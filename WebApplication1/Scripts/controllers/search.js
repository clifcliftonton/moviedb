angular.module('MovieDB', [])
    .controller('SearchController', ['$scope', '$http', function ($scope, $http) {

        var raw = {};
        var results = {};
        var temp = {};

        //GET: returns api data, up to 10 movies with similar titles to query
        $scope.search = function () {
            if ($scope.searchForm.query == null) {
                alert('cannot be undefined');
            } else {
                $http.get('http://www.omdbapi.com/?s=' + $scope.searchForm.query)
                    .then(function (response) {
                        raw = response.data.Search;
                        for (var i = 0; i < raw.length; i++) {
                            temp[i] = raw[i].imdbID;
                        }
                        fetch(0, i)
                    });
            }
        }

        //GET: returns api data, movie specific data from each movie in query
        function fetch(init, index) {
            if (init < index) {
                $http.get('http://www.omdbapi.com/?i=' + temp[init] + '&plot=short&r=json')
                    .then(function (response2) {
                        results[init] = response2.data;
                        fetch(init + 1, index)
                    });
            }
            $scope.results = results;
        }

        //POST: saves the selected movie into user's movie list.
        $scope.save = function (r) {
            var movie = {
                Poster: r.Poster,
                Title: r.Title,
                ReleaseYear: r.ReleaseYear,
                Rated: r.Rated,
                Runtime: r.Runtime,
                Genre: r.Genre,
                Director: r.Director,
                Actors: r.Actors,
                Plot: r.Plot,
                Country: r.Country,
                Imdbrating: r.Imdbrating,
                Type: r.Type
            }
            $http.post('/movie/add', movie)
                .then(function successCallback(response) {
                    if (response && response.data.Succeeded) {
                        alert('movie added!');
                    } else if (response && !response.data.Succeeded) {
                        alert(response.data.Message);
                    }
                }, function errorCallback(response) {
                    if (response && response.data && response.data.Errors) {
                        alert("Error occured within server.");
                    }
                }
            );
        }

    }]);
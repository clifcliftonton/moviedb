angular.module('MovieDB', [])
    .controller('ListController', ['$scope', '$http', '$window', function ($scope, $http, $window) {
        $http.post('/movies/getlist').then(function successCallback(response) {
            if (response && response.data.Succeeded) {
                $scope.results = response.data;
            } else if (response && !response.data.Succeeded) {
                alert(response.data.Message);
            }
        });


    }]);

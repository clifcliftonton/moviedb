angular.module('MovieDB', [])
    .controller('LoginController', ['$scope', '$http', '$window', function ($scope, $http, $window) {

        $scope.loginForm = {
            username: '',
            password: '',
            rememberMe: false
        };

        //Successful login redirects user to search page
        $scope.login = function () {
            $http.post('/account/login', $scope.loginForm)
                .then(function successCallBack(response) {
                    if (response && response.data.Succeeded) {
                        $window.location.href = '/movie/search';
                    } else if (response && !response.data.Succeeded) {
                        alert(reponse.data.Message);
                    }
                })
        }

    }]);

angular.module('MovieDB', [])
    .controller('RegisterController', ['$scope', '$http', '$window', function ($scope, $http, $window) {

        $scope.registerForm = {
            username: '',
            password: '',
            confirmPassword: ''
        };

        //Successful registration redirects user to the login page
        $scope.register = function () {
            if ($scope.registerForm.password == $scope.registerForm.confirmPassword) {
                $http.post('/account/register', $scope.registerForm)
                    .then(function successCallback(response) {
                        if (response && response.data.Succeeded) {
                            $window.location.href = '/account/login';
                        } else if (response && !response.data.Succeeded) {
                            alert(response.data.Message);
                        }
                    });
            } else {
                alert("Passwords do not match!");
            }
        }

    }]);

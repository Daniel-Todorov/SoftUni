'use strict';

app.controller('LoginController', ['$scope', '$location', '$timeout', 'utilitiesDataWorker', 'usersDataWorker',
    function ($scope, $location, $timeout, utilitiesDataWorker, usersDataWorker) {

        $scope.headerTitle = 'Ads Login';

        $scope.login = function (loginInfo) {

            usersDataWorker.login(loginInfo).then(function (data) {
                $scope.hasError = false;
                $scope.hasSuccess = true;
                $scope.successMessage = 'You have logged in successfully. You will be redirected to home page in 2 seconds.'

                $timeout(function () {
                    $location.path('/user/home');
                }, 2000);

            }, function (error) {
                console.log(error)
                $scope.hasError = true;
                $scope.errorMessage = error.error_description;
            });

            console.log(loginInfo);
        };


        $scope.dismissError = function () {
            $scope.hasError = false;
        };
    }]);
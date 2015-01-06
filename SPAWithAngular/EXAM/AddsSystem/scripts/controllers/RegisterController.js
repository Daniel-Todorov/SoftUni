'use strict';

app.controller('RegisterController', ['$scope', '$location', '$timeout', 'utilitiesDataWorker', 'usersDataWorker',
    function ($scope, $location, $timeout, utilitiesDataWorker, usersDataWorker) {

        $scope.headerTitle = 'Ads Registration';

        $scope.register = function (registerInfo) {

            usersDataWorker.register(registerInfo).then(function (data) {
                $scope.hasError = false;
                $scope.hasSuccess = true;
                $scope.successMessage = 'You have registered successfully. You will be redirected to home page in 2 seconds.'

                $timeout(function () {
                    $location.path('/user/home');
                }, 2000);

            }, function (error) {
                $scope.hasError = true;
                $scope.errorMessages = error.modelState[''];
            });

            console.log(registerInfo);

        };

        $scope.checkPasswordConfirmation = function(password, confirmPassword){
            if (password === confirmPassword) {
                return true;
            }

            return false;
        };

        $scope.dismissError = function () {
          $scope.hasError = false;
        };

        utilitiesDataWorker.getAllTowns().then(function (data) {
            $scope.towns = data;
        }, function (error) {
            console.log(error);
        });

    }]);
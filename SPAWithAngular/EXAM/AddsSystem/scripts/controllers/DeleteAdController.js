'use strict';

app.controller('DeleteAdController', ['$scope', '$location', '$window', '$routeParams', '$timeout', 'utilitiesDataWorker', 'usersDataWorker', 'adsDataWorker',
    function ($scope, $location, $window, $routeParams, $timeout, utilitiesDataWorker, usersDataWorker, adsDataWorker) {

        if (!usersDataWorker.isLogged()) {
            $location.path('/');
        }

        $scope.headerTitle = 'Ads - Delete Ad';
        $scope.selectedIndex = -1;
        $scope.publishInfo = {};

        adsDataWorker.getAdById($routeParams.id).then(function (data) {
            $scope.publishInfo = data;
        }, function (error) {
            console.log(error);
            $scope.hasError = true;
            $scope.hasSuccess = false;
            $scope.errorMessage = 'You cannot access the requested ad. Please, try again.';
        });

        $scope.deleteAd = function () {
            adsDataWorker.deleteAd($routeParams.id).then(function (data) {
                $scope.hasError = false;
                $scope.hasSuccess = true;
                $scope.successMessage = data.message + ' You will be redirected to your ads in 2 seconds.';

                $timeout(function () {
                    $location.path('/my-ads');
                }, 2000);
            }, function (error) {
                $scope.hasError = true;
                $scope.hasSuccess = false;
                $scope.errorMessage = error.message;
            })
        };

        $scope.cancel = function () {
            $location.path('/my-ads');
        };

        $scope.dismissError = function () {
            $scope.hasSuccess = false;
            $scope.hasError = false;
        };
    }]);
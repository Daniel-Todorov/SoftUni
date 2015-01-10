'use strict';

app.controller('EditAdController', ['$scope', '$location', '$window', '$routeParams', '$timeout', 'utilitiesDataWorker', 'usersDataWorker', 'adsDataWorker',
    function ($scope, $location, $window, $routeParams, $timeout, utilitiesDataWorker, usersDataWorker, adsDataWorker) {

        if (!usersDataWorker.isLogged()) {
            $location.path('/');
        }

        $scope.headerTitle = 'Ads - Edit Ad';
        $scope.selectedIndex = -1;
        $scope.publishInfo = {};

        utilitiesDataWorker.getAllCategories().then(function (data) {
            $scope.categories = data;
        }, function (error) {
            console.log(error);
        });

        utilitiesDataWorker.getAllTowns().then(function (data) {
            $scope.towns = data;
        }, function (error) {
            console.log(error);
        });

        adsDataWorker.getAdById($routeParams.id).then(function (data) {
            data.changeImage = false;
            $scope.publishInfo = data;
        }, function (error) {
            $scope.hasError = true;
            $scope.hasSuccess = false;
            $scope.errorMessage = 'You cannot access the requested ad. Please, try again.';
        });

        $scope.editAd = function (publishInfo) {
            console.log(publishInfo);

            adsDataWorker.editAd($routeParams.id, publishInfo).then(function (data) {
                $scope.hasError = false;
                $scope.hasSuccess = true;
                $scope.successMessage = data.message;
                $scope.isNewAdPublished = true;
            }, function (error) {
                console.log(error);

                $scope.hasError = true;
                $scope.hasSuccess = false;
                $scope.errorMessage = error.message;
            })
        };

        $scope.changeImage = function () {
            $scope.publishInfo.changeImage = true;
        };

        $scope.deleteImage = function () {
            $scope.publishInfo.changeImage = true;
            $scope.publishInfo.imageDataUrl = '';
            $scope.imageUrl = '';
        };

        $scope.getImageUrl = function (data) {
            $scope.imageUrl = data.value;
            $scope.$apply();
        };

        $scope.cancel = function () {
            $location.path('/my-ads');
        };

        $scope.dismissError = function () {
            $scope.hasSuccess = false;
            $scope.hasError = false;
        };
    }]);
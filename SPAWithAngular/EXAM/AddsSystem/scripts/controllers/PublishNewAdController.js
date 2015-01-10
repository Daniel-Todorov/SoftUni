'use strict';

app.controller('PublishNewAdController', ['$scope', '$location', '$window', '$timeout', 'utilitiesDataWorker', 'usersDataWorker', 'adsDataWorker',
    function ($scope, $location, $window, $timeout, utilitiesDataWorker, usersDataWorker, adsDataWorker) {

        if (!usersDataWorker.isLogged()) {
            $location.path('/');
        }

        $scope.headerTitle = 'Ads - Publish New Ad';
        $scope.selectedIndex = 2;
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

        $scope.publish = function (publishInfo) {
            console.log(publishInfo);

            adsDataWorker.createNewAd(publishInfo).then(function (data) {
                $scope.hasError = false;
                $scope.hasSuccess = true;
                $scope.successMessage = data.message + ' Once approved, it will be published.';
                $scope.isNewAdPublished = true;
            }, function (error) {
                $scope.hasError = true;
                $scope.hasSuccess = false;
                $scope.errorMessage = error.message;
            })
        };

        $scope.getImageUrl = function (data) {
            $scope.imageUrl = data.value;
            $scope.$apply();
        };

        $scope.publishNewAd = function () {
            $scope.publishInfo = {};
            $scope.isNewAdPublished = false;
            $scope.imageUrl = '';
            //$scope.$apply();
        };

        $scope.cancel = function () {
            $location.path('/user/home');
        };

        $scope.dismissError = function () {
            $scope.hasSuccess = false;
            $scope.hasError = false;
        };
    }]);
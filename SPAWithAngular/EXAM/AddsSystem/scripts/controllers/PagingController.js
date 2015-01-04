'use strict';

app.controller('PagingController', ['$scope',
    function ($scope) {

        $scope.changeSelectedPage = function (pageNumber) {
            $scope.filterOptions.startPage = pageNumber;
            $scope.filterAds();
        };

        $scope.goToFirst = function () {
            $scope.filterOptions.startPage = 1;
            $scope.filterAds();
        };

        $scope.goToPrevious = function () {
            if (parseInt($scope.filterOptions.startPage) > 1) {
                $scope.filterOptions.startPage = parseInt($scope.filterOptions.startPage) - 1;
                $scope.filterAds();
            }
        };

        $scope.goToNext = function () {
            if (parseInt($scope.filterOptions.startPage) < parseInt($scope.numPages)) {
                $scope.filterOptions.startPage = parseInt($scope.filterOptions.startPage) + 1;
                $scope.filterAds();
            }
        };

        $scope.goToLast = function () {
            $scope.filterOptions.startPage = $scope.numPages;
            $scope.filterAds();
        }
    }]);
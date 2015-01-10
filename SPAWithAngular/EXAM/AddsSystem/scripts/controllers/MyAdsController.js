'use strict';

app.controller('MyAdsController', ['$scope', '$location', '$window', 'usersDataWorker', 'adsDataWorker',
    function ($scope, $location, $window, usersDataWorker, adsDataWorker) {
        $scope.headerTitle = 'Ads - My Ads';
        $scope.selectedIndex = 1;

        $scope.isLogged = usersDataWorker.isLogged();

        if (usersDataWorker.isLogged()) {
            $scope.username = usersDataWorker.getCurrentUsername();
        } else {
            $location.path('/');
        }

        $scope.filterOptions = {
            startPage: 1,
            pageSize: 5,
            status: ''
        };

        $scope.filterAds = function () {
            adsDataWorker.getUserAds($scope.filterOptions).then(function (data) {
                console.log(data)

                $scope.ads = data.ads;
                $scope.numPages = data.numPages;
                $scope.pages = new Array(data.numPages);
            }, function (error) {
                alert('Error connecting to the database.');
                console.log(error);
            });
        };

        $scope.filterAds();

        $scope.deactivateAd = function (id) {
            adsDataWorker.deactivateAd(id).then(function (data) {
                console.log(data);
                $scope.hasSuccess = true;
                $scope.hasError = false;
                $scope.successMessage = data.message;
                $scope.filterAds();
            }, function (error) {
                console.dir(error);
                $scope.hasSuccess = false;
                $scope.hasError = true;
                $scope.errorMessage = 'Cannot deactivate this ad. Please, try again later.'
            })
        };

        $scope.publishAgainAd = function (id) {
            adsDataWorker.publishAgainAd(id).then(function (data) {
                console.log(data);
                $scope.hasSuccess = true;
                $scope.hasError = false;
                $scope.successMessage = data.message;
                $scope.filterAds();
            }, function (error) {
                console.dir(error);
                $scope.hasSuccess = false;
                $scope.hasError = true;
                $scope.errorMessage = 'Cannot republish this ad. Please, try again later.'
            })
        };

        $scope.goToEdit = function (id) {
            $location.path('edit-ad/' + id);
        };

        $scope.goToDelete = function (id) {
            $location.path('delete-ad/' + id);
        };

        $scope.dismissError = function () {
            $scope.hasError = false;
            $scope.hasSuccess = false;
        }
    }]);
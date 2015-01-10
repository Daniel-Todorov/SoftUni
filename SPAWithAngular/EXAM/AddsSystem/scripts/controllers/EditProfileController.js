'use strict';

app.controller('EditProfileController', ['$scope', '$location', '$window', '$routeParams', '$timeout', 'utilitiesDataWorker', 'usersDataWorker',
    function ($scope, $location, $window, $routeParams, $timeout, utilitiesDataWorker, usersDataWorker) {
        var profileOriginalInfo;

        if (!usersDataWorker.isLogged()) {
            $location.path('/');
        }

        $scope.headerTitle = 'Ads - Edit User Profile';
        $scope.selectedIndex = 3;

        utilitiesDataWorker.getAllTowns().then(function (data) {
            $scope.towns = data;
        }, function (error) {
            console.log(error);
        });

        usersDataWorker.getUserProfile().then(function (data) {
            profileOriginalInfo = JSON.parse(JSON.stringify(data));
            $scope.profileInfo = data;
        }, function (error) {
            $scope.hasError = true;
            $scope.hasSuccess = false;
            $scope.errorMessage = 'You cannot edit this profile. Please, try again.';
        });

        $scope.editProfile = function (profileInfo) {
            console.log(profileInfo);

            usersDataWorker.editProfile(profileInfo).then(function (data) {
                console.log(data);

                $scope.hasError = false;
                $scope.hasSuccess = true;
                $scope.successMessage = data.message;
                $scope.isNewAdPublished = true;
            }, function (error) {
                console.log(error);

                $scope.hasError = true;
                $scope.hasSuccess = false;
                $scope.errorMessage = error.message;
            });
        };

        $scope.editPassword = function (passwordInfo) {
            console.log(passwordInfo);

            usersDataWorker.changePassword(passwordInfo).then(function (data) {
                console.log(data);

                $scope.hasError = false;
                $scope.hasSuccess = true;
                $scope.successMessage = data.message;
                $scope.isNewAdPublished = true;
            }, function (error) {
                console.log(error);

                $scope.hasError = true;
                $scope.hasSuccess = false;
                $scope.errorMessage = error.message;
            });
        };

        $scope.cancel = function () {
            console.log(profileOriginalInfo)
            $scope.profileInfo = JSON.parse(JSON.stringify(profileOriginalInfo));
        };

        $scope.dismissError = function () {
            $scope.hasSuccess = false;
            $scope.hasError = false;
        };
    }]);
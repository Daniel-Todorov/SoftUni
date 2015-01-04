'use strict';

app.controller('TownsController', ['$scope', 'utilitiesDataWorker',
    function ($scope, utilitiesDataWorker) {

        $scope.changeSelectedTown = function (townId) {
            $scope.filterOptions.townId = townId;
            $scope.filterAds();
        };

        utilitiesDataWorker.getAllTowns().then(function (data) {
            var allOption = {id: '', name: 'All'};

            data.unshift(allOption);

            $scope.towns = data;
        }, function (error) {
            alert('Error connecting to the database.');
            console.log(error);
        })
    }]);
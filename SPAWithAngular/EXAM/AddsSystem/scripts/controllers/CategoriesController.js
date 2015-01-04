'use strict';

app.controller('CategoriesController', ['$scope', 'utilitiesDataWorker',
    function ($scope, utilitiesDataWorker) {

        $scope.changeSelectedCategory = function (categoryId) {
            $scope.filterOptions.categoryId = categoryId;
            $scope.filterAds();
        };

        utilitiesDataWorker.getAllCategories().then(function (data) {
            var allOption = {id: '', name: 'All'};

            data.unshift(allOption);

            $scope.categories = data;
        }, function (error) {
            alert('Error connecting to the database.');
            console.log(error);
        })
    }]);
'use strict';

app.controller('HomeController', ['$scope', 'usersDataWorker', 'utilitiesDataWorker',
    function ($scope, usersDataWorker, utilitiesDataWorker) {
        $scope.headerTitle = 'Ads Home';
        $scope.selectedIndex = 0;

        $scope.filterOptions = {
            startPage: 1,
            pageSize: 5,
            categoryId: '',
            townId: ''
        };

        if (usersDataWorker.isLogged()) {
            $scope.username = usersDataWorker.getCurrentUsername();
        }

        $scope.filterAds = function () {
            utilitiesDataWorker.getAllAds($scope.filterOptions).then(function (data) {
                console.log(data);

                $scope.ads = data.ads;
                $scope.numPages = data.numPages;
                $scope.pages = new Array(data.numPages);
            }, function (error) {
                alert('Error connecting to the database.');
                console.log(error);
            });
        };

        $scope.filterAds();
    }]);
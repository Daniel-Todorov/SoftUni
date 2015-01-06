'use strict';

app.controller('HeaderController', ['$scope', '$location', 'usersDataWorker',
    function ($scope, $location, usersDataWorker) {

        $scope.isLogged = usersDataWorker.isLogged();

        if (usersDataWorker.isLogged()) {
            $scope.username = usersDataWorker.getCurrentUsername();
        }

        $scope.filterOptions = {
            startPage: 1,
            pageSize: 5,
            categoryId: '',
            townId: ''
        };

        $scope.logout = function () {
            usersDataWorker.logout().then(function () {
                $location.path('/');
                $scope.isLogged = false;
            });
        }
    }]);
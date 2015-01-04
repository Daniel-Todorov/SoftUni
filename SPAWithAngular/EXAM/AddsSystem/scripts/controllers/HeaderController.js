'use strict';

app.controller('HeaderController', ['$scope', '$location', 'usersDataWorker',
    function ($scope, $location, usersDataWorker) {
        $scope.logout = function () {
            usersDataWorker.logout().then(function () {
                $location.path('/');
            });
        }
    }]);
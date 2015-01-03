'use strict';

app.controller('FooterController', ['$scope',
    function($scope) {
        $scope.year = new Date().getFullYear();
        $scope.author = 'Daniel Todorov';
        $scope.copyRights = 'All Rights Reserved';
    }]);
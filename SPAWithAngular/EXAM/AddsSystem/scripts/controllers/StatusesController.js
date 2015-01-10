'use strict';

app.controller('StatusesController', ['$scope',
    function ($scope) {

        $scope.statuses = [
            {
                id: '',
                name: 'All'
            },
            {
                id: 'Inactive',
                name: 'Inactive'
            },
            {
                id: 'WaitingApproval',
                name: 'Waiting Approval'
            },
            {
                id: 'Published',
                name: 'Published'
            }
        ];

        $scope.changeSelectedStatus = function (statusId) {
            $scope.filterOptions.status = statusId;
            $scope.filterAds();
        };
    }]);
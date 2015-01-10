'use strict';

app.controller('NavigationController', ['$scope',
    function ($scope) {
        var options = [
            {
                href: '#/',
                text: 'Home'
            },
            {
                href: '#/my-ads',
                text: 'My Ads'
            },
            {
                href: '#/publish-new-ad',
                text: 'Publish New Ad'
            },
            {
                href: '#/edit-profile',
                text: 'Edit Profile'
            }
        ];

        $scope.options = options;
    }]);
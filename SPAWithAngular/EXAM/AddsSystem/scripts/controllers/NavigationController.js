'use strict';

app.controller('NavigationController', ['$scope', '$location', 'usersDataWorker', 'utilitiesDataWorker',
    function ($scope, $location, usersDataWorker, utilitiesDataWorker) {
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
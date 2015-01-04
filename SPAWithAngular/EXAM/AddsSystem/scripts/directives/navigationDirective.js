"use strict";

app.directive('navigationDirective', function () {
    return {
        templateUrl: 'templates/directives/navigation.html',
        controller: 'NavigationController',
        replace: true
    }
});
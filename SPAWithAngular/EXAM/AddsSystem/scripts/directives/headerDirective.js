"use strict";

app.directive('headerDirective', function () {
    return {
        templateUrl: 'templates/directives/header.html',
        controller: 'HeaderController',
        replace: true
    }
});
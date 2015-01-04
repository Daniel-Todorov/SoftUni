"use strict";

app.directive('townsDirective', function () {
    return {
        templateUrl: 'templates/directives/towns.html',
        controller: 'TownsController',
        replace: true
    }
});
"use strict";

app.directive('statusesDirective', function () {
    return {
        templateUrl: 'templates/directives/statuses.html',
        controller: 'StatusesController',
        replace: true
    }
});
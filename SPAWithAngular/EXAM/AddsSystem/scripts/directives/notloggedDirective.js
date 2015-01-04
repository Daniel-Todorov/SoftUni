"use strict";

app.directive('notloggedDirective', function () {
    return {
        templateUrl: 'templates/directives/notlogged.html',
        controller: 'NotloggedController',
        replace: true
    }
});
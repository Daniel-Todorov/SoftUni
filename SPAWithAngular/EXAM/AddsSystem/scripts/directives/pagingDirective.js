"use strict";

app.directive('pagingDirective', function () {
    return {
        templateUrl: 'templates/directives/paging.html',
        controller: 'PagingController',
        replace: true
    }
});
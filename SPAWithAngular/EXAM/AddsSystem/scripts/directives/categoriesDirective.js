"use strict";

app.directive('categoriesDirective', function () {
    return {
        templateUrl: 'templates/directives/categories.html',
        controller: 'CategoriesController',
        replace: true
    }
});
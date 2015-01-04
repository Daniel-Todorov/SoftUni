"use strict";

app.directive('footerDirective', function () {
    return {
        templateUrl: 'templates/directives/footer.html',
        controller: 'FooterController',
        replace: true
    }
});
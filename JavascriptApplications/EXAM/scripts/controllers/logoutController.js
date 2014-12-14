"use strict";

app.logoutController = (function () {

    function initialize() {
        app.userSession.logout();
        app.headerController.display();
        app.homeController.initialize();
        app.notificationsController.showNotification('You logged off!', true);
    }

    return {
        initialize: initialize
    }
}());
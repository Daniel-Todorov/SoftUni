"use strict";

app.headerController = (function () {
    var _headerSelector = '.header-main',
        _$header;

    function initialize() {

        if (!app.utils.isDefined(_$header)) {
            _$header = $(_headerSelector);
        }

        bindNavLinks();

        display();
    }

    function display() {
        var $unauthorisedNav = _$header.find('.unauthorised-nav'),
            $authorisedNav = _$header.find('.authorised-nav'),
            isLogged = app.userSession.isLogged();

        if(isLogged) {
            $unauthorisedNav.hide();
            $authorisedNav.show();
        } else {
            $authorisedNav.hide();
            $unauthorisedNav.show();
        }
    }

    function bindNavLinks() {
        _$header.on('click', '.home-nav-button', function () {
            console.log('going to home view');
            app.homeController.initialize();
        });

        _$header.on('click', '.login-nav-button', function () {
            console.log('going to login view');
            app.loginController.initialize();
        });

        _$header.on('click', '.register-nav-button', function () {
            console.log('going to register view');
            app.registerController.initialize();
        });

        _$header.on('click', '.products-nav-button', function () {
            console.log('going to products');
            app.productsController.initialize();
        });

        _$header.on('click', '.add-nav-button', function () {
            console.log('going to add product');
            app.addController.initialize();
        });

        _$header.on('click', '.logout-nav-button', function () {
            console.log('logging out');
            app.logoutController.initialize();
        });
    }

    return {
        initialize: initialize,
        display: display
    }
}());
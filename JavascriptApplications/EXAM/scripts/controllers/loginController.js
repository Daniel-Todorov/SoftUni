"use strict";

app.loginController = (function () {
    var _loginViewSelector = '.login-view',
        _loginFormSelector = '.login-form',
        _$loginForm,
        _$loginView;

    function initialize () {

        if (!app.utils.isDefined(_$loginView) || !app.utils.isDefined(_$loginForm)) {
            _$loginView = $(_loginViewSelector);
            _$loginForm = $(_loginFormSelector);

            _$loginForm.on('click', '#login-button', function (event) {
                event.preventDefault();

                login();
            });

            _$loginForm.on('click', '.register-nav-button', function (event) {
                event.preventDefault();

                console.log('going to register view');
                app.registerController.initialize();
            })
        }

        app.utils.displaySection(_$loginView);
    }

    function login() {
        var $usernameInput = _$loginForm.find('#username'),
            username = $usernameInput.val(),
            $passwordInput = _$loginForm.find('#password'),
            password = $passwordInput.val();

        app.ajaxRequester.login(username, password, authSuccess, loginError);
    }

    function authSuccess(data) {
        _$loginForm.find('input').val('');

        app.userSession.login(data);

        app.homeController.initialize();
        app.headerController.display();
        app.notificationsController.showNotification('Login successful!', true)

    }

    function loginError(error) {
        console.log('Login error: ' + error.responseText);

        app.notificationsController.showNotification('Login failed! Please, try again and check the console for more details.', false)
    }

    return {
        initialize: initialize
    }
}());
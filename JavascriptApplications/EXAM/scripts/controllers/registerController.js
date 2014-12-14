"use strict";

app.registerController = (function () {
    var _registerViewSelector = '.register-view',
        _registerFormSelector = '.register-form',
        _$registerForm,
        _$registerView;

    function initialize () {

        if (!app.utils.isDefined(_$registerView) || !app.utils.isDefined(_$registerForm)) {
            _$registerView = $(_registerViewSelector);
            _$registerForm = $(_registerFormSelector);

            _$registerForm.on('click', '#register-button', function (event) {
                event.preventDefault();

                register();
            });

            _$registerForm.on('click', '.login-nav-button', function (event) {
                event.preventDefault();

                console.log('going to login view');
                app.loginController.initialize();
            })
        }

        app.utils.displaySection(_$registerView);
    }

    function register() {
        var $usernameInput = _$registerForm.find('#username'),
            username = $usernameInput.val(),
            $passwordInput = _$registerForm.find('#password'),
            password = $passwordInput.val(),
            $confirmedPasswordInput = _$registerForm.find('#confirm-password'),
            confirmPassword = $confirmedPasswordInput.val();

        if (password !== confirmPassword) {
            app.notificationsController.showNotification('Passwords must be identical.', false);
            return;
        }

        app.ajaxRequester.register(username, password, registerSuccess, registerError);
    }

    function registerSuccess(data) {
        _$registerForm.find('input').val('');

        app.loginController.initialize();
        app.notificationsController.showNotification('Registration successful! Please, log in.', true)
    }

    function registerError(error) {
        console.log('Registration error: ' + error.responseText);
        app.notificationsController.showNotification('Registration failed! Please, try again and check the console for more details.', false)
    }


    return {
        initialize: initialize
    }
}());
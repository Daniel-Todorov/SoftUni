"use strict";

app.homeController = (function () {
    var _authViewSelector = '.welcome-authorised-view',
        _unauthViewSelector = '.welcome-unauthorised-view',
        _homeViewSelector = '.welcome-view',
        _$homeView,
        _$authHomeView,
        _$unauthHomeView;

    function initialize() {

        if(!app.utils.isDefined(_$authHomeView) || !app.utils.isDefined(_$unauthHomeView)) {
            _$homeView = $(_homeViewSelector);
            _$authHomeView = $(_authViewSelector);
            _$unauthHomeView = $(_unauthViewSelector);

            _$unauthHomeView.on('click', '.login-nav-button', function () {
                console.log('going to login view');
                app.loginController.initialize();
            })
        }

        app.utils.displaySection(_$homeView);

        if(app.userSession.isLogged()) {
            var loggedUsername = app.userSession.getCurrentUser().username,
                $usernamePanel = _$authHomeView.find('.username-panel');

            _$unauthHomeView.hide();
            _$authHomeView.show();

            $usernamePanel.text(loggedUsername);
        } else {
            _$authHomeView.hide();
            _$unauthHomeView.show();
        }
    }

    return {
        initialize: initialize
    }
}());
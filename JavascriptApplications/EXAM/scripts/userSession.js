'use strict'

app.userSession = (function () {

    function login(data)
    {
        sessionStorage['currentUser'] = JSON.stringify(data);
    }

    function getCurrentUser() {
        var userData = sessionStorage['currentUser'];
        if (userData) {
            return JSON.parse(sessionStorage['currentUser']);
        }
    }

    function logout() {
        delete sessionStorage['currentUser'];
    }

    function isLogged() {
        var userData = sessionStorage['currentUser'];
        if (userData) {
            return true;
        } else {
            return false;
        }
    }

    return {
        login: login,
        getCurrentUser: getCurrentUser,
        isLogged: isLogged,
        logout: logout
    }
}());
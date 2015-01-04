'use strict';

app.factory('usersDataWorker', ['$http', '$q', 'baseServiceUrl',
    function ($http, $q, baseServiceUrl) {
        var usersApi = baseServiceUrl + 'user/',
            loginApi = usersApi + 'login',
            registerApi = usersApi + 'register',
            changePasswordApi = usersApi + 'changePassword',
            profileApi = usersApi + 'profile';

        function login(loginInfo) {
            var deferred = $q.defer();

            $http.post(loginApi, loginInfo)
                .success(function (data) {
                    var dataObject = JSON.parse(data);

                    dataObject.username = loginInfo.username;

                    sessionStorage.currentUser = JSON.stringify(dataObject);

                    deferred.resolve(data);
                }).error(function (error) {
                    deferred.reject(error);
                });

            return deferred.promise;
        }

        function logout() {
            var deferred = $q.defer();

            deferred.resolve(sessionStorage.removeItem('currentUser'));

            return deferred.promise;
        }

        function register(registerInfo) {
            var deferred = $q.defer();

            $http.post(registerApi, registerInfo)
                .success(function (data) {
                    var dataObject = JSON.parse(data);

                    dataObject.username = registerInfo.username;

                    sessionStorage.currentUser = JSON.stringify(dataObject);

                    deferred.resolve(data);
                }).error(function (error) {
                    deferred.reject(error)
                });

            return deferred.promise;
        }

        function changePassword(oldPassword, newPassword, confirmPassword) {
            var deferred = $q.defer();

            $http.delete(changePasswordApi, {
                data: {
                    oldPassword: oldPassword, newPassword: newPassword, confirmPassword: confirmPassword
                },
                headers: getAuthorizationHeader()
            })
                .success(function (data) {
                    deferred.resolve(data);
                }).error(function (error) {
                    deferred.reject(error);
                });

            return deferred.promise;
        }

        function getUserProfile() {
            var deferred = $q.defer();

            $http.get(profileApi, {
                headers: getAuthorizationHeader()
            })
                .success(function (data) {
                    deferred.resolve(data);
                }).error(function (error) {
                    deferred.reject(error);
                });

            return deferred.promise;
        }

        function editProfile(profileInfo) {
            var deferred = $q.defer();

            $http.put(profileApi, profileInfo, {
                headers: getAuthorizationHeader()
            })
                .success(function (data) {
                    deferred.resolve(data);
                }).error(function (error) {
                    deferred.reject(error);
                });

            return deferred.promise;
        }

        function getCurrentUsername() {
            return JSON.parse(sessionStorage.currentUser).username;
        }

        function getAuthorizationHeader() {
            return {
                'Authorization': 'Bearer ' + JSON.parse(sessionStorage.currentUser).access_token
            };
        }

        function isLogged() {
            if (sessionStorage.currentUser && !!JSON.parse(sessionStorage.currentUser)) {
                return true;
            }

            return false;
        }

        function isAdmin() {
            if (sessionStorage.currentUser && !!JSON.parse(sessionStorage.currentUser).isAdmin) {
                return true;
            }

            return false;
        }

        return {
            login: login,
            logout: logout,
            register: register,
            changePassword: changePassword,
            getUserProfile: getUserProfile,
            editProfile: editProfile,
            isLogged: isLogged,
            isAdmin: isAdmin,
            getCurrentUsername: getCurrentUsername,
            getAuthorizationHeader: getAuthorizationHeader
        };
    }]);
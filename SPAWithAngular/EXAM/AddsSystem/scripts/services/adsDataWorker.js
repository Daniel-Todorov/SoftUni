'use strict';

app.factory('adsDataWorker', ['$http', '$q', 'usersDataWorker', 'baseServiceUrl',
    function ($http, $q, usersDataWorker, baseServiceUrl) {
        var adsApi = baseServiceUrl + 'user/ads/';

        function createNewAd(newAddInfo) {
            var deferred = $q.defer();

            $http.post(adsApi, newAddInfo, {
                headers: usersDataWorker.getAuthorizationHeader()
            })
                .success(function (data) {
                    deferred.resolve(data);
                }).error(function (error) {
                   deferred.reject(error);
                });

            return deferred.promise;
        }

        function getUserAds(filterOptions) {
            var deferred = $q.defer();

            $http.get(adsApi, {
                headers: usersDataWorker.getAuthorizationHeader(),
                params: filterOptions
            })
                .success(function (data) {
                    deferred.resolve(data);
                }).error(function (error) {
                    deferred.reject(error);
                });

            return deferred.promise;
        }

        function deactivateAd(id) {
            var deferred = $q.defer();

            $http.put(adsApi + 'deactivate/' + id, {}, {
                headers: usersDataWorker.getAuthorizationHeader()
            })
                .success(function (data) {
                    deferred.resolve(data);
                }).error(function (error) {
                    deferred.reject(error);
                });

            return deferred.promise;
        }

        function publishAgainAd(id) {
            var deferred = $q.defer();

            $http.put(adsApi + 'publishagain/' + id, {}, {
                headers: usersDataWorker.getAuthorizationHeader()
            })
                .success(function (data) {
                    deferred.resolve(data);
                }).error(function (error) {
                    deferred.reject(error);
                });

            return deferred.promise;
        }

        function getAdById(id) {
            var deferred = $q.defer();

            $http.get(adsApi + id, {
                headers: usersDataWorker.getAuthorizationHeader()
            })
                .success(function (data) {
                    deferred.resolve(data);
                }).error(function (error) {
                    deferred.reject(error);
                });

            return deferred.promise;
        }

        function editAd(id, newAddInfo) {
            var deferred = $q.defer();

            $http.put(adsApi + id, newAddInfo, {
                headers: usersDataWorker.getAuthorizationHeader()
            })
                .success(function (data) {
                    deferred.resolve(data);
                }).error(function (error) {
                    deferred.reject(error);
                });

            return deferred.promise;
        }

        function deleteAd(id) {
            var deferred = $q.defer();
            
            $http.delete(adsApi + id, {
                headers: usersDataWorker.getAuthorizationHeader()
            })
                .success(function (data) {
                    deferred.resolve(data);
                }).error(function (error) {
                    deferred.resolve(error);
                });

            return deferred.promise;
        }

        return {
            createNewAd: createNewAd,
            getUserAds: getUserAds,
            deactivateAd: deactivateAd,
            publishAgainAd: publishAgainAd,
            getAdById: getAdById,
            editAd: editAd,
            deleteAd: deleteAd
        };
    }]);
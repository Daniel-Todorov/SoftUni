'use strict';

app.factory('utilitiesDataWorker', ['$http', '$q', 'baseServiceUrl',
    function ($http, $q, baseServiceUrl) {
        var adsApi = baseServiceUrl + 'ads',
            categoriesApi = baseServiceUrl + 'categories',
            townsApi = baseServiceUrl + 'towns';

        function getAllAds(filterOptions) {
            var deferred = $q.defer();

            $http.get(adsApi, {
                params: filterOptions
            })
                .success(function (data) {
                    deferred.resolve(data);
                }).error(function (error) {
                    deferred.reject(error);
                });

            return deferred.promise;
        }

        function getAllCategories() {
            var deferred = $q.defer();

            $http.get(categoriesApi)
                .success(function (data) {
                    deferred.resolve(data);
                }).error(function (error) {
                    deferred.reject(error)
                });

            return deferred.promise;
        }

        function getAllTowns() {
            var deferred = $q.defer();

            $http.get(townsApi)
                .success(function (data) {
                    deferred.resolve(data);
                }).error(function (error) {
                    deferred.reject(error)
                });

            return deferred.promise;
        }

        return {
            getAllAds: getAllAds,
            getAllCategories: getAllCategories,
            getAllTowns: getAllTowns
        };
    }]);
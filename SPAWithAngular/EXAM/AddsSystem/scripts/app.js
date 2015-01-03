'use strict';

var app = angular.module('myApp', ['ngRoute', 'ngResource']).
    config(['$routeProvider', function($routeProvider) {
        $routeProvider
            .when('/', {
                templateUrl: 'templates/home.html',
                controller: 'HomeController'
            })
            .when('/login', {
                templateUrl: 'templates/login.html',
                controller: 'LoginController'
            })
            .when('/register', {
                templateUrl: 'templates/register.html',
                controller: 'RegisterController'
            })
            .when('/publish-new-ad', {
                templateUrl: 'templates/publish-new-ad.html',
                controller: 'PublishNewAdController'
            })
            .when('/my-ads', {
                templateUrl: 'templates/my-ads.html',
                controller: 'MyAdsController'
            })
            .when('/edit-ad/:id', {
                templateUrl: 'templates/edit-ad.html',
                controller: 'EditAdController'
            })
            .when('/delete-ad/:id', {
                templateUrl: 'templates/delete.html',
                controller: 'DeleteAdController'
            })
            .when('/edit-profile', {
                templateUrl: 'templates/edit-profile.html',
                controller: 'EditProfileController'
            })
            .otherwise({ redirectTo: '/' });
    }])
    .constant('baseServiceUrl', 'http://softuni-ads.azurewebsites.net/api/');
var app = angular.module('myApp', ['ui.router']);

app.config(function ($stateProvider, $urlRouterProvider) {

    $urlRouterProvider.otherwise('/home');

    $stateProvider

        // HOME STATES AND NESTED VIEWS ========================================
        .state('home', {
            url: '/home',
            templateUrl: '/myApp/pages/home/home.html'
        })

        .state('login', {
            url: '/login',
            templateUrl: '/myApp/pages/login/login.html'
        })
    .state('allevents', {
        url: '/allevents',
        templateUrl: '/myApp/pages/allevents/allevents.html'
    })
    .state('createevent', {
        url: '/createevent',
        templateUrl: '/myApp/pages/createevent/createevent.html'
    });

});
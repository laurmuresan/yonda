(function () {
    'use strict';

    angular
        .module('myApp')
        .factory('AlleventsService', AlleventsService);

    AlleventsService.$inject = ['$http'];
    function AlleventsService($http) {

        var service = {};

        service.getEvents = function () {
            $http({
                method: 'Get',
                url: 'http://localhost:51427/api/account/allevents'
            }).then(function (result) {
                console.log("succes");

            }).catch(function (result) {
                console.log("error");
            });
        };

        return service;
    }
})();
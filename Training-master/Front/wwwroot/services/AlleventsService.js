(function () {
    'use strict';

    angular
        .module('myApp')
        .factory('AlleventsService', AlleventsService);

    AlleventsService.$inject = ['$http'];
    function AlleventsService($http) {

        var service = {};

        service.getEvents = function () {
            return $http({
                method: 'Get',
                url: 'http://localhost:51427/api/event/allevents'
            });
        };

        return service;
    }
})();
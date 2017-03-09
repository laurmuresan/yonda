(function () {
    'use strict';

    angular
        .module('myApp')
        .factory('UpdateEventService', UpdateEventService);

    UpdateEventService.$inject = ['$http'];
    function UpdateEventService($http) {
        var service = {};

        service.UpdateEvent = function (date, price, location, name, callback) {
            var response
            $http({
                method: 'Post',
                url: 'http://localhost:51427/api/updateevent/updateevent',
                data: {
                    'Date': date,
                    'Price': price,
                    'Location': location,
                    'Name': name

                }
            }).then(function (result) {
                if (result.status = "200") {
                    response = { success: true };
                } else {
                    response = { success: false };
                }
                callback(response);

            }).catch(function (result) {
                response = {
                    success: false
                }
                callback(response)
            });
        };


        return service;

    }
})();
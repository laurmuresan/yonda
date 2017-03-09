(function () {
    'use strict';

    angular
        .module('myApp')
        .factory('CreateEventService', CreateEventService);

    CreateEventService.$inject = ['$http'];
    function CreateEventService($http) {
        var service = {};

        service.CreateEvent = function (date, price, location, name, callback) {
            var response
            $http({
                method: 'Post',
                url: 'http://localhost:51427/api/createevent/createevent',
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
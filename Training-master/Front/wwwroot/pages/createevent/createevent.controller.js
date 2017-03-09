app.controller('CreateEventController', ["$http", "CreateEventService",
        function ($http, CreateEventService) {
            var vm = this;
            vm.date = "";
            vm.price = "";
            vm.location = "";
            vm.name = "";
            vm.goCreateEvent = function () {
                CreateEventService.CreateEvent(vm.date, vm.price, vm.location, vm.name, function (response) {
                    if (response.success) {
                        alert("The event was created");
                    } else {
                        alert("Failed to create the event");
                    }
                });
            };
        }

]);
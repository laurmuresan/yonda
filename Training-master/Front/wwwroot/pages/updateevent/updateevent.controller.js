app.controller('UpdateEventController', ["$http", "UpdateEventService",
        function ($http, UpdateEventService) {
            var vm = this;
            vm.date = "";
            vm.price = "";
            vm.location = "";
            vm.name = "";
            vm.goUpdateEvent = function () {
                UpdateEventService.UpdateEvent(vm.date, vm.price, vm.location, vm.name, function (response) {
                    if (response.success) {
                        alert("The event was updated");
                    } else {
                        alert("Failed to update the event");
                    }
                });
            };
        }

]);
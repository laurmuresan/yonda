app.controller('AlleventsController', ["$http", 'ngDialog', "AlleventsService",
    function ($scope, ngDialog, AlleventsService) {
        var self = this;
        this.events = [];
        AlleventsService.getEvents().then(function (result) {

            self.events = self.events.concat(result.data);
        });
        self.openCreateEventForm = function () {
            return ngDialog.open({
                template: '/myApp/pages/createevent/createevent.html'

            })
        };
        self.openUpdateEventForm = function (e) {
            console.log(e);
            return ngDialog.open({
                template: '/myApp/pages/updateevent/updateevent.html',
                controller: 'UpdateEventController',
                resolve: {
                    inputData: function () {
                        return e;
                    }
                }
            })
        };
    }
])
    .directive('allEventsDirective', function () {
        return {
            restrict: 'E',
            templateUrl: '/myApp/pages/allevents/alleventsdirective.html',
            scope: {
                eventItem: '='
            },
            link: function (scope, element) {
                //  console.log(scope.eventItem);
                scope.$watch(function () { return scope.eventItem; });
            }
        };
    });


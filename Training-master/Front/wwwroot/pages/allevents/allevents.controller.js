app.controller('AlleventsController', ["$http", "AlleventsService",
    function ($scope, AlleventsService) {
        var self = this;
        this.events = [];
        AlleventsService.getEvents().then(function (result) {

            self.events = self.events.concat(result.data);
        });
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
                scope.$watch(function () { return scope.eventItem; }, function (oldvalue, newValue) { console.log(newValue); });
            }
        };
    });

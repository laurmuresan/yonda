app.controller('AlleventsController', ["$http", "AlleventsService",
    function ($scope, AlleventService) {
        AlleventService.getEvents().then(function (result) {
            $scope.events = result.data;
        });
    }
    ])
    .directive('AlleventsDirective', function () {
    return {
        templateURL: '/myApp/pages/allevents/alleventsdirective.html',
        scope: {
            eventItem:'='
        }
    };
});
    
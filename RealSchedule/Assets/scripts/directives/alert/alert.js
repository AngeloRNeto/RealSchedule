app.directive('alert', function () {
    return {
        scope: {},
        restrict: 'E',
        templateUrl: 'alert.html',
        controller: ['$scope', function ($scope) {
            console.log('Angelo');
        }],
    };
});
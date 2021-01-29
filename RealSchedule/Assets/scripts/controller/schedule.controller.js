(function (angular) {

    'use strict';

    angular.module('app.controllers').controller('ScheduleController', ScheduleController);

    ScheduleController.$inject = ['$scope', 'ScheduleBusiness'];

    function ScheduleController($scope, scheduleBO) {
        $scope.eventSchedule = 'Nova Agenda';

        $scope.addEventOrSchedule = function () {
            if (!$scope.hasSchedule) {
                $scope.schedule = { Nome:'Agenda', UserId:sessionStorage.getItem('IdUser') }
                scheduleBO.createSchedule($scope.schedule, function (res) {
               
                });
            }
            else {
              //tela pra ver os eventos
            }

        };

    }

})(angular);
(function () {

    'use strict';

    angular.module('app.repositories').factory('ScheduleRepository', ScheduleRepository);

    function ScheduleRepository() {

        this.CreateSchedule = function (data, _callback) {
            let schedule = JSON.stringify({ 'schedule': data });
            $.ajax({
                contentType: 'application/json; charset=utf-8',
                dataType: 'json',
                type: "POST",
                url: "/Home/CreateSchedule",
                data: schedule,
                success: function (result) {
                    if (result)
                        _callback && _callback(result);
                }
            });
        };

        return this;
    }

})();
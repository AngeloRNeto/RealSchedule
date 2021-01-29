(function () {

    'use strict';

    angular.module('app.repositories').factory('HomeRepository', HomeRepository);

    function HomeRepository() {

        this.GetAll = function (_callback) {
            $.ajax({
                url: "/Home/GetParameters",
                success: function (result) {
                    if (result)
                        _callback && _callback(result);
                }
            });
        };

        this.SaveUser = function (data, _callback) {
            let usuario = JSON.stringify({ 'usuario': data });
            $.ajax({
                contentType: 'application/json; charset=utf-8',
                dataType: 'json',
                type: "POST",
                url: "/Home/SaveUser",
                data: usuario,
                success: function (result) {
                    if (result)
                        _callback && _callback(result);
                }
            });
        };

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
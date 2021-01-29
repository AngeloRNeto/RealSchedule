(function (angular) {

    'use strict';

    angular.module('app.business').factory('ScheduleBusiness', ScheduleBusiness);

    ScheduleBusiness.$inject = ['ScheduleRepository'];

    function ScheduleBusiness(repository) {

        this.validate = function (model) {

            if (!model.valor || model.valor == "") {
                alert("Valor é obrigatório para o cálculo!");
                return false;
            }

            if (!model.data || model.data == "") {
                alert("Data é obrigatório para o cálculo!");
                return false;
            }

            if (!model.parcelas || model.parcelas == "") {
                alert("Número de parcelas é obrigatório!");
                return false;
            }

            return true;
        }

        this.createSchedule = function (schedule, _callback) {
            repository.CreateSchedule(schedule,function (res) {
                if(res)
                _callback && _callback(res);
            });
        }

        return this;
    }
    
})(angular);
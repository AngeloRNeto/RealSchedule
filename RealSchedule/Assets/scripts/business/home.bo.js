(function (angular) {

    'use strict';

    angular.module('app.business').factory('HomeBusiness', HomeBusiness);

    HomeBusiness.$inject = ['HomeRepository'];

    function HomeBusiness(repository) {

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

        this.getParameters = function (_callback) {
            repository.GetAll(function (res) {
                if(res)
                _callback && _callback(res);
            });
        }

        this.saveUser = function (user, _callback) {
            repository.SaveUser(user,function (res) {
                if(res)
                _callback && _callback(res);
            });
        }

        return this;
    }



})(angular);
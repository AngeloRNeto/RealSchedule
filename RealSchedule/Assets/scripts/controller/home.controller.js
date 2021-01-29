(function (angular) {

    'use strict';

    angular.module('app.controllers').controller('HomeController', HomeController);

    HomeController.$inject = ['$scope', 'HomeBusiness'];

    function HomeController($scope, homeBO) {

        $scope.checkLogin = function () {
            homeBO.alert($scope.login)
        };

        $scope.clear = function () {
            $scope.login = {};
            $scope.sign = {};
        };

        $scope.saveAndLogin = function () {
            homeBO.saveUser($scope.sign, function (res) {
                sessionStorage.setItem('IdUser', res);
                window.location.href = "/Schedule";
            });
        };

    }

})(angular);
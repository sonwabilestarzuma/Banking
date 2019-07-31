// bankDetailsController.js

(function () {

    "use strict";

    // Getting the existing module
    angular.module("app-bankDetails")
        .controller("bankDetailsController", bankDetailsController);

    function bankDetailsController($http) {

        var vm = this;
        vm.bankDetails = [];

        vm.newBankDetails = {};

        vm.errorMessage = "";
        vm.isBusy = true;

        $http.get("/api/BankDetails")
            .then(function (response) {
                // Success
                angular.copy(response.data, vm.bankDetails );
            }, function (error) {
                // Failure
                vm.errorMessage = "Failed to load data: " + error;
            })
            .finally(function () {
                vm.isBusy = false;
            });


    }

})();
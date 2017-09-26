(function () {

  "use strict";

  // Creating the Module
  angular.module("appTrips2", ["simpleControls", "ngRoute"])
    .config(function ($routeProvider) {
      var x = "thing";

      $routeProvider.when("/", {
        controller: "tripsController",
        controllerAs: "vm",
        templateUrl: "/views/tripsView.html"
      });

      $routeProvider.otherwise({ redirectTo: "/" });

    });

})();
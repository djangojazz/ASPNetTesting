﻿// trips.js
(function () {

  "use strict";

  // Creating the Module
  angular.module("trips", ["simpleControls", "ngRoute"]);
    .config(function ($routeProvider) {

    $routeProvider.when("/", {
      controller: "tripsC",
      controllerAs: "vm",
      templateUrl: "/views/tripsView.html"
    });

    $routeProvider.otherwise({ redirectTo: "/" });

  });

})();
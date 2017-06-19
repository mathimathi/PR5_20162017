 var app = angular.module("app", ['ngResource']);
 app.factory("deckservice", function ($resource) {
     return $resource('http://localhost:24842/api/deck/:deck', {
         deck: "@deck"
     });
 });

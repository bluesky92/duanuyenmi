var app = angular.module('myShoppingList', []);
app.controller('myCtrl', function ($scope, $http) {
    $scope.getNd = function () {
        $http.get("/Controllers/HomeAngular/GetSP").then(function (response) {
            $scope.products = response.data;
            console.log($scope.products);
        })
    }
})
var app = angular.module('myapp', []);
app.controller("get", function ($scope, $http) {
    $http({
        method: 'GET',
        url: '/sanphams/index1'
    }).then(function successCallback(response) {
        $scope.list = response.data;
    });
})
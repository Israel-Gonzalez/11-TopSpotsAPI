var app = angular.module('myApp', []);
app.controller('myCtrl', function($scope, $http) {
    $http({
        url: 'http://localhost:53801/api/TopSpot/',
        dataType: 'json',
        method: 'POST',
        data: ''
    }).then(function(response) {
        $scope.spots = response.data;
    });
});

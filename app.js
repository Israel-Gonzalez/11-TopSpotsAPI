var app = angular.module('myApp', []);
app.controller('myCtrl', function($scope, $http) {
	$http.get('topspots.json').then(function (response) {
			$scope.spots = response.data;
	});
});


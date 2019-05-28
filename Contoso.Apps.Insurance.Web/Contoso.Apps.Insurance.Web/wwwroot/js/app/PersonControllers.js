 var  modules = modules || [];
(function () {
    'use strict';
    //modules.push('Person');

    var rootPath = contoso.policyconnect.vars.rootPath;


    angular.module('policyConnect')
    .controller('Person_list', ['$scope', '$http', function($scope, $http){
        $http.defaults.useXDomain = true;
        delete $http.defaults.headers.common['X-Requested-With'];

        $http.get(rootPath + '/Api/People/')
        .then(function(response){$scope.data = response.data;});

    }])
    .controller('Person_details', ['$scope', '$http', '$routeParams', function($scope, $http, $routeParams){
        $http.defaults.useXDomain = true;
        delete $http.defaults.headers.common['X-Requested-With'];

        $http.get(rootPath + '/Api/People/' + $routeParams.id)
        .then(function(response){$scope.data = response.data;});

    }])
    .controller('Person_create', ['$scope', '$http', '$routeParams', '$location', function($scope, $http, $routeParams, $location){
        $http.defaults.useXDomain = true;
        delete $http.defaults.headers.common['X-Requested-With'];

        $scope.data = {};
        
        $scope.save = function(){
            $http.post(rootPath + '/Api/People/', $scope.data)
            .then(function(response){ $location.path("Person"); });
        }

    }])
    .controller('Person_edit', ['$scope', '$http', '$routeParams', '$location', function($scope, $http, $routeParams, $location){
        $http.defaults.useXDomain = true;
        delete $http.defaults.headers.common['X-Requested-With'];

        $http.get(rootPath + '/Api/People/' + $routeParams.id)
        .then(function(response){$scope.data = response.data;});

        
        $scope.save = function(){
            $http.post(rootPath + '/Api/People/', $scope.data)
            .then(function(response){ $location.path("Person"); });
        }

    }])
    .controller('Person_delete', ['$scope', '$http', '$routeParams', '$location', function($scope, $http, $routeParams, $location){
        $http.defaults.useXDomain = true;
        delete $http.defaults.headers.common['X-Requested-With'];

        $http.get(rootPath + '/Api/People/' + $routeParams.id)
        .then(function(response){$scope.data = response.data;});
        $scope.save = function(){
            $http.delete(rootPath + '/Api/People?personId=' + $routeParams.id, $scope.data)
            .then(function(response){ $location.path("Person"); });
        }

    }]);

})();

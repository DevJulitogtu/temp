﻿ var  modules = modules || [];
(function () {
    'use strict';
    //modules.push('Policy');

    var rootPath = contoso.policyconnect.vars.rootPath;

    angular.module('policyConnect')
    .controller('Policy_list', ['$scope', '$http', function($scope, $http){
        $http.defaults.useXDomain = true;
        delete $http.defaults.headers.common['X-Requested-With'];

        $http.get(rootPath + '/Api/Policies/')
        .then(function(response){$scope.data = response.data;});

    }])
    .controller('Policy_details', ['$scope', '$http', '$routeParams', function($scope, $http, $routeParams){
        $http.defaults.useXDomain = true;
        delete $http.defaults.headers.common['X-Requested-With'];

        $http.get(rootPath + '/Api/Policies/' + $routeParams.id)
        .then(function(response){$scope.data = response.data;});

    }])
    .controller('Policy_create', ['$scope', '$http', '$routeParams', '$location', function($scope, $http, $routeParams, $location){
        $http.defaults.useXDomain = true;
        delete $http.defaults.headers.common['X-Requested-With'];

        $scope.data = {};
        
        $scope.save = function(){
            $http.post(rootPath + '/Api/Policies/', $scope.data)
            .then(function(response){ $location.path("Policy"); });
        }

    }])
    .controller('Policy_edit', ['$scope', '$http', '$routeParams', '$location', function($scope, $http, $routeParams, $location){
        $http.defaults.useXDomain = true;
        delete $http.defaults.headers.common['X-Requested-With'];

        $http.get(rootPath + '/Api/Policies/' + $routeParams.id)
        .then(function(response){$scope.data = response.data;});

        
        $scope.save = function(){
            $http.post(rootPath + '/Api/Policies/', $scope.data)
            .then(function(response){ $location.path("Policy"); });
        }

    }])
    .controller('Policy_delete', ['$scope', '$http', '$routeParams', '$location', function($scope, $http, $routeParams, $location){
        $http.defaults.useXDomain = true;
        delete $http.defaults.headers.common['X-Requested-With'];

        $http.get(rootPath + '/Api/Policies/' + $routeParams.id)
        .then(function(response){$scope.data = response.data;});
        $scope.save = function(){
            $http.delete(rootPath + '/Api/Policies/' + $routeParams.id, $scope.data)
            .then(function(response){ $location.path("Policy"); });
        }

    }]);

})();

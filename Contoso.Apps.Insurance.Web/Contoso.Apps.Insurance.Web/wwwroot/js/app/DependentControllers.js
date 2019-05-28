 var  modules = modules || [];
(function () {
    'use strict';
    //modules.push('Dependent');

    var rootPath = contoso.policyconnect.vars.rootPath;

    angular.module('policyConnect')
    .controller('Dependent_list', ['$scope', '$http', '$routeParams', function($scope, $http, $routeParams){
        $http.defaults.useXDomain = true;
        delete $http.defaults.headers.common['X-Requested-With'];

        $http.get(rootPath + '/Api/Dependents?policyHolderId=' + $routeParams.PolicyHolder)
        .then(function(response){$scope.data = response.data;});

    }])
    .controller('Dependent_details', ['$scope', '$http', '$routeParams', function($scope, $http, $routeParams){
        $http.defaults.useXDomain = true;
        delete $http.defaults.headers.common['X-Requested-With'];

        $http.get(rootPath + '/Api/Dependents/' + $routeParams.id)
        .then(function(response){$scope.data = response.data;});

    }])
    .controller('Dependent_create', ['$scope', '$http', '$routeParams', '$location', function($scope, $http, $routeParams, $location){
        $http.defaults.useXDomain = true;
        delete $http.defaults.headers.common['X-Requested-With'];

        $scope.data = {};
        $http.get(rootPath + '/Api/People?getPeopleWhoAreNotPolicyHolders=true')
        .then(function(response){$scope.PersonId_options = response.data;});
        $http.get(rootPath + '/Api/PolicyHolders/')
        .then(function(response){$scope.PolicyHolderId_options = response.data;});
        
        $scope.save = function(){
            $http.post(rootPath + '/Api/Dependents/', $scope.data)
            .then(function(response){ $location.path("Dependent"); });
        }

    }])
    .controller('Dependent_edit', ['$scope', '$http', '$routeParams', '$location', function($scope, $http, $routeParams, $location){
        $http.defaults.useXDomain = true;
        delete $http.defaults.headers.common['X-Requested-With'];

        $http.get(rootPath + '/Api/Dependents/' + $routeParams.id)
        .then(function(response){$scope.data = response.data;});

        $http.get(rootPath + '/Api/People?getPeopleWhoAreNotPolicyHolders=true')
        .then(function(response){$scope.PersonId_options = response.data;});
        $http.get(rootPath + '/Api/PolicyHolders/')
        .then(function(response){$scope.PolicyHolderId_options = response.data;});
        
        $scope.save = function(){
            $http.post(rootPath + '/Api/Dependents/', $scope.data)
            .then(function(response){ $location.path("Dependent"); });
        }

    }])
    .controller('Dependent_delete', ['$scope', '$http', '$routeParams', '$location', function($scope, $http, $routeParams, $location){
        $http.defaults.useXDomain = true;
        delete $http.defaults.headers.common['X-Requested-With'];

        $http.get(rootPath + '/Api/Dependents/' + $routeParams.id)
        .then(function(response){$scope.data = response.data;});
        $scope.save = function(){
            $http.delete(rootPath + '/Api/Dependents?dependentId=' + $routeParams.id, $scope.data)
            .then(function(response){ $location.path("Dependent"); });
        }

    }]);

})();

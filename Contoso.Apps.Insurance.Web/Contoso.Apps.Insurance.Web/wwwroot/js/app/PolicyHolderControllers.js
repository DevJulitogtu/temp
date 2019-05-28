var modules = modules || [];
var contoso = contoso || {};
(function () {
    'use strict';

    var rootPath = contoso.policyconnect.vars.rootPath;
    var proxyPath = contoso.policyconnect.vars.azureFunctionsProxyUrl;

    angular.module('policyConnect')
        .controller('PolicyHolder_list',
        [
            '$scope', '$http', function ($scope, $http) {
                $http.defaults.useXDomain = true;
                delete $http.defaults.headers.common['X-Requested-With'];

                $http.get(rootPath + '/Api/PolicyHolders/')
                    .then(function (response) {
                        if (response.statusCode == 401) {
                            alert('Authentication failed. You need to sign in first!');
                        }
                        $scope.data = response.data;
                    });
            }
        ])
        .controller('PolicyHolder_details',
        [
            '$scope', '$http', '$routeParams', function($scope, $http, $routeParams) {
                $http.defaults.useXDomain = true;
                delete $http.defaults.headers.common['X-Requested-With'];
                $scope.data = {};
                $http.get(rootPath + '/Api/PolicyHolders/' + $routeParams.id)
                    .then(function (response)
                    {
                        $scope.data = response.data;
                        $scope.azureFunctionsProxyUrl = proxyPath.replace("{policyHolder}", $scope.data.Person.LName).replace("{policyNumber}", $scope.data.PolicyNumber);
                    });
            }
        ])
        .controller('PolicyHolder_create',
        [
            '$scope', '$http', '$routeParams', '$location', function($scope, $http, $routeParams, $location) {
                $http.defaults.useXDomain = true;
                delete $http.defaults.headers.common['X-Requested-With'];

                $scope.data = {};
                $http.get(rootPath + '/Api/People/')
                    .then(function(response) { $scope.PersonId_options = response.data; });
                $http.get(rootPath + '/Api/Policies/')
                    .then(function(response) { $scope.PolicyId_options = response.data; });

                $scope.save = function() {
                    $http.post(rootPath + '/Api/PolicyHolders/', $scope.data)
                        .then(function(response) { $location.path("PolicyHolder"); });
                }

            }
        ])
        .controller('PolicyHolder_edit',
        [
            '$scope', '$http', '$routeParams', '$location', function($scope, $http, $routeParams, $location) {
                $http.defaults.useXDomain = true;
                delete $http.defaults.headers.common['X-Requested-With'];

                $http.get(rootPath + '/Api/PolicyHolders/' + $routeParams.id)
                    .then(function(response) { $scope.data = response.data; });

                $http.get(rootPath + '/Api/People/')
                    .then(function(response) { $scope.PersonId_options = response.data; });
                $http.get(rootPath + '/Api/Policies/')
                    .then(function(response) { $scope.PolicyId_options = response.data; });

                $scope.save = function() {
                    $http.post(rootPath + '/Api/PolicyHolders/', $scope.data)
                        .then(function(response) { $location.path("PolicyHolder"); });
                }

            }
        ])
        .controller('PolicyHolder_delete',
        [
            '$scope', '$http', '$routeParams', '$location', function($scope, $http, $routeParams, $location) {
                $http.defaults.useXDomain = true;
                delete $http.defaults.headers.common['X-Requested-With'];

                $http.get(rootPath + '/Api/PolicyHolders/' + $routeParams.id)
                    .then(function(response) { $scope.data = response.data; });
                $scope.save = function() {
                    $http.delete(rootPath + '/Api/PolicyHolders/' + $routeParams.id, $scope.data)
                        .then(function(response) { $location.path("PolicyHolder"); });
                }

            }
        ]);
})();
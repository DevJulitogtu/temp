'use strict';
angular.module('policyConnect', ['ngRoute', 'AdalAngular'])
.config(['$routeProvider', '$httpProvider', 'adalAuthenticationServiceProvider', function ($routeProvider, $httpProvider, adalProvider) {

    $routeProvider.when('/PolicyHolder', {
                title: 'PolicyHolder - List',
                templateUrl: '/Static/PolicyHolder_List',
                controller: 'PolicyHolder_list',
                requireADLogin: true
            })
            .when('/PolicyHolder/Create', {
                title: 'PolicyHolder - Create',
                templateUrl: '/Static/PolicyHolder_Edit',
                controller: 'PolicyHolder_create',
                requireADLogin: true
            })
            .when('/PolicyHolder/Edit/:id', {
                title: 'PolicyHolder - Edit',
                templateUrl: '/Static/PolicyHolder_Edit',
                controller: 'PolicyHolder_edit',
                requireADLogin: true
            })
            .when('/PolicyHolder/Delete/:id', {
                title: 'PolicyHolder - Delete',
                templateUrl: '/Static/PolicyHolder_Delete',
                controller: 'PolicyHolder_delete',
                requireADLogin: true
            })
            .when('/PolicyHolder/:id', {
                title: 'PolicyHolder - Details',
                templateUrl: '/Static/PolicyHolder_Details',
                controller: 'PolicyHolder_details',
                requireADLogin: true
            })
            .when('/Policy', {
                title: 'Policy - List',
                templateUrl: '/Static/Policy_List',
                controller: 'Policy_list',
                requireADLogin: true
            })
            .when('/Policy/Create', {
                title: 'Policy - Create',
                templateUrl: '/Static/Policy_Edit',
                controller: 'Policy_create',
                requireADLogin: true
            })
            .when('/Policy/Edit/:id', {
                title: 'Policy - Edit',
                templateUrl: '/Static/Policy_Edit',
                controller: 'Policy_edit',
                requireADLogin: true
            })
            .when('/Policy/Delete/:id', {
                title: 'Policy - Delete',
                templateUrl: '/Static/Policy_Delete',
                controller: 'Policy_delete',
                requireADLogin: true
            })
            .when('/Policy/:id', {
                title: 'Policy - Details',
                templateUrl: '/Static/Policy_Details',
                controller: 'Policy_details',
                requireADLogin: true
            })
            .when('/Person', {
                title: 'Person - List',
                templateUrl: '/Static/Person_List',
                controller: 'Person_list',
                requireADLogin: true
            })
            .when('/Person/Create', {
                title: 'Person - Create',
                templateUrl: '/Static/Person_Edit',
                controller: 'Person_create',
                requireADLogin: true
            })
            .when('/Person/Edit/:id', {
                title: 'Person - Edit',
                templateUrl: '/Static/Person_Edit',
                controller: 'Person_edit',
                requireADLogin: true
            })
            .when('/Person/Delete/:id', {
                title: 'Person - Delete',
                templateUrl: '/Static/Person_Delete',
                controller: 'Person_delete',
                requireADLogin: true
            })
            .when('/Person/:id', {
                title: 'Person - Details',
                templateUrl: '/Static/Person_Details',
                controller: 'Person_details',
                requireADLogin: true
            })
            .when('/Dependent', {
                title: 'Dependent - List',
                templateUrl: '/Static/Dependent_List',
                controller: 'Dependent_list',
                requireADLogin: true
            })
            .when('/Dependent/Create', {
                title: 'Dependent - Create',
                templateUrl: '/Static/Dependent_Edit',
                controller: 'Dependent_create',
                requireADLogin: true
            })
            .when('/Dependent/Edit/:id', {
                title: 'Dependent - Edit',
                templateUrl: '/Static/Dependent_Edit',
                controller: 'Dependent_edit',
                requireADLogin: true
            })
            .when('/Dependent/Delete/:id', {
                title: 'Dependent - Delete',
                templateUrl: '/Static/Dependent_Delete',
                controller: 'Dependent_delete',
                requireADLogin: true
            })
            .when('/Dependent/:id', {
                title: 'Dependent - Details',
                templateUrl: '/Static/Dependent_Details',
                controller: 'Dependent_details',
                requireADLogin: true
            }).otherwise({ redirectTo: '/Static/PolicyHolder_List' });

        var endpoints = {
        // Map the location of a request to an API to a the identifier of the associated resource
        "https://contosoinsuranceapi.azurewebsites.net/": contoso.policyconnect.vars.webApiAppId
    };

    adalProvider.init(
        {
            instance: 'https://login.microsoftonline.com/',
            tenant: contoso.policyconnect.vars.tenant,
            clientId: contoso.policyconnect.vars.webClientId,
            extraQueryParameter: 'nux=1',
            endpoints: endpoints,
            //cacheLocation: 'localStorage', // enable this for IE, as sessionStorage does not work for localhost.  
            // Also, token acquisition for the To Go API will fail in IE when running on localhost, due to IE security restrictions.
        },
        $httpProvider
        );

}]);

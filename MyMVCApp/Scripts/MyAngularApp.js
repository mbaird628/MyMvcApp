(function () {
    'use strict';

    var app = angular.module("myApp", []);

    app.run(function ($rootScope) {
        // This variable has global scrope 
        $rootScope.color = 'Coral';
    });

    app.directive("myCustomAngularDirective", function () {
        return {
            template: "<p style='font-size:16px;color:{{color}}'>A variable named 'color' is defined as " +
                        "<b>{{color}}</b> in the rootScope.<br> This variable will be used in the input boxes as well untill the color is changed. " +
                        "At that time the model in the contoller will be updated with a local color variable but " +
                        "the global variable will not be updated as indicated by color of this paragraph.</p>"

        };
    });

    app.controller('personCtrl', function ($scope) {
        const privateFirstName = "Jerry";
        const privateLastName = "Brown";

        //$scope is the model in the Angular MVC app
        $scope.person = {
            firstName: 'Jeremy',
            lastName: 'Smith'
        };
        $scope.firstName = "Mark";
        $scope.lastName = "Baird";
        $scope.fullName = function () {
            return privateFirstName + " " + privateLastName;
        };
    });


    app.controller('namesCtrl', function ($scope) {
        //$scope is the model in the Angular MVC app
        $scope.nameAndCountry = [{
                first: 'Mark',
                last:'Baird',
                country: 'USA'
        }, {
                first: 'Jerry',
                last: 'Anderson',
                country: 'Sweden'
        }, {
                first: 'Robert',
                last:'Johnson',
                country: 'Mars'
        }, {
                first: 'Bob',
                last:'Hope',
                country: 'France'
        }];

        
        $scope.orderBy = function (x,y) {
            $scope.myOrderBy = x;
            $scope.isReverse = y;
        };
    });

})();


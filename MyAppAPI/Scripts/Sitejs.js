app.service('studentService', function($http) {
    this.Delete = function(student) {
        $http({
            method: 'Delete',
            url: 'api/Delete',
            headers: {
                'Content-Type': 'application/json'
            },
            data: JSON.stringify(student)
        }).then(function (response) {alert('successful')},
            function (error, status) {
            });
    }

    this.GetStudent = function() {
        return $http.get('api/GetAllStudent', { cache: true });
    }

});

app.controller('myCtrl', function ($scope, studentService) {
    $scope.firstName = "Caleb";

    studentService.GetStudent().then(function(response) {
        $scope.students = response.data;
    });

    $scope.Delete = function (student) {
        studentService.Delete(student);
    }

});
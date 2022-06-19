// angular forms 
app.controller('ISC', ($scope, $rootScope, $http) => {

    // Variables 
    $scope.title = " Hello ";
    $scope.description = " is it me . ";

    // Get All 
    $scope.GetAllInnovaitions = () => {
        // Ajax Call Throw AngularJS
        $http.get('/Innovation/GetAllInnovations').then(
            (res) => {
                // TODO: Success
                $scope.myListOfInnovations = res.data;
            },
            (err) => {
                // TODO: Handle Error
                console.log(err);
            })
    }
    $scope.GetAllInnovaitions();


    // Add Innovation
    $scope.AddInnovation = () => {

        $scope.model = { "Id": 1, "Title": $scope.title, "Description": $scope.description, "CreatedUserId": 1, "UserName": "Mohamed" }; // for Now ..
        $http.post('/Innovation/AddInnovation', $scope.model).then(
            (res) => {
                // TODO: Success
                $scope.myListOfInnovations.push($scope.model);

                /* $scope.GetAllInnovaitions();*/
                $scope.title = "";
                $scope.description = "";
            },
            (err) => {
                // TODO: Handle Error
                console.log(err);
            })
    }



    // Delete 
    $scope.DeleteInnovation = (id) => {


        $http.get('/Innovation/DeleteInnovation?id=' + id).then(
            (res) => {
                // TODO: Success
                //$scope.GetAllInnovaitions();

                /// id Search in Array 
                // get index from array , 
                // slice from array 

                $scope.index = $scope.myListOfInnovations.findIndex(x => x.id == id);
                $scope.myListOfInnovations.splice($scope.index, 1)

            },
            (err) => {
                // TODO: Handle Error
                console.log(err);
            })
    }




    // Update 
});
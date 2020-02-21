// JavaScript source code
//function SaveEmployee(e) {
//    e.stopPropagation();

//    var data = {
//        "EmpName": ['input'],
//        "Company": <input>
//            };

//        $.ajax({
//                type: "POST",
//            url: "/employee",
//            data: JSON.stringify(data),
//            contentType: "application/json; charset=utf-8",
//            dataType: "json",
//            success: function (data) {
//                //           data is your json returned from webapi method
//            },
//            error: function (xhr, ajaxOptions, thrownError) {
//                console.log(xhr.status);
//            console.log(thrownError);
//            e.preventDefault();
//        }
//    });        
//}

//$(document).ready(function () {

//    // Send an AJAX request  
//    $.ajax({
//        url: 'https://localhost:44347/api/Employee?type=xml',
//        type: "GET",
//        data: {},
//        dataType: "json",
//        success: function (result) {
//            // On success, 'data' contains a list of products.  
//            var htmlContent = "";

//            $.each(result, function (key, item) {
//                htmlContent = htmlContent + "<tr><td>" + Employee.EmployeeID + "</td><td>" + Employee.Name + "</td><td>" + Employee.Position + "</td><td>" + Employee.Age + "</td><td>" + Employee.Salary + "</td></tr>";
//            });

//            // Appending HTML content  
//            $('#Employee').append(htmlContent);
//        },
//        error: function (err) {
//            alert(err.statusText);
//        }
//    });
//});

//// Adding Employee record

//function add() {
//    var EmployeeId = $('#Id').val();
//    var Name = $('#Name').val();
//    var Position = $('#Position').val();
//    var Age = $('#Age').val();
//    var Salary = $('#Salary').val();


//    var EmployeeData = { "EmployeeId": EmployeeId, "Name": Name, "Position": Position, "Age": Age, "Salary": Salary };

//    $.ajax({
//        url: 'http://localhost:44347/api/Employee?type=json',
//        type: "POST",
//        contentType: "application/json",
//        data: JSON.stringify(EmployeeData),
//        dataType: "json",
//        success: function (result) {
//            // On success, 'data' contains a list of products.  
//            var htmlContent = "";

//            $("#Employee > tbody > tr").remove();

//            $.each(result, function (key, item) {
//                htmlContent = htmlContent + "<tr><td>" + Employee.EmployeeID + "</td><td>" + Employee.Name + "</td><td>" + Employee.Position + "</td><td>" + Employee.Age + "</td><td>" + Employee.Salary + "</td></tr>";
//            });

//            // Appending HTML content  
//            $('#Employee').append(htmlContent);
//        },
//        error: function (err) {
//            alert(err.statusText);
//        }
// url: 'https://localhost:44347/api/Employee',   });
//}  





//$(document).ready(function() {
//    $.ajax({

//        type: 'GET',
//        dataType: 'json',
//        success: function (data, textStatus, xhr) {
//            console.log(data);
//        },
//        error: function (xhr, textStatus, errorThrown) {
//            console.log('Error in Database');
//        }
//    });
//});

// GET ALL
function GetAllEmployee() {
    //console.log("Hi");
    $.ajax({
        type: "GET",
        url: "https://localhost:44347/api/Employee",
        contentType: "json",
        dataType: "json",
        success: function (data) {

            $.each(data, function (key, value) {
                //stringify
                var jsonData = JSON.stringify(value);
                //Parse JSON
                var objData = $.parseJSON(jsonData);
                var id = objData.EmployeeId;
                var name = objData.Name;
                var position = objData.Position;
                var age = objData.Age;
                var salary = objData.Salary;
                $("<tr><td>" + Employee.EmployeeID + "</td><td>" + Employee.Name + "</td><td>" + Employee.Position + "</td><td>" + Employee.Age + "</td><td>" + Employee.Salary + "</td></tr>").appendTo('#Employee tbody');
            });
        },
        error: function (xhr) {
            alert(xhr.responseText);
        }
    });
}




////GET
//function GetStudentById() {
//    $.ajax({
//        type: "GET",
//        url: "http://localhost/CRUDWebAPI/api/students/1",
//        contentType: "json",
//        dataType: "json",
//        success: function (data) {
//            //stringify
//            var jsonData = JSON.stringify(data);
//            //Parse JSON
//            var objData = $.parseJSON(jsonData);

//            var objData = $.parseJSON(jsonData);
//            var id = objData.StudentId;
//            var fname = objData.FirstName;
//            var lname = objData.LastName;

//            $('<tr><td>' + id + '</td><td>' + fname +
//                '</td><td>' + lname +
//                '</td></tr>').appendTo('#students');
//        },
//        error: function (xhr) {
//            alert(xhr.responseText);
//        }
//    });
//}
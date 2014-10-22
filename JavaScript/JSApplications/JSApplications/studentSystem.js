define(['httpRq', 'jquery'], function(httpRequest, $){

    var requestedURL = 'http://localhost:3000/students'

    var textBox = $('#container');

    function loadStudent (){
     return httpRequest
         .getJSON(requestedURL)
        .done(function(data){
             var $studentsList = $('<ul/>').addClass('students-list');
             for (var i = 0; i < data.students.length; i++) {
                 var student = data.students[i];
                 $studentsList.append('name<li>' + student.name + ' grade' + student.grade + '</li>')

             }
             textBox.html($studentsList)
         })
    }
return {
    loadStudent: loadStudent
}

})
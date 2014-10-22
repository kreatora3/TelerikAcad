/// <reference path="../libs/jquery-2.1.1.min.js" />
function createStudent(firstname, lastname, grade) {
    return { firstname: firstname, lastname: lastname, grade: grade }
}

var arrayOfStudent = [];

arrayOfStudent.push(createStudent('Peter', 'Ivanov', 3));
arrayOfStudent.push(createStudent('Milena', 'Grigorova', 6));
arrayOfStudent.push(createStudent('Gergana', 'Borisova', 12));
arrayOfStudent.push(createStudent('Boyko', 'Petrov', 7));

function createTable(students) {
    var $container = $('#container'),
        dFrag = $(document.createDocumentFragment());

    for (var i = 0; i < students.length; i++) {
        var tr = $('<tr />'),
                nameElement = $('<td />').addClass('firsName').html(students[i].firstname),
                lastNameElement = $('<td />').addClass('lastName').html(students[i].lastname),
                gradeElement = $('<td />').addClass('grade').html(students[i].grade);
            
        dFrag.append(tr).append(nameElement).append(lastNameElement).append(gradeElement);      
    }

    $container.append(dFrag);
}

createTable(arrayOfStudent);
function firstTask() {
    var result,
        toPrint = String();

    var students = [
        {firstName: 'Pesho', lastName: 'Georgiev'},
        {firstName: 'Georgi', lastName: 'Petrov'},
        {firstName: 'Ivan', lastName: 'Emilov'},
        {firstName: 'Maria', lastName: 'Ivanova'}
    ]


     result = _.chain(students)
        .filter(function (student) {
            return student.lastName < student.firstName;
        })
        .sortBy('firstName')
        .reverse()
        .each(function (student) {
            toPrint += student.firstName + ' ' + student.lastName + '<br />'
        }).value()


    $('#result1').slideToggle(toPrint).html(toPrint)


}
$('#result1').hide()
$('#result1executor').on('click', firstTask)

function secondTask(){
    var result,
        toPrint = String();
    var students = [

    {firstName: 'Pesho', lastName: 'Georgiev', age: 18},
    {firstName: 'Georgi', lastName: 'Petrov', age: 24},
    {firstName: 'Ivan', lastName: 'Emilov', age: 20},
    {firstName: 'Maria', lastName: 'Ivanova',age:17}

    ]

     result = _.chain(students)
         .filter(function(student){
             return (student.age >= 18 && 24 >= student.age)
         })
         .each(function(student){
             toPrint += student.firstName + ' ' + student.lastName + ' is ' + student.age + ' year ' + ' old' + '<br />'
         }).value()

$('#result2').fadeToggle(toPrint).html(toPrint)

}

$('#result2').hide()
$('#result2executor').on('click', secondTask)
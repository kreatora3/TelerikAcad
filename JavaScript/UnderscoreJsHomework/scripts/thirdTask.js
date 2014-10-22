function thirdTask(){
    var result,
        toPrint = String();
    var students = [

        {firstName: 'Pesho', lastName: 'Georgiev', age: 18, averageMark:5.98},
        {firstName: 'Georgi', lastName: 'Petrov', age: 24, averageMark:4.98},
        {firstName: 'Ivan', lastName: 'Emilov', age: 20, averageMark:3.98},
        {firstName: 'Maria', lastName: 'Ivanova',age:17, averageMark:5.50}

    ]

    result = _.chain(students)
        .sortBy('averageMark')
        .last().value()

    var  highestMark = result.averageMark
    var  fullName = result.firstName +' ' + result.lastName

    toPrint = fullName + ' has ' + highestMark + ' which is the highest one !'

    $('#result3').toggle(toPrint).html(toPrint)
}

$('#result3').hide()
$('#result3executor').on('click', thirdTask)
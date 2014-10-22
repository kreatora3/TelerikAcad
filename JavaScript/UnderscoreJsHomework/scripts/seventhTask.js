function seventhTask () {
    var people,
        countFirstNames,
        countLastNames,
        toPrint

    people = [
        {firstName: 'Ivan', lastName:'Ivanov'},
        {firstName: 'Georgi', lastName:'Ivanov'},
        {firstName: 'Cvetan', lastName:'Ivanov'},
        {firstName: 'Ivan', lastName:'Georgiev'},
        {firstName: 'Milen', lastName:'Georgiev'},
        {firstName: 'Emil', lastName:'Georgiev'},
        {firstName: 'Todor', lastName:'Georgiev'},
        {firstName: 'Ivan', lastName:'Simeonov'}
    ]


    function countNames(array, property){
        var count = _.countBy(array, property)
        var maxIndex = _.max(count)
        return _.invert(count)[maxIndex]
    }
    countFirstNames = countNames(people, 'firstName');
    countLastNames = countNames(people, 'lastName');

    toPrint = 'The most frequent first name is ... ' + countFirstNames + '<br />' + 'The most frequent last name is ... ' + countLastNames
    $('#result7').fadeToggle(toPrint).html(toPrint)
}

$('#result7').hide()
$('#result7executor').on('click', seventhTask)
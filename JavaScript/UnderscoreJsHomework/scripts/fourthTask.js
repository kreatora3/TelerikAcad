function fourthTask() {
    var animals,
        result,
        i,
        j,
        len,
        toPrint = String();

    animals = [
        {   name: 'Eagle',
            species: 'bird',
            numberOfLegs: 3},   // Put 3 legs to show that the sort works fine :)

        {   name: 'Crow',
            species: 'bird',
            numberOfLegs: 2},

        {   name: 'Boar',
            species: 'mammal',
            numberOfLegs: 4},

        {   name: 'Lion',
            species: 'mammal',
            numberOfLegs: 4},

        {   name: 'Snake',
            species: 'reptile',
            numberOfLegs: 0},

        {   name: 'Alligator',
            species: 'reptile',
            numberOfLegs: 4}
    ]

    result = _.chain(animals)
        .groupBy('species')
        .sortBy(function (array) {
            array.sort(function (a, b) {
                return a.numberOfLegs - b.numberOfLegs
            })
        }).value()

    for ( i = 0, len = result.length ; i < len; i++) {
        var obj = result[i];
        for ( j = 0; j < obj.length; j++) {
            var animal = obj[j];
            toPrint += animal.name + ' has ' + animal.numberOfLegs + ' legs' + '<br />'
        }


    }

    $('#result4').slideToggle(toPrint).html(toPrint)
}

$('#result4').hide()
$('#result4executor').on('click', fourthTask)
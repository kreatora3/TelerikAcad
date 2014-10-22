function fifthTask(){
    var animals,
        result,
        counter = Number()

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
            numberOfLegs: 4},

        {   name: 'HundredLegAnimal',
            species: 'insect',
            numberOfLegs: 100}
    ]

    result = _.each(animals, function(animal){
        counter += animal.numberOfLegs;
    })
    $('#result5').fadeToggle(counter).html(counter)
}

$('#result5').hide()
$('#result5executor').on('click', fifthTask)
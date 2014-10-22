function propertyCheck(form) {

    var person = {
        name: form.name.value,
        age: form.age.value
    }
    var searchedProperty = form.search.value;

    if (person.hasOwnProperty(searchedProperty)) {

        document.getElementById('result4').innerHTML = 'Person object has this property'
    } else {
        document.getElementById('result4').innerHTML = 'Person object has no such property'
    }

}
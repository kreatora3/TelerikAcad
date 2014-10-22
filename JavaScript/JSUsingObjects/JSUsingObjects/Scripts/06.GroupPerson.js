function groupByProperty(form) {

    function person(firstname, lastname, age) {
        this.firstname = firstname;
        this.lastname = lastname;
        this.age = age;
    }

    var property = form.property.value;
    var pesho = new person(form.firstName1.value, form.lastName1.value, form.age1.value)
    var gosho = new person(form.firstName2.value, form.lastName2.value, form.age2.value)
    var niki = new person(form.firstName3.value, form.lastName3.value, form.age3.value)

    var persons = [pesho, gosho, niki]

    function group(persons, property) {
        switch (property) {
            case 'firstname':
                persons.sort(function (a, b) {
                    var nameA = a.firstname.toLowerCase(), nameB = b.firstname.toLowerCase()
                    if (nameA > nameB)
                        return 1
                    if (nameA < nameB)
                        return -1
                    return 0
                })
                break;
            case 'lastname':
                persons.sort(function (a, b) {
                    var nameA = a.lastname.toLowerCase(), nameB = b.lastname.toLowerCase()
                    if (nameA > nameB)
                        return 1
                    if (nameA < nameB)
                        return -1
                    return 0
                })
                break;
            case 'age':
                persons.sort(function (a, b) {
                    return a.age - b.age
                });
               
                break;
            default: return document.getElementById('result6').innerHTML = 'Not valid property'; break;

        }
       
    }

    group(persons, property);

     document.getElementById('result6').innerHTML = JSON.stringify(persons);
}
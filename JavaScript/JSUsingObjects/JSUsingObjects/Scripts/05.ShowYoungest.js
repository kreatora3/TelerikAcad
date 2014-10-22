function showYoungest(form) {
     
    function person(firstname, lastname, age){
        this.firstname = firstname;
        this.lastname= lastname;
        this.age = age;
    }

    var pesho = new person(form.firstName1.value, form.lastName1.value, form.age1.value)
    var gosho = new person(form.firstName2.value, form.lastName2.value, form.age2.value)
    var niki = new person(form.firstName3.value, form.lastName3.value, form.age3.value)

   
    var arr = [pesho, gosho, niki].sort(function (obj1, obj2) {
        return obj1.age - obj2.age
    });

    document.getElementById('result5').innerHTML = arr[0].firstname + ' ' + arr[0].lastname;
}
function objectCopy(form) {

    var person = {
        name: form.name.value,
        age: form.age.value
    }

    function deepCopy(oldObj) {
        var newObj = oldObj;
        if (oldObj && typeof oldObj === 'object') {
            newObj = Object.prototype.toString.call(oldObj) === "[object Array]" ? [] : {};
            for (var i in oldObj) {
                newObj[i] = deepCopy(oldObj[i]);
            }
        }
        return newObj;
    }

    document.getElementById('result3').innerHTML = 'The deep copy of person\'s details is --> ' + JSON.stringify(deepCopy(person)) + 'for detailed info how it works check the js file :)'
}


function divisibleBy3aAnd7(form) {
    var n = parseInt(form.num.value);
    var divisor = 21;
    var result = [];

    for (var i = 1; i <= n; i++) {

        if (i % divisor === 0) {
            result.push(i)
        }
    }

    document.getElementById('result2').innerHTML = result.toString();
}
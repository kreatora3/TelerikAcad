function printNumbers(form) {
    var n = parseInt(form.num.value);
    var arr = [];
    for (var i = 1; i <= n; i++) {

        arr.push(i);
    }

    document.getElementById('result1').innerHTML = arr.toString();
}

function timer(form) {
    var n = parseInt(form.num1.value);
    for (i = 0; i <= n; i++) {
        (function (i) {
            setTimeout(function () {
                document.getElementById('result1').innerHTML = i
            }, i * 500);
        })(i);
    }
}

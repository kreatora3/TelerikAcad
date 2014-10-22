function maxAndMin(form) {
    var n = (form.num.value).split(' ');

    var minNum = Number.MAX_VALUE;
    var maxNum = -Number.MAX_VALUE;

    for (var i = 0; i < n.length; i++) {
        if (parseInt(n[i]) > maxNum) {
            maxNum = parseInt(n[i]);
        }

        if (parseInt(n[i]) < minNum) {
            minNum = parseInt(n[i]);
        }

    }

    document.getElementById('result3').innerHTML = 'Min number is ' + minNum + ' Max number is ' + maxNum;
}
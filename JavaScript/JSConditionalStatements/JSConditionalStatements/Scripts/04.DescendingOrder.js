function orderDescending(form) {

    var a = parseInt(form.int.value);
    var b = parseInt(form.secondInt.value);
    var c = parseInt(form.thirdInt.value);
    var num = -Number.MAX_VALUE;

    if (a > num) {
        num = a;

        if (b > num) {
            num = b;
        }

        if (c > num) {
            num = c;
        }
    }

    if (num == a) {
        if (b > c) {
            document.getElementById('result4').innerHTML = num.toString() + ', ' + b.toString() + ', ' + c.toString();
        }
        else {

            document.getElementById('result4').innerHTML = num.toString() + ', ' + c.toString() + ', ' + b.toString();
        }
    }

    if (num == b) {
        if (a > c) {
            document.getElementById('result4').innerHTML = b.toString() + ', ' + a.toString() + ', ' + c.toString();
        }
        else {
            document.getElementById('result4').innerHTML = b.toString() + ', ' + c.toString() + ', ' + a.toString();
        }
    }

    if (num == c) {
        if (a > b) {
            document.getElementById('result4').innerHTML = c.toString() + ', ' + a.toString() + ', ' + b.toString();
        }
        else {
            document.getElementById('result4').innerHTML = c.toString() + ', ' + b.toString() + ', ' + a.toString();
        }
    }
}
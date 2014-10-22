function greatestNum(form){

    var a = parseInt(form.int.value);
    var b = parseInt(form.secondInt.value);
    var c = parseInt(form.thirdInt.value);
    var d = parseInt(form.fourthInt.value);
    var e = parseInt(form.fifthInt.value);

    var num = -Number.MAX_VALUE;

    if (a >= num) {
        num = a;
    }

    if (b >= num) {
        num = b;
    }

    if (c >= num) {
        num = c;
    }
    if (d >= num) {
        num = d;
    }
    if (e >= num) {
        num = e;
    }

    document.getElementById('result7').innerHTML = 'The greatest of these five is... ' + num.toString();
}
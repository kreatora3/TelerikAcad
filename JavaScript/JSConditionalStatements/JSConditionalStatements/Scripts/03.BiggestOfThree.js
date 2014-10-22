function biggestOfThree(form) {

    var a = parseInt(form.int.value);
    var b = parseInt(form.secondInt.value);
    var c = parseInt(form.thirdInt.value);
    var biggest = - Number.MAX_VALUE;

    if (a > biggest) {
        biggest = a;

        if (b > biggest) {
            biggest = b;
        }

        if (c > biggest) {
            biggest = c;
        }
    }
    document.getElementById('result3').innerHTML = "The biggest number you have just entered is " + biggest;
    
}
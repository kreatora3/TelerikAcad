function signFinder(form) {
    var a = parseInt(form.int.value);
    var b = parseInt(form.secondInt.value);
    var c = parseInt(form.thirdInt.value);

    if ((a<0) && (b<0) && (c<0)) {

        document.getElementById('result2').innerHTML = 'Sign is "munis"';
    }
    else if ((a < 0) && (b > 0) && (c > 0)) {

        document.getElementById('result2').innerHTML = 'Sign is "munis"';
    }
    else if ((a > 0) && (b < 0) && (c > 0)) {

        document.getElementById('result2').innerHTML = 'Sign is "munis"';
    }
    else if ((a > 0) && (b > 0) && (c < 0)) {

        document.getElementById('result2').innerHTML = 'Sign is "munis"';
    }
    else{

        document.getElementById('result2').innerHTML = 'Sign is "plus"';
    }
}
function isDividedByFiveAndSeven(form) {
    var number = form.num.value;

    if (parseInt(number) % 5 === 0 && parseInt(number) % 7 === 0) {

        document.getElementById('result2').innerHTML = 'This number is divisible by 5 and 7 at the same time'
    }
    else {

        document.getElementById('result2').innerHTML = 'This number is not divisible by 5 and 7 at the same time. Sorry  :( '
    }
}
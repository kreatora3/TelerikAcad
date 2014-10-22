function checkTheThirdBit(form){
    var number = form.num.value;
    var checkDigit = 8;

    var result = number & checkDigit;

    if (result === 0) {
        document.getElementById('result5').innerHTML = 'Third bit is 0'
    }
    else {
        document.getElementById('result5').innerHTML = 'Third bit is 1'
    }
}
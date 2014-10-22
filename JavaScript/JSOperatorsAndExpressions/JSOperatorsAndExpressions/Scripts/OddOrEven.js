function oddOrEven(form) {
    var number = form.num.value;
    
    if (parseInt(number) % 2 === 0) {
        document.getElementById('result1').innerHTML = 'It is even';
    }

    else {
        document.getElementById('result1').innerHTML = 'It is odd';
    }
}
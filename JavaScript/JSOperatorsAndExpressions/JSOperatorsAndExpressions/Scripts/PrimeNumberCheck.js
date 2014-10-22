function primeCheck(form) {
    var number = form.num.value;
    var sqrt = Math.sqrt(number);
    var count = 0;

    for (var i = 2; i < sqrt; i++) {

        if (number % i === 0) {
            count++;
        }
        
    }
    
    if (count > 0) {
        document.getElementById('result7').innerHTML = 'This is  not a prime number'
    }
    else{
        document.getElementById('result7').innerHTML = 'This is a prime number'
    }
}
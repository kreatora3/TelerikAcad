function reverseNumber(form) {

    var number = form.num.value;

    var result = number.split('').reverse().join('');

    document.getElementById('result2').innerHTML = result;
}
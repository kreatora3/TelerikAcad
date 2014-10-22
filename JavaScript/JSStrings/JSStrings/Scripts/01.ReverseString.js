function reverse(form) {

    var input = form.string.value;

    var reversed = input.split('').reverse().join('');

    document.getElementById('result1').innerHTML = reversed;
}
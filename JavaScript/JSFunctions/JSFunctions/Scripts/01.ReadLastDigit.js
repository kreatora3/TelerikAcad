function readLastDigit(form) {

    var number = form.num.value;

    switch (parseInt(number[number.length - 1])) {
        case 1: document.getElementById('result1').innerHTML = 'One'; break;
        case 2: document.getElementById('result1').innerHTML = 'Two'; break;
        case 3: document.getElementById('result1').innerHTML = 'Three'; break;
        case 4: document.getElementById('result1').innerHTML = 'Four'; break;
        case 5: document.getElementById('result1').innerHTML = 'Five'; break;
        case 6: document.getElementById('result1').innerHTML = 'Six'; break;
        case 7: document.getElementById('result1').innerHTML = 'Seven'; break;
        case 8: document.getElementById('result1').innerHTML = 'Eight'; break;
        case 9: document.getElementById('result1').innerHTML = 'Nine'; break;
        case 0: document.getElementById('result1').innerHTML = 'Zero'; break;
        default: document.getElementById('result1').innerHTML = 'Thank you for breaking my code :)'; break;
    }
}
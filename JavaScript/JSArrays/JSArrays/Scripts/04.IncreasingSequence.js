function increasingSequence(form) {

    var counter = 1;
    var start = 0;
    var bestCounter = 1;
    var array = [];
    var print = 0;
    array = (form.array.value).split('');


    for (var i = 1; i < array.length; i++) {
        if (array[start] < array[i]) {
            counter++;

            if (counter > bestCounter) {
                bestCounter = counter;
                print = i;
            }

        }
        if (array[start] >= array[i]) {
            counter = 1;
            start = i - 1;
        }
        start++;
    }

    var result = [];
    for (var i = (print - bestCounter + 1) ; i <= print; i++) {
        result.push(array[i]);
    }

    document.getElementById('result4').innerHTML = 'Maximal increasing sequence  is '  + '(' + bestCounter + ')' + ' => ' + result.join(' ');
}
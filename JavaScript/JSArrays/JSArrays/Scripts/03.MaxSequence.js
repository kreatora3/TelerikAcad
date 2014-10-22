function sequenceFinder(form) {

    var counter = 0;
    var start = 0;
    var bestCounter = 1;
    var array = [];
    var print = 0;

    array = (form.array.value).split('');

    for (var i = 0; i < array.length; i++) {

        if (array[start] === array[i]) {

            counter++;

            if (counter > bestCounter) {
                bestCounter = counter;
                print = i;
            }
        }

        if (array[start] !== array[i]) {

            counter = 1;
            start = i;
        }
    }

    var result = [];
    for (var i = (print - bestCounter + 1); i <= print; i++) {
        result.push(array[i]);
    }

    document.getElementById('result3').innerHTML = 'Sequence of equal elements is' + ' ' + '(' + bestCounter + ')' + ' => ' + result.join(' ');

}
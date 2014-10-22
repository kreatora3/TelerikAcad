function binarySearch(form) {

    var array = [];
    array = (form.array.value).split('');
    var symbol = form.symbol.value;

    array.sort();

    var startInd = 0;
    var endInd = array.length - 1;
    var midPoint = 0;

    while (startInd <= endInd) {

        midPoint = ~~((startInd + endInd) / 2);

        if (symbol > array[midPoint]) {
            startInd = midPoint + 1;
        } else if (symbol < array[midPoint]) {
            endInd = midPoint - 1;
        } else {
            document.getElementById('result7').innerHTML = 'The sorted array is ' + '<span id="blue">' +
                array.join(' ') + '</span>' + '<br />' + ' and the searched symbol ' + '<span id="blue">' + symbol + '</span>' + ' was found at the position with index of ' +
                '<span id="blue">' + midPoint + '</span>' + ' in the given array';
            break;
        }
        if (midPoint == array.length - 1 || startInd > endInd) {

            document.getElementById('result7').innerHTML = 'No such a symbol in the given array';
            break;

        }
    }
}
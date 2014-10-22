function mostFreqElement(form) {

    var array = [];
    array = (form.array.value).split('');

    if (array.length == 0) {
        return null;
    }

    var modeMap = {};

    var maxEl = array[0];
    var maxCount = 1;

    for (var i = 0; i < array.length; i++) {

        var el = array[i];

        if (modeMap[el] == null) {
            modeMap[el] = 1;
        } else {
            modeMap[el]++;
        }

        if (modeMap[el] > maxCount) {
            maxEl = el;
            maxCount = modeMap[el];
        }
    }

    document.getElementById('result6').innerHTML = 'The element is ' + maxEl + ' and it is repeated ' + maxCount + ' times';
}
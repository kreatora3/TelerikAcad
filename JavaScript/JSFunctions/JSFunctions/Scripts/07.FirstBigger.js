function firstBigger(form) {

    var arr = [];
    arr = (form.array.value).replace(/\s/g, '').split('');

    function neighbours(array) {
        var counter = array.length - 2;

        for (var index = 1; index < array.length - 1; index++) {
            if (array[index] > array[index - 1] && array[index] > array[index + 1]) {
                return document.getElementById('result7').innerHTML = index;
            }
            counter--;
        }
        if (counter == 0) {
            return document.getElementById('result7').innerHTML = -1;
        }
    }

    neighbours(arr);
}
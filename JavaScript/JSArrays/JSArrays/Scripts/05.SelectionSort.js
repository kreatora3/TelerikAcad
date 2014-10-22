function selectionSort(form) {

    var array = [];
    array = (form.array.value).split('');

    var min = 0;
    var temp = 0;

    for (var i = 0; i < array.length - 1; i++) {
        min = i;
        for (var j = i; j < array.length; j++) {
            if (array[min] > array[j]) {
                min = j;
            }
        }
        temp = array[i];
        array[i] = array[min];
        array[min] = temp;
    }

    document.getElementById('result5').innerHTML = array.join(' ');
}
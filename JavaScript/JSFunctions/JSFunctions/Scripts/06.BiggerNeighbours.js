function biggerThanNeighbours(form) {

    var arr = [];
    arr = (form.array.value).replace(/\s/g, '').split('');
    var index = parseInt(form.index.value);

    function neighbours(array, index) {
        if (index === 0 || index === (array.length - 1)) {
            document.getElementById('result6').innerHTML = 'This position in the array has only one neighbour';
        }
        if (index < 0 || index > array.length - 1) {
            document.getElementById('result6').innerHTML = 'There is no such index in this array';
        }
        if (index > 0 && index < array.length - 1) {
            if (array[index] > array[index - 1] && array[index] > array[index + 1]) {
                document.getElementById('result6').innerHTML = 'The element at position' + index + ' in this array is bigger than its both neighbours';
            }
            else {
                document.getElementById('result6').innerHTML = 'Element at this position is not bigger than its neighbours';
            }
        }
    }

    neighbours(arr, index);
}
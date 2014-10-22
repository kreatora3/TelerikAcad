function compare(form) {
    var firstArray = [];
    var secondArray = [];

    firstArray = (form.array1.value).replace(/\s/g, "").split('');
    secondArray = (form.array2.value).replace(/\s/g, "").split('');
    var counter = 0;

    if (firstArray.length === secondArray.length) {

        for (var i = 0; i < firstArray.length; i++) {

            if (firstArray[i] === secondArray[i]) {
                counter++;
                continue;
            }

            if (firstArray[i] < secondArray[i]) {
                document.getElementById('result2').innerHTML = 'First array is lexicographically first than second one';
                break;
            }

            if (firstArray[i] > secondArray[i]) {
                document.getElementById('result2').innerHTML = 'Second array is lexicographically first than the first one';
                break;
            }
        }
    }

    if (firstArray.length > secondArray.length) {

        for (var i = 0; i < secondArray.length; i++) {

            if (firstArray[i] < secondArray[i]) {
                document.getElementById('result2').innerHTML = 'First array is lexicographically first than second one';
                break;
            }

            if (firstArray[i] > secondArray[i]) {
                document.getElementById('result2').innerHTML = 'Second array is lexicographically first than the first one';
                break;
            }
        }
    }

    if (firstArray.length < secondArray.length) {
        for (var i = 0; i < firstArray.length; i++) {
            if (firstArray[i] < secondArray[i]) {
                document.getElementById('result2').innerHTML = 'First array is lexicographically FIRST than second one';
                break;
            }

            if (firstArray[i] > secondArray[i]) {
                document.getElementById('result2').innerHTML = 'Second array is lexicographically FIRST than the first one';
                break;
            }
        }
    }

    if (counter === firstArray.length && counter === secondArray.length) {
        document.getElementById('result2').innerHTML = 'Both arrays are lexicographically equal';
    }
}
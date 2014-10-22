function test(form) {

    var input = [];
    input = (form.array.value).replace(/\s/g, "").split('');
    var number = form.symbol.value;

    function numInArrayCounter(array, number) {
        var counter = 0;

        for (var i = 0; i < array.length; i++) {
           
                if (array[i] === number) {
                    counter++;
            }
        }

       return  'The number ' + number + ' is found ' + counter + ' times in the given array'
    }

     var result = numInArrayCounter(input, number);
     document.getElementById('result5').innerHTML = result;
}
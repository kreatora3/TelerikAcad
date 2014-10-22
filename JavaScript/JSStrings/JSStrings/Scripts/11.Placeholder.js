function placeholders(form) {
    
    var template = '{0} is the first placeholder, {1} is the second and third is {2} and all of them again {0}, {1}, {2}'

    var first = form.text1.value;
    var second = form.text2.value;
    var third = form.text3.value;
    
    function stringFormat() {
        var output = arguments[0];

        for (var i = 1; i < arguments.length; i++)
            output = output.replace(new RegExp('\\{' + (i - 1) + '\\}', "g"), arguments[i]);
        return output;
    }

    var result = stringFormat(template, first, second, third)

    document.getElementById('result11').innerHTML = result
}
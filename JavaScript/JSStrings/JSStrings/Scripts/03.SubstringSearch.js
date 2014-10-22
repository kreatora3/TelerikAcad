function subStingSearch(form) {

    var input = form.text.value;
    var subStr = form.substring.value;
    var counter = 0;
    input = input.toLowerCase();

    var count = 0;
    var index = input.indexOf(subStr);
    while (index !== -1) {
        counter++;
        index = input.indexOf(subStr, index + 1);
    }

    document.getElementById('result3').innerHTML = counter;
}
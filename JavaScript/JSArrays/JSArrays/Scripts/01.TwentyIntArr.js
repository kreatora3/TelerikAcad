function fillArr() {

    var arr = [];

    for (var i = 1; i <= 20; i++) {

        arr.push(i * 5);
    }

    document.getElementById('result1').innerHTML = arr.toString();
}
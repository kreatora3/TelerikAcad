function propertiesOrdered() {

    var docArr = [];
    var winArr = [];
    var navArr = [];

    for (var i in document) {

        docArr.push(i);
    }

    for (var i in window) {

        winArr.push(i);
    }

    for (var i in navigator) {

        navArr.push(i);
    }

    docArr.sort();
    winArr.sort();
    navArr.sort();

    document.getElementById('result4').innerHTML = 'Document max property is ' + '<span id="blue">' + docArr.shift() + '</span>' + ' and the min property is ' + '<span id="blue">' + docArr.pop() + '</span>' + '<br/>' +
        'Window max property is ' + '<span id="blue">' + winArr.shift() + '</span>' + ' and the min property is ' + '<span id="blue">' + winArr.pop() + '</span>' + '<br/>' +
        'Navigator max property is ' + '<span id="blue">' + navArr.shift() + '</span>' + ' and the min property is ' + '<span id="blue">' + navArr.pop() + '</span>';
}
function divSelector() {

    var result = document.querySelectorAll('div > div');

    document.getElementById('output').innerHTML = 'Result is...'
    for (var i = 0, len = result.length; i < len; i++) {
        document.getElementById('output').innerHTML += '<p>' + result[i].innerHTML + '</p>'
    }
    
}
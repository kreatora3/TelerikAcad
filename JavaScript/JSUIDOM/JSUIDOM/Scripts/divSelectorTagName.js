function divSelectorTag() {

    var result = document.getElementsByTagName('div');
    var divs = [];
    for (var i = 0, len = result.length; i < len; i++) {

        var currElement = result[i].children

        for (var j = 0, len1 = currElement.length; j < len1; j++) {
            if (currElement[j] instanceof HTMLDivElement) {
                divs.push(currElement[j])
            }
        }
    }
    document.getElementById('output1').innerHTML = 'Result is';
    for (var i in divs) {
        
        document.getElementById('output1').innerHTML += divs[i].innerHTML
    }
}
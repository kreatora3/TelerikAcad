
function start() {
    var number = document.getElementById('number').value;
    creatingRandomDivs(number);
}

function creatingRandomDivs(number) {

    //  reset div
    var contentDiv = document.getElementById("container");
    while (contentDiv.firstChild) { contentDiv.removeChild(contentDiv.firstChild); }

    // create divs
    var docFrag = document.createDocumentFragment();
    for (var i = 0; i < number; i++) {
        var div = document.createElement("div");
        divRandomizer(div);
        docFrag.appendChild(div);
    }
    contentDiv.appendChild(docFrag);

}

function divRandomizer(div) {
    var style = div.style;
    var height = getRandomNumber(20, 100);
    style.height = height + 'px';
    var width = getRandomNumber(20, 100);
    style.width = width + 'px';

    style.backgroundColor = getRandomColor();
    style.color = getRandomColor();

    var strong = document.createElement('strong');
    strong.innerHTML = 'div';
    div.appendChild(strong);

    style.borderRadius = getRandomNumber(0, 30) + 'px';
    style.borderColor = getRandomColor();
    var border = getRandomNumber(0, 20);
    style.borderWidth = border + 'px';
    style.borderStyle = 'solid';
    
    style.position = 'absolute';
    style.top = getRandomNumber(0, screen.availHeight - height - border) + 'px';
    style.left = getRandomNumber(0, screen.availWidth - width - border) + 'px';
}

function getRandomColor() {
    var red = getRandomNumber(0, 255);
    var green = getRandomNumber(0, 255);
    var blue = getRandomNumber(0, 255);

    return 'rgb(' + red + ',' + green + ',' + blue + ')';
}

function getRandomNumber(min, max) {
    return Math.floor(Math.random() * (max - min + 1) + min);
}


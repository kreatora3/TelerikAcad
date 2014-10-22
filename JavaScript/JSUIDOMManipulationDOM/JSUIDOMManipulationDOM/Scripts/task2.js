function createDivs() {
    // clean main div
    var contentDiv = document.getElementById("container");
    while (contentDiv.firstChild) { contentDiv.removeChild(contentDiv.firstChild); }

    
    center = {
        x: contentDiv.clientWidth / 2,
        y: contentDiv.clientHeight / 2
    }

    // set distance from center
    distance = 150;

   
    var docFrag = document.createDocumentFragment();
    var div;
    var angle;
    for (var i = 0; i < 5; i++) {
        div = document.createElement("div");
        angle = i + i * 0.25;
        positionDiv(div, center, distance, angle, 'calm');
        docFrag.appendChild(div);
    }
    contentDiv.appendChild(docFrag);
}

function positionDiv(div, center, distance, angle, action) {
    var style = div.style;
    var offset = 25;

    
    if (action == 'calm') {
        
        div.angle = angle;
    }
    else if (action == 'move') {
        div.angle += angle;
    }

    style.position = 'absolute';
    style.top = (center.y + Math.sin(div.angle) * distance) - offset + 'px';
    style.left = (center.x + Math.cos(div.angle) * distance) - offset + 'px';
}

function start() {
    var container = document.getElementById('container');
    launch(container);

    return false;
}

function launch(container) {
    var divs = container.getElementsByTagName('div');
    var i;
    var button = document.querySelector('#start');
    button.disabled = true;
    setInterval(function () { move() }, 100);

    function move() {
        for (i = 0; i < divs.length; i++) {
            positionDiv(divs[i], center, distance, 0.05, 'move')
        }
    }
}
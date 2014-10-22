function positonCheck(form) {
    var xCircle = 1;
    var yCircle = 1;
    var radius = 3;

    var xTop = 1;
    var yLeft = -1;
    var height = 2;
    var width = 6;

    var xPoint = form.x.value;
    var yPoint = form.y.value;

    var resut = Math.pow((xPoint - xCircle), 2) + Math.pow((yPoint - yCircle), 2);

    if (resut <= Math.pow(radius, 2)) {

        document.getElementById('result9').innerHTML = 'The point with coordinates ' + xPoint + ' and ' + yPoint + ' is inside the circle and'
    }
    else {
        document.getElementById('result9').innerHTML = 'The point with coordinates ' + xPoint + ' and ' + yPoint + ' is outside the circle and'
    }

    if (((xTop) >= xPoint) || (xPoint >= (xTop + width)) || (yLeft <= yPoint) || (yPoint <= ((yLeft - height)))) {
        document.getElementById('result10').innerHTML = 'outside the rectangle';

    }
    else {
        document.getElementById('result10').innerHTML = 'inside the rectangle';
    }
    
}
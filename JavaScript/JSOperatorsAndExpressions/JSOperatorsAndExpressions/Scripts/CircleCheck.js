function circleCheck(form) {
    var xCircle = 0;
    var yCircle = 5;
    var radius = 5;
    var xPoint = form.x.value;
    var yPoint = form.y.value;

    var resut = Math.pow((xPoint - xCircle), 2) + Math.pow((yPoint - yCircle), 2);

    if (resut <= Math.pow(radius,2)) {
        
        document.getElementById('result6').innerHTML = 'The point with coordinates ' + xPoint + ' and ' + yPoint + ' is inside the circle';
    }
    else {
        document.getElementById('result6').innerHTML = 'The point with coordinates ' + xPoint + ' and ' + yPoint + ' is outside the circle';
    }
}
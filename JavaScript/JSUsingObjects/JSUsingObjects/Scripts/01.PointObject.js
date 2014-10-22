function calculateDistance(form) {

    var firstX1 = form.x1.value;
    var firstY1 = form.y1.value;
    var firstX2 = form.x2.value;
    var firstY2 = form.y2.value;
    var secondX1 = form.x12.value;
    var secondY1 = form.y12.value;
    var secondX2 = form.x22.value;
    var secondY2 = form.y22.value;
    var thirdX1 = form.x13.value;
    var thirdY1 = form.y13.value;
    var thirdX2 = form.x23.value;
    var thirdY2 = form.y23.value;
    var firstDistance = 0;
    var secondDistance = 0;
    var thirdDistance = 0;
    var triangle;

    firstDistance = Math.sqrt(Math.pow((firstX1 - firstX2), 2) + Math.pow((firstY1 - firstY2), 2));
    secondDistance = Math.sqrt(Math.pow((secondX1 - secondX2), 2) + Math.pow((secondY1 - secondY2), 2));
    thirdDistance = Math.sqrt(Math.pow((thirdX1 - thirdX2), 2) + Math.pow((thirdY1 - thirdY2), 2));

    if ((firstDistance + secondDistance) > thirdDistance && (firstDistance + thirdDistance) > secondDistance && (secondDistance + thirdDistance)> firstDistance) {
        triangle = 'These lines can form triangle'
    } else {
        triangle = 'These lines cannot make triangle'
    }
    document.getElementById('result1').innerHTML = 'Distance between first 2 points is ' + firstDistance + '<br />' + 'Distance between second 2 points is ' +
        secondDistance + '<br />' + 'Distance between last 2 points is ' + thirdDistance + '<br />' + triangle;

}
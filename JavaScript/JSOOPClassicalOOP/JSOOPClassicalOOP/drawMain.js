(function () {
    var ctx = document.getElementById('canvas').getContext('2d');

    // create rect
    var rect = new Shapes.Rect(150, 150);
    rect.draw(100, 150, 'lightblue', ctx);

    // create circle
    var circle = new Shapes.Circle(50);
    circle.draw(200, 100, 'orange', ctx);

    // create line
    var line = new Shapes.Line(-75, -75);
    line.draw(100, 200, 'black', ctx);

})();
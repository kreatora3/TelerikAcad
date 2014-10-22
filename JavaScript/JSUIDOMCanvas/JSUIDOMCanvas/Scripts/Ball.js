var canvas = document.getElementById('the-canvas');
var ctx = canvas.getContext('2d');
var dx = 2;
var dy = 3;
var x = 250;
var y = 295;

function circle(x, y, r) {
    ctx.beginPath()
    ctx.fillStyle = '#f00';
    ctx.strokeStyle = '#000';
    ctx.arc(x, y, r, 0, 360 * Math.PI / 180);
    ctx.fill();
}

function clear() {
    ctx.clearRect(0, 0, canvas.width, canvas.height)
}

function draw() {
    clear()
    circle(x, y, 7)
    if (x + dx > canvas.width || x + dx < 0)
        dx = -dx;
    if (y + dy > canvas.height || y + dy < 0)
        dy = -dy;

    x += dx;
    y += dy;
}

setInterval(draw, 12)
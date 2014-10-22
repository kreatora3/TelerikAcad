var canvas = document.getElementById('the-canvas');
var ctx = canvas.getContext('2d');

ctx.lineWidth = 2;
ctx.save();

// head
ctx.fillStyle = "#90CAD7";
ctx.strokeStyle = "#22545F";
ctx.beginPath();
ctx.scale(1, 0.9);
ctx.arc(250, 260, 70, 0, 2 * Math.PI);
ctx.fill();
ctx.stroke();

// eyes
ctx.restore();
ctx.strokeStyle = "#22545F";
ctx.save();
ctx.beginPath();
ctx.scale(1, 0.6);
ctx.arc(210, 360, 10, 0, 2 * Math.PI);
ctx.stroke();

ctx.beginPath();
ctx.arc(260, 360, 10, 0, 2 * Math.PI);
ctx.stroke();

ctx.restore();
ctx.save();
ctx.fillStyle = "#22545F";
ctx.beginPath();
ctx.scale(0.7, 1);
ctx.arc(296, 216, 5, 0, 2 * Math.PI);
ctx.fill();

ctx.beginPath();
ctx.arc(368, 216, 5, 0, 2 * Math.PI);
ctx.fill();

// nose
ctx.restore();
ctx.save();
ctx.beginPath();
ctx.moveTo(235, 220);
ctx.lineTo(225, 250);
ctx.lineTo(240, 250);
ctx.stroke();

// mouth
ctx.restore();
ctx.save();
ctx.rotate(6 * Math.PI / 180);
ctx.beginPath();
ctx.scale(1, 0.3);
ctx.arc(260, 820, 27, 0, 2 * Math.PI);
ctx.lineWidth = 3;
ctx.stroke();

// hat
ctx.restore();
ctx.lineWidth = 3;
ctx.strokeStyle = "black";
ctx.save();
ctx.fillStyle = "#396693";
ctx.strokeStyle = "black";
ctx.beginPath();
ctx.scale(1, 0.2);
ctx.arc(250, 900, 100, 0, 2 * Math.PI);
ctx.fill();
ctx.stroke();

ctx.restore();
ctx.lineWidth = 2;
ctx.save();
ctx.fillStyle = "#396693";
ctx.beginPath();
ctx.scale(1, 0.3);
ctx.arc(250, 250, 50, 0, 2 * Math.PI);
ctx.fill();
ctx.stroke();

ctx.lineTo(300, 250);
ctx.arc(250, 580, 50, 0, Math.PI);
ctx.lineTo(200, 240);
ctx.fill();
ctx.stroke();
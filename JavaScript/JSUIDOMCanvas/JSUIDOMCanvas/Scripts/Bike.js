
var canvas = document.getElementById('the-canvas');
var ctx = canvas.getContext('2d');

ctx.beginPath();
ctx.fillStyle = '#90CAD7';
ctx.strokeStyle = '#307587';
ctx.lineWidth = 2;
ctx.arc(120, 300, 60, 0, 2 * Math.PI);
ctx.fill();
ctx.stroke();

ctx.beginPath();
ctx.fillStyle = '#90CAD7';
ctx.strokeStyle = '#307587';
ctx.arc(350, 300, 60, 0, 2 * Math.PI);
ctx.fill();
ctx.stroke();

ctx.beginPath();
ctx.moveTo(120, 300);
ctx.lineTo(190, 220);
ctx.lineTo(330, 220);
ctx.lineTo(220, 300);
ctx.closePath();
ctx.stroke();

ctx.beginPath();
ctx.moveTo(220, 300);
ctx.lineTo(175, 180);
ctx.stroke();

ctx.beginPath();
ctx.moveTo(150, 180);
ctx.lineTo(200, 180);
ctx.stroke();

ctx.beginPath();
ctx.moveTo(350, 300);
ctx.lineTo(320, 170);
ctx.lineTo(350, 140);
ctx.stroke();

ctx.beginPath();
ctx.moveTo(320, 170);
ctx.lineTo(280, 180);
ctx.stroke();

ctx.beginPath();
ctx.strokeStyle = '#307587';
ctx.arc(220, 300, 15, 0, 2 * Math.PI);
ctx.stroke();
var canvas = document.getElementById('the-canvas');
var ctx = canvas.getContext('2d');

ctx.fillStyle = '#975B5B'

ctx.strokeStyle = "black"
ctx.fillRect(50, 200, 290, 220);
ctx.strokeRect(50, 200, 290, 220);
ctx.beginPath();
ctx.moveTo(50, 200);
ctx.lineTo(195, 40);
ctx.lineTo(340, 200);
ctx.fill();
ctx.stroke();

ctx.fillStyle = 'black'
ctx.fillRect(80, 230, 100, 50)
ctx.fillRect(210, 230, 100, 50)
ctx.fillRect(210, 315, 100, 50)

ctx.beginPath();

ctx.strokeStyle = '#975B5B'
ctx.moveTo(80, 255)
ctx.lineTo(180, 255)

ctx.moveTo(210, 255);
ctx.lineTo(310, 255)

ctx.moveTo(210, 340)
ctx.lineTo(310, 340)

ctx.moveTo(130, 230)
ctx.lineTo(130, 280)

ctx.moveTo(260, 230);
ctx.lineTo(260, 280);

ctx.moveTo(260, 315);
ctx.lineTo(260, 365);

ctx.stroke()


ctx.strokeStyle = 'black'
ctx.moveTo(80, 420)
ctx.lineTo(80, 320);
ctx.bezierCurveTo(80, 320, 130, 280, 180, 320)
ctx.lineTo(180, 420)
ctx.moveTo(130, 420)
ctx.lineTo(130, 302)
ctx.stroke()
ctx.beginPath()
ctx.arc(110, 380, 5, 0, 360 * Math.PI / 180)
ctx.stroke()
ctx.beginPath()
ctx.arc(150, 380, 5, 0, 360 * Math.PI / 180)
ctx.stroke()
ctx.beginPath()
ctx.fillStyle = '#975B5B'
ctx.moveTo(260, 160)
ctx.lineTo(260, 80)
ctx.lineTo(280, 80)
ctx.lineTo(280, 160)
ctx.fill()
ctx.stroke()
ctx.beginPath()


ctx.scale(1, 0.25)
ctx.arc(270, 320, 10, 0, 360 * Math.PI / 180)

ctx.fill()
ctx.stroke()
var Shapes = (function () {

    var Rect = (function () {
        function Rect(width, height) {
            this.width = width;
            this.height = height;
        }

        Rect.prototype.draw = function (x, y, color, ctx) {
            ctx.save();
            ctx.fillStyle = color;
            ctx.fillRect(x, y, this.width, this.height);
            ctx.restore();
        };

        return Rect;
    }());


    var Circle = (function () {
        function Circle(radius) {
            this.radius = radius;
        }

        Circle.prototype.draw = function (x, y, color, ctx) {
            ctx.save();
            ctx.fillStyle = color;
            ctx.beginPath();
            ctx.arc(x, y, this.radius, 0, 2 * Math.PI);
            ctx.fill();
            ctx.restore();
        };

        return Circle;
    }());

    var Line = (function () {
        function Line(dx, dy) {
            this.dx = dx;
            this.dy = dy;
        }

        Line.prototype.draw = function (x, y, color, ctx) {
            ctx.save();
            ctx.strokeStyle = color;
            ctx.beginPath();
            ctx.moveTo(x, y);
            ctx.lineTo(x + this.dx, y + this.dy);
            ctx.stroke();
            ctx.restore();
        };

        return Line;
    }());


    return {
        Rect: Rect,
        Circle: Circle,
        Line: Line,
    };
})();
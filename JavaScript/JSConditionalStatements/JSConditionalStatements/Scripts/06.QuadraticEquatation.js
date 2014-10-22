function quadEquatSolver(form) {

    var a = parseInt(form.int.value);
    var b = parseInt(form.secondInt.value);
    var c = parseInt(form.thirdInt.value);

    var discriminant=(Math.pow(b,2)-(4*a*c));

    if (discriminant < 0)
    {
        document.getElementById('result6').innerHTML = 'There are no real roots for this quadratic equatation';
    }
    else if (discriminant > 0)
    {
        var xFirst = (-b + Math.sqrt(discriminant)) / (2 * a);
        var xSecond = (-b - Math.sqrt(discriminant)) /( 2 * a);
        document.getElementById('result6').innerHTML = 'Quadratic equatation has two roots: ' +  xFirst.toFixed(3) + ' and ' + xSecond.toFixed(3);
    }
    else
    {
        var x = -(b / (2 * a));
        document.getElementById('result6').innerHTML = 'Quadratic equatation has exactly one root and it value is: ' + x.toFixed(3);

    }
}
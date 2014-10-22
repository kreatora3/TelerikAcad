function areaCalculatorTrapezoid(form) {
    var a = form.a.value;
    var b = form.b.value;
    var h = form.h.value;

    document.getElementById('result8').innerHTML = 'The area of the trapezoid is ' + (((parseInt(a) + parseInt(b)) * parseInt(h) )/ 2);
}
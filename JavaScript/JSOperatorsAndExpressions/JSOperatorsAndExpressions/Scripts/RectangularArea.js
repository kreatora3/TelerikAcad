function areaCalculator(form) {
    var a = form.height.value;
    var b = form.width.value;

    document.getElementById('result3').innerHTML = "The rectangular's area is" + ' ' + (parseInt(a) * parseInt(b));
}
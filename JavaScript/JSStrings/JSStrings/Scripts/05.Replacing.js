function replacingNonBreakingSpace(form) {
    var text = form.text.value;

    var newStr = text.replace(/\s/g, '&amp;nbsp;');

    document.getElementById('result5').innerHTML = newStr;
}
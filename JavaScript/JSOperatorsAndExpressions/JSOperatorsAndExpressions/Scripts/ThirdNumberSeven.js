function thirdNumberCheck(form) {
    var d = form.num.value;
    console.log(typeof d)
    var position = 3;
    var index = (d.toString().length - position);
    console.log(typeof index)

    if (d.toString()[index] === '7' ) {
        
        document.getElementById('result4').innerHTML = 'The third digit of this number is seven';
    }

    else {
        document.getElementById('result4').innerHTML = 'The third digit of this number is not seven';
    }
}
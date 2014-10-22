function checkExpression(form) {

    var input = form.expression.value;

    var count = 0
   
    str = input.split(""); 

    if (str[0] == ")" || str[str.length - 1] == "(") {
        document.getElementById('result2').innerHTML = 'Incorrect expression' 
    } else {
        for (var i = 0; i < str.length; i++) {
            if (str[i] == ")" && str[i - 1] == "(") {
                document.getElementById('result2').innerHTML = 'Incorrect expression'
                break;
            } else {
                if (str[i] == "(") count++;
                else if (str[i] == ")") count--;
            }
        };

        if (count < 0) {
            document.getElementById('result2').innerHTML = 'Incorrect expression'
        } else if (count == 0) {
            document.getElementById('result2').innerHTML = 'Correct expression'
        } else {
            document.getElementById('result2').innerHTML = 'Incorrect expression'
        }
    }

}
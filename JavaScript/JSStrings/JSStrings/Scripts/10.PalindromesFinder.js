function palindromesFinder(form) {

    var text = form.text.value;

    var words = text.replace(/\,/g,' ').replace(/\./g,' ').split(' ');
    var result = [];

    for  (var i = 0; i < words.length; i++) {
        var palindromeWord = true;
        for (var j = 0; j < ~~(words[i].length / 2) ; j++) {
            if (words[i][j] !== words[i][(words[i].length - 1 - j)]) {
                palindromeWord = false;
                break;
            }
        }
        if (palindromeWord && words[i].length > 1) {
           
            result.push(words[i]);
        }
    }

    document.getElementById('result10').innerHTML = result.join(' ');
}
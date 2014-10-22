function countWords(form) {

    var text = form.text.value;
    var word = form.word.value;
    var checked = form.checkBox.checked;
    var result;
    var counter = 0;

    function count(text, word, caseInsensitive){
        switch (arguments.length) {
            case 2:
                checked = checked || false;
                result = text.split(' ');
                for (var i = 0; i < result.length; i++) {
                    if (word.toLowerCase() === (result[i]).toLowerCase()) {
                        counter++;
                    }
                }
                document.getElementById('result3').innerHTML = 'This word was found ' + counter + 'time(s)';
                break;
            case 3:
                result = text.split(' ');
                for (var i = 0; i < result.length; i++) {
                    if (word === result[i]) {
                        counter++;
                    }
                }
                document.getElementById('result3').innerHTML = 'This word was found ' + counter + 'time(s)';
                break;
        }
    }
    if (checked) {
        count(text, word, checked)
    } else {
        count(text, word)
    }
    
}
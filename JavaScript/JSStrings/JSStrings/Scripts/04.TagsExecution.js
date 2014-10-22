function tagExecutor(form) {

    var text = form.text.value;

    function changeCase(str) {
        var tagsLen = { 'm': 7, 'u': 6, 'l': 7 },
            stack = [],
            result = [];
        for (var i = 0; i < str.length; i++) {
            if (str[i] === '<') {
                if (str[i + 1] === '/') {
                    i += tagsLen[stack.pop()] + 2;
                } else {
                    stack.push(str[i + 1]);
                    i += tagsLen[str[i + 1]] + 1;
                }
            } else {
                var tag = stack[stack.length - 1];
                if (tag === 'm') {
                    if (Math.random() < 0.5) result.push(str[i].toUpperCase());
                    else result.push(str[i].toLowerCase());
                } else if (tag === 'u') {
                    result.push(str[i].toUpperCase());
                } else if (tag === 'l') {
                    result.push(str[i].toLowerCase());
                } else {
                    result.push(str[i]);
                }
            }
        }
        return result.join('');
    }

    document.getElementById('result4').innerHTML = changeCase(text);
}

function replaceA(form) {
    
    var code = form.htmlCode.value;

    var result = code.replace(/<a href="/gi, "[URL=").replace(/">/gi,"]").replace(/<\/a>/gi,"[/URL]")

    document.getElementById('result8').innerHTML = result
}
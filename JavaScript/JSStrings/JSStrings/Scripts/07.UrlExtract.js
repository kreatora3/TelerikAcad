function urlExtract(form) {

    var url = form.url.value;

    function extracter(str) {
        var regexParser = /(https?|ftp):\/\/([^\/]+)\/(.*)/i;
        var result = str.match(regexParser);
        return {
            protocol: result[1],
            server: result[2],
            resource: result[3]
        };
    }

    document.getElementById('result7').innerHTML = JSON.stringify(extracter(url))
}
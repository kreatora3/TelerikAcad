function mailExtract(form) {

    var mail = form.mail.value;

    function extractEmails(text) {
        return text.match(/([a-zA-Z0-9._-]+@[a-zA-Z0-9._-]+\.[a-zA-Z0-9._-]+)/gi);
    }

    document.getElementById('result9').innerHTML = extractEmails(mail).join(' and ');

    /*Of course, you still have to pay to receive text phonenumber@vtext.com  messages from other people. If somebody replies to a text message that you sent 
    as an IM or e-mail, his reply will come to you  phonenumber@tmomail.net in the format you initially sent it in, and reading it won't*/
}
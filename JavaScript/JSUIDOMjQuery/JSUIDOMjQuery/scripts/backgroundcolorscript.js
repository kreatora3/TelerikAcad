/// <reference path="../libs/jquery-2.1.1.min.js" />

function setColor() {
    var $color = $('#colorpicker').val(),
    $body = $('body');

    $body.css('background-color', $color);
}

$('#submit').on('click', setColor);
/// <reference path="../libs/jquery-2.1.1.min.js" />

function slider() {
    var DIV_HEIGHT = 304,
        CONTROL_HEIGHT = 300,
        BUTTONS_WIDTH = 100,
        SLIDESHOW_HEIGHT = 50,
        DIV_WIDTH = 300,
        SLIDESHOW_WIDTH = DIV_WIDTH + (2 * BUTTONS_WIDTH) + 4,
        $div = $('div'),
        $buttons = $('.buton'),
        $slideShowButton = $('#toggleSlideShow')
    $container = $('#container');

    $buttons.height(CONTROL_HEIGHT);
    $div.height(DIV_HEIGHT);
    $buttons.width(BUTTONS_WIDTH);
    $div.width(DIV_WIDTH);
    $slideShowButton.height(SLIDESHOW_HEIGHT);
    $slideShowButton.width(SLIDESHOW_WIDTH);
    $buttons.css('float', 'left')
    $div.css('float', 'left')

    $container.children().hide();

    var $firstElement = $container.children().first();
    var $lastElement = $container.children().last();
    var $currentElement = $firstElement;
    $currentElement.show();

    function next() {
        $currentElement.fadeOut();
        $currentElement = $currentElement.next();
        if ($currentElement.length < 1) {
            $currentElement = $firstElement;
        }
        $currentElement.fadeIn();
    }

    function previous() {
        $currentElement.fadeOut();
        $currentElement = $currentElement.prev();
        if ($currentElement.length < 1) {
            $currentElement = $lastElement;
        }
        $currentElement.fadeIn();
    }

    var toggle = false;

    function auto(bool) {

        if (bool) {
            interval = setInterval(next, 1000);
        }
        else {
            clearInterval(interval);
        }
    }

    function clickOnToggle() {
        toggle = !toggle;
        auto(toggle);

        if (toggle) {
            $slideShowButton.html('Slide Show OFF');
        }
        else {
            $slideShowButton.html('Slide Show ON');
        }

    }

    $('#next').on('click', next);
    $('#prev').on('click', previous);
    $('#toggleSlideShow').on('click', clickOnToggle);
}

slider();
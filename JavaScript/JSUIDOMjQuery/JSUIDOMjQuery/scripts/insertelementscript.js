/// <reference path="../libs/jquery-2.1.1.min.js" />

(function addElement() {
    var $baseElement = $('#firstelement'),
        newElementContent = 'element ',
        newElementNumber = 1;

    function addBefore() {
        $("<div>" + newElementContent + newElementNumber + "</div>").insertBefore($baseElement);       
        newElementNumber += 1;
    }

    function addAfter() {        
        $("<div>" + newElementContent + newElementNumber + "</div>").insertAfter($baseElement);
        newElementNumber += 1;
    }

    $('#pre').on('click', addBefore);
    $('#post').on('click', addAfter);
}());
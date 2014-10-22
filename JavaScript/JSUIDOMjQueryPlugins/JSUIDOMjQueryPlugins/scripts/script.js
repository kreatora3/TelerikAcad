/// <reference path="../libs/jquery-2.1.1.min.js" />

$.fn.dropdown = function () {
    var $this = $(this),
        $dFrag = $(document.createDocumentFragment()),
        $div = $('<div />').addClass('dropdown-list-container'),
        $ul = $('<ul />').addClass('dropdown-list-options'),
        $result = $('<div />').addClass('result')


    $dFrag.append($div.append($ul)).append($result);
    $this.hide();

    for (var i = 0; i < $this.children().length; i++) {
        $ul.append($('<li />').addClass('dropdown-list-option').attr('data-value', i).html($($this.children()[i]).text()));
    }

    $('body').append($dFrag);
    $('.dropdown-list-option').on('click', selectElement);

    function selectElement() {
        var $self = $(this);
        $this.children().removeAttr('selected');
        $($this.children()[+($self.attr('data-value'))]).attr('selected', 'selected');
        $('.result').html('option ' + $self.html() + ' selected --> Check the console to see the attribute change' )
    }
}

$('#dropdown').dropdown()
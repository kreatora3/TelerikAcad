/// <reference path="jquery.min.js" />
$.fn.tabs = function () {
    var $this = $(this),
        container = $this
        //content = $('.tab-item-content')

    $this.addClass('tabs-container');   
    container.find('.tab-item-content').hide()
   
    $this.find('.tab-item-title').on('click', function (ev) {
        var $this = $(this)
        
        container.find('.current').removeClass('current')        
        $this.parent().addClass('current')

        container.find('.tab-item-content').hide()
        $this.parent().find('.tab-item-content').show();
    })
};

//$('#tabs-container').tabs();
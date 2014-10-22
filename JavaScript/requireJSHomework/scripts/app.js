   require.config({
        paths: {
            'handlebars': 'libs/handlebars.min',
            'jquery': 'libs/jquery.min',
            'people': 'comboBox/people',
            'combo': 'comboBox/comboBox',
            'controls': 'comboBox/controls'

        }
    });

    /*require(['jquery'], function ($) {
     console.log($('#container'))
     })*/
    require(['jquery', 'controls', 'people' ], function ($, controls, people) {
        $(document).ready(function (){
            var peopleContainer = $('#container')
            var comboBox = controls.ComboBox(people);
            var template = $("#person-template").html();
            var comboBoxHtml = comboBox.render(template);

            peopleContainer.append(comboBoxHtml);
            var items = $('.person-item')
            items.hide();
            items.first().show();
            items.on('click', function(){
                $(this).show().siblings().slideToggle('slow')
            })

        });

    });

/*
require(['comboBox/comboBox', 'people'], function (Combo, people) {
    ComboBox(people)
});
*/


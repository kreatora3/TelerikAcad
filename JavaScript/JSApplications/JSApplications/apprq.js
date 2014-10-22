(function () {
   'use strict'
    require.config({
            paths: {
                jquery: 'libs/jquery',
                httpRq: 'httpRequest',
                studentSystem: 'studentSystem'
            }
        });

 require(['jquery', 'studentSystem'], function($, studentSystem){

     console.log('wtf')
 });

}());
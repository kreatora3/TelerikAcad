define(['jquery'], function ($) {

    // jQuery ajax return promise
    return{

        getJSON: function (url, callback, headers) {

        return $.ajax({
            url: url,
            headers: headers,
            data: undefined,
            dataType: 'json',
            success: callback
        });
    },
        postJSON: function (url, callback, headers, data ) {
            return $.ajax({
                url: url,
                headers: headers,
                data: data,
                dataType: 'json',
                success: callback
            });
        }

    }
}())
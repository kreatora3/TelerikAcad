var domModule = (function () {
    var MAX_BUFFER_SIZE = 100,
                 buffer = [];

    function appendChild(element, selector) {
        var parent = document.querySelector(selector);
        parent.appendChild(element);
    }

    function removeChild(parentSelector, childSelector) {
        var parent = document.querySelector(parentSelector);
        var child = parent.querySelector(childSelector);
        parent.removeChild(child);
    }

    function addHandler(selector, eventType, eventHandler) {
        var elements = document.querySelectorAll(selector),
             i;        
        for (i = 0; i < elements.length; i += 1) {
            elements[i].addEventListener(eventType, eventHandler);
        }
    }

    function addToBuffer(selector, element) {
        var parent = document.querySelector(selector);
        if (!buffer[parent]) {
            buffer[parent] = document.createDocumentFragment();
        }

        buffer[parent].appendChild(element);
        
        if (buffer[parent].childElementCount === MAX_BUFFER_SIZE) {
            parent.appendChild(buffer[parent]);
        }
    }

    function getElementBySelector(selector) {
        return document.querySelector(selector);
    }

    function getElementsBySelector(selector) {
        return document.querySelectorAll(selector);
    }

    return {
        appendChild: appendChild,
        removeChild: removeChild,
        addHandler: addHandler,
        addToBuffer: addToBuffer,
        getElementBySelector: getElementBySelector,
        getElementsBySelector: getElementsBySelector
    }
})();
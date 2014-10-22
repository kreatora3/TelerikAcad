
var p = document.createElement('p');
p.innerText = '<p> appended through buffer ';
var newDiv;
for (var i = 0; i < 99; i++) {
    addDivToTestDiv(i + 1);
}

function addDivToTestDiv(num) {
    newDiv = p.cloneNode(true);
    newDiv.innerText += ' ' + num;
    domModule.addToBuffer('#test-div', newDiv);
}

domModule.addHandler('#fill-buffer', 'click', function () {
    addDivToTestDiv(100);
    domModule.getElementBySelector('#fill-buffer').disabled = true;
});

domModule.addHandler('.button-test', 'click', function () {
    domModule.getElementBySelector('#test-div').innerText = 'Event handler added successfully!'
});

domModule.addHandler('#remove-first-li', 'click', function (){
    domModule.removeChild('ul', 'li:first-child');
});

function test(form) {
    var arr = [];
    var arr = form.array.value.split('');
    var itemToremove = form.element.value;

    Array.prototype.remove = function (item) {

        for (var i = 0; i < this.length; i++) {
            
            if (this[i] === item){

                this.splice(i, 1);
            }
        }
    }

    arr.remove(itemToremove);

    document.getElementById('result2').innerHTML = arr.join(' ');
}
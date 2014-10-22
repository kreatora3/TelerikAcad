window.onload = function () {
    var creation = document.getElementsByName("elementDoType")[0];
    var doType = document.getElementById("btnCreate");
    
    var outArea = document.getElementById("output");
    var hideBtn = document.getElementById("hideEl");
    var showBtn = document.getElementById("showEl");

    doType.addEventListener("click", elDo);
    hideBtn.addEventListener("click", hideFunc);
    showBtn.addEventListener("click", showFunc);


    function elDo() {
        var newEl = document.createElement('li');
        newEl.innerHTML = creation.value;
        var del = document.createElement('strong');
        del.onclick = delElement;
        del.innerHTML = '<button>Delete</button>'
        newEl.appendChild(del);
        outArea.appendChild(newEl);
    };

    function delElement() {
        this.parentNode.parentNode.removeChild(this.parentNode);
    }

    function hideFunc() {
        outArea.style.display = 'none';

    }
    function showFunc() {
        outArea.style.display = '';
    }
}

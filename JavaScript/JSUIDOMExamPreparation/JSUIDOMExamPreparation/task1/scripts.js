function createCalendar(selector, events) {

    var calendarContainer = document.querySelector(selector),
        div = document.createElement('div'),
        dayTitle = document.createElement('span'),
        dayEvent = document.createElement('div'),
        monthSize = 30,
        weekDays = ['Sun', 'Mon', 'Tue', 'Wed', 'Thu', 'Fri', 'Sat'],
        clicked = null;

    dayEvent.className = 'event'
    dayEvent.innerHTML = '&nbsp'
    document.body.style.margin = 0;
    document.body.style.padding = 0;

    div.style.height = '180px';
    div.style.width = '180px';
    div.style.border = "1px solid black"
    div.style.display = 'inline-block'
    div.style.margin = 0;
    div.style.padding = 0;

    dayTitle.style.background = '#ccc'
    dayTitle.style.display = 'block'
    dayTitle.style.borderBottom = "1px solid black"
    dayTitle.style.textAlign = "center"
   var  dfrag = document.createDocumentFragment();

    for (var i = 0; i < monthSize; i++) {
        var node = div.cloneNode(true);
        var title = dayTitle.cloneNode(true)
        var contentDiv = dayEvent.cloneNode(true)

        node.appendChild(title)
        node.appendChild(contentDiv)
        title.innerHTML = weekDays[i % 7] + ' ' + (i + 1) + ' ' + 'June 2014'
        node.addEventListener('click', onMouseClick)
        node.addEventListener('mouseover', onMouseover)
        node.addEventListener('mouseout', onMouseout)
        dfrag.appendChild(node)
    }   

    calendarContainer.appendChild(dfrag);    

    for (var i = 0; i < events.length; i++) {
        var event = events[i];
        calendarContainer.children[event.date - 1].querySelector('.event').innerHTML = event.title + ' ' + event.date + ' ' + event.hour + ' ' + event.duration;
    }

    function onMouseover(ev) {
       this.style.background ='green'
    }

    function onMouseout(ev) {
        this.style.background = ''
        //this.firstChild.style.background ='#ccc'
    }
    function onMouseClick(ev) {
        if (clicked) {
            clicked.style.background = '#ccc';
        }

        this.firstChild.style.background = 'red'
        clicked = this.firstChild;
    }
   
}

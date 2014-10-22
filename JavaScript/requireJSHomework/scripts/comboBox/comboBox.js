define(['jquery', 'handlebars'], function ($, hadlebars) {

    function ComboBox(people) {
        this.people = people
    }

    ComboBox.prototype.render = function (template) {
        var source = template
        var peopleTemplate = Handlebars.compile(source);
        return peopleTemplate({
            people: this.people})

    }
    return ComboBox;
})


/* var peopleContainer = $('#container'); */

/*  peopleContainer.html(peopleTemplate())*/
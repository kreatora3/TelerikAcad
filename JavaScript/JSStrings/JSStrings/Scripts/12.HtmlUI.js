function getPeopleList(people, template) {
    var ul = document.createElement('ul');

    for (var i = 0; i < people.length; i++) {
        var curLi = document.createElement('li');
        var curLiContent = template.replace("-{name}-", people[i].name).replace("-{age}-", people[i].age);
        curLi.innerHTML = curLiContent;
        ul.appendChild(curLi);
    }

    return ul;
}

function onGenerateUl() {
    onGenerateTemplate();
    var template = document.getElementById('list-item').innerHTML;
    var people = [{ name: "Pesho", age: 24 }, { name: "Tosho", age: 11 }, { name: "Gosho", age: 52 }, { name: "Slavi", age: 44}];;

    var ul = getPeopleList(people, template);

    document.getElementById('result').innerHTML = "";
    document.getElementById('result').appendChild(ul);
}

function onGenerateTemplate() {
    var nameStyle = document.getElementById('nameStyle').value;
    var ageStyle = document.getElementById('ageStyle').value;

    var openName = "<" + nameStyle + ">";
    var closeName = "</";
    var indexSpaceNameStyle = nameStyle.indexOf(' ');
    if (indexSpaceNameStyle > -1) {
        closeName += nameStyle.substring(0, indexSpaceNameStyle);
    }
    else {
        closeName += nameStyle;
    }
    closeName += ">";

    var openAge = "<" + ageStyle + ">";
    var closeAge = "</";
    var indexSpaceAgeStyle = ageStyle.indexOf(' ');
    if (indexSpaceAgeStyle > -1) {
        closeAge += nameStyle.substring(0, indexSpaceAgeStyle);
    }
    else {
        closeAge += ageStyle;
    }
    closeAge += ">";

    var newStyle = openName + "-{name}-" + closeName + " " + openAge + "-{age}-" + closeAge;
    document.getElementById('list-item').innerHTML = newStyle;
}
var addElementBtn = document.getElementById('addElementBtn'),
                circlesFaster = document.getElementById('circlesFaster'),
                rectsFaster = document.getElementById('rectsFaster');


addElementBtn.addEventListener('click', function () {
    moveMod.createMovingElement('circle');
    moveMod.createMovingElement('rect');
});

circlesFaster.addEventListener('click', moveMod.moveCirclesFaster);
rectsFaster.addEventListener('click', moveMod.moveRectsFaster);
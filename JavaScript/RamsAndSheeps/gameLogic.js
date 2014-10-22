(function(){
    var num = 0,
        sheep = 0,
        score = 0,
        rams = 0

    function getRandomNumber () {
        var min = 1000;
        var max = 9999;
        var number = Math.floor(Math.random() * (max - min + 1)) + min;
        return number.toString();
    }

    function startGame() {
        $('#play-btn').hide('slow');
        $('#number-container').show('slow');
        $('#msg').text('Guess the four-digit number');
        $('#number').val('');
        $('#name').val('');
        num = getRandomNumber();
        while(hasRepetitiveDigit(num) ) {
            num = getRandomNumber();
        }
        // console.log(num)   // Uncomment to resolve the number in 1 try and see the local storage functions working
    }

    function hasRepetitiveDigit(num) {
        var count= 0,
            numAsString=num.toString(),
            digitIndex;

        for (var i = 0; i < 4; i++) {
            digitIndex = numAsString.indexOf(numAsString[i].toString());

            while (digitIndex !== -1) {
                count++;
                digitIndex = numAsString.indexOf(numAsString[i], digitIndex + 1);
            }
            if(count>1){
                return true;
            }
            count=0;
        }
        return false;
    }

    function checkNumber() {
        var value = $('#number').val(),
            $sheep=$('#sheep'),
            $rams=$('#rams');
        rams = getRams(value);
        sheep = getSheep(value);

        if (value < 1000 || value> 9999) {
            $('#msg').text('Enter just 4 digits please');
            $sheep.text('');
            $rams.text('');
            return;
        }
        else if(!isFinite(value)){
            $('#msg').text('Don\'t use letters');
            $sheep.text('');
            $rams.text('');
            return;
        }
        else if(hasRepetitiveDigit(value)){
            $('#msg').text('Number should consists of unique digits');
            $sheep.text('');
            $rams.text('');
            return;
        }
        else {
            $('#msg').text('Enter four-digit number');
        }

        $sheep.text("Sheep: " + sheep);
        $rams.text("Rams: " + rams);

        if (rams === 4) {
            $('#msg').text('Enter your name');
            $('#number-container').hide('slow');
            $('#name-container').show('slow');
        }
        score += 1;
    }

    function getSheep(value) {
        var sheepCount=0;
        for (var i = 0; i < value.length; i++) {
            if (value[i] !== num[i] && value.indexOf(num[i]) !== -1) {
                if(rams===3) {
                    continue;
                }
                sheepCount++;
            }
        }
        return sheepCount;
    }

    function getRams(value){
        var ramsCount=0;
        for (var i = 0; i < value.length; i++) {
            if(value[i]===num[i]){
                ramsCount++;
            }
        }
        return ramsCount;
    }

    function keepScore() {
        var name=$('#name').val();

        if(name.length<=1){
            $('#msg').text('Invalid name.');
            return;
        }
        localStorage.setItem(name,score);
        score=0;
        $('#name-container').hide('slow');
        $('#play-btn').show('slow');
        name='';
        $('#number').val('');
        $('#sheep').text("Sheep: 0");
        $('#rams').text("Rams: 0");
        loadScore();
    }
    function loadScore() {
        var highscores = [],
            list = [];

        for (var i = 0; i < localStorage.length; i++) {
            var nickname = localStorage.key(i),
                score = localStorage.getItem(nickname)

            highscores.push([nickname, score]);
        }

        highscores.sort(function (a, b) {
            a = parseInt(a[1]);
            b = parseInt(b[1]);

            return a < b ? -1 : (a > b ? 1 : 0);
        });

        var count = 1;
        for (var player in highscores) {
            list.push(count + '. ' + highscores[player][0] + ' - ' + highscores[player][1] + ' tries.');
            count++;
        }
        $('#scores').html(list.join('<br/>'));
    }

    function bindEvents() {
        $('#play-btn').click(function () {
            startGame();
        });

        $('#check-btn').click(function () {
            checkNumber();
        });

        $('#submit-btn').click(function () {
            keepScore()
        });
        $('#clear-btn').click(function () {
            localStorage.clear();
            loadScore();
        });
    }

    $(document).ready(function () {
        loadScore();
        bindEvents();
    });
}())
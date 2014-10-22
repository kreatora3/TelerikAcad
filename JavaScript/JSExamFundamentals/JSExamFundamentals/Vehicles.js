function solve(input) {

    var s = parseInt(input[0])
    var truck = 10;
    var car = 4;
    var trike = 3;
    var counter = 0
    var numbers = [3, 4, 10]
    var sum = 0

    for (var i = 1; i <= ~~(s/numbers[0]); i++) {
        sum += numbers[0];
        for (var j = 1; j <= ~~(s/numbers[1]); j++) {
            sum += numbers[0]+numbers[1]
            for (var k = 1; k <= ~~(s/numbers[2]); k++) {
                sum += (numbers[0] * i + numbers[1] * j + numbers[2] * k)
                if (sum === s) {
                    counter++
                }
                if (sum > s) {
                    sum = 0;
                    break;
                }
                
            }
        }
    }

    //for (var i = 1; i < Math.pow(2, numbers.length) ; i++) {
    //    var sum = 0
    //    for (var j = 0; j < numbers.length; j++) {

    //        sum += ((i >> j) & 1) * numbers[j]
    //    }
    //}
    //if (sum === s) {
    //    counter++;
    //}
    console.log(counter)
}

var input = ['40'];

solve(input);
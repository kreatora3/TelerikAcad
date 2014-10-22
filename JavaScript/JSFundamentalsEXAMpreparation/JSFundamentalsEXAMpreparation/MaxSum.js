function solve(input) {

    var maxSum = -Infinity;
    var sum = 0;
    var test = input.map(Number)

    for (var i = 1; i < input.length; i++) {
        for (var j = i; j < input.length; j++) {
            sum += test[j];

            if (maxSum < sum) {
                maxSum = sum;
            }
        }
        sum = 0;
    }
    console.log(maxSum)
}

var input = [
    '6', 
    '1',
    '3',
    '-5',
    '8',
    '7',
    '-6',
]

solve(input)
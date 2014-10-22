function solve(input) {

    var valley = input[0].split(',').map(Number);
    var patternNumbers = input[1].split(',').map(Number);
    var patterns = []
    var maxSum = -Infinity
    var currentSum = 0
    var currentIndex = 0
    var currentPatternIndex = 0
    var visited = [];

    function falseReload(visited) {
        for (var i = 0; i < valley.length; i++) {
            visited[i] = false;
        }
        return visited
    }
    for (var i = 0; i < patternNumbers; i++) {
        patterns.push(input[i+2].split(',').map(Number))
    }
   
    for (var i = 0; i < patternNumbers; i++) {

        currentPatternIndex = 0
        currentSum = 0;
        currentIndex = 0;
        visited = falseReload(visited)
        while (true) {
            
            if (visited[currentIndex] === true) {
                break;
            }

            currentSum += valley[currentIndex];
            visited[currentIndex] = true;

            
            if (currentPatternIndex >= patterns.length) {
                currentPatternIndex = 0;
            }
            currentIndex += patterns[i][currentPatternIndex]
            currentPatternIndex++;
        }
        if (currentSum > maxSum) {

            maxSum = currentSum;
        }
       
    }
   
    console.log(maxSum)
}

var input = [
    '1, 3, -6, 7, 4 ,1, 12',
    '3',
    '1, 2, -3',
    '1, 3, -2',
    '1, -1',
];

solve(input)
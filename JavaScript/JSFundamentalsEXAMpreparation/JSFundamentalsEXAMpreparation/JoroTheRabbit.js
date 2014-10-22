function solve(input) {

    var rowColJumps = parseNumber(input[0]);
   
    var rows = rowColJumps[0];
    var cols = rowColJumps[1];
    var allJumps = rowColJumps[2];

    var startingPos = parseNumber(input[1]);
    var currentRow = startingPos[0];
    var currentCol = startingPos[1];
    var jumps = readJumps();
    var jumpsIndex = 0;
    var sum = 0;
    var countJumps = 0;
    var escaped = false;
    var caught = false;
    //field
    var filler = 1;

    var matrix = []
    for (var i = 0; i < rows; i++) {
        matrix[i] =[]

        for (var j = 0; j < cols; j++) {
            matrix[i][j] = filler;
            filler++
        }
    }
    //parser function
    function parseNumber(input) {
        var i = input.split(' ').map(Number);
        return i;
    }

    function readJumps() {
        jumps = [];
        for (var i = 2; i < allJumps + 2; i++) {
            var parsedJump = parseNumber(input[i])
            var currentJump = {
                row: parsedJump[0],
                col: parsedJump[1]
            }
            jumps.push(currentJump)
        }
        return jumps;
    }
    
    while (true) {
      
        if (currentRow < 0 || currentRow >= rows || currentCol < 0 || currentCol >= cols) {
            escape = true;
            break;
        }
        if (matrix[currentRow][currentCol] === 'X') {
            caught = true;
            break;
        }
        sum += matrix[currentRow][currentCol];
        countJumps++;

        matrix[currentRow][currentCol] = 'X';

        if (jumpsIndex >= jumps.length) {
            jumpsIndex = 0;
        }
        
        var currentJ = jumps[jumpsIndex++]
        currentRow += currentJ.row;
        currentCol += currentJ.col;
    }

    if (escape) {
        console.log('escaped ' + sum)
    }
    if (caught) {
        console.log('caught ' + countJumps)
    }
}

var input = [
    '6 7 3',
    '0 0',
    '2 2',
    '-2 2',
    '3 -1'
];

solve(input)
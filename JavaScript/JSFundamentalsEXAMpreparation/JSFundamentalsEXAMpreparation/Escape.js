function solve(input) {

    var rowsAndcols = input[0].split(' ').map(Number)
    var rows = rowsAndcols[0];
    var cols = rowsAndcols[1];
    var filler = 1;
    var startingPos = input[1].split(' ').map(Number)
    var currentRow = startingPos[0];
    var currentCol = startingPos[1];
    var sum = 0;
    var steps = 0;
    var out = false;
    var lost = false;

    var field = [];
    for (var i = 0; i < rows; i+=1) {

        field[i] = [];

        for (var j = 0; j < cols; j+=1) {
            field[i][j] = filler;
            filler++
        }
    }
    
    var labyrinth = []

    for (var i = 0; i < rows; i+=1) {
        labyrinth[i] = input[i + 2].split('');
    }

    while (true) {
        if (currentRow < 0 || currentRow >= rows || currentCol < 0 || currentCol >= cols  ) {

            out = true;
            break;
        }

        if (field[currentRow][currentCol] === 'X') {

            lost = true;
            break;
        }

        sum += field[currentRow][currentCol];
        steps++;

        field[currentRow][currentCol] = 'X';

        switch (labyrinth[currentRow][currentCol]) {
            
            case 'l': currentCol--; break;
            case 'r': currentCol++; break;
            case 'd': currentRow++; break;
            case 'u': currentRow--; break;
        }
    }

    if (out) {
        console.log('out '+ sum)
    }

    if (lost) {
        console.log('lost ' + steps)
    }

   
}

var input = [
 '3 4',
 '1 3',
 'lrrd',
 'dlll',
 'rddd'
];

solve(input);
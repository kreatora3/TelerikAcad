function solve(input) {

    var rowsAndCols = input[0].split(' ').map(Number);
    var rows = rowsAndCols[0];
    var cols = rowsAndCols[1];
    var sum = 0;
    var successed = false;
    var failed = false;
    var directions = []
    var currentRow = 0;
    var currentCol = 0;

    for (var i = 0; i < rows; i+=1) {

        directions[i] = input[i + 1].split(' ');
    }

    field = [];

    for (var i = 0; i < rows; i+=1) {
        field[i] = []
        for (var j = 0; j < cols; j+=1) {
            field[i][j] = 1 //(Math.pow(2, i) + j);
        }
    }
    
    while (true) {

        if (currentRow < 0 || currentRow >= rows || currentCol < 0 || currentCol >= cols) {

            successed = true;
            break;
        }

        if (field[currentRow][currentCol] === 'X') {
            failed = true;
            break;
        }

        //sum += field[currentRow][currentCol];
        sum += (Math.pow(2, currentRow) + currentCol) 
        field[currentRow][currentCol] = 'X'

        switch (directions[currentRow][currentCol]) {
            case 'dr': {
                currentRow++;
                currentCol++;
            } break;
            case 'ur': {
                currentRow--;
                currentCol++;
            } break;
            case 'ul': {
                currentRow--;
                currentCol--;
            } break;
            case 'dl': {
                currentRow++;
                currentCol--;
            }
        }
    }

    if (successed) {
        console.log('successed with ' + sum)
    }

    if (failed) {
        console.log('failed at (' + currentRow + ', ' + currentCol + ')')
    }
}

var input = [
    '3 5',
      'dr dl dr ur ul',
      'dr dr ul ur ur',
      'dl dr ur dl ur'

]

solve(input);
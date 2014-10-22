function solve(input) {
    var result = 0;

    for (var i = 1; i < input.length; i++) {

        if (parseInt(input[i]) <= parseInt(input[i + 1])) {
            continue;
        }
        result++;
    }
    console.log(result)
}

var input = [
  '6',
'1',
'3',
'-5',
'8',
'7',
 '-6'

];

solve(input)
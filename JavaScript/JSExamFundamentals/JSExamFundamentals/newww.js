function solve(input) {


    var s = parseInt(input[0])
    var numbers = [3, 4, 10]
    // Set the total that we want to divide into chips
   

    // Set the chip values
  

    // Work out how many of each chip is required to make up the bet value
    var tempBet = s;
    var tempChips = [];
    for (var i = numbers .length - 1; i >= 0; i--) {
        var chipValue = numbers [i];
        var divided = Math.floor(tempBet / chipValue);

        if (divided >= 1) {
            tempChips[i] = divided;
            tempBet -= divided * numbers [i];
        }

        if (tempBet == 0) { break; }
    }
    console.log(tempChips.length)
    //// Display the chips and how many of each make up the s
    //for (var i in tempChips) {
    //    console.log(tempChips[i] + ' of ' + numbers [i]);
    //}
}
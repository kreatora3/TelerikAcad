function read(form) {

    var num = form.int.value;

    var zeroToNineteenArr = ['Zero', 'One', 'Two', 'Three', 'Four', 'Five', 'Six', 'Seven', 'Eight', 'Nine', 'Ten', 'Eleven', 
        'Twelve', 'Thirteen', 'Fourteen', 'Fifteen', 'Sixteen', 'Seventeen', 'Eighteen', 'Nineteen'];

    var tensArr = [ 'Twenty', 'Thirty', 'Fourty', 'Fifty', 'Sixty', 'Seventy', 'Eighty', 'Ninety' ];


    
    var digit = parseInt(num);


    if ( num.length === 1) 
    {
        document.getElementById('result8').innerHTML = zeroToNineteenArr[digit];
    }
        
    if (num.length === 2)
    {
        var tens = (num.charCodeAt(0) - '0'.charCodeAt());
        var ones = (num.charCodeAt(1) - '0'.charCodeAt());
        
        if (digit < 20)
        {
            document.getElementById('result8').innerHTML = zeroToNineteenArr[digit];
        }
        else if(ones == 0)
        {
            document.getElementById('result8').innerHTML = (tensArr[tens-2]);
        }
        else
        {                
            document.getElementById('result8').innerHTML = tensArr[tens - 2] + ' ' + zeroToNineteenArr[ones];
        }
    }

    if (num.length === 3)
    {
        var hundreds = (num.charCodeAt(0) - '0'.charCodeAt());
        var tens = (num.charCodeAt(1) - '0'.charCodeAt());
        var ones = (num.charCodeAt(2) - '0'.charCodeAt());

        if (tens === 1)
        {
            if (ones === 0)
            {
                document.getElementById('result8').innerHTML = zeroToNineteenArr[hundreds] + ' Hundred ' + 'and ' + zeroToNineteenArr[10];
            }
            else
            {
                document.getElementById('result8').innerHTML = zeroToNineteenArr[hundreds] + ' Hundred ' + 'and ' + zeroToNineteenArr[10 + ones];
            }
        }
        if (tens > 1)
        {
            if (ones === 0)
            {
                document.getElementById('result8').innerHTML = zeroToNineteenArr[hundreds] + ' Hundred ' + 'and ' + tensArr[tens - 2];
            }
            else
            {
                document.getElementById('result8').innerHTML = zeroToNineteenArr[hundreds] + ' Hundred ' + 'and ' + tensArr[tens - 2] + ' ' + zeroToNineteenArr[ones];
            }
        }
        if (tens === 0)
        {
            if (ones === 0)
            {
                document.getElementById('result8').innerHTML = zeroToNineteenArr[hundreds] + ' Hundred ';
            }
            else
            {
                document.getElementById('result8').innerHTML = zeroToNineteenArr[hundreds] + ' Hundred ' + ' and ' + zeroToNineteenArr[ones];
            }
        }

    }
}
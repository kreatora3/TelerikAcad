function exchangeNums(form) {

	var a = parseInt(form.int.value);
	var b = parseInt(form.secondInt.value);
	var swap = 0;

	
		if (a > b) {
			swap = a - b;
			a = b;
			b = a + swap;
			document.getElementById('result1').innerHTML = 'First number after swap is now ' + parseInt(a) + ' and second number is now ' + parseInt(b)
		}
		else {
			document.getElementById('result1').innerHTML = 'No swap available due to condition is not met!'
		}
	}
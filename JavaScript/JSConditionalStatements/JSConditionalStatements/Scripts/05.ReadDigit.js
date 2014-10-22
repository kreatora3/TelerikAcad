function readDigit(form){

	var digit = parseInt(form.int.value);

	switch (digit) {
		case 1: document.getElementById('result5').innerHTML = 'Hey, you entered One'; break;
		case 2: document.getElementById('result5').innerHTML = 'Hey, you entered Two'; break;
		case 3: document.getElementById('result5').innerHTML = 'Hey, you entered Three'; break;
		case 4: document.getElementById('result5').innerHTML = 'Hey, you entered Four'; break;
		case 5: document.getElementById('result5').innerHTML = 'Hey, you entered Five'; break;
		case 6: document.getElementById('result5').innerHTML = 'Hey, you entered Six'; break;
		case 7: document.getElementById('result5').innerHTML = 'Hey, you entered Seven'; break;
		case 8: document.getElementById('result5').innerHTML = 'Hey, you entered Eight'; break;
		case 9: document.getElementById('result5').innerHTML = 'Hey, you entered Nine'; break;
		case 0: document.getElementById('result5').innerHTML = 'Hey, you entered Zero'; break;
		default: document.getElementById('result5').innerHTML ='Next time enter digit between (0-9)'; break;
	}
}
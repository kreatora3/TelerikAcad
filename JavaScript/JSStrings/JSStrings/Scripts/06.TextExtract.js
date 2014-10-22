function textExctract(form) {

	var text = form.text.value;

	var regex = /(<([^>]+)>)/ig

	document.getElementById('result6').innerHTML = text.replace(regex, '');
}
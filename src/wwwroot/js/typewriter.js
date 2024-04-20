var content = [ 
	"Din IP: " + document.getElementById("ipvar").innerHTML, 
	"Din lokation: " + document.getElementById("geovar").innerHTML
];

var part = 0;
var partIndex = 0;
var interval;
var element = document.getElementById("loadtext");

function Type() {
	var text =  content[part].substring(0, partIndex + 1);
	element.innerHTML = text;
	partIndex++;

	if(text === content[part]) {
		clearInterval(interval);
		setTimeout(function() {
			interval = setInterval(Delete, 50);
		}, 1000);
	}
}

function Delete() {
	var text =  content[part].substring(0, partIndex - 1);
	element.innerHTML = text;
	partIndex--;

	if(text === '') {
		clearInterval(interval);

		if(part == (content.length - 1))
			part = 0;
		else
			part++;
		
		partIndex = 0;

		setTimeout(function() {
			interval = setInterval(Type, 100);
		}, 200);
	}
}

interval = setInterval(Type, 100);
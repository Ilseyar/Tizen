window.onload = function() {
	var fileName = localStorage.fileName;
	$('#label').text(fileName);

};

var file;

(function() {
	/**
	 * page - Radio page element radios - NodeList object for radios radioresult -
	 * Indicator for active radio
	 */
	var page = document.getElementById("page-show-file");

	/**
	 * pageshow event handler Do preparatory works and adds event listeners
	 */
	page.addEventListener("pageshow", function() {
		console.log("page show");
		var fileName = localStorage.fileName;
		 console.log("fileName1");
		tizen.filesystem.resolve('documents', function(dir) {
			file = dir.resolve(fileName);
			file.openStream('r', onOpenSuccess, onOpenError);
		}, function(e) {
			console.log("Error" + e.message);
		}, "rw");
		 
		//второй способ чтения из файла
//		file.readAsText(function(contents) {
//			$('#label').text(contents);
//		}, onOpenError);
	});
}());

function onOpenSuccess(fs) {
	var byteAvailable = fs.bytesAvailable;
	console.log(byteAvailable);
	if (byteAvailable > 0) {
		var content = fs.read(byteAvailable);
		if (content.length !== 0) {
			$('#label').text(content);
		}
	}
}

function onOpenError() {
	alert('Error open file');
}
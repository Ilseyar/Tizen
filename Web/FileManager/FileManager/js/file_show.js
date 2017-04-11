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
		var fileName = localStorage.fileName;
		tizen.filesystem.resolve('documents', function(dir) {
			file = dir.resolve(fileName);
			//открытие файла для чтения
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

//Чтение из файла
function onOpenSuccess(fs) {
	//Количество байтов, доступных для памяти
	var byteAvailable = fs.bytesAvailable;
	if (byteAvailable > 0) {
		//Чтение из файла
		var content = fs.read(byteAvailable);
		if (content.length !== 0) {
			//Вывод на экран
			$('#label').text(content);
		}
	}
}

//Ошибка при чтении файла
function onOpenError() {
	alert('Error open file');
}
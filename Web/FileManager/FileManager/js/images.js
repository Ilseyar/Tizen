(function() {
	/**
	 * page - Radio page element radios - NodeList object for radios radioresult -
	 * Indicator for active radio
	 */
	var page = document.getElementById("page-images");

	/**
	 * pageshow event handler Do preparatory works and adds event listeners
	 */
	page.addEventListener("pageshow", function() {
		console.log("page show");
		tizen.filesystem.resolve("images", function(dir) {
			documentsDir = dir;
			dir.listFiles(onsuccess, onerror);
		}, function(e) {
			console.log("Error" + e.message);
		}, "r");
	});
}());

//Успешное получение списка картинок
function onsuccess(files) {
	filesList = files;
	filesList = document.getElementById('lv-images');
	for (var i = 0; i < files.length; i++) {
		var li = document.createElement('li');
		li.innerText = files[i].name;
		filesList.appendChild(li);
		filesListInst = tau.widget.getInstance(filesList);
		filesListInst.refresh();
	}
}
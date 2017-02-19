var currentIndex;
var label = document.getElementById('label');
var filesList = []

function onStorage(storage) {
	alert(storage[0].label);
}

function onStorageError() {

}
(function() {
	/**
	 * page - Radio page element radios - NodeList object for radios radioresult -
	 * Indicator for active radio
	 */
	var page = document.getElementById("page-documents");

	/**
	 * pageshow event handler Do preparatory works and adds event listeners
	 */
	page.addEventListener("pageshow", function() {
		console.log("page show");
		// tizen.filesystem.getStorage("documents", onStorage, onStorageError);
		tizen.filesystem.resolve('documents', function(dir) {
			documentsDir = dir;
			console.log(dir);
			dir.listFiles(onsuccess, onerror);
		}, function(e) {
			console.log("Error" + e.message);
		}, "rw");
	});
	
	 document.addEventListener( 'tizenhwkey', backEvent );
}());

function onsuccess(files) {
	console.log(files.length);
	filesList = files;
	filesList = document.getElementById('lv-documents');
	for (var i = 0; i < files.length; i++) {
		console.log(files[i].name);
		var li = document.createElement('li');
		li.addEventListener('click', showFile.bind(this, files[i]), false);
		li.innerText = files[i].name;
		filesList.appendChild(li);
		filesListInst = tau.widget.getInstance(filesList);
		filesListInst.refresh();
	}

	var testFile = documentsDir.createFile("test.txt");

	if (testFile != null) {
		testFile.openStream("w", function(fs) {
			fs.write("HelloWorld");
			fs.close();
		}, function(e) {
			console.log("Error " + e.message);
		}, "UTF-8");
	}
}

function showFile(file) {
	console.log(file.name);
	localStorage.fileName = file.name;
	tau.changePage('file_show.html');

}

function onerror(error) {
	console.log("The error " + error.message
			+ " occurred when listing the files in the selected folder");
}
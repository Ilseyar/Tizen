var backEventListener = null;

var db;
var version = 1.0;
var dbName = "tasksdb";
var dbDisplayName = "tizen_tasks_db";
var dbSize = 2 * 1024 * 1024;
var tasksTableName = "tasks_table";
var d = new Date();

var unregister = function() {
	if (backEventListener !== null) {
		document.removeEventListener('tizenhwkey', backEventListener);
		backEventListener = null;
		window.tizen.application.getCurrentApplication().exit();
	}
}

// Initialize function
var init = function() {
	// register once
	if (backEventListener !== null) {
		return;
	}

	// TODO:: Do your initialization job
	console.log("init() called");

	var backEvent = function(e) {
		if (e.keyName == "back") {
			try {
				if ($.mobile.urlHistory.activeIndex <= 0) {
					// if first page, terminate app
					unregister();
				} else {
					// move previous page
					$.mobile.urlHistory.activeIndex -= 1;
					$.mobile.urlHistory.clearForward();
					window.history.back();
				}
			} catch (ex) {
				unregister();
			}
		}
	}

	openDB();
	createTableTasks();
	$('#btnAdd').bind('click', function(event, ui) {
		task = $('#taskText').val();
		insertTask(task, getCurrentDate());
		getAllDataFromDB();
	});
	// add eventListener for tizenhwkey (Back Button)
	document.addEventListener('tizenhwkey', backEvent);
	backEventListener = backEvent;
};

$(document).bind('pageinit', init);
$(document).unload(unregister);

function getCurrentDate() {
	var month = d.getMonth() + 1;
	var day = d.getDate();
	var fullDate = (day < 10 ? '0' : '') + day + '-' + (month < 10 ? '0' : '')
			+ month + '-' + d.getFullYear();
	return fullDate;
}

function openDB() {
	db = openDatabase(dbName, version, dbDisplayName, dbSize,
			function(database) {
				alert("database opened");
			});
}

function createTableTasks() {
	db.transaction(function(t) {
		t.executeSql("CREATE TABLE IF NOT EXISTS " + tasksTableName
				+ " (id INTEGER PRIMARY KEY, title TEXT, date TEXT);", []);
	});
};

function insertTask(title, date) {
	db.transaction(function(t) {
		t.executeSql("INSERT INTO " + tasksTableName
				+ "(title, date) VALUES(?, ?)", [ title, date ],
				onSuccessInsertData, onErrorInsertData);
	});
};

function onSuccessInsertData() {
	alert('Data inserted');
}

function onErrorInsertData() {
	alert('Error insert data');
}

function deleteTask(taskId) {
	db.transaction(function(t) {
		t.executeSql("DELETE FROM " + tasksTableName + " WHERE id = ?",
				[ taskId ], getAllDataFromDB);
	});
}

function getAllDataFromDB() {
	var tasks = [];
	db.transaction(function(t) {
		t.executeSql("SELECT * FROM " + tasksTableName, [], function(
				sqlTransaction, sqlResultSet) {
			var i, tasksNumber = sqlResultSet.rows.length;
			for (i = 0; i < tasksNumber; i++) {
				var task = sqlResultSet.rows.item(i);
				tasks.push(task);
			}
			showTasks(tasks);
		});
	});
};

function showTasks(tasks) {
	$('#lvTasks').children().remove();
	tasks.forEach(function(item, i, arr) {
		updateListView(item.id, item.title, item.date);
	});
	$('#lvTasks').listview('refresh');
}

function updateListView(taskId, taskTitle, taskDate) {
	$('#lvTasks').append(
			'<li id="' + taskId + '">' + taskTitle + '<br>' + taskDate
					+ '</li>');
	$('#' + taskId).bind('click', function(event, ui) {
		deleteTask(taskId);
		getAllDataFromDB();
	});
}

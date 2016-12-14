var backEventListener = null;

var db;
var version = 1.0;
var dbName = "tasksdb";
var dbDisplayName = "tizen_task_db";
var dbSize = 2 * 1024 * 1024;

var unregister = function() {
    if ( backEventListener !== null ) {
        document.removeEventListener( 'tizenhwkey', backEventListener );
        backEventListener = null;
        window.tizen.application.getCurrentApplication().exit();
    }
}

//Initialize function
var init = function () {
    // register once
    if ( backEventListener !== null ) {
        return;
    }
    
    // TODO:: Do your initialization job
    console.log("init() called");
    
    var backEvent = function(e) {
        if ( e.keyName == "back" ) {
            try {
                if ( $.mobile.urlHistory.activeIndex <= 0 ) {
                    // if first page, terminate app
                    unregister();
                } else {
                    // move previous page
                    $.mobile.urlHistory.activeIndex -= 1;
                    $.mobile.urlHistory.clearForward();
                    window.history.back();
                }
            } catch( ex ) {
                unregister();
            }
        }
    }
    
    openDB();
    createTable();
    insertData("Открыть базу данных");
    
    // add eventListener for tizenhwkey (Back Button)
    document.addEventListener( 'tizenhwkey', backEvent );
    backEventListener = backEvent;
};


function openDB() {
	db = openDatabase(dbName, version, dbDisplayName, dbSize,
			function(database) {
				alert("database opened");
			});
};

function createTable() {
	db.transaction(function (t) {
        t.executeSql("CREATE TABLE tasksTable (id INTEGER PRIMARY KEY, title TEXT);", []);
    });
};

function insertData(title) {
	db.transaction(function(t) {
		t.executeSql("INSERT INTO tasksTable(title) VALUES (?)", [ title ],
				onSuccess, onError);
	});
};

function getAllDataFromDB() {
	var tasks = []
	db.transaction(function(t) {
	t.executeSql("SELECT * FROM tasksTable", [],
			function(sqlTransaction, sqlResultSet) {
				var i, tasksNumber = sqlResultSet.rows.length;
				for (i = 0; i < tasksNumber; i++) {
					var task = sqlResultSet.rows.item(i);
					tasks.push(task.title);
					console.log(task.title);
				}
			});
	});
	return tasks;
};

function onSuccess(){
	alert("Task added!");
}

function onError(){
	alert("Error insert data");
}

$(document).bind( 'pageinit', init );
$(document).unload( unregister );

var backEventListener = null;
var posts_num;

var unregister = function() {
	if (backEventListener !== null) {
		window.removeEventListener('tizenhwkey', backEventListener, false);
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
				var activePage = $.mobile.activePage.attr('id');
				switch (activePage) {
			    case 'post-list': 
			        tizen.application.getCurrentApplication().exit();
			        break;
			      case 'post-add':
			        window.history.back(history);
			        break;
				}
			} catch (ex) {
				unregister();
			}
		}
	}
	getDataFromServer();
	// add eventListener for tizenhwkey (Back Button)
	$('#btn-send-post').bind('click', function() {
		title = $('#input-title').val();
		author = $('#input-author').val();
		post = {
			'id': posts_num,
			'title' : title,
			'author' : author
		}
		sendDataToServer(post);
	});
	window.addEventListener('tizenhwkey', backEvent, false);
	backEventListener = backEvent;
};

$(document).bind('pageinit', init);
$(document).unload(unregister);

function getLastId(){
	return posts[posts.length-1] + 1;
}

function getDataFromServer() {
	$.ajax({
		url : "http://192.168.1.189:3000/posts", //Поменять IP адрес
		type : "GET",
		dataType : "json",
		success : function(data) {
			posts = data;
			showPosts(data)
		},
		error : function(err) {
			alert("error");
			console.log("error " + err.message);
		}
	});
}

function showPosts(posts) {
	$('#lv-posts').children().remove();
	posts_num = 1;
	posts.forEach(function(item, i, arr) {
		$('#lv-posts').append('<li>' + item.title + '</li>')
		posts_num++;
	});
	$('#lv-posts').listview('refresh');
}

function sendDataToServer(post) {
	console.log(post)
	$.ajax({
		url : "http://192.168.1.189:3000/posts", //Поменять IP адрес
		type : "POST",
		dataType : "json",
		data : post,
		success : function() {
			alert("success");
			getDataFromServer();
		},
		error : function(err) {
			alert("error");
			console.log("error " + err.message);
		}
	});
}

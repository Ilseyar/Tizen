var backEventListener = null;

var post = {
		id: "",
		title: "",
		author: ""
}
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
    post.title = "title";
    post.author = "Author";
    post.id = 4;
    sendDataToServer(post);
    
    
    // add eventListener for tizenhwkey (Back Button)
    document.addEventListener( 'tizenhwkey', backEvent );
    backEventListener = backEvent;
};

function getDataFromServer(){
	alert("request")
	$.ajax({
		url:"http://192.168.43.189:3000/posts",
		type: "GET",
		dataType: "json",
		success: function(data) {
			alert("success");
			console.log("succes");
			console.log(data.title)
//			$('#label').text(data.title);
			showPosts(data)
		},
		error: function(err) {
			alert("error");
			console.log("error " + err.message);
		}
	});
}

function sendDataToServer(post){
	console.log(post)
	alert("request")
	$.ajax({
		url:"http://192.168.43.189:3000/posts",
		type: "POST",
		dataType: "json",
		data: post,
		success: function() {
			alert("success");
			getDataFromServer();
		},
		error: function(err) {
			alert("error");
			console.log("error " + err.message);
		}
	});
}

function showPosts(posts){
	posts.forEach(function(item, i, arr) {
		  $('#posts').append('<ul>' + item.title + '</ul>')
		});
}

$(document).bind( 'pageinit', init );
$(document).unload( unregister );

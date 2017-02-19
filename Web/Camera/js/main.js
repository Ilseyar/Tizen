var backEventListener = null;
var stream;
var video;

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

	navigator.webkitGetUserMedia({
		video : true,
		audio : false,
		facingMode: "environment"
	}, gotStreamCallback.bind(this), noStreamCallback.bind(this));

	// add eventListener for tizenhwkey (Back Button)
	document.addEventListener('tizenhwkey', backEvent);
	backEventListener = backEvent;
};

$(document).bind('pageinit', init);
$(document).unload(unregister);

function gotStreamCallback(rStream) {
	stream = rStream;
	video = $('<video />', {
		autoplay : 'autoplay',
		id : 'camera-viewport',
		css : {
			height : '100%',
			width : '100%'
		},
		src : window.webkitURL.createObjectURL(rStream)
	});

	$('#video-container').append(video);
	$('#picture-button').bind('click', takePicture);
}

function noStreamCallback() {
	alert('Error getting stream');
}

function gotCameraCallback(cameraControl) {
	$('#take-picture').bind('click', function() {
		cameraControl.image.takePicture(takePictureSuccess.bind(this), takePictureError);
	});
}

function takePicture() {
	var canvas = $('<canvas id="canvas"/>', {
		css : {
			width : video.width(),
			height : video.height()
		}
	});
	var data = canvas[0].getContext('2d').drawImage(video[0], 0, 0,
			video.width(), video.height());

	var data = canvas[0].toDataURL().replace('data:image/png;base64,', '')
			.replace('data:,', '');

	var fileName = 'IMAGE_' + Date.now().toString() + '.png';
	
	//сохранение фотографии в файл
	tizen.filesystem.resolve('images', function(dir) {
		var file = dir.createFile(fileName);
		file.openStream('w', function(stream) {
			stream.writeBase64(data);
			stream.close();
			alert("Image saved to " + file.toURI() + '"');
		}, function(e) {
			alert('Error: ' + e.message);
		}, 'UTF-8');
	}, function(e) {
		alert('Error: ' + e.message);
	});
	alert('take picture success event');
}

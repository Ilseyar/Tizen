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
	
	//Получение видеопотока с камеры
	navigator.webkitGetUserMedia({
		video : true,
		audio : false,
		facingMode: "environment" //Использование основной камеры, удалить для использования фронтальной
	}, onGetStreamSuccess.bind(this), onGetStreamError.bind(this));

	// add eventListener for tizenhwkey (Back Button)
	document.addEventListener('tizenhwkey', backEvent);
	backEventListener = backEvent;
};

$(document).bind('pageinit', init);
$(document).unload(unregister);

//Отображение превью
function onGetStreamSuccess(rStream) {
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

function onGetStreamError() {
	alert('Error getting stream');
}

function takePicture() {
	var canvas = $('<canvas id="canvas"/>', {
		css : {
			width : video.width(),
			height : video.height()
		}
	});
	
	//Получение картинки
	var data = canvas[0].getContext('2d').drawImage(video[0], 0, 0,
			video.width(), video.height());
	var photo = canvas[0].toDataURL().replace('data:image/png;base64,', '')
			.replace('data:,', '');

	var fileName = 'IMAGE_' + Date.now().toString() + '.png';
	//сохранение фотографии в файл
	tizen.filesystem.resolve('images', function(dir) {
		var file = dir.createFile(fileName);
		file.openStream('w', function(stream) {
			stream.writeBase64(photo);
			stream.close();
			alert("Фотография сохранена в " + file.toURI() + '"');
		}, function(e) {
			alert('Error: ' + e.message);
		}, 'UTF-8');
	}, function(e) {
		alert('Error: ' + e.message);
	});
	alert('Фотография сделана успешно');
}

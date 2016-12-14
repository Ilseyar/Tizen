var backEventListener = null;
var music = ["media/Sia-Cheap_Thrills.mp3", "media/Hurts - Wonderful Life.mp3",
             "media/This One's For You.mp3"];
var images = ["images/sia.jpg", "images/hurts.jpg", "images/DavidGuetta.jpg"];
var rightAnswers = ["Sia", "Hurts", "David Guetta"];
var currentIndex = 0;
var countRightAnswers = 0;

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
    
    
    $('#btn_next').bind("click", function(event, ui){
    	var answer = $('#answer').val();
    	if(answer === rightAnswers[currentIndex]) {
    		countRightAnswers++;
    	}
    	currentIndex = currentIndex + 1;
    	if (currentIndex < 3) {
    		//switch for next question
    		$('#img').attr("src", images[currentIndex]);
    		$('#music').attr("src", music[currentIndex]);
    	} else {
    		//Pass parameter for page result 
    		localStorage.score=countRightAnswers;
    		console.log(countRightAnswers);
    		//open page result
    		window.open("result.html");
    	}
    });
    
    $('#check_answer').bind("click", function(event, ui){
    	var answer = $('#answer').val();
    	if(answer === rightAnswers[currentIndex]) {
    		$('#label').text("Right Answer");
    	} else {
    		$('#label').text("Wrong Answer");
    	}
    });
    // add eventListener for tizenhwkey (Back Button)
    document.addEventListener( 'tizenhwkey', backEvent );
    backEventListener = backEvent;
};

$(document).bind( 'pageinit', init );
$(document).unload( unregister );

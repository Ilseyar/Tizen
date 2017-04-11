var backEventListener = null;
//Список композиций
var music = ["media/Sia-Cheap_Thrills.mp3", "media/Hurts - Wonderful Life.mp3",
             "media/This One's For You.mp3"];
//Список изображений
var images = ["images/sia.jpg", "images/hurts.jpg", "images/DavidGuetta.jpg"];
//Список правильных ответов
var rightAnswers = ["Sia", "Hurts", "David Guetta"];
//Номер текущего вопроса
var currentIndex = 0;
//Кол-во правильных ответов
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
    
    //Переход на следующий экран
    $('#btn_next').bind("click", function(event, ui){
    	var answer = $('#answer').val();
    	if(answer === rightAnswers[currentIndex]) {
    		countRightAnswers++;
    	}
    	currentIndex = currentIndex + 1;
    	if (currentIndex < 3) {
    		//Вывод фото следующего артиста на экран
    		$('#img').attr("src", images[currentIndex]);
    		//Добавление следующего аудио на экран
    		$('#music').attr("src", music[currentIndex]);
    	} else {
    		//Передача параметров на экран результатов 
    		localStorage.score=countRightAnswers;
    		//Переход на страницу результатов
    		tau.changePage("result.html");
    	}
    });
    
    //Обработка кнопки проверки ответа
    $('#check_answer').bind("click", function(event, ui){
    	//Получение ответа, введенного пользователем
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

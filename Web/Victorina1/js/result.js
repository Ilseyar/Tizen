//function start to work when page is loaded
window.onload = function () {
	var score = localStorage.score;
	var point = "";
	if (score === "1"){
		point = "балл";
	} else {
		point = "балла";
	}
	 $('#label').text("Вы заработали " + score + " " + point + ":)");
	
};


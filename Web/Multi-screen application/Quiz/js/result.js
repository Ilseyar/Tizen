(function() {
	/**
	 * page - Radio page element radios - NodeList object for radios radioresult -
	 * Indicator for active radio
	 */
	var page = document.getElementById("page-result");
	console.log("result page");

	/**
	 * pageshow event handler Do preparatory works and adds event listeners
	 */
	page.addEventListener("pageshow", function() {
		var score = localStorage.score;
		var point = "";
		if (score === "0"){
			point = "баллов";
		} else if (score === "1") {
			point = "балл";
		} else {
			point = "балла";
		}
		var para = document.createElement("P");                     
		var t = document.createTextNode("Вы заработали " + score + " " + point + ":)");     
		para.appendChild(t);  
		document.getElementById('result').appendChild(para);
	});

}());

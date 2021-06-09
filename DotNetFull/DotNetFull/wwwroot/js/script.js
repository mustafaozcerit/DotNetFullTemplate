$(document).ready(function() {
  
  var counter = 0;
  var c = 0;
  var a=0;
  var i = setInterval(function(){
      $(".loading-page .counter h1").html(c + "%");
      $(".loading-page .counter hr").css("width", c + "%");
      //$(".loading-page .counter").css("background", "linear-gradient(to right, #f60d54 "+ c + "%,#0d0d0d "+ c + "%)");

    /*
    $(".loading-page .counter h1.color").css("width", c + "%");
    */
	// Data yüklenme kontrolünü burada sağlıyoruz.
	if(a==0){
		  counter++;
    c++;
	}
  

		   if(counter == 101) {
        clearInterval(i);
    }
	  
   
  }, 300);
});
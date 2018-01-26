			$(document).ready(function($) {
				$(".scroll").click(function(event){
					event.preventDefault();
					$('html,body').animate({scrollTop:$(this.hash).offset().top},1000);
				});
				$("#login").click(function () {
				    showpopup();
				}
                 );//login click
			});


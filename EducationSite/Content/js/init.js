(function($){
  $(function(){
$(document).ready(function(){
      $('.slider').slider();
    });
    $('.button-collapse').sideNav();
    $('.parallax').parallax();
    $(document).ready(function(){
		    // the "href" attribute of the modal trigger must specify the modal ID that wants to be triggered
		    $('#modalPost').modal();
  			});

  }); // end of document ready
})(jQuery); // end of jQuery name space
		
// <script type="text/javascript">
// 		 $(document).ready(function(){
// 		    // the "href" attribute of the modal trigger must specify the modal ID that wants to be triggered
// 		    $('#modalPost').modal();
//   			});
// 	</script>

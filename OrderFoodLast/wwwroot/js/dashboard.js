$(document).ready(function(){
  $('#sidebarCollapse').on('click', function(){
    $('#sidebar').toggleClass('active');
  });

  $('.list-unstyled li').click(function(event) {
    // event.preventDefault();
    $(this).parent().find('li.active').removeClass('active');
    $(this).attr('class', "active");
  });
});

function readURL(input) {
  if (input.files && input.files[0]) {
    var reader = new FileReader();
    
    reader.onload = function(e) {
      $('#blah').attr('src', e.target.result);
    }
    
    reader.readAsDataURL(input.files[0]);
  }
}

$("#imgInp").change(function() {
  readURL(this);
});
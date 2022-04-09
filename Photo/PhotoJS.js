function openModal() {
  document.getElementById("myModal").style.display = "block";
}

function closeModal() {
  document.getElementById("myModal").style.display = "none";
}
var slideIndex = 1;
showSlides(slideIndex);

function plusSlides(n) {
  showSlides(slideIndex += n);
}

function currentSlide(n) {
  showSlides(slideIndex = n);
}
function showSlides(n) {
    var i;
    var slides = document.getElementsByClassName("mySlides");
    var dots = document.getElementsByClassName("demo");
    var captionText = document.getElementById("caption");
    if (n > slides.length) {slideIndex = 1}
    if (n < 1) {slideIndex = slides.length}
    for (i = 0; i < slides.length; i++) {
        slides[i].style.display = "none";
    }
    for (i = 0; i < dots.length; i++) {
        dots[i].className = dots[i].className.replace(" active", "");
    }
    slides[slideIndex-1].style.display = "block";
    dots[slideIndex-1].className += " active";
    captionText.innerHTML = dots[slideIndex-1].alt;
  }

  function openModal2() {
    document.getElementById("myModal2").style.display = "block";
  }
  
  function closeModal2() {
    document.getElementById("myModal2").style.display = "none";
  }
  var slideIndex2 = 1;
  showSlides2(slideIndex2);
  
  function plusSlides2(n) {
    showSlides2(slideIndex2 += n);
  }
  
  function currentSlide2(n) {
    showSlides2(slideIndex2 = n);
  }
  function showSlides2(n) {
      var i;
      var slides2 = document.getElementsByClassName("mySlides2");
      var dots = document.getElementsByClassName("demo");
      var captionText = document.getElementById("caption");
      if (n > slides2.length) {slideIndex2 = 1}
      if (n < 1) {slideIndex = slides2.length}
      for (i = 0; i < slides2.length; i++) {
          slides2[i].style.display = "none";
      }
      for (i = 0; i < dots.length; i++) {
          dots[i].className = dots[i].className.replace(" active", "");
      }
      slides2[slideIndex2-1].style.display = "block";
      dots[slideIndex2-1].className += " active";
      captionText.innerHTML = dots[slideIndex2-1].alt;
    }
  
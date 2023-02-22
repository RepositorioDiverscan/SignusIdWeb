// Get the modal
var modal = document.getElementById('myModal');
var url11 = ''; 

// Get the image and insert it inside the modal - use its "alt" text as a caption
var img1 = document.getElementById('f1');
var img2 = document.getElementById('f2');
var img3 = document.getElementById('f3');
var img4 = document.getElementById('f4');
var img5 = document.getElementById('f5');

var modalImg = document.getElementById("img01");

img1.onclick = function () {
    url11 = 'Null-Image.jpg';
    var textoComparar = img1.src;
    if (textoComparar.includes(url11) != true) {

        modal.style.display = "block";
        modalImg.src = this.src;
    }
    else {
    }
   
}
img2.onclick = function () {
    url11 = 'Null-Image.jpg';
    var textoComparar = img2.src;
    if (textoComparar.includes(url11) != true) {

        modal.style.display = "block";
        modalImg.src = this.src;
    }
    else {
    }

}
img3.onclick = function () {
    url11 = 'Null-Image.jpg';
    var textoComparar = img3.src;
    if (textoComparar.includes(url11) != true) {

        modal.style.display = "block";
        modalImg.src = this.src;
    }
    else {
    }

}
img4.onclick = function () {
    url11 = 'Null-Image.jpg';
    var textoComparar = img4.src;
    if (textoComparar.includes(url11) != true) {

        modal.style.display = "block";
        modalImg.src = this.src;
    }
    else {
    }

}
img5.onclick = function () {
    url11 = 'Null-Image.jpg';
    var textoComparar = img5.src;
    if (textoComparar.includes(url11) != true) {

        modal.style.display = "block";
        modalImg.src = this.src;
    }
    else {
    }

}

// Get the <span> element that closes the modal
var span = document.getElementsByClassName("close")[0];

// When the user clicks on <span> (x), close the modal
span.onclick = function () {
    modal.style.display = "none";
}

window.addEventListener('click', function (e) {
    /*2. Si el div con id clickbox contiene a e. target*/
    if (document.getElementById('myModal').contains(e.target)) {
        console.log(e.target);
        modal.style.display = "none";
    } 
})
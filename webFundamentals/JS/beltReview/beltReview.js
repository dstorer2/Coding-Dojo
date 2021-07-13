var cartCount= 0;

var element = document.getElementById("cartQty");
var mainImage = document.getElementById("mainImage");

function buyGame(){
    cartCount++;

    element.innerText = cartCount
}

function linuxClick(){
    alert("This game runs on Linux!")
}

var images = [
    "img/riot-games-image.jpg",
    "img/riot-games-valorant.jpg",
    "img/riot-games-forge.jpg"
]
var currentImage = 0;

function switchImageRight(){
    currentImage++
    if(currentImage === 3){
        currentImage = 0;
    }
    mainImage.src = images[currentImage]
    
}
function switchImageLeft(){
    currentImage--
    if(currentImage === 0){
        currentImage = 2;
    }
    mainImage.src = images[currentImage]
}
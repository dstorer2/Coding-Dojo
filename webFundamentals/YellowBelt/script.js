var alertElement = document.getElementById("alert")

function hide(element){
    alertElement.remove();
}

function flipImage(element){
    element.src = "assets/succulents-2.jpg"
}

function flipBackImage(element){
    element.src = "assets/succulents-1.jpg"
}
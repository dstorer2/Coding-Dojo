var isFlipped = false;

function cardClick(element){
    if(isFlipped){
        element.src = "back.jpg";
    }
    else{
        element.src = "scissor.jpg";
    }
    isFlipped = !isFlipped
}
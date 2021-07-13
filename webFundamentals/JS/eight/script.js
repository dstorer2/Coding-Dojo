var answerList = [
    "yes",
    "no",
    "lol no",
    "ask again",
    "ask your mother",
    "never will you ever",
    "stop asking silly questions",
    "yesn't",
    "maybe" 
]
function findFortune(){
    //change the image to the gif
    var image = document.getElementById("eightBall");
    image.src = "img/ball.gif"
    //set timeout to call end function
    setTimeout(endFortune, 2000)
}

function endFortune(){
    //place text in answer h1
    var image = document.getElementById("eightBall");
    image.src = "img/ballStill.jpg";
    //sets image src back to static image
    var answer = document.getElementById("answer");
    var randIndex = Math.floor(Math.random() * answerList.length)
    answer.innerText = answerList[randIndex]
}
var count = 0
var countElement = document.getElementById("likes")

function addLike() {
    count++;
    likes.innerHTML = count + " like(s)"
}
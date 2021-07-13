var count1 = 0
var count2 = 0
var count3 = 0

var countElement0 = document.getElementById("likes0")
var countElement1 = document.getElementById("likes1")
var countElement2 = document.getElementById("likes2")

// function addLike1() {
//     count1++;
//     likes1.innerHTML = count1 + " like(s)"
// }

// function addLike2() {
//     count2++;
//     likes2.innerHTML = count2 + " like(s)"
// }

// function addLike3() {
//     count3++;
//     likes3.innerHTML = count3 + " like(s)"
// }

var count = [0, 0, 0];
console.log("hey there");

function addLike(likedPost){
    if( likedPost === 0){
        count[0]++;
        countElement0.innerHTML = count[0] + " like(s)"
    }
}
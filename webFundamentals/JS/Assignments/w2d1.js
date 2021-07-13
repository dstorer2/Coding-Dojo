// function rollDie(){
//     roll = Math.floor(Math.random()*6 +1)
//     var roll;
//     return roll;
// }

// console.log(rollDie())

function eightBall(){
    let caravanPalace = ['How to do', 'where to go', 'what to do without you?', 'What to think', 'how to dream', 'if I dont sleep with you?']
    var shake = Math.floor(Math.random()*caravanPalace.length)
    return caravanPalace[shake]
}
console.log(eightBall())
async function getCoderData() {
    // The await keyword lets js know that it needs to wait until it gets a response back to continue.
    var response = await fetch("https://api.github.com/users/dstorer2");
    // We then need to convert the data into JSON format.
    var coderData = await response.json();
    return coderData;
}

var x = document.getElementById("userInfo")

function showCoderData(){
    x.innerHTML=coderData.name + "has" + coderData.followers + "followers."
}

console.log(getCoderData())

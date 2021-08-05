function isPallindrome(str) {
    for (var i = 0; i < str.length; i++ ){
        if(str[i] !== str[str.length - 1 - i]){
            console.log(str +" is not a pallindrome")
            return false
        }
    }
    return true
}

// console.log(isPallindrome("du d"))

// Given a String, return the longest pallindromic substring. Given "hello dada", return "dad". Given "not much" return "n". Include spaces as well!

// Example 1: "my favorite racecar erupted" --> "e racecar e"
// Example 2: "nada" --> "ada"
// Example 3: "nothing to see" --> "ee"

function longestPallindrome(str) {
    for (var i  = 0; i < str.length; i++ ){
        if(str[i] === " "){
            continue
        }
        for (var j = i+1; j < str.length; j++){
            newStr = " "
            if( j === i){
                for (var x = str[i]; x <=str[j]; x)
            }
        }
    }
}
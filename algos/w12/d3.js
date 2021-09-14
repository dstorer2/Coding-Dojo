//You are given a string that may contain sequences of consecutive characters.
//Create a function to shorten a string by including the character, then the 
//number of times it appears. For "aaaabbcddd" return "a4b2c1d3"
//no built in functions!!!! parseInt() is ok
const encode = (str) => {
    let newStr = "";
    for( let i = 0; i < str.length; ++i){
        let counter = 0;
        while(str[i] === str[i+1]){
            counter ++;
            i++;
        }
        counter ++;
        newStr = newStr + str[i] +counter;
        // console.log(newStr);
    }
    return newStr;
}

// console.log(encode("aaabbcccc"));
// console.log(encode("ddddeeeeeffgggg"));
// console.log(encode("aaaaabbbbbbbc"));
// console.log(encode("bb"));

//given an encoded string, decode and return it
//given "a3b2c1d3" return "aaabbcddd"
//parseInt() is ok
//special note: can your function handle "g14f12"?
const decode = (str) => {
    let newStr = "";
    for( let i = 0; i < str.length; i++){
        let currentChar = str[i];
        let multiplier = parseInt(str[i + 1]);


        for(let x = 1; x <= multiplier; ++x){
            currentChar = str[i];
            newStr = newStr + currentChar;
        }
        ++i;
    }
    return newStr;

}

console.log(decode("a3b2c4"));
// console.log(decode("t2h10j4"));
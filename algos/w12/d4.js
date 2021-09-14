const upperCaseIt = (str) => {
    let newStr = "";
    for(let i = 0; i < str.length; ++i){
        let this_char = str[i];
        let code = str.charCodeAt(i);
        code >= 97 && code <= 122 && (this_char = String.fromCharCode(code - 32));
        newStr += this_char;
    }
    return newStr;
}
// console.log(upperCaseIt("wooOOOooOO let's freAKIN Go!!!"));
// console.log(upperCaseIt("r"));

//A pangram is a sentence or phrase that uses every letter of the alphabet
//Write a function to return if a string contains at least one of every
//letter(not case sensitive).
//return true or false
//no built in functions!! toUpperCase is OK
//if(str[0] >= "A" && str[0] <= "Z") can be useful
const isPangram = (str) => {
    return new Set(format(str)).size == 26;
}

const isPerfectPangram = (str) => {
    return new Set(format(str)).size == 26 && format(str).length == 26;
}

function format(string) {
    return string.toUpperCase().replace(/[^A-Z]/g, '');
}

console.log(isPangram("Waxy and quivering, jocks fumble the pizza."));//returns true
console.log(isPangram("The quick brown fo jumps over the lazy sleeping dog"));//missing x, returns false
console.log(isPangram("Sphinx of black quartz, judge my vow"));

console.log(isPerfectPangram("The quick brown fox jumps over the lazy sleeping dog"));//should be false
console.log(isPerfectPangram("qrstuvwxyzab cde.fghijkLMNOP"));//should be true
console.log(isPangram("Waxy and quivering, jocks fumble the pizza."));//returns true
// console.log(isPangram("The quick brown fo jumps over the lazy sleeping dog"));//missing x, returns false
// console.log(isPangram("Sphinx of black quartz, judge my vow"));

//Write a function to check if a string contains exactly one of every letter
//again, not case sensitive and it's ok to use toUpperCase
const isPerfectPangram = (str) => {
}

// console.log(isPerfectPangram("The quick brown fox jumps over the lazy sleeping dog"));//should be false
// console.log(isPerfectPangram("qrstuvwxyzabcdefghijkLMNOP"));//should be true
    // Create a function that, given an input string, returns a boolean true/false whether parentheses in that string are valid.

// Example 1:"y(3(p)p(3)r)s" --> true
// Example 2: "n(0(p)3" --> false
// Example 3: "n)0(t(o)k" --> false

// hint: consider using an array or object to solve


// check entire string, return true/false
// every single opening parens has a closing
// never hit an closing parens before a opening parens
// ONLY care about the parens in the string

function parensValid(str) {
    var countOpen = 0;
    var countClose = 0;
    for(var i = 0; i < str.length; ++i ){
        if (str[i] === "(") {
            countOpen ++
        }
        if (str[i] === ")") {
            countClose ++
        }
        else if(countClose > countOpen){
            return false
        }
    }
    if ( countOpen === countClose){
        return true
    }
    else{
        return false
    }
}

// console.log(parensValid("n(0(p)3"))


// Given a string, returns whether the sequence of various parentheses, braces and brackets within it are valid. 

// Example 1: "({[({})]})" --> true
// Example 2: "d(i{a}l[t]o)n{e!" --> false
// Example 2: "{{[a]}}(){bcd}{()}" --> true

// hint: consider using an array or object to solve

function bracesValid(str) {
    var countOpen = 0;
    var countClose = 0;
    for(var i = 0; i < str.length; ++i ){
        if (str[i] === "(") {
            countOpen ++
        }
        if (str[i] === ")") {
            countClose ++
        }
        else if(countClose > countOpen){
            return false
        }
    }
    if ( countOpen === countClose){
        return true
    }
    else{
        return false
    }
}

// console.log(parensValid("n(0(p)3"))
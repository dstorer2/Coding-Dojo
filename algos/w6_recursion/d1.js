// Write a drecursive function that, given a number, returns the product of integers up to a given number
// Ex: given 4 would return 1*2*3*4 == 24
// Ex: given 3.5 would return 1*2*3 == 6 

function recursiveFactorial(num) {
    // your code here
    
    if (num <=1){
        console.log("ending recusion.")
        return 1
    }
    console.log("hitting recursion function with " + num)
    return num * recursiveFactorial(num - 1)
}

console.log(recursiveFactorial(3))
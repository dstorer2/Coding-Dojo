//Create a standalone function that accepts a string
//and an integer, and rotates the characters in the
//string to the right by that amount.
//this one must be done without built in methods
//("Did I shine my shoes today?", 9) ->
//"es today?Did I shine my shoe"


// function bubbleSort(arr){
//     var unsorted = true;

//     while(unsorted){
//         unsorted = false;
//         for(var i = 0; i < arr.length - 1; i++){
//             if(arr[i] > arr[i + 1]){
//                 var temp = arr[i];
//                 arr[i] = arr[i+1];
//                 arr[i+1] = temp;

//                 unsorted = true;
//             }
//         }
//     }

//     return arr;
// }


const rotateString = (str, num) => {
    let i = 0;
    while(i < num){
        let x = str.length-1;
        for(let j = str.length - 2; j >= 0; --j){
            let temp = str[j];
            str[j] = str[x];
            str[x] = temp;
            --x;
        }
        ++i;
    }
    return str;
}

console.log(rotateString("Did I shine my shoes today?", 9));

// let testString = "012345";
// console.log(rotateString(testString, 3));
// let shoes = "Did I shine my shoes today?";
// console.log(rotateString(shoes, 9));

//write a function that will return true if str2 is a
//rotation of str1. otherwise return false
//("Did I shine my shoes today?", "es today?Did I shine my shoe")
// -> returns true
const isRotation = (str1, str2) => {
    for(let i = 0; i < str1.length; ++i){
        let newStr = rotateString(str1, i);
        if(newStr == str2){
            return true;
        }
    }
    return false;
}

// console.log(isRotation("Did I shine my shoes today? ", "es today?Did I shine my sho"));
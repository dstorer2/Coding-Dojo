const stringToWordArray = (str) => {
    let arr = [];
    let word = '';
    for(let i = 0; i < str.length; ++i) {
        if(str[i] != ' ') {
            word += str[i]

        }
        if(str[i] == ' ' || str[i+1] == null) {
            arr.push(word);
            word = '';
            while(str[i+1] == ' ' && str[i+1] != null) {
                ++i;
            }
        }
        // console.log(i);
    }
    // console.log(arr);
    return arr;
}

console.log(stringToWordArray("Did I shine my shoes today?      "));
console.log(stringToWordArray("two             words"));


const reverseWordOrder = (str) => {
    let newStr = '';
    let arr = stringToWordArray(str);
    console.log(arr)
    for(let i = arr.length - 1; i >= 0; --i) {
        if(i==0) {
            newStr += arr[i];
        }
        else {
            newStr += arr[i] + ' ';
        }
    }

    return newStr;
}

// console.log(reverseWordOrder("This is a test"));
// console.log(reverseWordOrder("A man a plan a canal Panama"));
// Write a function that given a sorted array of numbers, returns a string representing a book index. Combine consecutive pages to create ranges.

// Example: [1,3,4,5,7,8,10,12] --> "1, 3-5, 7-8, 10, 12"
// Example: [14, 21, 22, 23, 24, 26, 27] --> "14, 21-24, 26-27"



function bookIndex(arr){
    var str = ""
    for ( var i = 0; i < arr.length; i++){
        temp = i
        while (arr[i] + 1 === arr[i + 1]){
            i ++
        }
        if(i > temp){
            str += arr[temp], "+", arr[i]
        }
        // console.log(arr.slice(temp, i+1))
        // console.log(temp)
    }
    return str
}

console.log(bookIndex([1,3,4,5,7,8,10,12]))
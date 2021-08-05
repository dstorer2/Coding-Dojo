//Given a sorted array and a value, return whether the
//array contains that value. Do not sequentially iterate
//the array. Instead, 'divide and conquer', taking
//advantage of the fact that the array is sorted.
//try not to use built in functions, if you have to then so be it

function binarySearch(arr, num){
    mid = Math.floor(arr.length/2)
    if (num == arr[mid]) {
        console.log("Found the number!")
        return num
    }
    else if (num > arr[mid]) {
        var newArr = []
        for ( var x = mid + 1; x < arr.length; x++){
            newArr.push(arr[x])
        }
        binarySearch(newArr, num)
    }
    else if (num < arr[mid]) {
        var newArr = []
        for ( var x = 0; x < mid; x++){
            newArr.push(arr[x])
        }
        binarySearch(newArr, num)
    }
    else {
        return false
    }
}

// console.log(binarySearch([0,1,2,3,4,8,15,16,23,42,108,109,115,122,241,298,500], 500));



console.log(binarySearch([0,1,2,3,4,8,15,16,23,42,108,109,115,122,241,298,500], 3));
// console.log(binarySearch([0,1,2,3,4,8,15,16,23,42,108,109,115,122,241,298,500], 157));
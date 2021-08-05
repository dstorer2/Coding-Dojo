//write a function that returns whether the given array
//has a balance point between indices, where one side's
//sum is equal to the other's
//note: the array is unsorted
//[1,2,3,4,10] -> true (point is between 4 and 10)
//[1,2,4,2,1] -> false
//[-2,-6,-8] -> true
function balancePoint(arr){
    if (arr.length == 0){
        return true
    }
    if (arr.length == 1){
        return false
    }
    else{
        for (var i = 0; i < arr.length; i++){
            var x = 0
            var y = arr.length - 1
            var sum1 = 0
            var sum2 = 0
            console.log("first half")
            while( x <= i ) {
                sum1 += arr[x]
                console.log(sum1)
                x ++
            }
            console.log("second half")
            while ( y > i) {
                sum2 += arr[y]
                console.log(sum2)
                y --
            }
            if (sum1 == sum2) {
                console.log("Between "+ arr[i]+" and "+arr[i+1])
                return true
            }
        }
        return false
    }

}

// console.log(balancePoint([1,2,3,4,10]));
// console.log(balancePoint([1,2,4,2,1]));
// console.log(balancePoint([-8,-6,-2]));
// console.log(balancePoint([7,8,9,24]));

//Here, a balance point is ON an index, not between indices
//Return the balance index where sums are equal on both
//sides (exclude the point's own value).
//Return -1 if none exist.
// [-2,5,7,0,3] -> 2
//[9,9] -> -1
function balanceIndex(arr) {
    if (arr.length == 0) {
        console.log("array has length of 0.")
        return false
    }
    if (arr.length == 1) {
        console.log("array has length of 1.")
        return true
    }
    else {
        for (var i = 1; i <= arr.length - 2; i ++) {
            var sum1 = 0
            var sum2 = 0
            var x = 0
            var y = arr.length - 1
            console.log("first half")
            while(x < i) {
                sum1 += arr[x]
                console.log(sum1)
                x++
            }
            console.log("second half")
            while(y > i) {
                sum2 += arr[y]
                console.log(sum2)
                y--
            }
            if (sum1 == sum2) {
                console.log("Balance index: "+ arr[i])
                return true
            }
        }
        return false
    }
}

// console.log(balanceIndex([-2,5,7,0,3]));
// console.log(balanceIndex([9,9]));
console.log(balanceIndex([9,12,17,6,5,9,30,5]));

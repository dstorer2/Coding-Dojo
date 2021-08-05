//remove array duplicates. Do not alter the
//original array. Return a new array with the values
//in the order they first appear in the original
//[1,2,1,3,4,2] -> [1,2,3,4]


function removeDuplicates(arr){
    var newArr = [];
    newArr.push(arr[0])
    for (var i = 1; i < arr.length; i++){
        for (var j = 0; j < newArr.length; j++){
            if (arr[i] != newArr[j]){
                continue
            }
        }
    }

}

console.log(removeDuplicates([1,2,1,3,4,2]));
console.log(removeDuplicates([4,8,4,4,15,4,15,16,23,8,42,4]));

//bonus challenge! remove array duplicates without
//creating a new array
function removeDuplicates2(arr){    
}

console.log(removeDuplicates2([1,2,1,3,4,2]));
console.log(removeDuplicates2([4,8,4,4,15,4,15,16,23,8,42,4]));
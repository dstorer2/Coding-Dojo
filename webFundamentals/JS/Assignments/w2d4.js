var nums = [ 
    [1, 2, 3],
    [4, 5, 6],
    [7, 8, 9] 
]

var moreNums = [
    [1, 5, 7, 9, 3, 8],
    [3, 6, 4, 9, 0, 4]
]

// function printAll2d(arr2d){
//     for (var i = 0; i < arr2d.length; i++){
//         for (var j = 0; j < arr2d[i].length; j++){
//             console.log(arr2d[i][j]);
//         }
//     }
// }

// printAll2d(moreNums);

// function flatten(){

function flatten(arr2d){
    var flat = [];
    for (var i = 0; i < arr2d.length; i++){
        for (var j = 0; j < arr2d[i].length; j++){
            flat.push(arr2d[i][j])
        }
    }
    return flat;
}

console.log(flatten(moreNums))

// }
// // We can console.log the `8` in this array if we
// console.log(arr2d[0][2]);
// // the first index `0` will select the `[2, 5, 8]` sub-array
// // the second index `2` will select the `8` out of that sub-array


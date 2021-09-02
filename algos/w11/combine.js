//combine two pre-sorted arrays into one sorted array
//return the newly combined array
//bonus challenge: combine in place into leftArr instead of a new array
const combine = (leftArr, rightArr) => {
    var newArr = [];
    let i = 0;
    while(leftArr.length > 0 || rightArr > 0){
        if(leftArr[0] > rightArr[0] || leftArr.length == 0){
            newArr.push(rightArr[0]);
            rightArr.splice(0, 1);
        }
        else if(leftArr[0] < rightArr[0] || rightArr.length == 0){
            newArr.push(leftArr[0]);
            leftArr.splice(0, 1);
        }
    }
    return newArr;
}

const combineToRight = (leftArr, rightArr) => {
    for(let i = 0; i < leftArr.length; ++i){
        rightArr[rightArr.length] += 1;
        rightArr[rightArr.length -1] = leftArr[i];
        console.log(rightArr);
        let runner = rightArr[rightArr.length-1]
        let j = rightArr.length - 2;
        while(runner < rightArr[j]){
            let temp = rightArr[j];
            rightArr[j] = runner;
            runner = temp;
            j -= 2;
        }
    }
    return rightArr;
}

const mergeSort = (arr) => {
    console.log(arr);
    if(arr.length <= 1) return arr;
    let leftHalf = arr.slice(0, Math.floor(arr.length/2));
    let rightHalf = arr.slice(Math.floor(arr.length/2));
    return combine(mergeSort(leftHalf),mergeSort(rightHalf));
}

//should return [1,2,3,4,5,6,8,14]
console.log(mergeSort([5,4,2,6,8,14,1,3,11]));
// should return [0,1,2,3,4,6,7,9,11]
console.log(combineToRight([1,2,7,9],[0,3,4,6,11]));

// should return [0,1]
// console.log(combine([1],[0]));
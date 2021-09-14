// looping through the array from 0 to arr.length
// shift a value in the array back from the place it belongs
// the value to shift should incrememnt with each loop iteration
//follow this example for each step, with the current value in ()
//step one: [(6),4,5,2,8,14,1,3] -> [(6),4,5,2,8,14,1,3]
//step two: [6,(4),5,2,8,14,1,3] -> [(4),6,5,2,8,14,1,3]
//step three: [4,6,(5),2,8,14,1,3] -> [4,(5),6,2,8,14,1,3]
//step four: [4,5,6,(2),8,14,1,3] -> [(2),4,5,6,8,14,1,3]
//step five: [2,4,5,6,(8),14,1,3] -> [2,4,5,6,(8),14,1,3]
//and so on...
const insertionSort = (arr) => {
    for(let i=1;i<arr.length;i++){
        let current_value = i;
        for(let j=i-1;j>=0;j--){
            if (arr[current_value]<arr[j]){
                temp = arr[current_value];
                arr[current_value] = arr[j];
                arr[j] = temp;
                current_value--
            }
        }
    }
    return arr
}

console.log(insertionSort([6, 4, 5, 2, 8, 14, 1, 3]))
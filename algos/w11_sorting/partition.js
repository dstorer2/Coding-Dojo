const partition = (arr) => {
    console.log(arr);
    const pivot = arr[0];
    let pivi = 0;

    for(let i = 1; i < arr.length; ++i){
        if(arr[i] < pivot){
            ++pivi;
            //put number at the beginning
            for(let j = i - 1; j >= 0; --j){
                let temp = arr[j];
                arr[j] = arr[j+1];
                arr[j+1] = temp;
            }
            console.log(arr);
        }
    }

    console.log(arr);
    return pivi;
}

console.log(partition([6,4,5,2,8,14,1,3]));
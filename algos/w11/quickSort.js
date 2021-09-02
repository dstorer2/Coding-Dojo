function quickSort(arr){
    const p = Math.floor(Math.random()*arr.length)
    console.log(p)
    console.log(arr)
    for(let i = 0; i < arr.length; ++i){
        for(let j = arr.length - 1; j > p; --j){
            
        }
        while(arr[i] < arr[p]){
            i++;
        }
        while(arr[j] > arr[p]){
            j--;
        }
        let temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
        console.log(arr)
        console.log("##############")
    }
    if(j > 0 && j+1 < arr.length-1){
        const left = arr.slice(0, j);
        quickSort(left);
        const right = arr.slice(j+1, arr.length-1)
        quickSort(right);
    }
    else if(j == 0 && j+1 < arr.length -1){
        const right = arr.slice(j+1, arr.length -1)
        quickSort(right);
    }
    else if(j > 0 && j+1 == arr.length-1){
        const left = arr.slice(0, j);
        quickSort(left);
    }
    else{
        return j;
    }
}

var test = [10, 15, 6, 4, 12, 5, 3, 13, 1, 9]
quickSort(test);
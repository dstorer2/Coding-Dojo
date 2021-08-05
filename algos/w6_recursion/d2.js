//  Given a number, add the collective sum up to that number (using Fiboncci sequence)

// F0-> F1-> F2-> F3-> F4-> F5-> F6-> F7-> F8-> F9-> F10
// 0->   1->   1->    2->   3->   5->   8->   13-> 21-> 34-> 55

function recursiveFibonnaci(num){
    // your code here
    if(num == 0){
        return 0
    }
    var y = 0
    var z = 1
    var fibonnaci = 1
    for (var x = 1; x < num; x++){
        fibonnaci = y + z
        y = z
        z = fibonnaci
    }
    return fibonnaci
}

console.log(recursiveFibonnaci(9))
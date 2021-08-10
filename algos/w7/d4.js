//given 2 different 2 dimensional arrays, both resembling
//rectangles, and with the second array having a shorter
//height and length, confirm if the smaller 2D array can be
//found in the larger 2D array
/*given [[12,34,45,56],
        [98,87,76,65],
        [56,67,78,89],
        [54,43,32,21]]
    and [[67,78],
        [43,32]]    
    return true
*/

function matrixSearch(large, small){
    for (var i = 0; i <= large.length - small.length; ++i){
        for (var j = 0; j <= large[0].length - small[0].length; ++j){
            var x = 0;
            var is_valid = true;
            while (x < small.length){
                if(is_valid == true){
                    var y = 0;
                    while (y < small[x].length){
                        if (large[i+x][j+y] != small[x][y]){
                            is_valid = false
                            break
                        }
                        y++
                    }
                    x++
                }
                else{
                    break
                }
            }
            if (is_valid == true){
                console.log("The small matrix exists within the large matrix starting at point "+i+", "+j+" of the larger matrix")
                return true
            }
        }
    }
    return false
}

const bigArr = [[12,34,45,56],
                [98,87,67,78],
                [56,67,78,89],
                [54,43,32,21]];
const smallArr = [[34,45],
                [87,67]]; 

console.log(matrixSearch(bigArr,smallArr));
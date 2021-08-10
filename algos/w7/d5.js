/*
Joe drives a taco truck in the booming town of Squaresburg.
He uses an array of [x,y] coordinates corresponding to
locations of his customers. They walk to his truck, but he
is fair-minded so he wants to minimize total distance from
truck to customers. City blocks are perfect squares, and
every street is two-way, at right angles. He only parks by
street corners(coordinates like [37,-16]). Customers only
travel on streets: coordinate [2,-2] is distance 4 from [0,0].
Joe checks the array before deciding where to park. Given a
customer coordinate array, return an optimal taco truck
location.
given [[10,0],[-1,-10],[2,4]]
return [2,0] as total distance is 25(8+13+4)
*/

function tacoTruck(customerArr){
    var xmin = customerArr[0][0];
    var xmax = customerArr[0][0];
    var ymin = customerArr[0][0];
    var ymax = customerArr[0][0];
    for (var i = 0; i < customerArr.length; ++i){
        for (var j = 0; j < customerArr[i].length; ++j){
            if (j = 0 && customerArr[i][j] < xmin){
                xmin = customerArr[i][j]
            }
            if (j = 0 && customerArr[i][j] > xmax){
                xmax = customerArr[i][j]
            }
            if (j = 1 && customerArr[i][j] > ymax){
                ymax = customerArr[i][j];
            }
            if (j = 1 && customerArr[i][j] < ymin){
                ymin = customerArr[i][j]
            }
        }
        console.log(xmin + xmax + ymin + ymax)
        var amin = (xmax - xmin) + (ymax - ymin);
        var bmin = (xmax - xmin) + (ymax - ymin);
        var cmin = (xmax - xmin) + (ymax - ymin);
        for (var y = ymin; y <= ymax; ++y){
            for (var x = xmin; x < xmax; ++x){
                for (var i = 0; i < customerArr.length; ++i){
                    for (var j = 0; j < customerArr[i].length; ++j){
                        if (j == 0 && i == 0){
                            var aXDist = customerArr[i][j] - x;
                        }
                        if (j == 1 && i == 0){
                            var aYDist = customerArr[i][j] - y;
                        }
                        if (j == 0 && i == 1){
                            var bXDist = customerArr[i][j] - y;
                        }
                        if (j == 1 && i == 1){
                            var aYDist = customerArr[i][j] - y;
                        }
                        if (j == 0 && i == 2){
                            var cXDist = customerArr[i][j] - y;
                        }
                        if (j == 1 && i == 2){
                            var cYDist = customerArr[i][j] - y;
                        }
                    }
                    
                }
            }
        }
    }
}

console.log(tacoTruck([[10,0],[-1,-10],[2,4]]));
console.log(tacoTruck([[3,1],[-1,2],[0,0]]));
// Number.prototype.isPrime = function() {
//         for( let i=2; i<Math.sqrt(this); i++ ) {
//             if( this % i === 0 ) {
//                 return false;
//             }
//         }
//         return true;
//     }

//     const { performance } = require('perf_hooks');
//     const start = performance.now();
//     let primeCount = 0;
//     let num = 2; // for math reasons, 1 is considered prime
//     while( primeCount < 1e5 ) {
//         if( num.isPrime() ) {
//             primeCount++;
//         }
//         num++;
//     }
//     console.log(`The 100,000th prime number is ${num-1}`);
//     console.log(`This took ${performance.now() - start} milliseconds to run`);

// recursive
// const { performance } = require('perf_hooks');
// const start = performance.now();
// function rFib( n ) {
//     if ( n < 2 ) {
//         return n;
//     }
//     return rFib( n-1 ) + rFib( n-2 );
// }
// console.log(rFib(20));
// console.log(`This took ${performance.now() - start} milliseconds to run`);
// iterative
// function iFib( n ) {
//     const vals = [ 0, 1 ];
//     while(vals.length-1 < n) {
//         let len = vals.length;
//         vals.push( vals[len-1] + vals[len-2] );
//     }
//     return vals[n];
// }
// console.log(iFib(20));
// console.log(`This took ${performance.now() - start} milliseconds to run`);
// iFib(20);

// ITERATIVE IS FASTER


const { performance } = require('perf_hooks');
const start = performance.now();

const story = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Provident culpa nihil repellat nulla laboriosam maxime, quia aliquam ipsam reprehenderit delectus reiciendis molestias assumenda aut fugit tempore laudantium tempora aspernatur? Repellendus consequatur expedita doloribus soluta cupiditate quae fugit! Aliquid, repellat animi, illum molestias maiores, laboriosam vero impedit iusto mollitia optio labore asperiores!";
const reversed1 = story.split("").reverse().join("");
const reversed2 = text => {
    let 
    for(let i = 0; i < text.length/2; ++i){
        var temp = text[i]
        text[i] = text[text.length-i-1]
        text[text.length-i-1] = temp
    }
    return text
}

console.log(reversed2(story))
console.log(`This took ${performance.now() - start} milliseconds to run`);

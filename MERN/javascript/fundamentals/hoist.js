// question 1
// console.log(hello);                                   
// var hello = 'world'
// AFTER HOISTING

// var hello;
// console.log(hello);  // logs undefined
// hello = "hello world";


// question 2
// var needle = 'haystack';
// test();
// function test(){
//     var needle = 'magnet';
//     console.log(needle);
// }
// // AFTER HOISTING
// var needle = 'haystack';
// function test(){} function is defined
// test(): // calls function
// var needle = 'magnet'; variable is redifined within the scope of the function
// console.log(needle) // "magnet" is logged to the console.


// question 3
// var brendan = 'super cool';
// function print(){
//     brendan = 'only okay';
//     console.log(brendan);
// }
// console.log(brendan);
// AFTER HOISTING
// var brendan = 'super cool'; // variable declared and defined with global scope
// function print(){    // function defined
//     brendan = 'only okay';   // function never called so nothing in here happens
//     console.log(brendan);
// }
// console.log(brendan); // "super cool" is logged to the console

// question 4
// var food = 'chicken';
// console.log(food);
// eat();
// function eat(){
//     food = 'half-chicken';
//     console.log(food);
//     var food = 'gone';
// }
// AFTER HOISTING
// var food = 'chicken';
// the eat() function is declared and defined
// console.lgo(food) // chicken is logged
// eat(); // eat function is called
//     food = 'half-chicken'; // var food is redefined
//     console.log(food); // the new variable value is logged
//     var food = 'gone'; // var food is redefined
// }

// question 5
// mean();
// console.log(food);
// var mean = function() {
//     food = "chicken";
//     console.log(food);
//     var food = "fish";
//     console.log(food);
// }
// console.log(food);


//AFTER HOISTING
// var mean; // mean is declared as a variable
// mean() // mean is called before it has been defined as a function and throws a syntax error

// question 6
// console.log(genre);
// var genre = "disco";
// rewind();
// function rewind() {
//     genre = "rock";
//     console.log(genre);
//     var genre = "r&b";
//     console.log(genre);
// }
// console.log(genre);

//AFTER HOISTING
// var genre; // genre is declared as a variable
// function rewind() is declared and defined
//console.log(genre); // variable has not been defined so undefined is logged
// var genre = "disco"; // variable is defined
// rewind(); // function gets valled
//     genre = "rock"; // variable is redefined
//     console.log(genre); // "rock" logged
//     var genre = "r&b"; // variable is redefined
//     console.log(genre); // "r&b" is logged
// console.log(genre); // globally scoped definition of genre is logged - "disco"

//question 7
// dojo = "san jose";
// console.log(dojo);
// learn();
// function learn() {
//     dojo = "seattle";
//     console.log(dojo);
//     var dojo = "burbank";
//     console.log(dojo);
// }
// console.log(dojo);

// AFTER HOISTING
// var dojo; // variable declared
// function learn(); // function is declared and defined
// dojo = "san jose"; // variable defined
// console.log(dojo); // "san jose" logged
// learn(); // function called
//     dojo = "seattle"; // variable redefined
//     console.log(dojo); // "seattle" logged
//     var dojo = "burbank"; // variable redefined
//     console.log(dojo); // "burbank" logged
// console.log(dojo); // globally scoped definition of var dojo is logged - "san jose"

// question 8
console.log(makeDojo("Chicago", 65));
console.log(makeDojo("Berkeley", 0));
function makeDojo(name, students){
    const dojo = {};
    dojo.name = name;
    dojo.students = students;
    if(dojo.students > 50){
        dojo.hiring = true;
    }
    else if(dojo.students <= 0){
        dojo = "closed for now";
    }
    return dojo;
}

// AFTER HOISTING
// function makeDojo(); // function is declared and defined 
// console.log(makeDojo("Chicago", 65)); // funciton is called in the console log
//     const dojo = {}; // variable dojo declared to be an object
//     dojo.name = name; // value of name key is set to "Chicago"
//     dojo.students = students; // value of students key is set to 65
//     if(dojo.students > 50){ // condition hits
//         dojo.hiring = true;  // new key "hiring" is set to a value of true
//     else if(dojo.students <= 0){ // condition not met, skips

// console.log(makeDojo("Berkeley", 0)); // funciton is called in the console log
//     const dojo = {}; // variable dojo declared to be an object
//     dojo.name = name; // value of name key is set to "Berkley"
//     dojo.students = students; // value of students key is set to 0
//     if(dojo.students > 50){ // condition not met, skips
//     else if(dojo.students <= 0){ // condition hits
//         dojo = "closed for now"; // sytax error trying to convert a constant type variable from object to string

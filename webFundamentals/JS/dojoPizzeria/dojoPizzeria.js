// function pizzaOven(crustType, sauceType, cheeses, toppings) {
//     var pizza = {};
//     pizza.crustType = crustType;
//     pizza.sauceType = sauceType;
//     pizza.cheeses = cheeses;
//     pizza.toppings = toppings;
//     return pizza;
// }
    
// var p1 = pizzaOven("deep dish", "traditional", ["mozzarella"], ["pepperoni", "sausage"]);
// console.log(p1);

// var p2 = pizzaOven("hand tossed", "marinera", ["mozzarella", "feta"], ["mushrooms", "olives", "onions"])
// console.log(p2)

// var p3 = pizzaOven("thick", "white", ["mozzarella", "goat"], ["basil", "tomato"])
// console.log(p3)

// var p4 = pizzaOven("thin", "marinera", ["provalone"], ["green peppers", "black olives", "onions"])
// console.log(p4)

var pizza = [
    {"name": "crust", "types": ["thin", "thick", "stuffed", "deep dish", "hand tossed"]},
    {"name": "sauce", "types": ["traditional", "marinera", "white"]},
    {"name": "cheese", "types": ["fresh mozzarella", "smoked mozzarella", "provolone", "parmigiano reggiano", "pecorino romano"]},
    {"name": "toppings", "types": ["pepperoni", "sausage", "ham", "banana peppers", "green peppers", "onion", "olives", "pineapple", "tomato" ]}
]

function randomPizza(){
    var randPizza = []
    for (var i = 0; i < pizza.length; i++){
        randPizza.push (pizza[i].types[Math.floor(Math.random() * pizza[i].types.length)])
    }
    return randPizza
}

console.log(randomPizza())
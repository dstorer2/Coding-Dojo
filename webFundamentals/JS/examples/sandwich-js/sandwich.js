var bread = "wheat";
var protein = "london broil";
var cheeses = ["provolone", "pepperjack"];
var condiments = ["arugala", "mayo", "tomatoes"];

var sandwich1 = {
    bread: "wheat",
    proteins: ["london broil", "bacon"],
    cheeses: ["provolone", "pepperjack"],
    condiments: ["arugala", "mayo", "tomatoes"],
    display: function(){
        console.log("the bread is:          " + this.bread);
        console.log("the cheese is:          " + this.cheeses);
        console.log("the proteins are:         " + this.proteins);
        console.log("the condiments are:      " + this.condiments);
    }
}

sandwich1.display();

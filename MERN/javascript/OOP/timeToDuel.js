class Card{
    constructor(name, cost){
        this.name = name;
        this.cost = cost;
    }
}

class Unit extends Card{
    constructor(name, cost, power, res){
        super(name, cost);
        this.power = power;
        this.res = res;
    }
    attack(target){
        target.res -= this.power;
        console.log(`${this.name} attacked ${target.name} for ${this.power} damage to their resilience.`)
    }
}

class Effect extends Card{
    constructor(name, cost, text, magnitude, stat){
        super(name, cost);
        this.text = text;
        this.magnitude = magnitude;
        this.stat = stat;
        
    }
    play(target){
        console.log(`${this.name} card used on ${target.name}`)
        console.log(this.text);
        if(this.stat = "resilience"){
            target.res += this.magnitude
            return this;
        }
        else{
            target.power +=this.magnitude
            return this;
        }
    }
}

const RBN = new Unit("Red Belt Ninja", 3, 3, 4);
const BBN = new Unit("Black Belt Ninja", 4, 5, 4);
const hardAlgo = new Effect("Hard Algorithm", 2, "increase target's resilience by 3", 3, "resilience")
const UPR = new Effect("Unhandled Promise Rejection", 1, "reduce target's resilience by 2", -2, "resilience")
const PP = new Effect("Pair Programming", 3, "increase target's power by 2", 2, "power")

hardAlgo.play(RBN);
UPR.play(RBN);
PP.play(RBN);
RBN.attack(BBN);
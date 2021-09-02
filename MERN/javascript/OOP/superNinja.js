class Ninja{
    constructor(name, health = 10, speed = 3, strength = 3){
        this.name = name;
        this.health = health;
        this.speed = speed;
        this.strength = strength;
    }
    sayName(){
        console.log(`Hi, my name is ${this.name}`)
    }
    showStats(){
        console.log("\\\\\\\\\\\\\\ Ninja Stats //////////")
        console.log(`Name: ${this.name}`);
        console.log(`Strength: ${this.strength}`);
        console.log(`Speed: ${this.speed}`);
        console.log(`Health: ${this.health}`);
    }
    drinkSake(){
        this.health += 10;
        console.log("Health increased by 10!")
    }
    // methods
}

class Sensei extends Ninja{
    constructor(name){
        super(name, 200, 10, 10);
        this.wisdom = 10;

    }
    speakWisdom(){
        super.drinkSake();
        console.log(`What one programmer can do in one month, two programmers can do in two months.`)
    }
}
const superSensei = new Sensei("Master Splinter");
superSensei.speakWisdom();
superSensei.showStats();
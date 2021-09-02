class Node{
    constructor(val){
        this.val = val;
        this.next = null;
        //THIS IS NEW
        this.child = null;
    }
}
//singly linked list
//add to front, add to back, display/contains
class SLL{
    constructor(){
        this.head = null;
    }

    addToFront(val){
        //make a new node
        //set the next value of the node to current head
        //set the head to the new node
        let newNode = new Node(val);
        newNode.next = this.head;
        this.head = newNode;
    }

    //this is BROKEN!!! but its brokenness will help us test our algo today
    addToBack(val){
        let runner = this.head;
        while(runner.next != null){
            runner = runner.next;
        }
        runner.next = new Node(val);
        //this line below is the broken part but leave it for testing
        runner.next.next = this.head;
    }

    //will return true if the list is a circle, false if it ends
    //you are allowed to change the SLL class, the node class,
    //whatever you see fit in order to make this happen
    hasLoop(){
        let runner = this.head;
        while (runner.next != null){
            if (runner.next == this.head){
                console.log("This list is a loop")
                return true;
            }
            runner = runner.next
        }
        console.log("This list is NOT a loop")
        return false;
    }

    //this function should find where the loop connects and break it
    //so that it functions as a normal SLL
    breakLoop(){
        if(this.hasLoop()){
            let runner = this.head
            while (runner.next != null){
                if (runner.next == this.head){
                    runner.next = null;
                    console.log("Loop broken!")
                    return true;
                }
                runner = runner.next;
            }
        }
        else{
            console.log("This list is not a loop. Nothing the break!")
            return false;
        }
    }

    printMe(){
        let returnStr = '';
        let runner = this.head;
        while(runner != null){
            returnStr += `${runner.val} -> `;
            runner = runner.next;
        }
        console.log(returnStr);
        return returnStr;
    }

    printN(n){
        let returnStr = '';
        let runner = this.head;
        for(let i = 0; i < n; ++i){
            if(runner === null) return returnStr;
            returnStr += `${runner.val} -> `;
            runner = runner.next;
        }
        console.log(returnStr);
        return returnStr;
    }
}

mySLL = new SLL();
mySLL.addToFront(1);
mySLL.addToFront(5);
mySLL.addToFront(3);
mySLL.addToFront(4);
mySLL.addToFront(5);
mySLL.addToBack(0);
mySLL.breakLoop();
// mySLL.printN(50);
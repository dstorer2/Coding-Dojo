class Node{
    constructor(value){
        this.value = value
        this.next = null
    }
}

class SLList{
    constructor(){
        this.head = null
    }

    addToFront(value) {
        var node = new Node(value);
        node.next = this.head;
        this.head = node;
        return this;
    }

    // given a value, add it to the back of your singly linked list
    // what if the list is empty?
    addToBack(value) {
        var node = new Node(value);
        if(this.head == null) {
            this.head = node;
        }
        var runner = this.head;
        while(runner.next != null) {
            runner = runner.next;
        }
        runner.next = node;
        return this;
    }
    
    // remove the first node in the list
    removeFromFront() {
        if(this.head){
            this.head = this.head.next
        }

        // your code here
    }

    getPenultimate() {
        var runner = this.head;
        while( runner.next != null ){
            runner = runner.next
        }
        return runner
    }

    // remove the last node in the list
    removeFromBack() {
        var runner = this.head;
        while( runner.next.next != null){
            runner = runner.next
        }
        console.log(runner)
        runner.next = null
        
    }
    
    // print the singly linked list
    printValues() {
        if(this.head == null) {
            console.log("There's nothing in this list!");
            return this;
        }
        var runner = this.head;
        while(runner != null) {
            console.log(`${runner.value} --> `);
            // console.log(runner.value + " --> ");
            runner = runner.next;
        }
        return this;
    }
}

const sll = new SLList();
sll.addToFront(-3)
sll.addToFront(-122)
sll.addToFront(41)
sll.addToBack(48)
sll.addToBack(-5)
sll.addToBack(-15)
sll.addToBack(14)
sll.printValues()
console.log("==========================================")
sll.removeFromBack()
sll.printValues()
console.log("==========================================")
sll.removeFromFront()
sll.printValues()
console.log("==========================================")
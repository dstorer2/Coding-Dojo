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

    // find and return the second to last value in your SLL
    secondToLast() {
        // your code here
        var runner  = this.head
        if( runner.next == null){
            console.log("There's only one node in this list")
        }
        if( runner == null){
            console.log("Add some nodes to this list first!")
        }
        while ( runner.next.next != null ){
            runner = runner.next
        }
        return runner.value
    }

    // given a list of integers, remove the negative values from the list
    removeNegatives() {
        // your code here
        var runner = this.head
        if ( runner == null ){
            console.log("Add some nodes to this list first!")
        }
        while ( runner.next != null) {
            if ( runner.value < 0 ){
                var head  = runner
                runner.next = this.head
                head.next = null
            }
            if ( runner.next.value < 0 ){
                var negativeNode = runner.next
                runner.next = runner.next.next
                negativeNode.next = null
            }
            else {
            runner = runner.next
            }
        }
        return this

    }

    // find the given location in your list and append (add after) that location the given value as a new node
    appendValue(loc, val){
        // your code here
        var node = new Node(val);
        var position = 0;
        var runner = this.head;
        var nextNode;
        while ( position < loc ){
            runner = runner.next
            console.log(position)
            position += 1
        }
        nextNode = runner.next
        runner.next = node
        node.next = nextNode
        return this;
    }

    // find the given location in your list and prepend (add before) that location the given value as a new node
    prependValue(loc, val){
        // your code here
        if (loc == 0){
            sll.addToFront(val)
        }
        var node = new Node(val);
        var position = 0;
        var runner = this.head;
        var nextNode;
        while ( position < loc - 1 ){
            runner = runner.next
            console.log(position)
            position += 1
        }
        nextNode = runner.next
        runner.next = node
        node.next = nextNode
        return this;
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
sll.addToFront(-3)
sll.printValues()
console.log("==========================================")
// sll.appendValue(1, 15)
// sll.printValues()
// console.log("==========================================")
// sll.prependValue(4, 6)
// sll.printValues()
sll.removeNegatives()
sll.printValues()

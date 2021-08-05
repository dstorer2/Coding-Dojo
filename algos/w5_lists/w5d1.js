class Node{
    constructor(value){
        this.value = value
        this.next = null
    }
}

// a queue operates on the principal of "First In, First Out" like waiting in line for something
class SLQueue {
    constructor() {
        this.head = null
        this.tail = null
    }

    // add a node with the given value to the queue
    enqueue(value) {
        var node = new Node(value)
        var runner = this.head
        if ( this.head == null ){
            this.head = node
            this.tail = node
        }
        else{
            this.tail.next = node
            this.tail = node
        }
        return this
        // your code here
    }

    // remove and return the front value from the queue
    dequeue() {
        if ( !this.head ){
            console.log("There are no nodes in the queue")
            return null
        }
        var temp = this.head.value
        this.head = this.head.next
        return temp
        // your code here
    }

    //return true/false based on whether you find the given value in a queue
    contains(value) {
        if ( !this.head ) {
            console.log("This queue is empty!")
            return null
        }
        var runner = this.head;
        while ( runner ) {
            if ( runner.value === value) {
                return true;
            }
            runner = runner.next
        }
        return false
        // your code here
    }

    // find the size/length of a queue
    size(){
        var runner = this.head;
        var count = 0;
        while ( runner ) {
            count ++;
            runner = runner.next;
        }
        console.log(count)
        return count
        // your code here
    }

    displayQueue(){
        var runner = this.head
        if ( runner == null){
            console.log("There are no nodes in the queue")
        }
        while (runner != null){
            console.log(runner.value)
            runner = runner.next
        }
        return this

        // your code here
    }

}


var q = new SLQueue();
q.enqueue(1);
q.enqueue(2);
q.enqueue(3);
q.enqueue(3);
q.enqueue(2);
q.enqueue(1);
q.dequeue();
q.size();
q.contains(3);
q.contains(6);
q.displayQueue();
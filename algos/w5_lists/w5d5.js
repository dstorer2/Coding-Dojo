class Node{
    constructor(value){
        this.value = value
        this.next = null
    }
}

// a queue operates on the principal of "First In, First Out" like waiting in line for something
class SLQueue{
    constructor() {
        this.head = null
        this.tail = null
    }

    enqueue(value) {
        var newNode = new Node(value);

        if (!this.head){
            this.head = newNode;
            this.tail = newNode;
        }

        this.tail.next = newNode;
        this.tail = this.tail.next;
        return this;
    }

    dequeue() {
        if(!this.head) {
            console.log("Nothing in this queue!");
            return null;
        }
        var temp = this.head.value;
        this.head = this.head.next;
        return temp;
    }

    size(){
        var runner = this.head;
        var count = 0;
        while (runner){
            count++;
            runner = runner.next;
        }
        return count;
    }
    
    displayQueue(){
        if (!this.head){
            console.log("This queue is empty.");
        }
        else {
            var runner = this.head;
            var str = "";
            while(runner){
                str += runner.value + " -> ";
                runner = runner.next;
            }
            str += "null";
            console.log(str);
        }
    }

        // Reorder SLQueue values to alternate first half values with second half values, in order. For example: (1,2,3,4,5) becomes (1,4,2,5,3). You may create one additional SLQueue, if needed.

        // 1 --> 2 --> 3 --> 4 --> 5 --> 
        // 1 --> 2 --> 3 -->    |      4 --> 5 --> 
        // 1 --> 4 --> 2 --> 5 --> 3 --> 

    interleaveQueue(){
        var count = Math.ceil(this.size()/2)
        var runner = this.head
        var x = 0
        while (x < count){
            x++
            runner = runner.next
        }

        var runner2 = this.head
        var y = runner2.next
        var last = this.tail
        while (runner.next){
            runner2.next = runner;
            if(runner.next){
                runner = runner.next;
            }
            runner2 = runner2.next
            runner2.next = y
            y = y.next
            runner2 = runner2.next
        }
        y.next = last
        return this
        // your code here
    }

}


var q = new SLQueue();
q.enqueue(1);
q.enqueue(2);
q.enqueue(3);
q.enqueue(4);
q.enqueue(5);
q.enqueue(6);
q.enqueue(7);

q.interleaveQueue();
q.displayQueue()
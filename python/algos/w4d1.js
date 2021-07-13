class Node{
    constructor(valueInput){
        this.value= valueInput;
        this.next = null;
    }
}

class SLL{
    constructor(){
        this.head = null;
    }

    addToFront(value) {
        var node = new Node(value);
        node.next = this.head;
        this.head = node;
        return this;
    }

    // given a value, add it to the back of your singly linked list
    // what if the list is empty?
    addToBack(valueInput){
        var node = new Node(valueInput);
        var runner = this.head;
        while (runner.next != null){
            runner = runner.next
        }
        runner.next = node
        return this;
    }


    // given a value, print whether the list contains that value
    contains(value) {
        var runner = this.head;
        while (runner.value != value){
            if(runner.next == null){
                break
            }
            runner = runner.next
        }
        if (runner.value == value){
            console.log("The list contains the specified value")
        }
        else{
            console.log("The list does not contain the specified value")
        }
    }

    // print out the SLL
    display(){
        var runner = this.head;
        while (runner != null){
            console.log(runner.value)
            runner = runner.next
        }
    }
}

a = new Node(1)

list = new SLL()

list.addToFront(1).addToFront(2).addToFront(3).addToBack(0).contains(7)






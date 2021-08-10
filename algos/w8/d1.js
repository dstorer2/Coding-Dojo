class Node{
    constructor(val){
        this.val = val;
        this.next = null;
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

    //create a method to reverse the order of the SLL
    //1->2->3->4->5-> should be 5->4->3->2->1->
    //for extra challenge, do this without creating a new SLL
    moveHeadToBack(){
        let oldHead = this.head;
        let newHead = this.head.next;
        newHead = this.head;
        oldHead.next = null;
        let runner = this.head;
        while(runner.next != null){
            runner = runner.next
        }
        runner.next = oldHead;

    }
    reverse(){
        let runner = this.head;
        while(runner.next != null){

        }
    }
}

mySLL = new SLL();
mySLL.addToFront(1);
mySLL.addToFront(2);
mySLL.addToFront(3);
mySLL.addToFront(4);
mySLL.addToFront(5);
mySLL.moveHeadToBack();
mySLL.printMe();
// mySLL.reverse();
// mySLL.printMe();
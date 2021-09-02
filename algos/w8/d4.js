class DNode{
    constructor(val){
        this.val = val;
        this.prev = null;
        this.next = null;
    }
}

class DLL{
    constructor(){
        this.head = null;
        this.tail = null;
    }

    //given a value, place a new node with that value
    //at the end of the list, becoming the new tail
    //make sure it works when the list is empty!
    //and make sure to connects things two ways!
    push(val){
        //add first node here
        if(this.head === null){
            this.head = new DNode(val);
            this.tail = this.head;
        }
        else{
            this.tail.next = new DNode(val);
            this.tail.next.prev = this.tail;
            this.tail = this.tail.next;
        }
    }

    //remove the tail from the list and return the value
    pop(){
        if(this.tail == null){
            console.log("This list is empty. No nodes to remove")
        }
        if(this.head == this.tail){
            this.head = null;
            this.tail = null;
            console.log("This list only had one node. It has been removed")
        }
        else{
            var popNodeVal = this.tail.val;
            this.tail = this.tail.prev;
            this.tail.next.prev = null;
            this.tail.next = null;
            console.log("Removed tail node.")
            return popNodeVal
        }
    }

    //return the value at the head
    front(){
        return this.head.val;
    }

    //return the value at the tail
    back(){
        return this.tail.val;
    }

    //return true if any node in the list matches the given
    //value. return false if the value does not appear
    contains(val){
        let runner = this.head;
        while(runner != null){
            if (runner.val == val){
                console.log(`This list does contain the value, ${val}`)
                return true;
            }
            runner = runner.next;
        }
        console.log(`This list does NOT contain the value, ${val}`);
        return false;
    }

    //count up how many nodes exist in the list and return
    //the count
    size(){
        let runner = this.head;
        let count = 0;
        while(runner != null){
            count +=1
            runner = runner.next;
        }
        console.log(count)
        return count
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

    reversePrint(){
        let returnStr = '';
        let runner = this.tail;
        while(runner != null){
            returnStr += `<- ${runner.val}`;
            runner = runner.prev;
        }
        console.log(returnStr);
        return returnStr;
    }
}

let myDLL = new DLL();
myDLL.push(1);
myDLL.push(2);
myDLL.push(3);
myDLL.push(4);
myDLL.printMe();
// myDLL.pop();
myDLL.front();
myDLL.printMe();
myDLL.reversePrint();
console.log(myDLL.contains(4));
// console.log(`let's take this value out: ${myDLL.pop()}`);
// myDLL.printMe();
// console.log(myDLL.size());
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
        this.tail = this.tail.prev
        this.tail.next.prev = null
        let value = this.tail.next.val
        this.tail.next = null
        return value;
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
            if(runner.val === val) return true;
            runner = runner.next;
        }
        return false;
    }

    //count up how many nodes exist in the list and return
    //the count
    size(){
        let runner = this.head;
        let count = 0;
        while(runner != null){
            ++count;
            runner = runner.next;
        }
        return count;
    }

    reverse(){
        var temp = this.tail
        this.tail = this.head
        this.head = temp

        this.head.next = this.head.prev
        this.head.prev = null

        var runner = this.head.next
        while (runner !=this.tail) {
            var temp = runner.next
            runner.next = runner.prev
            runner.prev = temp
            runner = runner.next
        }
        this.tail.prev = this.tail.next
        this.tail.next = null
        
    }

    //determine whether the list is valid, make sure next
    //and prev pointers match, returns false if not valid
    //true if valid
    isValid(){
        var runner = this.head
        while (runner.next!=null) {
            if (runner.next.prev != runner) {
                return false
            }
        runner = runner.next
        }
        if (runner!= this.tail) {
            return false
        }
        return true
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
myDLL.reverse();
myDLL.printMe();
console.log(myDLL.isValid());
myDLL.head.next.next = null;
// myDLL.head.next.next.prev = null;
console.log(myDLL.isValid());

// console.log(myDLL.contains(4));
// console.log(`let's take this value out: ${myDLL.pop()}`);
// myDLL.printMe();
// console.log(myDLL.size());
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

    printMeWithChildren(){
        let returnStr = '';
        let runner = this.head;
        while(runner != null){
            returnStr += `${runner.val}`;
            if(runner.child){
                returnStr += "(";
                let runner2 = runner.child.head;
                while(runner2 !== null){
                    returnStr += `${runner2.val} ->`;
                    runner2 = runner2.next;
                }
                returnStr += ")";
            }
            returnStr += " -> ";
            runner = runner.next;
        }
        console.log(returnStr);
        return returnStr;
    }

    //populates each node with a random amount of children from 0 to 4
    populateChildren(){
        
        let runner = this.head;

        while(runner !== null){
            let numChildren = Math.floor(Math.random() * 5);
            if(numChildren !== 0){
                let childList = new SLL();
                for(let i = 0; i < numChildren; ++i){
                    childList.addToFront(Math.floor(Math.random() * 50));
                }
                runner.child = childList;
            }
            runner = runner.next;
        }
    }

    /*
        For this method(and this list), each node has .next, but also
        .child that is either null or points to another SLL. In turn,
        each child node could point to another list. Don't alter .child;
        arrange .next pointers to "flatten" the hierarchy into one linear
        list, from head through all others via .next
    */
    flattenChildren(){
        let runner = this.head;
        while (runner != null){
            if(runner.child != null){
                var nextNode = runner.next;
                var runner2 = runner.child.head;
                while(runner2.next != null){
                    runner2 = runner2.next
                }
                runner.next = runner.child.head;
                runner.child = null;
                runner2.next = nextNode;
                runner = nextNode;
            }
            else{
                runner = runner.next;
            }
        }
    }


}

mySLL = new SLL();
mySLL.addToFront(1);
mySLL.addToFront(2);
mySLL.addToFront(3);
mySLL.addToFront(4);
mySLL.addToFront(5);
mySLL.populateChildren();
mySLL.printMeWithChildren();
mySLL.flattenChildren();
mySLL.printMeWithChildren();
mySLL.printMe();
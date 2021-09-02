class BNode{
    constructor(val){
        this.val = val;
        this.left = null;// <
        this.right = null;// >=
    }
}


class BST{
    constructor(){
        this.count = 0;
        this.root = null;
    }

    add(val){
        //if root is null, make new node as the root
        if(this.root === null){
            this.root = new BNode(val);
            this.count ++;
            return;
        }

        //make a runner
        let runner = this.root;

        //loop until
        while(runner !== null){
            if(val < runner.val){
                //left branch
                if(runner.left === null){
                    runner.left = new BNode(val);
                    return;
                }
                else{
                    //keep moving runner
                    runner = runner.left;
                }
            }
            else if(runner.val === val)
            {
                return;
            }
            else{
                //right branch
                if(runner.right === null){
                    runner.right = new BNode(val);
                    return;
                }
                else{
                    //keep moving runner
                    runner = runner.right;
                }
            }
            //keep going down until the left/right(depends) is null
            //when you reach that condition, add a new node there
        } 
    }

    max(){
        let runner = this.root;
        while(runner.right !== null){
            runner = runner.right;
        }
        return runner.val;
    }

    min(){
        let runner = this.root;
        while(runner.left !== null){
            runner = runner.left;
        }
        return runner.val;
    }

    //return true if the tree contains the given value
    //return false if the value is not in the tree
    //hint: recursion is a good approach!!!
    contains(val){
        if(this.root == null){
            console.log("No nodes in the tree.")
            return false;
        }
        let runner = this.root;
        while(runner != null){
            if(runner.val == val){
                console.log(`${val} does exist in this tree`)
                return true;
            }
            if(val > runner.val){
                runner = runner.right;
            }
            else{
                runner = runner.left;
            }
        }
        console.log(`${val} does NOT exist in this tree`)
        return false;
    }

    recursiveContains(val){
        var result = false;
        const cont = (currentNode) => {
            if(currentNode === null) return;
            if(currentNode.val === val){
                result = true;
                return;
            }
            cont(currentNode.left);
            cont(currentNode.right);
        }
        cont(this.root)
        return result;
    }

    //return the count of nodes in the tree
    size(){
        var nodeCount = 0;
        const count = (currentNode) => {
            if(currentNode === null) return;
            nodeCount += 1;
            count(currentNode.left);
            count(currentNode.right);
        }
        count(this.root);
        return nodeCount;
    }

    //find the longest sequence of nodes
    //from root to the bottom
    height(){
        var nodeCount = 0;
        var maxCount = 0;
        const count = (currentNode) => {
            if(currentNode == null) return;
            nodeCount ++;
            if(currentNode.left == null && currentNode.right == null){
                if(nodeCount > maxCount){
                    maxCount = nodeCount;
                    nodeCount --;
                }
                else{
                    nodeCount --;
                }
                return;
            } 
            count(currentNode.left);
            count(currentNode.right);
            nodeCount --;
        }
        count(this.root)
        return maxCount;
    }

    getNodeBeforeVal(val){
        var returnNode;
        const run = (currentNode) => {
            if(currentNode == null) return;
            if(currentNode.left != null){
                if(currentNode.left.val == val){
                    returnNode = currentNode;
                    return;
                }
            }
            if(currentNode.right != null){
                if(currentNode.right.val == val){
                    returnNode = currentNode;
                    return;
                }
            }
            run(currentNode.left);
            run(currentNode.right);
        }
        run(this.root);
        return returnNode;
    }

    remove(val){
        if(recusiveContains(val)){
            if(this.root.val != val){
                let runner = getNodeBeforeVal(val);
                console.log(runner.val)
                //RIGHT REMOVE
                if(runner.right != null){
                    if(runner.right.val == val){
                        //BOTH NULL
                        if(runner.right.right == null && runner.right.left == null){
                            runner.right = null;
                            console.log(`${val} removed from BST`)
                            return true;
                        }
                        //ONE NULL
                        if(runner.right.right != null && runner.right.left == null){
                            runner.right = runner.right.right;
                            console.log(`${val} removed from BST`)
                            return true;
                        }
                        if(runner.right.left != null && runner.right.right == null){
                            runner.right = runner.right.left;
                            console.log(`${val} removed from BST`)
                            return true;
                        }
                        //BOTH NOT NULL
                        if(runner.right.right != null && runner.right.left != null){
                            let temp = runner.right.right;
                            runner.right = runner.right.left;
                            while(runner.right !=null){
                                runner = runner.right
                            }
                            runner.right = temp;
                            console.log(`${val} removed from BST`)
                            return true;
                        }
                    }
                }
                //LEFT REMOVE
                else if(runner.left.null){
                    if(runner.left.val == val){
                        //BOTH NULL
                        if(runner.left.right == null && runner.left.left == null){
                            runner.left = null;
                            console.log(`${val} removed from BST`)
                            return true;
                        }
                        //ONE NULL
                        if(runner.left.right != null && runner.left.left == null){
                            runner.left = runner.left.right;
                            console.log(`${val} removed from BST`)
                            return true;
                        }
                        if(runner.left.left != null && runner.left.right == null){
                            runner.left = runner.left.left;
                            console.log(`${val} removed from BST`)
                            return true;
                        }
                        //BOTH NOT NULL
                        if(runner.left.right != null && runner.left.left != null){
                            let temp = runner.left.right;
                            runner.left = runner.left.left;
                            runner = runner.left
                            while(runner.right !=null){
                                runner = runner.right
                            }
                            runner.right = temp;
                            console.log(`${val} removed from BST`)
                            return true;
                        }
                    }
                }
            }
            //IF ROOT IS VAL
            else{
                let temp = this.root.right;
                this.root = this.root.left;
                let runner = this.root;
                while(runner.right != null){
                    runner = runner.right;
                }
                runner.right = temp;
                console.log(`${val} removed from BST`)
                return true;
            }
        }
        //IF BTS DOES NOT CONTAIN VAL
        else{
            console.log(`${val} does not exist in this BST`);
            return false;
        }
    }

    printMe(){
        const internalPrint = (currentNode) => {
            if(currentNode === null) return;
            console.log(currentNode.val);
            internalPrint(currentNode.left);
            internalPrint(currentNode.right);
        }
        internalPrint(this.root);
    }
}

let myBST = new BST();
myBST.add(15);
myBST.add(12);
myBST.add(4);
myBST.add(-30);
myBST.add(160);
myBST.add(8);
myBST.add(23);
myBST.add(42);
myBST.add(43);
myBST.add(44);
// myBST.printMe();
// console.log(`min is ${myBST.min()} and max is ${myBST.max()}`);
// console.log(myBST.recursiveContains(42));
// console.log(myBST.size());
// console.log(myBST.height());
myBST.printMe();
myBST.remove(23);
console.log("######################")
myBST.printMe();
// console.log(myBST.getNodeBeforeVal(23));
class BNode{
    constructor(val){
        this.val = val;
        this.left = null;
        this.right = null;
    }
}

class BST{
    constructor(){
        this.root = null;
    }

    add(val){
        if(this.root == null){
            this.root = new BNode(val);
            return;
        }
        
        let runner = this.root;

        while(runner != null){
            if(val < runner.val){
                if(runner.left == null){
                    runner.left = new BNode(val)
                }
                else{
                    runner = runner.left
                }
            }
            else if(runner.val == val){
                return;
            }
            else{
                if(runner.right == null){
                    runner.right = new BNode(val);
                    return;
                }
                else{
                    runner = runner.right;
                }
            }
        }
    }

    max(){
        let runner = this.root;
        while(runner.right !=null){
            runner = runner.right;
        }
        return runner.val;
    }

    min(){
        let runner = this.root;
        while(runner.left !=null){
            runner = runner.left;
        }
        return runner.val;
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
myBST.add(4);
myBST.add(8);
myBST.add(15);
myBST.add(16);
myBST.add(23);
myBST.add(42);

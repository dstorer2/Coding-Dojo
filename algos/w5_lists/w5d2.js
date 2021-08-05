class Node{
    constructor(value){
        this.value = value
        this.next = null
    }
}

// a stack operates on the principal of "First In, Last Out" like waiting in line for something
class SLStack{
    constructor() {
        this.top = null
    }

    // add a given value to your stack
    push(value){
        var newNode  = new Node(value)
        if ( this.top == null ) {
            this.top = newNode
        }
        else{
            newNode.next = this.top
            this.top = newNode
        }
        return this
        // your code here
    }
    
    // remove and return the top value
    pop(){
        var oldTop = this.top
        if ( this.top == null ){
            console.log("There are no nodes in this stack!")
        }
        else if ( this.top.next == null ) {
            console.log(this.top.value)
            this.top = null
            return null
        }
        else {
            this.top = this.top.next
            console.log("Popped"+ String( oldTop.value ))
            oldTop = null
        }
        return this.top
        // your code here
    }

    // return (don't remove) the top value of a stack
    returnTop() {
        if ( this.top == null ) {
            console.log("There are no nodes in this stack")
            return null
        }
        else {
            console.log( "The value of the top node is "+String(this.top.value) )
        }
        return this.top
        // your code here
    }

    printStack() {
        if ( this.top == null ) {
            console.log("There are no nodes in this stack")
            return null
        }
        var digger = this.top
        while( digger ){
            console.log( digger.value )
            digger = digger.next
        }
        return this
        // your code here
    }

    isPallindrome() {
        var values = []
        var runner = this.top
        if (this.top == null){
            console.log("There are no nodes in this stack")
            return false
        }
        while (runner) {
            values.push(runner.value)
            runner = runner.next
        }
        console.log(values)
        
        for (var x = 0; x < values.length/2; x++) {
            if (values[x] !== values[values.length - 1 - x]){
                return console.log("The stack IS NOT a pallindrome")
            }
        }
        return console.log("The stack IS a pallindrome")
    }
    generatePallindrome(sl){
        var arr = []
        for (var i = 0; i < sl/2; i++) {
            arr.push(Math.floor(Math.random()*10))
        }
        for (var x = arr.length -  1; x >= 0; x--){
            arr.push(arr[x])
        }
        console.log(arr)
        for (var y = 0; y < arr.length; y++){
            sls.push(arr[y])
        }
        return this
    }
}

var sls = new SLStack()
// sls.push(1)
// sls.push(2)
// sls.push(349)
// sls.push(3)
// sls.push(25)
// sls.push(3)
// sls.push(3)
// sls.push(25)
// sls.push(3)
// sls.push(349)
// sls.push(2)
// sls.push(1)
// sls.pop()
// sls.returnTop()




sls.generatePallindrome(21)

sls.printStack()

sls.isPallindrome()
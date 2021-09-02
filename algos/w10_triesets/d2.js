class TrieNode{
    constructor(letter){
        this.letter = letter;
        this.isWord = false;
        this.children = {};
    }
}

class TrieSet{
    constructor(){
        this.root = new TrieNode("");
    }

    add(word){
        let runner = this.root;

        //loop through the letters in the word
        for(let i = 0; i < word.length; i++){
            if(!runner.children[word[i]]){
                runner.children[word[i]] = new TrieNode(word[i]);
            }
            runner = runner.children[word[i]];
        }
        runner.isWord = true;
    }

    contains(word){
        let runner = this.root;

        for(let i = 0; i < word.length; i++){
            if(!runner.children[word[i]]){
                return false;
            }
            runner = runner.children[word[i]];
        }
        return runner.isWord;
    }

    //given a string representing the beginning of a word or words,
    //return an array of words that start with that string
    //example "cap" -> ["cap","captain","capture","capital"]
    //Object.keys(yourObject) gives an array of all the keys in a given object
    autocomplete(str){
        let runner = this.root;

        for(var i = 0; i < str.length; i++){
            if(!runner.children[str[i]]){
                return false;
            }
            runner = runner.children[str[i]]
        }
        var oneWord = str;
        var allWords = [];

        const findWords = (currentNode) => {
            if(currentNode.isWord == true){
                allWords.push(oneWord);
            }
            if(!currentNode.children) return;
            for(var x = 0; x < Object.keys(currentNode.children).length; x++){
                currentNode = currentNode.children[Object.keys(currentNode.children)[x]];
                oneWord += currentNode.letter;
                console.log(allWords)
                findWords(currentNode);
                oneWord = str;
            }
        }
        findWords(runner);
        return allWords;
    }

    test(){
        var obj = this.root.children;
        console.log(this.root.children["c"])
        return Object.keys(obj);
    }
}

let words = new TrieSet();
words.add("captain");
words.add("capture");
words.add("cap");
words.add("catch");
words.add("dog");
words.add("dig");
words.add("diagonal");
words.add("diligent");
words.add("dastardly");
words.add("done");
words.add("don");
words.add("dialogue");
words.add("dinner");
words.add("capital");
words.add("zap");
words.add("zen");
words.add("dip");
words.add("dipper");
words.add("digging");
words.add("digital");
words.add("zebra");
console.log(words.autocomplete("dig"));

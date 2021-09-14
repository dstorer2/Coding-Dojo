const dedupe = (str) => {
    for(let i = str.length-1; i > 0; --i){
        let x = i - 1;
        while(x >= 0){
            if(str[x] == str[i]){
                str = str.replace(str[x], "");
            }
            x--;
            console.log(str);
        }
    }
    return str;
}

console.log(dedupe("Snaps! Crackles! Pops!"));
console.log(dedupe("Did I shine my shoes today?"));
console.log(dedupe("Scoop dedupe!"));
console.log(dedupe("Ooooooooweeeeeeee!"));
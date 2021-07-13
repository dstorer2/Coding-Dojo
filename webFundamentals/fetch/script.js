var input = document.getElementById("input")

async function getPokemon(name){
    var response = await fetch("https://pokeapi.co/api/v2/pokemon/"+name);
    var data = await response.json();
    // console.log(data.sprites.front_default);

    var image = document.getElementById("pkmn")
    image.src = data.sprites.front_default
    image.alt = name;
}

getPokemon(input);

function searchForPokemon(){
    var pkmnInput = document.getElementById("pkmnInput");
    var name = pkmnInput.value;
    getPokemon(name);
}
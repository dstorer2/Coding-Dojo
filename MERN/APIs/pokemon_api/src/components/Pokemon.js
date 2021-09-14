import React, { useState } from "react";
import 'bootstrap/dist/css/bootstrap.min.css';
import axios from "axios";

const Pokemon = (props) => {
    const [pokemon, setPokemon] = useState([])
    
    const onSubmitHandler = (event) => {
        event.preventDefault();
        axios.get("https://pokeapi.co/api/v2/pokemon?limit=1000&offset=200")
            .then(res => {
                console.log(res.data.results);
                setPokemon(res.data.results);
            })
            .catch(err => console.log(err));
    }
    return(
        <div>
            <button className="btn btn-primary btn-lg" onClick={onSubmitHandler}>Generate Pokemon</button>
            <ul>
                {
                    pokemon.map((item, i) =>
                            <li key={i}>{item.name}</li>
                    )
                }
                <li>derp</li>
            </ul>
        </div>
    )
}

export default Pokemon;
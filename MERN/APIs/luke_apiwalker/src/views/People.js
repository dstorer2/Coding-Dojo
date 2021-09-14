import axios from "axios";
import React, { useEffect, useState } from "react";
import { useParams } from "react-router";
import BadSearch from "../components/BadSearch";
import { Link } from "react-router-dom";

const People = (props) => {
    const {ID} = useParams();
    const [error, setError] = useState(false);
    const [results, setResults] =useState({})
    const [world, setWorld] = useState({})

    useEffect(() => {
        axios.get(`https://swapi.dev/api/people/${ID}`)
            .then(res => setResults(res.data))
            .then(() => setError(false))
            .then(
                axios.get(`${results.homeworld}`)
                    .then(res => setWorld(res.data))
                    .catch(err => console.log(err))
            )
            .catch(err => setError(true))
    }, [ID])

    return(
        <div>
            {
                error ?
                    <BadSearch/> :
                    <div>
                        <h1>{results.name}</h1>
                        <h3>Height: {results.height} cm</h3>
                        <h3>Mass: {results.mass} kg</h3>
                        <h3>Hair Color: {results.hair_color}</h3>
                        <h3>Skin Color: {results.skin_color}</h3>
                        <h3>Home Word: {world.name}</h3>
                    </div>

            }
        </div>
    )
}

export default People;
import axios from "axios";
import React, { useEffect, useState } from "react";
import { useParams } from "react-router";
import BadSearch from "../components/BadSearch";

const People = (props) => {
    const {ID} = useParams();
    const [error, setError] = useState(false);
    const [results, setResults] =useState({})

    useEffect(() => {
        axios.get(`https://swapi.dev/api/planets/${ID}`)
            .then(res => setResults(res.data))
            .catch(err => setError(true))
    }, [ID])

    return(
        <div>
            {
                error ?
                    <BadSearch/> :
                    <div>
                        <h1>{results.name}</h1>
                        <h3>Climate: {results.climate} cm</h3>
                        <h3>Terrain: {results.terrain} kg</h3>
                        <h3>Surface Water: {results.surface_water}</h3>
                        <h3>Population: {results.population}</h3>

                    </div>

            }
        </div>
    )
}

export default People;
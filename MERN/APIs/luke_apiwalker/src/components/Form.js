import React, { useState} from "react";
import 'bootstrap/dist/css/bootstrap.min.css'
import { useHistory } from "react-router";


const Form = (props) => {
    const [searchVal, setSearchVal] = useState("people");
    const [ID, setID] = useState(1);
    const history = useHistory();

    const handleSubmit = (event) => {
        event.preventDefault();
        // console.log(`/${searchVal}/${ID}`)
        history.push(`/${searchVal}/${ID}`);
    }
    
    const handleSearchVal = (event) => {
        setSearchVal(event.target.value);
    }
    
    console.log(searchVal);

    const handleID = (event) => {
        setID(event.target.value);
        console.log(ID);
    }


    return(
        <form onSubmit={handleSubmit}>
            <label>Search for: </label>
            <select onChange={handleSearchVal}>
                <option value="people">people</option>
                <option value="planets">planets</option>
            </select>
            <label>ID: </label>
            <input onChange={handleID} type="number"/>
            <input className="btn btn-primary" value="Search" type="submit"/>
        </form>
    )
}

export default Form;
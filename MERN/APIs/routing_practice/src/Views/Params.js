import React from "react";
import { useParams } from "react-router";


const Params = (props) => {
    const {param} = useParams();
    if(isNaN(param)){
        return(
            <div>The word is: {param}</div>
        )
    }
    else{
        return(
            <div>The number is: {param}</div>
        )
    }
}

export default Params;
import React from "react";
import { useParams } from "react-router";

const Styled = (props) => {
    const {input, background, text} = useParams();
    return(
        <div style={{backgroundColor: background, color: text}}>
            <h1>The word is: {input}</h1>
        </div>
    )
}

export default Styled;
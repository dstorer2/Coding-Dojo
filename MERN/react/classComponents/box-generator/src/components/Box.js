import React, { useState } from "react";

const Box = (props) => {
    const [boxes, setBoxes] = useState([]);

    const createBox = (event) => {
        event.preventDefault();
        console.log(event.target);
        const newBox = {
            color: event.target[0].value
        }
        setBoxes([...boxes, newBox]);
    }
    return(
        <>
            <form onSubmit = {createBox}>
                <label>Color: </label>
                <input type="text" name="color" />
                <input type="submit" value="submit" />
            </form>
            <div className="allBoxes">
                {
                    boxes.map((item, i) =>
                        <div style={{backgroundColor: item.color}} key={i} className="box"></div>
                    )
                }
            </div>
        </>
    )
}

export default Box;
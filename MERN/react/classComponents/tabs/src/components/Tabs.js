import React, {useState} from "react";

const Tabs = (props) => {
    const [selectedIndex, setSelectedIndex] = useState(0);

    if (props.tabItems.length === 0){
        return "NoTabs!!!";
    }

    
    
    return(
        <div >
            <header style={{marginTop: 50}}>
            {
                props.tabItems.map((tab, i) => {
                    const labelStyle = {
                        padding: 20,
                        marginRight: 10,
                        border: "1px solid gray"
                    }
                    if(selectedIndex === i){
                        labelStyle.backgroundColor = "black";
                        labelStyle.color = "white";
                    }
                    return <span key={i} onClick={(event) => {setSelectedIndex(i);}} style={labelStyle}>{tab.label}</span>
                })
            }
            </header>
            <main>
                <h3 style={{margin: "50px auto", border: "1px solid black", width: "30%", padding: "10px"}}>{props.tabItems[selectedIndex].content}</h3>
            </main>
        </div>
    )
}

export default Tabs;
import React, {useState} from "react";

const Input = (props) => {
    const [currentTask, setCurrentTask] =useState("");

    const onSubmitHandler = (event)  => {
        event.preventDefault();
        const newTask = {
            text: currentTask,
            checked: false
        }
        props.setTasks([...props.tasks, newTask])

    }
    return(
        <div className="form-group">
            <form onSubmit={onSubmitHandler}>
                <input  type="text" classname="form-control" onChange={(event) => {setCurrentTask(event.target.value)}} value={currentTask.text}/>
                <input  type="submit" classname="btn btn-primary btn-lg" />
                
            </form>
        </div>
    )
}

export default Input;
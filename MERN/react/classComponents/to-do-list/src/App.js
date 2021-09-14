import './App.css';
import Task from './components/Task';
import 'bootstrap/dist/css/bootstrap.min.css';
import { useState } from 'react';
import Input from './components/Input'

function App() {
  const [tasks, setTasks] = useState([])

  const displayTask = (item, i) => {
    return <Task checkTask ={checkTask} key={i} text={item.text} checked={item.checked} idx={i} deleteTask={deleteTask}/>
  }

  const deleteTask = (id) => {
    console.log(id);
    setTasks([
      ...tasks.slice(0, id),
      ...tasks.slice(id +1)
    ])
  }

  const checkTask = (id) => {
    console.log(id);
    const updatedTask = tasks[id];
    updatedTask.checked = !updatedTask.checked;
    setTasks([
      ...tasks.slice(0, id),
      updatedTask,
      ...tasks.slice(id +1)
    ])

  }

  return (
    <div className="App">
      <h1>To Do List</h1>
      <Input tasks={tasks} setTasks={setTasks}/>
      <div id="tasks">
        {
          tasks.map(displayTask)
        }
      </div>
    </div>
  );
}

export default App;

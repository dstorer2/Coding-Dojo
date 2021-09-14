import { BrowserRouter, Switch, Route } from 'react-router-dom';
import './App.css';
import 'bootstrap/dist/css/bootstrap.min.css'
import People from './views/People';
import Form from './components/Form'
import Planets from './views/Planets';


function App() {
  

  return (
    <div className="App">
      <BrowserRouter>
        <Form />
        <Switch>
          <Route exact path="/people/:ID">
            <People/>
          </Route>

          <Route exact path="/planets/:ID">
            <Planets/>
          </Route>
        </Switch>
      </BrowserRouter>

    </div>
  );
}

export default App;

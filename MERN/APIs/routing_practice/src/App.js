import './App.css';
import {BrowserRouter, Switch, Route} from 'react-router-dom';
import Home from './Views/Home';
import Params from './Views/Params';
import Styled from './Views/Styled';


function App() {
  return (
    <div className="App">
      <BrowserRouter>
        <Switch>
          <Route exact path="/home">
            <Home />
          </Route>

          <Route exact path = "/:param">
            <Params/>
          </Route>

          <Route exact path = "/:input/:background/:text">
            <Styled/>
          </Route>

        </Switch>
      </BrowserRouter>

    </div>
  );
}

export default App;

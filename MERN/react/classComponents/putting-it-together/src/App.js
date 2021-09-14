import './App.css';
import Person from './components/Person';

function App() {
  return (
    <div className="App">
      <Person firstName="Jane" lastName="Doe" age={45} hairColor="Black"/>
      <Person firstName="John" lastName="Smith" age={88} hairColor="Grey"/>
    </div>
  );
}

export default App;

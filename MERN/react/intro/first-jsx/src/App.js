import React from 'react';
import './App.css';

import PersonCard from './components/PersonCard';

function App() {
  return (
    <div>
      <PersonCard firstName="Dwight" lastName="Schrute" age={39} hairColor="Dirty Blonde"/>
      <PersonCard firstName="Jim" lastName="Halpert" age={38} hairColor="Brown"/>
      <PersonCard firstName="Phylis" lastName="Vance" age={56} hairColor="Salt and pepper"/>
      <PersonCard firstName="Stanley" lastName="Hudson" age={59} hairColor="Black"/>
    </div>
  );
}

export default App;

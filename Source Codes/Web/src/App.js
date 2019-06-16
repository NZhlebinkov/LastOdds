import React from 'react';
import logo from './logo.svg';
import { BrowserRouter, Switch, Route } from 'react-router-dom';

import Home from './components/Home'
import Login from './components/Login'
import Search from './components/Search'
import Register from './components/Register'

import './App.css';

function App() {
  return (
    <div className="App">
      <BrowserRouter>
          <Switch>
              <Route exact path='/' component={Home} />
              <Route exact path='/login' component={Login} />
              <Route exact path='/register' component={Register} />
              <Route exact path='/search/:type/:search' component={Search} />
          </Switch>
      </BrowserRouter>
    </div>
  );
}

export default App;

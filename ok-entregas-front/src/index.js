import React from 'react';
import ReactDOM from 'react-dom';

import Login from './pages/login'
import Home from './pages/home'

import reportWebVitals from './reportWebVitals';
import { Switch, BrowserRouter as Router, Route } from 'react-router-dom';
import './css/index.css';

const rotas = (
  <Router>
    <Switch>
      <Route exact path = "/" component = {Login}/>
      <Route path = "/home" component = {Home}/>
    </Switch>
  </Router>
)
ReactDOM.render(rotas, document.getElementById('root'));

// If you want to start measuring performance in your app, pass a function
// to log results (for example: reportWebVitals(console.log))
// or send to an analytics endpoint. Learn more: https://bit.ly/CRA-vitals
reportWebVitals();

import React, { Component } from 'react';
import ReactDOM from 'react-dom';

import Login from './pages/login'
import Home from './pages/home'
import Dashboard from './pages/dashboard'
import Voip from './pages/voip'
import Historico from './pages/historico'

import reportWebVitals from './reportWebVitals';
import { Switch, BrowserRouter as Router, Route, Redirect } from 'react-router-dom';
import './css/index.css';

import { parseJwt, usuarioAutenticado } from './services/auth';

const PermissaoAdm = ({ component : Component }) => (
  <Route
    render = {props => 
      usuarioAutenticado() && parseJwt().role ==="admin" ? 
      <Component {...props}/>: 
      <Redirect to ="/" />
    }
  />

)
const rotas = (
  <Router>
    <Switch>
      <Route exact path = "/" component = {Login}/>
      <PermissaoAdm path = "/home" component = {Home}/>
      <Route path = "/dashboard" component = {Dashboard}/>
      <Route path = "/voice" component = {Voip}/>
      <Route path = "/historico" component = {Historico}/>
      <Redirect to= "/notfound"/>
    </Switch>
  </Router>
)
ReactDOM.render(rotas, document.getElementById('root'));

// If you want to start measuring performance in your app, pass a function
// to log results (for example: reportWebVitals(console.log))
// or send to an analytics endpoint. Learn more: https://bit.ly/CRA-vitals
reportWebVitals();

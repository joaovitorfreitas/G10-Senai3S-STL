import React, { Component } from 'react';
import { Link } from 'react-router-dom';
// import axios from 'axios';

import logo from '../img/logo.png'
import welcome from '../img/welcome.png'

import '../css/base-style.css'

export default class Login extends Component{
    constructor(props) {
        super(props);
        this.state = {

        }
    }


    render() {
        return (
            <section className="glass">
                <div>
                    <h1>Login</h1>
                    <form>
                        <div>
                            <label>E-mail</label>
                            <input></input>
                        </div>
                        <div>
                            <label>Senha</label>
                            <input></input>
                        </div>
                        <Link to ="/cadastro"><p>Não tem uma conta ? Crie uma</p></Link>
                        <button>Logar</button>
                    </form>
                </div>
                <div>
                    <div>
                        <img src={logo}/>
                        <img src={welcome}/>
                    </div>
                </div>
            </section>
        )
    }
}
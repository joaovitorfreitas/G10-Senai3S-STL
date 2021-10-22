import React, { Component } from 'react';
import { Link } from 'react-router-dom';
// import axios from 'axios';

import logo from '../img/logo.png'
import welcome from '../img/welcome.png'

import '../css/base-style.css'
import '../css/login.css'

export default class Login extends Component{
    constructor(props) {
        super(props);
        this.state = {

        }
    }


    render() {
        return (
            <main>
                <section className="glass">
                    <div className="user-info">
                        <h1>Login</h1>
                        <form className="forms">
                            <div className="inputs">
                                <label>E-mail</label>
                                <input type="email"></input>
                            </div>
                            <div className="inputs">
                                <label>Senha</label>
                                <input type="password"></input>
                            </div>
                            <Link to ="/" className="forgot"><p>Esqueceu a sua senha ?</p></Link>
                            <button className="btn">Logar</button>
                        </form>
                    </div>
                    <div className="images">
                        <div className="ilustration">
                            <img src={logo} className="logo" alt="Logo OK Entregas"/>
                            <img src={welcome} className="welcome" alt="Ilustração com mensagem de bem-vindo"/>
                        </div>
                    </div>
                </section>
                <div className="bc1"></div>
                <div className="bc2"></div>
                <div className="circle"></div>
                <div className="square"></div>
            </main>
        )
    }
}
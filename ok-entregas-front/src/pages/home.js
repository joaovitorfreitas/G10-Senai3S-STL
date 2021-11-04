import React, { Component } from 'react';
import { Link } from 'react-router-dom';
// import axios from 'axios';

import logo from '../img/logo.png'
import welcome from '../img/welcome.png'

import '../css/base-style.css'
import '../css/home.css'
import Side from '../components/side-bar'
import Email from '../components/email'

export default class Login extends Component{
    constructor(props) {
        super(props);
        this.state = {

        }
    }

    render() {
        return (
            <main>
                <Side/>
                <Email/>
                <section className="content">
                    <div className="glass-home flex flex-collumn ai-flex-start jc-flex-start">
                        <h1>Digite um CNPJ</h1>
                        <form className="pesquisa flex">
                            <div className="inputs-home flex flex-collumn">
                                <label>CNPJ</label>
                                <input type="text"></input>
                            </div>
                            <div className="flex ai-center ai-flex-end">
                                <button className="btn-pesquisar flex ai-center jc-center"><i id="lupa" className="fas fa-search"></i>Buscar</button>
                            </div>
                        </form>
                        <div className="resultado">

                        </div>
                    </div>
                </section>
                <div className="bc1"></div>
                <div className="bc2"></div>
            </main>
        )
    }

}
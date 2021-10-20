import React, { Component } from 'react';
// import axios from 'axios';

import logo from '../img/logo.png'
import cadastro from '../img/cadastro.png'

export default class Cadastro extends Component{
    constructor(props) {
        super(props);
        this.state = {

        }
    }


    render() {
        return (
            <section>
                <div>
                    <h1>Cadastro</h1>
                    <form>
                        <div>
                            <label>E-mail</label>
                            <input></input>
                        </div>
                        <div>
                            <label>Senha</label>
                            <input></input>
                        </div>
                        <div>
                            <label>Confirmar a senha</label>
                            <input></input>
                        </div>
                        <div>
                            <label>Registro de identificação</label>
                            <input></input>
                        </div>
                        <button>Cadastrar</button>
                    </form>
                </div>
                <div>
                    <div>
                        <img src={logo}/>
                        <img src={cadastro}/>
                    </div>
                </div>
            </section>
        )
    }
}
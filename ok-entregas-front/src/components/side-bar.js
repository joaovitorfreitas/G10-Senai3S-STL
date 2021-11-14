import React, { Component } from 'react';
import { Link } from 'react-router-dom';

import '../css/base-style.css'
import '../css/side-bar.css'
import '../css/cadastro.css'

export default class Side extends Component{
    constructor(props) {
        super(props);
        this.state = {

        }
    }

    abreModal = () => {
        const modal = document.getElementById('modal')
        modal.classList.add('mostrar')
        modal.addEventListener('click', (e) => {
            if (e.target.id === "modal" || e.target.id === "fechar") {
                modal.classList.remove('mostrar')
            }
        })
    }

    render() {
        return (
            <section>
                <section className="side-bar flex">
                    <div className="content-side-bar">
                        <ul className="side-bar-ul flex jc-space-eve flex-collumn">
                            <li><Link to ="/home"><i id="icon-home" className="fas fa-home"></i></Link></li>
                            <li><a onClick={this.abreModal}><i id="icon-user" className="fas fa-user-plus"></i></a></li>
                            <li><Link to ="/historico"><i id="icon-history" className="fas fa-history"></i></Link></li>
                            <li><Link to ="/voice"><i id="icon-phone" className="fas fa-phone"></i></Link></li>
                            <li><Link><i id="icon-office" className="fas fa-th-large"></i></Link></li>
                            <li><Link><i id="icon-off" className="fas fa-power-off"></i></Link></li>
                        </ul>
                    </div>
                </section>
                <section className="modal flex ai-center jc-center " id="modal">
                    <div className="modal-content flex flex-collumn ai-center jc-space-eve">
                        <h1 className="titulinho">Cadastrar um novo usuário</h1>
                        <div className="inputs-cadastro flex flex-collumn ai-center">
                            <label>E-mail do usuário</label>
                            <input type="text"></input>
                        </div>
                        <div className="inputs-cadastro flex flex-collumn ai-center">
                            <label>Primeiro Nome</label>
                            <input type="text"></input>
                        </div>
                        <div className="inputs-cadastro flex flex-collumn ai-center">
                            <label>Sobrenome</label>
                            <input type="text"></input>
                        </div>
                        <p className="frase">Ao concluir o processo de cadastro, o e-mail informado acima vai receber um e-mail e uma senha de primeiro acesso que deve ser trocada após o primeiro acesso.</p>
                        <div className="flex ai-center ai-flex-end">
                            <button className="btn-cadastro flex ai-center jc-center"><i id="cadastrinho" className="fas fa-user-plus"></i>Cadastrar</button>
                        </div>
                    </div>
                </section>
            </section>
        )
    }
}
import React, { Component } from 'react';
import { Link } from 'react-router-dom';

import '../css/base-style.css'
import '../css/side-bar.css'
import '../css/cadastro.css'
import axios from 'axios';

export default class Side extends Component{
    constructor(props) {
        super(props);
        this.state = {
            email : '',
            nome : '',
            sobrenome : '',
            senha : '',
            tipoUsuario : '',
            verificacao : false
        }
    }

    cadastrarUser = (event) => {
        event.preventDefault();

        let usuario = {
            email : this.state.email,
            nome : this.state.nome,
            sobrenome : this.state.sobrenome,
            senha : this.state.senha,
            tipoUsuario : this.state.tipoUsuario,
            verificacaoEmail : this.state.verificacao
        };
        axios.post("http://localhost:5000/api/usuario", usuario)
            
        .then (resposta => {
            if(resposta.status === 201){
                console.log('aeeeeee')
            }
        })
        .catch(erro => {
            console.log(erro);
        })
    }
    atualizaStateCampo = (campo) => {
        this.setState({[campo.target.name]: campo.target.value})
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

    deslogar () {
        localStorage.removeItem('token-login')
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
                            <li><Link to ="/"><i onClick={this.deslogar} id="icon-off" className="fas fa-power-off"></i></Link></li>
                        </ul>
                    </div>
                </section>
                <section className="modal flex ai-center jc-center " id="modal">
                    <form onSubmit={this.cadastrarUser} className="modal-content flex flex-collumn ai-center jc-space-eve">
                        <h1 className="titulinho">Cadastrar um novo usuário</h1>
                        <div className="inputs-cadastro flex flex-collumn ai-center">
                            <label>E-mail do usuário</label>
                            <input type="email" name='email' value={this.state.email} onChange={this.atualizaStateCampo}></input>
                        </div>
                        <div className="inputs-cadastro flex flex-collumn ai-center">
                            <label>Primeiro Nome</label>
                            <input type="text" name='nome' value={this.state.nome} onChange={this.atualizaStateCampo}></input>
                        </div>
                        <div className="inputs-cadastro flex flex-collumn ai-center">
                            <label>Sobrenome</label>
                            <input type="text" name='sobrenome' value={this.state.sobrenome} onChange={this.atualizaStateCampo}></input>
                        </div>
                        <div className="inputs-cadastro flex flex-collumn ai-center">
                            <label>Senha</label>
                            <input type="password" name='senha' value={this.state.senha} onChange={this.atualizaStateCampo}></input>
                        </div>
                        <div className="selects flex ai-center jc-space-eve">
                            <div className="input-select flex flex-collumn ai-center">
                                <label>Tipo de Usuário</label>
                                <select className="select-cadastro" name="tipoUsuario" value={this.state.tipoUsuario} onChange={this.atualizaStateCampo}>
                                    <option value="admin">Adm</option>
                                    <option value="vendedor">Vendedor</option>
                                </select>
                            </div>
                            <div className="checkbox flex ai-center">
                                <label className="checkbox-container"> Verificar E-mail 
                                    <input type="checkbox"/>    
                                    <span className="checkmark"></span>
                                </label>
                            </div>
                        </div>
                       
                        <div className="flex ai-center ai-flex-end">
                            <button type="submit" className="btn-cadastro flex ai-center jc-center"><i id="cadastrinho" className="fas fa-user-plus"></i>Cadastrar</button>
                        </div>
                    </form>
                </section>
            </section>
        )
    }
}
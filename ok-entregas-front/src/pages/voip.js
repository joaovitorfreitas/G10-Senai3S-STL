import React, { Component } from 'react';
// import axios from 'axios';

import '../css/base-style.css'
import Side from '../components/side-bar'
import Email from '../components/email'
import axios from 'axios';

import '../css/voip.css'


export default class Voip extends Component{
    constructor(props) {
        super(props);
        this.state = {
            idEmpresa : 0,
            nomeEmpresa : '',
            numeroDeFuncionarios : 0,
            numeroDeTelefone : '',
            emailEmpresa: '',
            nomeFantasia: '',
            cnpj: '',
            segmentoDeMercado: ''
        }
    }

    cadastrarEmpresa = (event) => {
        event.preventDefault();

        let empresa = {
            nomeEmpresa : this.state.nomeEmpresa,
            numeroDeFuncionarios : this.state.numeroDeFuncionarios,
            numeroDeTelefone : this.state.numeroDeTelefone,
            emailEmpresa : this.state.emailEmpresa,
            nomeFantasia : this.state.nomeFantasia,
            cnpj : this.state.cnpj,
            segmentoDeMercado : this.state.segmentoDeMercado
        };
        axios.post("http://localhost:5000/api/empresas", empresa)
        .then(resposta => {
            if(resposta.status === 201){
                console.log('aeejduejdueidj')
            }
        })

        .catch(erro => {
            console.log(erro);
        })
    }

    atualizaStateCampo = (campo) => {
        this.setState({[campo.target.name]: campo.target.value})
      }

    render() {
        return (
            <main>
                <Side/>
                <Email/>
                <section className="content">
                    <div className="glass-home">
                    <h1>VOIP</h1>
                    </div>
                    <section className="inputs">
                    <form onSubmit={this.cadastrarEmpresa}>
                    <div className="inputs-cadastro flex flex-collumn ai-center"> 
                    <label>Nome da Empresa</label>
                    <input type="text" name='nomeEmpresa' value={this.state.nomeEmpresa} onChange={this.atualizaStateCampo}/>
                    </div>

                    <div className="inputs-cadastro flex flex-collumn ai-center">
                    <label>Numero de Funcionários</label>
                    <input type="text" name='numeroDeFuncionarios' value={this.state.numeroDeFuncionarios} onChange={this.atualizaStateCampo}/>
                    </div>

                    <div className="inputs-cadastro flex flex-collumn ai-center">
                    <label>Numero de Telefone</label>
                    <input type="number" name='numeroDeTelefone' value={this.state.numeroDeTelefone} onChange={this.atualizaStateCampo}/>
                    </div>

                    <div className="inputs-cadastro flex flex-collumn ai-center">
                    <label>Email da Empresa</label>
                    <input type="text" name='emailEmpresa' value={this.state.emailEmpresa} onChange={this.atualizaStateCampo}/>
                    </div>

                    <div className="inputs-cadastro flex flex-collumn ai-center">
                    <label>Nome Fantasia</label>
                    <input type="text" name='nomeFantasia' value={this.state.nomeFantasia} onChange={this.atualizaStateCampo}/>
                    </div>

                    <div className="inputs-cadastro flex flex-collumn ai-center">
                    <label>Cnpj</label>
                    <input type="text" name='cnpj' value={this.state.cnpj} onChange={this.atualizaStateCampo}/>
                    </div>

                    <div className="inputs-cadastro flex flex-collumn ai-center">
                    <label>Segmento de Mercado</label>
                    <input type="text" name='segmentoDeMercado' value={this.state.segmentoDeMercado} onChange={this.atualizaStateCampo}/>
                    </div>

                    <div className="flex ai-center ai-flex-end">
                    <button type="submit" className="btn-cadastro flex ai-center jc-center"><i id="cadastrinho" className="fas fa-user-plus"></i>Cadastrar</button>
                    </div>
                    </form>
                </section>
                </section>
               
                <div className="bc1"></div>
                <div className="bc2"></div>
            </main>
        )
    }

}
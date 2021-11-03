import React, { Component } from 'react';
import { Link } from 'react-router-dom';
// import axios from 'axios';

import logo from '../img/logo.png'
import welcome from '../img/welcome.png'

import '../css/base-style.css'
import Side from '../components/side-bar'

export default class Historico extends Component{
    constructor(props) {
        super(props);
        this.state = {

        }
    }

    render() {
        return (
            <main>
                <Side/>
                <section className="content">
                    <div className="glass-home">
                        <h1>Historico</h1>
                    </div>
                </section>
                <div className="bc1"></div>
                <div className="bc2"></div>
            </main>
        )
    }

}
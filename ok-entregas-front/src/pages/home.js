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
                <section className="">
                    <h1>HOME</h1>
                </section>
                <div className="bc1"></div>
                <div className="bc2"></div>
            </main>
        )
    }

}
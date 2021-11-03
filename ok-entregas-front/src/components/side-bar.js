import React, { Component } from 'react';
import { Link } from 'react-router-dom';

import '../css/base-style.css'
import '../css/side-bar.css'

export default class Side extends Component{
    constructor(props) {
        super(props);
        this.state = {

        }
    }


    render() {
        return (
            <section className="side-bar flex">
                <div className="content-side-bar">
                    <ul className="side-bar-ul flex jc-space-eve flex-collumn">
                        <li><Link to ="/home"><i id="icon-home" className="fas fa-home"></i></Link></li>
                        <li><Link to ="/dashboard"><i id="icon-chart" className="fas fa-chart-bar"></i></Link></li>
                        <li><Link><i id="icon-user" className="fas fa-user-plus"></i></Link></li>
                        <li><Link to ="/historico"><i id="icon-history" className="fas fa-history"></i></Link></li>
                        <li><Link to ="/voice"><i id="icon-phone" className="fas fa-phone"></i></Link></li>
                        <li><Link><i id="icon-office" className="fas fa-th-large"></i></Link></li>
                        <li><Link><i id="icon-off" className="fas fa-power-off"></i></Link></li>
                    </ul>
                </div>
            </section>
        )
    }
}
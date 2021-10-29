import React, { Component } from 'react';
import { Link } from 'react-router-dom';

export default class Login extends Component{
    constructor(props) {
        super(props);
        this.state = {

        }
    }


    render() {
        return (
            <div>
                <ul>
                    <li><Link><i class="fas fa-home"></i></Link></li>
                    <li><Link><i class="fas fa-chart-bar"></i></Link></li>
                    <li><Link><i class="fas fa-user-plus"></i></Link></li>
                    <li><Link><i class="fas fa-history"></i></Link></li>
                    <li><Link><i class="fas fa-phone"></i></Link></li>
                    <li><Link><i class="fas fa-th-large"></i></Link></li>
                    <li><Link><i class="fas fa-power-off"></i></Link></li>
                </ul>
            </div>
        )
    }
}
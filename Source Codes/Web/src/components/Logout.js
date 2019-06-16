import React from 'react';
import observer from '../helpers/observer';
import requester from '../helpers/requester';
import {
  NavItem,
  NavLink, } from 'reactstrap';

export default class Logout extends React.Component {
    logout(event) {
        requester.get('/logout')
            .then(res => res.json())
            .then(res => {
                localStorage.removeItem('username');
                observer.fire('logging', false);
                observer.fire('notifications', {
                    type: res.type,
                    message: res.message
                });
            })
    }
    render(){
        return (
            <div>
                <NavLink onClick={this.logout}>Logout</NavLink>
            </div>
        );
    }
}
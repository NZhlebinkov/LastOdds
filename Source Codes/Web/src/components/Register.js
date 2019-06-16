import React from 'react';
import {Redirect} from 'react-router-dom'
import { InputGroup, InputGroupAddon, Button, Input,  Form, FormGroup, Label, Col } from 'reactstrap';
import observer from '../helpers/observer'
import requester from '../helpers/requester'
import Header from './Header'
import '../styles/forms.css'


class Register extends React.Component {
    constructor(props) {
        super(props);
    
        this.onChange = this.onChange.bind(this);
        this.onSubmit = this.onSubmit.bind(this);
        this.state = {
            username: '',
            password: '',
            redirect: false
        };
    }

    onChange(event){
        let name = event.target.name;
        let val = event.target.value;
        console.log('Changed')
        this.setState({
           [name]: val
        });
    }
    onSubmit(event) {
        event.preventDefault();
        if(!this.state.password || !this.state.username){
            observer.fire('notifications', {
                type: 'error',
                message: 'Моля попълнете всички полета'
            });
        } else {
            requester.post(this.state, '/register')
                .then(res => res.json())
                .then(res => {
                    if(res.type === 'info') {
                        localStorage.setItem('username', res.username);
                        observer.fire('logging', true);
                        this.setState({redirect: true});
                    }
                    observer.fire('notifications', {
                        type: res.type,
                        message: res.message
                    });
                });
        }
    }

  render() {
    if(this.state.redirect) {
        return <Redirect to='/'/>;
    }
    return (
        <div>
            <Header></Header>
            <h2>Register</h2>
            <Form className="form" onSubmit={this.onSubmit}>
            <Col>
                <FormGroup>
                <Label>Username</Label>
                <Input
                    type="text"
                    name="username"
                    placeholder="username"
                    onChange={this.onChange}
                />
                </FormGroup>
            </Col>
            <Col>
                <FormGroup>
                <Label for="examplePassword">Password</Label>
                <Input
                    type="password"
                    name="password"
                    placeholder="********"
                    onChange={this.onChange}
                />
                </FormGroup>
            </Col>
            <Button>Register</Button>
            </Form>
        </div>
    );
  }
}

export default Register;
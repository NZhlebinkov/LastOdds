import React from 'react'
import observer from '../helpers/observer'
import requester from '../helpers/requester'

export default function withLogging(WrappedComponent){
    return class extends React.Component{
        constructor(props){
            super(props);

            this.state = {
                logging: false,
                username: '',
                money: 0,
                roles: [],
                expositions:[],
                images: [],
                loaded: false
            };

            this.setRoles = this.setRoles.bind(this);
            this.subscription = this.subscription.bind(this);
            this.getUserData = this.getUserData.bind(this);

            observer.subscribe('logging', this.subscription);
        }
        componentDidMount(){
            let username = localStorage.getItem('username');
            if(username){
                this.setRoles();
                this.setState({
                    username: username
                });
            } else {
                requester.get('/logout');
                this.setState({
                    loaded: true,
                    logging: false
                });
            }
        }
        componentWillUnmount(){
            observer.unsubscribe('logging', this.subscription);
        }
        setRoles() {
            requester.get('/roles')
                .then(res => res.json())
                .then(res => {
                    if (res.roles) {
                        this.setState({
                            roles: res.roles,
                            money: res.money,
                            expositions: res.expositions,
                            images: res.images,
                            logging: true,
                            loaded: true
                        });
                    } else if(res.message !== 'Could not connect to server'){
                        this.setState({
                            roles: [],
                            logging: false,
                            loaded: true
                        });
                        localStorage.removeItem('username');
                    } else
                        this.setState({
                            loaded: false
                        });
                })
        }
        subscription(logged) {
            let username = localStorage.getItem('username');
            if(logged) {
                this.setRoles();
                this.setState({
                    logging: true,
                    username: username
                });
            } else {
                localStorage.removeItem('username');
                this.setState({
                    roles: [],
                    loaded: true,
                    logging: false
                });
            }


        }
        getUserData(){
            requester.get('/user')
                .then(res => res.json())
                .then(res => {
                    if(res.username && !this.state.logging) {
                        console.log(res);
                        this.setState({
                            username: res.username,
                            expositions: res.expositions,
                            images: res.images
                        });
                    }
                    else if(!res.username && this.state.logging)
                        this.setState({
                            logging: false
                        });
                })
        }
        render(){
            let isAdmin = false;
            if(this.state.roles.includes('admin')) isAdmin = true;
            if(!this.state.loaded)
                return <WrappedComponent 
                            logging={true} 
                            expositions={this.state.expositions}
                            images={this.state.images}
                            {...this.props} />
            return (
                <WrappedComponent
                    isAdmin={isAdmin}
                    username={this.state.username}
                    logging={this.state.logging}
                    getUserData={this.getUserData}
                    expositions={this.state.expositions}
                    images={this.state.images}
                    {...this.props} />
            )
        }
    }
}
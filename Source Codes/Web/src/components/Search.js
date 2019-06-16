import React from 'react';
import {Redirect} from 'react-router-dom'
import observer from '../helpers/observer'
import requester from '../helpers/requester'
import SportItem from './SportItem'
import Header from './Header'
import '../styles/forms.css'
import withLogging from '../hocs/withLogging.js'


class SearchBar extends React.Component {  
    constructor(props) {
        super(props);
        this.state = {sports: [], url: ''};
        this.changeCoeff = this.changeCoeff.bind(this);
    }

    componentDidMount(){
        console.log(this.props.match.params.search);
        this.updateCoeff();
    }

    updateCoeff() {
        requester.get('/api/sports/' + this.props.match.params.type + '/' + this.props.match.params.search)
            .then(res => res.json())
            .then(res => {
                if(res.type !== 'error'){
                    console.log(res.data);
                    this.setState({
                        sports: res.data
                    });
                }
                else
                    observer.fire('notifications', res);
            });
    }
    
    changeCoeff(item, bet) {
        requester.post({item: item._id, bet}, '/api/sports')
        .then(res => res.json())
        .then(res => {
            if(res.type !== 'error'){
                this.updateCoeff();
            }
            else
                observer.fire('notifications', res);
        });
    }
  render() {
    let sports = this.state.sports;
    return (
        <div>
            <Header></Header>
            {
                sports.map((item, i) => 
                    <SportItem item={item} changeCoeff={this.changeCoeff} logged={this.props.logging}>
                    </SportItem>)
            }
        </div>
    );
  }
}

export default withLogging(SearchBar);
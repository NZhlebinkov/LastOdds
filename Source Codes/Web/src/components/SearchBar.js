import React from 'react';
import {Redirect} from 'react-router-dom'
import { InputGroup, InputGroupAddon, Button, Input,  Dropdown, DropdownToggle, DropdownMenu, DropdownItem, Row, Col } from 'reactstrap';
import '../styles/forms.css'


class SearchBar extends React.Component {
    constructor(props) {
        super(props);
    
        this.toggle = this.toggle.bind(this);
        this.onChange = this.onChange.bind(this);
        this.onSubmit = this.onSubmit.bind(this);
        this.state = {
          dropdownOpen: false,
          dropDownValue: 'Event',
          search: ''
        };
    }
    
    toggle() {
        this.setState(prevState => ({
          dropdownOpen: !prevState.dropdownOpen
        }));
    }

    onChange(event){
        let name = event.target.name;
        let val = event.target.value;

        this.setState({
           [name]: val
        });
    }
    onSubmit() {
        if(this.state.search)
            this.setState({redirect: true});
    }

  render() {
    if(this.state.redirect)
        return <Redirect to={'/search/' + this.state.dropDownValue + '/' + this.state.search}/>;

    return (
        <div className="col-centered">
            <InputGroup>
            <InputGroupAddon addonType="prepend">
                <Dropdown  isOpen={this.state.dropdownOpen} toggle={this.toggle}>
                <DropdownToggle caret>
                    {this.state.dropDownValue}
                </DropdownToggle>
                <DropdownMenu>
                    <DropdownItem name="dropDownValue" onClick={this.onChange} value="Event">Event</DropdownItem>
                    <DropdownItem name="dropDownValue" onClick={this.onChange} value="Sport">Sport</DropdownItem>
                    <DropdownItem name="dropDownValue" onClick={this.onChange} value="League">League</DropdownItem>
                </DropdownMenu>
                </Dropdown>
            </InputGroupAddon>
                <input placeholder="Search bar" className="Search" name="search" onChange={this.onChange}/>
            <InputGroupAddon addonType="append">
                <Button color="primary" onClick={this.onSubmit}>Search!</Button>
            </InputGroupAddon>
            </InputGroup>
        </div>
    );
  }
}

export default SearchBar;
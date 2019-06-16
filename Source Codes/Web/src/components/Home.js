import React from 'react';
import SearchBar from './SearchBar'
import Slider from './Carousel'
import Header from './Header'


class Home extends React.Component {
    
  render() {
    return (
        <div>
            <Header></Header>
            <Slider></Slider>
            <SearchBar></SearchBar>
        </div>
    );
  }
}

export default Home;
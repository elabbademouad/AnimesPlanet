import React from 'react';
import ReactDOM from 'react-dom';

class App extends React.Component{
    constructor(){
        super();
        this.state={Animes:[]};
        fetch("http://localhost:5000/api/AnimesPlanet")
        .then(response=>response.json())
        .then(data=>this.setState({Animes:data}))
        .catch(err=>console.log(err));
    }
    render(){
        console.log(this.state.Animes);
        return <h1>{'Hello WOrld'}</h1>
    }
}
ReactDOM.render(<App />, document.getElementById('root'));
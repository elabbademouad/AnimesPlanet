import React from 'react';
import ReactDOM from 'react-dom';

class App extends React.Component{
    constructor(){
        super();
        this.state={header:''};
        fetch("http://localhost:5000/api/values/index")
        .then(response=>response.text())
        .then(data=>this.setState({header:data}))
        .catch(err=>console.log(err));
    }
    render(){
        return <h1>{this.state.header}</h1>
    }
}
ReactDOM.render(<App />, document.getElementById('root'));

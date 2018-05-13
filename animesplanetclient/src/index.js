import React from 'react';
import ReactDOM from 'react-dom';
import { BrowserRouter as Router, Route, Link } from "react-router-dom";
import 'bootstrap/dist/css/bootstrap.min.css';
import './index.css';
import cover from './cover.jpg'
class App extends React.Component{
    constructor(){
        super();
    }
    render(){
        return (
            <div >
            <div className='header'>
                <img className="img-fluid header"  src={cover}/>
            </div>
            <Router>
                <div id="nav">
                    <ul>
                        <li><Link to="/">Home</Link></li>
                        <li><Link to="/play">Jouer</Link></li>
                        <li><Link to="/play">Exemples</Link></li>
                        <li style={{float:'right'}}><Link to="/about">About</Link></li>
                    </ul>
                <div>
                    {/*
                        <Route exact path="/" component={Home} />
                        <Route path="/aboust" component={About} />
                        <Route path="/play" component={Play} />
                    */}
                </div>
                </div>
            </Router>
        </div>

        )
    }
}
ReactDOM.render(<App />, document.getElementById('root'));
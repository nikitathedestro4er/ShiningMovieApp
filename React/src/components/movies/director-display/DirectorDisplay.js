import React from "react";
import PropTypes from "prop-types";
import "./DirectorDisplay.css";
import { Link } from "react-router-dom";



class DirectorDisplay extends React.Component{
  constructor(props){
    super(props)
  }
  




  render() {
    return (
            <div className="directordisplay">
                <h2>Director</h2>
                  <Link to={"/director/" + this.props.movie.director.slug}>
                    <img className="holderdirectorimage" src={this.props.movie.director.image}/>
                  </Link>
            </div>   
  );
  }
 
}


DirectorDisplay.propTypes = {
  movie: PropTypes.object,
};




export default DirectorDisplay;
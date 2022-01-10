import React from "react";
import PropTypes from "prop-types";
import Spinner from "../common/spinner/Spinner";



class DirectorDisplay extends React.Component{
  constructor(props){
    super(props)
  }

  render() {
    return (
    <>
      {this.props.director.name === undefined  ? (
      <Spinner />
      ) : (
      <>
          <main className="container">
          <div className="left-column">
            <img src={this.props.director.image} className="left-column-img" />
          </div>

          <div className="right-column">
            <div className="movie-description">
              <h1>{this.props.director.name}</h1>
              <p>
                {this.props.director.description}
              </p>
            </div>

            
          </div>
        </main>
      </>
    )}
    </> 
  );
  }
 
}


DirectorDisplay.propTypes = {
  director: PropTypes.object,
};




export default DirectorDisplay;

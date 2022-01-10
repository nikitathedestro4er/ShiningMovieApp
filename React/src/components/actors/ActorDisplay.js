import React from "react";
import PropTypes from "prop-types";
import Spinner from "../common/spinner/Spinner";



class ActorDisplay extends React.Component{
  constructor(props){
    super(props)
  }

  render() {
    return (
    <>
      {this.props.actor.name === undefined  ? (
      <Spinner />
      ) : (
      <>
          <main className="container">
          <div className="left-column">
            <img src={this.props.actor.image} className="left-column-img" />
          </div>

          <div className="right-column">
            <div className="movie-description">
              <h1>{this.props.actor.name}</h1>
              <p>
                {this.props.actor.description}
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


ActorDisplay.propTypes = {
  actor: PropTypes.object,
};




export default ActorDisplay;

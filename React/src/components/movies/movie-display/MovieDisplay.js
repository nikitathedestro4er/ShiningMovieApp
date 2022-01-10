import React from "react";
import PropTypes from "prop-types";
import "./MovieDisplay.css";
import Spinner from "../../common/spinner/Spinner";




class MovieDisplay extends React.Component{
  constructor(props){
    super(props)
  }
  




  render() {
    return (
    <>
      {this.props.movie.name === undefined  ? (
      <Spinner />
      ) : (
      <>
          <main className="container">
          <div className="left-column">
            <img src={this.props.movie.image} className="left-column-img" />
          </div>

          <div className="right-column">
            <div className="movie-description">
              <h1>{this.props.movie.name}</h1>
              <p>
                {this.props.movie.description}
              </p>
            </div>

            <div className="movie-configuration">
              <div className="genre-label">
                <span>Genre</span>

                <div className="genre-name">
                  <button name="genreId" value={this.props.movie.genre.id} onClick={this.props.onClick}  className="btn btn-danger">
                    {this.props.movie.genre.name}
                  </button>
                </div>
              </div>
              <div className="director-label">
                <span>Director</span>

                <div className="director-name">
                  <button name="directorId" value={this.props.movie.director.id} onClick={this.props.onClick}  className="btn btn-danger">
                    {this.props.movie.director.name}
                  </button>
                </div>
            </div>

            <div className="rating-label">
              <span>Rating</span>

              <div className="rating-name">
                <button name="rating" onClick={this.props.onClick} className="btn btn-danger">
                  {this.props.movie.rating}
                </button>
              </div>
            </div>

            <div className="director-label">
                <span>Year</span>

                <div className="director-name">
                      <button name="maxYear" value={this.props.movie.year} onClick={this.props.onClick} className="btn btn-danger">
                        {this.props.movie.year}
                      </button>
                </div>
              </div>
              </div>
          </div>
        </main>
      </>
    )}
    </> 
  );
  }
 
}


MovieDisplay.propTypes = {
  movie: PropTypes.object,
  loadMovie: PropTypes.func,
  loading: PropTypes.bool,
  actions: PropTypes.any,
  id: PropTypes.number,
  onClick: PropTypes.func,
};




export default MovieDisplay;


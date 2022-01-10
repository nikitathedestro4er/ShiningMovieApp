import React from "react";
import PropTypes from "prop-types";
import Spinner from "../../common/spinner/Spinner";
import { Link } from "react-router-dom";
import "./RelatedMovies.css";


class RelatedMovies extends React.Component{
    constructor(props){
        super(props)
    }
    
  

    render() {
        return (
                <div className="movie">
                    <>
                        <h2>Related Movies</h2>
                        {this.props.movies === undefined ? (
                        <Spinner />
                        ) : (
                            <div className="flexmovie">
                            <>
                                {this.props.movies.map((movie) => {
                                    return (
                                        <div key={movie.id} className="holdermovie">
                                            <Link to={"/movie/" + movie.slug}>
                                                <img className="holderimagemovie" src={movie.image}/>
                                            </Link>
                                        </div>
                                    );
                                })}
                            </>
                            </div>
                            )}
                    </>  
                </div>

        );
    }

}

RelatedMovies.propTypes = {
  relatedMovies: PropTypes.array,
  movies: PropTypes.array,
  loading: PropTypes.bool,
  actions: PropTypes.any
};



export default RelatedMovies;
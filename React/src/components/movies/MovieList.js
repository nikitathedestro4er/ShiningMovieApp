/* eslint-disable */
import React from "react";
import PropTypes from "prop-types";
import { Link } from "react-router-dom";
import "./Movies.css";
import { connect } from "react-redux";
import { bindActionCreators } from "redux";
import * as movieActions from "../../redux/actions/movieActions";
import Spinner from "../common/spinner/Spinner";

class MoviesList extends React.Component {
  constructor(props) {
    super(props);
  }

  componentDidMount() {
    const { movies, actions } = this.props;

    if (movies.length === 0) {
    actions.loadMovies().catch((error) => {
      alert("Loading movies failed" + error);
      });
    }
  }




  render() {
    return (
      <>
        {this.props.loading ? (
          <Spinner />
        ) : (
          <div className="movieList">
          <div className="flexPosters">
              {this.props.movies.map((movie) => {
                return (
                  <div key={movie.id} className="flexMovie">
                      <Link to={"/movie/" + movie.slug}>
                        <img src={movie.image} className="Poster" />
                      </Link>
                  </div>
                );
              })}
              </div>
          </div>
        )}
      </>
    );
  }
}

MoviesList.propTypes = {
  movies: PropTypes.array.isRequired,
  actions: PropTypes.object.isRequired,
  loading: PropTypes.bool.isRequired,
};

function mapStateToProps(state) {
  return {
    movies: state.movies,
    loading: state.apiCallsInProgress > 0,
  };
}

function mapDispatchToProps(dispatch) {
  return {
    actions: {
      loadMovies: bindActionCreators(movieActions.loadMovies, dispatch),
    },
  };
}

export default connect(mapStateToProps, mapDispatchToProps)(MoviesList);
import React from "react";
import PropTypes from "prop-types";
import AdminMovieList from "./AdminMovieList";
import { Redirect } from "react-router-dom";
import AdminMoviesPagination from "./AdminMoviesPagination";
import AdminMoviesSearch from "../admin-movies/AdminMoviesSearch";

class AdminMoviesPage extends React.Component {
  state = {
    redirectToAddMoviePage: false,
  };



  

  render() {
    return (
      <>
        {this.state.redirectToAddMoviePage && <Redirect to="/edit/managemovie" />}
        <h2>Movies</h2>
          <>
            <button
              style={{ marginBottom: 20 }}
              className="btn btn-primary"
              onClick={() => this.setState({ redirectToAddMoviePage: true })}
            >
              Add Movie
            </button>

            <AdminMoviesSearch/>

            <AdminMovieList/>
            
            <AdminMoviesPagination/>
          </>
      </>
    );
  }
}

AdminMoviesPage.propTypes = {
  genres: PropTypes.array,
  directors: PropTypes.array,
  movies: PropTypes.array,
  actions: PropTypes.object,
  loading: PropTypes.bool,
};




export default AdminMoviesPage;

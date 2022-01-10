import React from "react";
import PropTypes from "prop-types";
import { Link } from "react-router-dom";
import * as movieActions from "../../redux/actions/movieActions";
import { connect } from "react-redux";
import { bindActionCreators } from "redux";
import Spinner from "../common/spinner/Spinner";
import { toast } from "react-toastify";
import "./AdminMovie.css";


class AdminMovieList extends React.Component{
  constructor(props) {
  super(props);
    this.props.actions.loadMovies();
}

  




  handleOrderby = (event) => {
    const { name } = event.target;
    const { pageSize, order} = this.props.pagination.movie;
    let sort = (order === name) ? (name + " desc") : name;
    let query={orderBy: sort,pageNumber: 1,pageSize: pageSize}  
    this.props.actions.loadMovies(query)
    .catch((error) => {
      alert("Loading movies failed" + error);
      });
  }

  handleDeleteMovie = (movie) => {
    toast.success("Movie deleted.");
    this.props.actions.deleteMovie(movie).catch((error) => {
      toast.error("Delete failed." + error.message, { autoClose: false });
    });
  };

  orderIcon(name){
    return (this.props.pagination.order === name) ? "▼" : "▲"
  }

  render() {
    return(
      <>
        {this.props.loading ? (
          <Spinner />
        ) : (
            <table className="table">
            <thead className="panel">

                  <tr>
                    <th className="firstRadius">
                      <button name="id" className="btn btn-primary" onClick={this.handleOrderby.bind(this)}>
                        ID{this.orderIcon("id")}
                      </button>
                    </th>
                    <th>
                      <button name="name" className="btn btn-primary" onClick={this.handleOrderby.bind(this)}>
                        Name{this.orderIcon("name")}
                      </button>
                    </th>
                    <th>
                      <button name="genre" className="btn btn-primary" onClick={this.handleOrderby.bind(this)}>
                        Genre{this.orderIcon("genre")}
                      </button>
                    </th>
                    <th>
                      <button name="director" className="btn btn-primary" onClick={this.handleOrderby.bind(this)}>
                        Director{this.orderIcon("director")}
                      </button>
                    </th>
                    <th>
                      <button name="year" className="btn btn-primary" onClick={this.handleOrderby.bind(this)}>
                        Year{this.orderIcon("year")}
                      </button>
                    </th>
                    <th>
                      <button name="rating" className="btn btn-primary" onClick={this.handleOrderby.bind(this)}>
                        Rating{this.orderIcon("rating")}
                      </button>
                    </th>
                    <th >
                      <button name="updated" className="btn btn-primary" onClick={this.handleOrderby}>
                        Updated{this.orderIcon("updated")}
                      </button>
                    </th>
                    <th className="lastRadius">
                    </th>
                  </tr>

            </thead>
            <tbody>
            {this.props.movies.map((movie) => {
              return (
                <tr key={movie.id}>
                  <td className="id">{movie.id}</td>
                  <td className="name">
                    <Link to={`managemovie/${movie.slug}`}>{movie.name}</Link>
                  </td>
                  <td className="genre">{movie.genre ? movie.genre.name : ""}</td>
                  <td className="director">{movie.director ? movie.director.name : ""}</td>
                  <td className="year">{movie.year}</td>
                  <td className="rating">{movie.rating}</td>
                  <td className="updated">{movie.modifiedDate}</td>
                  <td >
                    <button
                      className="btn btn-outline-danger delete"
                      onClick={() => this.handleDeleteMovie(movie)}
                    >
                      Delete
                    </button>
                  </td>
                </tr>
              );
            })}
          </tbody>
        </table>  
        )}
        </>
    );
  }
}


AdminMovieList.propTypes = {
  genres: PropTypes.array.isRequired,
  directors: PropTypes.array.isRequired,
  movies: PropTypes.array,
  actions: PropTypes.object.isRequired,
  pagination: PropTypes.object,
  loading: PropTypes.bool.isRequired,
  onDeleteClick: PropTypes.func,
};

function mapStateToProps(state) {
  return {
    movies: state.movies,
    genres: state.genres,
    directors: state.directors,
    loading: state.apiCallsInProgress > 0,
    pagination: state.pagination,
  };
}

function mapDispatchToProps(dispatch) {
  return {
    actions: {
      loadMovies: bindActionCreators(movieActions.loadMovies, dispatch),
      deleteMovie: bindActionCreators(movieActions.deleteMovie, dispatch),
    },
  };
}

export default connect(mapStateToProps, mapDispatchToProps)(AdminMovieList);


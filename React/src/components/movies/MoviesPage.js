import React from "react";
import MovieList from "./MovieList";
import MoviesPagination from "./MoviesPagination";
import MoviesFilter from "./MoviesFilter";
import "./MoviesPage.css"



class MoviesPage extends React.Component {
  constructor(props) {
    super(props);
  }


  render() {
    return (
      <div className="page">
      <MoviesFilter/>
      <MovieList/>
      <MoviesPagination/>
      </div>
    );
  }
}


export default (MoviesPage);

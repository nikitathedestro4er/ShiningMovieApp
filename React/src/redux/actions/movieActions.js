import * as types from "./actionTypes";
import * as movieApi from "../../api/movieApi";
import { beginApiCall, apiCallError } from "./apiStatusActions";
import { setMoviePagination } from "./pageActions";


export function loadMoviesSuccess(movies) {
  return { type: types.LOAD_MOVIES_SUCCESS, movies };
}

export function createMovieSuccess(movie) {
  return { type: types.CREATE_MOVIE_SUCCESS, movie };
}

export function updateMovieSuccess(movie) {
  return { type: types.UPDATE_MOVIE_SUCCESS, movie };
}

export function deleteMovieOptimistic(movie) {
  return { type: types.DELETE_MOVIE_OPTIMISTIC, movie };
}

export function loadMovies(query) {

  return (dispatch) => {
    dispatch(beginApiCall());
    return movieApi
      .getMovies(query)
      .then((response) => {
        dispatch(setMoviePagination(JSON.parse(response.headers["x-pagination"])));
        dispatch(loadMoviesSuccess(response.data));
      })
      .catch(() => {
        dispatch(apiCallError());
      })
  };
}


export function saveMovie(movie) {
  //eslint-disable-next-line no-unused-vars
  return function (dispatch) {
    dispatch(beginApiCall());
    return movieApi
      .saveMovie(movie)
      .then((response) => {
        movie.id
          ? dispatch(updateMovieSuccess(response.data))
          : dispatch(createMovieSuccess(response.data));
      })
      .catch((error) => {
        dispatch(apiCallError(error));
        throw error;
      });
  };
}

export function deleteMovie(movie) {
  return function (dispatch) {
    dispatch(deleteMovieOptimistic(movie));
    return movieApi.deleteMovie(movie.id);
  };
}

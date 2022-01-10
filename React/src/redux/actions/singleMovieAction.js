import * as types from "./actionTypes";
import * as movieApi from "../../api/movieApi";
import { beginApiCall, apiCallError } from "./apiStatusActions";



export function loadMovieSuccess(movie) {
  return { type: types.LOAD_MOVIE_SUCCESS, movie };
}

export function loadMovie(movieId) {
  return function (dispatch) {
    dispatch(beginApiCall());
    return movieApi
      .getMovie(movieId)
      .then((response) => {
        dispatch(loadMovieSuccess(response.data));
      })
      .catch((error) => {
        dispatch(apiCallError(error));
        throw error;
      });
  };
}

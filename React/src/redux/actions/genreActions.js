import * as types from "./actionTypes";
import * as genreApi from "../../api/genreApi";
import { beginApiCall, apiCallError } from "./apiStatusActions";

export function loadGenresSuccess(genres) {
  return { type: types.LOAD_GENRES_SUCCESS, genres };
}

export function loadGenres() {
  return function (dispatch) {
    dispatch(beginApiCall());
    return genreApi
      .getGenres()
      .then(({data}) => {
        dispatch(loadGenresSuccess(data));
      })
      .catch((error) => {
        dispatch(apiCallError(error));
        throw error;
      });
  };
}


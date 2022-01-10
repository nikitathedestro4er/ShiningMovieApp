import * as types from "./actionTypes";
import * as directorApi from "../../api/directorApi";
import { beginApiCall, apiCallError } from "./apiStatusActions";



export function loadDirectorSuccess(director) {
  return { type: types.LOAD_DIRECTOR_SUCCESS, director };
}

export function loadDirector(directorId) {
  return function (dispatch) {
    dispatch(beginApiCall());
    return directorApi
      .getDirector(directorId)
      .then((response) => {
        dispatch(loadDirectorSuccess(response.data));
      })
      .catch((error) => {
        dispatch(apiCallError(error));
        throw error;
      });
  };
}
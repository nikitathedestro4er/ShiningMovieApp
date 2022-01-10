import * as types from "./actionTypes";
import * as directorApi from "../../api/directorApi";
import { beginApiCall, apiCallError } from "./apiStatusActions";
import { setDirectorPagination } from "./pageActions";

export function loadDirectorsSuccess(directors) {
  return { type: types.LOAD_DIRECTORS_SUCCESS, directors };
}


export function createDirectorSuccess(director) {
  return { type: types.CREATE_DIRECTOR_SUCCESS, director };
}

export function updateDirectorSuccess(director) {
  return { type: types.UPDATE_DIRECTOR_SUCCESS, director };
}

export function deleteDirectorOptimistic(director) {
  return { type: types.DELETE_DIRECTOR_OPTIMISTIC, director };
}


export function loadDirectors(query) {
  return function (dispatch) {
    dispatch(beginApiCall());
    return directorApi
      .getDirectors(query)
      .then((response) => {
        dispatch(setDirectorPagination(JSON.parse(response.headers["x-pagination"])));
        dispatch(loadDirectorsSuccess(response.data));
      })
      .catch((error) => {
        dispatch(apiCallError(error));
        throw error;
      });
  };
}

export function saveDirector(director) {
  return function (dispatch) {
    dispatch(beginApiCall());
    return directorApi
      .saveDirector(director)
      .then((response) => {
        director.id
          ? dispatch(updateDirectorSuccess(response.data))
          : dispatch(createDirectorSuccess(response.data));
      })
      .catch((error) => {
        dispatch(apiCallError(error));
        throw error;
      });
  };
}

export function deleteDirector(director) {
  return function (dispatch) {
    dispatch(deleteDirectorOptimistic(director));
    return directorApi.deleteDirector(director.id);
  };
}
import * as types from "./actionTypes";
import * as actorApi from "../../api/actorApi";
import { beginApiCall, apiCallError } from "./apiStatusActions";
import { setActorPagination } from "./pageActions";

export function loadActorsSuccess(actors) {
  return { type: types.LOAD_ACTORS_SUCCESS, actors };
}

export function createActorSuccess(actor) {
  return { type: types.CREATE_ACTOR_SUCCESS, actor };
}

export function updateActorSuccess(actor) {
  return { type: types.UPDATE_ACTOR_SUCCESS, actor };
}

export function deleteActorOptimistic(actor) {
  return { type: types.DELETE_ACTOR_OPTIMISTIC, actor };
}

export function loadActors(query) {
  return function (dispatch) {
    dispatch(beginApiCall());
    return actorApi
      .getActors(query)
      .then((response) => {
          dispatch(setActorPagination(JSON.parse(response.headers["x-pagination"])));
          dispatch(loadActorsSuccess(response.data));
      })
      .catch((error) => {
        dispatch(apiCallError(error));
        throw error;
      });
  };
}


export function saveActor(actor) {
  return function (dispatch) {
    dispatch(beginApiCall());
    return actorApi
      .saveActor(actor)
      .then((response) => {
        actor.id
          ? dispatch(updateActorSuccess(response.data))
          : dispatch(createActorSuccess(response.data));
      })
      .catch((error) => {
        dispatch(apiCallError(error));
        throw error;
      });
  };
}

export function deleteActor(actor) {
  return function (dispatch) {
    dispatch(deleteActorOptimistic(actor));
    return actorApi.deleteActor(actor.id);
  };
}
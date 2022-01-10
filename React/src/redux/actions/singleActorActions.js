import * as types from "./actionTypes";
import * as actorApi from "../../api/actorApi";
import { beginApiCall, apiCallError } from "./apiStatusActions";


export function loadActorSuccess(actor) {
  return { type: types.LOAD_ACTOR_SUCCESS, actor };
}

export function loadActor(actorId) {
  return function (dispatch) {
    dispatch(beginApiCall());
    return actorApi
      .getActor(actorId)
      .then((response) => {
        dispatch(loadActorSuccess(response.data));
      })
      .catch((error) => {
        dispatch(apiCallError(error));
        throw error;
      });
  };
}
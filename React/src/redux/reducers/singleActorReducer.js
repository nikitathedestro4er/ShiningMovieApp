import * as types from "../actions/actionTypes";
import { createMovieSlug } from "../../helpers/slug";

export default function singleActorReducer(state = {}, action) {
  switch (action.type) {
    case types.LOAD_ACTOR_SUCCESS:
      action.actor.movies.map(x => {
        x.slug = createMovieSlug(x)
      });
      return action.actor;
    default:
      return state;
  }
}
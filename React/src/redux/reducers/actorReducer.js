import * as types from "../actions/actionTypes";
import { createActorSlug } from "../../helpers/slug";
import { formatDate } from "../../helpers/date";

export default function actorReducer(state = [], action) {
  switch (action.type) {
    case types.LOAD_ACTORS_SUCCESS:
      return action.actors.map(x => {
        x.slug = createActorSlug(x);
        x.birthday = formatDate(x.birthday);
        x.modifiedDate = formatDate(x.modifiedDate);
        return x
      });
    case types.CREATE_ACTOR_SUCCESS:
      return [...state, { ...action.actor }];
    case types.UPDATE_ACTOR_SUCCESS:
      return state.map((actor) =>
        actor.id === action.actor.id ? action.actor : actor
      );
    case types.DELETE_ACTOR_OPTIMISTIC:
      return state.filter((actor) => actor.id !== action.actor.id);
    default:
      return state;
  }
}

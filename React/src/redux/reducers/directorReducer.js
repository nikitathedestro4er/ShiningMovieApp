import * as types from "../actions/actionTypes";
import { createActorSlug } from "../../helpers/slug";
import { formatDate } from "../../helpers/date";

export default function directorReducer(state = [], action) {
  switch (action.type) {
    case types.LOAD_DIRECTORS_SUCCESS:
      return action.directors.map(x => {
        x.slug = createActorSlug(x);
        x.birthday = formatDate(x.birthday);
        x.modifiedDate = formatDate(x.modifiedDate);
        return x
      });
    case types.CREATE_DIRECTOR_SUCCESS:
      return [...state, { ...action.director }];
    case types.UPDATE_DIRECTOR_SUCCESS:
      return state.map((director) =>
        director.id === action.director.id ? action.director : director
      );
    case types.DELETE_DIRECTOR_OPTIMISTIC:
      return state.filter((director) => director.id !== action.director.id);
    default:
      return state;
  }
}

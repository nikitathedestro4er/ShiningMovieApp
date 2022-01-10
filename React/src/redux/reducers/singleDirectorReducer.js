import * as types from "../actions/actionTypes";
import { createMovieSlug } from "../../helpers/slug";

export default function singleDirectorReducer(state = {}, action) {
  switch (action.type) {
    case types.LOAD_DIRECTOR_SUCCESS:
      action.director.movies.map(x => {
        x.slug = createMovieSlug(x)
      });
      return action.director;
    default:
      return state;
  }
}
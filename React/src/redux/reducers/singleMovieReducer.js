import * as types from "../actions/actionTypes";
import { createActorSlug, createMovieSlug } from "../../helpers/slug";

export default function singleMovieReducer(state = {}, action) {
  switch (action.type) {
    case types.LOAD_MOVIE_SUCCESS:
        action.movie.relatedMovies.map(x => {
            x.slug = createMovieSlug(x);
          })
        action.movie.actors.map(x => {
            x.slug = createActorSlug(x);
          })
        action.movie.director.slug = createActorSlug(action.movie.director);
        return action.movie;
    default:
      return state;
  }
}
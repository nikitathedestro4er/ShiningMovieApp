import * as types from "../actions/actionTypes";
import { createMovieSlug } from "../../helpers/slug";
import { formatDate } from "../../helpers/date";


export default function movieReducer(state = [], action) {
  switch (action.type) {
    case types.CREATE_MOVIE_SUCCESS:
      return [...state, { ...action.movie }];
    case types.UPDATE_MOVIE_SUCCESS:
      return state.map((movie) =>
        movie.id === action.movie.id ? action.movie : movie
      );
    case types.LOAD_MOVIES_SUCCESS:
      return action.movies.map(x => {
        x.slug = createMovieSlug(x)
        x.modifiedDate = formatDate(x.modifiedDate);
        return x
      });
    case types.DELETE_MOVIE_OPTIMISTIC:
      return state.filter((movie) => movie.id !== action.movie.id);
    default:
      return state;
  }
}

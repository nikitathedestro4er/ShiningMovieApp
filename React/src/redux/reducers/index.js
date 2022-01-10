import { combineReducers } from "redux";
import movies from "./movieReducer";
import movie from "./singleMovieReducer";
import actor from "./singleActorReducer";
import genres from "./genreReducer";
import directors from "./directorReducer";
import director from "./singleDirectorReducer";
import actors from "./actorReducer";
import customer from "./singleCustomerReducer";
import customers from "./customerReducer";
import comments from "./commentReducer";
import auth from "./authReducer";
import message from "./messageReducer";
import apiCallsInProgress from "./apiStatusReducer";
import pagination from "./pageReducer";


const rootReducer = combineReducers({
  movies,
  customer,
  customers,
  movie,
  genres,
  directors,
  director,
  actors,
  actor,
  comments,
  auth,
  message,
  apiCallsInProgress,
  pagination,
});

export default rootReducer;

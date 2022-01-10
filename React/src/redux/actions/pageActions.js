import * as types from "./actionTypes";

export const setMoviePagination = (data) => ({
  type: types.SET_MOVIE_PAGINATION,
  payload: data,
});

export const setDirectorPagination = (data) => ({
  type: types.SET_DIRECTOR_PAGINATION,
  payload: data,
});

export const setActorPagination = (data) => ({
  type: types.SET_ACTOR_PAGINATION,
  payload: data,
});
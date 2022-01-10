import * as types from "../actions/actionTypes";

const defaultState = {
    movie: {
      currentPage:1,
      pageSize:9,
      totalCount:0,
      totalPages: 0,
      order: "name"
    },
    director: {
      currentPage:1,
      pageSize:9,
      totalCount:0,
      totalPages: 0,
      order: "name"
    },
    actor: {
      currentPage:1,
      pageSize:9,
      totalCount:0,
      totalPages: 0,
      order: "name"
    }
}

export default function pageReducer(state = defaultState, action) {
  switch (action.type) {
    case types.SET_MOVIE_PAGINATION:
            return {
              ...state,
              movie : {
                currentPage: action.payload.CurrentPage,
                pageSize: action.payload.PageSize,
                totalCount: action.payload.TotalCount,
                totalPages: Math.ceil(action.payload.TotalPages),
                order: action.payload.Order
              }
            }
    case types.SET_DIRECTOR_PAGINATION:
            return {
              ...state,
              director : {
                currentPage: action.payload.CurrentPage,
                pageSize: action.payload.PageSize,
                totalCount: action.payload.TotalCount,
                totalPages: Math.ceil(action.payload.TotalPages),
                order: action.payload.Order
              }
            }
    case types.SET_ACTOR_PAGINATION:
            return {
              ...state,
              actor : {
                currentPage: action.payload.CurrentPage,
                pageSize: action.payload.PageSize,
                totalCount: action.payload.TotalCount,
                totalPages: Math.ceil(action.payload.TotalPages),
                order: action.payload.Order
              }
            }  
        default:
            return state
  }
}
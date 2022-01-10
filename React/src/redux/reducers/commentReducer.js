import * as types from "../actions/actionTypes";


export default function commentReducer(state = [], action) {
  switch (action.type) {
    case types.LOAD_COMMENTS_SUCCESS:
      return action.comments;
    case types.CREATE_COMMENT_SUCCESS:
      return [...state, { ...action.comment }];
    case types.UPDATE_COMMENT_SUCCESS:
      return state.map((comment) =>
        comment.id === action.comment.id ? action.comment : comment
      );
    case types.DELETE_COMMENT_OPTIMISTIC:
      return state.filter((comment) => comment.id !== action.comment);
    default:
      return state;
  }
}

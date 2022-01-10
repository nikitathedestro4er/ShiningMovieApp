import * as types from "./actionTypes";
import * as commentApi from "../../api/commentApi";
import { beginApiCall, apiCallError } from "./apiStatusActions";


export function loadCommentsSuccess(comments) {
  return { type: types.LOAD_COMMENTS_SUCCESS, comments };
}

export function createCommentSuccess(comment) {
  return { type: types.CREATE_COMMENT_SUCCESS, comment };
}

export function updateCommentSuccess(comment) {
  return { type: types.UPDATE_COMMENT_SUCCESS, comment };
}

export function deleteCommentOptimistic(comment) {
  return { type: types.DELETE_COMMENT_OPTIMISTIC, comment };
}



export function loadComments(movieId) {
  return function (dispatch) {
    dispatch(beginApiCall());
    return commentApi
      .getComments(movieId)
      .then(({data}) => {
        dispatch(loadCommentsSuccess(data));
      })
      .catch((error) => {
        dispatch(apiCallError(error));
        throw error;
      });
  };
}



export function saveComment(comment) {
  return function (dispatch) {
    dispatch(beginApiCall());
    return commentApi
      .saveComment(comment)
      .then((response) => {
        comment.id
          ? dispatch(updateCommentSuccess(comment))
          : dispatch(createCommentSuccess(response.data));
      })
      .catch((error) => {
        dispatch(apiCallError(error));
        throw error;
      });
  };
}

export function deleteComment(commentId) {
  return function (dispatch) {
    dispatch(deleteCommentOptimistic(commentId));
    return commentApi.deleteComment(commentId);
  };
}
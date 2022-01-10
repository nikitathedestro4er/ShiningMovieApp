import {  handleError } from "./apiUtils";
import {authorizedAxios} from "./interceptor";
const baseUrl = process.env.API_URL + "/comment/";


export function getComments(movieId) {
  return authorizedAxios.get(baseUrl + movieId).catch(handleError);
}

export function saveComment(comment) {
  return comment.id ?
  authorizedAxios.put(baseUrl + (comment.id), comment) :
  authorizedAxios.post(baseUrl, comment)
    .catch(handleError);
}



export function deleteComment(commentId) {
  return authorizedAxios.delete(baseUrl + (commentId))
    .catch(handleError);
}
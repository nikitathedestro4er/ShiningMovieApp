import {  handleError } from "./apiUtils";
import {authorizedAxios} from "./interceptor";
const baseUrl = process.env.API_URL + "/rating/";


export function saveRating(rating) {
  return authorizedAxios.post(baseUrl, rating).catch(handleError);
}


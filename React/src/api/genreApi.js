import axios from "axios";
import {  handleError } from "./apiUtils";
const baseUrl = process.env.API_URL + "/genre/";
import {authorizedAxios } from "./interceptor";

export function getGenres() {
  return axios.get(baseUrl).catch(handleError);
}

export function getGenre(genreId) {
  return axios.get(baseUrl + genreId)
    .catch(handleError);
}

export function saveGenre(genre) {

  var config = {
    headers: {
      'Content-Type': 'multipart/form-data'
    }
  };

  return genre.id ?
  authorizedAxios.put(baseUrl + (genre.id), genre, config) :
  authorizedAxios.post(baseUrl, genre, config)
    .catch(handleError);
}



export function deleteGenre(genreId) {
  return authorizedAxios.delete(baseUrl + (genreId))
    .catch(handleError);
}
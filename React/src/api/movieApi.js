import {  handleError } from "./apiUtils";
import {authorizedAxios, withCancellationToken } from "./interceptor";
import axios from "axios";
const baseUrl = process.env.API_URL + "/movie/";
const defaultQuery = {pageNumber:1, pageSize:9,orderBy: undefined, searchTerm: undefined, minYear: undefined, maxYear: undefined, directorId: undefined, genreId: undefined}

const getMoviesCreator = api => (query = defaultQuery) =>
    {
        let url = baseUrl + `?PageNumber=${query.pageNumber}&PageSize=${query.pageSize}`;
        if(query.orderBy !== undefined){
          url = url + `&Order=${query.orderBy}`;
        }
        if(query.searchTerm !== undefined){
          url = url + `&Search=${query.searchTerm}`;
        }
        if(query.minYear !== undefined){
          url = url + `&MinYear=${query.minYear}`;
        }
        if(query.maxYear !== undefined){
          url = url + `&MaxYear=${query.maxYear}`;
        }
        if(query.directorId !== undefined){
          url = url + `&DirectorId=${query.directorId}`;
        }
        if(query.genreId !== undefined){
          url = url + `&GenreId=${query.genreId}`;
        }

        return api.get(url)
            .catch(function (thrown) {
            if (axios.isCancel(thrown)) {
              console.log('Request canceled', thrown.message);
              throw thrown
            } else {
              handleError
            }
          });
      };

export const getMovies = getMoviesCreator(withCancellationToken())



export function getMovie(movieId) {
  return axios.get(baseUrl + movieId)
    .catch(handleError);
}

export function saveMovie(movie) {

  var formData = new FormData()
  
  formData.append("Name", movie.name)
  formData.append("GenreId", movie.genreId)
  formData.append("DirectorId", movie.directorId)
  formData.append("Year", movie.year)
  formData.append("Rating", (movie.rating.toString()).replace(".",","))
  formData.append("Image", movie.image)
  formData.append("File", movie.imageFile)
  formData.append("Description", movie.description)
  movie.actors.forEach((a, i) => {
      formData.append(`Actors[${i}].Id`, a.id)
      formData.append(`Actors[${i}].Name`, a.name)
    }
  );
  
  var config = {
    headers: {
      'Content-Type': 'multipart/form-data'
    }
  };

  return movie.id ?
  authorizedAxios.put(baseUrl + (movie.id), formData, config) :
  authorizedAxios.post(baseUrl, formData, config)
    .catch(handleError);
}



export function deleteMovie(movieId) {
  return authorizedAxios.delete(baseUrl + (movieId))
    .catch(handleError);
}

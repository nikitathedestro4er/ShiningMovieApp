import axios from "axios";
import {  handleError } from "./apiUtils";
import {authorizedAxios, withCancellationToken } from "./interceptor";
const baseUrl = process.env.API_URL + "/director/";
const defaultQuery = {pageNumber:1, pageSize:9,orderBy: undefined, searchTerm: undefined, }


export function getDirector(directorId) {
  return axios.get(baseUrl + directorId)
    .catch(handleError);
}



const getDirectorsCreator = api => (query = defaultQuery) =>
    {
        let url = baseUrl + `?PageNumber=${query.pageNumber}&PageSize=${query.pageSize}`;
        if(query.orderBy !== undefined){
          url = url + `&Order=${query.orderBy}`;
        }
        if(query.searchTerm !== undefined){
          url = url + `&Search=${query.searchTerm}`;
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

export const getDirectors = getDirectorsCreator(withCancellationToken())


export function saveDirector(director) {

  var formData = new FormData()
  
  formData.append("Name", director.name)
  formData.append("Birthday", director.birthday)
  formData.append("Rating", (director.rating.toString()).replace(".",","))
  formData.append("Image", director.image)
  formData.append("File", director.imageFile)
  formData.append("Description", director.description)
  
  var config = {
    headers: {
      'Content-Type': 'multipart/form-data'
    }
  };

  return director.id ?
  authorizedAxios.put(baseUrl + (director.id), formData, config) :
  authorizedAxios.post(baseUrl, formData, config)
    .catch(handleError);
}



export function deleteDirector(directorId) {
  return authorizedAxios.delete(baseUrl + (directorId))
    .catch(handleError);
}
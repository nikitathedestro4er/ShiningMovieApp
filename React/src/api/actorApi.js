import axios from "axios";
import {  handleError } from "./apiUtils";
import {authorizedAxios, withCancellationToken } from "./interceptor";
const baseUrl = process.env.API_URL + "/actor/";
const defaultQuery = {pageNumber:1, pageSize:9,orderBy: undefined, searchTerm: undefined, }

export function getActor(actorId) {
  return axios.get(baseUrl + actorId)
    .catch(handleError);
}


const getActorsCreator = api => (query = defaultQuery) =>
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

export const getActors = getActorsCreator(withCancellationToken())


export function saveActor(actor) {

  var formData = new FormData()
  
  formData.append("Name", actor.name)
  formData.append("Birthday", actor.birthday)
  formData.append("Rating", (actor.rating.toString()).replace(".",","))
  formData.append("Image", actor.image)
  formData.append("File", actor.imageFile)
  formData.append("Description", actor.description)
  
  var config = {
    headers: {
      'Content-Type': 'multipart/form-data'
    }
  };

  return actor.id ?
  authorizedAxios.put(baseUrl + (actor.id), formData, config) :
  authorizedAxios.post(baseUrl, formData, config)
    .catch(handleError);
}



export function deleteActor(actorId) {
  return authorizedAxios.delete(baseUrl + (actorId))
    .catch(handleError);
}

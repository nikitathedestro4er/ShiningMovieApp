import axios from "axios";
import {  handleError } from "./apiUtils";
import {authorizedAxios } from "./interceptor";
const baseUrl = process.env.API_URL + "/customer/";


export function getCustomer(customerId) {
  return authorizedAxios.get(baseUrl + customerId)
    .catch(handleError);
}

export function getCustomers() {
  return authorizedAxios.get(baseUrl ).catch(handleError);
}


export function saveCustomer(customer) {

  var formData = new FormData()
  
  formData.append("UserId", customer.userId)
  formData.append("Image", customer.image)
  formData.append("File", customer.imageFile)
  
  var config = {
    headers: {
      'Content-Type': 'multipart/form-data'
    }
  };

  return customer.id ?
  authorizedAxios.put(baseUrl + (customer.id), formData, config) :
  axios.post(baseUrl, formData, config)
    .catch(handleError);
}



export function deleteCustomer(customerId) {
  return authorizedAxios.delete(baseUrl + (customerId))
    .catch(handleError);
}

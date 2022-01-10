import axios from "axios";
import { handleError } from "./apiUtils";
import getTokens from "./getTokens";
const baseUrl = process.env.API_AUTH_URL + "/account/";



export function register(userName, email, password, confirmPassword) {
  let dto = {userName,email,password,confirmPassword}
  return axios.post(baseUrl + "registration", dto, {
    headers: {
      "content-type": "application/json",
    },
  })
    .catch(handleError);
}

export function login(userName, password) {
  let dto = {userName,password}
   return axios.post(baseUrl + "login", dto, {
      headers: { 
        "content-type": "application/json" 
      },
  })
    .catch(handleError);
}

export function changePassword(link, password){
  return axios.post(baseUrl + "changePassword/" + link, password, {
    headers: { 
        "content-type": "application/json" 
      },
  })
    .catch(handleError);
}

export function resetPassword(email){
  return axios.post(baseUrl + "resetpassword", email, {
    headers: { 
        "content-type": "application/json" 
      },
  })
    .catch(handleError);
}

export function refreshToken() {
  let dto = getTokens();
  return  axios.post(baseUrl + "refresh", dto, {
    headers: {
       "content-type": "application/json" 
  },
  })
  .catch(handleError);
}


export const logout = () => {
  localStorage.removeItem("user");
  localStorage.removeItem("refreshToken");
};



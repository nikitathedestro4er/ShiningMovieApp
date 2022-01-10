import axios from "axios";
import getTokens from "./getTokens";
import jwt_decode from "jwt-decode";

const refreshAxios = axios.create({
  baseURL:  process.env.API_AUTH_URL,
  headers: {
    "Content-Type": "application/json",
    "Authorization": "Bearer" + getTokens().token,
  },
});

export const authorizedAxios = axios.create({
  baseURL:  process.env.API_URL,
  headers: {
    "Content-Type": "application/json",
  },
});

authorizedAxios.interceptors.request.use(
  (config) => {
    const token = getTokens().token;
    if (token) {
      config.headers["Authorization"] = 'Bearer ' + token;  
    }
    return config;
  },
  (error) => {
    return Promise.reject(error);
  }
);

authorizedAxios.interceptors.response.use(
  (res) => {
    return res;
  },
  async (err) => {
    const originalConfig = err.config;

    if (originalConfig.url !== "/account/login" && err.response) {
      // Access Token was expired
      if (err.response.status === 401 && !originalConfig._retry) {
        originalConfig._retry = true;

        try {
          const rs = await refreshAxios.post("/account/refresh", getTokens());

          let decodedUser = jwt_decode(rs.data.token);
          let currentUser = { ...decodedUser, token: rs.data.token };
          localStorage.setItem("user", JSON.stringify(currentUser));
          localStorage.setItem("refreshToken", JSON.stringify(rs.data.refreshToken));

          return authorizedAxios(originalConfig);
        } catch (_error) {
          return Promise.reject(_error);
        }
      }
    }

    return Promise.reject(err);
  }
);

export function withCancellationToken(){
  
  let axiosWithCancellationToken = axios.create({
    baseURL:  process.env.API_URL,
    headers: {
      "Content-Type": "application/json",
    },
  });

  let cancellationTokenSource;

  axiosWithCancellationToken.interceptors.request.use(
    (config) => {
      
      if(cancellationTokenSource){
        cancellationTokenSource.cancel()
      }

      cancellationTokenSource = axios.CancelToken.source()

      return {...config, cancelToken: cancellationTokenSource.token};
    },
    (error) => {
      return Promise.reject(error);
    }
  );

  return axiosWithCancellationToken;
}
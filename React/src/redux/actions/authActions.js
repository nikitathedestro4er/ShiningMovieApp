import jwt_decode from "jwt-decode";
import * as types from "./actionTypes";
import * as authApi from "../../api/authApi";



export const register =
  (userName, email, password, confirmPassword) => (dispatch) => {
    return authApi.register(userName, email, password, confirmPassword).then(
      () => {
        dispatch({
          type: types.REGISTER_SUCCESS,
        });

        dispatch({
          type: types.SET_MESSAGE,
          payload: "Successfully Registered!",
        });
        return Promise.resolve();
      }
    ).catch((error) => {
      const message = error.message;
        

      dispatch({
        type: types.REGISTER_FAIL,
      });

      dispatch({
        type: types.SET_MESSAGE,
        payload: message,
      });

      return Promise.reject();
    })
  };

export const login = (userName, password) => (dispatch) => {
  return authApi.login(userName, password).then(
    ({data}) => {
      let decodedUser = jwt_decode(data.token);
      let currentUser = { ...decodedUser, token: data.token };
      localStorage.setItem("user", JSON.stringify(currentUser));
      localStorage.setItem("refreshToken", JSON.stringify(data.refreshToken));
      dispatch({
        type: types.LOGIN_SUCCESS,
        payload: { user: data },
      });

      return Promise.resolve();
    }
  ).catch((error) => {
      const message = error.message;

      dispatch({
        type: types.LOGIN_FAIL,
      });

      dispatch({
        type: types.SET_MESSAGE,
        payload: message,
      });

      return Promise.reject();
    })
};

export const refreshToken = () => (dispatch) => {
  return authApi.refreshToken().then(
    ({data}) => {
      let decodedUser = jwt_decode(data.token);
      let currentUser = { ...decodedUser, token: data.token };
      localStorage.setItem("user", JSON.stringify(currentUser));
      localStorage.setItem("refreshToken", JSON.stringify(data.refreshToken));
      dispatch({
        type: types.REFRESH_TOKEN,
        payload: { user: data },
      });

      return Promise.resolve();
    }
  ).catch((error) => {
      const message = error.errorMessage
        error.toString();
        console.log(message);

      return Promise.reject();
    })
};


export const changePassword =
  (link, password) => (dispatch) => {
    return authApi.changePassword(link, password).then(
      () => {

        dispatch({
          type: types.SET_MESSAGE,
          payload: "Password has been changed!",
        });
        return Promise.resolve();
      }
    )  
  };


export const resetPassword =
  (email) => (dispatch) => {
    return authApi.resetPassword(email).then(
      () => {

        dispatch({
          type: types.SET_MESSAGE,
          payload: "Your instructions has been sent to your Email!",
        });
        return Promise.resolve();
      }
    )  
  };


export const logout = () => (dispatch) => {
  authApi.logout();

  dispatch({
    type: types.LOGOUT,
  });
};

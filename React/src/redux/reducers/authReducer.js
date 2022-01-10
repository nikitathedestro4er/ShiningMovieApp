import * as types from "../actions/actionTypes";
// import initialState from "./initialState";

const user = JSON.parse(localStorage.getItem("user"));

const initialState = user
  ? { isLoggedIn: true, user }
  : { isLoggedIn: false, user: null };

export default function authReducer(state = initialState, action) {
  switch (action.type) {
    case types.REGISTER_SUCCESS:
      return {
        ...state,
        ...{isLoggedIn: false},
      };
    case types.REGISTER_FAIL:
      return {
        ...state,
        ...{isLoggedIn: false},
      };
    case types.LOGIN_SUCCESS:
      return {
        ...state,
        isLoggedIn: true, 
        user: action.payload.user,
      };
    case types.LOGIN_FAIL:
      return {
        ...state,
        ...{isLoggedIn: false}
      };
    case types.LOGOUT:
      return {
        ...state,
        ...{isLoggedIn: false}
      };
    case types.REFRESH_TOKEN:
      return {
        ...state,
        ...{isLoggedIn: true, ...action.payload.user}
      }  
    default:
      return state;
  }
}

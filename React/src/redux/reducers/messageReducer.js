import * as types from "../actions/actionTypes";
// import initialState from "./initialState";

export default function messageReducer(state = "", action) {
  switch (action.type) {
    case types.SET_MESSAGE:
      return { message: action.payload };
    case types.CLEAR_MESSAGE:
      return { message: "" };

    default:
      return state;
  }
}

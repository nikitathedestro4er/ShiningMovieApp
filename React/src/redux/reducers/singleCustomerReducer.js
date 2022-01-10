import * as types from "../actions/actionTypes";


export default function singleCustomerReducer(state = {}, action) {
  switch (action.type) {
    case types.LOAD_CUSTOMER_SUCCESS:
      return action.customer;
    default:
      return state;
  }
}
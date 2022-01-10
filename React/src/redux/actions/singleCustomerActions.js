import * as types from "./actionTypes";
import * as customerApi from "../../api/customerApi";
import { beginApiCall, apiCallError } from "./apiStatusActions";


export function loadCustomerSuccess(customer) {
  return { type: types.LOAD_CUSTOMER_SUCCESS, customer };
}

export function loadCustomer(customerId) {
  return function (dispatch) {
    dispatch(beginApiCall());
    return customerApi
      .getCustomer(customerId)
      .then((response) => {
        dispatch(loadCustomerSuccess(response.data));
      })
      .catch((error) => {
        dispatch(apiCallError(error));
        throw error;
      });
  };
}
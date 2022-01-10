import * as types from "./actionTypes";
import * as customerApi from "../../api/customerApi";
import { beginApiCall, apiCallError } from "./apiStatusActions";


export function loadCustomersSuccess(customers) {
  return { type: types.LOAD_CUSTOMERS_SUCCESS, customers };
}

export function createCustomerSuccess(customer) {
  return { type: types.CREATE_CUSTOMER_SUCCESS, customer };
}

export function updateCustomerSuccess(customer) {
  return { type: types.UPDATE_CUSTOMER_SUCCESS, customer };
}

export function deleteCustomerOptimistic(customer) {
  return { type: types.DELETE_CUSTOMER_OPTIMISTIC, customer };
}



export function loadCustomers() {
  return function (dispatch) {
    dispatch(beginApiCall());
    return customerApi
      .getCustomers()
      .then(({data}) => {
        dispatch(loadCustomersSuccess(data));
      })
      .catch((error) => {
        dispatch(apiCallError(error));
        throw error;
      });
  };
}



export function saveCustomer(customer) {
  return function (dispatch) {
    dispatch(beginApiCall());
    return customerApi
      .saveCustomer(customer)
      .then((response) => {
        customer.id
          ? dispatch(updateCustomerSuccess(customer))
          : dispatch(createCustomerSuccess(response.data));
      })
      .catch((error) => {
        dispatch(apiCallError(error));
        throw error;
      });
  };
}

export function deleteCustomer(customerId) {
  return function (dispatch) {
    dispatch(deleteCustomerOptimistic(customerId));
    return customerApi.deleteCustomer(customerId);
  };
}
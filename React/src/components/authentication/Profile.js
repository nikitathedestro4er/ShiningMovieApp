import React from "react";
import { Redirect } from "react-router-dom";
import { connect } from "react-redux";
import { bindActionCreators } from "redux";
import "./Authentication.css";
/*import * as authActions from "../../redux/actions/authActions";*/
import * as customerActions from "../../redux/actions/singleCustomerActions";
import PropTypes from "prop-types";
import Spinner from "../common/spinner/Spinner";

const email = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/emailaddress";
const name = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name";
const id = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier";


class Profile extends React.Component{
  state ={
    currentUser: JSON.parse(localStorage.getItem("user")),
    customer: this.props.customer,
  }


  componentDidMount(){
    if(this.state.currentUser[id]){
       this.props.actions.loadCustomer(this.state.currentUser[id])
       .then(()=>{
         this.setState({customer: this.props.customer}); 
        })  
    }   
  }

  


  render(){
    
    return(
      <>
      {!this.state.currentUser && <Redirect to="/login" />}
      {this.props.customer.userId === undefined ? (
        <Spinner/>
      ) : (
        <div className="container">
          <header className="jumbotron">
            <h3 className="profileP">
              <strong>Profile</strong> 
            </h3>
            <img
              src={this.state.customer.image}
              alt="profile-img"
              className="profile-img-card"
            />
          </header>
          <ul className="list">
            <li>
              <p className="profileP">
                <strong>Username:</strong> {this.state.currentUser[name]}
              </p>
            </li>
            <li>
              <p className="profileP">
                <strong>Email:</strong> {this.state.currentUser[email]}
              </p>
            </li>
          </ul>
        </div>
        )}
      </>  
    );
  }
}

Profile.propTypes = {
  actions: PropTypes.object,
  currentUser: PropTypes.object,
  user: PropTypes.object,
  customer: PropTypes.object,
};

function mapStateToProps(state) {
  return {
    customer: state.customer,
  };
}

function mapDispatchToProps(dispatch) {
  return {
    actions: {
      loadCustomer: bindActionCreators(customerActions.loadCustomer, dispatch),
    },
  };
}

export default connect(mapStateToProps, mapDispatchToProps)(Profile);
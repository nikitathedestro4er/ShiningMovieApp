/* eslint-disable */
import React from "react";
import { Redirect, NavLink } from "react-router-dom";
import Form from "react-validation/build/form";
import Input from "react-validation/build/input";
import CheckButton from "react-validation/build/button";
import "./Authentication.css";
import * as authActions from "../../redux/actions/authActions";
import { withRouter } from "react-router";
import { connect } from "react-redux";
import { bindActionCreators } from "redux";




const required = (value) => {
  if (!value) {
    return (
      <div className="alert alert-danger" role="alert">
        This field is required!
      </div>
    );
  }
};



class Login extends React.Component{
  constructor(props) {
    super(props);
    this.form = React.createRef();
    this.checkBtn = React.createRef();
    this.state = {
      userName: "",
      password: "",
      loading: false
    }
  }

  onChangeUserName = (e) => {
    const userName = e.target.value;
    this.setState({userName: userName});
  }; 

  onChangePassword = (e) => {
    const password = e.target.value;
    this.setState({password: password});
  };

  handleLogin = (e) => {
    e.preventDefault();

    this.setState({loading: true});

    this.form.current.validateAll();

    if (this.checkBtn.current.context._errors.length === 0) {
      this.props.actions.login(this.state.userName, this.state.password)
        .then(() => {
          this.props.history.push("/profile");
        })
        .catch((error) => {
          console.log(error)
          this.setState({loading:false});
        });
    } else {
      this.setState({loading: false});
    }
  };


  render() {
    return(
      <>
      {this.props.isLoggedIn && <Redirect to="/profile"/>}
      <div className="col-md-12">
        <div className="auth-card auth-card-container">
          <img
            src="https://memegenerator.net/img/images/300x300/11342175.jpg"
            alt="profile-img"
            className="profile-img-card"
          />

          <Form onSubmit={this.handleLogin} ref={this.form}>
            <div className="form-group">
              <label htmlFor="userName">Username</label>
              <Input
                type="text"
                className="form-control"
                name="userName"
                value={this.state.userName}
                onChange={this.onChangeUserName}
                validations={[required]}
              />
            </div>

            <div className="form-group">
              <div className="passwordDiv">
                <label htmlFor="password">Password</label>
                <NavLink to="/resetpassword" className="forgetPassword">Forget Password?</NavLink>
              </div>
              <Input
                type="password"
                className="form-control"
                name="password"
                value={this.state.password}
                onChange={this.onChangePassword}
                validations={[required]}
              />
            </div>

            <div className="form-group auth-btn">
              <button className="btn btn-danger btn-block" disabled={this.state.loading}>
                {this.state.loading && (
                  <span className="spinner-border spinner-border-sm"></span>
                )}
                <span>Login</span>
              </button>
            </div>

            <div className="registerLinkDiv">
              <p>No account?</p>
              <NavLink to="/register" className="registerLink">Create one!</NavLink>
            </div>

            {this.props.message.length > 0 && (
              <div className="form-group">
                <div className="alert alert-danger warning" role="alert">
                  {this.props.message}
                </div>
              </div>
            )}
            <CheckButton style={{ display: "none" }} ref={this.checkBtn} />
          </Form>
        </div>
      </div>
      </>
    );
  }

}


function mapStateToProps(state) {
  return {
    isLoggedIn: state.isLoggedIn,
    message: state.message
  };
}

function mapDispatchToProps(dispatch) {
  return {
    actions: {
      login: bindActionCreators(authActions.login, dispatch),
    },
  };
}

export default withRouter(connect(mapStateToProps, mapDispatchToProps)(Login));



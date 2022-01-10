import React from "react";
import Form from "react-validation/build/form";
import Input from "react-validation/build/input";
import CheckButton from "react-validation/build/button";
import { isEmail } from "validator";
import "./Authentication.css";
import * as authActions from "../../redux/actions/authActions";
import * as customerActions from "../../redux/actions/customerActions";
import { connect } from "react-redux";
import { bindActionCreators } from "redux";
import PropTypes from "prop-types";


const required = (value) => {
  if (!value) {
    return (
      <div className="alert alert-danger" role="alert">
        This field is required!
      </div>
    );
  }
};

const validEmail = (value) => {
  if (!isEmail(value)) {
    return (
      <div className="alert alert-danger" role="alert">
        This is not a valid email.
      </div>
    );
  }
};

const validUserName = (value) => {
  if (value.length < 3 || value.length > 20) {
    return (
      <div className="alert alert-danger" role="alert">
        This UserName must be between 3 and 20 characters.
      </div>
    );
  }
};

const validPassword = (value) => {
  if (value.length < 6 || value.length > 40) {
    return (
      <div className="alert alert-danger" role="alert">
        This password must be between 6 and 40 characters.
      </div>
    );
  }
};

const validConfirmPassword = (value) => {
  if (value != value) {
    return (
      <div className="alert alert-danger" role="alert">
        The password and confirmation password do not match..
      </div>
    );
  }
};


class Register extends React.Component{
  constructor(props) {
    super(props);
    this.form = React.createRef();
    this.checkBtn = React.createRef();
    this.state = {
      userName: "",
      password: "",
      confirmPassword: "",
      email: "",
      successful: false,
      uploadFile: false,
      image: "https://memegenerator.net/img/images/300x300/11342175.jpg",
      imageFile: ""
    }
  }

  openUploadingFile(){
    this.setState({uploadFile: true});
  }

  handleFileChange = this.handleFileChange.bind(this);

  handleFileChange(event) {
    if (event.target.files && event.target.files[0]) {
      let imageFile = event.target.files[0];
      const reader = new FileReader();
      reader.onload = x => {
        this.setState({imageFile: imageFile});
        this.setState({image: x.target.result});

      }
      reader.readAsDataURL(imageFile)
    }
    else {
      return;
    }
  }

  onChangeUserName = (e) => {
    const userName = e.target.value;
    this.setState({userName: userName});
  };

  onChangeEmail = (e) => {
    const email = e.target.value;
    this.setState({email: email});
  };

  onChangePassword = (e) => {
    const password = e.target.value;
    this.setState({password: password});
  };

  onChangeConfirmPassword = (e) => {
    const confirmPassword = e.target.value;
    this.setState({confirmPassword: confirmPassword});
  };

  handleRegister = (e) => {
    e.preventDefault();

    this.setState({successful: true})

    this.form.current.validateAll();


    if (this.checkBtn.current.context._errors.length === 0) {
      const {userName, email, password, confirmPassword} = this.state;
      this.props.actions.register(userName, email, password, confirmPassword)
        .then(() => {
          this.setState({successful: true});
          this.props.actions.login(userName, password).then(() => {
            const userId = (JSON.parse(localStorage.getItem("user")))["http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier"];
            this.props.actions.saveCustomer({userId: userId, imageFile: this.state.imageFile})
          });
        })
        .catch((error) => {
          console.log(error)
          this.setState({successful: false})
        });
    } 
 }

 render() {
   return (
      <div className="col-md-12">
        <div className="auth-card auth-card-container">
          <div>
            <label htmlFor="register-file-input">
              <img
                src={this.state.image}
                alt="profile-img"
                className="profile-img-card"
              />
            </label>
            <input id="register-file-input" className="imageRegister" type="file" accept="image/*"  onChange={this.handleFileChange}/>
          </div>

          <Form onSubmit={this.handleRegister} ref={this.form}>
            {!this.state.successful && (
              <div>
                <div className="form-group">
                  <label htmlFor="userName">Username</label>
                  <Input
                    type="text"
                    className="form-control"
                    name="userName"
                    value={this.state.userName}
                    onChange={this.onChangeUserName}
                    validations={[required, validUserName]}
                  />
                </div>

                <div className="form-group">
                  <label htmlFor="email">Email</label>
                  <Input
                    type="text"
                    className="form-control"
                    name="email"
                    value={this.state.email}
                    onChange={this.onChangeEmail}
                    validations={[required, validEmail]}
                  />
                </div>

                <div className="form-group">
                  <label htmlFor="password">Password</label>
                  <Input
                    type="text"
                    className="form-control"
                    name="password"
                    value={this.state.password}
                    onChange={this.onChangePassword}
                    validations={[required, validPassword]}
                  />
                </div>

                <div className="form-group">
                  <label htmlFor="confirmPassword">Confirmation Password</label>
                  <Input
                    type="text"
                    className="form-control"
                    name="confirmPassword"
                    value={this.state.confirmPassword}
                    onChange={this.onChangeConfirmPassword}
                    validations={[required, validConfirmPassword]}
                  />
                </div>

                <div className="form-group auth-btn">
                  <button className="btn btn-danger btn-block">Sign Up</button>
                </div>
              </div>
            )}

            {this.props.message.length > 0 && (
              <div className="form-group">
                <div
                  className={
                    this.state.successful ? "alert alert-succes warning" : "alert alert-danger warning"
                  }
                  role="alert"
                >
                  {this.props.message}
                </div>
              </div>
            )}
            <CheckButton style={{ display: "none" }} ref={this.checkBtn} />
          </Form>
        </div>
      </div>
   );
 }
 
}


Register.propTypes = {
  actions: PropTypes.object,
  message: PropTypes.string
};


function mapStateToProps(state) {
  return {
    message: state.message
  };
}

function mapDispatchToProps(dispatch) {
  return {
    actions: {
      login: bindActionCreators(authActions.login, dispatch),
      register: bindActionCreators(authActions.register, dispatch),
      saveCustomer: bindActionCreators(customerActions.saveCustomer, dispatch),
    },
  };
}

export default connect(mapStateToProps, mapDispatchToProps)(Register);



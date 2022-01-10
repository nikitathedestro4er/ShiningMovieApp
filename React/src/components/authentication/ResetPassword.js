import React from "react";
import {resetPassword, changePassword} from "../../redux/actions/authActions";
import { connect } from "react-redux";
import { bindActionCreators } from "redux";
import "./Authentication.css";
import PropTypes from "prop-types";
import { withRouter } from "react-router";




class ResetPassword extends React.Component{
    state = {
        link: "",
        email: "",
        password: "",
        confirmationPassword: "",
        changePassword: false,
        showPasswordMessage: false,
        showMessage: false
    }

    componentDidMount(){
        if(this.props.link !== null){
            this.setState({link: this.props.link})
            this.setState({changePassword: true})
        }
    }


    handlePasswordChange = this.handlePasswordChange.bind(this);

    handleConfirmationPasswordChange = this.handleConfirmationPasswordChange.bind(this);

    handlePasswordSubmit = this.handlePasswordSubmit.bind(this);

    handleEmailChange = this.handleEmailChange.bind(this);

    handleEmailSubmit = this.handleEmailSubmit.bind(this);

    handleEmailChange(event) {
        const {  value } = event.target;
        this.setState({email: value})
    }

    handleEmailSubmit(){
        this.setState({showMessage: true});
        this.props.actions.resetPassword(this.state.email);      
    }

    handlePasswordChange(event){
        const {  value } = event.target;
        this.setState({password: value})
    }

    handleConfirmationPasswordChange(event){
        const {  value } = event.target;
        this.setState({confirmationPassword: value})
    }

    handlePasswordSubmit(){
        if(this.state.password === this.state.confirmationPassword){
            this.props.actions.changePassword(this.state.link, this.state.password);
            this.setState({showPasswordMessage: true});
        }
        
        
    }

    render() {
        return (
            <>
            {this.state.changePassword ? (
                <>
                    <div className="col-md-12">
                        <div className="auth-card auth-card-container">
                            {this.state.showPasswordMessage ? (
                                <p>Password has been changed!</p>
                            ) : (
                                <>
                                <div className="form-group">
                                    <label htmlFor="userName">Password</label>
                                    <input
                                    type="text"
                                    className="form-control"
                                    name="userName"
                                    value={this.state.password}
                                    onChange={this.handlePasswordChange}
                                    />
                                </div>


                                <div className="form-group">
                                        <label htmlFor="userName">Confirmation Password</label>
                                        <input
                                        type="text"
                                        className="form-control"
                                        name="userName"
                                        value={this.state.confirmationPassword}
                                        onChange={this.handleConfirmationPasswordChange}
                                        />
                                </div>


                                <div className="form-group auth-btn">
                                    <button onClick={this.handlePasswordSubmit} className="btn btn-danger btn-block" >
                                        Confirm
                                    </button>
                                </div>
                                </>
                            )}
                        </div>
                    </div>
                </>   
            ) : (
                <>
                    <div className="col-md-12">
                    <div className="auth-card auth-card-container">

                        {this.state.showMessage ? (
                            <p>Instructions has been sent to Email!</p>
                        ) : (
                            <>
                                <div className="form-group">
                                    <label htmlFor="userName">Your Email</label>
                                    <input
                                    type="text"
                                    className="form-control"
                                    name="userName"
                                    value={this.state.email}
                                    onChange={this.handleEmailChange}
                                    />
                                </div>


                                <div className="form-group auth-btn">
                                    <button onClick={this.handleEmailSubmit} className="btn btn-danger btn-block" >
                                        Send
                                    </button>
                                </div>

                            </>
                        )}
                    </div>
                    </div>
                </>   
            )}
            </>              
        );
    }
}

ResetPassword.propTypes = {
  showMessage: PropTypes.bool,
  showPasswordMessage: PropTypes.bool,
  actions: PropTypes.object,
  currentUser: PropTypes.object,
  user: PropTypes.object,
  customer: PropTypes.object,
  message: PropTypes.object,
  link: PropTypes.object
};


function mapStateToProps(state, ownProps) {
  const link = ownProps.match.params.link ? "?" + ownProps.match.params.link : null;  
  return {
    message: state.message,
    link
  };
}

function mapDispatchToProps(dispatch) {
  return {
    actions: {
      resetPassword: bindActionCreators(resetPassword, dispatch),
      changePassword: bindActionCreators(changePassword, dispatch)
    },
  };
}

export default withRouter(connect(mapStateToProps, mapDispatchToProps)(ResetPassword));
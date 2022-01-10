import React from "react";
import { connect } from "react-redux";
import { saveDirector } from "../../redux/actions/directorActions";
import { loadDirector } from "../../redux/actions/singleDirectorAction";
import PropTypes from "prop-types";
import AdminDirectorForm from "./AdminDirectorForm";
import newDirector from "./newDirector";
import Spinner from "../common/spinner/Spinner";
import { toast } from "react-toastify";
import { getIdBySlug } from "../../helpers/slug";
import { bindActionCreators } from "redux";
import { withRouter } from "react-router";
import { formatDate } from "../../helpers/date";






class AdminManageDirectorPage extends React.Component{
  constructor(props) {
    super(props);
    this.state = {
      errors: {},
      saving: false,
      director: this.props.director ? this.props.director : {}
    };
  }

  handleChange = this.handleChange.bind(this);
  handleDateChange = this.handleDateChange.bind(this);
  handleFileChange = this.handleFileChange.bind(this);
  handleSave = this.handleSave.bind(this);

  componentDidMount(){
    const {  id, actions } = this.props;

    if (id){
      actions.loadDirector(id).catch((error) => {
        alert("Loading director failed" + error);
      });
    }

  }


  componentDidUpdate(props){
    if(this.state.director.id != this.props.director.id){
      this.setState({director: {...props.director}})
    }
  }


  handleChange(event) {
    const { name, value } = event.target;
    this.setState(prevState => ({
    director: {                   
        ...prevState.director,    
        [name]: value       
    }
    }))
  }


  handleDateChange(date) {
    this.setState(prevState => ({
    director: {                   
        ...prevState.director,    
        ["birthday"]: formatDate(date)   
    }
    }))
  }


  handleFileChange(event) {
    if (event.target.files && event.target.files[0]) {
      let imageFile = event.target.files[0];
      const reader = new FileReader();
      reader.onload = x => {
        this.setState(prevState => ({
        director: {                   
        ...prevState.director,   
        imageFile: imageFile,
        image: x.target.result    
    }}))  
      }
      reader.readAsDataURL(imageFile)
    }
    else {
      return;
    }
  }


  formIsValid() {
    const { name, birthday, image, rating, description} = this.state.director;
    const errors = {};

    if (!name) errors.name = "Name is required.";
    if (!birthday) errors.year = "Birthday is required.";
    if (image === newDirector.image) errors.image = "Image is required.";
    if (!rating) errors.rating = "Rating is required.";
    if (!description) errors.description = "Rating is required.";

    this.setState({errors: errors});

    return Object.keys(errors).length === 0;
  }

  handleSave(event) {
    event.preventDefault();
    if (!this.formIsValid()) return;
    this.setState({saving: true})
    this.props.actions.saveDirector(this.state.director)
      .then(() => {
        toast.success("Director saved.");
        this.props.history.push("/edit/managedirectors");
      })
      .catch((error) => {
        this.setState({saving: false});
        this.setState(prevState => ({
        errors: {                   
        ...prevState.errors,   
        onSave: error.message,   
        }}));  
      });
  }

  
  render() {
    return (
    (this.state.director.id !== this.props.id)  ? (
    <Spinner />
  ) : (
    <AdminDirectorForm
      director={this.state.director}
      errors={this.state.errors}
      onChange={this.handleChange}
      onDateChange={this.handleDateChange}
      onFileChange={this.handleFileChange}
      onSave={this.handleSave}
      saving={this.state.saving}
    />
    ));
  }
}




AdminManageDirectorPage.propTypes = {
  director: PropTypes.object,
  actions: PropTypes.any,
  history: PropTypes.object,
  id: PropTypes.number,
  handleChange: PropTypes.func,
  handleFileChange: PropTypes.func,
  handleSave: PropTypes.func,
  formIsValid: PropTypes.func,
};



function mapStateToProps(state, ownProps) {
  const slug = ownProps.match.params.slug;
  const id = slug ? getIdBySlug(slug) : undefined;
  const director = slug ? state.director : newDirector;
  return {
    id,
    director,
  };
}


function mapDispatchToProps(dispatch) {
  return {
    actions: {
      loadDirector: bindActionCreators(loadDirector, dispatch),
      saveDirector: bindActionCreators(saveDirector, dispatch)
    },
  };
}

export default withRouter(connect(mapStateToProps,mapDispatchToProps)(AdminManageDirectorPage));

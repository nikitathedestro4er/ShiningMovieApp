import React from "react";
import { connect } from "react-redux";
import { saveActor } from "../../redux/actions/actorActions";
import { loadActor } from "../../redux/actions/singleActorActions";
import PropTypes from "prop-types";
import AdminActorForm from "./AdminActorForm";
import newActor from "./newActor";
import Spinner from "../common/spinner/Spinner";
import { toast } from "react-toastify";
import { getIdBySlug } from "../../helpers/slug";
import { formatDate } from "../../helpers/date";
import { bindActionCreators } from "redux";
import { withRouter } from "react-router";






class AdminManageActorPage extends React.Component{
  constructor(props) {
    super(props);
    this.state = {
      errors: {},
      saving: false,
      actor: this.props.actor ? this.props.actor : {}
    };
  }

  handleChange = this.handleChange.bind(this);
  handleDateChange = this.handleDateChange.bind(this);
  handleFileChange = this.handleFileChange.bind(this);
  handleSave = this.handleSave.bind(this);

  componentDidMount(){
    const {  id, actions} = this.props;

    if (id){
      actions.loadActor(id).catch((error) => {
        alert("Loading actor failed" + error);
      });
    }

  }


  componentDidUpdate(props){
    if(this.state.actor.id != this.props.actor.id){
      this.setState({actor: {...props.actor}})
    }
  }


  handleChange(event) {
    const { name, value } = event.target;
    this.setState(prevState => ({
    actor: {                   
        ...prevState.actor,    
        [name]: value       
    }
    }))
  }

  handleDateChange(date) {
    this.setState(prevState => ({
    actor: {                   
        ...prevState.actor,    
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
        actor: {                   
        ...prevState.actor,   
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
    const { name, birthday, image, rating, description} = this.state.actor;
    const errors = {};

    if (!name) errors.name = "Name is required.";
    if (!birthday) errors.year = "Birthday is required.";
    if (image === newActor.image) errors.image = "Image is required.";
    if (!rating) errors.rating = "Rating is required.";
    if (!description) errors.description = "Rating is required.";

    this.setState({errors: errors});

    return Object.keys(errors).length === 0;
  }

  handleSave(event) {
    event.preventDefault();
    if (!this.formIsValid()) return;
    this.setState({saving: true})
    this.props.actions.saveActor(this.state.actor)
      .then(() => {
        toast.success("Actor saved.");
        this.props.history.push("/edit/manageactors");
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
    (this.state.actor.id !== this.props.id)  ? (
    <Spinner />
  ) : (
    <AdminActorForm
      actor={this.state.actor}
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




AdminManageActorPage.propTypes = {
  actor: PropTypes.object,
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
  const actor = slug ? state.actor : newActor;
  return {
    id,
    actor,
  };
}


function mapDispatchToProps(dispatch) {
  return {
    actions: {
      loadActor: bindActionCreators(loadActor, dispatch),
      saveActor: bindActionCreators(saveActor, dispatch)
    },
  };
}

export default withRouter(connect(mapStateToProps,mapDispatchToProps)(AdminManageActorPage));

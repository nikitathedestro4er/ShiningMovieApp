import React from "react";
import "./Modal.css";
import PropTypes from "prop-types";
import AdminActorForm from "../../admin-actors/AdminActorForm";
import newActor from "../../admin-actors/newActor";
import { formatDate } from "../../../helpers/date";






class ModalActor extends React.Component{

    state = {
        errors: {},
        saving: false,
        actor: {
          name: this.props.actorName,
          rating: null,
          image: "",
          imageFile: null,
          birthday: null,
        }
    }


    
  componentDidUpdate(){
    if(this.state.actor.name != this.props.actorName){
      this.setState(prevState => ({
      actor: {                   
        ...prevState.actor,    
        ["name"]: this.props.actorName       
    }
    }))
    }
  }


  handleChange = this.handleChange.bind(this);
  handleDateChange = this.handleDateChange.bind(this);
  handleFileChange = this.handleFileChange.bind(this);
  handleSave = this.handleSave.bind(this);


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

  handleSave(event) {
    event.preventDefault();
    if (!this.formIsValid()) return;
    this.props.addActorToMovie(this.state.actor);
    this.setState({actor: newActor});
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

  

    render(){
        

        return(
            <>
            {this.props.show ? (
                <div className="modal" onClick={this.props.onClose}>
                <div className="modal-content" onClick={e => e.stopPropagation()}>
                    <div className="modal-body">
                        <AdminActorForm
                        actor={this.state.actor}
                        errors={this.state.errors}
                        onChange={this.handleChange}
                        onDateChange={this.handleDateChange}
                        onFileChange={this.handleFileChange}
                        onSave={this.handleSave}
                        saving={this.state.saving}
                        />
                    </div> 
                </div>
            </div>
            ) : null}   
            </>
        );
    }

}

ModalActor.propTypes = {
    show: PropTypes.bool.isRequired,
    onClose: PropTypes.func,
    actions: PropTypes.object,
    handleSave: PropTypes.func,
    actor: PropTypes.object,
    addActorToMovie: PropTypes.func,
    actorName: PropTypes.string,
};



export default (ModalActor);

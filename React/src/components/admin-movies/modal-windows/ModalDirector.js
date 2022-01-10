import React from "react";
import "./Modal.css";
import PropTypes from "prop-types";
import AdminDirectorForm from "../../admin-directors/AdminDirectorForm";
import newDirector from "../../admin-directors/newDirector";
import { formatDate } from "../../../helpers/date";






class ModalDirector extends React.Component{

    state = {
        errors: {},
        saving: false,
        director: {
          name: this.props.directorName,
          rating: null,
          image: "",
          imageFile: null,
          birthday: null,
        }
    }


    
  componentDidUpdate(){
    if(this.state.director.name != this.props.directorName){
      this.setState(prevState => ({
      director: {                   
        ...prevState.director,    
        ["name"]: this.props.directorName       
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

  handleSave(event) {
    event.preventDefault();
    if (!this.formIsValid()) return;
    this.props.addDirectorToMovie(this.state.director);
    this.setState({director: newDirector});
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

  

    render(){
        

        return(
            <>
            {this.props.show ? (
                <div className="modal" onClick={this.props.onClose}>
                <div className="modal-content" onClick={e => e.stopPropagation()}>
                    <div className="modal-body">
                        <AdminDirectorForm
                        director={this.state.director}
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

ModalDirector.propTypes = {
    show: PropTypes.bool.isRequired,
    onClose: PropTypes.func,
    actions: PropTypes.object,
    handleSave: PropTypes.func,
    addDirectorToMovie: PropTypes.func,
    directorName: PropTypes.string,
};



export default (ModalDirector);

import React from "react";
import { connect } from "react-redux";
import { saveMovie } from "../../redux/actions/movieActions";
import { loadMovie } from "../../redux/actions/singleMovieAction";
import { loadGenres } from "../../redux/actions/genreActions";
import { loadDirectors, saveDirector } from "../../redux/actions/directorActions";
import { loadActors, saveActor } from "../../redux/actions/actorActions";
import PropTypes from "prop-types";
import AdminMovieForm from "./AdminMovieForm";
import newMovie from "./newMovie";
import Spinner from "../common/spinner/Spinner";
import { toast } from "react-toastify";
import { getIdBySlug } from "../../helpers/slug";
import { bindActionCreators } from "redux";
import { withRouter } from "react-router";
import ModalDirector from "./modal-windows/ModalDirector";
import ModalActor from "./modal-windows/ModalActor";






class AdminManageMoviePage extends React.Component{
  constructor(props) {
    super(props);
    this.state = {
      errors: {},
      saving: false,
      movie: this.props.movie ? this.props.movie : {},
      showDirectorModal: false,
      showActorModal: false,
      newDirectorName: "",
      newActorName: "",
    };
  }

  handleChange = this.handleChange.bind(this);
  handleSelectChange = this.handleSelectChange.bind(this);
  handleMultipleSelectChange = this.handleMultipleSelectChange.bind(this);
  handleFileChange = this.handleFileChange.bind(this);
  handleSave = this.handleSave.bind(this);
  handleDirectorAdding = this.handleDirectorAdding.bind(this);
  handleActorAdding = this.handleActorAdding.bind(this);

  componentDidMount(){
    const {  id, actions } = this.props;

    if (id){
      actions.loadMovie(id).catch((error) => {
        alert("Loading movie failed" + error);
      });
    }

    actions.loadGenres().catch((error) => {
        alert("Loading genres failed" + error);
      });

    actions.loadDirectors({pageNumber:1, pageSize:50}).catch((error) => {
        alert("Loading directors failed" + error);
      });

    actions.loadActors({pageNumber:1, pageSize:50}).catch((error) => {
        alert("Loading actors failed" + error);
      });
  }


  componentDidUpdate(props){
    if(this.state.movie.id != this.props.movie.id){
      this.setState({movie: {...props.movie}})
    }
  }


  handleChange(event) {
    const { name, value } = event.target;
    this.setState(prevState => ({
    movie: {                   
        ...prevState.movie,    
        [name]: value       
    }
    }))
  }

  handleSelectChange(event) {
    // eslint-disable-next-line no-unused-vars
    const { name, value, label } = event;
    this.setState(prevState => ({
    movie: {                   
        ...prevState.movie,   
        [name]: value     
    }}));
  }

  handleMultipleSelectChange(event) {
    let actors = [];
    event.forEach(element => {
      actors.push({id: element.value, name: element.label});
    });
    this.setState(prevState => ({
    movie: {                   
        ...prevState.movie,   
        ["actors"]: actors     
    }}));        
  }


  handleFileChange(event) {
    if (event.target.files && event.target.files[0]) {
      let imageFile = event.target.files[0];
      const reader = new FileReader();
      reader.onload = x => {
        this.setState(prevState => ({
        movie: {                   
        ...prevState.movie,   
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

  handleDirectorAdding(director) {
    this.props.actions.saveDirector(director)
      .then(() => {
        this.setState({showDirectorModal: false})
        toast.success("New Director added.");
        director.id = this.props.directors.find(d=>d.name === director.name).id
        this.setState(prevState => ({
        movie: {                   
            ...prevState.movie,
            ["directorId"]: director.id     
        }}));
      })
      .catch((error) => {
        toast.error(error.message)
      });
    }

  handleActorAdding(actor) {
    this.props.actions.saveActor(actor)
      .then(() => {
        this.setState({showActorModal: false})
        toast.success("New Actor added.");
        actor.id = this.props.actors.find(d=>d.name === actor.name).id
        let actors = [{id: actor.id, name: actor.name}];
        if(this.state.movie.actors){
          this.state.movie.actors.forEach(element => {
          actors.push({id: element.id, name: element.name});
        });
        }
        this.setState(prevState => ({
        movie: {                   
            ...prevState.movie,   
            ["actors"]: actors     
        }}));
      })
      .catch((error) => {
        toast.error(error.message)
      });
    }

  handleSelectCreate = (inputValue) => {
      this.setState({newDirectorName: inputValue})
      this.setState({showDirectorModal: true})
      
    };

    handleMultipleSelectCreate = (inputValue) => {
      this.setState({newActorName: inputValue})
      this.setState({showActorModal: true})
    }

  formIsValid() {
    const { name, genreId, directorId,actors, year, image, rating, description} = this.state.movie;
    const errors = {};

    if (!name) errors.name = "Name is required.";
    if (!genreId) errors.genreId = "Genre is required.";
    if (!directorId) errors.directorId = "Director is required.";
    if (!actors) errors.actors = "Actors are required.";
    if (!year) errors.year = "Year is required.";
    if (image === newMovie.image) errors.image = "Image is required.";
    if (!rating) errors.rating = "Rating is required.";
    if (!description) errors.description = "Rating is required.";

    this.setState({errors: errors});

    return Object.keys(errors).length === 0;
  }

  handleSave(event) {
    event.preventDefault();
    if (!this.formIsValid()) return;
    this.setState({saving: true});
    this.props.actions.saveMovie(this.state.movie)
      .then(() => {
        toast.success("Movie saved.");
        this.props.history.push("/edit/managemovies");
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
    this.props.genres.length === 0 || this.props.actors.length === 0 || this.props.directors.length === 0 || (this.state.movie.id !== this.props.id)  ? (
    <Spinner />
  ) : (
    <>
    <ModalDirector 
     show={this.state.showDirectorModal}
     directorName={this.state.newDirectorName}
     addDirectorToMovie={this.handleDirectorAdding}
     onClose={() => this.setState({showDirectorModal: false})}/>
     <ModalActor 
     show={this.state.showActorModal}
     actorName={this.state.newActorName}
     addActorToMovie={this.handleActorAdding}
     onClose={() => this.setState({showActorModal: false})}/>
    <AdminMovieForm
      movie={this.state.movie}
      errors={this.state.errors}
      genres={this.props.genres}
      directors={this.props.directors}
      actors={this.props.actors}
      onChange={this.handleChange}
      onSelectChange={this.handleSelectChange}
      onSelectCreate={this.handleSelectCreate}
      onMultipleSelectChange={this.handleMultipleSelectChange}
      onMultipleSelectCreate={this.handleMultipleSelectCreate}
      onFileChange={this.handleFileChange}
      onSave={this.handleSave}
      saving={this.state.saving}
    />
    </>
    ));
  }
}




AdminManageMoviePage.propTypes = {
  movie: PropTypes.object,
  genres: PropTypes.array,
  movies: PropTypes.array,
  directors: PropTypes.array,
  actors: PropTypes.array,
  actions: PropTypes.any,
  history: PropTypes.object,
  id: PropTypes.number,
  handleChange: PropTypes.func,
  handleSelectChange: PropTypes.func,
  handleMultipleSelectChange: PropTypes.func,
  handleFileChange: PropTypes.func,
  handleSave: PropTypes.func,
  formIsValid: PropTypes.func,
};



function mapStateToProps(state, ownProps) {
  const slug = ownProps.match.params.slug;
  const id = slug ? getIdBySlug(slug) : undefined;
  const movie = slug ? state.movie : newMovie;
  return {
    id,
    movie,
    genres: state.genres,
    directors: state.directors,
    actors: state.actors,
  };
}


function mapDispatchToProps(dispatch) {
  return {
    actions: {
      loadMovie: bindActionCreators(loadMovie, dispatch),
      loadGenres: bindActionCreators(loadGenres, dispatch),
      loadDirectors: bindActionCreators(loadDirectors, dispatch),
      saveDirector: bindActionCreators(saveDirector, dispatch),
      loadActors: bindActionCreators(loadActors, dispatch),
      saveActor: bindActionCreators(saveActor, dispatch),
      saveMovie: bindActionCreators(saveMovie, dispatch)
    },
  };
}

export default withRouter(connect(mapStateToProps,mapDispatchToProps)(AdminManageMoviePage));

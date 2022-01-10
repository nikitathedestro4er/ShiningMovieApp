import React from "react";
import { connect } from "react-redux";
import * as singleMovieActions from "../../redux/actions/singleMovieAction";
import * as movieActions from "../../redux/actions/movieActions";
import * as singleCustomerActions from "../../redux/actions/singleCustomerActions";
import PropTypes from "prop-types";
import MovieDisplay from "./movie-display/MovieDisplay";
import Spinner from "../common/spinner/Spinner";
import { bindActionCreators } from "redux";
import DirectorDisplay from "./director-display/DirectorDisplay";
import ActorsList from "./actors-list/ActorsList";
import RelatedMovies from "./related-movies/RelatedMovies";
import { Redirect } from "react-router-dom";
import { withRouter } from "react-router";
import { getIdBySlug } from "../../helpers/slug";
import "./MoviePage.css";
import Comments from "../common/comments/Comments";
import Rating from "../common/rating/Rating";



class MoviePage extends React.Component {
  state = {
    redirectToMovieList: false
  };
  componentDidMount(){
    const { actions, id, userId} = this.props;

    actions.loadMovie(id).catch((error) => {
      alert("Loading movie failed" + error);
      });
   
    if(userId.length > 0){
      actions.loadCustomer(userId).catch((error) => {
      alert("Loading customer failed" + error);
    });
    }  
    

  }

  componentDidUpdate(){
    const { actions, id, movie } = this.props;

    if(movie.id !== id){
      actions.loadMovie(id).catch((error) => {
      alert("Loading movie failed" + error);
      });
    }
  }

  handleButtonClick = (event) => {
    const { name, value } = event.target;
    this.props.actions.loadMovies({[name]: value,pageNumber: 1,pageSize: 9})
    this.setState({ redirectToMovieList: true })
  };

  

  render() {
    return (
      <div className="moviepage">
          <>
        {this.state.redirectToMovieList && <Redirect to="/movies" />}
        {this.props.movie.id !== this.props.id || this.props.customer === {} ? (
        <Spinner />
        ) : (
        <>  
        <MovieDisplay movie={this.props.movie} onClick={this.handleButtonClick.bind(this)}/>
        <DirectorDisplay movie={this.props.movie} />
        <ActorsList className="relatedactors" movie={this.props.movie} />
        <RelatedMovies className="relatedmovies" movies={this.props.movie.relatedMovies} />
        <Rating movieId={this.props.movie.id} customerId={this.props.customer.id} rating={this.props.movie.rating}/>
        <Comments movieId={this.props.movie.id}/>
        </>
      )}
      </>
      </div>
    );
  }
}



MoviePage.propTypes = {
  movie: PropTypes.object,
  id: PropTypes.number.isRequired,
  loadMovie: PropTypes.func,
  actions: PropTypes.any,
  query: PropTypes.object,
  userId: PropTypes.number,
  movieId: PropTypes.number,
  customer: PropTypes.object
};



function mapStateToProps(state, ownProps) {
  const slug = ownProps.match.params.slug;
  const id = getIdBySlug(slug);
  const userId = localStorage.getItem("user") ? JSON.parse(localStorage.getItem("user"))["http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier"] : ""
  return {
    userId,
    id,
    movie: state.movie,
    customer: state.customer,
  };
}

function mapDispatchToProps(dispatch) {
  return {
    actions: {
      loadMovie: bindActionCreators(singleMovieActions.loadMovie, dispatch),
      loadMovies: bindActionCreators(movieActions.loadMovies, dispatch),
      loadCustomer: bindActionCreators(singleCustomerActions.loadCustomer, dispatch)
    },
  };
}

export default withRouter(connect(mapStateToProps, mapDispatchToProps)(MoviePage));

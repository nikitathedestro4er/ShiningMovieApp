import React from "react";
import RelatedMovies from "../movies/related-movies/RelatedMovies";
import { connect } from "react-redux";
import * as directorActions from "../../redux/actions/singleDirectorAction";
import PropTypes from "prop-types";
import Spinner from "../common/spinner/Spinner";
import { bindActionCreators } from "redux";
import DirectorDisplay from "./DirectorDisplay";
import { getIdBySlug } from "../../helpers/slug";
import { withRouter } from "react-router";



class DirectorPage extends React.Component{
    constructor(props){
        super(props)
    }

    
componentDidMount(){
    const { actions, id } = this.props;

    actions.loadDirector(id).catch((error) => {
      alert("Loading director failed" + error);
      });
  }
  
  
componentDidUpdate(){
    const { actions, id, director } = this.props;

    if(director.id !== id){
      actions.loadDirector(id).catch((error) => {
      alert("Loading director failed" + error);
      });
    }
  }

    render() {
        return (
            <>
            {this.props.director.id !== this.props.id ? (
            <Spinner />
            ) : (
            <>  
            <DirectorDisplay director={this.props.director} />
            <RelatedMovies movies={this.props.director.movies} />
            </>
            )}
            </>);
    }

}

DirectorPage.propTypes = {
  director: PropTypes.object,
  id: PropTypes.number.isRequired,
  loadDirector: PropTypes.func,
  actions: PropTypes.any,
};


function mapStateToProps(state, ownProps) {
  const slug = ownProps.match.params.slug;
  const id = getIdBySlug(slug)
  return {
    id,
    director: state.director,
  };
}

function mapDispatchToProps(dispatch) {
  return {
    actions: {
      loadDirector: bindActionCreators(directorActions.loadDirector, dispatch),
    },
  };
}

export default withRouter(connect(mapStateToProps, mapDispatchToProps)(DirectorPage));

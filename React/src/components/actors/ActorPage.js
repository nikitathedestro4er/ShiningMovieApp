import React from "react";
import RelatedMovies from "../movies/related-movies/RelatedMovies";
import { connect } from "react-redux";
import { bindActionCreators } from "redux";
import * as actorActions from "../../redux/actions/singleActorActions";
import PropTypes from "prop-types";
import Spinner from "../common/spinner/Spinner";
import ActorDisplay from "./ActorDisplay";
import { getIdBySlug } from "../../helpers/slug";
import { withRouter } from "react-router";



class ActorPage extends React.Component{
    constructor(props){
        super(props)
    }

    
  componentDidMount(){
      const { actions, id } = this.props;

      actions.loadActor(id).catch((error) => {
        alert("Loading movie failed" + error);
        });
    }
  
  componentDidUpdate(){
    const { actions, id, actor } = this.props;

    if(actor.id !== id){
      actions.loadActor(id).catch((error) => {
        alert("Loading actor failed" + error);
        });
    }
  }
  


    render() {
        return (
            <>
            {this.props.actor.id !== this.props.id ? (
            <Spinner />
            ) : (
            <>  
            <ActorDisplay actor={this.props.actor} />
            <RelatedMovies movies={this.props.actor.movies} />
            </>
            )}
            </>);
    }

}

ActorPage.propTypes = {
  actor: PropTypes.object,
  id: PropTypes.number.isRequired,
  loadActor: PropTypes.func,
  actions: PropTypes.any,
};


function mapStateToProps(state, ownProps) {
  const slug = ownProps.match.params.slug;
  const id = getIdBySlug(slug)
  return {
    id,
    actor: state.actor,
  };
}

function mapDispatchToProps(dispatch) {
  return {
    actions: {
      loadActor: bindActionCreators(actorActions.loadActor, dispatch),
    },
  };
}

export default withRouter(connect(mapStateToProps, mapDispatchToProps)(ActorPage));

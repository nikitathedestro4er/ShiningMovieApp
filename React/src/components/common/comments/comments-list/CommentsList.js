import React from "react";
import "./CommentsList.css";
import Comment from "../comment/Comment";
import * as commentActions from "../../../../redux/actions/commentActions";
import { connect } from "react-redux";
import { bindActionCreators } from "redux";
import PropTypes from "prop-types";
import Spinner from "../../spinner/Spinner";



class CommentsList extends React.Component{
    constructor(props){
        super(props)
        
        
    }

    componentDidMount(){
        const {movieId, actions} = this.props;

        actions.loadComments(movieId).catch((error) => {
      alert("Loading comments failed" + error);
      });
    }


   

    render(){
        return(
                <div className="commentsList">
                    {this.props.loading ? (
                        <Spinner/>
                    ) : (
                        <>
                       {this.props.comments.map((comment) => {
                        return (
                            <Comment 
                                key={comment.id} 
                                comment={comment}
                            />
                        );
                    })}
                    </> 
                    )}                    
                </div>
                );
    }
}

CommentsList.propTypes = {
  movieId: PropTypes.number,
  actions: PropTypes.object,
  loading: PropTypes.bool,
  comments: PropTypes.array,
};

function mapStateToProps(state) {
    const movieId = state.movie.id;
  return {
    comments: state.comments,
    loading: state.apiCallsInProgress > 0,
    movieId
  };
}

function mapDispatchToProps(dispatch) {
  return {
    actions: {
      loadComments: bindActionCreators(commentActions.loadComments, dispatch),
    },
  };
}

export default connect(mapStateToProps, mapDispatchToProps)(CommentsList);
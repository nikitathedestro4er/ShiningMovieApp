import React from "react";
import * as commentActions from "../../../redux/actions/commentActions";
import { connect } from "react-redux";
import { bindActionCreators } from "redux";
import PropTypes from "prop-types";
import "./Comments.css";
import CommentsList from "./comments-list/CommentsList";
import CommentInput from "./comment-input/CommentInput";



class Comments extends React.Component{
    constructor(props){
        super(props)
        this.state = {
            comment: {
                movieId: this.props.movieId,
                customerId: this.props.customer.id,
                userName: this.props.userName,
                content: "",
                likes: undefined,
                dislikes: undefined,
                replies: undefined,
                image: this.props.customer.image
            },
            
        }
    }





    handleChange = this.handleChange.bind(this);
    handleSubmit = this.handleSubmit.bind(this);
  

    handleChange(event) {
        const { value } = event.target;
        this.setState(prevState => ({
        comment: {                   
            ...prevState.comment,    
            content: value       
        }
    }))
  }

    handleSubmit(event) {
        if(this.state.comment.content.length > 3){            
            event.preventDefault();
            this.props.actions.saveComment(this.state.comment);
            this.setState(prevState => ({
            comment: {                   
                ...prevState.comment,    
                content: ""       
            }
        }))
        }
    }



    render(){
        return(
                <div className="commentArea">
                    <h2>Comments</h2>
                    <CommentInput 
                        comment={this.state.comment} 
                        showImage={true} 
                        handleChange={this.handleChange} 
                        handleSubmit={this.handleSubmit}
                        customer={this.props.customer}/>
                    <CommentsList />
                </div>
                );
    }
}

Comments.propTypes = {
  userName: PropTypes.string,
  comment: PropTypes.object,
  commentId: PropTypes.number,
  comments: PropTypes.array,
  movieId: PropTypes.number,
  actions: PropTypes.any,
  loading: PropTypes.bool,
  user: PropTypes.object,
  handleSubmit: PropTypes.func,
  handleChange: PropTypes.func,
  handleReplySubmit: PropTypes.func,
  handleReplyChange: PropTypes.func,
  customer: PropTypes.object
};

function mapStateToProps(state) {
  return {
    comments: state.comments,
    loading: state.apiCallsInProgress > 0,
    userName: state.auth.user ? state.auth.user["http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name"] : "",
    customer: state.customer ? state.customer : "",
  };
}

function mapDispatchToProps(dispatch) {
  return {
    actions: {
      loadComments: bindActionCreators(commentActions.loadComments, dispatch),
      saveComment: bindActionCreators(commentActions.saveComment, dispatch),
      deleteComment: bindActionCreators(commentActions.deleteComment,dispatch)
    },
  };
}

export default connect(mapStateToProps, mapDispatchToProps)(Comments);
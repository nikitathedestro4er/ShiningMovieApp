import React from "react";
import * as commentActions from "../../../../redux/actions/commentActions";
import { connect } from "react-redux";
import { bindActionCreators } from "redux";
import PropTypes from "prop-types";
import "./Comment.css";
import ReplyCommentsList from "../reply-comments-list/ReplyCommentsList";
import ReplyCommentInput from "../reply-comment-input/ReplyCommentInput";
import CommentInput from "../comment-input/CommentInput";
import { timeSince, formatDateWithTime} from "../../../../helpers/date";



class Comment extends React.Component{
    constructor(props){
        super(props)
        this.state = {
            customerId: "",
            comment: {
                id: "",
                movieId: "",
                customerId: "",
                userName: "",
                content: "",
                likes: "",
                dislikes: "",
                replies: [],
                image: ""
            },
            replyComment: {
                commentId: "",
                customerId: "",
                userName: "",
                content: "",
                likes: 0,
                dislikes: 0,
                creationTime: new Date()
            },
            showEdit: false,
            showReplyInput: false,
            showReplies: false,
        }
    }


   componentDidMount(){
       this.setState({customerId: this.props.customer.id})
       this.setState({comment: this.props.comment});
       this.setState(prevState => ({
        replyComment: {                   
            ...prevState.replyComment,    
            commentId: this.props.comment.id,
            customerId: this.props.comment.customerId,
            userName: this.props.comment.userName,       
            }
        }))
   }
   

   

   
   handleShowReplyInput = this.handleShowReplyInput.bind(this);
   handleShowReplies = this.handleShowReplies.bind(this);
   handleShowEdit = this.handleShowEdit.bind(this);
   handleLike = this.handleLike.bind(this);
   handleDislike = this.handleDislike.bind(this);



   handleShowEdit(){
       this.setState({showEdit: !this.state.showEdit});
   }

   handleShowReplyInput(){
       this.setState({showReplyInput: !this.state.showReplyInput});
   } 

   handleShowReplies(){
       this.setState({showReplies: !this.state.showReplies});
   }


   handleSubmit = this.handleSubmit.bind(this);
   handleChange = this.handleChange.bind(this);
   handleDelete = this.handleDelete.bind(this);
   handleReplyChange = this.handleReplyChange.bind(this);
   handleReplySubmit = this.handleReplySubmit.bind(this);
   handleReplyDelete = this.handleReplyDelete.bind(this);




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
        }
    }  


   handleDelete(){
       this.props.actions.deleteComment(this.state.comment.id);
   }


   handleLike(){
       console.log(this.state.comment);
        this.setState(prevState => ({
        comment: {                   
            ...prevState.comment,    
            likes: (this.state.comment.likes + 1)       
            }
        }), () => {
            this.props.actions.saveComment(this.state.comment);
        });
        
   }


   handleDislike(){
        this.setState(prevState => ({
        comment: {                   
            ...prevState.comment,    
            dislikes: this.state.comment.dislikes + 1       
        }
    }),() => {
        this.props.actions.saveComment(this.state.comment);
    });
   }


   handleReplyChange(event) {
        const { value } = event.target;
        this.setState(prevState => ({
        replyComment: {                   
            ...prevState.replyComment,    
            content: value       
        }
    }))
    }
   


   handleReplySubmit(event) {
        if(this.state.replyComment.content.length > 3){            
            event.preventDefault();           
            let replies = [this.state.replyComment];
            if(this.state.comment.replies){
                this.state.comment.replies.forEach(element => {
                replies.push(element);
                });
            }
            this.setState(prevState => ({
                comment: {                   
                    ...prevState.comment,    
                    ["replies"]: replies      
                }
            }),() => {
                this.props.actions.saveComment(this.state.comment);
            });
        }
    }
    
    
   handleReplyDelete(event){
       event.preventDefault();
       console.log(event.target.id);
       let replies = this.state.comment.replies.filter((reply) => reply.id !== parseInt(event.target.id));
       this.setState(prevState => ({
                comment: {                   
                    ...prevState.comment,    
                    ["replies"]: replies      
                }
            }),() => {
                this.props.actions.saveComment(this.state.comment);
            });
            
   }


    
   CommentDate(comment){
       if(formatDateWithTime(comment.modifiedDate) === formatDateWithTime(comment.creationTime)){
            return timeSince(comment.creationTime) + " " + "ago";
       }
       else{
           return timeSince(comment.modifiedDate) + " " + "ago (edited)";
       }
   }

    render(){
        return(
                <div className="comment" onClick={this.handleShowEdit}>
                    <div className="userImage">
                        <img className="userImageHolder" src={this.state.comment.image}/>
                    </div>
                    <div className="commentDiv">
                        {this.state.showEdit ? (
                            <CommentInput 
                                comment={this.state.comment} 
                                handleChange={this.handleChange} 
                                handleSubmit={this.handleSubmit}

                            />
                        ) : (
                            <div className="commentContent">
                            <div>
                                <div className="userNameAndDate">
                                    <div>
                                        <p className="userName">{this.props.comment.userName}</p>
                                    </div>
                                    <div>
                                        <p className="commentDate">{this.CommentDate(this.props.comment)}</p>
                                    </div>
                                </div>
                                <div className="commentContent">
                                    <p className="commentText">{this.props.comment.content}</p>
                                </div>
                                <div className="commentReaction" onClick={e => e.stopPropagation()}>
                                    <span className="likes" onClick={this.handleLike}>Likes:{this.props.comment.likes > 0 ? this.props.comment.likes : ""}</span>
                                    <span className="dislikes" onClick={this.handleDislike}>Dislikes:{this.props.comment.dislikes > 0 ? this.props.comment.dislikes : ""}</span>
                                    <span className="showReply" onClick={this.handleShowReplyInput}>REPLY</span>
                                </div>
                            </div>
                            {this.state.customerId === this.state.comment.customerId ? (
                                <div className="deleteAndEdit" onClick={e => e.stopPropagation()}>
                                <div>
                                    <span  onClick={this.handleShowEdit}>Edit</span>
                                </div>
                                <div>
                                    <span  onClick={this.handleDelete}>Delete</span>
                                </div>
                            </div> 
                            ) : (
                                ""
                            )}
                            </div>
                            
                        )}
                        <div onClick={e => e.stopPropagation()}>
                            {this.state.showReplyInput ? (
                                <ReplyCommentInput
                                    replyComment={this.state.replyComment}
                                    handleReplyChange={this.handleReplyChange}
                                    handleReplySubmit={this.handleReplySubmit}
                                    />
                            ) : ""}         
                        </div>
                        <div onClick={e => e.stopPropagation()}>
                            {this.props.comment.replies.length > 0 ? (
                                <span className="showReplies" onClick={this.handleShowReplies}>
                                    {this.state.showReplies ? "▲ Hide replies" : "▼ Show replies"}
                                </span>
                            ) : ""}
                            {this.state.showReplies ? (
                                <div className="replies">
                                    <ReplyCommentsList 
                                        replyComments={this.props.comment.replies}
                                        handleReplyDelete={this.handleReplyDelete}
                                        customerId = {this.state.customerId}/>
                                </div>
                            ) : ""}
                        </div>
                    </div>
                </div>
                );
    }
}

Comment.propTypes = {
  customer: PropTypes.object,
  actions: PropTypes.object,
  comment: PropTypes.object,
  editComment: PropTypes.object,
  userName: PropTypes.string,
  content: PropTypes.string,
  likes: PropTypes.number,
  dislikes: PropTypes.number,
  showEdit: PropTypes.bool,
  showReplies: PropTypes.bool,
  replyComment: PropTypes.object,
  handleDelete: PropTypes.func,
  handleSubmit: PropTypes.func,
  handleChange: PropTypes.func,
  handleOpenInput: PropTypes.func,
};

function mapStateToProps(state){
    return {
        customer: state.customer ? state.customer : ""
    }
}

function mapDispatchToProps(dispatch) {
  return {
    actions: {
      saveComment: bindActionCreators(commentActions.saveComment, dispatch),
      deleteComment: bindActionCreators(commentActions.deleteComment,dispatch),
      loadComments: bindActionCreators(commentActions.loadComments, dispatch),
    },
  };
}




export default connect(mapStateToProps, mapDispatchToProps)(Comment);
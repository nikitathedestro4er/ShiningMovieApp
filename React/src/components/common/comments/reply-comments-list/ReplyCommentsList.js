import React from "react";
import PropTypes from "prop-types";
import "./ReplyCommentsList.css";
import ReplyComment from "../reply-comment/ReplyComment";



class ReplyCommentsList extends React.Component{
    constructor(props){
        super(props)
        
    }

    

    render(){
        return(
                <div className="commentsList">
                    {this.props.replyComments.map((comment) => {
                        return (
                            <ReplyComment 
                                key={comment.id} 
                                comment={comment} 
                                handleReplyDelete={this.props.handleReplyDelete}
                                customerId = {this.props.customerId}
                                />
                        );
                    })}
                </div>
                );
    }
}

ReplyCommentsList.propTypes = {
  replyComments: PropTypes.array,
  replyComment: PropTypes.object,
  handleReplyDelete: PropTypes.func,
  customerId: PropTypes.number
};



export default ReplyCommentsList;
import React from "react";
import PropTypes from "prop-types";
import "./ReplyComment.css";
import { timeSince } from "../../../../helpers/date";




class ReplyComment extends React.Component{
    constructor(props){
        super(props)

    }



    render(){
        return(
                <div className="replyComment">
                    <div className="replyUserImage">
                        <img className="replyUserImageHolder" src="https://memegenerator.net/img/images/300x300/11342175.jpg"/>
                    </div>
                    <div className="commentDiv">
                        <div className="replyUserNameAndDate">
                            <div>
                                <p className="replyUserName">{this.props.comment.userName}</p>
                            </div>
                            <div>
                                <p className="commentDate">{timeSince(this.props.comment.creationTime)}</p>
                            </div>
                        </div>
                        <div className="replyCommentContent">
                            <p className="commentText">{this.props.comment.content}</p>
                        </div>
                    </div>
                    {this.props.customerId === this.props.comment.customerId ? (
                        <div className="replyDeleteAndEdit" onClick={e => e.stopPropagation()}>
                        <div>
                             <span id={this.props.comment.id} onClick={this.props.handleReplyDelete}>Delete</span>
                        </div>
                    </div>
                    ) : (
                        ""
                    )}
                </div>
                );
    }
}

ReplyComment.propTypes = {
  comment: PropTypes.object,
  userName: PropTypes.string,
  content: PropTypes.string,
  likes: PropTypes.number,
  dislikes: PropTypes.number,
  handleReplyDelete: PropTypes.func,
  customerId: PropTypes.number
};



export default ReplyComment;
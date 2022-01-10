import React from "react";
import PropTypes from "prop-types";
import "./ReplyCommentInput.css";




class ReplyCommentInput extends React.Component{
    constructor(props){
        super(props)
        
    }


    


    render(){
        return(
            <>
             <div className="replyUserImageAndInput">
                <div className="replyUserImage">
                    <img className="replyUserImageHolder" src="https://memegenerator.net/img/images/300x300/11342175.jpg"/>
                </div>
                <div className="replyInputArea">
                    <textarea
                        type=""
                        className="replyCommentInput"
                        onChange={this.props.handleReplyChange}
                        value={this.props.replyComment.content}
                        placeholder="Your opinion..."
                        />
                    <br/>   
                </div>
            </div>
            <button
                disabled={this.props.replyComment.content.length < 10}
                className="replyCommentSubmitBtn" 
                onClick={this.props.handleReplySubmit}>
                Submit
            </button>                                             
             </>                   
                );
    }
}

ReplyCommentInput.propTypes = {
  replyComment: PropTypes.object,
  handleReplyChange: PropTypes.func,
  handleReplySubmit: PropTypes.func
};


export default ReplyCommentInput;
import React from "react";
import PropTypes from "prop-types";
import "./CommentInput.css";




class CommentInput extends React.Component{
    constructor(props){
        super(props)
        
    }

    style(){
        return this.props.showImage ? { marginLeft: "910px" } : {};
    }

    
    render(){
        return(
            <>
                <div className="userImageAndInput">
                    {this.props.showImage ? (
                        <div className="userImage">
                            <img className="userImageHolder" src={this.props.customer.image}/>
                        </div>
                    ) : ""}                    
                    <div className="inputArea" onClick={e => e.stopPropagation()}>
                            <textarea
                                type="text"
                                className="commentInput"
                                onChange={this.props.handleChange}
                                value={this.props.comment.content}
                                placeholder="Your opinion..."
                            />
                        <br/>   
                    </div>    
                </div>
                <div className="commentSubmit" style={this.style()}>
                        <button                            
                            disabled={this.props.comment.content.length < 10}
                            className="commentSubmitBtn" 
                            onClick={this.props.handleSubmit}
                            >
                            Submit
                        </button>
                </div>
            </>      
                );
    }
}

CommentInput.propTypes = {
  comment: PropTypes.object,
  movieId: PropTypes.number,
  actions: PropTypes.any,
  loading: PropTypes.bool,
  user: PropTypes.object,
  handleSubmit: PropTypes.func,
  handleChange: PropTypes.func,
  showImage: PropTypes.bool,
  customer: PropTypes.object
};


export default CommentInput;

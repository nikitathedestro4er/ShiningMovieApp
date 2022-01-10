import React from "react";
import { saveRating } from "../../../api/ratingApi";
import ReactStars from "react-rating-stars-component";
import PropTypes from "prop-types";
import "./Rating.css";

class Rating extends React.Component{
    state = {
        rating: this.props.rating
    }


    handleChanged = this.handleChanged.bind(this);



    handleChanged(value){
        const rating = {movieId: this.props.movieId, customerId: this.props.customerId, rate: value};
        saveRating(rating);
    }



    render(){
        return (
            <>
            <h2>Rating</h2>
            <div className="ratingDiv">
                <ReactStars
                size={75}
                count={13}
                value={this.state.rating}
                onChange={this.handleChanged}
                activeColor="#ffd700"
            />
            <p className="ratingP">{this.state.rating}/13</p>
            </div>
            </>
        );
    }
}

Rating.propTypes = {
  rating: PropTypes.number, 
  movieId: PropTypes.number,
  customerId: PropTypes.number
};


export default Rating;

import React from "react";
import PropTypes from "prop-types";
import Spinner from "../../common/spinner/Spinner";
import { Link } from "react-router-dom";
import "./ActorList.css"


class ActorsList extends React.Component{
    constructor(props){
        super(props)
    }

    



    render() {
        return (
            <div className="actorlist">
                <>
                <h2>Actors</h2>
                {this.props.movie.name === undefined ? (
                <Spinner />
                  ) : (
                    <div className="flexactor">
                        <>
                        {this.props.movie.actors.map((actor) => {
                            return (
                                <div key={actor.id} className="holderactor">
                                    <Link to={"/actor/" + actor.slug}>
                                        <img className="holderimage" src={actor.image}/>
                                    </Link>
                                </div>
                            );
                        })}
                    </>
                    </div>
                    )}
                </>  
            </div>
        );
    }

}

ActorsList.propTypes = {
  movie: PropTypes.object,
  loadMovie: PropTypes.func,
  loading: PropTypes.bool,
  actions: PropTypes.any,
  id: PropTypes.number,
};






export default ActorsList;

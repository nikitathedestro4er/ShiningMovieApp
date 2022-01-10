import React from "react";
import PropTypes from "prop-types";
import { Link } from "react-router-dom";
import * as actorActions from "../../redux/actions/actorActions";
import { connect } from "react-redux";
import { bindActionCreators } from "redux";
import Spinner from "../common/spinner/Spinner";
import { toast } from "react-toastify";


class AdminActorList extends React.Component{


  componentDidMount() {
    this.props.actions.loadActors().catch((error) => {
      alert("Loading actors failed" + error);
      });
  }


  handleOrderby = (event) => {
    const { name } = event.target;
    const { pageSize, order} = this.props.pagination.actor;
    let sort = (order === name) ? (name + " desc") : name;
    let query={orderBy: sort,pageNumber: 1,pageSize: pageSize}  
    this.props.actions.loadActors(query)
    .catch((error) => {
      alert("Loading directors failed" + error);
      });
  }

  handleDeleteActor = (actor) => {
    toast.success("Actor deleted.");
    this.props.actions.deleteActor(actor).catch((error) => {
      toast.error("Delete failed." + error.message, { autoClose: false });
    });
  };

  orderIcon(name){
    return (this.props.pagination.order === name) ? "▼" : "▲"
  }
  

  render() {
    return(
         <>
        {this.props.loading ? (
          <Spinner />
        ) : (
            <table className="table">
            <thead className="panel">

                  <tr>
                    <th className="firstRadius">
                      <button name="id" className="btn btn-primary" onClick={this.handleOrderby.bind(this)}>
                        ID{this.orderIcon("id")}
                      </button>
                    </th>
                    <th>
                      <button name="name" className="btn btn-primary" onClick={this.handleOrderby.bind(this)}>
                        Name{this.orderIcon("name")}
                      </button>
                    </th>
                    <th>
                      <button name="birthday" className="btn btn-primary" onClick={this.handleOrderby.bind(this)}>
                        Birthday{this.orderIcon("birthday")}
                      </button>
                    </th>
                    <th>
                      <button name="rating" className="btn btn-primary" onClick={this.handleOrderby.bind(this)}>
                        Rating{this.orderIcon("rating")}
                      </button>
                    </th>
                     <th>
                      <button name="movies" className="btn btn-primary" onClick={this.handleOrderby.bind(this)}>
                        Movies{this.orderIcon("movies")}
                      </button>
                    </th>
                    <th >
                      <button name="updated" className="btn btn-primary" onClick={this.handleOrderby.bind(this)}>
                        Updated{this.orderIcon("updated")}
                      </button>
                    </th>
                    <th className="lastRadius">
                    </th>
                  </tr>

            </thead>
            <tbody>

            {this.props.actors.map((actor) => {
              return (
                <tr key={actor.id}>
                  <td className="id">{actor.id}</td>
                  <td className="name">
                    <Link to={`manageactor/${actor.slug}`}>{actor.name}</Link>
                  </td>
                  <td className="birthday">{actor.birthday}</td>
                  <td className="rating">{actor.rating}</td>
                  <td className="movies">{actor.movies ? actor.movies.map((movie)=>{
                    return (
                    <p key={movie.id}>{movie.name}</p>
                      );
                  }) : ""}
                  </td>
                  <td className="updated">{actor.modifiedDate}</td>
                  <td>
                    <button
                      className="btn btn-outline-danger"
                      onClick={() => this.handleDeleteActor(actor)}
                    >
                      Delete
                    </button>
                  </td>
                </tr>
              );
            })}
          </tbody>
        </table>  
        )}
        </>
    );
  }
}


AdminActorList.propTypes = {
  actors: PropTypes.array,
  actions: PropTypes.object,
  loading: PropTypes.bool,
  onDeleteClick: PropTypes.func,
  pagination: PropTypes.object,
};

function mapStateToProps(state) {
  return {
    actors: state.actors,
    loading: state.apiCallsInProgress > 0,
    pagination: state.pagination,
  };
}

function mapDispatchToProps(dispatch) {
  return {
    actions: {
      loadActors: bindActionCreators(actorActions.loadActors, dispatch),
      deleteActor: bindActionCreators(actorActions.deleteActor, dispatch),
    },
  };
}

export default connect(mapStateToProps, mapDispatchToProps)(AdminActorList);


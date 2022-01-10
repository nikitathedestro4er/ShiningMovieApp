import React from "react";
import PropTypes from "prop-types";
import { Link } from "react-router-dom";
import * as directorActions from "../../redux/actions/directorActions";
import { connect } from "react-redux";
import { bindActionCreators } from "redux";
import Spinner from "../common/spinner/Spinner";
import { toast } from "react-toastify";


class AdminDirectorList extends React.Component{


  componentDidMount() {
    this.props.actions.loadDirectors().catch((error) => {
      alert("Loading directors failed" + error);
      });
  }


  handleOrderby = (event) => {
    const { name } = event.target;
    const { pageSize, order} = this.props.pagination.director;
    let sort = (order === name) ? (name + " desc") : name;
    let query={orderBy: sort,pageNumber: 1,pageSize: pageSize}  
    this.props.actions.loadDirectors(query)
    .catch((error) => {
      alert("Loading directors failed" + error);
      });
  }

  handleDeleteDirector = (director) => {
    toast.success("Director deleted.");
    this.props.actions.deleteDirector(director).catch((error) => {
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

            {this.props.directors.map((director) => {
              return (
                <tr key={director.id}>
                  <td className="id">{director.id}</td>
                  <td className="name">
                    <Link to={`managedirector/${director.slug}`}>{director.name}</Link>
                  </td>
                  <td className="birthday">{director.birthday}</td>
                  <td className="rating">{director.rating}</td>
                  <td className="movies">{director.movies ? director.movies.map((movie)=>{
                    return (
                    <p key={movie.id}>{movie.name}</p>
                      );
                  }) : ""}
                  </td>
                  <td className="updated">{director.modifiedDate}</td>
                  <td>
                    <button
                      className="btn btn-outline-danger"
                      onClick={() => this.handleDeleteDirector(director)}
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


AdminDirectorList.propTypes = {
  directors: PropTypes.array,
  actions: PropTypes.object,
  loading: PropTypes.bool,
  onDeleteClick: PropTypes.func,
  pagination: PropTypes.object,
};

function mapStateToProps(state) {
  return {
    directors: state.directors,
    loading: state.apiCallsInProgress > 0,
    pagination: state.pagination,
  };
}

function mapDispatchToProps(dispatch) {
  return {
    actions: {
      loadDirectors: bindActionCreators(directorActions.loadDirectors, dispatch),
      deleteDirector: bindActionCreators(directorActions.deleteDirector, dispatch),
    },
  };
}

export default connect(mapStateToProps, mapDispatchToProps)(AdminDirectorList);


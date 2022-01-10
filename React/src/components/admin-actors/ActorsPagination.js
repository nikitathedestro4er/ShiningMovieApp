import React from "react";
import { connect } from "react-redux";
import { bindActionCreators } from "redux";
import * as actorActions from "../../redux/actions/actorActions";
import PropTypes from "prop-types";
import ReactPaginate from "react-paginate";
import "bootstrap/dist/css/bootstrap.min.css";

class ActorsPagination extends React.Component {
  constructor(props){
    super(props)
  }


  handlePageClick = (data) => {
    let query = {orderBy: this.props.pagination.actor.order,pageNumber: data.selected + 1,pageSize: 9}
    this.props.actions.loadActors(query)
  };

  render() {
    return (
      <ReactPaginate
            forcePage={this.props.pagination.actor.currentPage - 1}
            pageCount={this.props.pagination.actor.totalPages}
            marginPagesDisplayed={3}
            pageRangeDisplayed={6}
            previousLabel={"previous"}
            nextLabel={"next"}
            breakLabel={"..."}
            onPageChange={this.handlePageClick} 
            containerClassName={"pagination justify-content-center"}
            pageClassName={"page-item"}
            pageLinkClassName={"page-link"}
            previousClassName={"page-item"}
            previousLinkClassName={"page-link"}
            nextClassName={"page-item"}
            nextLinkClassName={"page-link"}
            breakClassName={"page-item"}
            breakLinkClassName={"page-link"}
            activeClassName={"active"}
            />
    );
  }
}

ActorsPagination.propTypes = {
  actions: PropTypes.object.isRequired,
  pagination: PropTypes.object.isRequired
};

function mapStateToProps(state) {
  return {
    pagination: state.pagination,
  };
}

function mapDispatchToProps(dispatch) {
  return {
    actions: {
      loadActors: bindActionCreators(actorActions.loadActors, dispatch),
    },
  };
}

export default connect(mapStateToProps, mapDispatchToProps)(ActorsPagination);

import React from "react";
import AdminDirectorList from "./AdminDirectorList";
import { Redirect } from "react-router-dom";
import DirectorsSearch from "./DirectorsSearch";
import DirectorsPagination from "./DirectorsPagination";


class AdminDirectorsPage extends React.Component {
  state = {
    redirectToAddDirectorPage: false,
  };



  

  render() {
    return (
      <>
        {this.state.redirectToAddDirectorPage && <Redirect to="/edit/managedirector" />}
        <h2>Directors</h2>
          <>
            <button
              style={{ marginBottom: 20 }}
              className="btn btn-primary add-course"
              onClick={() => this.setState({ redirectToAddDirectorPage: true })}
            >
              Add Director
            </button>

            <DirectorsSearch/>

            <AdminDirectorList/>

            <DirectorsPagination/>

          </>
      </>
    );
  }
}






export default AdminDirectorsPage;

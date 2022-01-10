import React from "react";
import AdminActorList from "./AdminActorList";
import { Redirect } from "react-router-dom";
import ActorsSearch from "./ActorsSearch";
import ActorsPagination from "./ActorsPagination";

class AdminActorsPage extends React.Component {
  state = {
    redirectToAddActorPage: false,
  };



  

  render() {
    return (
      <>
        {this.state.redirectToAddActorPage && <Redirect to="/edit/manageactor" />}
        <h2>Actors</h2>
          <>
            <button
              style={{ marginBottom: 20 }}
              className="btn btn-primary add-course"
              onClick={() => this.setState({ redirectToAddActorPage: true })}
            >
              Add Actor
            </button>

            <ActorsSearch/>

            <AdminActorList/>

            <ActorsPagination/>

          </>
      </>
    );
  }
}






export default AdminActorsPage;

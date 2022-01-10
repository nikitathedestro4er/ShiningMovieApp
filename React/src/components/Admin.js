import React from "react";
import { Route, Redirect, useRouteMatch, Switch } from "react-router-dom";
import PageNotFound from "./PageNotFound";
import AdminMoviesPage from "./admin-movies/AdminMoviesPage";
import AdminManageMoviePage from "./admin-movies/AdminManageMoviePage";
import AdminDirectorsPage from "./admin-directors/AdminDirectorsPage";
import AdminManageDirectorPage from "./admin-directors/AdminManageDirectorPage";
import AdminActorsPage from "./admin-actors/AdminActorsPage";
import AdminManageActorPage from "./admin-actors/AdminManageActorPage";
import "react-toastify/dist/ReactToastify.css";
import "./App.css";
import "./Admin.css"
import AdminHeader from "./common/admin-header/AdminHeader";
import { isAdmin } from "../helpers/isLogin";



export function Admin() {
  const { path } = useRouteMatch();
  return (
    <div className="container-fluid admin">
        {isAdmin() ? (
        <>
        <AdminHeader/>      
        <Switch >
          <Route path={`${path}/managemovies`} component={AdminMoviesPage} />
          <Route path={`${path}/managemovie/:slug`} component={AdminManageMoviePage} />
          <Route path={`${path}/managemovie`} component={AdminManageMoviePage} />
          <Route path={`${path}/manageactors`} component={AdminActorsPage} />
          <Route path={`${path}/manageactor/:slug`} component={AdminManageActorPage} />
          <Route path={`${path}/manageactor`} component={AdminManageActorPage} />
          <Route path={`${path}/managedirectors`} component={AdminDirectorsPage} />
          <Route path={`${path}/managedirector/:slug`} component={AdminManageDirectorPage} />
          <Route path={`${path}/managedirector`} component={AdminManageDirectorPage} />
          <Route component={PageNotFound} />
        </Switch>
        </> 
        )
        : 
        <Redirect to="/login"/>}
    </div>
  );
}
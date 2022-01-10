import React from "react";
import { Route, Switch, useRouteMatch} from "react-router-dom";
import HomePage from "./home/HomePage";
import AboutPage from "./about/AboutPage";
import Header from "./common/header/Header";
import "react-toastify/dist/ReactToastify.css";
import MoviePage from "./movies/MoviePage";
import MoviesPage from "./movies/MoviesPage";
import Login from "./authentication/Login";
import Register from "./authentication/Register";
import Profile from "./authentication/Profile";
import ResetPassword from "./authentication/ResetPassword";
import "./App.css";
import ActorPage from "./actors/ActorPage";
import DirectorPage from "./directors/DirectorPage";
import PageNotFound from "./PageNotFound";
import "./Client.css";
import Footer from "./common/footer/Footer";


export function Client() {
  let { path } = useRouteMatch();


  return (
       <div id="client">
           <>     
        <Header />
        <Switch >
          <Route path={`/about`}>
              <AboutPage/>
          </Route>
          <Route path={`/login`}>
              <Login/>
          </Route>
          <Route path={`/register`}>
              <Register/>
          </Route>
          <Route path={`/profile`}>
              <Profile/>
          </Route>
          <Route path={`/resetpassword/:link`}>
              <ResetPassword/>
          </Route>
          <Route path={`/resetpassword`}>
              <ResetPassword/>
          </Route>
          <Route path={`/movies`}>
              <MoviesPage/>
          </Route>
          <Route path={`/movie/:slug`}>
              <MoviePage/>
          </Route>
          <Route path={`/actor/:slug`}>
              <ActorPage/>
          </Route>
          <Route path={`/director/:slug`}>
              <DirectorPage/>
          </Route>
           <Route exact path={`${path}`}>
              <HomePage/>
          </Route>
          <Route component={PageNotFound}/>
        </Switch>
       </>
       <Footer/>
       </div>
  );
}
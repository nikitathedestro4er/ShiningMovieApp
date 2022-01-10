import React from "react";
import { Route, Switch, Router } from "react-router-dom";
import { ToastContainer } from "react-toastify";
import "react-toastify/dist/ReactToastify.css";
import { history } from "../helpers/history";
import "./App.css";
import { Client } from "./Client";
import { Admin } from "./Admin";


function App() {
  return (
    <div className="container-fluid">
      <Router history={history}>        
        <Switch >
          <Route path="/edit" component={Admin} />
          <Route path="/" component={Client} />
        </Switch>
        <ToastContainer autoClose={3000} hideProgressBar />
      </Router>
    </div>
  );
}

export default App;

import React from "react";
import { Link } from "react-router-dom";

const HomePage = () => (
  <div className="jumbotron">
    <h1>Shining Movie App</h1>
    <p>Welcome to the Shining Movie App =)</p>
    <Link to="about" className="btn btn-danger btn-lg">
      Learn more
    </Link>
  </div>
);

export default HomePage;

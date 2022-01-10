import React, {  useEffect, useState } from "react";
import { NavLink } from "react-router-dom";
import { history } from "../../../helpers/history";
import { useDispatch, useSelector } from "react-redux";
import { logout } from "../../../redux/actions/authActions";
import { clearMessage } from "../../../redux/actions/messageActions";
import "bootstrap/dist/css/bootstrap.min.css";
import "./Header.css";
import logo from "../../../img/shining-logo.png";




const Header = () => {
  const currentUser = useSelector((state) => state.auth.user);
  const dispatch = useDispatch();
  const [login, setLogin] = useState(currentUser ? true : false);
  useEffect(() => {
    /* eslint-disable*/
    history.listen((location) => {
      dispatch(clearMessage());
    });
  }, [dispatch]);


  function handleLogin(){
    if(login){
      setLogin(false);
      logOut();
      
    }
    else{
      setLogin(true);
      history.push('/login');
    
    }
  }


  const logOut = () => {
    dispatch(logout());
  };

  return (
    <>
    <div className="header">
      <NavLink exact to={"/"} className="navbar-brand">
          <img src={logo} className="logo"/>
      </NavLink>
      <div className="headerLinks">
        <div className="moviesLink">
          <NavLink to={"/movies"} className="navLink" activeClassName="navLink--active">
            <span className="fast-flicker">M</span>ov<span className="flicker">i</span>es
          </NavLink>
        </div>
        <div className="actorsLink">
          <NavLink to={"/actors"} className="navLink" activeClassName="navLink--active">
            <span className="fast-flicker">Ac</span>to<span className="flicker">r</span>s
          </NavLink>
        </div>
        <div className="directorsLink">
          <NavLink to={"/directors"} className="navLink" activeClassName="navLink--active">
           <span className="fast-flicker">D</span>ire<span className="flicker">ct</span>ors
          </NavLink>
        </div>
        <>
        <p className="loginText">{login ? "LOGOUT" : "LOG IN"}</p>   
        <label className="switch">
          <input type="checkbox" onChange={() => handleLogin()} checked={login}/>
          <span></span>
        </label>        
        </>
      </div>
    </div>
  </>  
    
  );
};


/*<div className="signInLink">
          <NavLink to={"/login"} className="navLink" activeClassName="navLink--active">
            Sign In
          </NavLink>
        </div>*/

export default Header;

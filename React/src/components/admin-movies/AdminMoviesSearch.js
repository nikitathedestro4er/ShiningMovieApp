import { loadMovies } from "../../redux/actions/movieActions";
import PropTypes from "prop-types";
import React, {useState} from 'react';
import {useDispatch} from "react-redux";
import "./AdminMoviesSearch.css";

const AdminMoviesSearch = () => {
    const dispatch = useDispatch()
    const [searchValue, setSearchValue] = useState("")

    function searchHandler(event){
        setSearchValue(event.target.value)
        let query = {pageNumber: 1,pageSize: 9, searchTerm: event.target.value};
        dispatch(loadMovies(query))
    }
    

    return (
        <div>
            <div className="moviesearch">
                <input  value={searchValue} onChange={searchHandler} type="text" placeholder="Search..." className="moviesearch-input"/>
            </div>
        </div>
    );
};

AdminMoviesSearch.propTypes = {
  searchTerm: PropTypes.string,
  dispatch: PropTypes.any,
  loadMovies: PropTypes.func,
};

export default AdminMoviesSearch;
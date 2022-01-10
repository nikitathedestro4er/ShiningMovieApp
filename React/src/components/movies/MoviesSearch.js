import { loadMovies } from "../../redux/actions/movieActions";
import PropTypes from "prop-types";
import React, {useState} from 'react';
import {useDispatch} from "react-redux";
import "./MoviesSearch.css";

const MoviesSearch = () => {
    const dispatch = useDispatch()
    const [searchValue, setSearchValue] = useState("")

    function searchHandler(event){
        setSearchValue(event.target.value)
        let query = {pageNumber: 1,pageSize: 9, searchTerm: event.target.value};
        dispatch(loadMovies(query))
    }
    

    return (
        <div>
            <div className="search">
                <input  value={searchValue} onChange={searchHandler} type="text" placeholder="Search..." className="background search-input"/>
            </div>
        </div>
    );
};

MoviesSearch.propTypes = {
  searchTerm: PropTypes.string,
  dispatch: PropTypes.any,
  loadMovies: PropTypes.func,
};

export default MoviesSearch;



import { loadDirectors } from "../../redux/actions/directorActions";
import PropTypes from "prop-types";
import React, {useState} from 'react';
import {useDispatch} from "react-redux";
import "./DirectorsSearch.css";

const DirectorsSearch = () => {
    const dispatch = useDispatch()
    const [searchValue, setSearchValue] = useState("")

    function searchHandler(event){
        setSearchValue(event.target.value)
        let query = {pageNumber: 1,pageSize: 9, searchTerm: event.target.value};
        dispatch(loadDirectors(query))
    }
    

    return (
        <div>
            <div className="directorsearch">
                <input value={searchValue} onChange={searchHandler} type="text" placeholder="Search..." className="directorsearch-input"/>
            </div>
        </div>
    );
};

DirectorsSearch.propTypes = {
  searchTerm: PropTypes.string,
  dispatch: PropTypes.any,
  loadDirectors: PropTypes.func,
};

export default DirectorsSearch;



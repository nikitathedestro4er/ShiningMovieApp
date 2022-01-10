import { loadActors } from "../../redux/actions/actorActions";
import PropTypes from "prop-types";
import React, {useState} from 'react';
import {useDispatch} from "react-redux";
import "./ActorsSearch.css";

const ActorsSearch = () => {
    const dispatch = useDispatch()
    const [searchValue, setSearchValue] = useState("")

    function searchHandler(event){
        setSearchValue(event.target.value)
        let query = {pageNumber: 1,pageSize: 9, searchTerm: event.target.value};
        dispatch(loadActors(query))
    }
    

    return (
        <div>
            <div className="actorsearch">
                <input value={searchValue} onChange={searchHandler} type="text" placeholder="Search..." className="actorsearch-input"/>
            </div>
        </div>
    );
};

ActorsSearch.propTypes = {
  searchTerm: PropTypes.string,
  dispatch: PropTypes.any,
  loadActors: PropTypes.func,
};

export default ActorsSearch;



/* eslint-disable */
import React, { useState,useEffect} from "react";
import Input from "../common/filters-input/Input";
import SelectSearchInput from "../common/filters-input/SelectSearchInput";
import { connect } from "react-redux";
import { bindActionCreators } from "redux";
import * as movieActions from "../../redux/actions/movieActions";
import * as directorActions from "../../redux/actions/directorActions";
import * as genreActions from "../../redux/actions/genreActions";
import PropTypes from "prop-types";
import "bootstrap/dist/css/bootstrap.min.css";
import "./MoviesFilter.css";
import icon from "../../img/close.png";



function MoviesFilter({genres,directors,loadDirectors,loadGenres,loadMovies}) {
  const [isOpen, setIsOpen] = useState(false);
  const [isChanged, setChanged] = useState(false);
  const defaultQuery = {minYear: undefined, maxYear: undefined, genreId: undefined, directorId: undefined, pageSize:9, pageNumber:1, searchValue: undefined};  
  const [query, setQuery] = useState(defaultQuery);
  const director = {id: 0, name: "Director..."};
  const genre = {id: 0, name: "Genre..."};
  const [searchValue, setSearchValue] = useState("")
  const searchClassName = isChanged ? "search-input-filter-changed" : "search-input";
  const buttonClassName = isOpen ? "filterOpenButton" : "filterButton";

  
  useEffect(() => {      
    if (genres.length === 0) {
    loadGenres().catch((error) => {
      alert("Loading genres failed" + error);
      });
    }

    if (directors.length === 0) {
    loadDirectors().catch((error) => {
      alert("Loading directors failed" + error);
      });
    }
  }, []);
  
  function  handleHoverOn(){
      setIsOpen(true);
  }

  function  handleHoverOff(){
      setIsOpen(false);
      if(isChanged) {
        loadMovies(query);
        setChanged(false);
      }
    }

  function searchHandler(event){
        setSearchValue(event.target.value)
        setChanged(true);
        setQuery((prevQuery) => ({
        ...prevQuery,
        ["searchValue"]: event.target.value
        }));
        let query = {pageNumber: 1,pageSize: 9, searchTerm: event.target.value};
        loadMovies(query);
    }

  function handleChange(event) {
    const { name, value } = event.target;
    setChanged(true);
    setQuery((prevQuery) => ({
      ...prevQuery,
      [name]: value,
    }));
  }

  function handleClear() {
    setSearchValue(undefined);
    setQuery(defaultQuery);
    if(JSON.stringify(query) !== JSON.stringify(defaultQuery)){
      loadMovies(defaultQuery);
    }
  }


  function handleDirectorChange(event) {
    setChanged(true);
    if (event === null){
        setQuery((prevQuery) => ({
        ...prevQuery,
        ["directorId"]: undefined
        }));
    } else{
        setQuery((prevQuery) => ({
        ...prevQuery,
        ["directorId"]: event.value,
        }));
    }    
  }

  function handleGenreChange(event) {
    setChanged(true);
    if (event === null){
        setQuery((prevQuery) => ({
        ...prevQuery,
        ["genreId"]: undefined
        }));
    } else{
        setQuery((prevQuery) => ({
        ...prevQuery,
        ["genreId"]: event.value,
        }));
    }    
  }


  function getDirectorById(id) {
    return directors.find((director) => director.id === id);
  }

  function getGenreById(id) {
    return genres.find((genre) => genre.id === id);
  }



    return (
       <div>         
        <div className="flex">
          <div>
                <div className="search">
                    <input  value={searchValue} onChange={searchHandler} type="text" placeholder="Search..." className={searchClassName}/>
                    <span className="iconClose" onClick={() => handleClear()}>
                      <img className="closeImg" src={icon}></img>
                    </span>
                </div>
            </div>
            <div  onMouseEnter={handleHoverOn}  onMouseLeave={handleHoverOff}>
                <button className={buttonClassName} onClick={() => setIsOpen(!isOpen)}>Filters</button>

                {isOpen && (
                    <div className="container-filter">
                      <div className="genreDiv">   
                            <SelectSearchInput
                                value={query.genreId ? getGenreById(query.genreId) : genre}
                                options={genres.map((genre) => ({
                                value: genre.id,
                                label: genre.name,
                                name: "genreId"
                                }))}
                                onChange={handleGenreChange}
                            />    
                        </div>         
                        <div className="directorDiv">           
                            <SelectSearchInput
                                value={query.directorId ? getDirectorById(query.directorId) : director}
                                options={directors.map((director) => ({
                                value: director.id,
                                label: director.name,
                                name: "directorId"
                                }))}
                                onChange={handleDirectorChange}
                            />
                        </div>
                        <div className="minYear">
                            <Input
                                name="minYear"
                                placeholder="From..."
                                value={query.minYear}
                                onChange={handleChange}
                                error={""}
                            />
                        </div>
                        <div className="maxYear">    
                            <Input
                                name="maxYear"
                                placeholder="To..."
                                value={query.maxYear}
                                onChange={handleChange}
                                error={""}
                            />
                        </div>                      
                    </div>
                )}
            </div>
          </div>
         </div> 
    );

}

MoviesFilter.propTypes = {
  genres: PropTypes.array.isRequired,
  directors: PropTypes.array.isRequired,
  loadMovies: PropTypes.func.isRequired,
  loadGenres: PropTypes.func.isRequired,
  loadDirectors: PropTypes.func.isRequired,
};

function mapStateToProps(state) {
  return {
    genres: state.genres,
    directors: state.directors,
  };
}

function mapDispatchToProps(dispatch) {
  return {
      loadMovies: bindActionCreators(movieActions.loadMovies, dispatch),
      loadGenres: bindActionCreators(genreActions.loadGenres, dispatch),
      loadDirectors: bindActionCreators(directorActions.loadDirectors, dispatch),
  };
}

export default connect(mapStateToProps, mapDispatchToProps)(MoviesFilter);
// eslint-disable-file 
import React, {useState, useEffect} from "react";
import PropTypes from "prop-types";
import TextInput from "../common/TextInput";
import TextAreaInput from "../common/TextAreaInput";
import NumberInput from "../common/NumberInput";
import SelectSearchInput from "../common/SelectSearchInput";
import SelectSearchMultipleInput from "../common/SelectSearchMultipleInput";
import FileInput from "../common/FileInput";
import "./AdminMovie.css";



function AdminMovieForm(props){  
   
  const [movie, setMovie] = useState(props.movie);
  useEffect(() => {
    setMovie(props.movie)
  });
  
  return (
    <div key={movie}>
    <>
    <form  onSubmit={props.onSave}>
      <h2>{movie.id ? "Edit" : "Add"} Movie</h2>
      {props.errors.onSave && (
        <div className="alert alert-danger" role="alert">
          {props.errors.onSave}
        </div>
      )}
      <TextInput
        name="name"
        label="Name"
        value={movie.name}
        onChange={props.onChange}
        error={props.errors.name}
      />
      <SelectSearchInput
        name="genreId"
        label="Genre"
        defaultValue={movie.genreId || ""}
        options={props.genres.map((genre) => ({
          value: genre.id,
          label: genre.name,
          name: "genreId"
        }))}
        onChange={props.onSelectChange}
        error={props.errors.genreId}
      />
      <SelectSearchInput
        id="newcolumn"
        name="directorId"
        label="Director"
        defaultValue={movie.directorId || ""}
        options={props.directors.map((director) => ({
          value: director.id,
          label: director.name,
          name: "directorId"
        }))}
        onChange={props.onSelectChange}
        onCreate={props.onSelectCreate}
        error={props.errors.directorId}
      />
      <SelectSearchMultipleInput
        name="actors"
        label="Actors"
        defaultValue={movie.actors || ""}
        options={props.actors.map((actor) => ({
          value: actor.id,
          label: actor.name,
        }))}
        onChange={props.onMultipleSelectChange}
        onCreate={props.onMultipleSelectCreate}
        error={props.errors.actors}
      />
      <NumberInput
        name="year"
        label="Year"
        value={movie.year}
        onChange={props.onChange}
        error={props.errors.year}
      />
      <FileInput
        imageSrc={movie.image}
        onChange={props.onFileChange}
        error={props.errors.image}
      />
      <NumberInput
        name="rating"
        label="Rating"
        value={movie.rating}
        onChange={props.onChange}
        error={props.errors.rating}
      />
      <TextAreaInput
        name="description"
        label="Description"
        value={movie.description}
        onChange={props.onChange}
        error={props.errors.description}
      />

      <button
        type="submit"
        disabled={props.saving}
        className="btn btn-primary saving-btn"
      >
        {props.saving ? "Saving..." : "Save"}
      </button>
    </form>
    </>
    </div>
  );
}

AdminMovieForm.propTypes = {
  genres: PropTypes.array.isRequired,
  directors: PropTypes.array.isRequired,
  actors: PropTypes.array.isRequired,
  movie: PropTypes.object.isRequired,
  errors: PropTypes.object,
  onSave: PropTypes.func.isRequired,
  onChange: PropTypes.func.isRequired,
  onSelectChange: PropTypes.func.isRequired,
  onSelectCreate: PropTypes.func.isRequired,
  onMultipleSelectChange: PropTypes.func.isRequired,
  onMultipleSelectCreate: PropTypes.func.isRequired,
  onFileChange: PropTypes.func.isRequired,
  saving: PropTypes.bool,
};

export default AdminMovieForm;

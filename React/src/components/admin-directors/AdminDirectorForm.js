// eslint-disable-file 
import React from "react";
import PropTypes from "prop-types";
import TextInput from "../common/TextInput";
import TextAreaInput from "../common/TextAreaInput";
import DateInput from "../common/DateInput";
import NumberInput from "../common/NumberInput";
import FileInput from "../common/FileInput";
import "./AdminDirector.css";

const AdminDirectorForm = ({
  director,
  onSave,
  onChange,
  onDateChange,
  onFileChange,
  saving = false,
  errors,
}) => {
  return (
    <form onSubmit={onSave}>
      <h2>{director.id ? "Edit" : "Add"} Director</h2>
      {errors.onSave && (
        <div className="alert alert-danger" role="alert">
          {errors.onSave}
        </div>
      )}
      <TextInput
        name="name"
        label="Name"
        value={director.name}
        onChange={onChange}
        error={errors.name}
      />
      <DateInput
        name="dateOfBirthday"
        label="Birthday"
        selected={director.birthday}
        onChange={onDateChange}
        error={errors.year}
      />
      <FileInput
        imageSrc={director.image}
        onChange={onFileChange}
        error={errors.image}
      />
      <NumberInput
        name="rating"
        label="Rating"
        value={director.rating}
        onChange={onChange}
        error={errors.rating}
      />
      <TextAreaInput
        name="description"
        label="Description"
        value={director.description}
        onChange={onChange}
        error={errors.description}
      />

      <button
        type="submit"
        disabled={saving}
        className="btn btn-primary saving-btn"
      >
        {saving ? "Saving..." : "Save"}
      </button>
    </form>
  );
};

AdminDirectorForm.propTypes = {
  director: PropTypes.object,
  errors: PropTypes.object,
  onSave: PropTypes.func,
  onChange: PropTypes.func,
  onDateChange: PropTypes.func,
  onFileChange: PropTypes.func,
  saving: PropTypes.bool,
};

export default AdminDirectorForm;

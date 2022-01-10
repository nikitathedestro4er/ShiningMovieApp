// eslint-disable-file 
import React from "react";
import PropTypes from "prop-types";
import TextInput from "../common/TextInput";
import TextAreaInput from "../common/TextAreaInput";
import NumberInput from "../common/NumberInput";
import FileInput from "../common/FileInput";
import DateInput from "../common/DateInput";
import "./AdminActor.css";

const AdminActorForm = ({
  actor,
  onSave,
  onChange,
  onDateChange,
  onFileChange,
  saving = false,
  errors,
}) => {
  return (
    <form onSubmit={onSave}>
      <h2>{actor.id ? "Edit" : "Add"} Actor</h2>
      {errors.onSave && (
        <div className="alert alert-danger" role="alert">
          {errors.onSave}
        </div>
      )}
      <TextInput
        name="name"
        label="Name"
        value={actor.name}
        onChange={onChange}
        error={errors.name}
      />
      <DateInput
        name="dateOfBirthday"
        label="Birthday"
        selected={actor.birthday}
        onChange={onDateChange}
        error={errors.year}
      />
      <FileInput
        imageSrc={actor.image}
        onChange={onFileChange}
        error={errors.image}
      />
      <NumberInput
        name="rating"
        label="Rating"
        value={actor.rating}
        onChange={onChange}
        error={errors.rating}
      />
      <TextAreaInput
        name="description"
        label="Description"
        value={actor.description}
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

AdminActorForm.propTypes = {
  actor: PropTypes.object,
  errors: PropTypes.object,
  onSave: PropTypes.func,
  onChange: PropTypes.func,
  onDateChange: PropTypes.func,
  onFileChange: PropTypes.func,
  saving: PropTypes.bool,
};

export default AdminActorForm;

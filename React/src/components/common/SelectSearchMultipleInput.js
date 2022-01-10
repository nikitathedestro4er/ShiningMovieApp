import React from "react";
import PropTypes from "prop-types";
import CreatableSelect from 'react-select/creatable';

const SelectSearchMultipleInput = ({
  name,
  label,
  onChange,
  onCreate,
  error,
  options,
  defaultValue,
}) => {
  return (
    <div className="form-group">
      <label htmlFor={name}>{label}</label>
      <div className="field">
        {}
        <CreatableSelect
          value={defaultValue ? defaultValue.map((actor) => ({
            value: actor.id,
            label: actor.name,
          })) : ""}
          isMulti={true}
          name={name}
          options={options}
          isClearable={true}
          onChange={onChange}
          onCreateOption={onCreate}/>
        {error && <div className="alert alert-danger">{error}</div>}
      </div>
    </div>
  );
};

SelectSearchMultipleInput.propTypes = {
  name: PropTypes.string,
  label: PropTypes.string,
  placeholder: PropTypes.string,
  onChange: PropTypes.func,
  onCreate: PropTypes.func,
  value: PropTypes.oneOfType([PropTypes.string, PropTypes.number]),
  defaultValue: PropTypes.any,
  error: PropTypes.string,
  options: PropTypes.arrayOf(PropTypes.object),
};

export default SelectSearchMultipleInput;
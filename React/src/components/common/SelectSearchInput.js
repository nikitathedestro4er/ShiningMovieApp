import React from "react";
import PropTypes from "prop-types";
import CreatableSelect from 'react-select/creatable';

const SelectSearchInput = ({
  name,
  label,
  onChange,
  onCreate,
  error,
  options,
  defaultValue,
  
}) => {


  const newValue = defaultValue ? options.find(x => x.value === parseInt(defaultValue)) : {};

  return (
    <div className="form-group">
      <label htmlFor={name}>{label}</label>
      <div className="field">
        {}
        <CreatableSelect
        value={{value: newValue.value, label:newValue.label}}     
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

SelectSearchInput.propTypes = {
  name: PropTypes.string,
  label: PropTypes.string,
  onChange: PropTypes.func,
  onCreate: PropTypes.func,
  value: PropTypes.oneOfType([PropTypes.string, PropTypes.number]),
  defaultValue: PropTypes.any,
  error: PropTypes.string,
  options: PropTypes.arrayOf(PropTypes.object),
};

export default SelectSearchInput;
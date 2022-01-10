import React from "react";
import PropTypes from "prop-types";
import Select from "react-select";

const SelectSearchInput = ({
  onChange,
  options,
  value,
}) => {
  return (
    <div className="form-group">
      <div className="field">
        {}
        <Select
        value={{label: value.name, value : value.id}}
        options={options}
        isClearable={true}
        onChange={onChange}/>
      </div>
    </div>
  );
};

SelectSearchInput.propTypes = {
  onChange: PropTypes.func.isRequired,
  value: PropTypes.oneOfType([PropTypes.string, PropTypes.number]),
  options: PropTypes.arrayOf(PropTypes.object),
};

export default SelectSearchInput;
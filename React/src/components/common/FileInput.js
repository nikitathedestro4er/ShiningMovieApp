import React from "react";
import PropTypes from "prop-types";
import "../admin-movies/AdminMovie.css";

const FileInput = ({
  imageSrc,
  onChange,
  error,
  
}) => {
  return (
    <div className="card">
      <img src={imageSrc} className="cardInput-img-top" />
      <div className="card-body">
          <div className="form-group">
          <input type="file" accept="image/*" className="form-control-file" onChange={onChange} id="image-uploader"/>
          {error && <div className="alert alert-danger">{error}</div>}
      </div>
      </div>
    </div>
  );
};

FileInput.propTypes = {
  imageSrc: PropTypes.any,
  id: PropTypes.string,  
  onChange: PropTypes.func,
  error: PropTypes.string,
};

export default FileInput;
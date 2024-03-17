import React from "react";
import { Link } from "react-router-dom";
// import Age from "./Age";
// import project1 from "../images/project1.jpg";

const TextForm = (props) => {
  return (
    <nav
      className="navbar navbar-expand-lg  bg-info text-dark"
      data-bs-theme="blue" style={{fontFamily:'Antiqua' }}
    >
      <div className="container">
        
        {/* <img
          src={project1}
          className="spinner-border text-light "
          style={{margin: "auto",width: "50px", height: "50px", objectFit: "cover", border: "2px solid #fff", boxShadow: "0 2px 4px rgba(0, 0, 0, 0.1)"}}
          alt=""/>
        */}

         {/* <Link className="navbar-brand" to="/home">Rahul </Link>
         <button
          className="navbar-toggler btn btn-outline-primary"
          type="button"
          data-bs-toggle="collapse"
          data-bs-target="#navbarSupportedContent"
          aria-controls="navbarSupportedContent"
          aria-expanded="false"
          aria-label="Toggle navigation"
        > 
          <span className="navbar-toggler-icon"></span>
        </button>*/}
        <div className="collapse navbar-collapse" id="navbarSupportedContent">
          <ul className="navbar-nav me-auto mb-2 mb-lg-0">
            <li className="nav-item">
              <Link className="nav-link btn-outline-primary" to="/">
                Home
              </Link>
            </li>
            <li className="nav-item">
              <Link className="nav-link btn-outline-primary" to="/about">
                About
              </Link>
            </li>
            <li className="nav-item">
              <Link className="nav-link " to="/details" >
                Contact US
              </Link>
            </li>

            <li className="nav-item">
              <Link className="nav-link btn-outline-primary" to="/marketlist">
                Market
              </Link>
            </li>

            <li className="nav-item">
              <Link className="nav-link " aria-disabled="true" to="/product">
                Product
              </Link>
            </li>
            <li className="nav-item dropdown">
              <Link
                className="nav-link dropdown-toggle"
                to="#"
                role="button"
                data-bs-toggle="dropdown"
                aria-expanded="false"
              >
                Dropdown
              </Link>
              <ul className="dropdown-menu">
                <li>
                  <Link className="dropdown-item bg-primary-subtle" to="/age">
                    Goal
                  </Link>
                </li>
                <li>
                  <hr className="dropdown-divider" />
                </li>
                <li>
                  <Link
                    className="dropdown-item bg-primary-subtle"
                    to="picture"
                  >
                    Photos
                  </Link>
                </li>
                <li>
                  <hr className="dropdown-divider" />
                </li>
                <li>
                  <Link className="dropdown-item bg-primary-subtle" to="/">
                    Something else here
                  </Link>
                </li>
              </ul>
            </li>
          </ul>
          <form className="d-flex">
            <input
              className="form-control me-2"
              type="search"
              placeholder="Search"
              aria-label="Search"
            />
            <button className="btn btn-outline-success" type="submit">
              Search
            </button>
          </form>
        </div>
      </div>
      {/* <div class="fixed-bottom">8888888888888888888888</div> */}
    </nav>
  );
};

export default TextForm;

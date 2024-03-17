import React from "react";
import { Link } from "react-router-dom";
import farmingBackground from "../Image/farmingBackground.jpg"; // Import your farming background image
import natural from "../Image/natural.jpeg";
const TextForm = (props) => {
  return (
    <nav
      className="navbar navbar-expand-lg bg-info text-dark"
      style={{
        fontFamily: 'Antiqua',
        backgroundImage: `url(${natural})`, // Apply the farming background image
        backgroundSize: 'cover',
      }}
    >
      <div className="container">
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
              <Link className="nav-link " to="/details">
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
    </nav>
  );
};

export default TextForm;

import React from "react";
// import { FontAwesomeIcon } from "@fortawesome/react-fontawesome";
// import {
//   faFacebook,
//   faTwitter,
//   faInstagram,
//   faLinkedin,
// } from "@fortawesome/free-brands-svg-icons";

const Footer = () => {
  const containerStyle = {
    display: "flex",
    justifyContent: "space-between",
    // alignItems: " stretch",
    alignItems:  'flex-start',
    // backgroundColor: '#333',
    // color: "black",
    // padding: "10px 10px",
    // margin:'50px 50px'
    // position: 'relative',
    fontFamily:'serif',
  backgroundColor: 'bg-light-subtle',
  color: 'black',
  padding: '10px 20px', 
  };

  return (
    <footer>
     
        <div className="container" style={containerStyle}>
          {/* <a
            href="https://www.facebook.com/"
            target="_blank"
            style={{ margin: "20px" ,position: 'absolute',left: 0, }}
            rel="noopener noreferrer"
          >
            <FontAwesomeIcon
              icon={faFacebook}
             
              size="3x"
              className="social-icon"
            />
          </a>
          <a
            href="https://www.twitter.com/"
            style={{ margin: "20px" ,position: 'absolute',left: 80, }}
            target="_blank"
            rel="noopener noreferrer"
          >
            <FontAwesomeIcon
              icon={faTwitter}
              size="3x"
              className="social-icon"
            />
          </a>
          <a
            href="https://www.instagram.com/"
            style={{ margin: "20px", color: "red",position: 'absolute',left: 160, }}
            target="_blank"
            rel="noopener noreferrer"
          >
            <FontAwesomeIcon
              icon={faInstagram}
              size="3x"
              className="social-icon"
            />
          </a>
          <a
            href="https://www.linkedin.com/"
            style={{ margin: "20px" ,position: 'absolute',left: 240,}}
            target="_blank"
            rel="noopener noreferrer"
          >
            <FontAwesomeIcon
              icon={faLinkedin}
              size="3x"
              className="social-icon"
            />
          </a> */}
          <div style={{ position: "absolute", right: 0,margin:'20px' }}>
            <p style={{size:'3x', color:'#000'}}>&copy; 2024 Rahul Shermale</p>
          </div>
        </div>
     
    </footer>
  );
};

export default Footer;

import React from "react";
import onion from "../Image/onion.jpg";
import maize_01 from "../Image/maize_01.jpg";
import maize_02 from "../Image/maize_02.jpg";

import { Link } from "react-router-dom";

const imStyle = {
  // display: "flex",
//   margin: "auto",
  width: "300px",
  height: "300px",
//   // objectFit: 'left',
//   border: "1px solid #000",
//   // boxShadow: '0 2px 4px rgba(0, 5, 10, 0.1)',
//   // marginRight: '200px', // Add margin-right for space between images
//   borderRadius: "50%",
  // display: "flex",
//   // position:'fixed',
  // bottom: "10",
//   left: "200",
// margin: "auto",
  // width: "30%",
  // height: "100 px",
  // objectFit: 'left',
  gap:'5px'
};


const gallary={
  display: "flex",
  // width : "30%",
  // height:"50px",
  // gap:"50px",
  
}


const imageStyle = {
  display: "flex",
  width: "30%",
  height: "auto",
  padding: " 8% 0% 0% 1% ",
  // boxsizing: "border-box"
};

export default function Home() {
  return (
    <div
    className="container-fluid"
    // style={{
    //   backgroundColor: "rba(52, 280, 219, 5)",
    //   textAlign: "justify",
    //   height: "100vh",
    //   fontFamily: "serif",
    // }}
    >
      <div className="row-5">
            <div className="col-10 text-center pt-5"
                style={{ color: "Blue", textShadow: "2px" }}  >
                      <h1><b>Onion</b></h1>
                      <img src={onion} className="" style={imageStyle} alt="abc" />
                      <Link to="/onion"> Show Details</Link>
            </div>
            <div className="col-10 text-center pt-5"
                style={{ color: "Blue", textShadow: "2px" }}  >
                      <h1><b>Maize</b></h1>
                      <img src={maize_01} className="" style={imageStyle} alt="abc" />
                      <Link to="/maize01"> Show Details</Link>
            </div>  
            <div className="col-10 text-center pt-5"
                style={{ color: "Blue", textShadow: "2px" }}  >
                      <h1><b>Maize</b></h1>
                      <img src={maize_02} className="" style={imageStyle} alt="abc" />
                      <Link to="/maize02"> Show Details</Link>
            </div> 
         <br />
         <br />

      </div>
      <div className="gallary">
        <img src={onion} className="rounded" style={imStyle} alt="" />
        <img src={maize_01} className="rounded" style={imStyle} alt="" />
        <img src={maize_02} className="rounded" style={imStyle} alt="" />
      </div>
    </div>
  );
}

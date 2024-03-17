import React from "react";
import onion from "../Image/onion.jpg";
import maize_01 from "../Image/maize_01.jpg";
import maize_02 from "../Image/maize_02.jpg";
import farm_02 from "../Image/farm_02.jpg";
import { Link } from "react-router-dom";

const imageStyle = {
  display: "flex",
  width: "30%",
  height: "auto",
  padding: "8% 0% 0% 1%",
};

export default function Home() {
  return (
    <div className="container-fluid" style={{ backgroundImage: `url(${farm_02})`, backgroundAttachment: "fixed" }}>
      <div className="row justify-content-center">
        <div className="col-10 text-center pt-5" style={{ color: "blue", textShadow: "2px" }}>
          <h1><b>Onion</b></h1>
          <img src={onion} className="rounded" style={imageStyle} alt="Onion" />
          <Link to="/onion">Show Details</Link>
        </div>
        <div className="col-10 text-center pt-5" style={{ color: "blue", textShadow: "2px" }}>
          <h1><b>Maize</b></h1>
          <img src={maize_01} className="rounded" style={imageStyle} alt="Maize 01" />
          <Link to="/maize01">Show Details</Link>
        </div>
        <div className="col-10 text-center pt-5" style={{ color: "blue", textShadow: "2px" }}>
          <h1><b>Maize</b></h1>
          <img src={maize_02} className="rounded" style={imageStyle} alt="Maize 02" />
          <Link to="/maize02">Show Details</Link>
        </div>
      </div>
    </div>
  );
}

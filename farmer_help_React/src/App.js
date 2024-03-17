// import logo from "./logo.svg";
// import "./App.css";
// import Header from "./Component/Header";
import Navbar from "./Component/Navbar";

import Home from "./Component/Home";
import { BrowserRouter as Router, Routes, Route } from "react-router-dom";
import Footer from "./Component/Footer";
import Product from "./Component/Product"
import Onion from "./Component/Onion";
import Maize from "./Component/Maize";
import Market from "./Component/Market";

function App() {
  return (<>
    <Router>
      
     <Navbar/>
     
      <Routes>
       

        <Route path="/" element={<Home />} />
        <Route path="/home" element={<Home />} />
        <Route path="/product" element={<Product/>}/>
        <Route path="/onion" element={<Onion/>}/>
        <Route path="/maize01" element={<Maize/>}/>
        <Route path="/maize02" element={<Maize/>}/>
        <Route path="/marketlist" element={<Market/>}/>
      </Routes>

      <Footer/>
    </Router>
  </>
);
}


export default App;

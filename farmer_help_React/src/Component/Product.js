import React, { useState, useEffect } from "react";
import { useNavigate, useParams } from "react-router-dom";
// // import Button from "react-bootstrap/Button";
// import Carousel from "react-bootstrap/Carousel";

import { Table, Button } from "react-bootstrap";
// import { Container, Row, Col } from "reactstrap";

export default function Product() {
  const navigate = useNavigate();
  const [product, setProducts] = useState([]);
  //   const { id } = useParams();

    {useEffect(() => {
      fetch("http://localhost:8080/api/product")
        .then((res) => res.json())
        .then((result) => {
          setProducts(result);
        });
    }, []);}

  //   const [index, setIndex] = useState(0);

  //   const handleSelect = (selectedIndex) => {
  //     setIndex(selectedIndex);
  //   };

    const tabStyle = {
      width: "62%",
    //   margin: "auto",
    //   borderCollapse: "collapse",
      borderRadius: "8px",
    //   overflow: "hidden",
      boxShadow: "0 0 10px rgba(0, 0, 0, 0.1)",
    };

    const tabhead = {
      backgroundColor: "#007bff",
      color: "#fff",
      border: "2px solid #ddd",
      padding: "10px",
      textAlign: "center",
    };

    const tabBodyRow = {
      backgroundColor: "#f2f2f2",
    };

    const tabBodyCell = {
      border: "1px solid #ddd",
      padding: "10px",
      textAlign: "center",
    };

  return (
    <div style={{ textAlign: "center" }}>
      {/* //
//      <Container fluid>
//         <Row>
//           <Col md="6">
//             <div>
//               <br />
//               <h2 style={{ textAlign: "center", color: "#007bff" }}>Market List</h2>
//               <br />
//               <Table striped bordered hover style={tabStyle}> 
/*}
                <thead>
                  <tr>
                    <th style={tabhead}>Market Id</th>
                    <th style={tabhead}>Market Name</th>
                    <th style={tabhead}>Market Address</th>
                  </tr>
                </thead>
{/*                 <tbody>
//                   {product.map((product) => (
//                     <tr key={product.pid} style={tabBodyRow}>
//                       <td style={tabBodyCell}>{product.pid}</td>
//                       <td style={tabBodyCell}>{product.city}</td>
//                       <td style={tabBodyCell}>{market.address}</td>
//                     </tr>
//                   ))}
//                 </tbody>
//               </Table>
//             </div>
//           </Col>
//         </Row>
//       </Container>
  //      <div style={{textAlign:"center",padding:"100px"}}> */}
      <Table striped bordered hover style={tabStyle}> 

                <thead>
                  <tr>
                    <th style={tabhead}>Market Id</th>
                    <th style={tabhead}>Market Name</th>
                    <th style={tabhead}>Market Address</th>
                  </tr>
                </thead>
                <tbody>
                  {product.map((product) => (
                    <tr key={product.pid} style={tabBodyRow}>
                      <td style={tabBodyCell}>{product.pid}</td>
                      <td style={tabBodyCell}>{product.product_name}</td>
                      <td style={tabBodyCell}>{product.product_type}</td>
                    </tr>
                  ))}
                 </tbody>
                
    </Table>

      <br />

      <Button
        variant="primary"
        onClick={() => {
          navigate(-1);
        }}
      >
        Back
      </Button>
    </div>
    // </div>
  );
}

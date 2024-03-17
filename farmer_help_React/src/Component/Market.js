import React from "react";
import { useState, useEffect } from "react";
import { Table ,Button} from "react-bootstrap";
import { Container, Row, Col } from "reactstrap";
import { useNavigate, useParams } from "react-router-dom";



function Market() {
  const [markets, setMarkets] = useState([]);
  const navigate = useNavigate();
  useEffect(() => {
    fetch("http://localhost:8080/api/market")
      .then((res) => res.json())
      .then((result) => {
        setMarkets(result);
      });
  }, []);

  const tabStyle = {
    width: "100%",
    margin: "auto",
    borderCollapse: "collapse",
    borderRadius: "8px",
    overflow: "hidden",
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
    <>
      <Container fluid>
        <Row>
          <Col md="6">
            <div>
              <br />
              <h2 style={{ textAlign: "center", color: "#007bff" }}>Market List</h2>
              <br />
              <Table striped bordered hover style={tabStyle}>
                <thead>
                  <tr>
                    <th style={tabhead}>Market Id</th>
                    <th style={tabhead}>Market Name</th>
                    <th style={tabhead}>Market Address</th>
                  </tr>
                </thead>
                <tbody>
                  {markets.map((market) => (
                    <tr key={market.id} style={tabBodyRow}>
                      <td style={tabBodyCell}>{market.id}</td>
                      <td style={tabBodyCell}>{market.city}</td>
                      <td style={tabBodyCell}>{market.address}</td>
                    </tr>
                  ))}
                </tbody>
              </Table>
            </div>
          </Col>
        </Row>
      </Container>
     <div style={{textAlign:"center",padding:"100px"}}> 
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
    </>
  );
}

export default Market;

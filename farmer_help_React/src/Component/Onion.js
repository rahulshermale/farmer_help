
import onion from "../Image/onion.jpg"
export default function(){


    const imStyle = {
        display: "flex",
        margin: "auto",
        width: "300px",
        height: "300px",
        // objectFit: 'left',
    //     border: "1px solid #000",
    //     boxShadow: '0 2px 4px rgba(0, 5, 10, 0.1)',
    //     marginRight: '200px', // Add margin-right for space between images
    //     borderRadius: "50%",
    //     display: "flex",
    //     position:'fixed',
    //     bottom: "10",
    //     left: "200",
    //   margin: "auto",
    //     width: "30%",
    //     height: "100 px",
    //     objectFit: 'left',
        gap:'3px'
      };

    return(
        <>
        
        <h1> Onion Details</h1>
        
      <div className="gallary">
        <img src={onion} className="rounded" style={imStyle} alt="" />
          </div>
        </>
    )
}
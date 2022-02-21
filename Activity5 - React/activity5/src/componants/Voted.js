import "./Voted.css";
import React, { useState } from "react";

function Button() {
  const [result, setResult] = useState("MIN");
  const clickHandler = (event) => {
    if (event) {
      if (result === "MIN") {
        setResult(1);
      } else {
        setResult(result + 1);
      }
    } else {
      if (result === 1) {
        setResult("MIN");
      } 
      else if( result === "MIN"){
        alert("Hello! I am an alert box!!");
      }
          else {
        setResult(result - 1);
      }
    }
  };

  return (
    <div className="container">
      <button onClick={() => clickHandler(true)}>Click to Vote</button>
      <div className="result-card">{result}</div>
      <button onClick={() => clickHandler(false)}>Click to Unvote</button>
    </div>
  );
}
export default Button;

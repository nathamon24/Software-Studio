/* eslint-disable jsx-a11y/alt-text */
import "./MemberCard.css";
import Voted from "./Voted"
function MemberCard(props) {
  return (
    <div className="card">
      <div className="top">
        <div className="top-left">
          <h1>{props.firstname} {props.lastname}</h1>
          <h2>{props.id}</h2>
          <div>
            {props.des}
          </div>
        </div>
        <div className="top-right">
            <img src={props.image} />
        </div>
      </div>
      <div className="bottom">
          <Voted />
      </div>
    </div>
  );
}

export default MemberCard;
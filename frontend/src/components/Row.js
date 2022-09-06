import React from 'react'
import '../style/Row.css'
function Row(props){
    
return(
    <div className='Row'>
        <h3>{props.name}</h3>
        <div>{props.description}</div>
        <div><button>edit</button>
        <button >delete</button></div>
        
    </div>
)
};

export default Row;
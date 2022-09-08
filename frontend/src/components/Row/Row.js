import React from 'react'
import './Row.css'
function Row(props){
    
    const deleteBttnClicked = (event) =>{
        props.func(props.name)
    }
    
    const editBttnClicked = (event) =>{
        props.editFun(props.name, props.description);
    }

return(
    <div className='row-item'>
        <h2>{props.name}</h2>
        <div className='row-item__description'>{props.description}</div>
        <button className='row-item__price button-19' onClick={editBttnClicked}>edit</button>
        <button className='row-item__price button-19' onClick={deleteBttnClicked}>delete</button>
        
    </div>
)
};

export default Row;
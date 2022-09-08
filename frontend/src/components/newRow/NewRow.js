import React from 'react'
import './NewRow.css'
import RowForm from './RowForm';

function NewRow(props){
    const onSubmitData = (data) => {
        props.onAddRow(data);
    }
return (
<div className='new-expense'>
<RowForm onSubmitData={onSubmitData}></RowForm>    
</div>
)
};


export default NewRow;
import React from 'react'
import RowForm from '../newRow/RowForm'
import './popup.css'
export default function Popup(props) {
  const onSubmitData = (data) => {
    props.onEditFinished(data);
}
  return (props.popUpTrigger) ?(
    <div className='popup'>
        <div className='popup-inner'>
            <RowForm className='close-btn' onSubmitData={onSubmitData}></RowForm>
        </div>
    </div>
  ): ""
}

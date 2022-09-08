import React, {useState} from 'react'
import './RowForm.css'

function RowForm (props){
    const [taskName, setTaskName] = useState("");
    const [taskDesc, setTaskDesc] = useState("");
    
    const submitHandler = (event) => {
        event.preventDefault();

        const requestData={
            name: taskName,
            description: taskDesc
        }
        props.onSubmitData(requestData);
        setTaskName("");
        setTaskDesc("");
    }
    const nameChangeHandler = (event) =>{
        setTaskName(event.target.value);
    }

    const taskChangeHandler = (event) =>{
        setTaskDesc(event.target.value);
    }

    return <form onSubmit={submitHandler}>
        <div className='new-row__controls'>
            <div className='new-row__control'>
                <label>Task Name</label>
                <input type='text' value={taskName} onChange={nameChangeHandler}>{props.name}</input>
            </div>
            <div className='new-row__control'>
                <label>Task Description</label>
                <input type='text' value={taskDesc} onChange={taskChangeHandler}>{props.desc}</input>
            </div>
        </div>
        <div className='new-row__actions'>
            <button type='submit' > Add Task</button>
        </div>

    </form>
}

export default RowForm;
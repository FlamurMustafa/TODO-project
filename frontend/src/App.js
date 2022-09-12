import React, {useEffect, useState} from 'react';
import Row from './components/Row/Row';
import NewRow from './components/newRow/NewRow';
import './App.css'
import Popup from './components/Popup/Popup';
const axios = require('axios').default;




function App() {
  const [ress, setState] = useState([]);
  const [editTaskName, setEditTaskName] = useState('');
  const [editTaskDesc, setEditTaskDesc] = useState('');
  const [popupTrigger, setPopupTrigger] = useState(false);
  const [rowToBeEdited, setRowToBeEdited] = useState();
  const getRows = () => {
    axios.get("https://localhost:7019/items").then((result) => {
      setState(result.data)      
    }).catch((err) => {
      setState([])
    });
  }
useEffect(()=>{
  getRows();
},[])

function newRowAdded(data){
  axios.post("https://localhost:7019/items",{
    name: data.name,
    description: data.description
  }).then((result) => {
    getRows();
  }).catch((err) => {
    
  });
}

function deleteHandler(name){
  console.log(name);
 axios.delete(`https://localhost:7019/items/${name}`).then((result) => {
  getRows()
 }).catch((err) => {
  console.log(err);
 });
}

function editHandler(id, desc){
  console.log(id);
  setRowToBeEdited(id);
  setPopupTrigger(true);
}

function editRowHandler(newData){
  
  axios.put(`https://localhost:7019/items/${rowToBeEdited}`,newData).then((result) => {
    console.log("done");
    setPopupTrigger(false)
    getRows();
  }).catch((err) => {
    
  });
  console.log(newData, rowToBeEdited)
}

  return (
   <div className="App bg-red-300">
    <Popup popUpTrigger={popupTrigger} onEditFinished={editRowHandler}></Popup>
   <NewRow onAddRow={newRowAdded} taskName={editTaskName} taskDesc={editTaskDesc}></NewRow>
    {ress.map((e)=>{
      return (<Row key={e.id} id={e.id} name={e.name} description={e.description} func={deleteHandler} editFun={editHandler}></Row>)
    })}
   </div>
  )
  }

export default App;
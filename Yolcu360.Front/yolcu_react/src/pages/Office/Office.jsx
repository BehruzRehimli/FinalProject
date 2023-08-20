import React from 'react'
import "./Office.css"
import { Link } from 'react-router-dom'
import WhyYolcu from '../../components/WhyYolcu/WhyYolcu'
import Portniors from '../../components/Slider/Portniors/Portniors'

const Office = () => {
  return (
    <div style={{textAlign:"center"}}>
    <div className='top-office d-flex justify-content-center'>
      <div className="my-container">
        <span className='office-name'>El Prat de Llobregat Barcelona–El Prat Airport Rent a Car</span>
        <div className='head-page'>
          <Link>Rent a Car</Link>
          <span>{">"}</span>
          <span >Barcelona–El Prat Airport Rent a Car</span>
        </div>
      </div>
    </div>
    <div className="my-container" style={{margin:"0 auto"}}>
    <WhyYolcu/>
    </div>
    <div className="partners">
      <div className="my-container" style={{margin:"0 auto",paddingTop:"0"}}>
      <h3 style={{textAlign:"left",marginBottom:"50px"}} className='heading'>Our Partners</h3>
      <Portniors/>
      </div>
    </div>
    </div>
  )
}

export default Office
import React from 'react'
import "./Detail.css"
import {IoArrowBackOutline} from "react-icons/io5"
import {Link} from "react-router-dom"
import {TiArrowDownThick,TiArrowUpThick} from "react-icons/ti"
import {BiSolidCar} from "react-icons/bi"


const Detail = () => {
  return (
    <div>
        <div className="top-detail">
            <div className="go-back-btn">
                <span style={{marginRight:"10px",paddingRight:"10px",borderRight:"1px solid #9b9b9b"}}>Back</span>
                <IoArrowBackOutline style={{fontSize:"20px"}}/>
            </div>
        </div>
        <div className="my-container" style={{margin:"100px auto"}}>
            <div className="road">
                <div>
                    <span className='road-number'>1</span>
                    <span style={{color: "#434444",fontSize:"18px",fontWeight:"700",marginLeft:"10px"}}>Vehicle Selection</span>
                </div>
                <div className='wizard-dot'>
                    <span  className='line'/>
                </div>
                <div>
                    <span className='road-number passive'>2</span>
                    <span style={{color: "#979797",fontSize:"18px",fontWeight:"700",marginLeft:"10px"}}>Driver Information</span>
                </div>
                <div className='wizard-dot'>
                    <span  className='line'/>
                </div>
                <div>
                    <span className='road-number passive'>3</span>
                    <span style={{color: "#979797",fontSize:"18px",fontWeight:"700",marginLeft:"10px"}}>Payment Information</span>
                </div>
            </div>
            <div className="route-path text-start mt-3 ps-3">
                <Link to="/">Home Page</Link>
                <span className='ms-3 me-1'>/</span>
                <span>Rent a Car</span>
                <span className='ms-3 me-1'>/</span>
                <Link to="/office/5">Barcelona Airport</Link>
                <span className='ms-3 me-1'>/</span>
                <Link to="/detail">Fiat Egea</Link>
            </div>
            <div className="row mt-3">
                <div className="col-lg-8"></div>
                <div className='col-lg-4'>
                    <div className="detail-sidebar">
                        <div className="price-date">
                            <div className="header">
                                <div className="price">
                                    <p style={{color:"#9b9b9b",fontSize:"14px",textAlign:"start",marginBottom:"0"}}>3 Daily price:</p>
                                    <p style={{textAlign:"start",color:"#4a4a4a",fontWeight:"700",fontSize:"32px",marginBottom:"0"}}>145.05 $</p>
                                    <p style={{textAlign:"start",color:"#2ecc71",fontWeight:"400",fontSize:"14px",marginBottom:"10px"}}>Daily price:48.35 $</p>
                                </div>
                            </div>
                            <div className="pick-up-info">
                            <div className="left" style={{width:'50px',height:"50px"}}>
                                <TiArrowDownThick style={{fontSize:'25px',color:"#008dd4",position:"absolute",top:"0",left:"-6px"}}/>
                                <BiSolidCar style={{fontSize:'30px',marginTop:"5px",color:"#888",opacity:"0.35",top:"0",position:"absolute",left:"3px"}}/>
                            </div>
                            <div className="right d-flex justify-content-start">
                                 <div style={{width:"50px"}}>
                                    <p style={{maxWidth:"50px",textAlign:"start",fontSize:"12px",fontWeight:"700",color:"#008dd4"}}>Pick-Up Date</p>
                                 </div>
                                 <div className='ms-3'>
                                    <p style={{marginBottom:"0",textAlign:"start",color:"#9b9b9b",fontSize:"13px",fontWeight:"600"}}>Istanbul-Sabiha Gokcen</p>
                                    <p style={{marginBottom:"0",textAlign:"start",color:"#008dd4",fontWeight:"700",fontSize:"14px"}}>25.08.2023 - 10:00</p>
                                 </div>
                            </div>
                        </div>
                        <div className="drop-off-info">
                            <div className="left" style={{width:'50px',height:"50px"}}>
                            <TiArrowUpThick style={{fontSize:'25px',color:"#ffa900",position:"absolute",top:"0",left:"-6px"}}/>
                                <BiSolidCar style={{fontSize:'30px',marginTop:"5px",color:"#888",opacity:"0.35",top:"0",position:"absolute",left:"3px"}}/>
                            </div>
                            <div className="right d-flex justify-content-start">
                                 <div style={{width:"50px"}}>
                                    <p style={{maxWidth:"50px",textAlign:"start",fontSize:"12px",fontWeight:"700",color:"#ffa900"}}>Drop-Off Date</p>
                                 </div>
                                 <div className='ms-3'>
                                    <p style={{marginBottom:"0",textAlign:"start",color:"#9b9b9b",fontSize:"13px",fontWeight:"600"}}>Istanbul-Sabiha Gokcen</p>
                                    <p style={{marginBottom:"0",textAlign:"start",color:"#ffa900",fontWeight:"700",fontSize:"14px"}}>28.08.2023 - 10:00</p>
                                 </div>
                            </div>
                        </div>

                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
  )
}

export default Detail
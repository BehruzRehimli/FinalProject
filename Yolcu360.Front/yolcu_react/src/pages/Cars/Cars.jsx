import React, { useState } from 'react'
import { useParams, Link } from 'react-router-dom'
import "./Cars.css"
import { FaAngleRight, FaChevronDown, FaChevronUp } from "react-icons/fa"
import { PiArrowsDownUpBold } from "react-icons/pi"
import { BsCheck, BsFillFuelPumpFill, BsFillCarFrontFill } from "react-icons/bs"
import { BiInfoCircle } from "react-icons/bi"
import { GiGearStick } from 'react-icons/gi'
import { BiSolidStar, BiSolidStarHalf } from 'react-icons/bi'

const Cars = () => {
    const { id } = useParams();

    const [tab, setTab] = useState({
        transmission: false,
        fuel: false,
    })
    return (
        <div className='my-container mt-5' style={{ margin: "0 auto" }}>
            <div className='top-cars'>
                <Link to="/">Home Page</Link>
                <span>/</span>
                <span>Rent a Car</span>
                <span>/</span>
                <Link to={`/office/:${id}`}>Name</Link>
            </div>
            <div className="row">
                <div className="col-lg-3 col-xl-4 col-md-4 col-sm-4">
                    <div className="promo-code" style={{ height: "40px" }}>
                        <span>
                            I have a promo code
                            <FaAngleRight style={{ fontSize: "20px" }} />
                        </span>
                    </div>
                    <div style={{ border: "1px solid #dee3e8" }}>
                        <p style={{ marginBottom: "0", fontSize: "13px", textAlign: 'left', padding: "10px 20px" }}>Filter</p>
                    </div>
                    <div style={{ border: "1px solid #dee3e8", borderTop: "none", display: "flex", justifyContent: "space-between", alignItems: "center" }}>
                        <p style={{ color: "#ffa900", marginBottom: "0", fontSize: "15px", fontWeight: "700", textAlign: 'left', padding: "10px 20px" }}>Transmission Type</p>
                        {
                            tab.transmission ? <FaChevronUp style={{ color: "#ffa900", fontSize: "22px", marginRight: '10px' }} /> : <FaChevronDown style={{ color: "#ffa900", fontSize: "22px", marginRight: '10px' }} />
                        }
                    </div>
                    <div className='transsmission-tab tab' >
                        <div className="row">
                            <div className="col-xl-6 col-lg-12 col-md-12 col-sm-12 col-12" style={{ display: "flex", alignItems: "center" }}>
                                <input type="checkbox" value={1} id='automatic' name='transmission' />
                                <label htmlFor="automatic">Authomatic</label>
                            </div>
                            <div className="col-xl-6 col-lg-12 col-md-12 col-sm-12 col-12" style={{ display: "flex", alignItems: "center" }}>
                                <input type="checkbox" value={2} id='Manual' name='transmission' />
                                <label htmlFor="manual">Manual</label>
                            </div>

                            <div className="col-xl-6 col-lg-12 col-md-12 col-sm-12 col-12"></div>
                        </div>
                    </div>
                    <div style={{ border: "1px solid #dee3e8", borderTop: "none", display: "flex", justifyContent: "space-between", alignItems: "center" }}>
                        <p style={{ color: "#ffa900", marginBottom: "0", fontSize: "15px", fontWeight: "700", textAlign: 'left', padding: "10px 20px" }}>Fuel Type</p>
                        {
                            tab.fuel ? <FaChevronUp style={{ color: "#ffa900", fontSize: "22px", marginRight: '10px' }} /> : <FaChevronDown style={{ color: "#ffa900", fontSize: "22px", marginRight: '10px' }} />
                        }
                    </div>
                    <div className='transsmission-tab tab' >
                        <div className="row g-3">
                            <div className="col-xl-6 col-lg-12 col-md-12 col-sm-12 col-12" style={{ display: "flex", alignItems: "center" }}>
                                <input type="checkbox" value={1} id='automatic' />
                                <label htmlFor="diesel">Diesel</label>
                            </div>
                            <div className="col-xl-6 col-lg-12 col-md-12 col-sm-12 col-12" style={{ display: "flex", alignItems: "center" }}>
                                <input type="checkbox" value={2} id='GasDiesel' />
                                <label htmlFor="GasDiesel">Gas Diesel</label>
                            </div>
                            <div className="col-xl-6 col-lg-12 col-md-12 col-sm-12 col-12" style={{ display: "flex", alignItems: "center" }}>
                                <input type="checkbox" value={3} id='Electrik' />
                                <label htmlFor="Electric">Electric</label>
                            </div>
                            <div className="col-xl-6 col-lg-12 col-md-12 col-sm-12 col-12" style={{ display: "flex", alignItems: "center" }}>
                                <input type="checkbox" value={4} id='Gas' />
                                <label htmlFor="Gas">Gas</label>
                            </div>

                        </div>
                    </div>
                    <div style={{ border: "1px solid #dee3e8", borderTop: "none", display: "flex", justifyContent: "space-between", alignItems: "center" }}>
                        <p style={{ color: "#ffa900", marginBottom: "0", fontSize: "15px", fontWeight: "700", textAlign: 'left', padding: "10px 20px" }}>Car Brand</p>
                        {
                            tab.fuel ? <FaChevronUp style={{ color: "#ffa900", fontSize: "22px", marginRight: '10px' }} /> : <FaChevronDown style={{ color: "#ffa900", fontSize: "22px", marginRight: '10px' }} />
                        }
                    </div>
                    <div className='transsmission-tab tab' >
                        <div className="row g-3">
                            <div className="col-xl-6 col-lg-12 col-md-12 col-sm-12 col-12" style={{ display: "flex", alignItems: "center" }}>
                                <input type="checkbox" value={1} id='BMW' />
                                <label htmlFor="BMW">BMW</label>
                            </div>
                            <div className="col-xl-6 col-lg-12 col-md-12 col-sm-12 col-12" style={{ display: "flex", alignItems: "center" }}>
                                <input type="checkbox" value={2} id='Mercedes' />
                                <label htmlFor="Mercedes">Mercedes</label>
                            </div>
                            <div className="col-xl-6 col-lg-12 col-md-12 col-sm-12 col-12" style={{ display: "flex", alignItems: "center" }}>
                                <input type="checkbox" value={3} id='Toyota' />
                                <label htmlFor="Toyota">Toyota</label>
                            </div>
                            <div className="col-xl-6 col-lg-12 col-md-12 col-sm-12 col-12" style={{ display: "flex", alignItems: "center" }}>
                                <input type="checkbox" value={4} id='Gas' />
                                <label htmlFor="Gas">Gas</label>
                            </div>

                        </div>
                    </div>
                    <div style={{ border: "1px solid #dee3e8", borderTop: "none", display: "flex", justifyContent: "space-between", alignItems: "center" }}>
                        <p style={{ color: "#ffa900", marginBottom: "0", fontSize: "15px", fontWeight: "700", textAlign: 'left', padding: "10px 20px" }}>Car Model</p>
                        {
                            tab.fuel ? <FaChevronUp style={{ color: "#ffa900", fontSize: "22px", marginRight: '10px' }} /> : <FaChevronDown style={{ color: "#ffa900", fontSize: "22px", marginRight: '10px' }} />
                        }
                    </div>
                    <div className='transsmission-tab tab' >
                        <div className="row g-3">
                            <div className="col-xl-6 col-lg-12 col-md-12 col-sm-12 col-12" style={{ display: "flex", alignItems: "center" }}>
                                <input type="checkbox" value={1} id='BMW' />
                                <label htmlFor="BMW">BMW</label>
                            </div>
                            <div className="col-xl-6 col-lg-12 col-md-12 col-sm-12 col-12" style={{ display: "flex", alignItems: "center" }}>
                                <input type="checkbox" value={2} id='Mercedes' />
                                <label htmlFor="Mercedes">Mercedes</label>
                            </div>
                            <div className="col-xl-6 col-lg-12 col-md-12 col-sm-12 col-12" style={{ display: "flex", alignItems: "center" }}>
                                <input type="checkbox" value={3} id='Toyota' />
                                <label htmlFor="Toyota">Toyota</label>
                            </div>
                            <div className="col-xl-6 col-lg-12 col-md-12 col-sm-12 col-12" style={{ display: "flex", alignItems: "center" }}>
                                <input type="checkbox" value={4} id='Gas' />
                                <label htmlFor="Gas">Gas</label>
                            </div>

                        </div>
                    </div>


                </div>
                <div className="col-lg-9 col-xl-8 col-md-8 col-sm-8">
                    <div className="top-info">
                        <div className="left-top-info">
                            <div className="left">
                                <span className='office-name'>Madrid - Barajas Adolfo Suárez Airport</span>
                                <span className='desc'>Car Rental Prices</span>
                            </div>
                            <div className="right">
                                <span>listing</span>
                                <span className='second'>72 vehicles</span>
                            </div>
                        </div>
                        <div className="right-top-info">
                            <div style={{ padding: '6px 10px 6px 10px', width: "100%", height: "100%", display: "flex", justifyContent: "space-between" }}>
                                <div className="left">
                                    <span>Sort:</span>
                                    <span className='second'>Sort by Recommended</span>

                                </div>

                                <div className="right">
                                    <PiArrowsDownUpBold style={{ marginLeft: "10px", fontSize: "18px", fontWeight: "700", color: "#888888" }} />
                                </div>

                            </div>
                        </div>
                    </div>
                    <div className="cars mt-2">
                        <div className="car">
                            <div className="car-title">
                                <p className='car-name'>Fiat Fiorino</p>
                                <p style={{ color: '#9b9b9b', fontSize: "12px", textAlign: "left" }}>or similar</p>
                            </div>
                            <div className="car-info">
                                <div className="left">
                                    <div className="free-cancel">
                                        <div className='d-flex'>
                                            <div className="radius">
                                                <BsCheck style={{ color: "#39b54a", fontSize: "20px" }} />
                                            </div>
                                            <span>FREE CANCELLATION</span>
                                        </div>
                                    </div>
                                    <div className="car-img">
                                        <img src="https://static.yolcu360.com/thumbnails/ce/c8/cec8e73262e2ca2edb69859392cb3ce1.png" alt="car" />
                                    </div>
                                </div>
                                <div className="right">
                                    <ul>
                                        <li style={{ textAlign: "left", fontSize: "20px" }}>
                                            <BiInfoCircle color='#008dd4' />
                                            <span>Deposit : <b>55,15 $</b> </span>
                                        </li>
                                        <li style={{ textAlign: "left", fontSize: "20px" }}>
                                            <BiInfoCircle color='#008dd4' />
                                            <span>Total mileage limit : <b>1500 km</b> </span>
                                        </li>
                                        <li style={{ textAlign: "left", fontSize: "20px" }}>
                                            <BiInfoCircle color='#008dd4' />
                                            <span>How to pick up your car? <b>In-terminal office</b> </span>
                                        </li>                                    </ul>
                                </div>
                            </div>
                            <div className="car-bottom">
                                <div>
                                    <div className="car-icons">
                                        <div style={{ marginTop: "18px", marginBottom: "18px", display: "flex", justifyContent: "space-between", paddingLeft: "15px", paddingRight: "50px" }}>
                                            <div>
                                                <GiGearStick style={{ color: '#00a8f4', fontSize: '19px', marginRight: "6px" }} />
                                                <span style={{ color: '#9b9b9b', fontSize: "13px", fontWeight: "500" }}>Manual</span>
                                            </div>
                                            <div>
                                                <BsFillFuelPumpFill style={{ color: '#00a8f4', fontSize: '17px', marginRight: "6px" }} />
                                                <span style={{ color: '#9b9b9b', fontSize: "13px", fontWeight: "500" }}>Gas</span>
                                            </div>
                                            <div>
                                                <BsFillCarFrontFill style={{ color: '#00a8f4', fontSize: '22px', marginRight: "6px" }} />
                                                <span style={{ color: '#9b9b9b', fontSize: "13px", fontWeight: "500" }}>Standart</span>
                                            </div>
                                        </div>

                                    </div>
                                    <div className='car-rayting d-flex justify-content-beetween align-item-center p-2'>
                                        <div className='d-flex align-items-center ps-3'>
                                            <BiSolidStar color='#ffbf35' />
                                            <BiSolidStar color='#ffbf35' />
                                            <BiSolidStar color='#ffbf35' />
                                            <BiSolidStar color='#ffbf35' />
                                            <BiSolidStarHalf color='#ffbf35' />
                                            <span className='car-point'>
                                                4.8
                                            </span>


                                        </div>
                                        <div>
                                            <p style={{ textDecoration: "underline", marginLeft: "100px", fontSize: "14px", color: "#758493", marginTop: "10px", marginBottom: "0" }}>16 comments</p>
                                        </div>
                                        <div></div>
                                    </div>
                                </div>
                                <div>
                                    <div className="car-price">
                                        <div className='text-start'>
                                            <span>Total Amount (3 Days): </span>
                                            <BiInfoCircle color='#008dd4' style={{ fontSize: "20px" }} />
                                        </div>
                                        <div className='text-start d-flex justify-content-between align-items-center'>
                                            <span style={{ color: "#2ecc71" }}>Daily price : 41.77 $</span>
                                            <span style={{ color: "#4a4a4a", fontSize: "20px", fontWeight: "700", marginRight: '10px' }}>125.30 $</span>
                                        </div>
                                    </div>
                                    <div className='rent-btn'>
                                        Rent now!
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

export default Cars
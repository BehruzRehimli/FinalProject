import React from 'react'
import "./Detail.css"
import { IoArrowBackOutline } from "react-icons/io5"
import { Link } from "react-router-dom"
import { TiArrowDownThick, TiArrowUpThick } from "react-icons/ti"
import { BiSolidCar } from "react-icons/bi"
import { AiOutlineRight, AiOutlineInfoCircle } from "react-icons/ai"
import { MdHeadsetMic } from "react-icons/md"
import { BiSolidStar, BiSolidStarHalf } from "react-icons/bi"
import { BsCheck, BsFillFuelPumpFill, BsFillCarFrontFill } from 'react-icons/bs'
import { TbManualGearbox } from 'react-icons/tb'
import { GiKeyCard } from "react-icons/gi"


const Detail = () => {
    return (
        <div>
            <div className="top-detail">
                <div className="go-back-btn">
                    <span style={{ marginRight: "10px", paddingRight: "10px", borderRight: "1px solid #9b9b9b" }}>Back</span>
                    <IoArrowBackOutline style={{ fontSize: "20px" }} />
                </div>
            </div>
            <div className="my-container" style={{ margin: "100px auto" }}>
                <div className="road">
                    <div>
                        <span className='road-number'>1</span>
                        <span style={{ color: "#434444", fontSize: "18px", fontWeight: "700", marginLeft: "10px" }}>Vehicle Selection</span>
                    </div>
                    <div className='wizard-dot'>
                        <span className='line' />
                    </div>
                    <div>
                        <span className='road-number passive'>2</span>
                        <span style={{ color: "#979797", fontSize: "18px", fontWeight: "700", marginLeft: "10px" }}>Driver Information</span>
                    </div>
                    <div className='wizard-dot'>
                        <span className='line' />
                    </div>
                    <div>
                        <span className='road-number passive'>3</span>
                        <span style={{ color: "#979797", fontSize: "18px", fontWeight: "700", marginLeft: "10px" }}>Payment Information</span>
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
                    <div className="col-lg-8">
                        <div className='d-flex justify-content-between'>
                            <div className='text-start'>
                                <p style={{ color: "#4a4a4a", fontWeight: "700", fontSize: "24px", marginBottom: "0" }}>Fiat Egea</p>
                                <span style={{ textAlign: "start", color: "#9b9b9b" }}>or similar</span>
                            </div>
                            <div className='text-end d-flex align-items-center me-4'>
                                <BiSolidStar color='#ffbf35' />
                                <BiSolidStar color='#ffbf35' className='ms-1' />
                                <BiSolidStar color='#ffbf35' className='ms-1' />
                                <BiSolidStar color='#ffbf35' className='ms-1' />
                                <BiSolidStarHalf color='#ffbf35' className='ms-1' />
                                <span className='car-point'>
                                    4.8
                                </span>

                            </div>

                        </div>
                        <div className="free-cancel mt-4">
                            <div className='d-flex'>
                                <div className="radius">
                                    <BsCheck style={{ color: "#39b54a", fontSize: "20px" }} />
                                </div>
                                <span>FREE CANCELLATION</span>
                            </div>
                        </div>
                        <div>
                            <img style={{ height: "150px", alignSelf: "center" }} src="	https://static.yolcu360.com/thumbnails/fa/64/fa64b7bcfe65c804a860d91c9fbccf33.png" alt="car" />
                            <div className="car-icons mt-4" style={{ width: "60%", margin: "0 auto" }}>
                                <div style={{ marginTop: "18px", marginBottom: "18px", display: "flex", justifyContent: "space-between", paddingLeft: "15px", paddingRight: "50px" }}>
                                    <div>
                                        <TbManualGearbox style={{ color: '#00a8f4', fontSize: '25px', marginRight: "6px" }} />
                                        <span style={{ color: '#9b9b9b', fontSize: "15px", fontWeight: "400" }}>Manual</span>
                                    </div>
                                    <div>
                                        <BsFillFuelPumpFill style={{ color: '#00a8f4', fontSize: '21px', marginRight: "6px" }} />
                                        <span style={{ color: '#9b9b9b', fontSize: "15px", fontWeight: "400" }}>Gas/Diesel</span>
                                    </div>
                                    <div>
                                        <BsFillCarFrontFill style={{ color: '#00a8f4', fontSize: '25px', marginRight: "6px" }} />
                                        <span style={{ color: '#9b9b9b', fontSize: "15px", fontWeight: "400" }}>Standart</span>
                                    </div>
                                </div>

                            </div>

                        </div>
                        <div className=' detail-help mt-5' >
                            <div>
                                <AiOutlineInfoCircle style={{ color: "#2169aa", fontSize: "24px" }} />
                                <span style={{ color: "white", fontSize: "13px", marginLeft: "10px" }}>How to pick up your car? <b>Avis office</b></span>
                            </div>
                            <div>
                                <GiKeyCard style={{ color: "#2169aa", fontSize: "25px" }} />
                            </div>
                        </div>
                        <div className="info-office mt-5">
                            <p className='info-title'>Avis Office Information</p>
                            <div className='info-box'>
                                <div className="left">
                                    <p className="office-text-title">
                                        Address :
                                    </p>
                                    <p className="office-text-li">
                                        Ankara Yüksek Hızlı Tren Garı, Altındağ, Çankaya, Ankara
                                    </p>
                                    <p className="office-text-li">
                                        Ankara
                                    </p>
                                    <p className="office-text-title mt-5">
                                        Phone :
                                    </p>
                                    <p className="office-text-li">
                                        +(90) 5529576155
                                    </p>
                                </div>
                                <div className="right">
                                    <p className="office-text-title">
                                        Opening Hours :
                                    </p>
                                    <div className="d-flex justify-content-between mt-2">
                                        <p className="office-text-li">
                                            Monday
                                        </p>
                                        <p className="office-text-li">
                                            08:00 -19:00
                                        </p>
                                    </div>
                                    <div className="d-flex justify-content-between mt-2">
                                        <p className="office-text-li">
                                        Tuesday
                                        </p>
                                        <p className="office-text-li">
                                            08:00 -19:00
                                        </p>
                                    </div>                                    
                                    <div className="d-flex justify-content-between mt-2">
                                        <p className="office-text-li">
                                        Wednesday
                                        </p>
                                        <p className="office-text-li">
                                            08:00 -19:00
                                        </p>
                                    </div>                                    
                                    <div className="d-flex justify-content-between mt-2">
                                        <p className="office-text-li">
                                        Thursday
                                        </p>
                                        <p className="office-text-li">
                                            08:00 -19:00
                                        </p>
                                    </div>                                    
                                    <div className="d-flex justify-content-between mt-2">
                                        <p className="office-text-li">
                                        Friday
                                        </p>
                                        <p className="office-text-li">
                                            08:00 -19:00
                                        </p>
                                    </div>
                                    <div className="d-flex justify-content-between mt-2">
                                        <p className="office-text-li">
                                        Saturday
                                        </p>
                                        <p className="office-text-li">
                                            08:00 -19:00
                                        </p>
                                    </div>
                                    <div className="d-flex justify-content-between mt-2">
                                        <p className="office-text-li">
                                        Sunday
                                        </p>
                                        <p className="office-text-li">
                                            08:00 -19:00
                                        </p>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div className='col-lg-4'>
                        <div className="detail-sidebar">
                            <div className="price-date">
                                <div className="header">
                                    <div className="price">
                                        <p style={{ color: "#9b9b9b", fontSize: "14px", textAlign: "start", marginBottom: "0" }}>3 Daily price:</p>
                                        <p style={{ textAlign: "start", color: "#4a4a4a", fontWeight: "700", fontSize: "32px", marginBottom: "0" }}>145.05 $</p>
                                        <p style={{ textAlign: "start", color: "#2ecc71", fontWeight: "400", fontSize: "14px", marginBottom: "10px" }}>Daily price:48.35 $</p>
                                    </div>
                                </div>
                                <div className="pick-up-info">
                                    <div className="left" style={{ width: '50px', height: "50px" }}>
                                        <TiArrowDownThick style={{ fontSize: '25px', color: "#008dd4", position: "absolute", top: "0", left: "-6px" }} />
                                        <BiSolidCar style={{ fontSize: '30px', marginTop: "5px", color: "#888", opacity: "0.35", top: "0", position: "absolute", left: "3px" }} />
                                    </div>
                                    <div className="right d-flex justify-content-start">
                                        <div style={{ width: "50px" }}>
                                            <p style={{ maxWidth: "50px", textAlign: "start", fontSize: "12px", fontWeight: "700", color: "#008dd4" }}>Pick-Up Date</p>
                                        </div>
                                        <div className='ms-3'>
                                            <p style={{ marginBottom: "0", textAlign: "start", color: "#9b9b9b", fontSize: "13px", fontWeight: "600" }}>Istanbul-Sabiha Gokcen</p>
                                            <p style={{ marginBottom: "0", textAlign: "start", color: "#008dd4", fontWeight: "700", fontSize: "14px" }}>25.08.2023 - 10:00</p>
                                        </div>
                                    </div>
                                </div>
                                <div className="drop-off-info">
                                    <div className="left" style={{ width: '50px', height: "50px" }}>
                                        <TiArrowUpThick style={{ fontSize: '25px', color: "#ffa900", position: "absolute", top: "0", left: "-6px" }} />
                                        <BiSolidCar style={{ fontSize: '30px', marginTop: "5px", color: "#888", opacity: "0.35", top: "0", position: "absolute", left: "3px" }} />
                                    </div>
                                    <div className="right d-flex justify-content-start">
                                        <div style={{ width: "50px" }}>
                                            <p style={{ maxWidth: "50px", textAlign: "start", fontSize: "12px", fontWeight: "700", color: "#ffa900" }}>Drop-Off Date</p>
                                        </div>
                                        <div className='ms-3'>
                                            <p style={{ marginBottom: "0", textAlign: "start", color: "#9b9b9b", fontSize: "13px", fontWeight: "600" }}>Istanbul-Sabiha Gokcen</p>
                                            <p style={{ marginBottom: "0", textAlign: "start", color: "#ffa900", fontWeight: "700", fontSize: "14px" }}>28.08.2023 - 10:00</p>
                                        </div>
                                    </div>
                                </div>
                                <div style={{ backgroundColor: "#e8f5fa", padding: "13px 20px 13px 20px", border: "1px solid #b5ddef" }}>
                                    <p style={{ marginBottom: "0", textAlign: "start", color: "#008dd4", fontSize: "14px", fontWeight: "700", display: "flex", alignItems: "center", justifyContent: "space-between" }}>Your card will be charged:
                                        <span style={{ color: "#4a4a4a", fontSize: "18px", marginLeft: "20px" }}>149.11 $</span></p>
                                </div>
                                <div style={{ padding: "13px 20px 13px 20px", border: "1px solid #b5ddef", borderTop: "none" }}>
                                    <p style={{ marginBottom: "0", textAlign: "start", color: "#008dd4", fontSize: "14px", fontWeight: "700", display: "flex", alignItems: "center", justifyContent: "space-between" }}>Amount due at pickup:
                                        <span style={{ color: "#4a4a4a", fontSize: "18px", marginLeft: "20px" }}>0.00 $</span></p>
                                </div>
                                <div style={{ padding: "13px 20px 13px 20px", border: "1px solid #b5ddef", borderTop: "none" }}>
                                    <p style={{ marginBottom: "0", textAlign: "start", color: "#008dd4", fontSize: "14px", fontWeight: "700", display: "flex", alignItems: "center", justifyContent: "space-between" }}>Total Amount:
                                        <span style={{ color: "#4a4a4a", fontSize: "18px", marginLeft: "20px" }}>149.11 $</span></p>
                                    <div style={{ display: "flex", justifyContent: "space-between" }}>
                                        <span style={{ color: "#2ecc71", fontSize: "12px", marginLeft: "30px", fontWeight: "500" }}>
                                            Daily price :49,70 $
                                        </span>
                                        <span style={{ fontSize: "12px", fontWeight: "500", color: "#9b9b9b" }}>
                                            Price for 3 days
                                        </span>
                                    </div>
                                </div>
                                <div className="keep-go-btn">
                                    <button>
                                        Keep going!
                                    </button>
                                    <AiOutlineRight />
                                </div>

                            </div>
                            <div className="row mt-4">
                                <div className="col-3 ">
                                    <img style={{ width: "88px" }} src="	https://staticf.yolcu360.com/static/image/money-back@2x.png" alt="" />
                                </div>
                                <div className="col-9 ps-4">
                                    <p className='text-start' style={{ marginBottom: "0", marginTop: "5px", paddingBottom: "8px", fontSize: "14px", color: "#758493", borderBottom: "1px solid #e9e9e9" }}>Installment Options</p>
                                    <p className='text-start' style={{ marginBottom: "0", fontSize: "14px", color: "#758493", paddingTop: "5px" }}>We offer a 100% money-back guarantee</p>
                                </div>
                                <div className="detail-call-center">
                                    <MdHeadsetMic style={{ color: "#ffa900", fontSize: "60px" }} />
                                    <div className='ps-4'>
                                        <p style={{ fontWeight: "700", color: "#2169aa", fontSize: "20px", marginBottom: "0", marginTop: "5px" }}>DO YOU NEED HELP?</p>
                                        <p style={{ fontWeight: "700", color: "#ffa900", fontSize: "24px", textAlign: "start", marginBottom: "0" }}>+1 888 774 7471</p>
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
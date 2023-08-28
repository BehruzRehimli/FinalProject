import React, { useEffect, useState } from 'react'
import "./Detail.css"
import { IoArrowBackOutline } from "react-icons/io5"
import { Link, useParams } from "react-router-dom"
import { TiArrowDownThick, TiArrowUpThick } from "react-icons/ti"
import { BiSolidCar } from "react-icons/bi"
import { AiOutlineRight } from "react-icons/ai"
import { MdHeadsetMic } from "react-icons/md"
import { BiSolidStar, BiSolidStarHalf } from "react-icons/bi"
import { BsCheck, BsFillFuelPumpFill, BsFillCarFrontFill } from 'react-icons/bs'
import { TbManualGearbox } from 'react-icons/tb'
import { GiKeyCard, GiFlatTire } from "react-icons/gi"
import { LiaFileContractSolid } from "react-icons/lia"
import { IoMdTimer } from "react-icons/io"
import { FaUserNurse } from "react-icons/fa"
import { AiOutlineInfoCircle } from "react-icons/ai"
import { MdOutlineChildFriendly } from "react-icons/md"
import axios from 'axios'
import { Field, Form, Formik } from 'formik'
import Text from '../../components/Form/Text'
import Select from '../../components/Form/Select'

const Detail = () => {
    const { id } = useParams();
    const [extensions, setExtensions] = useState({
        extra1000: false,
        extra500: false,
        extra2000: false,
        tires: false,
        driver: false,
        child: false
    })
    const [car, setCar] = useState({
        car: {},
        loadCar: false
    })

    useEffect(() => {
        const getCar = async () => {
            var data = await axios.get(`https://localhost:7079/api/Cars/${id}`)
            setCar(prev => { return { ...prev, car: data.data, loadCar: true } })
        }
        getCar();
    }, [])

    const CheckExtra500Handler = (e) => {
        const data = e.target.checked
        setExtensions(previous => { return { ...previous, extra500: data } })
    }

    const CheckExtra1000Handler = (e) => {
        const data = e.target.checked
        setExtensions(previous => { return { ...previous, extra1000: data } })
    }

    const CheckExtra2000Handler = (e) => {
        const data = e.target.checked
        setExtensions(previous => { return { ...previous, extra2000: data } })
    }

    const CheckTiresHandler = (e) => {
        const data = e.target.checked
        setExtensions(previous => { return { ...previous, tires: data } })
    }

    const CheckChildHandler = (e) => {
        const data = e.target.checked
        setExtensions(previous => { return { ...previous, child: data } })
    }

    const CheckDriverHandler = (e) => {
        const data = e.target.checked
        setExtensions(previous => { return { ...previous, driver: data } })
    }

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
                    {
                        car.loadCar ? <Link to={`/detail/${id}`}>{car.car.name}</Link> : null
                    }
                </div>
                <div className="row mt-3">
                    <div className="col-lg-8">
                        <div className='d-flex justify-content-between'>
                            <div className='text-start'>
                                {
                                    car.loadCar ?
                                        <p style={{ color: "#4a4a4a", fontWeight: "700", fontSize: "24px", marginBottom: "0" }}>{car.car.name}</p>
                                        : null
                                }
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
                            {
                                car.loadCar ?
                                    car.car.isFreeCancelation ?
                                        <div className='d-flex'>
                                            <div className="radius">
                                                <BsCheck style={{ color: "#39b54a", fontSize: "20px" }} />
                                            </div>
                                            <span>FREE CANCELLATION</span>
                                        </div> : null : null

                            }
                        </div>
                        {
                            car.loadCar ?
                                <div>
                                    <img style={{ height: "150px", alignSelf: "center" }} src={car.car.imageName} alt="car" />
                                    <div className="car-icons mt-4" style={{ width: "60%", margin: "0 auto" }}>
                                        <div style={{ marginTop: "18px", marginBottom: "18px", display: "flex", justifyContent: "space-between", paddingLeft: "15px", paddingRight: "50px" }}>
                                            <div>
                                                <TbManualGearbox style={{ color: '#00a8f4', fontSize: '25px', marginRight: "6px" }} />
                                                <span style={{ color: '#9b9b9b', fontSize: "15px", fontWeight: "400" }}>{car.car.transmission === 1 ? "Automatic" : "Manual"}</span>
                                            </div>
                                            <div>
                                                <BsFillFuelPumpFill style={{ color: '#00a8f4', fontSize: '21px', marginRight: "6px" }} />
                                                <span style={{ color: '#9b9b9b', fontSize: "15px", fontWeight: "400" }}>{car.car.fuel === 1 ? "Diesel" : car.car.fuel === 2 ? 'Gas-Diesel' : car.car.fuel === 3 ? "Electric" : "Gas"}</span>
                                            </div>
                                            <div>
                                                <BsFillCarFrontFill style={{ color: '#00a8f4', fontSize: '25px', marginRight: "6px" }} />
                                                <span style={{ color: '#9b9b9b', fontSize: "15px", fontWeight: "400" }}>{car.car.type.name}</span>
                                            </div>
                                        </div>

                                    </div>

                                </div> : null

                        }
                        <div className=' detail-help mt-5' >
                            <div>
                                <AiOutlineInfoCircle style={{ color: "#2169aa", fontSize: "24px" }} />
                                <span style={{ color: "white", fontSize: "13px", marginLeft: "10px" }}>How to pick up your car? <b>Avis office</b></span>
                            </div>
                            <div>
                                <GiKeyCard style={{ color: "#2169aa", fontSize: "25px" }} />
                            </div>
                        </div>
                        {
                            car.loadCar ?
                                <div className="info-office mt-5">
                                    <p className='info-title'>Avis Office Information</p>
                                    <div className='info-box'>
                                        <div className="left">
                                            <p className="office-text-title">
                                                Address :
                                            </p>
                                            <p className="office-text-li">
                                                {car.car.office.address}
                                            </p>
                                            <p className="office-text-li">
                                                {car.car.office.city.name}
                                            </p>
                                            <p className="office-text-title mt-5">
                                                Phone :
                                            </p>
                                            <p className="office-text-li">
                                                {car.car.office.phone}
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
                                                    {car.car.office.openTimes}
                                                </p>
                                            </div>
                                            <div className="d-flex justify-content-between mt-2">
                                                <p className="office-text-li">
                                                    Tuesday
                                                </p>
                                                <p className="office-text-li">
                                                    {car.car.office.openTimes}
                                                </p>
                                            </div>
                                            <div className="d-flex justify-content-between mt-2">
                                                <p className="office-text-li">
                                                    Wednesday
                                                </p>
                                                <p className="office-text-li">
                                                    {car.car.office.openTimes}
                                                </p>
                                            </div>
                                            <div className="d-flex justify-content-between mt-2">
                                                <p className="office-text-li">
                                                    Thursday
                                                </p>
                                                <p className="office-text-li">
                                                    {car.car.office.openTimes}
                                                </p>
                                            </div>
                                            <div className="d-flex justify-content-between mt-2">
                                                <p className="office-text-li">
                                                    Friday
                                                </p>
                                                <p className="office-text-li">
                                                    {car.car.office.openTimes}
                                                </p>
                                            </div>
                                            <div className="d-flex justify-content-between mt-2">
                                                <p className="office-text-li">
                                                    Saturday
                                                </p>
                                                <p className="office-text-li">
                                                    {car.car.office.openTimes}
                                                </p>
                                            </div>
                                            <div className="d-flex justify-content-between mt-2">
                                                <p className="office-text-li">
                                                    Sunday
                                                </p>
                                                <p className="office-text-li">
                                                    {car.car.office.openTimes}
                                                </p>
                                            </div>
                                        </div>
                                    </div>
                                </div> : null

                        }
                        <div className="info-office mt-3">
                            <p className='info-title'>Rental Conditions</p>
                            <div className="row">
                                <div className='post-box ms-3'>
                                    <LiaFileContractSolid style={{ color: "#b7d1ea", fontSize: "60px" }} />
                                    <p className='office-text-li text-center mt-4'>Deposit</p>
                                    {
                                        car.loadCar ?
                                            <p className='detail-element mt-3'>{car.car.depozitPrice} $</p>
                                            : null
                                    }
                                </div>
                                <div className='post-box ms-3'>
                                    <IoMdTimer style={{ color: "#b7d1ea", fontSize: "60px" }} />
                                    <p className='office-text-li text-center mt-4'>Total Millage Limit</p>
                                    {
                                        car.loadCar ?
                                            <p className='detail-element mt-3'>{car.car.totalMillage} km</p>
                                            : null
                                    }
                                </div>

                            </div>
                            <li style={{ textAlign: "left", listStyleType: "revert", marginTop: "40px", color: "#758493", fontSize: "14px" }}>
                                When you arrive the office, a deposit fee will be collected from your <b style={{ color: "#00a8f4" }}>credit card issued in your name</b> by supplier company.
                            </li>

                            <div className='rental-condit'>
                                <a href="">Click for the rental contract of the company Avis.</a>
                            </div>
                            <p className='info-title mt-3'>Driver Requirements</p>
                            <div className="row g-3 pe-3">
                                <div className='post-box ms-3'>
                                    <LiaFileContractSolid style={{ color: "#b7d1ea", fontSize: "60px" }} />
                                    <p className='office-text-li text-center mt-4'>Min. Driver’s Age</p>
                                    {
                                        car.loadCar ?
                                            <p className='detail-element mt-3'>{car.car.minDriverAge}</p>
                                            : null
                                    }
                                </div>
                                {
                                    car.loadCar ?
                                        car.car.minYoungDriverAge > 0 ?
                                            <div className='post-box ms-3'>
                                                <LiaFileContractSolid style={{ color: "#b7d1ea", fontSize: "60px" }} />
                                                <p className='office-text-li text-center mt-4'>Min. Young Driver’s Age</p>
                                                <p className='detail-element mt-3'>{car.car.minYoungDriverAge}</p>
                                            </div> : null : null
                                }

                                <div className='post-box ms-3'>
                                    <IoMdTimer style={{ color: "#b7d1ea", fontSize: "60px" }} />
                                    <p className='office-text-li text-center mt-4'>Min. Driver's License Year</p>
                                    {
                                        car.loadCar ?
                                            <p className='detail-element mt-2'>{car.car.minDriverLisanseYear}</p>
                                            : null
                                    }
                                </div>
                                {
                                    car.loadCar ?
                                        car.car.minYoungDriverLisanseYear > 0 ?
                                            <div className='post-box ms-3'>
                                                <LiaFileContractSolid style={{ color: "#b7d1ea", fontSize: "60px" }} />
                                                <p className='office-text-li text-center mt-4'>Min. Young Driver’s License</p>
                                                <p className='detail-element mt-2'>{car.car.minYoungDriverLisanseYear}</p>
                                            </div> : null : null
                                }
                            </div>
                            <li style={{ textAlign: "left", listStyleType: "revert", marginTop: "40px", color: "#758493", fontSize: "14px" }}>
                                In order to receive the car, you must have <b style={{ color: "#00a8f4" }}>your ID, driver's license</b> and a <b style={{ color: "#00a8f4" }}>credit card with your name, surname and credit card number</b> on it.
                            </li>

                        </div>
                        <p className='info-title mt-3'>Driver Requirements</p>
                        <p className='header-requirements'>Extra Products Charged on Delivery</p>
                        <div className="row">
                            <div className="col-lg-6 col-md-12 col-sm-12">
                                <div className={extensions.extra1000 ? "requirement-cards active" : "requirement-cards"}>
                                    <IoMdTimer style={{ color: "#ffa900", fontSize: "60px" }} />
                                    <div className='me-5'>
                                        <p className='title'>Extra 1000 km</p>
                                        <p className='price-daily'>12,89 $ x3 days</p>
                                        <p className='price-total'>38,68 $</p>
                                    </div>
                                    <label className='check-div 1'>

                                        <input onClick={CheckExtra1000Handler} className='check-input' id='cb1' type="checkbox" />
                                        <span className='check'>
                                            <BsCheck style={{ color: "white", fontSize: "32px" }} />
                                        </span>

                                    </label>
                                </div>
                            </div>
                            <div className="col-lg-6 col-md-12 col-sm-12">
                                <div className={extensions.extra500 ? "requirement-cards active" : "requirement-cards"}>
                                    <IoMdTimer style={{ color: "#ffa900", fontSize: "60px" }} />
                                    <div className='me-5'>
                                        <p className='title'>Extra 500 km</p>
                                        <p className='price-daily'>6.43 $ x3 days</p>
                                        <p className='price-total'>19.29 $</p>
                                    </div>
                                    <label className='check-div second'>

                                        <input onClick={CheckExtra500Handler} className='check-input second' id='cb1' type="checkbox" />
                                        <span className='check second'>
                                            <BsCheck style={{ color: "white", fontSize: "32px" }} />
                                        </span>

                                    </label>
                                </div>

                            </div>
                            <div className="col-lg-6 col-md-12 col-sm-12">
                                <div className={extensions.extra2000 ? "requirement-cards active" : "requirement-cards"}>
                                    <IoMdTimer style={{ color: "#ffa900", fontSize: "60px" }} />
                                    <div className='me-5'>
                                        <p className='title'>Extra 2000 km</p>
                                        <p className='price-daily'>25.72 $ x3 days</p>
                                        <p className='price-total'>77.16 $</p>
                                    </div>
                                    <label className='check-div 3'>

                                        <input onClick={CheckExtra2000Handler} className='check-input' id='cb1' type="checkbox" />
                                        <span className='check'>
                                            <BsCheck style={{ color: "white", fontSize: "32px" }} />
                                        </span>

                                    </label>
                                </div>
                            </div>
                            <div className="col-lg-6 col-md-12 col-sm-12">
                                <div className={extensions.tires ? "requirement-cards active" : "requirement-cards"}>
                                    <GiFlatTire style={{ color: "#ffa900", fontSize: "55px" }} />
                                    <div className='me-5'>
                                        <p className='title'>Winter Tires</p>
                                        <p className='price-daily'>3.47 $ x3 days</p>
                                        <p className='price-total'>10.41 $</p>
                                    </div>
                                    <label className='check-div 4'>

                                        <input onChange={CheckTiresHandler} className='check-input' id='cb1' type="checkbox" />
                                        <span className='check'>
                                            <BsCheck style={{ color: "white", fontSize: "32px" }} />
                                        </span>

                                    </label>
                                </div>
                            </div>
                            <div className="col-lg-6 col-md-12 col-sm-12">
                                <div className={extensions.driver ? "requirement-cards active" : "requirement-cards"}>
                                    <FaUserNurse style={{ color: "#ffa900", fontSize: "55px" }} />
                                    <div className='me-5'>
                                        <p className='title'>Driver</p>
                                        <p className='price-daily'>3.47 $ x3 days</p>
                                        <p className='price-total'>10.41 $</p>
                                    </div>
                                    <label className='check-div 5'>

                                        <input onClick={CheckDriverHandler} className='check-input' id='cb1' type="checkbox" />
                                        <span className='check'>
                                            <BsCheck style={{ color: "white", fontSize: "32px" }} />
                                        </span>

                                    </label>
                                </div>
                            </div>
                            <div className="col-lg-6 col-md-12 col-sm-12">
                                <div className={extensions.child ? "requirement-cards active" : "requirement-cards"}>
                                    <MdOutlineChildFriendly style={{ color: "#ffa900", fontSize: "55px" }} />
                                    <div className='me-5'>
                                        <p className='title'>Child Seat</p>
                                        <p className='price-daily'>4.98 $ x3 days</p>
                                        <p className='price-total'>14.93 $</p>
                                    </div>
                                    <label className='check-div 6'>

                                        <input onClick={CheckChildHandler} className='check-input' id='cb1' type="checkbox" />
                                        <span className='check'>
                                            <BsCheck style={{ color: "white", fontSize: "32px" }} />
                                        </span>

                                    </label>
                                </div>
                            </div>

                        </div>
                        <div className='send-comment mt-4 mb-5'>
                            <p className='info-title text-center'>
                                Send your review
                            </p>
                            <Formik initialValues={{
                                carId: car.car.id,
                                comment: '',
                                cleannesPoint: 0,
                                personelPoint: 0,
                                speedPoint: 0
                            }} onSubmit={values => {
                                console.log(values);
                            }}>
                                {({ values }) => (
                                    <Form>
                                        <Text name="comment" spClass="info-title" label={"Write Your Comment"} /><br />
                                        <Field type="hidden" name='carId' />
                                        <div className="row">
                                            <div className="col-lg-4 col-md-12 col-12">
                                                <Select name="cleanPoint" label={"Select point for clear"} spClass="info-title" options={[1, 2, 3, 4, 5]} />
                                            </div>
                                            <div className="col-lg-4 col-md-12 col-12">
                                                <Select name="officePoint" label={"Select point for office"} spClass="info-title" options={[1, 2, 3, 4, 5]} />

                                            </div>
                                            <div className="col-lg-4 col-md-12 col-12">
                                                <Select name="speedPoint" label={"Select point for speed"} spClass="info-title" options={[1, 2, 3, 4, 5]} />

                                            </div>
                                        </div>
                                        <button type='submit' style={{ backgroundColor: "#ffa900",color:"#fff",fontWeight:"bolder", outline: "none" }} className='btn form-control mt-2'>Submit</button>
                                    </Form>
                                )}
                            </Formik>
                        </div>

                        <div className="reviews mt-4">
                            <p className="info-title text-center mt-4">Reviews</p>
                            <div className="all-reviews">
                                <div className="top-all-reviews">
                                    <div className="left">
                                        <BiSolidStar color='#ffbf35' className='ms-3' />
                                        <BiSolidStar color='#ffbf35' className='ms-2' />
                                        <BiSolidStar color='#ffbf35' className='ms-2' />
                                        <BiSolidStar color='#ffbf35' className='ms-2' />
                                        <BiSolidStarHalf color='#ffbf35' className='ms-2' />
                                        <span className='car-point ms-3'>
                                            4.8
                                        </span>
                                        <span style={{ fontSize: "12px", color: "#979797", textDecoration: "underline", marginLeft: "20px", fontWeight: "700" }}>
                                            214 comment
                                        </span>
                                    </div>
                                    <div className='right'>
                                        <span style={{ fontSize: "12px", color: "#979797" }}>
                                            AVIS -Istanbul-Sabiha Gokcen Airport Office
                                        </span>
                                    </div>
                                </div>
                                <div className="car-points">
                                    <div className='d-flex align-items-center'>
                                        <span>Cleannes</span>
                                        <div className='point-size'>
                                            <div></div>
                                        </div>
                                    </div>
                                    <div className='d-flex align-items-center'>
                                        <span>Office Personnel</span>
                                        <div className='point-size'>
                                            <div></div>
                                        </div>
                                    </div>
                                    <div className='d-flex align-items-center'>
                                        <span>Speedy Delivery</span>
                                        <div className='point-size'>
                                            <div></div>
                                        </div>
                                    </div>
                                </div>
                                <div className='users-comments'>
                                    <div className="user-comment">
                                        <div>
                                            <div className='d-flex align-items-center'>
                                                <div className="user-name-div">
                                                    S.G
                                                </div>
                                                <div>
                                                    <BiSolidStar className='ms-2' color='#ffa900' />
                                                    <BiSolidStar className='ms-1' color='#ffa900' />
                                                    <BiSolidStar className='ms-1' color='#ffa900' />
                                                    <BiSolidStar className='ms-1' color='#ffa900' />
                                                    <BiSolidStar className='ms-1' color='#ffa900' />
                                                    <span style={{ marginLeft: "15px", fontWeight: "600", color: "#384959" }}>5.0</span>

                                                </div>
                                            </div>
                                            <span className='review-time'>7 days ago</span>
                                        </div>
                                        <p className='user-comment-text'>Herşey çok güzeldi taki aracın klimasını acana kadar kilima hiç soutmuyor Du tek sıkıntı oydu başkada Bi sıkıntı yaşamadım</p>
                                    </div>
                                    <div className="user-comment">
                                        <div>
                                            <div className='d-flex align-items-center'>
                                                <div className="user-name-div">
                                                    S.G
                                                </div>
                                                <div>
                                                    <BiSolidStar className='ms-2' color='#ffa900' />
                                                    <BiSolidStar className='ms-1' color='#ffa900' />
                                                    <BiSolidStar className='ms-1' color='#ffa900' />
                                                    <BiSolidStar className='ms-1' color='#ffa900' />
                                                    <BiSolidStar className='ms-1' color='#ffa900' />
                                                    <span style={{ marginLeft: "15px", fontWeight: "600", color: "#384959" }}>5.0</span>

                                                </div>
                                            </div>
                                            <span className='review-time'>7 days ago</span>
                                        </div>
                                        <p className='user-comment-text'>Herşey çok güzeldi taki aracın klimasını acana kadar kilima hiç soutmuyor Du tek sıkıntı oydu başkada Bi sıkıntı yaşamadım</p>
                                    </div>
                                    <div className="user-comment">
                                        <div>
                                            <div className='d-flex align-items-center'>
                                                <div className="user-name-div">
                                                    S.G
                                                </div>
                                                <div>
                                                    <BiSolidStar className='ms-2' color='#ffa900' />
                                                    <BiSolidStar className='ms-1' color='#ffa900' />
                                                    <BiSolidStar className='ms-1' color='#ffa900' />
                                                    <BiSolidStar className='ms-1' color='#ffa900' />
                                                    <BiSolidStar className='ms-1' color='#ffa900' />
                                                    <span style={{ marginLeft: "15px", fontWeight: "600", color: "#384959" }}>5.0</span>

                                                </div>
                                            </div>
                                            <span className='review-time'>7 days ago</span>
                                        </div>
                                        <p className='user-comment-text'>Herşey çok güzeldi taki aracın klimasını acana kadar kilima hiç soutmuyor Du tek sıkıntı oydu başkada Bi sıkıntı yaşamadım</p>
                                    </div>
                                    <div className="user-comment">
                                        <div>
                                            <div className='d-flex align-items-center'>
                                                <div className="user-name-div">
                                                    S.G
                                                </div>
                                                <div>
                                                    <BiSolidStar className='ms-2' color='#ffa900' />
                                                    <BiSolidStar className='ms-1' color='#ffa900' />
                                                    <BiSolidStar className='ms-1' color='#ffa900' />
                                                    <BiSolidStar className='ms-1' color='#ffa900' />
                                                    <BiSolidStar className='ms-1' color='#ffa900' />
                                                    <span style={{ marginLeft: "15px", fontWeight: "600", color: "#384959" }}>5.0</span>

                                                </div>
                                            </div>
                                            <span className='review-time'>7 days ago</span>
                                        </div>
                                        <p className='user-comment-text'>Herşey çok güzeldi taki aracın klimasını acana kadar kilima hiç soutmuyor Du tek sıkıntı oydu başkada Bi sıkıntı yaşamadım</p>
                                    </div>

                                </div>
                            </div>
                        </div>
                    </div>
                    <div className='col-lg-4'>
                        <div className="detail-sidebar">
                            {
                                car.loadCar ?
                                    <div className="price-date">
                                        <div className="header">
                                            <div className="price">
                                                <p style={{ color: "#9b9b9b", fontSize: "14px", textAlign: "start", marginBottom: "0" }}>3 Daily price:</p>
                                                <p style={{ textAlign: "start", color: "#4a4a4a", fontWeight: "700", fontSize: "32px", marginBottom: "0" }}>{(car.car.priceDaily * 3).toFixed(2)} $</p>
                                                <p style={{ textAlign: "start", color: "#2ecc71", fontWeight: "400", fontSize: "14px", marginBottom: "10px" }}>Daily price:{car.car.priceDaily} $</p>
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
                                                    <p style={{ marginBottom: "0", textAlign: "start", color: "#9b9b9b", fontSize: "13px", fontWeight: "600" }}>{car.car.office.name}</p>
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
                                                    <p style={{ marginBottom: "0", textAlign: "start", color: "#9b9b9b", fontSize: "13px", fontWeight: "600" }}>{car.car.office.name}</p>
                                                    <p style={{ marginBottom: "0", textAlign: "start", color: "#ffa900", fontWeight: "700", fontSize: "14px" }}>28.08.2023 - 10:00</p>
                                                </div>
                                            </div>
                                        </div>
                                        <div style={{ backgroundColor: "#e8f5fa", padding: "13px 20px 13px 20px", border: "1px solid #b5ddef" }}>
                                            <p style={{ marginBottom: "0", textAlign: "start", color: "#008dd4", fontSize: "14px", fontWeight: "700", display: "flex", alignItems: "center", justifyContent: "space-between" }}>Your card will be charged:
                                                <span style={{ color: "#4a4a4a", fontSize: "18px", marginLeft: "20px" }}>{(car.car.priceDaily * 3).toFixed(2)} $</span></p>
                                        </div>
                                        <div style={{ padding: "13px 20px 13px 20px", border: "1px solid #b5ddef", borderTop: "none" }}>
                                            <p style={{ marginBottom: "0", textAlign: "start", color: "#008dd4", fontSize: "14px", fontWeight: "700", display: "flex", alignItems: "center", justifyContent: "space-between" }}>Amount due at pickup:
                                                <span style={{ color: "#4a4a4a", fontSize: "18px", marginLeft: "20px" }}>0.00 $</span></p>
                                        </div>
                                        <div style={{ padding: "13px 20px 13px 20px", border: "1px solid #b5ddef", borderTop: "none" }}>
                                            <p style={{ marginBottom: "0", textAlign: "start", color: "#008dd4", fontSize: "14px", fontWeight: "700", display: "flex", alignItems: "center", justifyContent: "space-between" }}>Total Amount:
                                                <span style={{ color: "#4a4a4a", fontSize: "18px", marginLeft: "20px" }}>{(car.car.priceDaily * 3).toFixed(2)} $</span></p>
                                            <div style={{ display: "flex", justifyContent: "space-between" }}>
                                                <span style={{ color: "#2ecc71", fontSize: "12px", marginLeft: "30px", fontWeight: "500" }}>
                                                    Daily price :{car.car.priceDaily} $
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

                                    </div> : null

                            }
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
import React from 'react'
import { BiSolidStar, BiSolidStarHalf } from "react-icons/bi"
import { BsCheck, BsFillFuelPumpFill, BsFillCarFrontFill } from 'react-icons/bs'
import { TbManualGearbox } from 'react-icons/tb'
import { GiKeyCard, GiFlatTire } from "react-icons/gi"
import { LiaFileContractSolid } from "react-icons/lia"
import { IoMdTimer } from "react-icons/io"
import { FaUserNurse } from "react-icons/fa"
import { AiOutlineInfoCircle } from "react-icons/ai"
import { MdOutlineChildFriendly } from "react-icons/md"
import { Field, Form, Formik } from 'formik'
import Text from '../../components/Form/Text'
import Select from '../../components/Form/Select'
import { useParams,useNavigate } from 'react-router-dom'
import { useState } from 'react'
import axios from 'axios'
import { useSelector,useDispatch } from 'react-redux'
import { useEffect } from 'react'
import { setExtentios } from '../../control/rentSlice'




const CarDetail = (props) => {

    const {id}= useParams();

    const dispatch=useDispatch();

    const [car, setCar] = useState({
        car: {},
        loadCar: false
    })

    const navigate=useNavigate();


    const [extensions, setExtensions] = useState({
        extra1000: false,
        extra500: false,
        extra2000: false,
        tires: false,
        driver: false,
        child: false
    })

    const [userComment, setUserCommnet] = useState(false)
    const { username, isLogin, token } = useSelector(store => store.login)
    const { pickUpDate,dropOffDate} = useSelector(store => store.rent)

    var day=Math.ceil((new Date(dropOffDate)-new Date(pickUpDate))/86400000)



    const CheckExtra500Handler = (e) => {
        const data = e.target.checked;
        dispatch(setExtentios(2))  
        setExtensions(previous => { return { ...previous, extra500: data } })
    }

    const CheckExtra1000Handler = (e) => {
        const data = e.target.checked;
        dispatch(setExtentios(1))  

        setExtensions(previous => { return { ...previous, extra1000: data } })
    }

    const CheckExtra2000Handler = (e) => {
        const data = e.target.checked;
        dispatch(setExtentios(3))  

        setExtensions(previous => { return { ...previous, extra2000: data } })
    }

    const CheckTiresHandler = (e) => {
        const data = e.target.checked;
        dispatch(setExtentios(4))  

        setExtensions(previous => { return { ...previous, tires: data } })
    }

    const CheckChildHandler = (e) => {
        const data = e.target.checked;
        dispatch(setExtentios(6))  

        setExtensions(previous => { return { ...previous, child: data } })
    }

    const CheckDriverHandler = (e) => {
        const data = e.target.checked;

        setExtensions(previous => { return { ...previous, driver: data } })
        dispatch(setExtentios(5))  
    }


    

    useEffect(()=>{
        const getCar = async () => {
            try {
                var data = await axios.get(`https://localhost:7079/api/Cars/${id}`)
                setCar(prev => { return { ...prev, car: data.data, loadCar: true } })
                var review = data.data.reviews.find(x => x.user.username = username)
                if (review) {
                    setUserCommnet(true)
                }
            } catch (error) {
                navigate("/error")
            }
        }
        getCar();
    },[])
    return (
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
                    <a href="#">Click for the rental contract of the company Avis.</a>
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
                            <p className='price-daily'>12,89 $ x{day} days</p>
                            <p className='price-total'>{(12.89* day).toFixed(2)} $</p>
                        </div>
                        <label className='check-div 1'>

                            <input onClick={CheckExtra1000Handler} className='check-input' id='1' type="checkbox" />
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
                            <p className='price-daily'>6.43 $ x{day} days</p>
                            <p className='price-total'>{(6.43* day).toFixed(2)} $</p>
                        </div>
                        <label className='check-div second'>

                            <input onClick={CheckExtra500Handler} className='check-input second' id='2' type="checkbox" />
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
                            <p className='price-daily'>25.72 $ x{day} days</p>
                            <p className='price-total'>{(25.72* day).toFixed(2)} $</p>
                        </div>
                        <label className='check-div 3'>

                            <input onClick={CheckExtra2000Handler} className='check-input' id='3' type="checkbox" />
                            <span className='check'>
                                <BsCheck style={{ color: "white", fontSize: "32px" }} />
                            </span>

                        </label>
                    </div>
                </div>
                <div className="col-lg-6 col-md-12 col-sm-12" >
                    <div className={extensions.tires ? "requirement-cards active" : "requirement-cards"}>
                        <GiFlatTire style={{ color: "#ffa900", fontSize: "55px" }} />
                        <div className='me-5'>
                            <p className='title'>Winter Tires</p>
                            <p className='price-daily'>3.47 $ x{day} days</p>
                            <p className='price-total'>{(3.47* day).toFixed(2)} $</p>
                        </div>
                        <label className='check-div 4'>

                            <input onChange={CheckTiresHandler} className='check-input' id='4' type="checkbox" />
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
                            <p className='price-daily'>3.47 $ x{day} days</p>
                            <p className='price-total'>{(3.47* day).toFixed(2)} $</p>
                        </div>
                        <label className='check-div 5'>

                            <input onClick={CheckDriverHandler} className='check-input' id='5' type="checkbox" />
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
                            <p className='price-daily'>4.98 $ x{day} days</p>
                            <p className='price-total'>{(4.98* day).toFixed(2)} $</p>
                        </div>
                        <label className='check-div 6'>

                            <input onClick={CheckChildHandler} className='check-input' id='6' type="checkbox" />
                            <span className='check'>
                                <BsCheck style={{ color: "white", fontSize: "32px" }} />
                            </span>

                        </label>
                    </div>
                </div>

            </div>
            {
                isLogin ?
                    !userComment ?
                        <div className='send-comment mt-4 mb-5'>
                            <p className='info-title text-center'>
                                Send your review
                            </p>
                            <Formik initialValues={{
                                comment: '',
                                personelPoint: 0,
                                speedPoint: 0,
                                cleannesPoint: 0,
                                carId: car.id,
                            }} onSubmit={async (values) => {
                                const data = await axios.post('https://localhost:7079/api/Reviews', values, { headers: { "Authorization": `Bearer ${token}` } })
                                setUserCommnet(true)
                            }}>
                                {({ values }) => (
                                    <Form>
                                        <Text name="comment" spClass="info-title" label={"Write Your Comment"} /><br />
                                        <Field type="hidden" value={car.id} name='carId' />
                                        <div className="row">
                                            <div className="col-lg-4 col-md-12 col-12">
                                                <Select name="cleannesPoint" label={"Select point for clear"} spClass="info-title" options={[1, 2, 3, 4, 5]} />
                                            </div>
                                            <div className="col-lg-4 col-md-12 col-12">
                                                <Select name="personelPoint" label={"Select point for office"} spClass="info-title" options={[1, 2, 3, 4, 5]} />

                                            </div>
                                            <div className="col-lg-4 col-md-12 col-12">
                                                <Select name="speedPoint" label={"Select point for speed"} spClass="info-title" options={[1, 2, 3, 4, 5]} />

                                            </div>
                                        </div>
                                        <button type='submit' style={{ backgroundColor: "#ffa900", color: "#fff", fontWeight: "bolder", outline: "none" }} className='btn form-control mt-2'>Submit</button>
                                    </Form>
                                )}
                            </Formik>
                        </div> :
                        <div className='rental-condit' >
                            <a href="#" style={{ textDecoration: "none" }}>You already share your review about this car.</a>
                        </div> :
                    <div className='rental-condit'>
                        <a href="#" style={{ textDecoration: "none" }}>If you want to share your reviews about this car, first you should login.</a>
                    </div>

            }
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
    )
}

export default CarDetail
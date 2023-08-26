import React, { useEffect, useState } from 'react'
import { useParams, Link } from 'react-router-dom'
import "./Cars.css"
import { FaAngleRight, FaChevronDown, FaChevronUp } from "react-icons/fa"
import { PiArrowsDownUpBold } from "react-icons/pi"
import { BsCheck, BsFillFuelPumpFill, BsFillCarFrontFill } from "react-icons/bs"
import { BiInfoCircle } from "react-icons/bi"
import { GiGearStick } from 'react-icons/gi'
import { BiSolidStar, BiSolidStarHalf } from 'react-icons/bi'
import axios from 'axios'

const Cars = () => {
    const { id } = useParams();
    const [cars, setCars] = useState({
        cars: [],
        loadCars: false,
        office: {},
        loadOffice: false,
        loadBrand: null,
        brands: [],
        loadModel: false,
        models: [],
        loadType: false,
        types: [],
        loadTrans: false,
        trans: [],
        loadFuel: false,
        fuels: [],
    });

    const [tab, setTab] = useState({
        transmission: false,
        fuel: false,
    })

    var fuels = [{ id: 1, name: "Diesel", count: 0 }, { id: 2, name: "Gas-Diesel", count: 0 },{ id: 3, name: "Electric", count: 0 },{ id: 4, name: "Gas", count: 0 }]
    const getFuels = () => {
        cars.cars.forEach(x => {
            if (x.fuelType === 1) {
                fuels[0].count++
            }
            else if (x.fuelType === 2) {
                fuels[1].count++
            }
            else if (x.fuelType === 3) {
                fuels[2].count++
            }            
            else if (x.fuelType === 4) {
                fuels[3].count++
            }
        });
        setCars(prev => { return { ...prev, fuels: fuels, loadFuel: true } })

    }



    var trans = [{ id: 1, name: "Authomatic", count: 0 }, { id: 2, name: "Manual", count: 0 }]
    const getTrans = () => {
        cars.cars.forEach(x => {
            if (x.transmission === 1) {
                trans[0].count++
            }
            else if (x.transmission === 2) {
                trans[1].count++
            }
        });
        setCars(prev => { return { ...prev, trans: trans, loadTrans: true } })

    }

    var types = []
    const getType = () => {
        types = []
        cars.cars.forEach(x => {
            if (!types.find(b => b.name == x.type.name)) {
                types.push({ id: x.type.id, name: x.type.name, count: 1 })
            }
            else {
                var br = types.find(b => b.name == x.type.name)
                br.count++
            }
        });
        setCars(prev => { return { ...prev, types: types, loadType: true } })

    }

    var models = []
    const getModel = () => {
        models = []
        cars.cars.forEach(x => {
            if (!models.find(b => b.name == x.model.name)) {
                models.push({ id: x.model.id, name: x.model.name, count: 1 })
            }
            else {
                var br = models.find(b => b.name == x.model.name)
                br.count++
            }
        });
        setCars(prev => { return { ...prev, models: models, loadModel: true } })

    }

    var brands = []
    const brand = () => {
        brands = [];
        cars.cars.forEach(x => {
            if (!brands.find(b => b.name == x.model.brand.name)) {
                brands.push({ id: x.model.brand.id, name: x.model.brand.name, count: 1 })
            }
            else {
                var br = brands.find(b => b.name == x.model.brand.name)
                br.count++
            }
        });
        setCars(prev => { return { ...prev, brands: brands, loadBrand: true } })
    }

    useEffect(() => {
        brand();
        getModel();
        getType();
        getTrans();
        getFuels();
    }, [cars.cars])

    useEffect(() => {
        const getCars = async () => {
            var datas = await axios.get(`https://localhost:7079/api/Cars/CarsList/${id}`)
            setCars(previous => { return { ...previous, cars: datas.data, loadCars: true } })
        }
        const getOffice = async () => {
            var data = await axios.get(`https://localhost:7079/api/Offices/${id}`)
            setCars(previous => { return { ...previous, office: data.data, loadOffice: true } })
        }
        getCars();
        getOffice();
    }, []);



    return (
        <div className='my-container mt-5' style={{ margin: "0 auto" }}>
            <div className='top-cars'>
                <Link to="/">Home Page</Link>
                <span>/</span>
                <span>Rent a Car</span>
                <span>/</span>
                {
                    cars.loadOffice ? <Link to={`/office/:${id}`}>{cars.office.name}</Link> : null
                }
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
                            {
                                cars.loadTrans ?
                                    cars.trans.map(x => (
                                        <div key={x.id} className="col-xl-6 col-lg-12 col-md-12 col-sm-12 col-12" style={{ display: "flex", alignItems: "center" }}>
                                            <input type="checkbox" value={1} id='automatic' name='transmission' />
                                            <label htmlFor="automatic">{x.name} ({x.count})</label>
                                        </div>
                                    ))
                                    : null

                            }
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
                        {
                                cars.loadFuel ?
                                    cars.fuels.filter(x=>x.count>0).map(x => (
                                        <div key={x.id} className="col-xl-6 col-lg-12 col-md-12 col-sm-12 col-12" style={{ display: "flex", alignItems: "center" }}>
                                            <input type="checkbox" value={1} id='automatic' name='transmission' />
                                            <label htmlFor="automatic">{x.name} ({x.count})</label>
                                        </div>
                                    ))
                                    : null

                            }
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
                            {
                                cars.loadBrand ?
                                    cars.brands.map(x => {
                                        return <div key={x.id} className="col-xl-6 col-lg-12 col-md-12 col-sm-12 col-12" style={{ display: "flex", alignItems: "center" }}>
                                            <input type="checkbox" value={1} id='BMW' />
                                            <label htmlFor="BMW">{x.name} ({x.count})</label>
                                        </div>
                                    }) : null
                            }


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
                            {
                                cars.loadModel ?
                                    cars.models.map(x => {
                                        return <div key={x.id} className="col-xl-6 col-lg-12 col-md-12 col-sm-12 col-12" style={{ display: "flex", alignItems: "center" }}>
                                            <input type="checkbox" value={1} id='BMW' />
                                            <label htmlFor="BMW">{x.name} ({x.count})</label>
                                        </div>
                                    }) : null
                            }
                        </div>
                    </div>
                    <div style={{ border: "1px solid #dee3e8", borderTop: "none", display: "flex", justifyContent: "space-between", alignItems: "center" }}>
                        <p style={{ color: "#ffa900", marginBottom: "0", fontSize: "15px", fontWeight: "700", textAlign: 'left', padding: "10px 20px" }}>Car Type</p>
                        {
                            tab.fuel ? <FaChevronUp style={{ color: "#ffa900", fontSize: "22px", marginRight: '10px' }} /> : <FaChevronDown style={{ color: "#ffa900", fontSize: "22px", marginRight: '10px' }} />
                        }
                    </div>
                    <div className='transsmission-tab tab' >
                        <div className="row g-3">
                            {
                                cars.loadType ?
                                    cars.types.map(x => {
                                        return <div key={x.id} className="col-xl-6 col-lg-12 col-md-12 col-sm-12 col-12" style={{ display: "flex", alignItems: "center" }}>
                                            <input type="checkbox" value={1} id='BMW' />
                                            <label htmlFor="BMW">{x.name} ({x.count})</label>
                                        </div>
                                    }) : null
                            }


                        </div>
                    </div>



                </div>
                <div className="col-lg-9 col-xl-8 col-md-8 col-sm-8">
                    <div className="top-info">
                        <div className="left-top-info">
                            <div className="left">
                                {
                                    cars.loadOffice ?
                                        <span className='office-name'>{cars.office.name}</span> : null

                                }

                                <span className='desc'>Car Rental Prices</span>
                            </div>
                            <div className="right">
                                <span>listing</span>
                                {
                                    cars.loadCars ?
                                        <span className='second'>{cars.cars.length} vehicles</span> : null

                                }
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
                        {cars.loadCars ? cars.cars.map(x => (<div className="car" key={x.id}>
                            <div className="car-title">
                                <p className='car-name'>{x.name}</p>
                                <p style={{ color: '#9b9b9b', fontSize: "12px", textAlign: "left", marginBottom: "0" }}>or similar</p>
                            </div>
                            <div className="car-info">
                                <div className="left">
                                    {
                                        x.isFreeCancelation ? <div className="free-cancel">
                                            <div className='d-flex'>
                                                <div className="radius">
                                                    <BsCheck style={{ color: "#39b54a", fontSize: "20px" }} />
                                                </div>
                                                <span>FREE CANCELLATION</span>
                                            </div>
                                        </div> : null
                                    }
                                    <div className="car-img">
                                        <img src={x.imageName} alt="car" />
                                    </div>
                                </div>
                                <div className="right">
                                    <ul>
                                        <li style={{ textAlign: "left", fontSize: "20px" }}>
                                            <BiInfoCircle color='#008dd4' />
                                            <span>Deposit : <b>{x.depozitPrice} $</b> </span>
                                        </li>
                                        <li style={{ textAlign: "left", fontSize: "20px" }}>
                                            <BiInfoCircle color='#008dd4' />
                                            <span>Total mileage limit : <b>{x.totalMillage} km</b> </span>
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
                                                <span style={{ color: '#9b9b9b', fontSize: "13px", fontWeight: "500" }}>{x.transmission === 1 ? "Automatic" : "Manual"}</span>
                                            </div>
                                            <div>
                                                <BsFillFuelPumpFill style={{ color: '#00a8f4', fontSize: '17px', marginRight: "6px" }} />
                                                <span style={{ color: '#9b9b9b', fontSize: "13px", fontWeight: "500" }}>{x.fuel === 1 ? "Diesel" : x.fuel === 2 ? 'Gas-Diesel' : x.fuel === 3 ? "Electric" : "Gas"}</span>
                                            </div>
                                            <div>
                                                <BsFillCarFrontFill style={{ color: '#00a8f4', fontSize: '22px', marginRight: "6px" }} />
                                                <span style={{ color: '#9b9b9b', fontSize: "13px", fontWeight: "500" }}>{x.type.name}</span>
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
                                            <p style={{ textDecoration: "underline", marginLeft: "100px", fontSize: "14px", color: "#758493", marginTop: "10px", marginBottom: "0" }}>{x.reviews.length} comments</p>
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
                                            <span style={{ color: "#2ecc71" }}>Daily price : {x.priceDaily} $</span>
                                            <span style={{ color: "#4a4a4a", fontSize: "20px", fontWeight: "700", marginRight: '10px' }}>125.30 $</span>
                                        </div>
                                    </div>
                                    <div className='rent-btn'>
                                        Rent now!
                                    </div>
                                </div>
                            </div>
                        </div>
                        )) : null}
                    </div>
                </div>
            </div>
        </div>
    )
}

export default Cars
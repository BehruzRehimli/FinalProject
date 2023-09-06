import React, { useState } from 'react'
import { useEffect } from 'react';
import { useNavigate, useParams } from 'react-router-dom'
import "./Profile.css"
import { FaUserAlt } from 'react-icons/fa'
import { IoMdCloseCircleOutline } from 'react-icons/io'
import { Formik, Form, Field } from 'formik';
import { MdOutlineDone } from 'react-icons/md'
import axios from 'axios';
import { useSelector } from 'react-redux';

const Profile = () => {
    const { username } = useParams();
    const [tab, setTab] = useState(1)

    const {adminToken}=useSelector(store=>store.login)
    const navigate=useNavigate()

    useEffect(() => {

    }, [])

    return (
        <div>
            <div className="navigation">
                <div className="row">
                    <div className="col-lg-4 left">My Account</div>
                    <div className="col-lg-8 right">
                        <div onClick={() => { setTab(1) }} className={tab === 1 ? "col-lg-3 profile-tab active" : "col-lg-3 profile-tab"}>Account Information</div>
                        <div onClick={() => { setTab(2) }} className={tab === 2 ? "col-lg-3 profile-tab active" : "col-lg-3 profile-tab"}>Past Reservations</div>
                        <div onClick={() => { setTab(3) }} className={tab === 3 ? "col-lg-3 profile-tab active" : "col-lg-3 profile-tab"}>Change Password</div>
                    </div>
                </div>
            </div>
            <div className="row">
                <div className="col-lg-4">
                    <div className='username-wrapper'>
                        <div className='username'>
                            <FaUserAlt style={{ color: "#2169aa", fontSize: "47px", marginLeft: "13px" }} />
                            <span>Behruz Rehimov</span>
                        </div>
                        <p >Logout
                            <IoMdCloseCircleOutline style={{ color: "#9b9b9b", fontSize: "14px", marginLeft: "15px" }} />
                        </p>
                    </div>
                </div>
                <div className="col-lg-8 right-profile">
                    {
                        tab === 1 ?
                            <div>
                                <p className="title-profile">
                                    Driver Information
                                    <span className='delete-profile'>Delete My Account</span>
                                </p>
                                <Formik>
                                    <Formik initialValues={{

                                    }} onSubmit={async (values) => {
                                    }}>
                                        {({ values }) => (
                                            <Form>
                                                <div className='mt-4 text-start'>
                                                    <label className='text-start rent-info-label' htmlFor="fullname">Fullname</label>
                                                    <Field type="text" id={"fullname"} className="driver-info w-100" name='fullname' />
                                                </div>
                                                <div className='d-flex justify-content-between'>
                                                    <div className='mt-4 text-start' style={{ width: "48%" }}>
                                                        <label className='text-start rent-info-label' htmlFor="phone">Phone</label>
                                                        <Field type="phone" id={"phone"} className="driver-info w-100" name='phone' />
                                                    </div>
                                                    <div className='mt-4 text-start' style={{ width: "48%" }}>
                                                        <label className='text-start rent-info-label' htmlFor="email">E-mail</label>
                                                        <Field type="email" id={"email"} className="driver-info w-100" name='email' />
                                                    </div>
                                                </div>
                                                <div className='d-flex justify-content-between'>
                                                    <div className='mt-4 text-start' style={{ width: "48%" }}>
                                                        <label className='text-start rent-info-label' htmlFor="birthday">Driver's Birthday (Ex: 30/12/1995)</label>
                                                        <Field type="text" id={"birthday"} className="driver-info w-100" name='birthday' />
                                                    </div>
                                                    <div className='mt-4 text-start' style={{ width: "48%" }}>
                                                        <label className='text-start rent-info-label' htmlFor="pasport">Passport Number</label>
                                                        <Field type="text" id={"pasport"} className="driver-info w-100" name='pasport' />
                                                    </div>
                                                </div>
                                                <div className='mt-4 text-start'>
                                                    <label className='text-start rent-info-label' htmlFor="address">Address</label>
                                                    <Field type="text" id={"address"} className="driver-info w-100" name='address' />
                                                </div>
                                                <button type='submit' className='btn login-btn register-btn form-control fs-6 mt-5' style={{ width: "200px", fontSize: "20px", fontWeight: "700" }}>Save <MdOutlineDone style={{ fontSize: "25px", marginLeft: '20px' }} /></button>

                                            </Form>
                                        )}
                                    </Formik>

                                </Formik>

                            </div> : tab === 2 ?
                                <div>Salam</div> :
                                <div>
                                    <p className="title-profile">
                                        Change Password
                                    </p>
                                    <Formik>
                                        <Formik initialValues={{
                                            current:'',
                                            newPassword:"",
                                            againPassword:""
                                        }} onSubmit={async (values) => {
                                            try {
                                                var headerToken = `Bearer ${adminToken}`
                                                axios.post("https://localhost:7079/api/Accounts/ChangePassword",values,{ headers: { "Authorization": headerToken } })
                                            } catch (error) {
                                                navigate("/error")
                                            }
                                        }}>
                                            {({ values }) => (
                                                <Form>
                                                    <div className='mt-4 text-start'>
                                                        <label className='text-start rent-info-label' htmlFor="password">Current</label><br />
                                                        <Field type="password" id={"password"} className="driver-info w-50" name='current' />
                                                    </div>
                                                    <div className='d-flex justify-content-between'>
                                                        <div className='mt-4 text-start' style={{ width: "48%" }}>
                                                            <label className='text-start rent-info-label' htmlFor="phone">New Password</label>
                                                            <Field type="password" id={"phone"} className="driver-info w-100" name='newPassword' />
                                                        </div>
                                                        <div className='mt-4 text-start' style={{ width: "48%" }}>
                                                            <label className='text-start rent-info-label' htmlFor="email">New Password (Again)</label>
                                                            <Field type="password" id={"email"} className="driver-info w-100" name='againPassword' />
                                                        </div>
                                                    </div>

                                                    <button type='submit' className='btn login-btn register-btn form-control fs-6 mt-5' style={{ width: "200px", fontSize: "20px", fontWeight: "700",float:"right" }}>Save <MdOutlineDone style={{ fontSize: "25px", marginLeft: '20px' }} /></button>

                                                </Form>
                                            )}
                                        </Formik>

                                    </Formik>

                                </div>

                    }
                </div>
            </div>
        </div>
    )
}

export default Profile
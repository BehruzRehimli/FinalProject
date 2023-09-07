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
import toast, { Toaster } from 'react-hot-toast';

const Profile = () => {
    const [tab, setTab] = useState(1)

    const { adminToken, token, isLogin } = useSelector(store => store.login)
    const navigate = useNavigate()
    const [user, setUser] = useState({
        user: {},
        isLoad: false,
        isSaved: false
    })

    const getUser = async () => {
        await axios.get('https://localhost:7079/api/Accounts/Profile', { headers: { "Authorization": `Bearer ${token}` } }).
            then(respose => setUser(prev => { return { ...prev, user: respose.data, isLoad: true } })).
            catch(error => navigate("/error"))
    }

    useEffect(() => {
        if (!token && !(token.length > 0)) {
            navigate("/")
        }
        getUser()
    }, [user.isSaved])

    return (
        <div style={{ overflow: "hidden" }}>
            <div className="navigation">
                <div className="row">
                    <div  className="col-lg-4 left">My Account</div>
                    <div className="col-lg-8 right">
                        <div onClick={() => { setTab(1) }} className={tab === 1 ? "col-lg-3 profile-tab active" : "col-lg-3 profile-tab"}>Account Information</div>
                        <div onClick={() => { setTab(2) }} className={tab === 2 ? "col-lg-3 profile-tab active" : "col-lg-3 profile-tab"}>Past Reservations</div>
                        <div onClick={() => { setTab(3) }} className={tab === 3 ? "col-lg-3 profile-tab active" : "col-lg-3 profile-tab"}>Change Password</div>
                    </div>
                </div>
                <Toaster
                    position="top-right"
                    reverseOrder={false}
                    gutter={8}
                    containerClassName=""
                    containerStyle={{}}
                    toastOptions={{
                        // Define default options
                        className: '',
                        duration: 5000,
                        style: {
                            background: '#363636',
                            color: '#fff',
                            marginTop:"70px"
                        },

                        // Default options for specific types
                        success: {
                            duration: 3000,
                            theme: {
                                primary: 'green',
                                secondary: 'black',
                            },
                        },
                    }}
                />
            </div>
            <div className="row">
                <div className="col-lg-4">
                    <div className='username-wrapper'>
                        <div className='username'>
                            <FaUserAlt style={{ color: "#2169aa", fontSize: "47px", marginLeft: "13px" }} />
                            {
                                user.isLoad ?
                                    <span>{user.user.fullname}</span> : null
                            }
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
                                        fullname: user.user.fullname,
                                        username: user.user.username,
                                        phone: user.user.phone,
                                        email: user.user.email,
                                        birthday: user.user.birthday,
                                        pasport: user.user.pasport,
                                        address: user.user.address
                                    }} onSubmit={async (values) => {
                                    }}>
                                        {({ values }) => (
                                            <Form>
                                                <div className='mt-4 text-start'>
                                                    <label className='text-start rent-info-label' htmlFor="fullname">Fullname</label>
                                                    <input defaultValue={user.user.fullname} type="text" id={"fullname"} className="driver-info w-100" name='fullname' />
                                                </div>
                                                <div className='mt-4 text-start'>
                                                    <label className='text-start rent-info-label' htmlFor="username">Username</label>
                                                    <input defaultValue={user.user.username} type="text" id={"username"} className="driver-info w-100" name='username' />
                                                </div>
                                                <div className='d-flex justify-content-between'>
                                                    <div className='mt-4 text-start' style={{ width: "48%" }}>
                                                        <label className='text-start rent-info-label' htmlFor="phone">Phone</label>
                                                        <input defaultValue={user.user.phone} type="phone" id={"phone"} className="driver-info w-100" name='phone' />
                                                    </div>
                                                    <div className='mt-4 text-start' style={{ width: "48%" }}>
                                                        <label className='text-start rent-info-label' htmlFor="email">E-mail</label>
                                                        <input defaultValue={user.user.email} type="email" id={"email"} className="driver-info w-100" name='email' />
                                                    </div>
                                                </div>
                                                <div className='d-flex justify-content-between'>
                                                    <div className='mt-4 text-start' style={{ width: "48%" }}>
                                                        <label className='text-start rent-info-label' htmlFor="birthday">Driver's Birthday (Ex: 30/12/1995)</label>
                                                        <input defaultValue={user.user.birthday} type="text" id={"birthday"} className="driver-info w-100" name='birthday' />
                                                    </div>
                                                    <div className='mt-4 text-start' style={{ width: "48%" }}>
                                                        <label className='text-start rent-info-label' htmlFor="pasport">Passport Number</label>
                                                        <input defaultValue={user.user.pasport} type="text" id={"pasport"} className="driver-info w-100" name='pasport' />
                                                    </div>
                                                </div>
                                                <div className='mt-4 text-start'>
                                                    <label className='text-start rent-info-label' htmlFor="address">Address</label>
                                                    <input defaultValue={user.user.address} type="text" id={"address"} className="driver-info w-100" name='address' />
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
                                            current: '',
                                            newPassword: "",
                                            againPassword: ""
                                        }} onSubmit={async (values) => {
                                            try {
                                                var headerToken = `Bearer ${token}`
                                                axios.post("https://localhost:7079/api/Accounts/ChangePassword", values, { headers: { "Authorization": headerToken } }).then(res => toast.success("Changed Your Password"), setTab(1)).catch(error => navigate("/error"))
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

                                                    <button type='submit' className='btn login-btn register-btn form-control fs-6 mt-5' style={{ width: "200px", fontSize: "20px", fontWeight: "700", float: "right" }}>Save <MdOutlineDone style={{ fontSize: "25px", marginLeft: '20px' }} /></button>

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
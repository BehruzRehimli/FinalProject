import React, { useEffect } from 'react'
import "./RentInfo.css"
import { Formik, Form, Field } from 'formik'
import { useSelector } from 'react-redux'


const RentInfo = () => {
    const {extentions}=useSelector(store=>store.rent)

    useEffect(()=>{
        console.log(extentions);
    },[])

    return (
        <div className='col-lg-8'>
            <Formik>
                <Formik initialValues={{
                    fullname: '',
                    phone:"",
                    mail:"",
                    birthday:"",
                    pasport:"",
                    address:""

                }} onSubmit={async (values) => {

                }}>
                    {({ values }) => (
                        <Form>
                            <h4 className='text-start rent-info-title mt-4'>Driver Information</h4>
                            <div className='mt-4 text-start'>
                                <label className='text-start rent-info-label' htmlFor="fullname">Fullname</label>
                                <Field type="text" id={"fullname"} className="driver-info w-100" name='fullname' />
                            </div>
                            <div className='d-flex justify-content-between'>
                                <div className='mt-4 text-start' style={{width:"48%"}}>
                                    <label className='text-start rent-info-label' htmlFor="phone">Phone</label>
                                    <Field type="phone" id={"phone"} className="driver-info w-100" name='phone' />
                                </div>
                                <div className='mt-4 text-start' style={{width:"48%"}}>
                                    <label className='text-start rent-info-label' htmlFor="email">E-mail</label>
                                    <Field type="email" id={"email"} className="driver-info w-100" name='mail' />
                                </div>
                            </div>
                            <div className='d-flex justify-content-between'>
                                <div className='mt-4 text-start' style={{width:"48%"}}>
                                    <label className='text-start rent-info-label' htmlFor="birthday">Driver's Birthday (Ex: 30/12/1995)</label>
                                    <Field type="text" id={"birthday"} className="driver-info w-100" name='birthday'  />
                                </div>
                                <div className='mt-4 text-start' style={{width:"48%"}}>
                                    <label className='text-start rent-info-label' htmlFor="pasport">Passport Number</label>
                                    <Field type="email" id={"pasport"} className="driver-info w-100" name='pasport' />
                                </div>
                            </div>
                            <div className='mt-4 text-start'>
                                <label className='text-start rent-info-label' htmlFor="address">Address</label>
                                <Field type="text" id={"address"} className="driver-info w-100" name='address' />
                            </div>
                            <button type='submit' className='btn login-btn register-btn form-control fs-6 mt-5'>Rent Now</button>

                        </Form>
                    )}
                </Formik>

            </Formik>
        </div>
    )
}

export default RentInfo
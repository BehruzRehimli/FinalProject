import React, { useEffect, useState } from 'react'
import { Formik, Form, Field } from 'formik'
import { useSelector } from 'react-redux/es/hooks/useSelector'
import axios from 'axios'
import { useNavigate } from 'react-router-dom'

const CityCreate = () => {
    const navigate = useNavigate()
    const [countries, setCountries] = useState()
    const { adminToken } = useSelector(store => store.login)
    const [image, setImage] = useState()


    useEffect(() => {
        const getCountries = async () => {
            var headerToken = `Bearer ${adminToken}`
            var datas = await axios.get("https://localhost:7079/api/Countries", { headers: { "Authorization": headerToken } })
            setCountries(datas.data)
        }
        getCountries()
    }, [])

    return (
        <div className='admin-container'>
            <h2 className='crud-header-entity mb-4'>Create City</h2>
            <Formik>
                <Formik initialValues={{
                    name: '',
                    homeSliderOrder: "",
                    homePopularOrder: "",
                    imageFile: null,
                    countryId: 0
                }} onSubmit={async (values) => {
                    var datas=values;
                    console.log(datas);
                    var headerToken = `Bearer ${adminToken}`
                    var data= await axios.post("https://localhost:7079/api/countries",values,{headers:{"Authorization": headerToken}})

                    // try {

                    // } catch (error) {
                    //     console.log(error.response.data);
                    //     if (error.response.status === 401) {
                    //         navigate("/admin/login")
                    //     }
                    // }
                    // if (result.status === 200) {
                    //     navigate("/admin/city")
                    // }
                }}>
                    {({ values, setFieldValue }) => (
                        <Form>

                            <div className='d-flex'>
                                <Field type="text" className="login-input" name='name' placeholder="City Name..." />
                            </div>
                            <div className='d-flex'>
                                <Field type="number" className="login-input" name='homeSliderOrder' placeholder="Home Slider Order..." />
                            </div>
                            <div className='d-flex'>
                                <Field type="number" className="login-input" name='homePopularOrder' placeholder="Popular City Order..." />
                            </div>
                            <div className='text-start'>
                                <label style={{ marginTop: "20px", textAlign: "left", fontSize: "16px", fontWeight: "500", color: "#ffa900" }} htmlFor="image">Add Image...</label>
                                <input onChange={(e) => {
                                    setFieldValue("imageFile", e.target.files[0])
                                    setImage(URL.createObjectURL(e.target.files[0]))
                                }} style={{ marginTop: "0" }} type="file" id='image' className="login-input" name='imageFile' placeholder="Add Image..." />
                            </div>
                            <div className='mt-3 text-start'>
                                {
                                    image &&
                                    <img src={image} alt="img" />
                                }
                            </div>
                            <div>
                                <select name="countryId" id="" className='login-input' onChange={(e) => {
                                    setFieldValue("countryId", e.target.value)
                                }}  >
                                    {
                                        countries ?
                                            countries.map(x => (
                                                <option value={x.id} key={x.id}>{x.name}</option>
                                            )) : null
                                    }
                                </select>
                            </div>
                            <button type='submit' className='btn login-btn register-btn form-control fs-5'>Create</button>
                        </Form>
                    )}
                </Formik>

            </Formik>

        </div>
    )
}

export default CityCreate
import React from 'react'
import { Formik, Form, Field } from 'formik'
import { useSelector } from 'react-redux/es/hooks/useSelector'
import axios from 'axios'
import { useNavigate } from 'react-router-dom'
import { useState, useEffect } from 'react'

const ModelCreate = () => {
    const navigate = useNavigate()

    const [entity, setEntity] = useState();

    const { adminToken } = useSelector(store => store.login)

    useEffect(() => {
        const getEntity = async () => {
            var headerToken = `Bearer ${adminToken}`
            try {
                var datas = await axios.get("https://localhost:7079/api/Brands", { headers: { "Authorization": headerToken } })
            } catch (error) {
                console.log(error);
                if (error.response.status === 401) {
                    navigate("/admin/login")
                }
            }

            setEntity(datas.data)
        }
        getEntity()
    }, [])

    const [postValues, setPostValues] = useState({
        name: '',
        brandId: 1
    })
    const BtnHandler = async (e) => {
        e.preventDefault()
        var headerToken = `Bearer ${adminToken}`
        try {
            var data = await axios.post("https://localhost:7079/api/Models", postValues, {
                headers: {
                    "Authorization": headerToken
                }
            })
        } catch (error) {
            console.log(error);
            if (error.response.status === 401) {
                navigate("/admin/login")
            }
        }
        navigate("/admin/model")

    }


    const InputHandler = (e) => {
        setPostValues(prev => { return { ...prev, [e.target.name]: e.target.value } })
    }




    return (
        <div className='admin-container'>
            <h2 className='crud-header-entity mb-4'>Create Model</h2>
            <Formik>
                <Formik initialValues={{
                    name: '',
                    brandId: 1
                }} onSubmit={async (values) => {
                }}>
                    {({ values, setFieldValue }) => (
                        <Form>

                            <div className='d-flex'>
                                <input type="text" onChange={InputHandler} className="login-input" name='name' placeholder="Office Name..." />
                            </div>
                            <div>
                                <select  name="brandId" id="" className='login-input' onChange={(e) => {
                                    setFieldValue("brandId", e.target.value)
                                    setPostValues(prev=>{return{...prev,brandId:e.target.value}})
                                }}  >
                                    {
                                        entity ?
                                            entity.map(x => (
                                                <option value={x.id} key={x.id}>{x.name}</option>
                                            )) : null
                                    }
                                </select>
                            </div>

                            <button onClick={BtnHandler} type='submit' className='btn login-btn register-btn form-control '>Create</button>
                        </Form>
                    )}
                </Formik>

            </Formik>

        </div>
    )
}

export default ModelCreate
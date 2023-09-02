import axios from 'axios'
import React, { useState } from 'react'
import { useEffect } from 'react'
import { Link } from 'react-router-dom'
import { useSelector } from 'react-redux'
import { useNavigate } from 'react-router-dom'
import { FiEdit } from "react-icons/fi"
import { MdDeleteForever } from "react-icons/md"

const City = () => {

    const navigate = useNavigate();

    const { adminToken } = useSelector(store => store.login)

    const [countries, setCountries] = useState({
        isLoad: false,
        countries: []
    })


    useEffect(() => {
        const getCountries = async () => {
            var token = "Bearer " + adminToken
            try {
                var datas = await axios.get("https://localhost:7079/api/Cities", { headers: { "Authorization": token } })
                setCountries(prev => { return { ...prev, countries: datas.data, isLoad: true } })
            } catch (error) {
                console.log(error);
                if (error.response.status === 401) {
                    navigate("/admin/login")
                }
            }
        }
        getCountries();
    }, [])

    let order = 1;

    return (
        <div className="admin-container">
            <h2 className='text-start  crud-header-entity pb-3' >City</h2>
            <div className='text-end me-3'>
                <Link className='btn btn-primary' to={"/admin/city/create"}>Create City</Link>
            </div>
            <div className="table-responsive mt-4">
                <table className="table table-hover">
                    <thead>
                        <tr>
                            <th className="text-center ">#</th>
                            <th>Name</th>
                            <th>Country Name</th>
                            <th>Offices Count</th>
                            <th>Actions</th>
                        </tr>
                    </thead>
                    <tbody>
                        {
                            countries.isLoad ?
                                countries.countries.map(x => (
                                    <tr key={x.id}>
                                        <td className="text-center">{order++}</td>
                                        <td className="txt-oflo">{x.name}</td>
                                        <td className="txt-oflo">{x.country.name}</td>
                                        <td className="txt-oflo">{x.officesCount}</td>
                                        <td><span className="text-success">
                                            <Link to={`/admin/type/edit/${x.id}`} className='btn btn-warning'> <FiEdit className='me-2' />Edit</Link>
                                            <button onClick={async () => {
                                                var token = "Bearer " + adminToken
                                                try {
                                                    var datas = await axios.delete(`https://localhost:7079/api/Cities/${x.id}`, { headers: { "Authorization": token } })
                                                    var datas = await axios.get("https://localhost:7079/api/Cities", { headers: { "Authorization": token } })
                                                    setCountries(prev => { return { ...prev, countries: datas.data, isLoad: true } })

                                                } catch (error) {
                                                    console.log(error);
                                                    if (error.response.status === 401) {
                                                        navigate("/admin/login")
                                                    }
                                                }

                                            }} className='btn btn-danger ms-3'> <MdDeleteForever className='me-2 fs-5' />Delete</button>
                                        </span></td>
                                    </tr>

                                )) : null
                        }
                    </tbody>
                </table>
            </div>


        </div>
    )
}

export default City
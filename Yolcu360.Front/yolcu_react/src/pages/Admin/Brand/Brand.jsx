import axios from 'axios'
import React, { useState } from 'react'
import { useEffect } from 'react'
import { Link } from 'react-router-dom'
import { useSelector } from 'react-redux'
import { useNavigate } from 'react-router-dom'
import { FiEdit } from "react-icons/fi"
import { MdDeleteForever } from "react-icons/md"

const Brand = () => {

    const navigate = useNavigate();

    const { adminToken } = useSelector(store => store.login)

    const [countries, setCountries] = useState({
        isLoad: false,
        countries: []
    })

    const [page, setPage] = useState(1)
    const [maxPage, setMaxPage] = useState();
    const pagesArray = []
    for (let i = 1; i <= maxPage; i++) {
        pagesArray.push(i);
    }
    const PageClickHandler = (e) => {
        setPage(e.target.innerHTML)
        var btns = document.querySelectorAll('.pagination')
        btns.forEach(btn => {
            btn.classList.remove("active")
        });
        e.target.classList.add("active")
    }



    useEffect(() => {
        const getCountries = async () => {
            var token = "Bearer " + adminToken
            try {
                var datas = await axios.get(`https://localhost:7079/api/Brands/GetAdmin/${page}`, { headers: { "Authorization": token } })
                setCountries(prev => { return { ...prev, countries: datas.data.data, isLoad: true } })
                setMaxPage(datas.data.pageCount)

            } catch (error) {
                console.log(error);
                if (error.response.status === 401) {
                    navigate("/admin/login")
                }
                else {
                    navigate("/error")

                }
            }
        }
        getCountries();
    }, [page])


    return (
        <div className="admin-container">
            <h2 className='text-start  crud-header-entity pb-3' >Brand</h2>
            <div className='text-end me-3'>
                <Link className='btn btn-primary' to={"/admin/brand/create"}>Create Brand</Link>
            </div>
            <div className="table-responsive mt-4">
                <table className="table table-hover">
                    <thead>
                        <tr>
                            <th className="text-center ">#</th>
                            <th>Name</th>
                            <th>Models Count</th>
                            <th>Actions</th>
                        </tr>
                    </thead>
                    <tbody>
                        {
                            countries.isLoad ?
                                countries.countries.map((x, index) => (
                                    <tr key={x.id}>
                                        <td className="text-center">{index + ((page - 1) * 10) + 1}</td>
                                        <td className="txt-oflo">{x.name}</td>
                                        <td className="txt-oflo">{x.modelsCount}</td>
                                        <td><span className="text-success">
                                            <Link to={`/admin/brand/edit/${x.id}`} className='btn btn-warning'> <FiEdit className='me-2' />Edit</Link>
                                            <button onClick={async () => {
                                                var token = "Bearer " + adminToken
                                                try {
                                                    var datas = await axios.delete(`https://localhost:7079/api/Brands/${x.id}`, { headers: { "Authorization": token } })
                                                    var datas = await axios.get("https://localhost:7079/api/Brands", { headers: { "Authorization": token } })
                                                    setCountries(prev => { return { ...prev, countries: datas.data, isLoad: true } })

                                                } catch (error) {
                                                    console.log(error);
                                                    if (error.response.status === 401) {
                                                        navigate("/admin/login")
                                                    }
                                                    else {
                                                        navigate("/error")
                                    
                                                    }
                                    
                                                }

                                            }} className='btn btn-danger ms-3'> <MdDeleteForever className='me-2 fs-5' />Delete</button>
                                        </span></td>
                                    </tr>

                                )) : null
                        }
                    </tbody>
                </table>
                <div className='text-start'>
                    {
                        pagesArray.length > 0 ?
                            pagesArray.map(x => (
                                <p id={`page-btn-${x}`} onClick={PageClickHandler} className={page === x ? 'pagination active' : 'pagination'} key={x}>{x}</p>
                            )) : null
                    }
                </div>

            </div>


        </div>
    )
}

export default Brand
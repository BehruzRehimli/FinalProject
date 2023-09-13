import React from 'react'
import User1 from "../../images/images/users/1.jpg"
import User2 from "../../images/images/users/2.jpg"
import User3 from "../../images/images/users/3.jpg"
import User4 from "../../images/images/users/4.jpg"
import { useNavigate } from 'react-router-dom'
import { useSelector } from 'react-redux'
import axios from 'axios'
import { useEffect } from 'react'
import Chart from '../../components/Chart/Chart'
import { data } from 'jquery'
import PieChart from "../../components/Chart/PieChart"


const Dashboard = () => {

    const navigate = useNavigate();

    const { adminToken } = useSelector(store => store.login)



    useEffect(() => {
        const getCountries = async () => {
            var token = "Bearer " + adminToken
            try {
                var datas = await axios.get(`https://localhost:7079/api/types`, { headers: { "Authorization": token } })
            } catch (error) {
                if (error.response.status == 401) {
                    navigate("/admin/login")
                }
                else {
                    navigate("/error")
                }
            }
        }
        getCountries();
    }, [])


    return (
        <>
            {/* <!-- ============================================================== -->
                <!-- Bread crumb and right sidebar toggle -->
                <!-- ============================================================== --> */}
            <div className="row page-titles">
                <div className="col-md-5 align-self-center">
                    <h4 className="text-themecolor">Dashboard</h4>
                </div>
                <div className="col-md-7 align-self-center text-right">
                    <div className="d-flex justify-content-end align-items-center">
                        <ol className="breadcrumb">
                            <li className="breadcrumb-item"><a >Home</a></li>
                            <li className="breadcrumb-item active">Dashboard</li>
                        </ol>
                        <a className="btn btn-success d-none d-lg-block m-l-15" href="https://wrappixel.com/templates/elegant-admin/"> Upgrade To Pro</a>
                    </div>
                </div>
            </div>
            {/* <!-- ============================================================== -->
                <!-- End Bread crumb and right sidebar toggle -->
                <!-- ============================================================== -->
                <!-- ============================================================== -->
                <!-- Yearly Sales -->
                <!-- ============================================================== --> */}
            <div className="row">
                <div className="col-lg-8">
                    <Chart/>
                </div>
                <div className="col-lg-4">
                    <div className="card">
                        <div className="card-body" style={{height:"450px"}}>
                            <PieChart/>
                        </div>
                    </div>
                </div>
            </div>
            {/* <!-- ============================================================== -->
                <!-- News -->
                <!-- ============================================================== --> */}
            <div className="row">
                {/* <!-- column --> */}
                <div className="col-12">
                    <div className="card">
                        <div className="card-body">
                            <div className="d-flex">
                                <div>
                                    <h5 className="card-title">Sales Overview</h5>
                                    <h6 className="card-subtitle">Check the monthly sales </h6>
                                </div>
                                <div className="ml-auto">
                                    <select className="custom-select b-0">
                                        <option>January</option>
                                        <option value="1">February</option>
                                        <option value="2" defaultValue="">March</option>
                                        <option value="3">April</option>
                                    </select>
                                </div>
                            </div>
                        </div>
                        <div className="table-responsive">
                            <table className="table table-hover">
                                <thead>
                                    <tr>
                                        <th className="text-center">#</th>
                                        <th>NAME</th>
                                        <th>DATE</th>
                                        <th>PRICE</th>
                                    </tr>
                                </thead>
                                <tbody>
                                    <tr>
                                        <td className="text-center">1</td>
                                        <td className="txt-oflo">Elite admin</td>
                                        <td className="txt-oflo">April 18, 2017</td>
                                        <td><span className="text-success">$24</span></td>
                                    </tr>
                                    <tr>
                                        <td className="text-center">2</td>
                                        <td className="txt-oflo">Real Homes WP Theme</td>
                                        <td className="txt-oflo">April 19, 2017</td>
                                        <td><span className="text-info">$1250</span></td>
                                    </tr>
                                    <tr>
                                        <td className="text-center">3</td>
                                        <td className="txt-oflo">Ample Admin</td>
                                        <td className="txt-oflo">April 19, 2017</td>
                                        <td><span className="text-info">$1250</span></td>
                                    </tr>
                                    <tr>
                                        <td className="text-center">4</td>
                                        <td className="txt-oflo">Medical Pro WP Theme</td>
                                        <td className="txt-oflo">April 20, 2017</td>
                                        <td><span className="text-danger">-$24</span></td>
                                    </tr>
                                    <tr>
                                        <td className="text-center">5</td>
                                        <td className="txt-oflo">Hosting press html</td>
                                        <td className="txt-oflo">April 21, 2017</td>
                                        <td><span className="text-success">$24</span></td>
                                    </tr>
                                    <tr>
                                        <td className="text-center">6</td>
                                        <td className="txt-oflo">Digital Agency PSD</td>
                                        <td className="txt-oflo">April 23, 2017</td>
                                        <td><span className="text-danger">-$14</span></td>
                                    </tr>
                                    <tr>
                                        <td className="text-center">7</td>
                                        <td className="txt-oflo">Helping Hands WP Theme</td>
                                        <td className="txt-oflo">April 22, 2017</td>
                                        <td><span className="text-success">$64</span></td>
                                    </tr>
                                    <tr>
                                        <td className="text-center">8</td>
                                        <td className="txt-oflo">Helping Hands WP Theme</td>
                                        <td className="txt-oflo">April 22, 2017</td>
                                        <td><span className="text-success">$64</span></td>
                                    </tr>
                                    <tr>
                                        <td className="text-center">9</td>
                                        <td className="txt-oflo">Ample Admin</td>
                                        <td className="txt-oflo">April 19, 2017</td>
                                        <td><span className="text-info">$1250</span></td>
                                    </tr>
                                </tbody>
                            </table>
                        </div>
                    </div>
                </div>
            </div>
            {/* <!-- ============================================================== -->
                <!-- To do chat and message -->
                <!-- ============================================================== --> */}
            <div className="row">
                <div className="col-md-6">
                    <div className="card">
                        <div className="card-body">
                            <h4 className="card-title">Feeds</h4>
                        </div>
                        <ul className="feeds p-b-20">
                            <li>
                                <div className="bg-info"><i className="fa fa-bell-o"></i></div> You have 4 pending tasks. <span className="text-muted">Just Now</span></li>
                            <li>
                                <div className="bg-success"><i className="ti-server"></i></div> Server #1 overloaded.<span className="text-muted">2 Hours ago</span></li>
                            <li>
                                <div className="bg-warning"><i className="ti-shopping-cart"></i></div> New order received.<span className="text-muted">31 May</span></li>
                            <li>
                                <div className="bg-danger"><i className="ti-user"></i></div> New user registered.<span className="text-muted">30 May</span></li>
                            <li>
                                <div className="bg-dark"><i className="fa fa-bell-o"></i></div> New Version just arrived. <span className="text-muted">27 May</span></li>
                            <li>
                                <div className="bg-info"><i className="fa fa-bell-o"></i></div> You have 4 pending tasks. <span className="text-muted">Just Now</span></li>
                            <li>
                                <div className="bg-danger"><i className="ti-user"></i></div> New user registered.<span className="text-muted">30 May</span></li>
                            <li>
                                <div className="bg-dark"><i className="fa fa-bell-o"></i></div> New Version just arrived. <span className="text-muted">27 May</span></li>
                        </ul>
                    </div>
                </div>
                <div className="col-md-6">
                    <div className="card">
                        <div className="card-body">
                            <h5 className="card-title">Messages (5 New)</h5>
                            <div className="message-box">
                                <div className="message-widget message-scroll">
                                    {/* <!-- Message --> */}
                                    <a >
                                        <div className="user-img"> <img src={User1} alt="user" className="img-circle" /> <span className="profile-status online pull-right"></span> </div>
                                        <div className="mail-contnet">
                                            <h5>Pavan kumar</h5> <span className="mail-desc">Lorem Ipsum is simply dummy text of the printing and type setting industry. Lorem Ipsum has been.</span> <span className="time">9:30 AM</span> </div>
                                    </a>
                                    {/* <!-- Message --> */}
                                    <a href="#">
                                        <div className="user-img"> <img src={User2} alt="user" className="img-circle" /> <span className="profile-status busy pull-right"></span> </div>
                                        <div className="mail-contnet">
                                            <h5>Sonu Nigam</h5> <span className="mail-desc">I've sung a song! See you at</span> <span className="time">9:10 AM</span> </div>
                                    </a>
                                    {/* <!-- Message --> */}
                                    <a href="#">
                                        <div className="user-img"> <span className="round">A</span> <span className="profile-status away pull-right"></span> </div>
                                        <div className="mail-contnet">
                                            <h5>Arijit Sinh</h5> <span className="mail-desc">Simply dummy text of the printing and typesetting industry.</span> <span className="time">9:08 AM</span> </div>
                                    </a>
                                    {/* <!-- Message --> */}
                                    <a href="#">
                                        <div className="user-img"> <img src={User4} alt="user" className="img-circle" /> <span className="profile-status offline pull-right"></span> </div>
                                        <div className="mail-contnet">
                                            <h5>Pavan kumar</h5> <span className="mail-desc">Just see the my admin!</span> <span className="time">9:02 AM</span> </div>
                                    </a>
                                    {/* <!-- Message --> */}
                                    <a href="#">
                                        <div className="user-img"> <img src={User1} alt="user" className="img-circle" /> <span className="profile-status online pull-right"></span> </div>
                                        <div className="mail-contnet">
                                            <h5>Pavan kumar</h5> <span className="mail-desc">Welcome to the Elite Admin</span> <span className="time">9:30 AM</span> </div>
                                    </a>
                                    {/* <!-- Message --> */}
                                    <a href="#">
                                        <div className="user-img"> <img src={User2} alt="user" className="img-circle" /> <span className="profile-status busy pull-right"></span> </div>
                                        <div className="mail-contnet">
                                            <h5>Sonu Nigam</h5> <span className="mail-desc">I've sung a song! See you at</span> <span className="time">9:10 AM</span> </div>
                                    </a>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </>
    )
}

export default Dashboard
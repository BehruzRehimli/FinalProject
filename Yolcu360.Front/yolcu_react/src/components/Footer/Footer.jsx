import React from 'react'
import "./Footer.css"
import { Link } from 'react-router-dom';
import {FaFacebookF,FaTwitter,FaInstagram,FaLinkedin,FaYoutube} from "react-icons/fa"

import 'bootstrap/dist/css/bootstrap.min.css';


const Footer = () => {
  return (
    <footer >
      <div className="my-container">
        <div className="top-footer">
          <div className="row">
            <div className="col-lg-3 col-md-6 col-xs-12">
              <ul>
              <li>
                  <Link to="/airport">Barcelona El Prat Airport</Link>
                </li>                <li>
                  <Link to="/airport">Barcelona El Prat Airport</Link>
                </li>                <li>
                  <Link to="/airport">Barcelona El Prat Airport</Link>
                </li>                <li>
                  <Link to="/airport">Barcelona El Prat Airport</Link>
                </li>
              </ul>
            </div>
            <div className="col-lg-3 col-md-6 col-xs-12">
              <ul>
              <li>
                  <Link to="/airport">Barcelona El Prat Airport</Link>
                </li>                <li>
                  <Link to="/airport">Barcelona El Prat Airport</Link>
                </li>                <li>
                  <Link to="/airport">Barcelona El Prat Airport</Link>
                </li>                <li>
                  <Link to="/airport">Barcelona El Prat Airport</Link>
                </li>
              </ul>
            </div>
            <div className="col-lg-3 col-md-6 col-xs-12">
            <ul>
              <li>
                  <Link to="/airport">Barcelona El Prat Airport</Link>
                </li>                <li>
                  <Link to="/airport">Barcelona El Prat Airport</Link>
                </li>                <li>
                  <Link to="/airport">Barcelona El Prat Airport</Link>
                </li>                <li>
                  <Link to="/airport">Barcelona El Prat Airport</Link>
                </li>
              </ul>
            </div>
            <div className="col-lg-3 col-md-6 col-xs-12">
            <ul>
              <li>
                  <Link to="/airport">Barcelona El Prat Airport</Link>
                </li>                <li>
                  <Link to="/airport">Barcelona El Prat Airport</Link>
                </li>                <li>
                  <Link to="/airport">Barcelona El Prat Airport</Link>
                </li>                <li>
                  <Link to="/airport">Barcelona El Prat Airport</Link>
                </li>
              </ul>
            </div>
          </div>
        </div>
        <div className="main-footer">
            <div className="row">
              <div className="col-lg-7 col-xs-7 left">
                <div className='text-start mt-5'>
                   <Link to="/"><img src="https://staticf.yolcu360.com/static/image/360-logo.svg" alt="Logo" /></Link>
                </div>
                <p className='mini-text'>Join the thousands of other customers who found their ideal vehicle at the best price with Yolcu360! No stress, hassle, just the perfect car.</p>
                <div className="d-flex justify-content-between">
                  <div>
                    <p className='mt-2' style={{color:"#758493",textAlign:'left',fontWeight:"700",fontSize:"12px"}}>Social Media Accounts</p>
                    <div className='text-start mt-3'>
                      <a href=""><FaFacebookF color='#9b9b9b' fontSize="26px"/></a>
                      <a className='ms-3' href=""><FaTwitter color='#9b9b9b' fontSize="26px"/></a>
                      <a className='ms-3' href=""><FaInstagram color='#9b9b9b' fontSize="26px"/></a>
                      <a className='ms-3' href=""><FaLinkedin color='#9b9b9b' fontSize="26px"/></a>
                      <a className='ms-3' href=""><FaYoutube color='#9b9b9b' fontSize="26px"/></a>
                    </div>
                    <p className='mini-text mt-4' style={{fontWeight:700,fontSize:"10px"}}>YOLCU360 INC. ALL RIGHTS RESERVED.</p>
                  </div>
                </div>
              </div>
              <div className="col-lg-5 col-xs-5 right"></div>
            </div>
        </div>
      </div>
    </footer>
  )
}

export default Footer
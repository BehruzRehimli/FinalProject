import React, { useState } from 'react'
import "./Navbar.css"
import { BsSearchHeart,BsFillGiftFill } from 'react-icons/bs'
import {BiSolidCar} from 'react-icons/bi'
import {RiUser3Fill} from 'react-icons/ri'
import {IoIosArrowDown} from 'react-icons/io'

const Navbar = (props) => {

  return (
    <nav className='my-navbar'>
        <div className='last-search my-nav-element'><BsSearchHeart style={{color:"#2169aa",fontSize:"18px",fontWeight:600}}/></div>
        <div className=' my-nav-element menu-element'><BsFillGiftFill style={{color:"#2169aa",fontSize:"18px",fontWeight:600}}/><span>Campaigns</span></div>
        <div className=' my-nav-element menu-element'><BiSolidCar style={{color:"#2169aa",fontSize:"20px",fontWeight:600}}/><span>Find Reservation</span></div>
        <div className=' my-nav-element menu-element'><RiUser3Fill style={{color:"#2169aa",fontSize:"20px",fontWeight:600}}/><span>Login</span></div>    
        <div className="my-nav-element menu-element valyuta-nav" style={props.valyuta?{backgroundColor:"#ecf0ff"}:null} onClick={props.valyutaTab}><span className='valyuta'>{props.valyutaName}</span><IoIosArrowDown className='down-arrow' style={{color:"#0e568c",marginLeft:"2px"}}/>
        <div className="valyuta-tab " style={props.valyuta?{display:'Block'}:{display:'none'}}>
          <p onClick={props.changeVal}>€ EUR</p>
          <p onClick={props.changeVal}>₺ TRY</p>
          <p onClick={props.changeVal}>$ USD</p>
          <p onClick={props.changeVal} className='last'>£ GBP</p>
        </div>
        </div>
        <div className="my-nav-element menu-element" style={props.language?{backgroundColor:"#ecf0ff"}:null} onClick={props.languageTab}><span className='language valyuta'>{props.languageName}</span><IoIosArrowDown className='down-arrow' style={{color:"#0e568c",marginLeft:"2px"}}/>
        <div className="valyuta-tab language-tab" style={props.language?{display:'Block'}:{display:'none'}}>
          <p onClick={props.changeLan} className='lan'>EN</p>
          <p onClick={props.changeLan} className='lan'>TR</p>
          <p onClick={props.changeLan} className='lan last'>DE</p>
        </div>
        </div>
        
        </nav>
        
  )
}

export default Navbar
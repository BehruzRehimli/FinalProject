import React from 'react'
import { useParams } from 'react-router-dom'

const ResetPasword = () => {
    const {id}=useParams();
    const {token}=useParams();

  return (
    <div className='mt-5'>
        <h1>{id}</h1>
        <h1>{token}</h1>
    </div>
  )
}

export default ResetPasword
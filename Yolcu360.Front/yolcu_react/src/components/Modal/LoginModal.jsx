import { Formik, Form, Field } from 'formik';
import { useState } from 'react';
import Button from 'react-bootstrap/Button';
import Modal from 'react-bootstrap/Modal';
import { RiUser3Fill } from 'react-icons/ri'
import axios from 'axios';
import { useEffect } from 'react';
import jwt_decode from "jwt-decode";
import { useDispatch } from 'react-redux';
import { setUsername,logedYes,setToken } from '../../control/loginSlice';

function LoginModal(props) {
    const [show, setShow] = useState(false);
    const dispatch=useDispatch();


    useEffect(() => {
        if (props.user.token) {
            props.setUser(prev => { return { ...prev, isLoged: true } })
        }
    }, [props.user.token])
    const handleClose = () => setShow(false);
    const handleShow = () => setShow(true);

    return (
        <>

            <button onClick={handleShow} className='text-start bg-transparent border-0' style={{ color: "#03437f" }} >Login</button>

            <Modal
                show={show}
                onHide={handleClose}
                backdrop="static"
                keyboard={false}
            >
                <Modal.Header closeButton>
                </Modal.Header>
                <Modal.Body>
                    <div className='d-flex justify-content-left align-items-center ' style={{ padding: "10px 30px" }}>
                        <RiUser3Fill style={{ fontSize: "40px", color: "#2169aa" }} />
                        <span style={{ fontSize: "26px", fontWeight: "600", marginLeft: "20px" }}>Login</span>
                    </div>
                    <div style={{ padding: "10px 30px" }}>
                        <Formik>
                            <Formik initialValues={{
                                username: '',
                                password: "",
                            }} onSubmit={async (values) => {
                                const data = await axios.post('https://localhost:7079/api/Accounts/Login', values)
                                localStorage.setItem("YolcuToken", data.data.token)
                                const decoded = jwt_decode(data.data.token);
                                let user=decoded["http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name"]
                                dispatch(setUsername(user))
                                dispatch(logedYes())
                                dispatch(setToken(data.data.token))
                                props.setUser(prev => { return { ...prev, token: data.data.token, isLoged: true,username: decoded["http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name"]} })
                                handleClose();
                            }}>
                                {({ values }) => (
                                    <Form>
                                        <div className='d-flex'>
                                            <span className="left ">
                                                <RiUser3Fill style={{ fontSize: "20px", color: "#bbbbbb" }} />
                                            </span>
                                            <Field type="text" placeholder="Username" className="login-input username" name='username' />
                                        </div>
                                        <div>
                                            <Field type="password" placeholder="Password" className="login-input" name='password' />

                                        </div>
                                        <button type='submit' className='btn login-btn form-control '>Login</button>
                                    </Form>
                                )}
                            </Formik>

                        </Formik>

                    </div>

                </Modal.Body>
            </Modal>
        </>
    );
}
export default LoginModal;
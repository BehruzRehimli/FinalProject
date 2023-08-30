 import { configureStore } from "@reduxjs/toolkit";
 import loginReducer from "./control/loginSlice"

 export const store=configureStore({
    reducer:{
        login: loginReducer,
    }
 })
import { createSlice} from "@reduxjs/toolkit";

const initialState={
    isLogin:false,
    token:localStorage.getItem("YolcuToken"),
    username: "bexarehim"
};

const loginSlice=createSlice({
    name:"login",
    initialState,
    reducers:{
        setUsername: (state,action)=>{
            state.username=action.payload;
        },
        logedYes:(state)=>{
            state.isLogin=true;
        },
        setToken:(state,action)=>{
            state.token=action.payload
        },
        logedNo:(state)=>{
            state.isLogin=false;
        }
    }
});

export const {setUsername,logedYes,setToken,logedNo} =loginSlice.actions;
export default loginSlice.reducer;
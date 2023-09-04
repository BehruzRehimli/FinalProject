import { createSlice} from "@reduxjs/toolkit";

var current=new Date();

const initialState={
    pickUpLoc:0,
    dropOffLoc:0,
    pickUpDate:  current,
    dropOffDate:  new Date((current).getTime() + 86400000*3)
};

const rentSlice=createSlice({
    name:"rent",
    initialState,
    reducers:{
        setPickUpDate: (state,action)=>{
            state.pickUpDate=action.payload;
        },
    }
});

export const {} =rentSlice.actions;
export default rentSlice.reducer;
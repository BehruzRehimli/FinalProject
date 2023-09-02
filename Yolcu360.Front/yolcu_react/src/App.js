import './App.css';
import {BrowserRouter,Routes,Route} from "react-router-dom"
import Home from './pages/Home/Home';
import Layout from './components/Layout/Layout';
import Office from "./pages/Office/Office";
import Cars from "./pages/Cars/Cars"
import Detail from "./pages/Detail/Detail"
import AdminLayout from './components/Layout/AdminLayout';
import Dashboard from './pages/Admin/Dashboard';
import Country from './pages/Admin/Country/Country';
import CountryCreate from './pages/Admin/Country/CountryCreate';
import Login from './pages/Admin/Login';
import CountryEdit from './pages/Admin/Country/CountryEdit';
import Type from './pages/Admin/Type/Type';
import TypeCreate from './pages/Admin/Type/TypeCreate';
import TypeEdit from './pages/Admin/Type/TypeEdit';
import Brand from './pages/Admin/Brand/Brand';
import BrandCreate from './pages/Admin/Brand/BrandCreate';
import BrandEdit from './pages/Admin/Brand/BrandEdit';
import City from './pages/Admin/City/City';
import CityCreate from './pages/Admin/City/CityCreate';


function App() {
  return (
    <div className="App">
        <BrowserRouter>
        <Routes>
          <Route path='/' element={<Layout/>}>
            <Route path='/' element={<Home/>}/>
            <Route path='/office/:id' element={<Office/>}/>
            <Route path="/cars/:id" element={<Cars/>}/>
            <Route path='/detail/:id' element={<Detail/>}/>

          </Route>
          <Route path='/admin' element={<AdminLayout/>}>
            <Route path='/admin' element={<Dashboard/>}/>
            <Route path='/admin/country' element={<Country/>}/>
            <Route path='/admin/country/create' element={<CountryCreate/>}/>
            <Route path='/admin/country/edit/:id' element={<CountryEdit/>}/>
            <Route path='/admin/type' element={<Type/>}/>
            <Route path='/admin/type/create' element={<TypeCreate/>}/>
            <Route path='/admin/type/edit/:id' element={<TypeEdit/>}/>
            <Route path='/admin/brand' element={<Brand/>}/>
            <Route path='/admin/brand/create' element={<BrandCreate/>}/>
            <Route path='/admin/brand/edit/:id' element={<BrandEdit/>}/>
            <Route path='/admin/city' element={<City/>}/>
            <Route path='/admin/city/create' element={<CityCreate/>}/>

          </Route>
          <Route path='/admin/login' element={<Login/>}/>
        </Routes>
        </BrowserRouter>
    </div>
  );
}

export default App;

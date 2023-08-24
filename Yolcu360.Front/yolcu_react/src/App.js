import './App.css';
import {BrowserRouter,Routes,Route} from "react-router-dom"
import Home from './pages/Home/Home';
import Layout from './components/Layout/Layout';
import Office from "./pages/Office/Office";
import Cars from "./pages/Cars/Cars"
import Detail from "./pages/Detail/Detail"


function App() {
  return (
    <div className="App">
        <BrowserRouter>
        <Routes>
          <Route path='/' element={<Layout/>}>
            <Route path='/' element={<Home/>}/>
            <Route path='/office/:id' element={<Office/>}/>
            <Route path="/cars/:id" element={<Cars/>}/>
            <Route path="/detail" element={<Detail/>}/>
          </Route>
        </Routes>
        </BrowserRouter>
    </div>
  );
}

export default App;

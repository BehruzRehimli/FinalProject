import React, { Component } from "react";
import Slider from "react-slick";
import "./Slider.css"
import "slick-carousel/slick/slick.css"; 
import "slick-carousel/slick/slick-theme.css";

export default class VerticalSwipeToSlide extends Component {
  render() {
    const settings = {
      dots: false,
      arrows: false,
      height:"32px",
      infinite: true,
      slidesToShow: 1,
      slidesToScroll: 1,
      autoplay: true,
      autoplaySpeed:1000,
      vertical: true,
      verticalSwiping: true,
      swipeToSlide: true,
      beforeChange: function(currentSlide, nextSlide) {
      },
      afterChange: function(currentSlide) {
      }
    };
    return (
      <div>
        <Slider {...settings}>
          <div>
            <h3 className="slider-item">In Paris</h3>
          </div>
          <div>
            <h3 className="slider-item">In Roma</h3>
          </div>
          <div>
            <h3 className="slider-item">In Madrid</h3>
          </div>
          <div>
            <h3 className="slider-item">In Ankara</h3>
          </div>
          <div>
            <h3 className="slider-item">In Baku</h3>
          </div>
          <div>
            <h3 className="slider-item">In Berlin</h3>
          </div>
        </Slider>
      </div>
    );
  }
}
﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.DesignPattern.Behavioral_ObserverDesignPattern
{
    public class BaggageInfo
    {
        private int flightNo;
        private string origin;
        private int location;

        internal BaggageInfo(int flight, string from, int carousel)
        {
            this.flightNo = flight;
            this.origin = from;
            this.location = carousel;
        }

        public int FlightNumber
        {
            get { return this.flightNo; }
        }

        public string From
        {
            get { return this.origin; }
        }

        public int Carousel
        {
            get { return this.location; }
        }
    }
}

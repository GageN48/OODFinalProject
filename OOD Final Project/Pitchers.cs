using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD_Final_Project
{
    internal class Pitchers
    {
        private double leagueERA = 4.44;

        private double _ER;
        private double _IP;
        private double _ERA;
        private double _W;
        private double _L;
        private double _H;
        private double _BB;

        private double _filler1;
        private double _filler2;
        private double _filler3;
        private double _filler4;
        private double _filler5;
        private double _filler6;
        private double _filler7;
        private double _filler8;
        private double _filler9;
        private double _filler10;

        public double ER
        {
            get { return _ER; }
            set { _ER = value; }
        }
        public double IP
        {
            get { return _IP; }
            set { _IP = value; }
        }
        public double ERA
        {
            get { return _ERA; }
            set { _ERA = value; }
        }
        public double W
        {
            get { return _W; }
            set { _W = value; }
        }
        public double L
        {
            get { return _L; }
            set { _L = value; }
        }
        public double H
        {
            get { return _H; }
            set { _H = value; }
        }
        public double BB
        {
            get { return _BB; }
            set { _BB = value; }
        }

        public Pitchers(double ER, double IP)
        {
            _ER = ER;
            _IP = IP;
        }
        public Pitchers(double ERA)
        {
            _ERA = ERA;
        }
        public Pitchers(double W, double L, double filler1)
        {
            _W = W;
            _L = L;
            _filler1 = filler1;
        }
        public Pitchers(double H, double BB, double IP, double filler1)
        {
            _H = H;
            _BB = BB;
            _IP = IP;
            _filler1 = filler1;
        }

        public double CalculateERA()
        {
            return (9 * ER) / IP;
        }
        public double CalculateERAPlus()
        {
            return (leagueERA * 100) / ERA;
        }
        public double CalculateWPCT()
        {
            return (W / (W + L));
        }
        public double CalculateWHIP()
        {
            return (BB + H) / IP;
        }

    }
}

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
        private double _HR;
        private double _K;

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
        public double HR
        {
            get { return _HR; }
            set { _HR = value; }
        }
        public double K
        {
            get { return _K; }
            set { _K = value; }
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
        public Pitchers(double HR, double IP, double filler1, double filler2, double filler3)
        {
            _HR = HR;
            _IP = IP;
            _filler1 = filler1;
            _filler2 = filler2;
            _filler3 = filler3;
        }
        public Pitchers(double H, double IP, double filler1, double filler2, double filler3, double filler4)
        {
            _H = H;
            _IP = IP;
            _filler1 = filler1;
            _filler2 = filler2;
            _filler3 = filler3;
            _filler4 = filler4;
        }
        public Pitchers(double BB, double IP, double filler1, double filler2, double filler3, double filler4, double filler5)
        {
            _BB = BB;
            _IP = IP;
            _filler1 = filler1;
            _filler2 = filler2;
            _filler3 = filler3;
            _filler4 = filler4;
            _filler5 = filler5;
        }
        public Pitchers(double K, double IP, double filler1, double filler2, double filler3, double filler4, double filler5, double filler6)
        {
            _K = K;
            _IP = IP;
            _filler1 = filler1;
            _filler2 = filler2;
            _filler3 = filler3;
            _filler4 = filler4;
            _filler5 = filler5;
            _filler6 = filler6;
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
        public double CalculateHRper9()
        {
            return (HR * 9) / IP;
        }
        public double CalculateHper9()
        {
            return (H * 9) / IP;
        }
        public double CalculateBBper9()
        {
            return (BB * 9) / IP;
        }
        public double CalculateKper9()
        {
            return (K * 9) / IP;
        }
    }
}

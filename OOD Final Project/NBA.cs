using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD_Final_Project
{
    internal class NBA
    {
        private double tsan = 0.44;
        private double tspn = 2;
        private double ftmi = 0;
        private double fgmi = 0;
        private double sheffn = 0.5;
        private double _m;
        private double _g;
        private double _fgm;
        private double _fga;
        private double _tpm;
        private double _tpa;
        private double _ftm;
        private double _fta;
        private double _pt;
        private double _tsa;
        private double _or;
        private double _dr;
        private double _a;
        private double _s;
        private double _b;
        private double _t;

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
        private double _filler11;
        private double _filler12;
        private double _filler13;
        public double m
        {
            get { return _m; }
            set { _m = value; }
        }

        public double g
        {
            get { return _g; }
            set { _g = value; }
        }

        public double fgm
        {
            get { return _fgm; }
            set { _fgm = value; }
        }

        public double fga
        {
            get { return _fga; }
            set { _fga = value; }
        }

        public double tpm
        {
            get { return _tpm; }
            set { _tpm = value; }
        }

        public double tpa
        {
            get { return _tpa; }
            set { _tpa = value; }
        }

        public double ftm
        {
            get { return _ftm; }
            set { _ftm = value; }
        }

        public double fta
        {
            get { return _fta; }
            set { _fta = value; }
        }

        public double pt
        {
            get { return _pt; }
            set { _pt = value; }
        }

        public double tsa
        {
            get { return _tsa; }
            set { _tsa = value; }
        }

        public double or
        {
            get { return _or; }
            set { _or = value; }
        }

        public double dr
        {
            get { return _dr; }
            set { _dr = value; }
        }

        public double a
        {
            get { return _a; }
            set { _a = value; }
        }

        public double s
        {
            get { return _s; }
            set { _s = value; }
        }

        public double b
        {
            get { return _b; }
            set { _b = value; }
        }

        public double t
        {
            get { return _t; }
            set { _t = value; }
        }
        public NBA(double g, double m)
        {
            _g = g;
            _m = m;
        }

        public NBA(double fgm, double fga, double filler1)
        {
            _fgm = fgm;
            _fga = fga;
            _filler1 = filler1;
        }

        public NBA(double tpm, double tpa, double filler1, double filler2)
        {
            _tpm = tpm;
            _tpa = tpa;
            _filler1 = filler1;
            _filler2 = filler2;
        }

        public NBA(double ftm, double fta, double filler1, double filler2, double filler3)
        {
            _ftm = ftm;
            _fta = fta;
            _filler1 = filler1;
            _filler2 = filler2;
            _filler3 = filler3;
        }

        public NBA(double fga, double fta, double filler1, double filler2, double filler3, double filler4)
        {
            _fga = fga;
            _fta = fta;
            _filler1 = filler1;
            _filler2 = filler2;
            _filler3 = filler3;
            _filler4 = filler4;
        }

        public NBA(double pt, double tsa, double filler13, double filler1, double filler2, double filler3, double filler4, double filler5, double filler6, double filler7, double filler8, double filler9, double filler10, double filler11, double filler12)
        {
            _pt = pt;
            _tsa = tsa;

            _filler13 = filler13;
            _filler1 = filler1;
            _filler2 = filler2;
            _filler3 = filler3;
            _filler4 = filler4;
            _filler5 = filler5;
            _filler6 = filler6;
            _filler7 = filler7;
            _filler8 = filler8;
            _filler9 = filler9;
            _filler10 = filler10;
            _filler11 = filler11;
            _filler12 = filler12;
        }
        public NBA(double pt, double or, double dr, double a, double s, double b, double t, double g)
        {
            _pt = pt;
            _or = or;
            _dr = dr;
            _a = a;
            _s = s;
            _b = b;
            _t = t;
            _g = g;
        }
        public NBA(double fgm, double tpm, double fga, double filler1, double filler2, double filler3, double filler4)
        {
            _fgm = fgm;
            _tpm = tpm;
            _fga = fga;
            _filler1 = filler1;
            _filler2 = filler2;
            _filler3 = filler3;
            _filler4 = filler4;
        }
        public NBA(double s, double g, double filler1, double filler2, double filler3, double filler4, double filler5, double filler6, double filler7)
        {
            _s = s;
            _g = g;
            _filler1 = filler1;
            _filler2 = filler2;
            _filler3 = filler3;
            _filler4 = filler4;
            _filler5 = filler5;
            _filler6 = filler6;
            _filler7 = filler7;
        }

        public NBA(double t, double g, double filler1, double filler2, double filler3, double filler4, double filler5, double filler6, double filler7, double filler8)
        {
            _t = t;
            _g = g;
            _filler1 = filler1;
            _filler2 = filler2;
            _filler3 = filler3;
            _filler4 = filler4;
            _filler5 = filler5;
            _filler6 = filler6;
            _filler7 = filler7;
            _filler8 = filler8;
        }

        public NBA(double a, double g, double filler1, double filler2, double filler3, double filler4, double filler5, double filler6, double filler7, double filler8, double filler9)
        {
            _a = a;
            _g = g;
            _filler1 = filler1;
            _filler2 = filler2;
            _filler3 = filler3;
            _filler4 = filler4;
            _filler5 = filler5;
            _filler6 = filler6;
            _filler7 = filler7;
            _filler8 = filler8;
            _filler9 = filler9;
        }

        public NBA(double b, double g, double filler1, double filler2, double filler3, double filler4, double filler5, double filler6, double filler7, double filler8, double filler9, double filler10)
        {
            _b = b;
            _g = g;
            _filler1 = filler1;
            _filler2 = filler2;
            _filler3 = filler3;
            _filler4 = filler4;
            _filler5 = filler5;
            _filler6 = filler6;
            _filler7 = filler7;
            _filler8 = filler8;
            _filler9 = filler9;
            _filler10 = filler10;
        }

        public NBA(double a, double t, double filler1, double filler2, double filler3, double filler4, double filler5, double filler6, double filler7, double filler8, double filler9, double filler10, double filler11)
        {
            _a = a;
            _t = t;
            _filler1 = filler1;
            _filler2 = filler2;
            _filler3 = filler3;
            _filler4 = filler4;
            _filler5 = filler5;
            _filler6 = filler6;
            _filler7 = filler7;
            _filler8 = filler8;
            _filler9 = filler9;
            _filler10 = filler10;
            _filler11 = filler11;
        }
        public NBA(double or, double dr, double g, double filler1, double filler2, double filler3, double filler4, double filler5, double filler6, double filler7, double filler8, double filler9, double filler10, double filler11)
        {
            _or = or;
            _dr = dr;
            _g = g;
            _filler1 = filler1;
            _filler2 = filler2;
            _filler3 = filler3;
            _filler4 = filler4;
            _filler5 = filler5;
            _filler6 = filler6;
            _filler7 = filler7;
            _filler8 = filler8;
            _filler9 = filler9;
            _filler10 = filler10;
            _filler11 = filler11;
        }


        public double CalculateMPG()
        {
            return (m / g);
        }

        public double CalculateFGP()
        {
            return (fgm / fga);
        }

        public double CalculateTPP()
        {
            return (tpm / tpa);
        }

        public double CalculateFTP()
        {
            return (ftm / fta);
        }

        public double CalculateTSA()
        {
            return (fga + tsan * fta);
        }

        public double CalculateTS()
        {
            return (pt / (tspn * tsa));
        }

        public double CalculateSCEFF()
        {
            ftmi = fta - ftm;
            fgmi = fga - fgm;

            return ((pt + or + dr + a + s + b - ftmi - fgmi - t) / g);
        }

        public double CalculateSHEFF()
        {
            return ((fgm + sheffn * tpm) / fga);
        }

        public double CalculateSTLPG()
        {
            return (s / g);
        }

        public double CalculateTOPG()
        {
            return (t / g);
        }

        public double CalculateASTSPG()
        {
            return (a / g);
        }

        public double CalculateBLKPG()
        {
            return (b / g);
        }

        public double CalculateASTTO()
        {
            return (a / t);
        }

        public double CalculateREBPG()
        {
            return ((or + dr) / g);
        }
    }

}

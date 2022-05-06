using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD_Final_Project
{
    internal class WNBA
    {
        private double Wtsan = 0.44;
        private double Wtspn = 2;
        private double Wftmi = 0;
        private double Wfgmi = 0;
        private double Wsheffn = 0.5;
        private double _Wm;
        private double _Wg;
        private double _Wfgm;
        private double _Wfga;
        private double _Wtpm;
        private double _Wtpa;
        private double _Wftm;
        private double _Wfta;
        private double _Wpt;
        private double _Wtsa;
        private double _Wor;
        private double _Wdr;
        private double _Wa;
        private double _Ws;
        private double _Wb;
        private double _Wt;

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
        public double Wm
        {
            get { return _Wm; }
            set { _Wm = value; }
        }

        public double Wg
        {
            get { return _Wg; }
            set { _Wg = value; }
        }

        public double Wfgm
        {
            get { return _Wfgm; }
            set { _Wfgm = value; }
        }

        public double Wfga
        {
            get { return _Wfga; }
            set { _Wfga = value; }
        }

        public double Wtpm
        {
            get { return _Wtpm; }
            set { _Wtpm = value; }
        }

        public double Wtpa
        {
            get { return _Wtpa; }
            set { _Wtpa = value; }
        }

        public double Wftm
        {
            get { return _Wftm; }
            set { _Wftm = value; }
        }

        public double Wfta
        {
            get { return _Wfta; }
            set { _Wfta = value; }
        }

        public double Wpt
        {
            get { return _Wpt; }
            set { _Wpt = value; }
        }

        public double Wtsa
        {
            get { return _Wtsa; }
            set { _Wtsa = value; }
        }

        public double Wor
        {
            get { return _Wor; }
            set { _Wor = value; }
        }

        public double Wdr
        {
            get { return _Wdr; }
            set { _Wdr = value; }
        }

        public double Wa
        {
            get { return _Wa; }
            set { _Wa = value; }
        }

        public double Ws
        {
            get { return _Ws; }
            set { _Ws = value; }
        }

        public double Wb
        {
            get { return _Wb; }
            set { _Wb = value; }
        }

        public double Wt
        {
            get { return _Wt; }
            set { _Wt = value; }
        }
        public WNBA(double Wg, double Wm)
        {
            _Wg = Wg;
            _Wm = Wm;
        }

        public WNBA(double Wfgm, double Wfga, double filler1)
        {
            _Wfgm = Wfgm;
            _Wfga = Wfga;
            _filler1 = filler1;
        }

        public WNBA(double Wtpm, double Wtpa, double filler1, double filler2)
        {
            _Wtpm = Wtpm;
            _Wtpa = Wtpa;
            _filler1 = filler1;
            _filler2 = filler2;
        }

        public WNBA(double Wftm, double Wfta, double filler1, double filler2, double filler3)
        {
            _Wftm = Wftm;
            _Wfta = Wfta;
            _filler1 = filler1;
            _filler2 = filler2;
            _filler3 = filler3;
        }

        public WNBA(double Wfga, double Wfta, double filler1, double filler2, double filler3, double filler4)
        {
            _Wfga = Wfga;
            _Wfta = Wfta;
            _filler1 = filler1;
            _filler2 = filler2;
            _filler3 = filler3;
            _filler4 = filler4;
        }

        public WNBA(double Wpt, double Wtsa, double filler13, double filler1, double filler2, double filler3, double filler4, double filler5, double filler6, double filler7, double filler8, double filler9, double filler10, double filler11, double filler12)
        {
            _Wpt = Wpt;
            _Wtsa = Wtsa;

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
        public WNBA(double Wpt, double Wor, double Wdr, double Wa, double Ws, double Wb, double Wt, double Wg)
        {
            _Wpt = Wpt;
            _Wor = Wor;
            _Wdr = Wdr;
            _Wa = Wa;
            _Ws = Ws;
            _Wb = Wb;
            _Wt = Wt;
            _Wg = Wg;
        }
        public WNBA(double Wfgm, double Wtpm, double Wfga, double filler1, double filler2, double filler3, double filler4)
        {
            _Wfgm = Wfgm;
            _Wtpm = Wtpm;
            _Wfga = Wfga;
            _filler1 = filler1;
            _filler2 = filler2;
            _filler3 = filler3;
            _filler4 = filler4;
        }
        public WNBA(double Ws, double Wg, double filler1, double filler2, double filler3, double filler4, double filler5, double filler6, double filler7)
        {
            _Ws = Ws;
            _Wg = Wg;
            _filler1 = filler1;
            _filler2 = filler2;
            _filler3 = filler3;
            _filler4 = filler4;
            _filler5 = filler5;
            _filler6 = filler6;
            _filler7 = filler7;
        }

        public WNBA(double Wt, double Wg, double filler1, double filler2, double filler3, double filler4, double filler5, double filler6, double filler7, double filler8)
        {
            _Wt = Wt;
            _Wg = Wg;
            _filler1 = filler1;
            _filler2 = filler2;
            _filler3 = filler3;
            _filler4 = filler4;
            _filler5 = filler5;
            _filler6 = filler6;
            _filler7 = filler7;
            _filler8 = filler8;
        }

        public WNBA(double Wa, double Wg, double filler1, double filler2, double filler3, double filler4, double filler5, double filler6, double filler7, double filler8, double filler9)
        {
            _Wa = Wa;
            _Wg = Wg;
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

        public WNBA(double Wb, double Wg, double filler1, double filler2, double filler3, double filler4, double filler5, double filler6, double filler7, double filler8, double filler9, double filler10)
        {
            _Wb = Wb;
            _Wg = Wg;
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

        public WNBA(double Wa, double Wt, double filler1, double filler2, double filler3, double filler4, double filler5, double filler6, double filler7, double filler8, double filler9, double filler10, double filler11)
        {
            _Wa = Wa;
            _Wt = Wt;
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
        public WNBA(double Wor, double Wdr, double Wg, double filler1, double filler2, double filler3, double filler4, double filler5, double filler6, double filler7, double filler8, double filler9, double filler10, double filler11)
        {
            _Wor = Wor;
            _Wdr = Wdr;
            _Wg = Wg;
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
            return (Wm / Wg);
        }

        public double CalculateFGP()
        {
            return (Wfgm / Wfga);
        }

        public double CalculateTPP()
        {
            return (Wtpm / Wtpa);
        }

        public double CalculateFTP()
        {
            return (Wftm / Wfta);
        }

        public double CalculateTSA()
        {
            return (Wfga + Wtsan * Wfta);
        }

        public double CalculateTS()
        {
            return (Wpt / (Wtspn * Wtsa));
        }

        public double CalculateSCEFF()
        {
            Wftmi = Wfta - Wftm;
            Wfgmi = Wfga - Wfgm;

            return ((Wpt + Wor + Wdr + Wa + Ws + Wb - Wftmi - Wfgmi - Wt) / Wg);
        }

        public double CalculateSHEFF()
        {
            return ((Wfgm + Wsheffn * Wtpm) / Wfga);
        }

        public double CalculateSTLPG()
        {
            return (Ws / Wg);
        }

        public double CalculateTOPG()
        {
            return (Wt / Wg);
        }

        public double CalculateASTSPG()
        {
            return (Wa / Wg);
        }

        public double CalculateBLKPG()
        {
            return (Wb / Wg);
        }

        public double CalculateASTTO()
        {
            return (Wa / Wt);
        }

        public double CalculateREBPG()
        {
            return ((Wor + Wdr) / Wg);
        }
    }
}

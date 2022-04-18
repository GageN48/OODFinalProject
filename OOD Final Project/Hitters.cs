using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OOD_Final_Project
{
    internal class Hitters
    {
        private double singles;
        private double leagueOPS = 0.728;
        private double NIBBFactor = 0.69;
        private double HBPFactor = 0.72;
        private double singleFactor = 0.89;
        private double doubleFactor = 1.27;
        private double tripleFactor = 1.62;
        private double homeRunFactor = 2.10;
        private double wOBAScale = 1.25;
        private double leaguewOBA = 0.320;
        private double leagueRperPA = 0.114;
        private double parkFactor = 1;
        private double leagueWRC = 10032;
        private double leaguePA = 85797;

        private double _hits;
        private double _atBats;
        private double _doubles;
        private double _triples;
        private double _homeRuns;
        private double _obp;
        private double _slg;
        private double _sf;
        private double _k;
        private double _avg;
        private double _ops;
        private double _pa;
        private double _tb;
        private double _bb;
        private double _hbp;
        private double _ibb;
        private double _wOBA;
        private double _wRAA;

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

        public double hits
        {
            get { return _hits; }
            set { _hits = value; }
        }

        public double atBats
        {
            get { return _atBats; }
            set { _atBats = value; }
        }

        public double doubles
        {
            get { return _doubles; }
            set { _doubles = value; }
        }

        public double triples
        {
            get { return _triples; }
            set { _triples = value; }
        }

        public double homeRuns
        {
            get { return _homeRuns; }
            set { _homeRuns = value; }
        }

        public double obp
        {
            get { return _obp; }
            set { _obp = value; }
        }

        public double slg
        {
            get { return _slg; }
            set { _slg = value; }
        }

        public double sf
        {
            get { return _sf; }
            set { _sf = value; }
        }

        public double k
        {
            get { return _k; }
            set { _k = value; }
        }

        public double avg
        {
            get { return _avg; }
            set { _avg = value; }
        }

        public double ops
        {
            get { return _ops; }
            set { _ops = value; }
        }

        public double pa
        {
            get { return _pa; }
            set { _pa = value; }
        }

        public double tb
        {
            get { return _tb; }
            set { _tb = value; }
        }

        public double bb
        {
            get { return _bb; }
            set { _bb = value; }
        }

        public double hbp
        {
            get { return _hbp; }
            set { _hbp = value; }
        }

        public double ibb
        {
            get { return _ibb; }
            set { _ibb = value; }
        }

        public double wOBA
        {
            get { return _wOBA; }
            set { _wOBA = value; }
        }

        public double wRAA
        {
            get { return _wRAA; }
            set { _wRAA = value; }
        }

        public Hitters(double hits, double atBats)
        {
            _hits = hits;
            _atBats = atBats;
        }

        public Hitters(double hits, double atBats, double doubles, double triples, double homeRuns)
        {
            _hits = hits;
            _atBats = atBats;
            _doubles = doubles;
            _triples = triples;
            _homeRuns = homeRuns;
        }

        public Hitters(double obp, double slg, double filler1)
        {
            _obp = obp;
            _slg = slg;
            _filler1 = filler1;
        }

        public Hitters(double hits, double doubles, double triples, double homeRuns)
        {
            _hits = hits;
            _doubles = doubles;
            _triples = triples;
            _homeRuns = homeRuns;
        }

        public Hitters(double hits, double atBats, double homeRuns, double sf, double k, double filler1)
        {
            _hits = hits;
            _atBats = atBats;
            _homeRuns = homeRuns;
            _sf = sf;
            _k = k;
            _filler1 = filler1;
        }

        public Hitters(double doubles, double triples, double homeRuns, double atBats, double filler1, double filler2, double filler3)
        {
            _doubles = doubles;
            _triples = triples;
            _homeRuns = homeRuns;
            _atBats = atBats;
            _filler1 = filler1;
            _filler2 = filler2;
            _filler3 = filler3;
        }

        public Hitters(double pa, double k, double filler1, double filler2, double filler3, double filler4, double filler5, double filler6)
        {
            _pa = pa;
            _k = k;
            _filler1 = filler1;
            _filler2 = filler2;
            _filler3 = filler3;
            _filler4 = filler4;
            _filler5 = filler5;
            _filler6 = filler6;
        }

        public Hitters(double tb, double hits, double bb, double hbp, double ibb, double atBats, double filler1, double filler2, double filler3)
        {
            _tb = tb;
            _hits = hits;
            _bb = bb;
            _hbp = hbp;
            _ibb = ibb;
            _atBats = atBats;
            _filler1 = filler1;
            _filler2 = filler2;
            _filler3 = filler3;
        }

        public Hitters(double ops)
        {
            _ops = ops;
        }

        public Hitters(double bb, double hbp, double hits, double doubles, double triples, double homeRuns, double atBats, double ibb, double sf, double filler1)
        {
            _bb = bb;
            _hbp = hbp;
            _hits = hits;
            _doubles = doubles;
            _triples = triples;
            _homeRuns = homeRuns;
            _atBats = atBats ;
            _ibb = ibb ;
            _sf = sf ;
            _filler1 = filler1 ;
        }

        public Hitters(double wOBA, double pa, double filler1, double filler2, double filler3, double filler4, double filler5, double filler6, double filler7, double filler8, double filler9)
        {
            _wOBA = wOBA;
            _pa = pa;
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

        public Hitters(double wRAA, double pa, double filler1, double filler2, double filler3, double filler4, double filler5, double filler6, double filler7, double filler8, double filler9, double filler10)
        {
            _wRAA = wRAA;
            _pa = pa;
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

        public double CalculateBA()
        {
            return (hits / atBats);
        }

        public double CalculateSLG()
        {
            singles = hits - doubles - triples - homeRuns;

            return (singles + (doubles * 2) + (triples * 3) + (homeRuns * 4)) / atBats;
        }

        public double CalculateOPS()
        {
            return obp + slg;
        }

        public double CalculateTB()
        {
            singles = hits - doubles - triples - homeRuns;
            return (singles + (doubles * 2) + (triples * 3) + (homeRuns * 4));
        }

        public double CalculateBABIP()
        {
            return ((hits - homeRuns) / (atBats - k - homeRuns + sf));
        }

        public double CalculateISO()
        {
            return ((doubles + (triples * 2) + (homeRuns * 3))/(atBats));
        }

        public double CalculateOPSPlus()
        {
            return (ops / leagueOPS) * 100;
        }

        public double CalculatePASO()
        {
            return pa / k;
        }

        public double CalculateRC()
        {
            return (tb * (hits + bb + hbp + ibb) / (atBats + bb + hbp + ibb));
            //return (tb * (hits + bb) / (atBats + bb));
        }

        public double CalculateWOBA()
        {
            singles = hits - doubles - triples - homeRuns;

            return (((NIBBFactor * bb) + (HBPFactor * hbp) + (singleFactor * singles) + (doubleFactor * doubles) + (tripleFactor * triples) + (homeRunFactor * homeRuns))
                / (atBats + bb - ibb + sf + hbp));
        }

        public double CalculatewRAA()
        {
            return (((wOBA - leaguewOBA) / (wOBAScale)) * pa);
        }

        public double CalculatewRCPlus()
        {
           return (((wRAA / pa) + leagueRperPA) + (leagueRperPA - (parkFactor * leagueRperPA))) / (leagueWRC / leaguePA) * 100;
            //(((wRAA per PA + league runs per PA) + (league runs per PA - ballpark factor x
            //league runs per PA) / league wRC per plate appearance, not including pitchers)) x 100.
        }
    }
}

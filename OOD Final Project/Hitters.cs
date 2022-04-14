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
        private double _hits;
        private double _atBats;
        private double _doubles;
        private double _triples;
        private double _homeRuns;
        private double singles;
        private double _obp;
        private double _slg;

        private double _filler1;
//        private double _filler2;
//        private double _filler3;
//        private double _filler4;
//        private double _filler5;

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

        public double filler1
        {
            get { return _filler1; }
            set { _filler1 = value; }
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
            filler1 = 0;
            return obp + slg;
        }

        public double CalculateTB()
        {
            singles = hits - doubles - triples - homeRuns;
            return (singles + (doubles * 2) + (triples * 3) + (homeRuns * 4));
        }
    }
}

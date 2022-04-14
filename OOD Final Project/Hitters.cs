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

        public Hitters(double hits, double atBats)
        {
            _hits = hits;
            _atBats = atBats;
        }

        public Hitters(double hits, double doubles, double triples, double homeRuns, double atBats)
        {
            _hits = hits;
            _doubles = doubles;
            _triples = triples;
            _homeRuns = homeRuns;
            _atBats = atBats;
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
    }
}

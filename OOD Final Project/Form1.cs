using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace OOD_Final_Project
{
    public partial class Form1 : Form
    {
        string[] firstName = new string[0];
        string[] lastName = new string[0];
        string[] team = new string[0];
        double[] plateAppearaces = new double[0];
        double[] atBats = new double[0];
        double[] runs = new double[0];
        double[] hits = new double[0];
        double[] doubles = new double[0];
        double[] triples = new double[0];
        double[] homeRuns = new double[0];
        double[] runsBattedIn = new double[0];
        double[] steals = new double[0];
        double[] caughtStealing = new double[0];
        double[] walks = new double[0];
        double[] strikeOuts = new double[0];
        double[] battingAverage = new double[0];
        double[] onBasePercentage = new double[0];
        double[] slugging = new double[0];
        double[] onBasePlusSlugging = new double[0];
        double[] totalBases = new double[0];
        double[] sacrificeFlies = new double[0];
        double[] hitByPitch = new double[0];
        double[] intentionalWalks = new double[0];
        double[] battingAverageOnBallsInPlay = new double[0];
        double[] isolatedPower = new double[0];
        double[] OPSPlus = new double[0];
        double[] plateAppearancesPerStrikeOut = new double[0];
        double[] runsCreated = new double[0];
        double[] weightedOnBaseAverage = new double[0];
        double[] weightRunsCretedPlus = new double[0];
        double[] weightRunsAboveAverage = new double[0];
        string[] division = new string[0];
        string[] league = new string[0];
        string[] position = new string[0];
        int num = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            rtbOut.Clear();
            rtbLabels.Clear();

            if (radHitters.Checked)
            {
                rtbLabels.AppendText("Team Player              ");


                double h = 0;
                double ab = 0;
                double d = 0;
                double t = 0;
                double hr = 0;
                double avg = 0;
                double obp = 0;
                double slg = 0;
                double hbp = 0;
                double sf = 0;
                double ibb = 0;
                double k = 0;
                double ops = 0;
                double pa = 0;
                double tb = 0;
                double bb = 0;
                double rc = 0;
                double wOBA = 0;
                double wRAA = 0;

                string path = @"Hitters.csv";
                StreamReader textIn = new StreamReader(
                new FileStream(path, FileMode.Open, FileAccess.Read));

                if (cbPA.Checked)
                    rtbLabels.AppendText("  PA");
                if (cbAB.Checked)
                    rtbLabels.AppendText("  AB");
                if (cbR.Checked)
                    rtbLabels.AppendText("   R");
                if (cbH.Checked)
                    rtbLabels.AppendText("   H");
                if (cb2B.Checked)
                    rtbLabels.AppendText("  2B");
                if (cb3B.Checked)
                    rtbLabels.AppendText("  3B");
                if (cbHR.Checked)
                    rtbLabels.AppendText("  HR");
                if (cbRBI.Checked)
                    rtbLabels.AppendText(" RBI");
                if (cbSB.Checked)
                    rtbLabels.AppendText("  SB");
                if (cbCS.Checked)
                    rtbLabels.AppendText("  CS");
                if (cbBB.Checked)
                    rtbLabels.AppendText("  BB");
                if (cbSO.Checked)
                    rtbLabels.AppendText("  SO");
                if (cbAVG.Checked)
                    rtbLabels.AppendText("   AVG");
                if (cbOBP.Checked)
                    rtbLabels.AppendText("   OBP");
                if (cbSLG.Checked)
                    rtbLabels.AppendText("   SLG");
                if (cbOPS.Checked)
                    rtbLabels.AppendText("   OPS");
                if (cbTB.Checked)
                    rtbLabels.AppendText("  TB");
                if (cbSF.Checked)
                    rtbLabels.AppendText(" HBP");
                if (cbHBP.Checked)
                    rtbLabels.AppendText("  SF");
                if (cbIBB.Checked)
                    rtbLabels.AppendText(" IBB");
                if (cbBABIP.Checked)
                    rtbLabels.AppendText(" BABIP");
                if (cbISO.Checked)
                    rtbLabels.AppendText("   ISO");
                if (cbOPSPlus.Checked)
                    rtbLabels.AppendText(" OPS+");
                if (cbPASO.Checked)
                    rtbLabels.AppendText(" PA/SO");
                if (cbRC.Checked)
                    rtbLabels.AppendText("    RC");
                if (cbwOBA.Checked)
                    rtbLabels.AppendText("  wOBA");
                if (cbwRCPlus.Checked)
                    rtbLabels.AppendText("  wRC+");
                if (cbwRAA.Checked)
                    rtbLabels.AppendText("  wRAA");

                while (textIn.Peek() != -1)
                {
                    Array.Resize<string>(ref team, team.Length + 1);
                    Array.Resize<string>(ref firstName, firstName.Length + 1);
                    Array.Resize<string>(ref lastName, lastName.Length + 1);
                    Array.Resize<string>(ref division, division.Length + 1);
                    Array.Resize<string>(ref league, league.Length + 1);
                    Array.Resize<string>(ref position, league.Length + 1);

                    string row = textIn.ReadLine();
                    string[] record = row.Split(',');
                    team[num] = Convert.ToString(record[2]).ToUpper();
                    firstName[num] = Convert.ToString(record[3]).ToUpper();
                    lastName[num] = Convert.ToString(record[4]).ToUpper();
                    division[num] = Convert.ToString(record[1]).ToUpper();
                    league[num] = Convert.ToString(record[0]).ToUpper();
                    position[num] = Convert.ToString(record[5]).ToUpper();


                    Array.Resize<double>(ref plateAppearaces, plateAppearaces.Length + 1);
                    plateAppearaces[num] = Convert.ToDouble(record[18]);
                    pa = Convert.ToDouble(record[18]);

                    Array.Resize<double>(ref atBats, atBats.Length + 1);
                    atBats[num] = Convert.ToDouble(record[6]);
                    ab = Convert.ToDouble(record[6]);

                    Array.Resize<double>(ref runs, runs.Length + 1);
                    runs[num] = Convert.ToDouble(record[7]);

                    Array.Resize<double>(ref hits, hits.Length + 1);
                    hits[num] = Convert.ToDouble(record[8]);
                    h = Convert.ToDouble(record[8]);

                    Array.Resize<double>(ref doubles, doubles.Length + 1);
                    doubles[num] = Convert.ToDouble(record[9]);
                    d = Convert.ToDouble(record[9]);

                    Array.Resize<double>(ref triples, triples.Length + 1);
                    triples[num] = Convert.ToDouble(record[10]);
                    t = Convert.ToDouble(record[10]);

                    Array.Resize<double>(ref homeRuns, homeRuns.Length + 1);
                    homeRuns[num] = Convert.ToDouble(record[11]);
                    hr = Convert.ToDouble(record[11]);

                    Array.Resize<double>(ref runsBattedIn, runsBattedIn.Length + 1);
                    runsBattedIn[num] = Convert.ToDouble(record[12]);

                    Array.Resize<double>(ref steals, steals.Length + 1);
                    steals[num] = Convert.ToDouble(record[13]);

                    Array.Resize<double>(ref caughtStealing, caughtStealing.Length + 1);
                    caughtStealing[num] = Convert.ToDouble(record[14]);

                    Array.Resize<double>(ref walks, walks.Length + 1);
                    walks[num] = Convert.ToDouble(record[15]);
                    bb = Convert.ToDouble(record[15]);

                    Array.Resize<double>(ref strikeOuts, strikeOuts.Length + 1);
                    strikeOuts[num] = Convert.ToDouble(record[16]);
                    k = Convert.ToDouble(record[16]);

                    Array.Resize<double>(ref battingAverage, battingAverage.Length + 1);
                    var AVG = new Hitters(h, ab);
                    battingAverage[num] = AVG.CalculateBA();
                    avg = Convert.ToDouble(battingAverage[num]);

                    Array.Resize<double>(ref onBasePercentage, onBasePercentage.Length + 1);
                    onBasePercentage[num] = Convert.ToDouble(record[17]);
                    obp = Convert.ToDouble(record[17]);

                    Array.Resize<double>(ref slugging, slugging.Length + 1);
                    var SLG = new Hitters(h, ab, d, t, hr);
                    slugging[num] = SLG.CalculateSLG();
                    slg = Convert.ToDouble(slugging[num]);

                    Array.Resize<double>(ref onBasePlusSlugging, onBasePlusSlugging.Length + 1);
                    var OPS = new Hitters(obp, slg, 0);
                    onBasePlusSlugging[num] = OPS.CalculateOPS();
                    ops = Convert.ToDouble(onBasePlusSlugging[num]);

                    Array.Resize<double>(ref totalBases, totalBases.Length + 1);
                    var TB = new Hitters(h, d, t, hr);
                    totalBases[num] = TB.CalculateTB();
                    tb = Convert.ToDouble(totalBases[num]);

                    Array.Resize<double>(ref onBasePercentage, onBasePercentage.Length + 1);
                    onBasePercentage[num] = Convert.ToDouble(record[17]);
                    obp = Convert.ToDouble(record[17]);

                    Array.Resize<double>(ref hitByPitch, hitByPitch.Length + 1);
                    hitByPitch[num] = Convert.ToDouble(record[19]);
                    hbp = Convert.ToDouble(record[19]);

                    Array.Resize<double>(ref sacrificeFlies, sacrificeFlies.Length + 1);
                    sacrificeFlies[num] = Convert.ToDouble(record[20]);
                    sf = Convert.ToDouble(record[20]);

                    Array.Resize<double>(ref intentionalWalks, intentionalWalks.Length + 1);
                    intentionalWalks[num] = Convert.ToDouble(record[21]);
                    ibb = Convert.ToDouble(record[21]);

                    Array.Resize<double>(ref battingAverageOnBallsInPlay, battingAverageOnBallsInPlay.Length + 1);
                    var BABIP = new Hitters(h, ab, hr, sf, k, 0);
                    battingAverageOnBallsInPlay[num] = BABIP.CalculateBABIP();

                    Array.Resize<double>(ref isolatedPower, isolatedPower.Length + 1);
                    var ISO = new Hitters(d, t, hr, ab, 0, 0, 0);
                    isolatedPower[num] = ISO.CalculateISO();

                    Array.Resize<double>(ref OPSPlus, OPSPlus.Length + 1);
                    var OPSp = new Hitters(ops);
                    OPSPlus[num] = OPSp.CalculateOPSPlus();

                    Array.Resize<double>(ref plateAppearancesPerStrikeOut, plateAppearancesPerStrikeOut.Length + 1);
                    var PASO = new Hitters(pa, k, 0, 0, 0, 0, 0, 0);
                    plateAppearancesPerStrikeOut[num] = PASO.CalculatePASO();

                    Array.Resize<double>(ref runsCreated, runsCreated.Length + 1);
                    var RC = new Hitters(tb, h, bb, hbp, ibb, ab, 0, 0, 0);
                    runsCreated[num] = RC.CalculateRC();
                    rc = runsCreated[num];

                    Array.Resize<double>(ref weightedOnBaseAverage, weightedOnBaseAverage.Length + 1);
                    var WOBA = new Hitters(bb, hbp, h, d, t, hr, ab, ibb, sf, 0);
                    weightedOnBaseAverage[num] = WOBA.CalculateWOBA();
                    wOBA = weightedOnBaseAverage[num];

                    Array.Resize<double>(ref weightRunsAboveAverage, weightRunsAboveAverage.Length + 1);
                    var WRAA = new Hitters(wOBA, pa, 0, 0, 0, 0, 0, 0, 0, 0, 0);
                    weightRunsAboveAverage[num] = WRAA.CalculatewRAA();
                    wRAA = weightRunsAboveAverage[num];

                    Array.Resize<double>(ref weightRunsCretedPlus, weightRunsCretedPlus.Length + 1);
                    var WRC = new Hitters(wRAA, pa, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
                    weightRunsCretedPlus[num] = WRC.CalculatewRCPlus();

                    if (radAllDivisions.Checked && radMLB.Checked)
                        {
                        if (lbHitterPosition.Text == "Catcher" && position[num] == "C")
                        {
                            if (lbMLBTeams.Text == "All Teams")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Baltimore Orioles" && team[num] == "BAL")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Boston Red Sox" && team[num] == "BOS")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "New York Yankees" && team[num] == "NYY")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Tampa Bay Rays" && team[num] == "TBR")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Toronto Blue Jays" && team[num] == "TOR")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Chicago White Sox" && team[num] == "CWS")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Cleveland Guardians" && team[num] == "CLE")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Detroit Tigers" && team[num] == "DET")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Kansas City Royals" && team[num] == "KCR")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Minnesota Twins" && team[num] == "MIN")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Houston Astros" && team[num] == "HOU")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Los Angeles Angels" && team[num] == "LAA")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Oakland Athletics" && team[num] == "OAK")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Seattle Mariners" && team[num] == "SEA")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Texas Rangers" && team[num] == "TEX")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Atlanta Braves" && team[num] == "ATL")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Miami Marlins" && team[num] == "MIA")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "New York Mets" && team[num] == "NYM")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Philidelphia Phillies" && team[num] == "PHI")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Washington Nationals" && team[num] == "WSN")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Cincinnati Reds" && team[num] == "CIN")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Chicago Cubs" && team[num] == "CHC")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Milwaukee Brewers" && team[num] == "MIL")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Pittsburgh Pirates" && team[num] == "PIT")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "St. Louis Cardinals" && team[num] == "STL")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Arizona Diamondbacks" && team[num] == "ARI")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Colorado Rockies" && team[num] == "COL")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Los Angeles Dodgers" && team[num] == "LAD")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "San Francisco Giants" && team[num] == "SFG")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "San Diego Padres" && team[num] == "SDP")
                            {
                                printHitters();
                            }
                        }
                        else if (lbHitterPosition.Text == "1st Base" && position[num] == "1B")
                        {
                            if (lbMLBTeams.Text == "All Teams")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Baltimore Orioles" && team[num] == "BAL")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Boston Red Sox" && team[num] == "BOS")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "New York Yankees" && team[num] == "NYY")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Tampa Bay Rays" && team[num] == "TBR")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Toronto Blue Jays" && team[num] == "TOR")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Chicago White Sox" && team[num] == "CWS")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Cleveland Guardians" && team[num] == "CLE")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Detroit Tigers" && team[num] == "DET")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Kansas City Royals" && team[num] == "KCR")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Minnesota Twins" && team[num] == "MIN")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Houston Astros" && team[num] == "HOU")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Los Angeles Angels" && team[num] == "LAA")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Oakland Athletics" && team[num] == "OAK")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Seattle Mariners" && team[num] == "SEA")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Texas Rangers" && team[num] == "TEX")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Atlanta Braves" && team[num] == "ATL")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Miami Marlins" && team[num] == "MIA")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "New York Mets" && team[num] == "NYM")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Philidelphia Phillies" && team[num] == "PHI")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Washington Nationals" && team[num] == "WSN")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Cincinnati Reds" && team[num] == "CIN")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Chicago Cubs" && team[num] == "CHC")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Milwaukee Brewers" && team[num] == "MIL")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Pittsburgh Pirates" && team[num] == "PIT")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "St. Louis Cardinals" && team[num] == "STL")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Arizona Diamondbacks" && team[num] == "ARI")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Colorado Rockies" && team[num] == "COL")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Los Angeles Dodgers" && team[num] == "LAD")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "San Francisco Giants" && team[num] == "SFG")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "San Diego Padres" && team[num] == "SDP")
                            {
                                printHitters();
                            }
                        }
                        else if (lbHitterPosition.Text == "2nd Base" && position[num] == "2B")
                        {
                            if (lbMLBTeams.Text == "All Teams")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Baltimore Orioles" && team[num] == "BAL")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Boston Red Sox" && team[num] == "BOS")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "New York Yankees" && team[num] == "NYY")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Tampa Bay Rays" && team[num] == "TBR")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Toronto Blue Jays" && team[num] == "TOR")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Chicago White Sox" && team[num] == "CWS")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Cleveland Guardians" && team[num] == "CLE")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Detroit Tigers" && team[num] == "DET")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Kansas City Royals" && team[num] == "KCR")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Minnesota Twins" && team[num] == "MIN")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Houston Astros" && team[num] == "HOU")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Los Angeles Angels" && team[num] == "LAA")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Oakland Athletics" && team[num] == "OAK")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Seattle Mariners" && team[num] == "SEA")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Texas Rangers" && team[num] == "TEX")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Atlanta Braves" && team[num] == "ATL")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Miami Marlins" && team[num] == "MIA")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "New York Mets" && team[num] == "NYM")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Philidelphia Phillies" && team[num] == "PHI")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Washington Nationals" && team[num] == "WSN")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Cincinnati Reds" && team[num] == "CIN")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Chicago Cubs" && team[num] == "CHC")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Milwaukee Brewers" && team[num] == "MIL")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Pittsburgh Pirates" && team[num] == "PIT")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "St. Louis Cardinals" && team[num] == "STL")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Arizona Diamondbacks" && team[num] == "ARI")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Colorado Rockies" && team[num] == "COL")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Los Angeles Dodgers" && team[num] == "LAD")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "San Francisco Giants" && team[num] == "SFG")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "San Diego Padres" && team[num] == "SDP")
                            {
                                printHitters();
                            }
                        }
                        else if (lbHitterPosition.Text == "Short Stop" && position[num] == "SS")
                        {
                            if (lbMLBTeams.Text == "All Teams")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Baltimore Orioles" && team[num] == "BAL")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Boston Red Sox" && team[num] == "BOS")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "New York Yankees" && team[num] == "NYY")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Tampa Bay Rays" && team[num] == "TBR")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Toronto Blue Jays" && team[num] == "TOR")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Chicago White Sox" && team[num] == "CWS")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Cleveland Guardians" && team[num] == "CLE")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Detroit Tigers" && team[num] == "DET")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Kansas City Royals" && team[num] == "KCR")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Minnesota Twins" && team[num] == "MIN")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Houston Astros" && team[num] == "HOU")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Los Angeles Angels" && team[num] == "LAA")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Oakland Athletics" && team[num] == "OAK")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Seattle Mariners" && team[num] == "SEA")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Texas Rangers" && team[num] == "TEX")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Atlanta Braves" && team[num] == "ATL")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Miami Marlins" && team[num] == "MIA")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "New York Mets" && team[num] == "NYM")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Philidelphia Phillies" && team[num] == "PHI")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Washington Nationals" && team[num] == "WSN")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Cincinnati Reds" && team[num] == "CIN")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Chicago Cubs" && team[num] == "CHC")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Milwaukee Brewers" && team[num] == "MIL")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Pittsburgh Pirates" && team[num] == "PIT")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "St. Louis Cardinals" && team[num] == "STL")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Arizona Diamondbacks" && team[num] == "ARI")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Colorado Rockies" && team[num] == "COL")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Los Angeles Dodgers" && team[num] == "LAD")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "San Francisco Giants" && team[num] == "SFG")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "San Diego Padres" && team[num] == "SDP")
                            {
                                printHitters();
                            }
                        }
                        else if (lbHitterPosition.Text == "3rd Base" && position[num] == "3B")
                        {
                            if (lbMLBTeams.Text == "All Teams")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Baltimore Orioles" && team[num] == "BAL")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Boston Red Sox" && team[num] == "BOS")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "New York Yankees" && team[num] == "NYY")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Tampa Bay Rays" && team[num] == "TBR")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Toronto Blue Jays" && team[num] == "TOR")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Chicago White Sox" && team[num] == "CWS")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Cleveland Guardians" && team[num] == "CLE")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Detroit Tigers" && team[num] == "DET")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Kansas City Royals" && team[num] == "KCR")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Minnesota Twins" && team[num] == "MIN")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Houston Astros" && team[num] == "HOU")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Los Angeles Angels" && team[num] == "LAA")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Oakland Athletics" && team[num] == "OAK")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Seattle Mariners" && team[num] == "SEA")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Texas Rangers" && team[num] == "TEX")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Atlanta Braves" && team[num] == "ATL")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Miami Marlins" && team[num] == "MIA")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "New York Mets" && team[num] == "NYM")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Philidelphia Phillies" && team[num] == "PHI")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Washington Nationals" && team[num] == "WSN")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Cincinnati Reds" && team[num] == "CIN")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Chicago Cubs" && team[num] == "CHC")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Milwaukee Brewers" && team[num] == "MIL")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Pittsburgh Pirates" && team[num] == "PIT")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "St. Louis Cardinals" && team[num] == "STL")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Arizona Diamondbacks" && team[num] == "ARI")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Colorado Rockies" && team[num] == "COL")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Los Angeles Dodgers" && team[num] == "LAD")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "San Francisco Giants" && team[num] == "SFG")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "San Diego Padres" && team[num] == "SDP")
                            {
                                printHitters();
                            }
                        }
                        else if (lbHitterPosition.Text == "Left Field" && position[num] == "LF")
                        {
                            if (lbMLBTeams.Text == "All Teams")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Baltimore Orioles" && team[num] == "BAL")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Boston Red Sox" && team[num] == "BOS")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "New York Yankees" && team[num] == "NYY")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Tampa Bay Rays" && team[num] == "TBR")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Toronto Blue Jays" && team[num] == "TOR")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Chicago White Sox" && team[num] == "CWS")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Cleveland Guardians" && team[num] == "CLE")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Detroit Tigers" && team[num] == "DET")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Kansas City Royals" && team[num] == "KCR")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Minnesota Twins" && team[num] == "MIN")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Houston Astros" && team[num] == "HOU")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Los Angeles Angels" && team[num] == "LAA")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Oakland Athletics" && team[num] == "OAK")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Seattle Mariners" && team[num] == "SEA")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Texas Rangers" && team[num] == "TEX")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Atlanta Braves" && team[num] == "ATL")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Miami Marlins" && team[num] == "MIA")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "New York Mets" && team[num] == "NYM")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Philidelphia Phillies" && team[num] == "PHI")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Washington Nationals" && team[num] == "WSN")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Cincinnati Reds" && team[num] == "CIN")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Chicago Cubs" && team[num] == "CHC")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Milwaukee Brewers" && team[num] == "MIL")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Pittsburgh Pirates" && team[num] == "PIT")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "St. Louis Cardinals" && team[num] == "STL")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Arizona Diamondbacks" && team[num] == "ARI")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Colorado Rockies" && team[num] == "COL")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Los Angeles Dodgers" && team[num] == "LAD")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "San Francisco Giants" && team[num] == "SFG")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "San Diego Padres" && team[num] == "SDP")
                            {
                                printHitters();
                            }
                        }
                        else if (lbHitterPosition.Text == "Center Field" && position[num] == "CF")
                        {
                            if (lbMLBTeams.Text == "All Teams")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Baltimore Orioles" && team[num] == "BAL")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Boston Red Sox" && team[num] == "BOS")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "New York Yankees" && team[num] == "NYY")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Tampa Bay Rays" && team[num] == "TBR")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Toronto Blue Jays" && team[num] == "TOR")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Chicago White Sox" && team[num] == "CWS")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Cleveland Guardians" && team[num] == "CLE")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Detroit Tigers" && team[num] == "DET")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Kansas City Royals" && team[num] == "KCR")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Minnesota Twins" && team[num] == "MIN")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Houston Astros" && team[num] == "HOU")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Los Angeles Angels" && team[num] == "LAA")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Oakland Athletics" && team[num] == "OAK")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Seattle Mariners" && team[num] == "SEA")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Texas Rangers" && team[num] == "TEX")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Atlanta Braves" && team[num] == "ATL")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Miami Marlins" && team[num] == "MIA")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "New York Mets" && team[num] == "NYM")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Philidelphia Phillies" && team[num] == "PHI")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Washington Nationals" && team[num] == "WSN")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Cincinnati Reds" && team[num] == "CIN")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Chicago Cubs" && team[num] == "CHC")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Milwaukee Brewers" && team[num] == "MIL")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Pittsburgh Pirates" && team[num] == "PIT")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "St. Louis Cardinals" && team[num] == "STL")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Arizona Diamondbacks" && team[num] == "ARI")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Colorado Rockies" && team[num] == "COL")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Los Angeles Dodgers" && team[num] == "LAD")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "San Francisco Giants" && team[num] == "SFG")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "San Diego Padres" && team[num] == "SDP")
                            {
                                printHitters();
                            }
                        }
                        else if (lbHitterPosition.Text == "Right Field" && position[num] == "RF")
                        {
                            if (lbMLBTeams.Text == "All Teams")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Baltimore Orioles" && team[num] == "BAL")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Boston Red Sox" && team[num] == "BOS")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "New York Yankees" && team[num] == "NYY")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Tampa Bay Rays" && team[num] == "TBR")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Toronto Blue Jays" && team[num] == "TOR")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Chicago White Sox" && team[num] == "CWS")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Cleveland Guardians" && team[num] == "CLE")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Detroit Tigers" && team[num] == "DET")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Kansas City Royals" && team[num] == "KCR")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Minnesota Twins" && team[num] == "MIN")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Houston Astros" && team[num] == "HOU")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Los Angeles Angels" && team[num] == "LAA")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Oakland Athletics" && team[num] == "OAK")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Seattle Mariners" && team[num] == "SEA")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Texas Rangers" && team[num] == "TEX")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Atlanta Braves" && team[num] == "ATL")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Miami Marlins" && team[num] == "MIA")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "New York Mets" && team[num] == "NYM")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Philidelphia Phillies" && team[num] == "PHI")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Washington Nationals" && team[num] == "WSN")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Cincinnati Reds" && team[num] == "CIN")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Chicago Cubs" && team[num] == "CHC")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Milwaukee Brewers" && team[num] == "MIL")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Pittsburgh Pirates" && team[num] == "PIT")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "St. Louis Cardinals" && team[num] == "STL")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Arizona Diamondbacks" && team[num] == "ARI")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Colorado Rockies" && team[num] == "COL")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Los Angeles Dodgers" && team[num] == "LAD")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "San Francisco Giants" && team[num] == "SFG")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "San Diego Padres" && team[num] == "SDP")
                            {
                                printHitters();
                            }
                        }
                        else if (lbHitterPosition.Text == "Designated Hitter" && position[num] == "DH")
                        {
                            if (lbMLBTeams.Text == "All Teams")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Baltimore Orioles" && team[num] == "BAL")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Boston Red Sox" && team[num] == "BOS")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "New York Yankees" && team[num] == "NYY")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Tampa Bay Rays" && team[num] == "TBR")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Toronto Blue Jays" && team[num] == "TOR")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Chicago White Sox" && team[num] == "CWS")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Cleveland Guardians" && team[num] == "CLE")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Detroit Tigers" && team[num] == "DET")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Kansas City Royals" && team[num] == "KCR")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Minnesota Twins" && team[num] == "MIN")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Houston Astros" && team[num] == "HOU")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Los Angeles Angels" && team[num] == "LAA")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Oakland Athletics" && team[num] == "OAK")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Seattle Mariners" && team[num] == "SEA")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Texas Rangers" && team[num] == "TEX")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Atlanta Braves" && team[num] == "ATL")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Miami Marlins" && team[num] == "MIA")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "New York Mets" && team[num] == "NYM")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Philidelphia Phillies" && team[num] == "PHI")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Washington Nationals" && team[num] == "WSN")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Cincinnati Reds" && team[num] == "CIN")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Chicago Cubs" && team[num] == "CHC")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Milwaukee Brewers" && team[num] == "MIL")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Pittsburgh Pirates" && team[num] == "PIT")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "St. Louis Cardinals" && team[num] == "STL")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Arizona Diamondbacks" && team[num] == "ARI")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Colorado Rockies" && team[num] == "COL")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Los Angeles Dodgers" && team[num] == "LAD")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "San Francisco Giants" && team[num] == "SFG")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "San Diego Padres" && team[num] == "SDP")
                            {
                                printHitters();
                            }
                        }
                        else
                        {
                            if (lbMLBTeams.Text == "All Teams")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Baltimore Orioles" && team[num] == "BAL")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Boston Red Sox" && team[num] == "BOS")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "New York Yankees" && team[num] == "NYY")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Tampa Bay Rays" && team[num] == "TBR")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Toronto Blue Jays" && team[num] == "TOR")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Chicago White Sox" && team[num] == "CWS")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Cleveland Guardians" && team[num] == "CLE")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Detroit Tigers" && team[num] == "DET")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Kansas City Royals" && team[num] == "KCR")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Minnesota Twins" && team[num] == "MIN")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Houston Astros" && team[num] == "HOU")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Los Angeles Angels" && team[num] == "LAA")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Oakland Athletics" && team[num] == "OAK")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Seattle Mariners" && team[num] == "SEA")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Texas Rangers" && team[num] == "TEX")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Atlanta Braves" && team[num] == "ATL")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Miami Marlins" && team[num] == "MIA")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "New York Mets" && team[num] == "NYM")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Philidelphia Phillies" && team[num] == "PHI")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Washington Nationals" && team[num] == "WSN")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Cincinnati Reds" && team[num] == "CIN")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Chicago Cubs" && team[num] == "CHC")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Milwaukee Brewers" && team[num] == "MIL")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Pittsburgh Pirates" && team[num] == "PIT")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "St. Louis Cardinals" && team[num] == "STL")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Arizona Diamondbacks" && team[num] == "ARI")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Colorado Rockies" && team[num] == "COL")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "Los Angeles Dodgers" && team[num] == "LAD")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "San Francisco Giants" && team[num] == "SFG")
                            {
                                printHitters();
                            }
                            if (lbMLBTeams.Text == "San Diego Padres" && team[num] == "SDP")
                            {
                                printHitters();
                            }
                        }
                    }
                    else if (radAllDivisions.Checked && radAL.Checked)
                    {
                        if (league[num] == "AL")
                        {
                            if (lbHitterPosition.Text == "Catcher" && position[num] == "C")
                            {
                                if (lbMLBTeams.Text == "All Teams")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Baltimore Orioles" && team[num] == "BAL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Boston Red Sox" && team[num] == "BOS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Yankees" && team[num] == "NYY")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Tampa Bay Rays" && team[num] == "TBR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Toronto Blue Jays" && team[num] == "TOR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago White Sox" && team[num] == "CWS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cleveland Guardians" && team[num] == "CLE")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Detroit Tigers" && team[num] == "DET")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Kansas City Royals" && team[num] == "KCR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Minnesota Twins" && team[num] == "MIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Houston Astros" && team[num] == "HOU")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Angels" && team[num] == "LAA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Oakland Athletics" && team[num] == "OAK")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Seattle Mariners" && team[num] == "SEA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Texas Rangers" && team[num] == "TEX")
                                {
                                    printHitters();
                                }
                            }
                            else if (lbHitterPosition.Text == "1st Base" && position[num] == "1B")
                            {
                                if (lbMLBTeams.Text == "All Teams")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Baltimore Orioles" && team[num] == "BAL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Boston Red Sox" && team[num] == "BOS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Yankees" && team[num] == "NYY")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Tampa Bay Rays" && team[num] == "TBR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Toronto Blue Jays" && team[num] == "TOR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago White Sox" && team[num] == "CWS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cleveland Guardians" && team[num] == "CLE")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Detroit Tigers" && team[num] == "DET")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Kansas City Royals" && team[num] == "KCR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Minnesota Twins" && team[num] == "MIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Houston Astros" && team[num] == "HOU")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Angels" && team[num] == "LAA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Oakland Athletics" && team[num] == "OAK")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Seattle Mariners" && team[num] == "SEA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Texas Rangers" && team[num] == "TEX")
                                {
                                    printHitters();
                                }
                            }
                            else if (lbHitterPosition.Text == "2nd Base" && position[num] == "2B")
                            {
                                if (lbMLBTeams.Text == "All Teams")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Baltimore Orioles" && team[num] == "BAL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Boston Red Sox" && team[num] == "BOS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Yankees" && team[num] == "NYY")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Tampa Bay Rays" && team[num] == "TBR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Toronto Blue Jays" && team[num] == "TOR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago White Sox" && team[num] == "CWS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cleveland Guardians" && team[num] == "CLE")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Detroit Tigers" && team[num] == "DET")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Kansas City Royals" && team[num] == "KCR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Minnesota Twins" && team[num] == "MIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Houston Astros" && team[num] == "HOU")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Angels" && team[num] == "LAA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Oakland Athletics" && team[num] == "OAK")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Seattle Mariners" && team[num] == "SEA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Texas Rangers" && team[num] == "TEX")
                                {
                                    printHitters();
                                }
                            }
                            else if (lbHitterPosition.Text == "Short Stop" && position[num] == "SS")
                            {
                                if (lbMLBTeams.Text == "All Teams")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Baltimore Orioles" && team[num] == "BAL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Boston Red Sox" && team[num] == "BOS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Yankees" && team[num] == "NYY")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Tampa Bay Rays" && team[num] == "TBR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Toronto Blue Jays" && team[num] == "TOR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago White Sox" && team[num] == "CWS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cleveland Guardians" && team[num] == "CLE")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Detroit Tigers" && team[num] == "DET")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Kansas City Royals" && team[num] == "KCR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Minnesota Twins" && team[num] == "MIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Houston Astros" && team[num] == "HOU")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Angels" && team[num] == "LAA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Oakland Athletics" && team[num] == "OAK")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Seattle Mariners" && team[num] == "SEA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Texas Rangers" && team[num] == "TEX")
                                {
                                    printHitters();
                                }
                            }
                            else if (lbHitterPosition.Text == "3rd Base" && position[num] == "3B")
                            {
                                if (lbMLBTeams.Text == "All Teams")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Baltimore Orioles" && team[num] == "BAL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Boston Red Sox" && team[num] == "BOS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Yankees" && team[num] == "NYY")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Tampa Bay Rays" && team[num] == "TBR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Toronto Blue Jays" && team[num] == "TOR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago White Sox" && team[num] == "CWS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cleveland Guardians" && team[num] == "CLE")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Detroit Tigers" && team[num] == "DET")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Kansas City Royals" && team[num] == "KCR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Minnesota Twins" && team[num] == "MIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Houston Astros" && team[num] == "HOU")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Angels" && team[num] == "LAA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Oakland Athletics" && team[num] == "OAK")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Seattle Mariners" && team[num] == "SEA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Texas Rangers" && team[num] == "TEX")
                                {
                                    printHitters();
                                }
                            }
                            else if (lbHitterPosition.Text == "Left Field" && position[num] == "LF")
                            {
                                if (lbMLBTeams.Text == "All Teams")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Baltimore Orioles" && team[num] == "BAL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Boston Red Sox" && team[num] == "BOS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Yankees" && team[num] == "NYY")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Tampa Bay Rays" && team[num] == "TBR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Toronto Blue Jays" && team[num] == "TOR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago White Sox" && team[num] == "CWS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cleveland Guardians" && team[num] == "CLE")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Detroit Tigers" && team[num] == "DET")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Kansas City Royals" && team[num] == "KCR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Minnesota Twins" && team[num] == "MIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Houston Astros" && team[num] == "HOU")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Angels" && team[num] == "LAA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Oakland Athletics" && team[num] == "OAK")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Seattle Mariners" && team[num] == "SEA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Texas Rangers" && team[num] == "TEX")
                                {
                                    printHitters();
                                }
                            }
                            else if (lbHitterPosition.Text == "Center Field" && position[num] == "CF")
                            {
                                if (lbMLBTeams.Text == "All Teams")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Baltimore Orioles" && team[num] == "BAL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Boston Red Sox" && team[num] == "BOS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Yankees" && team[num] == "NYY")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Tampa Bay Rays" && team[num] == "TBR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Toronto Blue Jays" && team[num] == "TOR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago White Sox" && team[num] == "CWS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cleveland Guardians" && team[num] == "CLE")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Detroit Tigers" && team[num] == "DET")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Kansas City Royals" && team[num] == "KCR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Minnesota Twins" && team[num] == "MIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Houston Astros" && team[num] == "HOU")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Angels" && team[num] == "LAA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Oakland Athletics" && team[num] == "OAK")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Seattle Mariners" && team[num] == "SEA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Texas Rangers" && team[num] == "TEX")
                                {
                                    printHitters();
                                }
                            }
                            else if (lbHitterPosition.Text == "Right Field" && position[num] == "RF")
                            {
                                if (lbMLBTeams.Text == "All Teams")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Baltimore Orioles" && team[num] == "BAL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Boston Red Sox" && team[num] == "BOS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Yankees" && team[num] == "NYY")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Tampa Bay Rays" && team[num] == "TBR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Toronto Blue Jays" && team[num] == "TOR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago White Sox" && team[num] == "CWS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cleveland Guardians" && team[num] == "CLE")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Detroit Tigers" && team[num] == "DET")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Kansas City Royals" && team[num] == "KCR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Minnesota Twins" && team[num] == "MIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Houston Astros" && team[num] == "HOU")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Angels" && team[num] == "LAA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Oakland Athletics" && team[num] == "OAK")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Seattle Mariners" && team[num] == "SEA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Texas Rangers" && team[num] == "TEX")
                                {
                                    printHitters();
                                }
                            }
                            else if (lbHitterPosition.Text == "Designated Hitter" && position[num] == "DH")
                            {
                                if (lbMLBTeams.Text == "All Teams")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Baltimore Orioles" && team[num] == "BAL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Boston Red Sox" && team[num] == "BOS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Yankees" && team[num] == "NYY")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Tampa Bay Rays" && team[num] == "TBR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Toronto Blue Jays" && team[num] == "TOR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago White Sox" && team[num] == "CWS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cleveland Guardians" && team[num] == "CLE")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Detroit Tigers" && team[num] == "DET")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Kansas City Royals" && team[num] == "KCR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Minnesota Twins" && team[num] == "MIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Houston Astros" && team[num] == "HOU")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Angels" && team[num] == "LAA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Oakland Athletics" && team[num] == "OAK")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Seattle Mariners" && team[num] == "SEA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Texas Rangers" && team[num] == "TEX")
                                {
                                    printHitters();
                                }
                            }
                            else
                            {
                                if (lbMLBTeams.Text == "All Teams")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Baltimore Orioles" && team[num] == "BAL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Boston Red Sox" && team[num] == "BOS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Yankees" && team[num] == "NYY")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Tampa Bay Rays" && team[num] == "TBR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Toronto Blue Jays" && team[num] == "TOR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago White Sox" && team[num] == "CWS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cleveland Guardians" && team[num] == "CLE")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Detroit Tigers" && team[num] == "DET")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Kansas City Royals" && team[num] == "KCR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Minnesota Twins" && team[num] == "MIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Houston Astros" && team[num] == "HOU")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Angels" && team[num] == "LAA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Oakland Athletics" && team[num] == "OAK")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Seattle Mariners" && team[num] == "SEA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Texas Rangers" && team[num] == "TEX")
                                {
                                    printHitters();
                                }
                            }
                        }
                    }
                    else if (radAllDivisions.Checked && radNL.Checked)
                    {
                        if (league[num] == "NL")
                        {
                            if (lbHitterPosition.Text == "Catcher" && position[num] == "C")
                            {
                                if (lbMLBTeams.Text == "All Teams")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Baltimore Orioles" && team[num] == "BAL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Boston Red Sox" && team[num] == "BOS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Yankees" && team[num] == "NYY")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Tampa Bay Rays" && team[num] == "TBR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Toronto Blue Jays" && team[num] == "TOR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago White Sox" && team[num] == "CWS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cleveland Guardians" && team[num] == "CLE")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Detroit Tigers" && team[num] == "DET")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Kansas City Royals" && team[num] == "KCR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Minnesota Twins" && team[num] == "MIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Houston Astros" && team[num] == "HOU")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Angels" && team[num] == "LAA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Oakland Athletics" && team[num] == "OAK")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Seattle Mariners" && team[num] == "SEA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Texas Rangers" && team[num] == "TEX")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Atlanta Braves" && team[num] == "ATL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Miami Marlins" && team[num] == "MIA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Mets" && team[num] == "NYM")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Philidelphia Phillies" && team[num] == "PHI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Washington Nationals" && team[num] == "WSN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cincinnati Reds" && team[num] == "CIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago Cubs" && team[num] == "CHC")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Milwaukee Brewers" && team[num] == "MIL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Pittsburgh Pirates" && team[num] == "PIT")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "St. Louis Cardinals" && team[num] == "STL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Arizona Diamondbacks" && team[num] == "ARI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Colorado Rockies" && team[num] == "COL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Dodgers" && team[num] == "LAD")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Francisco Giants" && team[num] == "SFG")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Diego Padres" && team[num] == "SDP")
                                {
                                    printHitters();
                                }
                            }
                            else if (lbHitterPosition.Text == "1st Base" && position[num] == "1B")
                            {
                                if (lbMLBTeams.Text == "All Teams")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Baltimore Orioles" && team[num] == "BAL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Boston Red Sox" && team[num] == "BOS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Yankees" && team[num] == "NYY")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Tampa Bay Rays" && team[num] == "TBR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Toronto Blue Jays" && team[num] == "TOR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago White Sox" && team[num] == "CWS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cleveland Guardians" && team[num] == "CLE")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Detroit Tigers" && team[num] == "DET")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Kansas City Royals" && team[num] == "KCR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Minnesota Twins" && team[num] == "MIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Houston Astros" && team[num] == "HOU")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Angels" && team[num] == "LAA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Oakland Athletics" && team[num] == "OAK")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Seattle Mariners" && team[num] == "SEA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Texas Rangers" && team[num] == "TEX")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Atlanta Braves" && team[num] == "ATL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Miami Marlins" && team[num] == "MIA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Mets" && team[num] == "NYM")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Philidelphia Phillies" && team[num] == "PHI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Washington Nationals" && team[num] == "WSN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cincinnati Reds" && team[num] == "CIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago Cubs" && team[num] == "CHC")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Milwaukee Brewers" && team[num] == "MIL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Pittsburgh Pirates" && team[num] == "PIT")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "St. Louis Cardinals" && team[num] == "STL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Arizona Diamondbacks" && team[num] == "ARI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Colorado Rockies" && team[num] == "COL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Dodgers" && team[num] == "LAD")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Francisco Giants" && team[num] == "SFG")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Diego Padres" && team[num] == "SDP")
                                {
                                    printHitters();
                                }
                            }
                            else if (lbHitterPosition.Text == "2nd Base" && position[num] == "2B")
                            {
                                if (lbMLBTeams.Text == "All Teams")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Baltimore Orioles" && team[num] == "BAL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Boston Red Sox" && team[num] == "BOS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Yankees" && team[num] == "NYY")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Tampa Bay Rays" && team[num] == "TBR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Toronto Blue Jays" && team[num] == "TOR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago White Sox" && team[num] == "CWS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cleveland Guardians" && team[num] == "CLE")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Detroit Tigers" && team[num] == "DET")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Kansas City Royals" && team[num] == "KCR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Minnesota Twins" && team[num] == "MIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Houston Astros" && team[num] == "HOU")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Angels" && team[num] == "LAA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Oakland Athletics" && team[num] == "OAK")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Seattle Mariners" && team[num] == "SEA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Texas Rangers" && team[num] == "TEX")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Atlanta Braves" && team[num] == "ATL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Miami Marlins" && team[num] == "MIA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Mets" && team[num] == "NYM")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Philidelphia Phillies" && team[num] == "PHI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Washington Nationals" && team[num] == "WSN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cincinnati Reds" && team[num] == "CIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago Cubs" && team[num] == "CHC")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Milwaukee Brewers" && team[num] == "MIL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Pittsburgh Pirates" && team[num] == "PIT")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "St. Louis Cardinals" && team[num] == "STL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Arizona Diamondbacks" && team[num] == "ARI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Colorado Rockies" && team[num] == "COL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Dodgers" && team[num] == "LAD")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Francisco Giants" && team[num] == "SFG")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Diego Padres" && team[num] == "SDP")
                                {
                                    printHitters();
                                }
                            }
                            else if (lbHitterPosition.Text == "Short Stop" && position[num] == "SS")
                            {
                                if (lbMLBTeams.Text == "All Teams")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Baltimore Orioles" && team[num] == "BAL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Boston Red Sox" && team[num] == "BOS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Yankees" && team[num] == "NYY")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Tampa Bay Rays" && team[num] == "TBR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Toronto Blue Jays" && team[num] == "TOR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago White Sox" && team[num] == "CWS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cleveland Guardians" && team[num] == "CLE")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Detroit Tigers" && team[num] == "DET")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Kansas City Royals" && team[num] == "KCR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Minnesota Twins" && team[num] == "MIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Houston Astros" && team[num] == "HOU")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Angels" && team[num] == "LAA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Oakland Athletics" && team[num] == "OAK")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Seattle Mariners" && team[num] == "SEA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Texas Rangers" && team[num] == "TEX")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Atlanta Braves" && team[num] == "ATL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Miami Marlins" && team[num] == "MIA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Mets" && team[num] == "NYM")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Philidelphia Phillies" && team[num] == "PHI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Washington Nationals" && team[num] == "WSN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cincinnati Reds" && team[num] == "CIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago Cubs" && team[num] == "CHC")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Milwaukee Brewers" && team[num] == "MIL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Pittsburgh Pirates" && team[num] == "PIT")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "St. Louis Cardinals" && team[num] == "STL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Arizona Diamondbacks" && team[num] == "ARI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Colorado Rockies" && team[num] == "COL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Dodgers" && team[num] == "LAD")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Francisco Giants" && team[num] == "SFG")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Diego Padres" && team[num] == "SDP")
                                {
                                    printHitters();
                                }
                            }
                            else if (lbHitterPosition.Text == "3rd Base" && position[num] == "3B")
                            {
                                if (lbMLBTeams.Text == "All Teams")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Baltimore Orioles" && team[num] == "BAL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Boston Red Sox" && team[num] == "BOS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Yankees" && team[num] == "NYY")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Tampa Bay Rays" && team[num] == "TBR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Toronto Blue Jays" && team[num] == "TOR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago White Sox" && team[num] == "CWS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cleveland Guardians" && team[num] == "CLE")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Detroit Tigers" && team[num] == "DET")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Kansas City Royals" && team[num] == "KCR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Minnesota Twins" && team[num] == "MIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Houston Astros" && team[num] == "HOU")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Angels" && team[num] == "LAA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Oakland Athletics" && team[num] == "OAK")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Seattle Mariners" && team[num] == "SEA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Texas Rangers" && team[num] == "TEX")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Atlanta Braves" && team[num] == "ATL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Miami Marlins" && team[num] == "MIA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Mets" && team[num] == "NYM")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Philidelphia Phillies" && team[num] == "PHI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Washington Nationals" && team[num] == "WSN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cincinnati Reds" && team[num] == "CIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago Cubs" && team[num] == "CHC")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Milwaukee Brewers" && team[num] == "MIL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Pittsburgh Pirates" && team[num] == "PIT")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "St. Louis Cardinals" && team[num] == "STL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Arizona Diamondbacks" && team[num] == "ARI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Colorado Rockies" && team[num] == "COL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Dodgers" && team[num] == "LAD")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Francisco Giants" && team[num] == "SFG")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Diego Padres" && team[num] == "SDP")
                                {
                                    printHitters();
                                }
                            }
                            else if (lbHitterPosition.Text == "Left Field" && position[num] == "LF")
                            {
                                if (lbMLBTeams.Text == "All Teams")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Baltimore Orioles" && team[num] == "BAL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Boston Red Sox" && team[num] == "BOS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Yankees" && team[num] == "NYY")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Tampa Bay Rays" && team[num] == "TBR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Toronto Blue Jays" && team[num] == "TOR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago White Sox" && team[num] == "CWS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cleveland Guardians" && team[num] == "CLE")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Detroit Tigers" && team[num] == "DET")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Kansas City Royals" && team[num] == "KCR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Minnesota Twins" && team[num] == "MIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Houston Astros" && team[num] == "HOU")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Angels" && team[num] == "LAA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Oakland Athletics" && team[num] == "OAK")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Seattle Mariners" && team[num] == "SEA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Texas Rangers" && team[num] == "TEX")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Atlanta Braves" && team[num] == "ATL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Miami Marlins" && team[num] == "MIA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Mets" && team[num] == "NYM")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Philidelphia Phillies" && team[num] == "PHI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Washington Nationals" && team[num] == "WSN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cincinnati Reds" && team[num] == "CIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago Cubs" && team[num] == "CHC")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Milwaukee Brewers" && team[num] == "MIL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Pittsburgh Pirates" && team[num] == "PIT")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "St. Louis Cardinals" && team[num] == "STL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Arizona Diamondbacks" && team[num] == "ARI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Colorado Rockies" && team[num] == "COL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Dodgers" && team[num] == "LAD")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Francisco Giants" && team[num] == "SFG")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Diego Padres" && team[num] == "SDP")
                                {
                                    printHitters();
                                }
                            }
                            else if (lbHitterPosition.Text == "Center Field" && position[num] == "CF")
                            {
                                if (lbMLBTeams.Text == "All Teams")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Baltimore Orioles" && team[num] == "BAL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Boston Red Sox" && team[num] == "BOS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Yankees" && team[num] == "NYY")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Tampa Bay Rays" && team[num] == "TBR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Toronto Blue Jays" && team[num] == "TOR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago White Sox" && team[num] == "CWS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cleveland Guardians" && team[num] == "CLE")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Detroit Tigers" && team[num] == "DET")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Kansas City Royals" && team[num] == "KCR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Minnesota Twins" && team[num] == "MIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Houston Astros" && team[num] == "HOU")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Angels" && team[num] == "LAA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Oakland Athletics" && team[num] == "OAK")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Seattle Mariners" && team[num] == "SEA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Texas Rangers" && team[num] == "TEX")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Atlanta Braves" && team[num] == "ATL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Miami Marlins" && team[num] == "MIA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Mets" && team[num] == "NYM")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Philidelphia Phillies" && team[num] == "PHI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Washington Nationals" && team[num] == "WSN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cincinnati Reds" && team[num] == "CIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago Cubs" && team[num] == "CHC")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Milwaukee Brewers" && team[num] == "MIL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Pittsburgh Pirates" && team[num] == "PIT")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "St. Louis Cardinals" && team[num] == "STL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Arizona Diamondbacks" && team[num] == "ARI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Colorado Rockies" && team[num] == "COL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Dodgers" && team[num] == "LAD")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Francisco Giants" && team[num] == "SFG")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Diego Padres" && team[num] == "SDP")
                                {
                                    printHitters();
                                }
                            }
                            else if (lbHitterPosition.Text == "Right Field" && position[num] == "RF")
                            {
                                if (lbMLBTeams.Text == "All Teams")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Baltimore Orioles" && team[num] == "BAL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Boston Red Sox" && team[num] == "BOS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Yankees" && team[num] == "NYY")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Tampa Bay Rays" && team[num] == "TBR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Toronto Blue Jays" && team[num] == "TOR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago White Sox" && team[num] == "CWS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cleveland Guardians" && team[num] == "CLE")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Detroit Tigers" && team[num] == "DET")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Kansas City Royals" && team[num] == "KCR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Minnesota Twins" && team[num] == "MIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Houston Astros" && team[num] == "HOU")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Angels" && team[num] == "LAA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Oakland Athletics" && team[num] == "OAK")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Seattle Mariners" && team[num] == "SEA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Texas Rangers" && team[num] == "TEX")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Atlanta Braves" && team[num] == "ATL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Miami Marlins" && team[num] == "MIA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Mets" && team[num] == "NYM")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Philidelphia Phillies" && team[num] == "PHI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Washington Nationals" && team[num] == "WSN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cincinnati Reds" && team[num] == "CIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago Cubs" && team[num] == "CHC")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Milwaukee Brewers" && team[num] == "MIL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Pittsburgh Pirates" && team[num] == "PIT")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "St. Louis Cardinals" && team[num] == "STL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Arizona Diamondbacks" && team[num] == "ARI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Colorado Rockies" && team[num] == "COL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Dodgers" && team[num] == "LAD")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Francisco Giants" && team[num] == "SFG")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Diego Padres" && team[num] == "SDP")
                                {
                                    printHitters();
                                }
                            }
                            else if (lbHitterPosition.Text == "Designated Hitter" && position[num] == "DH")
                            {
                                if (lbMLBTeams.Text == "All Teams")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Baltimore Orioles" && team[num] == "BAL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Boston Red Sox" && team[num] == "BOS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Yankees" && team[num] == "NYY")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Tampa Bay Rays" && team[num] == "TBR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Toronto Blue Jays" && team[num] == "TOR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago White Sox" && team[num] == "CWS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cleveland Guardians" && team[num] == "CLE")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Detroit Tigers" && team[num] == "DET")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Kansas City Royals" && team[num] == "KCR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Minnesota Twins" && team[num] == "MIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Houston Astros" && team[num] == "HOU")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Angels" && team[num] == "LAA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Oakland Athletics" && team[num] == "OAK")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Seattle Mariners" && team[num] == "SEA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Texas Rangers" && team[num] == "TEX")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Atlanta Braves" && team[num] == "ATL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Miami Marlins" && team[num] == "MIA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Mets" && team[num] == "NYM")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Philidelphia Phillies" && team[num] == "PHI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Washington Nationals" && team[num] == "WSN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cincinnati Reds" && team[num] == "CIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago Cubs" && team[num] == "CHC")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Milwaukee Brewers" && team[num] == "MIL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Pittsburgh Pirates" && team[num] == "PIT")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "St. Louis Cardinals" && team[num] == "STL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Arizona Diamondbacks" && team[num] == "ARI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Colorado Rockies" && team[num] == "COL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Dodgers" && team[num] == "LAD")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Francisco Giants" && team[num] == "SFG")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Diego Padres" && team[num] == "SDP")
                                {
                                    printHitters();
                                }
                            }
                            else
                            {
                                if (lbMLBTeams.Text == "All Teams")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Baltimore Orioles" && team[num] == "BAL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Boston Red Sox" && team[num] == "BOS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Yankees" && team[num] == "NYY")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Tampa Bay Rays" && team[num] == "TBR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Toronto Blue Jays" && team[num] == "TOR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago White Sox" && team[num] == "CWS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cleveland Guardians" && team[num] == "CLE")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Detroit Tigers" && team[num] == "DET")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Kansas City Royals" && team[num] == "KCR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Minnesota Twins" && team[num] == "MIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Houston Astros" && team[num] == "HOU")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Angels" && team[num] == "LAA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Oakland Athletics" && team[num] == "OAK")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Seattle Mariners" && team[num] == "SEA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Texas Rangers" && team[num] == "TEX")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Atlanta Braves" && team[num] == "ATL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Miami Marlins" && team[num] == "MIA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Mets" && team[num] == "NYM")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Philidelphia Phillies" && team[num] == "PHI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Washington Nationals" && team[num] == "WSN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cincinnati Reds" && team[num] == "CIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago Cubs" && team[num] == "CHC")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Milwaukee Brewers" && team[num] == "MIL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Pittsburgh Pirates" && team[num] == "PIT")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "St. Louis Cardinals" && team[num] == "STL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Arizona Diamondbacks" && team[num] == "ARI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Colorado Rockies" && team[num] == "COL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Dodgers" && team[num] == "LAD")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Francisco Giants" && team[num] == "SFG")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Diego Padres" && team[num] == "SDP")
                                {
                                    printHitters();
                                }
                            }
                        }
                    }
                    else if (radEast.Checked && radMLB.Checked)
                        {
                            if (division[num] == "E")
                            {
                            if (lbHitterPosition.Text == "Catcher" && position[num] == "C")
                            {
                                if (lbMLBTeams.Text == "All Teams")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Baltimore Orioles" && team[num] == "BAL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Boston Red Sox" && team[num] == "BOS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Yankees" && team[num] == "NYY")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Tampa Bay Rays" && team[num] == "TBR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Toronto Blue Jays" && team[num] == "TOR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago White Sox" && team[num] == "CWS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cleveland Guardians" && team[num] == "CLE")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Detroit Tigers" && team[num] == "DET")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Kansas City Royals" && team[num] == "KCR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Minnesota Twins" && team[num] == "MIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Houston Astros" && team[num] == "HOU")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Angels" && team[num] == "LAA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Oakland Athletics" && team[num] == "OAK")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Seattle Mariners" && team[num] == "SEA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Texas Rangers" && team[num] == "TEX")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Atlanta Braves" && team[num] == "ATL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Miami Marlins" && team[num] == "MIA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Mets" && team[num] == "NYM")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Philidelphia Phillies" && team[num] == "PHI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Washington Nationals" && team[num] == "WSN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cincinnati Reds" && team[num] == "CIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago Cubs" && team[num] == "CHC")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Milwaukee Brewers" && team[num] == "MIL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Pittsburgh Pirates" && team[num] == "PIT")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "St. Louis Cardinals" && team[num] == "STL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Arizona Diamondbacks" && team[num] == "ARI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Colorado Rockies" && team[num] == "COL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Dodgers" && team[num] == "LAD")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Francisco Giants" && team[num] == "SFG")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Diego Padres" && team[num] == "SDP")
                                {
                                    printHitters();
                                }
                            }
                            else if (lbHitterPosition.Text == "1st Base" && position[num] == "1B")
                            {
                                if (lbMLBTeams.Text == "All Teams")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Baltimore Orioles" && team[num] == "BAL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Boston Red Sox" && team[num] == "BOS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Yankees" && team[num] == "NYY")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Tampa Bay Rays" && team[num] == "TBR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Toronto Blue Jays" && team[num] == "TOR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago White Sox" && team[num] == "CWS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cleveland Guardians" && team[num] == "CLE")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Detroit Tigers" && team[num] == "DET")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Kansas City Royals" && team[num] == "KCR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Minnesota Twins" && team[num] == "MIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Houston Astros" && team[num] == "HOU")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Angels" && team[num] == "LAA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Oakland Athletics" && team[num] == "OAK")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Seattle Mariners" && team[num] == "SEA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Texas Rangers" && team[num] == "TEX")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Atlanta Braves" && team[num] == "ATL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Miami Marlins" && team[num] == "MIA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Mets" && team[num] == "NYM")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Philidelphia Phillies" && team[num] == "PHI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Washington Nationals" && team[num] == "WSN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cincinnati Reds" && team[num] == "CIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago Cubs" && team[num] == "CHC")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Milwaukee Brewers" && team[num] == "MIL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Pittsburgh Pirates" && team[num] == "PIT")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "St. Louis Cardinals" && team[num] == "STL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Arizona Diamondbacks" && team[num] == "ARI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Colorado Rockies" && team[num] == "COL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Dodgers" && team[num] == "LAD")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Francisco Giants" && team[num] == "SFG")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Diego Padres" && team[num] == "SDP")
                                {
                                    printHitters();
                                }
                            }
                            else if (lbHitterPosition.Text == "2nd Base" && position[num] == "2B")
                            {
                                if (lbMLBTeams.Text == "All Teams")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Baltimore Orioles" && team[num] == "BAL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Boston Red Sox" && team[num] == "BOS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Yankees" && team[num] == "NYY")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Tampa Bay Rays" && team[num] == "TBR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Toronto Blue Jays" && team[num] == "TOR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago White Sox" && team[num] == "CWS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cleveland Guardians" && team[num] == "CLE")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Detroit Tigers" && team[num] == "DET")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Kansas City Royals" && team[num] == "KCR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Minnesota Twins" && team[num] == "MIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Houston Astros" && team[num] == "HOU")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Angels" && team[num] == "LAA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Oakland Athletics" && team[num] == "OAK")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Seattle Mariners" && team[num] == "SEA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Texas Rangers" && team[num] == "TEX")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Atlanta Braves" && team[num] == "ATL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Miami Marlins" && team[num] == "MIA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Mets" && team[num] == "NYM")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Philidelphia Phillies" && team[num] == "PHI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Washington Nationals" && team[num] == "WSN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cincinnati Reds" && team[num] == "CIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago Cubs" && team[num] == "CHC")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Milwaukee Brewers" && team[num] == "MIL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Pittsburgh Pirates" && team[num] == "PIT")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "St. Louis Cardinals" && team[num] == "STL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Arizona Diamondbacks" && team[num] == "ARI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Colorado Rockies" && team[num] == "COL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Dodgers" && team[num] == "LAD")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Francisco Giants" && team[num] == "SFG")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Diego Padres" && team[num] == "SDP")
                                {
                                    printHitters();
                                }
                            }
                            else if (lbHitterPosition.Text == "Short Stop" && position[num] == "SS")
                            {
                                if (lbMLBTeams.Text == "All Teams")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Baltimore Orioles" && team[num] == "BAL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Boston Red Sox" && team[num] == "BOS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Yankees" && team[num] == "NYY")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Tampa Bay Rays" && team[num] == "TBR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Toronto Blue Jays" && team[num] == "TOR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago White Sox" && team[num] == "CWS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cleveland Guardians" && team[num] == "CLE")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Detroit Tigers" && team[num] == "DET")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Kansas City Royals" && team[num] == "KCR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Minnesota Twins" && team[num] == "MIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Houston Astros" && team[num] == "HOU")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Angels" && team[num] == "LAA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Oakland Athletics" && team[num] == "OAK")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Seattle Mariners" && team[num] == "SEA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Texas Rangers" && team[num] == "TEX")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Atlanta Braves" && team[num] == "ATL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Miami Marlins" && team[num] == "MIA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Mets" && team[num] == "NYM")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Philidelphia Phillies" && team[num] == "PHI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Washington Nationals" && team[num] == "WSN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cincinnati Reds" && team[num] == "CIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago Cubs" && team[num] == "CHC")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Milwaukee Brewers" && team[num] == "MIL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Pittsburgh Pirates" && team[num] == "PIT")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "St. Louis Cardinals" && team[num] == "STL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Arizona Diamondbacks" && team[num] == "ARI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Colorado Rockies" && team[num] == "COL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Dodgers" && team[num] == "LAD")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Francisco Giants" && team[num] == "SFG")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Diego Padres" && team[num] == "SDP")
                                {
                                    printHitters();
                                }
                            }
                            else if (lbHitterPosition.Text == "3rd Base" && position[num] == "3B")
                            {
                                if (lbMLBTeams.Text == "All Teams")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Baltimore Orioles" && team[num] == "BAL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Boston Red Sox" && team[num] == "BOS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Yankees" && team[num] == "NYY")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Tampa Bay Rays" && team[num] == "TBR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Toronto Blue Jays" && team[num] == "TOR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago White Sox" && team[num] == "CWS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cleveland Guardians" && team[num] == "CLE")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Detroit Tigers" && team[num] == "DET")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Kansas City Royals" && team[num] == "KCR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Minnesota Twins" && team[num] == "MIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Houston Astros" && team[num] == "HOU")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Angels" && team[num] == "LAA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Oakland Athletics" && team[num] == "OAK")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Seattle Mariners" && team[num] == "SEA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Texas Rangers" && team[num] == "TEX")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Atlanta Braves" && team[num] == "ATL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Miami Marlins" && team[num] == "MIA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Mets" && team[num] == "NYM")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Philidelphia Phillies" && team[num] == "PHI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Washington Nationals" && team[num] == "WSN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cincinnati Reds" && team[num] == "CIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago Cubs" && team[num] == "CHC")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Milwaukee Brewers" && team[num] == "MIL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Pittsburgh Pirates" && team[num] == "PIT")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "St. Louis Cardinals" && team[num] == "STL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Arizona Diamondbacks" && team[num] == "ARI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Colorado Rockies" && team[num] == "COL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Dodgers" && team[num] == "LAD")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Francisco Giants" && team[num] == "SFG")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Diego Padres" && team[num] == "SDP")
                                {
                                    printHitters();
                                }
                            }
                            else if (lbHitterPosition.Text == "Left Field" && position[num] == "LF")
                            {
                                if (lbMLBTeams.Text == "All Teams")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Baltimore Orioles" && team[num] == "BAL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Boston Red Sox" && team[num] == "BOS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Yankees" && team[num] == "NYY")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Tampa Bay Rays" && team[num] == "TBR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Toronto Blue Jays" && team[num] == "TOR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago White Sox" && team[num] == "CWS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cleveland Guardians" && team[num] == "CLE")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Detroit Tigers" && team[num] == "DET")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Kansas City Royals" && team[num] == "KCR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Minnesota Twins" && team[num] == "MIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Houston Astros" && team[num] == "HOU")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Angels" && team[num] == "LAA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Oakland Athletics" && team[num] == "OAK")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Seattle Mariners" && team[num] == "SEA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Texas Rangers" && team[num] == "TEX")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Atlanta Braves" && team[num] == "ATL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Miami Marlins" && team[num] == "MIA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Mets" && team[num] == "NYM")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Philidelphia Phillies" && team[num] == "PHI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Washington Nationals" && team[num] == "WSN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cincinnati Reds" && team[num] == "CIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago Cubs" && team[num] == "CHC")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Milwaukee Brewers" && team[num] == "MIL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Pittsburgh Pirates" && team[num] == "PIT")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "St. Louis Cardinals" && team[num] == "STL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Arizona Diamondbacks" && team[num] == "ARI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Colorado Rockies" && team[num] == "COL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Dodgers" && team[num] == "LAD")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Francisco Giants" && team[num] == "SFG")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Diego Padres" && team[num] == "SDP")
                                {
                                    printHitters();
                                }
                            }
                            else if (lbHitterPosition.Text == "Center Field" && position[num] == "CF")
                            {
                                if (lbMLBTeams.Text == "All Teams")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Baltimore Orioles" && team[num] == "BAL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Boston Red Sox" && team[num] == "BOS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Yankees" && team[num] == "NYY")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Tampa Bay Rays" && team[num] == "TBR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Toronto Blue Jays" && team[num] == "TOR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago White Sox" && team[num] == "CWS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cleveland Guardians" && team[num] == "CLE")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Detroit Tigers" && team[num] == "DET")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Kansas City Royals" && team[num] == "KCR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Minnesota Twins" && team[num] == "MIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Houston Astros" && team[num] == "HOU")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Angels" && team[num] == "LAA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Oakland Athletics" && team[num] == "OAK")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Seattle Mariners" && team[num] == "SEA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Texas Rangers" && team[num] == "TEX")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Atlanta Braves" && team[num] == "ATL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Miami Marlins" && team[num] == "MIA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Mets" && team[num] == "NYM")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Philidelphia Phillies" && team[num] == "PHI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Washington Nationals" && team[num] == "WSN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cincinnati Reds" && team[num] == "CIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago Cubs" && team[num] == "CHC")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Milwaukee Brewers" && team[num] == "MIL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Pittsburgh Pirates" && team[num] == "PIT")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "St. Louis Cardinals" && team[num] == "STL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Arizona Diamondbacks" && team[num] == "ARI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Colorado Rockies" && team[num] == "COL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Dodgers" && team[num] == "LAD")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Francisco Giants" && team[num] == "SFG")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Diego Padres" && team[num] == "SDP")
                                {
                                    printHitters();
                                }
                            }
                            else if (lbHitterPosition.Text == "Right Field" && position[num] == "RF")
                            {
                                if (lbMLBTeams.Text == "All Teams")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Baltimore Orioles" && team[num] == "BAL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Boston Red Sox" && team[num] == "BOS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Yankees" && team[num] == "NYY")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Tampa Bay Rays" && team[num] == "TBR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Toronto Blue Jays" && team[num] == "TOR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago White Sox" && team[num] == "CWS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cleveland Guardians" && team[num] == "CLE")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Detroit Tigers" && team[num] == "DET")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Kansas City Royals" && team[num] == "KCR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Minnesota Twins" && team[num] == "MIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Houston Astros" && team[num] == "HOU")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Angels" && team[num] == "LAA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Oakland Athletics" && team[num] == "OAK")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Seattle Mariners" && team[num] == "SEA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Texas Rangers" && team[num] == "TEX")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Atlanta Braves" && team[num] == "ATL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Miami Marlins" && team[num] == "MIA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Mets" && team[num] == "NYM")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Philidelphia Phillies" && team[num] == "PHI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Washington Nationals" && team[num] == "WSN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cincinnati Reds" && team[num] == "CIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago Cubs" && team[num] == "CHC")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Milwaukee Brewers" && team[num] == "MIL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Pittsburgh Pirates" && team[num] == "PIT")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "St. Louis Cardinals" && team[num] == "STL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Arizona Diamondbacks" && team[num] == "ARI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Colorado Rockies" && team[num] == "COL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Dodgers" && team[num] == "LAD")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Francisco Giants" && team[num] == "SFG")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Diego Padres" && team[num] == "SDP")
                                {
                                    printHitters();
                                }
                            }
                            else if (lbHitterPosition.Text == "Designated Hitter" && position[num] == "DH")
                            {
                                if (lbMLBTeams.Text == "All Teams")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Baltimore Orioles" && team[num] == "BAL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Boston Red Sox" && team[num] == "BOS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Yankees" && team[num] == "NYY")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Tampa Bay Rays" && team[num] == "TBR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Toronto Blue Jays" && team[num] == "TOR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago White Sox" && team[num] == "CWS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cleveland Guardians" && team[num] == "CLE")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Detroit Tigers" && team[num] == "DET")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Kansas City Royals" && team[num] == "KCR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Minnesota Twins" && team[num] == "MIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Houston Astros" && team[num] == "HOU")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Angels" && team[num] == "LAA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Oakland Athletics" && team[num] == "OAK")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Seattle Mariners" && team[num] == "SEA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Texas Rangers" && team[num] == "TEX")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Atlanta Braves" && team[num] == "ATL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Miami Marlins" && team[num] == "MIA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Mets" && team[num] == "NYM")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Philidelphia Phillies" && team[num] == "PHI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Washington Nationals" && team[num] == "WSN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cincinnati Reds" && team[num] == "CIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago Cubs" && team[num] == "CHC")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Milwaukee Brewers" && team[num] == "MIL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Pittsburgh Pirates" && team[num] == "PIT")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "St. Louis Cardinals" && team[num] == "STL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Arizona Diamondbacks" && team[num] == "ARI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Colorado Rockies" && team[num] == "COL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Dodgers" && team[num] == "LAD")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Francisco Giants" && team[num] == "SFG")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Diego Padres" && team[num] == "SDP")
                                {
                                    printHitters();
                                }
                            }
                            else
                            {
                                if (lbMLBTeams.Text == "All Teams")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Baltimore Orioles" && team[num] == "BAL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Boston Red Sox" && team[num] == "BOS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Yankees" && team[num] == "NYY")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Tampa Bay Rays" && team[num] == "TBR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Toronto Blue Jays" && team[num] == "TOR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago White Sox" && team[num] == "CWS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cleveland Guardians" && team[num] == "CLE")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Detroit Tigers" && team[num] == "DET")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Kansas City Royals" && team[num] == "KCR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Minnesota Twins" && team[num] == "MIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Houston Astros" && team[num] == "HOU")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Angels" && team[num] == "LAA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Oakland Athletics" && team[num] == "OAK")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Seattle Mariners" && team[num] == "SEA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Texas Rangers" && team[num] == "TEX")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Atlanta Braves" && team[num] == "ATL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Miami Marlins" && team[num] == "MIA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Mets" && team[num] == "NYM")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Philidelphia Phillies" && team[num] == "PHI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Washington Nationals" && team[num] == "WSN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cincinnati Reds" && team[num] == "CIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago Cubs" && team[num] == "CHC")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Milwaukee Brewers" && team[num] == "MIL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Pittsburgh Pirates" && team[num] == "PIT")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "St. Louis Cardinals" && team[num] == "STL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Arizona Diamondbacks" && team[num] == "ARI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Colorado Rockies" && team[num] == "COL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Dodgers" && team[num] == "LAD")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Francisco Giants" && team[num] == "SFG")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Diego Padres" && team[num] == "SDP")
                                {
                                    printHitters();
                                }
                            }
                        }
                        }
                    else if (radWest.Checked && radMLB.Checked)
                        {
                            if (division[num] == "W")
                            {
                            if (lbHitterPosition.Text == "Catcher" && position[num] == "C")
                            {
                                if (lbMLBTeams.Text == "All Teams")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Baltimore Orioles" && team[num] == "BAL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Boston Red Sox" && team[num] == "BOS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Yankees" && team[num] == "NYY")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Tampa Bay Rays" && team[num] == "TBR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Toronto Blue Jays" && team[num] == "TOR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago White Sox" && team[num] == "CWS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cleveland Guardians" && team[num] == "CLE")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Detroit Tigers" && team[num] == "DET")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Kansas City Royals" && team[num] == "KCR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Minnesota Twins" && team[num] == "MIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Houston Astros" && team[num] == "HOU")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Angels" && team[num] == "LAA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Oakland Athletics" && team[num] == "OAK")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Seattle Mariners" && team[num] == "SEA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Texas Rangers" && team[num] == "TEX")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Atlanta Braves" && team[num] == "ATL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Miami Marlins" && team[num] == "MIA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Mets" && team[num] == "NYM")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Philidelphia Phillies" && team[num] == "PHI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Washington Nationals" && team[num] == "WSN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cincinnati Reds" && team[num] == "CIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago Cubs" && team[num] == "CHC")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Milwaukee Brewers" && team[num] == "MIL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Pittsburgh Pirates" && team[num] == "PIT")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "St. Louis Cardinals" && team[num] == "STL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Arizona Diamondbacks" && team[num] == "ARI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Colorado Rockies" && team[num] == "COL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Dodgers" && team[num] == "LAD")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Francisco Giants" && team[num] == "SFG")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Diego Padres" && team[num] == "SDP")
                                {
                                    printHitters();
                                }
                            }
                            else if (lbHitterPosition.Text == "1st Base" && position[num] == "1B")
                            {
                                if (lbMLBTeams.Text == "All Teams")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Baltimore Orioles" && team[num] == "BAL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Boston Red Sox" && team[num] == "BOS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Yankees" && team[num] == "NYY")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Tampa Bay Rays" && team[num] == "TBR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Toronto Blue Jays" && team[num] == "TOR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago White Sox" && team[num] == "CWS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cleveland Guardians" && team[num] == "CLE")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Detroit Tigers" && team[num] == "DET")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Kansas City Royals" && team[num] == "KCR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Minnesota Twins" && team[num] == "MIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Houston Astros" && team[num] == "HOU")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Angels" && team[num] == "LAA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Oakland Athletics" && team[num] == "OAK")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Seattle Mariners" && team[num] == "SEA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Texas Rangers" && team[num] == "TEX")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Atlanta Braves" && team[num] == "ATL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Miami Marlins" && team[num] == "MIA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Mets" && team[num] == "NYM")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Philidelphia Phillies" && team[num] == "PHI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Washington Nationals" && team[num] == "WSN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cincinnati Reds" && team[num] == "CIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago Cubs" && team[num] == "CHC")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Milwaukee Brewers" && team[num] == "MIL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Pittsburgh Pirates" && team[num] == "PIT")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "St. Louis Cardinals" && team[num] == "STL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Arizona Diamondbacks" && team[num] == "ARI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Colorado Rockies" && team[num] == "COL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Dodgers" && team[num] == "LAD")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Francisco Giants" && team[num] == "SFG")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Diego Padres" && team[num] == "SDP")
                                {
                                    printHitters();
                                }
                            }
                            else if (lbHitterPosition.Text == "2nd Base" && position[num] == "2B")
                            {
                                if (lbMLBTeams.Text == "All Teams")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Baltimore Orioles" && team[num] == "BAL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Boston Red Sox" && team[num] == "BOS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Yankees" && team[num] == "NYY")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Tampa Bay Rays" && team[num] == "TBR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Toronto Blue Jays" && team[num] == "TOR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago White Sox" && team[num] == "CWS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cleveland Guardians" && team[num] == "CLE")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Detroit Tigers" && team[num] == "DET")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Kansas City Royals" && team[num] == "KCR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Minnesota Twins" && team[num] == "MIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Houston Astros" && team[num] == "HOU")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Angels" && team[num] == "LAA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Oakland Athletics" && team[num] == "OAK")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Seattle Mariners" && team[num] == "SEA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Texas Rangers" && team[num] == "TEX")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Atlanta Braves" && team[num] == "ATL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Miami Marlins" && team[num] == "MIA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Mets" && team[num] == "NYM")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Philidelphia Phillies" && team[num] == "PHI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Washington Nationals" && team[num] == "WSN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cincinnati Reds" && team[num] == "CIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago Cubs" && team[num] == "CHC")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Milwaukee Brewers" && team[num] == "MIL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Pittsburgh Pirates" && team[num] == "PIT")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "St. Louis Cardinals" && team[num] == "STL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Arizona Diamondbacks" && team[num] == "ARI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Colorado Rockies" && team[num] == "COL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Dodgers" && team[num] == "LAD")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Francisco Giants" && team[num] == "SFG")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Diego Padres" && team[num] == "SDP")
                                {
                                    printHitters();
                                }
                            }
                            else if (lbHitterPosition.Text == "Short Stop" && position[num] == "SS")
                            {
                                if (lbMLBTeams.Text == "All Teams")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Baltimore Orioles" && team[num] == "BAL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Boston Red Sox" && team[num] == "BOS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Yankees" && team[num] == "NYY")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Tampa Bay Rays" && team[num] == "TBR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Toronto Blue Jays" && team[num] == "TOR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago White Sox" && team[num] == "CWS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cleveland Guardians" && team[num] == "CLE")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Detroit Tigers" && team[num] == "DET")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Kansas City Royals" && team[num] == "KCR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Minnesota Twins" && team[num] == "MIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Houston Astros" && team[num] == "HOU")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Angels" && team[num] == "LAA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Oakland Athletics" && team[num] == "OAK")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Seattle Mariners" && team[num] == "SEA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Texas Rangers" && team[num] == "TEX")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Atlanta Braves" && team[num] == "ATL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Miami Marlins" && team[num] == "MIA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Mets" && team[num] == "NYM")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Philidelphia Phillies" && team[num] == "PHI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Washington Nationals" && team[num] == "WSN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cincinnati Reds" && team[num] == "CIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago Cubs" && team[num] == "CHC")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Milwaukee Brewers" && team[num] == "MIL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Pittsburgh Pirates" && team[num] == "PIT")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "St. Louis Cardinals" && team[num] == "STL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Arizona Diamondbacks" && team[num] == "ARI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Colorado Rockies" && team[num] == "COL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Dodgers" && team[num] == "LAD")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Francisco Giants" && team[num] == "SFG")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Diego Padres" && team[num] == "SDP")
                                {
                                    printHitters();
                                }
                            }
                            else if (lbHitterPosition.Text == "3rd Base" && position[num] == "3B")
                            {
                                if (lbMLBTeams.Text == "All Teams")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Baltimore Orioles" && team[num] == "BAL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Boston Red Sox" && team[num] == "BOS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Yankees" && team[num] == "NYY")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Tampa Bay Rays" && team[num] == "TBR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Toronto Blue Jays" && team[num] == "TOR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago White Sox" && team[num] == "CWS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cleveland Guardians" && team[num] == "CLE")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Detroit Tigers" && team[num] == "DET")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Kansas City Royals" && team[num] == "KCR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Minnesota Twins" && team[num] == "MIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Houston Astros" && team[num] == "HOU")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Angels" && team[num] == "LAA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Oakland Athletics" && team[num] == "OAK")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Seattle Mariners" && team[num] == "SEA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Texas Rangers" && team[num] == "TEX")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Atlanta Braves" && team[num] == "ATL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Miami Marlins" && team[num] == "MIA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Mets" && team[num] == "NYM")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Philidelphia Phillies" && team[num] == "PHI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Washington Nationals" && team[num] == "WSN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cincinnati Reds" && team[num] == "CIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago Cubs" && team[num] == "CHC")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Milwaukee Brewers" && team[num] == "MIL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Pittsburgh Pirates" && team[num] == "PIT")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "St. Louis Cardinals" && team[num] == "STL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Arizona Diamondbacks" && team[num] == "ARI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Colorado Rockies" && team[num] == "COL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Dodgers" && team[num] == "LAD")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Francisco Giants" && team[num] == "SFG")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Diego Padres" && team[num] == "SDP")
                                {
                                    printHitters();
                                }
                            }
                            else if (lbHitterPosition.Text == "Left Field" && position[num] == "LF")
                            {
                                if (lbMLBTeams.Text == "All Teams")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Baltimore Orioles" && team[num] == "BAL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Boston Red Sox" && team[num] == "BOS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Yankees" && team[num] == "NYY")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Tampa Bay Rays" && team[num] == "TBR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Toronto Blue Jays" && team[num] == "TOR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago White Sox" && team[num] == "CWS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cleveland Guardians" && team[num] == "CLE")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Detroit Tigers" && team[num] == "DET")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Kansas City Royals" && team[num] == "KCR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Minnesota Twins" && team[num] == "MIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Houston Astros" && team[num] == "HOU")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Angels" && team[num] == "LAA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Oakland Athletics" && team[num] == "OAK")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Seattle Mariners" && team[num] == "SEA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Texas Rangers" && team[num] == "TEX")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Atlanta Braves" && team[num] == "ATL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Miami Marlins" && team[num] == "MIA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Mets" && team[num] == "NYM")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Philidelphia Phillies" && team[num] == "PHI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Washington Nationals" && team[num] == "WSN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cincinnati Reds" && team[num] == "CIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago Cubs" && team[num] == "CHC")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Milwaukee Brewers" && team[num] == "MIL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Pittsburgh Pirates" && team[num] == "PIT")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "St. Louis Cardinals" && team[num] == "STL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Arizona Diamondbacks" && team[num] == "ARI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Colorado Rockies" && team[num] == "COL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Dodgers" && team[num] == "LAD")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Francisco Giants" && team[num] == "SFG")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Diego Padres" && team[num] == "SDP")
                                {
                                    printHitters();
                                }
                            }
                            else if (lbHitterPosition.Text == "Center Field" && position[num] == "CF")
                            {
                                if (lbMLBTeams.Text == "All Teams")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Baltimore Orioles" && team[num] == "BAL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Boston Red Sox" && team[num] == "BOS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Yankees" && team[num] == "NYY")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Tampa Bay Rays" && team[num] == "TBR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Toronto Blue Jays" && team[num] == "TOR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago White Sox" && team[num] == "CWS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cleveland Guardians" && team[num] == "CLE")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Detroit Tigers" && team[num] == "DET")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Kansas City Royals" && team[num] == "KCR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Minnesota Twins" && team[num] == "MIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Houston Astros" && team[num] == "HOU")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Angels" && team[num] == "LAA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Oakland Athletics" && team[num] == "OAK")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Seattle Mariners" && team[num] == "SEA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Texas Rangers" && team[num] == "TEX")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Atlanta Braves" && team[num] == "ATL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Miami Marlins" && team[num] == "MIA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Mets" && team[num] == "NYM")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Philidelphia Phillies" && team[num] == "PHI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Washington Nationals" && team[num] == "WSN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cincinnati Reds" && team[num] == "CIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago Cubs" && team[num] == "CHC")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Milwaukee Brewers" && team[num] == "MIL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Pittsburgh Pirates" && team[num] == "PIT")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "St. Louis Cardinals" && team[num] == "STL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Arizona Diamondbacks" && team[num] == "ARI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Colorado Rockies" && team[num] == "COL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Dodgers" && team[num] == "LAD")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Francisco Giants" && team[num] == "SFG")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Diego Padres" && team[num] == "SDP")
                                {
                                    printHitters();
                                }
                            }
                            else if (lbHitterPosition.Text == "Right Field" && position[num] == "RF")
                            {
                                if (lbMLBTeams.Text == "All Teams")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Baltimore Orioles" && team[num] == "BAL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Boston Red Sox" && team[num] == "BOS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Yankees" && team[num] == "NYY")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Tampa Bay Rays" && team[num] == "TBR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Toronto Blue Jays" && team[num] == "TOR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago White Sox" && team[num] == "CWS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cleveland Guardians" && team[num] == "CLE")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Detroit Tigers" && team[num] == "DET")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Kansas City Royals" && team[num] == "KCR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Minnesota Twins" && team[num] == "MIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Houston Astros" && team[num] == "HOU")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Angels" && team[num] == "LAA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Oakland Athletics" && team[num] == "OAK")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Seattle Mariners" && team[num] == "SEA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Texas Rangers" && team[num] == "TEX")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Atlanta Braves" && team[num] == "ATL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Miami Marlins" && team[num] == "MIA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Mets" && team[num] == "NYM")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Philidelphia Phillies" && team[num] == "PHI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Washington Nationals" && team[num] == "WSN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cincinnati Reds" && team[num] == "CIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago Cubs" && team[num] == "CHC")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Milwaukee Brewers" && team[num] == "MIL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Pittsburgh Pirates" && team[num] == "PIT")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "St. Louis Cardinals" && team[num] == "STL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Arizona Diamondbacks" && team[num] == "ARI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Colorado Rockies" && team[num] == "COL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Dodgers" && team[num] == "LAD")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Francisco Giants" && team[num] == "SFG")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Diego Padres" && team[num] == "SDP")
                                {
                                    printHitters();
                                }
                            }
                            else if (lbHitterPosition.Text == "Designated Hitter" && position[num] == "DH")
                            {
                                if (lbMLBTeams.Text == "All Teams")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Baltimore Orioles" && team[num] == "BAL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Boston Red Sox" && team[num] == "BOS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Yankees" && team[num] == "NYY")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Tampa Bay Rays" && team[num] == "TBR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Toronto Blue Jays" && team[num] == "TOR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago White Sox" && team[num] == "CWS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cleveland Guardians" && team[num] == "CLE")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Detroit Tigers" && team[num] == "DET")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Kansas City Royals" && team[num] == "KCR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Minnesota Twins" && team[num] == "MIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Houston Astros" && team[num] == "HOU")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Angels" && team[num] == "LAA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Oakland Athletics" && team[num] == "OAK")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Seattle Mariners" && team[num] == "SEA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Texas Rangers" && team[num] == "TEX")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Atlanta Braves" && team[num] == "ATL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Miami Marlins" && team[num] == "MIA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Mets" && team[num] == "NYM")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Philidelphia Phillies" && team[num] == "PHI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Washington Nationals" && team[num] == "WSN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cincinnati Reds" && team[num] == "CIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago Cubs" && team[num] == "CHC")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Milwaukee Brewers" && team[num] == "MIL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Pittsburgh Pirates" && team[num] == "PIT")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "St. Louis Cardinals" && team[num] == "STL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Arizona Diamondbacks" && team[num] == "ARI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Colorado Rockies" && team[num] == "COL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Dodgers" && team[num] == "LAD")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Francisco Giants" && team[num] == "SFG")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Diego Padres" && team[num] == "SDP")
                                {
                                    printHitters();
                                }
                            }
                            else
                            {
                                if (lbMLBTeams.Text == "All Teams")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Baltimore Orioles" && team[num] == "BAL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Boston Red Sox" && team[num] == "BOS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Yankees" && team[num] == "NYY")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Tampa Bay Rays" && team[num] == "TBR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Toronto Blue Jays" && team[num] == "TOR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago White Sox" && team[num] == "CWS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cleveland Guardians" && team[num] == "CLE")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Detroit Tigers" && team[num] == "DET")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Kansas City Royals" && team[num] == "KCR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Minnesota Twins" && team[num] == "MIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Houston Astros" && team[num] == "HOU")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Angels" && team[num] == "LAA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Oakland Athletics" && team[num] == "OAK")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Seattle Mariners" && team[num] == "SEA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Texas Rangers" && team[num] == "TEX")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Atlanta Braves" && team[num] == "ATL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Miami Marlins" && team[num] == "MIA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Mets" && team[num] == "NYM")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Philidelphia Phillies" && team[num] == "PHI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Washington Nationals" && team[num] == "WSN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cincinnati Reds" && team[num] == "CIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago Cubs" && team[num] == "CHC")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Milwaukee Brewers" && team[num] == "MIL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Pittsburgh Pirates" && team[num] == "PIT")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "St. Louis Cardinals" && team[num] == "STL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Arizona Diamondbacks" && team[num] == "ARI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Colorado Rockies" && team[num] == "COL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Dodgers" && team[num] == "LAD")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Francisco Giants" && team[num] == "SFG")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Diego Padres" && team[num] == "SDP")
                                {
                                    printHitters();
                                }
                            }
                        }
                        }
                    else if (radCentral.Checked && radMLB.Checked)
                        {
                            if (division[num] == "C")
                            {
                            if (lbHitterPosition.Text == "Catcher" && position[num] == "C")
                            {
                                if (lbMLBTeams.Text == "All Teams")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Baltimore Orioles" && team[num] == "BAL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Boston Red Sox" && team[num] == "BOS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Yankees" && team[num] == "NYY")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Tampa Bay Rays" && team[num] == "TBR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Toronto Blue Jays" && team[num] == "TOR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago White Sox" && team[num] == "CWS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cleveland Guardians" && team[num] == "CLE")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Detroit Tigers" && team[num] == "DET")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Kansas City Royals" && team[num] == "KCR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Minnesota Twins" && team[num] == "MIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Houston Astros" && team[num] == "HOU")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Angels" && team[num] == "LAA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Oakland Athletics" && team[num] == "OAK")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Seattle Mariners" && team[num] == "SEA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Texas Rangers" && team[num] == "TEX")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Atlanta Braves" && team[num] == "ATL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Miami Marlins" && team[num] == "MIA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Mets" && team[num] == "NYM")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Philidelphia Phillies" && team[num] == "PHI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Washington Nationals" && team[num] == "WSN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cincinnati Reds" && team[num] == "CIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago Cubs" && team[num] == "CHC")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Milwaukee Brewers" && team[num] == "MIL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Pittsburgh Pirates" && team[num] == "PIT")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "St. Louis Cardinals" && team[num] == "STL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Arizona Diamondbacks" && team[num] == "ARI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Colorado Rockies" && team[num] == "COL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Dodgers" && team[num] == "LAD")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Francisco Giants" && team[num] == "SFG")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Diego Padres" && team[num] == "SDP")
                                {
                                    printHitters();
                                }
                            }
                            else if (lbHitterPosition.Text == "1st Base" && position[num] == "1B")
                            {
                                if (lbMLBTeams.Text == "All Teams")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Baltimore Orioles" && team[num] == "BAL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Boston Red Sox" && team[num] == "BOS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Yankees" && team[num] == "NYY")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Tampa Bay Rays" && team[num] == "TBR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Toronto Blue Jays" && team[num] == "TOR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago White Sox" && team[num] == "CWS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cleveland Guardians" && team[num] == "CLE")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Detroit Tigers" && team[num] == "DET")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Kansas City Royals" && team[num] == "KCR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Minnesota Twins" && team[num] == "MIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Houston Astros" && team[num] == "HOU")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Angels" && team[num] == "LAA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Oakland Athletics" && team[num] == "OAK")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Seattle Mariners" && team[num] == "SEA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Texas Rangers" && team[num] == "TEX")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Atlanta Braves" && team[num] == "ATL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Miami Marlins" && team[num] == "MIA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Mets" && team[num] == "NYM")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Philidelphia Phillies" && team[num] == "PHI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Washington Nationals" && team[num] == "WSN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cincinnati Reds" && team[num] == "CIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago Cubs" && team[num] == "CHC")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Milwaukee Brewers" && team[num] == "MIL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Pittsburgh Pirates" && team[num] == "PIT")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "St. Louis Cardinals" && team[num] == "STL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Arizona Diamondbacks" && team[num] == "ARI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Colorado Rockies" && team[num] == "COL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Dodgers" && team[num] == "LAD")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Francisco Giants" && team[num] == "SFG")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Diego Padres" && team[num] == "SDP")
                                {
                                    printHitters();
                                }
                            }
                            else if (lbHitterPosition.Text == "2nd Base" && position[num] == "2B")
                            {
                                if (lbMLBTeams.Text == "All Teams")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Baltimore Orioles" && team[num] == "BAL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Boston Red Sox" && team[num] == "BOS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Yankees" && team[num] == "NYY")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Tampa Bay Rays" && team[num] == "TBR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Toronto Blue Jays" && team[num] == "TOR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago White Sox" && team[num] == "CWS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cleveland Guardians" && team[num] == "CLE")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Detroit Tigers" && team[num] == "DET")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Kansas City Royals" && team[num] == "KCR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Minnesota Twins" && team[num] == "MIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Houston Astros" && team[num] == "HOU")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Angels" && team[num] == "LAA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Oakland Athletics" && team[num] == "OAK")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Seattle Mariners" && team[num] == "SEA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Texas Rangers" && team[num] == "TEX")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Atlanta Braves" && team[num] == "ATL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Miami Marlins" && team[num] == "MIA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Mets" && team[num] == "NYM")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Philidelphia Phillies" && team[num] == "PHI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Washington Nationals" && team[num] == "WSN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cincinnati Reds" && team[num] == "CIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago Cubs" && team[num] == "CHC")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Milwaukee Brewers" && team[num] == "MIL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Pittsburgh Pirates" && team[num] == "PIT")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "St. Louis Cardinals" && team[num] == "STL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Arizona Diamondbacks" && team[num] == "ARI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Colorado Rockies" && team[num] == "COL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Dodgers" && team[num] == "LAD")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Francisco Giants" && team[num] == "SFG")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Diego Padres" && team[num] == "SDP")
                                {
                                    printHitters();
                                }
                            }
                            else if (lbHitterPosition.Text == "Short Stop" && position[num] == "SS")
                            {
                                if (lbMLBTeams.Text == "All Teams")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Baltimore Orioles" && team[num] == "BAL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Boston Red Sox" && team[num] == "BOS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Yankees" && team[num] == "NYY")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Tampa Bay Rays" && team[num] == "TBR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Toronto Blue Jays" && team[num] == "TOR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago White Sox" && team[num] == "CWS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cleveland Guardians" && team[num] == "CLE")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Detroit Tigers" && team[num] == "DET")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Kansas City Royals" && team[num] == "KCR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Minnesota Twins" && team[num] == "MIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Houston Astros" && team[num] == "HOU")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Angels" && team[num] == "LAA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Oakland Athletics" && team[num] == "OAK")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Seattle Mariners" && team[num] == "SEA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Texas Rangers" && team[num] == "TEX")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Atlanta Braves" && team[num] == "ATL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Miami Marlins" && team[num] == "MIA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Mets" && team[num] == "NYM")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Philidelphia Phillies" && team[num] == "PHI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Washington Nationals" && team[num] == "WSN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cincinnati Reds" && team[num] == "CIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago Cubs" && team[num] == "CHC")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Milwaukee Brewers" && team[num] == "MIL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Pittsburgh Pirates" && team[num] == "PIT")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "St. Louis Cardinals" && team[num] == "STL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Arizona Diamondbacks" && team[num] == "ARI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Colorado Rockies" && team[num] == "COL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Dodgers" && team[num] == "LAD")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Francisco Giants" && team[num] == "SFG")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Diego Padres" && team[num] == "SDP")
                                {
                                    printHitters();
                                }
                            }
                            else if (lbHitterPosition.Text == "3rd Base" && position[num] == "3B")
                            {
                                if (lbMLBTeams.Text == "All Teams")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Baltimore Orioles" && team[num] == "BAL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Boston Red Sox" && team[num] == "BOS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Yankees" && team[num] == "NYY")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Tampa Bay Rays" && team[num] == "TBR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Toronto Blue Jays" && team[num] == "TOR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago White Sox" && team[num] == "CWS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cleveland Guardians" && team[num] == "CLE")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Detroit Tigers" && team[num] == "DET")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Kansas City Royals" && team[num] == "KCR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Minnesota Twins" && team[num] == "MIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Houston Astros" && team[num] == "HOU")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Angels" && team[num] == "LAA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Oakland Athletics" && team[num] == "OAK")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Seattle Mariners" && team[num] == "SEA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Texas Rangers" && team[num] == "TEX")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Atlanta Braves" && team[num] == "ATL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Miami Marlins" && team[num] == "MIA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Mets" && team[num] == "NYM")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Philidelphia Phillies" && team[num] == "PHI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Washington Nationals" && team[num] == "WSN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cincinnati Reds" && team[num] == "CIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago Cubs" && team[num] == "CHC")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Milwaukee Brewers" && team[num] == "MIL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Pittsburgh Pirates" && team[num] == "PIT")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "St. Louis Cardinals" && team[num] == "STL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Arizona Diamondbacks" && team[num] == "ARI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Colorado Rockies" && team[num] == "COL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Dodgers" && team[num] == "LAD")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Francisco Giants" && team[num] == "SFG")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Diego Padres" && team[num] == "SDP")
                                {
                                    printHitters();
                                }
                            }
                            else if (lbHitterPosition.Text == "Left Field" && position[num] == "LF")
                            {
                                if (lbMLBTeams.Text == "All Teams")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Baltimore Orioles" && team[num] == "BAL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Boston Red Sox" && team[num] == "BOS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Yankees" && team[num] == "NYY")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Tampa Bay Rays" && team[num] == "TBR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Toronto Blue Jays" && team[num] == "TOR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago White Sox" && team[num] == "CWS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cleveland Guardians" && team[num] == "CLE")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Detroit Tigers" && team[num] == "DET")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Kansas City Royals" && team[num] == "KCR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Minnesota Twins" && team[num] == "MIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Houston Astros" && team[num] == "HOU")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Angels" && team[num] == "LAA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Oakland Athletics" && team[num] == "OAK")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Seattle Mariners" && team[num] == "SEA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Texas Rangers" && team[num] == "TEX")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Atlanta Braves" && team[num] == "ATL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Miami Marlins" && team[num] == "MIA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Mets" && team[num] == "NYM")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Philidelphia Phillies" && team[num] == "PHI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Washington Nationals" && team[num] == "WSN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cincinnati Reds" && team[num] == "CIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago Cubs" && team[num] == "CHC")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Milwaukee Brewers" && team[num] == "MIL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Pittsburgh Pirates" && team[num] == "PIT")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "St. Louis Cardinals" && team[num] == "STL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Arizona Diamondbacks" && team[num] == "ARI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Colorado Rockies" && team[num] == "COL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Dodgers" && team[num] == "LAD")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Francisco Giants" && team[num] == "SFG")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Diego Padres" && team[num] == "SDP")
                                {
                                    printHitters();
                                }
                            }
                            else if (lbHitterPosition.Text == "Center Field" && position[num] == "CF")
                            {
                                if (lbMLBTeams.Text == "All Teams")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Baltimore Orioles" && team[num] == "BAL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Boston Red Sox" && team[num] == "BOS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Yankees" && team[num] == "NYY")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Tampa Bay Rays" && team[num] == "TBR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Toronto Blue Jays" && team[num] == "TOR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago White Sox" && team[num] == "CWS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cleveland Guardians" && team[num] == "CLE")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Detroit Tigers" && team[num] == "DET")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Kansas City Royals" && team[num] == "KCR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Minnesota Twins" && team[num] == "MIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Houston Astros" && team[num] == "HOU")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Angels" && team[num] == "LAA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Oakland Athletics" && team[num] == "OAK")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Seattle Mariners" && team[num] == "SEA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Texas Rangers" && team[num] == "TEX")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Atlanta Braves" && team[num] == "ATL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Miami Marlins" && team[num] == "MIA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Mets" && team[num] == "NYM")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Philidelphia Phillies" && team[num] == "PHI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Washington Nationals" && team[num] == "WSN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cincinnati Reds" && team[num] == "CIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago Cubs" && team[num] == "CHC")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Milwaukee Brewers" && team[num] == "MIL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Pittsburgh Pirates" && team[num] == "PIT")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "St. Louis Cardinals" && team[num] == "STL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Arizona Diamondbacks" && team[num] == "ARI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Colorado Rockies" && team[num] == "COL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Dodgers" && team[num] == "LAD")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Francisco Giants" && team[num] == "SFG")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Diego Padres" && team[num] == "SDP")
                                {
                                    printHitters();
                                }
                            }
                            else if (lbHitterPosition.Text == "Right Field" && position[num] == "RF")
                            {
                                if (lbMLBTeams.Text == "All Teams")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Baltimore Orioles" && team[num] == "BAL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Boston Red Sox" && team[num] == "BOS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Yankees" && team[num] == "NYY")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Tampa Bay Rays" && team[num] == "TBR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Toronto Blue Jays" && team[num] == "TOR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago White Sox" && team[num] == "CWS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cleveland Guardians" && team[num] == "CLE")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Detroit Tigers" && team[num] == "DET")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Kansas City Royals" && team[num] == "KCR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Minnesota Twins" && team[num] == "MIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Houston Astros" && team[num] == "HOU")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Angels" && team[num] == "LAA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Oakland Athletics" && team[num] == "OAK")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Seattle Mariners" && team[num] == "SEA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Texas Rangers" && team[num] == "TEX")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Atlanta Braves" && team[num] == "ATL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Miami Marlins" && team[num] == "MIA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Mets" && team[num] == "NYM")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Philidelphia Phillies" && team[num] == "PHI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Washington Nationals" && team[num] == "WSN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cincinnati Reds" && team[num] == "CIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago Cubs" && team[num] == "CHC")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Milwaukee Brewers" && team[num] == "MIL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Pittsburgh Pirates" && team[num] == "PIT")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "St. Louis Cardinals" && team[num] == "STL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Arizona Diamondbacks" && team[num] == "ARI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Colorado Rockies" && team[num] == "COL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Dodgers" && team[num] == "LAD")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Francisco Giants" && team[num] == "SFG")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Diego Padres" && team[num] == "SDP")
                                {
                                    printHitters();
                                }
                            }
                            else if (lbHitterPosition.Text == "Designated Hitter" && position[num] == "DH")
                            {
                                if (lbMLBTeams.Text == "All Teams")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Baltimore Orioles" && team[num] == "BAL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Boston Red Sox" && team[num] == "BOS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Yankees" && team[num] == "NYY")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Tampa Bay Rays" && team[num] == "TBR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Toronto Blue Jays" && team[num] == "TOR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago White Sox" && team[num] == "CWS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cleveland Guardians" && team[num] == "CLE")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Detroit Tigers" && team[num] == "DET")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Kansas City Royals" && team[num] == "KCR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Minnesota Twins" && team[num] == "MIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Houston Astros" && team[num] == "HOU")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Angels" && team[num] == "LAA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Oakland Athletics" && team[num] == "OAK")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Seattle Mariners" && team[num] == "SEA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Texas Rangers" && team[num] == "TEX")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Atlanta Braves" && team[num] == "ATL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Miami Marlins" && team[num] == "MIA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Mets" && team[num] == "NYM")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Philidelphia Phillies" && team[num] == "PHI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Washington Nationals" && team[num] == "WSN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cincinnati Reds" && team[num] == "CIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago Cubs" && team[num] == "CHC")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Milwaukee Brewers" && team[num] == "MIL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Pittsburgh Pirates" && team[num] == "PIT")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "St. Louis Cardinals" && team[num] == "STL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Arizona Diamondbacks" && team[num] == "ARI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Colorado Rockies" && team[num] == "COL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Dodgers" && team[num] == "LAD")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Francisco Giants" && team[num] == "SFG")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Diego Padres" && team[num] == "SDP")
                                {
                                    printHitters();
                                }
                            }
                            else
                            {
                                if (lbMLBTeams.Text == "All Teams")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Baltimore Orioles" && team[num] == "BAL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Boston Red Sox" && team[num] == "BOS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Yankees" && team[num] == "NYY")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Tampa Bay Rays" && team[num] == "TBR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Toronto Blue Jays" && team[num] == "TOR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago White Sox" && team[num] == "CWS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cleveland Guardians" && team[num] == "CLE")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Detroit Tigers" && team[num] == "DET")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Kansas City Royals" && team[num] == "KCR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Minnesota Twins" && team[num] == "MIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Houston Astros" && team[num] == "HOU")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Angels" && team[num] == "LAA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Oakland Athletics" && team[num] == "OAK")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Seattle Mariners" && team[num] == "SEA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Texas Rangers" && team[num] == "TEX")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Atlanta Braves" && team[num] == "ATL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Miami Marlins" && team[num] == "MIA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Mets" && team[num] == "NYM")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Philidelphia Phillies" && team[num] == "PHI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Washington Nationals" && team[num] == "WSN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cincinnati Reds" && team[num] == "CIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago Cubs" && team[num] == "CHC")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Milwaukee Brewers" && team[num] == "MIL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Pittsburgh Pirates" && team[num] == "PIT")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "St. Louis Cardinals" && team[num] == "STL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Arizona Diamondbacks" && team[num] == "ARI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Colorado Rockies" && team[num] == "COL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Dodgers" && team[num] == "LAD")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Francisco Giants" && team[num] == "SFG")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Diego Padres" && team[num] == "SDP")
                                {
                                    printHitters();
                                }
                            }
                        }
                        }
                    else if (radEast.Checked && radAL.Checked)
                    {
                        if (division[num] == "E" && league[num] == "AL")
                        {
                            if (lbHitterPosition.Text == "Catcher" && position[num] == "C")
                            {
                                if (lbMLBTeams.Text == "All Teams")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Baltimore Orioles" && team[num] == "BAL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Boston Red Sox" && team[num] == "BOS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Yankees" && team[num] == "NYY")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Tampa Bay Rays" && team[num] == "TBR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Toronto Blue Jays" && team[num] == "TOR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago White Sox" && team[num] == "CWS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cleveland Guardians" && team[num] == "CLE")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Detroit Tigers" && team[num] == "DET")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Kansas City Royals" && team[num] == "KCR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Minnesota Twins" && team[num] == "MIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Houston Astros" && team[num] == "HOU")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Angels" && team[num] == "LAA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Oakland Athletics" && team[num] == "OAK")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Seattle Mariners" && team[num] == "SEA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Texas Rangers" && team[num] == "TEX")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Atlanta Braves" && team[num] == "ATL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Miami Marlins" && team[num] == "MIA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Mets" && team[num] == "NYM")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Philidelphia Phillies" && team[num] == "PHI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Washington Nationals" && team[num] == "WSN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cincinnati Reds" && team[num] == "CIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago Cubs" && team[num] == "CHC")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Milwaukee Brewers" && team[num] == "MIL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Pittsburgh Pirates" && team[num] == "PIT")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "St. Louis Cardinals" && team[num] == "STL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Arizona Diamondbacks" && team[num] == "ARI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Colorado Rockies" && team[num] == "COL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Dodgers" && team[num] == "LAD")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Francisco Giants" && team[num] == "SFG")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Diego Padres" && team[num] == "SDP")
                                {
                                    printHitters();
                                }
                            }
                            else if (lbHitterPosition.Text == "1st Base" && position[num] == "1B")
                            {
                                if (lbMLBTeams.Text == "All Teams")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Baltimore Orioles" && team[num] == "BAL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Boston Red Sox" && team[num] == "BOS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Yankees" && team[num] == "NYY")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Tampa Bay Rays" && team[num] == "TBR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Toronto Blue Jays" && team[num] == "TOR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago White Sox" && team[num] == "CWS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cleveland Guardians" && team[num] == "CLE")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Detroit Tigers" && team[num] == "DET")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Kansas City Royals" && team[num] == "KCR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Minnesota Twins" && team[num] == "MIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Houston Astros" && team[num] == "HOU")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Angels" && team[num] == "LAA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Oakland Athletics" && team[num] == "OAK")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Seattle Mariners" && team[num] == "SEA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Texas Rangers" && team[num] == "TEX")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Atlanta Braves" && team[num] == "ATL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Miami Marlins" && team[num] == "MIA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Mets" && team[num] == "NYM")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Philidelphia Phillies" && team[num] == "PHI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Washington Nationals" && team[num] == "WSN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cincinnati Reds" && team[num] == "CIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago Cubs" && team[num] == "CHC")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Milwaukee Brewers" && team[num] == "MIL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Pittsburgh Pirates" && team[num] == "PIT")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "St. Louis Cardinals" && team[num] == "STL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Arizona Diamondbacks" && team[num] == "ARI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Colorado Rockies" && team[num] == "COL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Dodgers" && team[num] == "LAD")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Francisco Giants" && team[num] == "SFG")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Diego Padres" && team[num] == "SDP")
                                {
                                    printHitters();
                                }
                            }
                            else if (lbHitterPosition.Text == "2nd Base" && position[num] == "2B")
                            {
                                if (lbMLBTeams.Text == "All Teams")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Baltimore Orioles" && team[num] == "BAL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Boston Red Sox" && team[num] == "BOS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Yankees" && team[num] == "NYY")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Tampa Bay Rays" && team[num] == "TBR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Toronto Blue Jays" && team[num] == "TOR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago White Sox" && team[num] == "CWS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cleveland Guardians" && team[num] == "CLE")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Detroit Tigers" && team[num] == "DET")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Kansas City Royals" && team[num] == "KCR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Minnesota Twins" && team[num] == "MIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Houston Astros" && team[num] == "HOU")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Angels" && team[num] == "LAA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Oakland Athletics" && team[num] == "OAK")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Seattle Mariners" && team[num] == "SEA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Texas Rangers" && team[num] == "TEX")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Atlanta Braves" && team[num] == "ATL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Miami Marlins" && team[num] == "MIA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Mets" && team[num] == "NYM")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Philidelphia Phillies" && team[num] == "PHI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Washington Nationals" && team[num] == "WSN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cincinnati Reds" && team[num] == "CIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago Cubs" && team[num] == "CHC")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Milwaukee Brewers" && team[num] == "MIL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Pittsburgh Pirates" && team[num] == "PIT")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "St. Louis Cardinals" && team[num] == "STL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Arizona Diamondbacks" && team[num] == "ARI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Colorado Rockies" && team[num] == "COL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Dodgers" && team[num] == "LAD")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Francisco Giants" && team[num] == "SFG")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Diego Padres" && team[num] == "SDP")
                                {
                                    printHitters();
                                }
                            }
                            else if (lbHitterPosition.Text == "Short Stop" && position[num] == "SS")
                            {
                                if (lbMLBTeams.Text == "All Teams")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Baltimore Orioles" && team[num] == "BAL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Boston Red Sox" && team[num] == "BOS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Yankees" && team[num] == "NYY")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Tampa Bay Rays" && team[num] == "TBR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Toronto Blue Jays" && team[num] == "TOR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago White Sox" && team[num] == "CWS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cleveland Guardians" && team[num] == "CLE")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Detroit Tigers" && team[num] == "DET")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Kansas City Royals" && team[num] == "KCR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Minnesota Twins" && team[num] == "MIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Houston Astros" && team[num] == "HOU")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Angels" && team[num] == "LAA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Oakland Athletics" && team[num] == "OAK")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Seattle Mariners" && team[num] == "SEA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Texas Rangers" && team[num] == "TEX")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Atlanta Braves" && team[num] == "ATL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Miami Marlins" && team[num] == "MIA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Mets" && team[num] == "NYM")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Philidelphia Phillies" && team[num] == "PHI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Washington Nationals" && team[num] == "WSN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cincinnati Reds" && team[num] == "CIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago Cubs" && team[num] == "CHC")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Milwaukee Brewers" && team[num] == "MIL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Pittsburgh Pirates" && team[num] == "PIT")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "St. Louis Cardinals" && team[num] == "STL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Arizona Diamondbacks" && team[num] == "ARI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Colorado Rockies" && team[num] == "COL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Dodgers" && team[num] == "LAD")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Francisco Giants" && team[num] == "SFG")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Diego Padres" && team[num] == "SDP")
                                {
                                    printHitters();
                                }
                            }
                            else if (lbHitterPosition.Text == "3rd Base" && position[num] == "3B")
                            {
                                if (lbMLBTeams.Text == "All Teams")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Baltimore Orioles" && team[num] == "BAL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Boston Red Sox" && team[num] == "BOS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Yankees" && team[num] == "NYY")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Tampa Bay Rays" && team[num] == "TBR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Toronto Blue Jays" && team[num] == "TOR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago White Sox" && team[num] == "CWS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cleveland Guardians" && team[num] == "CLE")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Detroit Tigers" && team[num] == "DET")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Kansas City Royals" && team[num] == "KCR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Minnesota Twins" && team[num] == "MIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Houston Astros" && team[num] == "HOU")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Angels" && team[num] == "LAA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Oakland Athletics" && team[num] == "OAK")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Seattle Mariners" && team[num] == "SEA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Texas Rangers" && team[num] == "TEX")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Atlanta Braves" && team[num] == "ATL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Miami Marlins" && team[num] == "MIA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Mets" && team[num] == "NYM")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Philidelphia Phillies" && team[num] == "PHI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Washington Nationals" && team[num] == "WSN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cincinnati Reds" && team[num] == "CIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago Cubs" && team[num] == "CHC")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Milwaukee Brewers" && team[num] == "MIL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Pittsburgh Pirates" && team[num] == "PIT")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "St. Louis Cardinals" && team[num] == "STL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Arizona Diamondbacks" && team[num] == "ARI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Colorado Rockies" && team[num] == "COL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Dodgers" && team[num] == "LAD")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Francisco Giants" && team[num] == "SFG")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Diego Padres" && team[num] == "SDP")
                                {
                                    printHitters();
                                }
                            }
                            else if (lbHitterPosition.Text == "Left Field" && position[num] == "LF")
                            {
                                if (lbMLBTeams.Text == "All Teams")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Baltimore Orioles" && team[num] == "BAL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Boston Red Sox" && team[num] == "BOS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Yankees" && team[num] == "NYY")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Tampa Bay Rays" && team[num] == "TBR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Toronto Blue Jays" && team[num] == "TOR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago White Sox" && team[num] == "CWS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cleveland Guardians" && team[num] == "CLE")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Detroit Tigers" && team[num] == "DET")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Kansas City Royals" && team[num] == "KCR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Minnesota Twins" && team[num] == "MIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Houston Astros" && team[num] == "HOU")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Angels" && team[num] == "LAA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Oakland Athletics" && team[num] == "OAK")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Seattle Mariners" && team[num] == "SEA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Texas Rangers" && team[num] == "TEX")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Atlanta Braves" && team[num] == "ATL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Miami Marlins" && team[num] == "MIA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Mets" && team[num] == "NYM")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Philidelphia Phillies" && team[num] == "PHI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Washington Nationals" && team[num] == "WSN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cincinnati Reds" && team[num] == "CIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago Cubs" && team[num] == "CHC")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Milwaukee Brewers" && team[num] == "MIL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Pittsburgh Pirates" && team[num] == "PIT")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "St. Louis Cardinals" && team[num] == "STL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Arizona Diamondbacks" && team[num] == "ARI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Colorado Rockies" && team[num] == "COL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Dodgers" && team[num] == "LAD")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Francisco Giants" && team[num] == "SFG")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Diego Padres" && team[num] == "SDP")
                                {
                                    printHitters();
                                }
                            }
                            else if (lbHitterPosition.Text == "Center Field" && position[num] == "CF")
                            {
                                if (lbMLBTeams.Text == "All Teams")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Baltimore Orioles" && team[num] == "BAL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Boston Red Sox" && team[num] == "BOS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Yankees" && team[num] == "NYY")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Tampa Bay Rays" && team[num] == "TBR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Toronto Blue Jays" && team[num] == "TOR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago White Sox" && team[num] == "CWS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cleveland Guardians" && team[num] == "CLE")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Detroit Tigers" && team[num] == "DET")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Kansas City Royals" && team[num] == "KCR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Minnesota Twins" && team[num] == "MIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Houston Astros" && team[num] == "HOU")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Angels" && team[num] == "LAA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Oakland Athletics" && team[num] == "OAK")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Seattle Mariners" && team[num] == "SEA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Texas Rangers" && team[num] == "TEX")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Atlanta Braves" && team[num] == "ATL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Miami Marlins" && team[num] == "MIA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Mets" && team[num] == "NYM")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Philidelphia Phillies" && team[num] == "PHI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Washington Nationals" && team[num] == "WSN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cincinnati Reds" && team[num] == "CIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago Cubs" && team[num] == "CHC")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Milwaukee Brewers" && team[num] == "MIL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Pittsburgh Pirates" && team[num] == "PIT")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "St. Louis Cardinals" && team[num] == "STL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Arizona Diamondbacks" && team[num] == "ARI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Colorado Rockies" && team[num] == "COL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Dodgers" && team[num] == "LAD")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Francisco Giants" && team[num] == "SFG")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Diego Padres" && team[num] == "SDP")
                                {
                                    printHitters();
                                }
                            }
                            else if (lbHitterPosition.Text == "Right Field" && position[num] == "RF")
                            {
                                if (lbMLBTeams.Text == "All Teams")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Baltimore Orioles" && team[num] == "BAL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Boston Red Sox" && team[num] == "BOS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Yankees" && team[num] == "NYY")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Tampa Bay Rays" && team[num] == "TBR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Toronto Blue Jays" && team[num] == "TOR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago White Sox" && team[num] == "CWS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cleveland Guardians" && team[num] == "CLE")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Detroit Tigers" && team[num] == "DET")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Kansas City Royals" && team[num] == "KCR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Minnesota Twins" && team[num] == "MIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Houston Astros" && team[num] == "HOU")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Angels" && team[num] == "LAA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Oakland Athletics" && team[num] == "OAK")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Seattle Mariners" && team[num] == "SEA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Texas Rangers" && team[num] == "TEX")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Atlanta Braves" && team[num] == "ATL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Miami Marlins" && team[num] == "MIA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Mets" && team[num] == "NYM")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Philidelphia Phillies" && team[num] == "PHI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Washington Nationals" && team[num] == "WSN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cincinnati Reds" && team[num] == "CIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago Cubs" && team[num] == "CHC")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Milwaukee Brewers" && team[num] == "MIL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Pittsburgh Pirates" && team[num] == "PIT")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "St. Louis Cardinals" && team[num] == "STL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Arizona Diamondbacks" && team[num] == "ARI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Colorado Rockies" && team[num] == "COL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Dodgers" && team[num] == "LAD")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Francisco Giants" && team[num] == "SFG")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Diego Padres" && team[num] == "SDP")
                                {
                                    printHitters();
                                }
                            }
                            else if (lbHitterPosition.Text == "Designated Hitter" && position[num] == "DH")
                            {
                                if (lbMLBTeams.Text == "All Teams")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Baltimore Orioles" && team[num] == "BAL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Boston Red Sox" && team[num] == "BOS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Yankees" && team[num] == "NYY")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Tampa Bay Rays" && team[num] == "TBR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Toronto Blue Jays" && team[num] == "TOR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago White Sox" && team[num] == "CWS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cleveland Guardians" && team[num] == "CLE")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Detroit Tigers" && team[num] == "DET")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Kansas City Royals" && team[num] == "KCR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Minnesota Twins" && team[num] == "MIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Houston Astros" && team[num] == "HOU")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Angels" && team[num] == "LAA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Oakland Athletics" && team[num] == "OAK")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Seattle Mariners" && team[num] == "SEA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Texas Rangers" && team[num] == "TEX")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Atlanta Braves" && team[num] == "ATL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Miami Marlins" && team[num] == "MIA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Mets" && team[num] == "NYM")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Philidelphia Phillies" && team[num] == "PHI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Washington Nationals" && team[num] == "WSN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cincinnati Reds" && team[num] == "CIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago Cubs" && team[num] == "CHC")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Milwaukee Brewers" && team[num] == "MIL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Pittsburgh Pirates" && team[num] == "PIT")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "St. Louis Cardinals" && team[num] == "STL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Arizona Diamondbacks" && team[num] == "ARI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Colorado Rockies" && team[num] == "COL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Dodgers" && team[num] == "LAD")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Francisco Giants" && team[num] == "SFG")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Diego Padres" && team[num] == "SDP")
                                {
                                    printHitters();
                                }
                            }
                            else
                            {
                                if (lbMLBTeams.Text == "All Teams")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Baltimore Orioles" && team[num] == "BAL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Boston Red Sox" && team[num] == "BOS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Yankees" && team[num] == "NYY")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Tampa Bay Rays" && team[num] == "TBR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Toronto Blue Jays" && team[num] == "TOR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago White Sox" && team[num] == "CWS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cleveland Guardians" && team[num] == "CLE")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Detroit Tigers" && team[num] == "DET")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Kansas City Royals" && team[num] == "KCR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Minnesota Twins" && team[num] == "MIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Houston Astros" && team[num] == "HOU")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Angels" && team[num] == "LAA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Oakland Athletics" && team[num] == "OAK")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Seattle Mariners" && team[num] == "SEA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Texas Rangers" && team[num] == "TEX")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Atlanta Braves" && team[num] == "ATL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Miami Marlins" && team[num] == "MIA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Mets" && team[num] == "NYM")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Philidelphia Phillies" && team[num] == "PHI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Washington Nationals" && team[num] == "WSN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cincinnati Reds" && team[num] == "CIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago Cubs" && team[num] == "CHC")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Milwaukee Brewers" && team[num] == "MIL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Pittsburgh Pirates" && team[num] == "PIT")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "St. Louis Cardinals" && team[num] == "STL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Arizona Diamondbacks" && team[num] == "ARI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Colorado Rockies" && team[num] == "COL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Dodgers" && team[num] == "LAD")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Francisco Giants" && team[num] == "SFG")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Diego Padres" && team[num] == "SDP")
                                {
                                    printHitters();
                                }
                            }
                        }
                    }
                    else if (radWest.Checked && radAL.Checked)
                    {
                        if (division[num] == "W" && league[num] == "AL")
                        {
                            if (lbHitterPosition.Text == "Catcher" && position[num] == "C")
                            {
                                if (lbMLBTeams.Text == "All Teams")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Baltimore Orioles" && team[num] == "BAL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Boston Red Sox" && team[num] == "BOS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Yankees" && team[num] == "NYY")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Tampa Bay Rays" && team[num] == "TBR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Toronto Blue Jays" && team[num] == "TOR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago White Sox" && team[num] == "CWS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cleveland Guardians" && team[num] == "CLE")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Detroit Tigers" && team[num] == "DET")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Kansas City Royals" && team[num] == "KCR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Minnesota Twins" && team[num] == "MIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Houston Astros" && team[num] == "HOU")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Angels" && team[num] == "LAA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Oakland Athletics" && team[num] == "OAK")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Seattle Mariners" && team[num] == "SEA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Texas Rangers" && team[num] == "TEX")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Atlanta Braves" && team[num] == "ATL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Miami Marlins" && team[num] == "MIA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Mets" && team[num] == "NYM")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Philidelphia Phillies" && team[num] == "PHI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Washington Nationals" && team[num] == "WSN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cincinnati Reds" && team[num] == "CIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago Cubs" && team[num] == "CHC")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Milwaukee Brewers" && team[num] == "MIL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Pittsburgh Pirates" && team[num] == "PIT")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "St. Louis Cardinals" && team[num] == "STL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Arizona Diamondbacks" && team[num] == "ARI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Colorado Rockies" && team[num] == "COL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Dodgers" && team[num] == "LAD")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Francisco Giants" && team[num] == "SFG")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Diego Padres" && team[num] == "SDP")
                                {
                                    printHitters();
                                }
                            }
                            else if (lbHitterPosition.Text == "1st Base" && position[num] == "1B")
                            {
                                if (lbMLBTeams.Text == "All Teams")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Baltimore Orioles" && team[num] == "BAL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Boston Red Sox" && team[num] == "BOS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Yankees" && team[num] == "NYY")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Tampa Bay Rays" && team[num] == "TBR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Toronto Blue Jays" && team[num] == "TOR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago White Sox" && team[num] == "CWS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cleveland Guardians" && team[num] == "CLE")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Detroit Tigers" && team[num] == "DET")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Kansas City Royals" && team[num] == "KCR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Minnesota Twins" && team[num] == "MIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Houston Astros" && team[num] == "HOU")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Angels" && team[num] == "LAA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Oakland Athletics" && team[num] == "OAK")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Seattle Mariners" && team[num] == "SEA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Texas Rangers" && team[num] == "TEX")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Atlanta Braves" && team[num] == "ATL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Miami Marlins" && team[num] == "MIA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Mets" && team[num] == "NYM")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Philidelphia Phillies" && team[num] == "PHI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Washington Nationals" && team[num] == "WSN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cincinnati Reds" && team[num] == "CIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago Cubs" && team[num] == "CHC")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Milwaukee Brewers" && team[num] == "MIL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Pittsburgh Pirates" && team[num] == "PIT")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "St. Louis Cardinals" && team[num] == "STL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Arizona Diamondbacks" && team[num] == "ARI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Colorado Rockies" && team[num] == "COL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Dodgers" && team[num] == "LAD")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Francisco Giants" && team[num] == "SFG")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Diego Padres" && team[num] == "SDP")
                                {
                                    printHitters();
                                }
                            }
                            else if (lbHitterPosition.Text == "2nd Base" && position[num] == "2B")
                            {
                                if (lbMLBTeams.Text == "All Teams")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Baltimore Orioles" && team[num] == "BAL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Boston Red Sox" && team[num] == "BOS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Yankees" && team[num] == "NYY")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Tampa Bay Rays" && team[num] == "TBR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Toronto Blue Jays" && team[num] == "TOR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago White Sox" && team[num] == "CWS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cleveland Guardians" && team[num] == "CLE")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Detroit Tigers" && team[num] == "DET")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Kansas City Royals" && team[num] == "KCR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Minnesota Twins" && team[num] == "MIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Houston Astros" && team[num] == "HOU")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Angels" && team[num] == "LAA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Oakland Athletics" && team[num] == "OAK")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Seattle Mariners" && team[num] == "SEA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Texas Rangers" && team[num] == "TEX")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Atlanta Braves" && team[num] == "ATL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Miami Marlins" && team[num] == "MIA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Mets" && team[num] == "NYM")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Philidelphia Phillies" && team[num] == "PHI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Washington Nationals" && team[num] == "WSN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cincinnati Reds" && team[num] == "CIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago Cubs" && team[num] == "CHC")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Milwaukee Brewers" && team[num] == "MIL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Pittsburgh Pirates" && team[num] == "PIT")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "St. Louis Cardinals" && team[num] == "STL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Arizona Diamondbacks" && team[num] == "ARI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Colorado Rockies" && team[num] == "COL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Dodgers" && team[num] == "LAD")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Francisco Giants" && team[num] == "SFG")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Diego Padres" && team[num] == "SDP")
                                {
                                    printHitters();
                                }
                            }
                            else if (lbHitterPosition.Text == "Short Stop" && position[num] == "SS")
                            {
                                if (lbMLBTeams.Text == "All Teams")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Baltimore Orioles" && team[num] == "BAL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Boston Red Sox" && team[num] == "BOS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Yankees" && team[num] == "NYY")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Tampa Bay Rays" && team[num] == "TBR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Toronto Blue Jays" && team[num] == "TOR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago White Sox" && team[num] == "CWS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cleveland Guardians" && team[num] == "CLE")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Detroit Tigers" && team[num] == "DET")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Kansas City Royals" && team[num] == "KCR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Minnesota Twins" && team[num] == "MIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Houston Astros" && team[num] == "HOU")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Angels" && team[num] == "LAA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Oakland Athletics" && team[num] == "OAK")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Seattle Mariners" && team[num] == "SEA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Texas Rangers" && team[num] == "TEX")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Atlanta Braves" && team[num] == "ATL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Miami Marlins" && team[num] == "MIA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Mets" && team[num] == "NYM")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Philidelphia Phillies" && team[num] == "PHI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Washington Nationals" && team[num] == "WSN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cincinnati Reds" && team[num] == "CIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago Cubs" && team[num] == "CHC")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Milwaukee Brewers" && team[num] == "MIL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Pittsburgh Pirates" && team[num] == "PIT")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "St. Louis Cardinals" && team[num] == "STL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Arizona Diamondbacks" && team[num] == "ARI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Colorado Rockies" && team[num] == "COL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Dodgers" && team[num] == "LAD")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Francisco Giants" && team[num] == "SFG")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Diego Padres" && team[num] == "SDP")
                                {
                                    printHitters();
                                }
                            }
                            else if (lbHitterPosition.Text == "3rd Base" && position[num] == "3B")
                            {
                                if (lbMLBTeams.Text == "All Teams")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Baltimore Orioles" && team[num] == "BAL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Boston Red Sox" && team[num] == "BOS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Yankees" && team[num] == "NYY")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Tampa Bay Rays" && team[num] == "TBR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Toronto Blue Jays" && team[num] == "TOR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago White Sox" && team[num] == "CWS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cleveland Guardians" && team[num] == "CLE")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Detroit Tigers" && team[num] == "DET")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Kansas City Royals" && team[num] == "KCR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Minnesota Twins" && team[num] == "MIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Houston Astros" && team[num] == "HOU")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Angels" && team[num] == "LAA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Oakland Athletics" && team[num] == "OAK")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Seattle Mariners" && team[num] == "SEA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Texas Rangers" && team[num] == "TEX")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Atlanta Braves" && team[num] == "ATL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Miami Marlins" && team[num] == "MIA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Mets" && team[num] == "NYM")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Philidelphia Phillies" && team[num] == "PHI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Washington Nationals" && team[num] == "WSN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cincinnati Reds" && team[num] == "CIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago Cubs" && team[num] == "CHC")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Milwaukee Brewers" && team[num] == "MIL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Pittsburgh Pirates" && team[num] == "PIT")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "St. Louis Cardinals" && team[num] == "STL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Arizona Diamondbacks" && team[num] == "ARI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Colorado Rockies" && team[num] == "COL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Dodgers" && team[num] == "LAD")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Francisco Giants" && team[num] == "SFG")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Diego Padres" && team[num] == "SDP")
                                {
                                    printHitters();
                                }
                            }
                            else if (lbHitterPosition.Text == "Left Field" && position[num] == "LF")
                            {
                                if (lbMLBTeams.Text == "All Teams")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Baltimore Orioles" && team[num] == "BAL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Boston Red Sox" && team[num] == "BOS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Yankees" && team[num] == "NYY")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Tampa Bay Rays" && team[num] == "TBR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Toronto Blue Jays" && team[num] == "TOR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago White Sox" && team[num] == "CWS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cleveland Guardians" && team[num] == "CLE")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Detroit Tigers" && team[num] == "DET")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Kansas City Royals" && team[num] == "KCR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Minnesota Twins" && team[num] == "MIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Houston Astros" && team[num] == "HOU")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Angels" && team[num] == "LAA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Oakland Athletics" && team[num] == "OAK")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Seattle Mariners" && team[num] == "SEA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Texas Rangers" && team[num] == "TEX")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Atlanta Braves" && team[num] == "ATL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Miami Marlins" && team[num] == "MIA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Mets" && team[num] == "NYM")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Philidelphia Phillies" && team[num] == "PHI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Washington Nationals" && team[num] == "WSN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cincinnati Reds" && team[num] == "CIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago Cubs" && team[num] == "CHC")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Milwaukee Brewers" && team[num] == "MIL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Pittsburgh Pirates" && team[num] == "PIT")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "St. Louis Cardinals" && team[num] == "STL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Arizona Diamondbacks" && team[num] == "ARI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Colorado Rockies" && team[num] == "COL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Dodgers" && team[num] == "LAD")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Francisco Giants" && team[num] == "SFG")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Diego Padres" && team[num] == "SDP")
                                {
                                    printHitters();
                                }
                            }
                            else if (lbHitterPosition.Text == "Center Field" && position[num] == "CF")
                            {
                                if (lbMLBTeams.Text == "All Teams")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Baltimore Orioles" && team[num] == "BAL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Boston Red Sox" && team[num] == "BOS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Yankees" && team[num] == "NYY")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Tampa Bay Rays" && team[num] == "TBR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Toronto Blue Jays" && team[num] == "TOR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago White Sox" && team[num] == "CWS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cleveland Guardians" && team[num] == "CLE")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Detroit Tigers" && team[num] == "DET")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Kansas City Royals" && team[num] == "KCR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Minnesota Twins" && team[num] == "MIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Houston Astros" && team[num] == "HOU")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Angels" && team[num] == "LAA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Oakland Athletics" && team[num] == "OAK")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Seattle Mariners" && team[num] == "SEA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Texas Rangers" && team[num] == "TEX")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Atlanta Braves" && team[num] == "ATL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Miami Marlins" && team[num] == "MIA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Mets" && team[num] == "NYM")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Philidelphia Phillies" && team[num] == "PHI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Washington Nationals" && team[num] == "WSN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cincinnati Reds" && team[num] == "CIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago Cubs" && team[num] == "CHC")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Milwaukee Brewers" && team[num] == "MIL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Pittsburgh Pirates" && team[num] == "PIT")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "St. Louis Cardinals" && team[num] == "STL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Arizona Diamondbacks" && team[num] == "ARI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Colorado Rockies" && team[num] == "COL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Dodgers" && team[num] == "LAD")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Francisco Giants" && team[num] == "SFG")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Diego Padres" && team[num] == "SDP")
                                {
                                    printHitters();
                                }
                            }
                            else if (lbHitterPosition.Text == "Right Field" && position[num] == "RF")
                            {
                                if (lbMLBTeams.Text == "All Teams")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Baltimore Orioles" && team[num] == "BAL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Boston Red Sox" && team[num] == "BOS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Yankees" && team[num] == "NYY")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Tampa Bay Rays" && team[num] == "TBR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Toronto Blue Jays" && team[num] == "TOR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago White Sox" && team[num] == "CWS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cleveland Guardians" && team[num] == "CLE")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Detroit Tigers" && team[num] == "DET")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Kansas City Royals" && team[num] == "KCR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Minnesota Twins" && team[num] == "MIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Houston Astros" && team[num] == "HOU")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Angels" && team[num] == "LAA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Oakland Athletics" && team[num] == "OAK")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Seattle Mariners" && team[num] == "SEA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Texas Rangers" && team[num] == "TEX")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Atlanta Braves" && team[num] == "ATL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Miami Marlins" && team[num] == "MIA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Mets" && team[num] == "NYM")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Philidelphia Phillies" && team[num] == "PHI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Washington Nationals" && team[num] == "WSN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cincinnati Reds" && team[num] == "CIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago Cubs" && team[num] == "CHC")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Milwaukee Brewers" && team[num] == "MIL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Pittsburgh Pirates" && team[num] == "PIT")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "St. Louis Cardinals" && team[num] == "STL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Arizona Diamondbacks" && team[num] == "ARI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Colorado Rockies" && team[num] == "COL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Dodgers" && team[num] == "LAD")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Francisco Giants" && team[num] == "SFG")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Diego Padres" && team[num] == "SDP")
                                {
                                    printHitters();
                                }
                            }
                            else if (lbHitterPosition.Text == "Designated Hitter" && position[num] == "DH")
                            {
                                if (lbMLBTeams.Text == "All Teams")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Baltimore Orioles" && team[num] == "BAL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Boston Red Sox" && team[num] == "BOS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Yankees" && team[num] == "NYY")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Tampa Bay Rays" && team[num] == "TBR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Toronto Blue Jays" && team[num] == "TOR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago White Sox" && team[num] == "CWS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cleveland Guardians" && team[num] == "CLE")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Detroit Tigers" && team[num] == "DET")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Kansas City Royals" && team[num] == "KCR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Minnesota Twins" && team[num] == "MIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Houston Astros" && team[num] == "HOU")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Angels" && team[num] == "LAA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Oakland Athletics" && team[num] == "OAK")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Seattle Mariners" && team[num] == "SEA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Texas Rangers" && team[num] == "TEX")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Atlanta Braves" && team[num] == "ATL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Miami Marlins" && team[num] == "MIA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Mets" && team[num] == "NYM")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Philidelphia Phillies" && team[num] == "PHI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Washington Nationals" && team[num] == "WSN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cincinnati Reds" && team[num] == "CIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago Cubs" && team[num] == "CHC")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Milwaukee Brewers" && team[num] == "MIL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Pittsburgh Pirates" && team[num] == "PIT")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "St. Louis Cardinals" && team[num] == "STL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Arizona Diamondbacks" && team[num] == "ARI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Colorado Rockies" && team[num] == "COL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Dodgers" && team[num] == "LAD")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Francisco Giants" && team[num] == "SFG")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Diego Padres" && team[num] == "SDP")
                                {
                                    printHitters();
                                }
                            }
                            else
                            {
                                if (lbMLBTeams.Text == "All Teams")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Baltimore Orioles" && team[num] == "BAL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Boston Red Sox" && team[num] == "BOS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Yankees" && team[num] == "NYY")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Tampa Bay Rays" && team[num] == "TBR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Toronto Blue Jays" && team[num] == "TOR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago White Sox" && team[num] == "CWS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cleveland Guardians" && team[num] == "CLE")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Detroit Tigers" && team[num] == "DET")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Kansas City Royals" && team[num] == "KCR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Minnesota Twins" && team[num] == "MIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Houston Astros" && team[num] == "HOU")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Angels" && team[num] == "LAA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Oakland Athletics" && team[num] == "OAK")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Seattle Mariners" && team[num] == "SEA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Texas Rangers" && team[num] == "TEX")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Atlanta Braves" && team[num] == "ATL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Miami Marlins" && team[num] == "MIA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Mets" && team[num] == "NYM")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Philidelphia Phillies" && team[num] == "PHI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Washington Nationals" && team[num] == "WSN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cincinnati Reds" && team[num] == "CIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago Cubs" && team[num] == "CHC")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Milwaukee Brewers" && team[num] == "MIL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Pittsburgh Pirates" && team[num] == "PIT")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "St. Louis Cardinals" && team[num] == "STL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Arizona Diamondbacks" && team[num] == "ARI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Colorado Rockies" && team[num] == "COL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Dodgers" && team[num] == "LAD")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Francisco Giants" && team[num] == "SFG")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Diego Padres" && team[num] == "SDP")
                                {
                                    printHitters();
                                }
                            }
                        }
                    }
                    else if (radCentral.Checked && radAL.Checked)
                    {
                        if (division[num] == "C" && league[num] == "AL")
                        {
                            if (lbHitterPosition.Text == "Catcher" && position[num] == "C")
                            {
                                if (lbMLBTeams.Text == "All Teams")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Baltimore Orioles" && team[num] == "BAL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Boston Red Sox" && team[num] == "BOS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Yankees" && team[num] == "NYY")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Tampa Bay Rays" && team[num] == "TBR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Toronto Blue Jays" && team[num] == "TOR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago White Sox" && team[num] == "CWS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cleveland Guardians" && team[num] == "CLE")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Detroit Tigers" && team[num] == "DET")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Kansas City Royals" && team[num] == "KCR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Minnesota Twins" && team[num] == "MIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Houston Astros" && team[num] == "HOU")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Angels" && team[num] == "LAA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Oakland Athletics" && team[num] == "OAK")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Seattle Mariners" && team[num] == "SEA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Texas Rangers" && team[num] == "TEX")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Atlanta Braves" && team[num] == "ATL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Miami Marlins" && team[num] == "MIA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Mets" && team[num] == "NYM")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Philidelphia Phillies" && team[num] == "PHI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Washington Nationals" && team[num] == "WSN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cincinnati Reds" && team[num] == "CIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago Cubs" && team[num] == "CHC")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Milwaukee Brewers" && team[num] == "MIL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Pittsburgh Pirates" && team[num] == "PIT")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "St. Louis Cardinals" && team[num] == "STL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Arizona Diamondbacks" && team[num] == "ARI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Colorado Rockies" && team[num] == "COL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Dodgers" && team[num] == "LAD")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Francisco Giants" && team[num] == "SFG")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Diego Padres" && team[num] == "SDP")
                                {
                                    printHitters();
                                }
                            }
                            else if (lbHitterPosition.Text == "1st Base" && position[num] == "1B")
                            {
                                if (lbMLBTeams.Text == "All Teams")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Baltimore Orioles" && team[num] == "BAL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Boston Red Sox" && team[num] == "BOS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Yankees" && team[num] == "NYY")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Tampa Bay Rays" && team[num] == "TBR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Toronto Blue Jays" && team[num] == "TOR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago White Sox" && team[num] == "CWS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cleveland Guardians" && team[num] == "CLE")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Detroit Tigers" && team[num] == "DET")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Kansas City Royals" && team[num] == "KCR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Minnesota Twins" && team[num] == "MIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Houston Astros" && team[num] == "HOU")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Angels" && team[num] == "LAA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Oakland Athletics" && team[num] == "OAK")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Seattle Mariners" && team[num] == "SEA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Texas Rangers" && team[num] == "TEX")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Atlanta Braves" && team[num] == "ATL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Miami Marlins" && team[num] == "MIA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Mets" && team[num] == "NYM")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Philidelphia Phillies" && team[num] == "PHI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Washington Nationals" && team[num] == "WSN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cincinnati Reds" && team[num] == "CIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago Cubs" && team[num] == "CHC")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Milwaukee Brewers" && team[num] == "MIL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Pittsburgh Pirates" && team[num] == "PIT")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "St. Louis Cardinals" && team[num] == "STL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Arizona Diamondbacks" && team[num] == "ARI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Colorado Rockies" && team[num] == "COL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Dodgers" && team[num] == "LAD")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Francisco Giants" && team[num] == "SFG")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Diego Padres" && team[num] == "SDP")
                                {
                                    printHitters();
                                }
                            }
                            else if (lbHitterPosition.Text == "2nd Base" && position[num] == "2B")
                            {
                                if (lbMLBTeams.Text == "All Teams")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Baltimore Orioles" && team[num] == "BAL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Boston Red Sox" && team[num] == "BOS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Yankees" && team[num] == "NYY")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Tampa Bay Rays" && team[num] == "TBR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Toronto Blue Jays" && team[num] == "TOR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago White Sox" && team[num] == "CWS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cleveland Guardians" && team[num] == "CLE")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Detroit Tigers" && team[num] == "DET")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Kansas City Royals" && team[num] == "KCR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Minnesota Twins" && team[num] == "MIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Houston Astros" && team[num] == "HOU")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Angels" && team[num] == "LAA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Oakland Athletics" && team[num] == "OAK")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Seattle Mariners" && team[num] == "SEA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Texas Rangers" && team[num] == "TEX")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Atlanta Braves" && team[num] == "ATL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Miami Marlins" && team[num] == "MIA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Mets" && team[num] == "NYM")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Philidelphia Phillies" && team[num] == "PHI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Washington Nationals" && team[num] == "WSN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cincinnati Reds" && team[num] == "CIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago Cubs" && team[num] == "CHC")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Milwaukee Brewers" && team[num] == "MIL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Pittsburgh Pirates" && team[num] == "PIT")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "St. Louis Cardinals" && team[num] == "STL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Arizona Diamondbacks" && team[num] == "ARI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Colorado Rockies" && team[num] == "COL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Dodgers" && team[num] == "LAD")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Francisco Giants" && team[num] == "SFG")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Diego Padres" && team[num] == "SDP")
                                {
                                    printHitters();
                                }
                            }
                            else if (lbHitterPosition.Text == "Short Stop" && position[num] == "SS")
                            {
                                if (lbMLBTeams.Text == "All Teams")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Baltimore Orioles" && team[num] == "BAL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Boston Red Sox" && team[num] == "BOS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Yankees" && team[num] == "NYY")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Tampa Bay Rays" && team[num] == "TBR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Toronto Blue Jays" && team[num] == "TOR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago White Sox" && team[num] == "CWS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cleveland Guardians" && team[num] == "CLE")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Detroit Tigers" && team[num] == "DET")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Kansas City Royals" && team[num] == "KCR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Minnesota Twins" && team[num] == "MIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Houston Astros" && team[num] == "HOU")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Angels" && team[num] == "LAA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Oakland Athletics" && team[num] == "OAK")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Seattle Mariners" && team[num] == "SEA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Texas Rangers" && team[num] == "TEX")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Atlanta Braves" && team[num] == "ATL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Miami Marlins" && team[num] == "MIA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Mets" && team[num] == "NYM")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Philidelphia Phillies" && team[num] == "PHI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Washington Nationals" && team[num] == "WSN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cincinnati Reds" && team[num] == "CIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago Cubs" && team[num] == "CHC")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Milwaukee Brewers" && team[num] == "MIL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Pittsburgh Pirates" && team[num] == "PIT")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "St. Louis Cardinals" && team[num] == "STL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Arizona Diamondbacks" && team[num] == "ARI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Colorado Rockies" && team[num] == "COL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Dodgers" && team[num] == "LAD")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Francisco Giants" && team[num] == "SFG")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Diego Padres" && team[num] == "SDP")
                                {
                                    printHitters();
                                }
                            }
                            else if (lbHitterPosition.Text == "3rd Base" && position[num] == "3B")
                            {
                                if (lbMLBTeams.Text == "All Teams")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Baltimore Orioles" && team[num] == "BAL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Boston Red Sox" && team[num] == "BOS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Yankees" && team[num] == "NYY")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Tampa Bay Rays" && team[num] == "TBR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Toronto Blue Jays" && team[num] == "TOR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago White Sox" && team[num] == "CWS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cleveland Guardians" && team[num] == "CLE")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Detroit Tigers" && team[num] == "DET")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Kansas City Royals" && team[num] == "KCR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Minnesota Twins" && team[num] == "MIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Houston Astros" && team[num] == "HOU")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Angels" && team[num] == "LAA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Oakland Athletics" && team[num] == "OAK")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Seattle Mariners" && team[num] == "SEA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Texas Rangers" && team[num] == "TEX")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Atlanta Braves" && team[num] == "ATL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Miami Marlins" && team[num] == "MIA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Mets" && team[num] == "NYM")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Philidelphia Phillies" && team[num] == "PHI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Washington Nationals" && team[num] == "WSN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cincinnati Reds" && team[num] == "CIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago Cubs" && team[num] == "CHC")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Milwaukee Brewers" && team[num] == "MIL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Pittsburgh Pirates" && team[num] == "PIT")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "St. Louis Cardinals" && team[num] == "STL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Arizona Diamondbacks" && team[num] == "ARI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Colorado Rockies" && team[num] == "COL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Dodgers" && team[num] == "LAD")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Francisco Giants" && team[num] == "SFG")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Diego Padres" && team[num] == "SDP")
                                {
                                    printHitters();
                                }
                            }
                            else if (lbHitterPosition.Text == "Left Field" && position[num] == "LF")
                            {
                                if (lbMLBTeams.Text == "All Teams")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Baltimore Orioles" && team[num] == "BAL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Boston Red Sox" && team[num] == "BOS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Yankees" && team[num] == "NYY")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Tampa Bay Rays" && team[num] == "TBR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Toronto Blue Jays" && team[num] == "TOR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago White Sox" && team[num] == "CWS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cleveland Guardians" && team[num] == "CLE")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Detroit Tigers" && team[num] == "DET")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Kansas City Royals" && team[num] == "KCR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Minnesota Twins" && team[num] == "MIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Houston Astros" && team[num] == "HOU")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Angels" && team[num] == "LAA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Oakland Athletics" && team[num] == "OAK")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Seattle Mariners" && team[num] == "SEA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Texas Rangers" && team[num] == "TEX")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Atlanta Braves" && team[num] == "ATL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Miami Marlins" && team[num] == "MIA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Mets" && team[num] == "NYM")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Philidelphia Phillies" && team[num] == "PHI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Washington Nationals" && team[num] == "WSN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cincinnati Reds" && team[num] == "CIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago Cubs" && team[num] == "CHC")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Milwaukee Brewers" && team[num] == "MIL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Pittsburgh Pirates" && team[num] == "PIT")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "St. Louis Cardinals" && team[num] == "STL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Arizona Diamondbacks" && team[num] == "ARI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Colorado Rockies" && team[num] == "COL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Dodgers" && team[num] == "LAD")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Francisco Giants" && team[num] == "SFG")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Diego Padres" && team[num] == "SDP")
                                {
                                    printHitters();
                                }
                            }
                            else if (lbHitterPosition.Text == "Center Field" && position[num] == "CF")
                            {
                                if (lbMLBTeams.Text == "All Teams")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Baltimore Orioles" && team[num] == "BAL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Boston Red Sox" && team[num] == "BOS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Yankees" && team[num] == "NYY")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Tampa Bay Rays" && team[num] == "TBR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Toronto Blue Jays" && team[num] == "TOR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago White Sox" && team[num] == "CWS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cleveland Guardians" && team[num] == "CLE")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Detroit Tigers" && team[num] == "DET")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Kansas City Royals" && team[num] == "KCR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Minnesota Twins" && team[num] == "MIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Houston Astros" && team[num] == "HOU")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Angels" && team[num] == "LAA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Oakland Athletics" && team[num] == "OAK")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Seattle Mariners" && team[num] == "SEA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Texas Rangers" && team[num] == "TEX")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Atlanta Braves" && team[num] == "ATL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Miami Marlins" && team[num] == "MIA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Mets" && team[num] == "NYM")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Philidelphia Phillies" && team[num] == "PHI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Washington Nationals" && team[num] == "WSN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cincinnati Reds" && team[num] == "CIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago Cubs" && team[num] == "CHC")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Milwaukee Brewers" && team[num] == "MIL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Pittsburgh Pirates" && team[num] == "PIT")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "St. Louis Cardinals" && team[num] == "STL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Arizona Diamondbacks" && team[num] == "ARI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Colorado Rockies" && team[num] == "COL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Dodgers" && team[num] == "LAD")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Francisco Giants" && team[num] == "SFG")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Diego Padres" && team[num] == "SDP")
                                {
                                    printHitters();
                                }
                            }
                            else if (lbHitterPosition.Text == "Right Field" && position[num] == "RF")
                            {
                                if (lbMLBTeams.Text == "All Teams")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Baltimore Orioles" && team[num] == "BAL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Boston Red Sox" && team[num] == "BOS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Yankees" && team[num] == "NYY")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Tampa Bay Rays" && team[num] == "TBR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Toronto Blue Jays" && team[num] == "TOR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago White Sox" && team[num] == "CWS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cleveland Guardians" && team[num] == "CLE")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Detroit Tigers" && team[num] == "DET")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Kansas City Royals" && team[num] == "KCR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Minnesota Twins" && team[num] == "MIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Houston Astros" && team[num] == "HOU")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Angels" && team[num] == "LAA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Oakland Athletics" && team[num] == "OAK")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Seattle Mariners" && team[num] == "SEA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Texas Rangers" && team[num] == "TEX")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Atlanta Braves" && team[num] == "ATL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Miami Marlins" && team[num] == "MIA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Mets" && team[num] == "NYM")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Philidelphia Phillies" && team[num] == "PHI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Washington Nationals" && team[num] == "WSN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cincinnati Reds" && team[num] == "CIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago Cubs" && team[num] == "CHC")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Milwaukee Brewers" && team[num] == "MIL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Pittsburgh Pirates" && team[num] == "PIT")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "St. Louis Cardinals" && team[num] == "STL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Arizona Diamondbacks" && team[num] == "ARI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Colorado Rockies" && team[num] == "COL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Dodgers" && team[num] == "LAD")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Francisco Giants" && team[num] == "SFG")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Diego Padres" && team[num] == "SDP")
                                {
                                    printHitters();
                                }
                            }
                            else if (lbHitterPosition.Text == "Designated Hitter" && position[num] == "DH")
                            {
                                if (lbMLBTeams.Text == "All Teams")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Baltimore Orioles" && team[num] == "BAL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Boston Red Sox" && team[num] == "BOS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Yankees" && team[num] == "NYY")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Tampa Bay Rays" && team[num] == "TBR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Toronto Blue Jays" && team[num] == "TOR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago White Sox" && team[num] == "CWS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cleveland Guardians" && team[num] == "CLE")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Detroit Tigers" && team[num] == "DET")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Kansas City Royals" && team[num] == "KCR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Minnesota Twins" && team[num] == "MIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Houston Astros" && team[num] == "HOU")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Angels" && team[num] == "LAA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Oakland Athletics" && team[num] == "OAK")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Seattle Mariners" && team[num] == "SEA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Texas Rangers" && team[num] == "TEX")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Atlanta Braves" && team[num] == "ATL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Miami Marlins" && team[num] == "MIA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Mets" && team[num] == "NYM")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Philidelphia Phillies" && team[num] == "PHI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Washington Nationals" && team[num] == "WSN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cincinnati Reds" && team[num] == "CIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago Cubs" && team[num] == "CHC")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Milwaukee Brewers" && team[num] == "MIL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Pittsburgh Pirates" && team[num] == "PIT")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "St. Louis Cardinals" && team[num] == "STL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Arizona Diamondbacks" && team[num] == "ARI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Colorado Rockies" && team[num] == "COL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Dodgers" && team[num] == "LAD")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Francisco Giants" && team[num] == "SFG")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Diego Padres" && team[num] == "SDP")
                                {
                                    printHitters();
                                }
                            }
                            else
                            {
                                if (lbMLBTeams.Text == "All Teams")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Baltimore Orioles" && team[num] == "BAL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Boston Red Sox" && team[num] == "BOS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Yankees" && team[num] == "NYY")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Tampa Bay Rays" && team[num] == "TBR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Toronto Blue Jays" && team[num] == "TOR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago White Sox" && team[num] == "CWS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cleveland Guardians" && team[num] == "CLE")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Detroit Tigers" && team[num] == "DET")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Kansas City Royals" && team[num] == "KCR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Minnesota Twins" && team[num] == "MIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Houston Astros" && team[num] == "HOU")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Angels" && team[num] == "LAA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Oakland Athletics" && team[num] == "OAK")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Seattle Mariners" && team[num] == "SEA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Texas Rangers" && team[num] == "TEX")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Atlanta Braves" && team[num] == "ATL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Miami Marlins" && team[num] == "MIA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Mets" && team[num] == "NYM")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Philidelphia Phillies" && team[num] == "PHI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Washington Nationals" && team[num] == "WSN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cincinnati Reds" && team[num] == "CIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago Cubs" && team[num] == "CHC")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Milwaukee Brewers" && team[num] == "MIL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Pittsburgh Pirates" && team[num] == "PIT")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "St. Louis Cardinals" && team[num] == "STL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Arizona Diamondbacks" && team[num] == "ARI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Colorado Rockies" && team[num] == "COL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Dodgers" && team[num] == "LAD")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Francisco Giants" && team[num] == "SFG")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Diego Padres" && team[num] == "SDP")
                                {
                                    printHitters();
                                }
                            }
                        }
                    }
                    else if (radEast.Checked && radNL.Checked)
                    {
                        if (division[num] == "E" && league[num] == "NL")
                        {
                            if (lbHitterPosition.Text == "Catcher" && position[num] == "C")
                            {
                                if (lbMLBTeams.Text == "All Teams")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Baltimore Orioles" && team[num] == "BAL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Boston Red Sox" && team[num] == "BOS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Yankees" && team[num] == "NYY")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Tampa Bay Rays" && team[num] == "TBR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Toronto Blue Jays" && team[num] == "TOR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago White Sox" && team[num] == "CWS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cleveland Guardians" && team[num] == "CLE")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Detroit Tigers" && team[num] == "DET")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Kansas City Royals" && team[num] == "KCR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Minnesota Twins" && team[num] == "MIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Houston Astros" && team[num] == "HOU")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Angels" && team[num] == "LAA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Oakland Athletics" && team[num] == "OAK")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Seattle Mariners" && team[num] == "SEA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Texas Rangers" && team[num] == "TEX")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Atlanta Braves" && team[num] == "ATL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Miami Marlins" && team[num] == "MIA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Mets" && team[num] == "NYM")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Philidelphia Phillies" && team[num] == "PHI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Washington Nationals" && team[num] == "WSN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cincinnati Reds" && team[num] == "CIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago Cubs" && team[num] == "CHC")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Milwaukee Brewers" && team[num] == "MIL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Pittsburgh Pirates" && team[num] == "PIT")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "St. Louis Cardinals" && team[num] == "STL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Arizona Diamondbacks" && team[num] == "ARI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Colorado Rockies" && team[num] == "COL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Dodgers" && team[num] == "LAD")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Francisco Giants" && team[num] == "SFG")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Diego Padres" && team[num] == "SDP")
                                {
                                    printHitters();
                                }
                            }
                            else if (lbHitterPosition.Text == "1st Base" && position[num] == "1B")
                            {
                                if (lbMLBTeams.Text == "All Teams")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Baltimore Orioles" && team[num] == "BAL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Boston Red Sox" && team[num] == "BOS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Yankees" && team[num] == "NYY")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Tampa Bay Rays" && team[num] == "TBR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Toronto Blue Jays" && team[num] == "TOR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago White Sox" && team[num] == "CWS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cleveland Guardians" && team[num] == "CLE")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Detroit Tigers" && team[num] == "DET")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Kansas City Royals" && team[num] == "KCR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Minnesota Twins" && team[num] == "MIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Houston Astros" && team[num] == "HOU")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Angels" && team[num] == "LAA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Oakland Athletics" && team[num] == "OAK")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Seattle Mariners" && team[num] == "SEA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Texas Rangers" && team[num] == "TEX")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Atlanta Braves" && team[num] == "ATL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Miami Marlins" && team[num] == "MIA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Mets" && team[num] == "NYM")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Philidelphia Phillies" && team[num] == "PHI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Washington Nationals" && team[num] == "WSN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cincinnati Reds" && team[num] == "CIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago Cubs" && team[num] == "CHC")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Milwaukee Brewers" && team[num] == "MIL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Pittsburgh Pirates" && team[num] == "PIT")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "St. Louis Cardinals" && team[num] == "STL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Arizona Diamondbacks" && team[num] == "ARI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Colorado Rockies" && team[num] == "COL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Dodgers" && team[num] == "LAD")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Francisco Giants" && team[num] == "SFG")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Diego Padres" && team[num] == "SDP")
                                {
                                    printHitters();
                                }
                            }
                            else if (lbHitterPosition.Text == "2nd Base" && position[num] == "2B")
                            {
                                if (lbMLBTeams.Text == "All Teams")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Baltimore Orioles" && team[num] == "BAL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Boston Red Sox" && team[num] == "BOS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Yankees" && team[num] == "NYY")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Tampa Bay Rays" && team[num] == "TBR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Toronto Blue Jays" && team[num] == "TOR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago White Sox" && team[num] == "CWS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cleveland Guardians" && team[num] == "CLE")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Detroit Tigers" && team[num] == "DET")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Kansas City Royals" && team[num] == "KCR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Minnesota Twins" && team[num] == "MIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Houston Astros" && team[num] == "HOU")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Angels" && team[num] == "LAA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Oakland Athletics" && team[num] == "OAK")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Seattle Mariners" && team[num] == "SEA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Texas Rangers" && team[num] == "TEX")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Atlanta Braves" && team[num] == "ATL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Miami Marlins" && team[num] == "MIA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Mets" && team[num] == "NYM")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Philidelphia Phillies" && team[num] == "PHI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Washington Nationals" && team[num] == "WSN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cincinnati Reds" && team[num] == "CIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago Cubs" && team[num] == "CHC")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Milwaukee Brewers" && team[num] == "MIL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Pittsburgh Pirates" && team[num] == "PIT")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "St. Louis Cardinals" && team[num] == "STL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Arizona Diamondbacks" && team[num] == "ARI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Colorado Rockies" && team[num] == "COL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Dodgers" && team[num] == "LAD")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Francisco Giants" && team[num] == "SFG")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Diego Padres" && team[num] == "SDP")
                                {
                                    printHitters();
                                }
                            }
                            else if (lbHitterPosition.Text == "Short Stop" && position[num] == "SS")
                            {
                                if (lbMLBTeams.Text == "All Teams")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Baltimore Orioles" && team[num] == "BAL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Boston Red Sox" && team[num] == "BOS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Yankees" && team[num] == "NYY")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Tampa Bay Rays" && team[num] == "TBR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Toronto Blue Jays" && team[num] == "TOR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago White Sox" && team[num] == "CWS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cleveland Guardians" && team[num] == "CLE")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Detroit Tigers" && team[num] == "DET")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Kansas City Royals" && team[num] == "KCR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Minnesota Twins" && team[num] == "MIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Houston Astros" && team[num] == "HOU")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Angels" && team[num] == "LAA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Oakland Athletics" && team[num] == "OAK")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Seattle Mariners" && team[num] == "SEA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Texas Rangers" && team[num] == "TEX")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Atlanta Braves" && team[num] == "ATL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Miami Marlins" && team[num] == "MIA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Mets" && team[num] == "NYM")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Philidelphia Phillies" && team[num] == "PHI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Washington Nationals" && team[num] == "WSN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cincinnati Reds" && team[num] == "CIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago Cubs" && team[num] == "CHC")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Milwaukee Brewers" && team[num] == "MIL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Pittsburgh Pirates" && team[num] == "PIT")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "St. Louis Cardinals" && team[num] == "STL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Arizona Diamondbacks" && team[num] == "ARI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Colorado Rockies" && team[num] == "COL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Dodgers" && team[num] == "LAD")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Francisco Giants" && team[num] == "SFG")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Diego Padres" && team[num] == "SDP")
                                {
                                    printHitters();
                                }
                            }
                            else if (lbHitterPosition.Text == "3rd Base" && position[num] == "3B")
                            {
                                if (lbMLBTeams.Text == "All Teams")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Baltimore Orioles" && team[num] == "BAL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Boston Red Sox" && team[num] == "BOS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Yankees" && team[num] == "NYY")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Tampa Bay Rays" && team[num] == "TBR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Toronto Blue Jays" && team[num] == "TOR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago White Sox" && team[num] == "CWS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cleveland Guardians" && team[num] == "CLE")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Detroit Tigers" && team[num] == "DET")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Kansas City Royals" && team[num] == "KCR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Minnesota Twins" && team[num] == "MIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Houston Astros" && team[num] == "HOU")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Angels" && team[num] == "LAA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Oakland Athletics" && team[num] == "OAK")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Seattle Mariners" && team[num] == "SEA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Texas Rangers" && team[num] == "TEX")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Atlanta Braves" && team[num] == "ATL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Miami Marlins" && team[num] == "MIA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Mets" && team[num] == "NYM")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Philidelphia Phillies" && team[num] == "PHI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Washington Nationals" && team[num] == "WSN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cincinnati Reds" && team[num] == "CIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago Cubs" && team[num] == "CHC")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Milwaukee Brewers" && team[num] == "MIL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Pittsburgh Pirates" && team[num] == "PIT")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "St. Louis Cardinals" && team[num] == "STL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Arizona Diamondbacks" && team[num] == "ARI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Colorado Rockies" && team[num] == "COL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Dodgers" && team[num] == "LAD")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Francisco Giants" && team[num] == "SFG")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Diego Padres" && team[num] == "SDP")
                                {
                                    printHitters();
                                }
                            }
                            else if (lbHitterPosition.Text == "Left Field" && position[num] == "LF")
                            {
                                if (lbMLBTeams.Text == "All Teams")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Baltimore Orioles" && team[num] == "BAL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Boston Red Sox" && team[num] == "BOS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Yankees" && team[num] == "NYY")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Tampa Bay Rays" && team[num] == "TBR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Toronto Blue Jays" && team[num] == "TOR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago White Sox" && team[num] == "CWS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cleveland Guardians" && team[num] == "CLE")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Detroit Tigers" && team[num] == "DET")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Kansas City Royals" && team[num] == "KCR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Minnesota Twins" && team[num] == "MIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Houston Astros" && team[num] == "HOU")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Angels" && team[num] == "LAA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Oakland Athletics" && team[num] == "OAK")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Seattle Mariners" && team[num] == "SEA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Texas Rangers" && team[num] == "TEX")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Atlanta Braves" && team[num] == "ATL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Miami Marlins" && team[num] == "MIA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Mets" && team[num] == "NYM")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Philidelphia Phillies" && team[num] == "PHI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Washington Nationals" && team[num] == "WSN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cincinnati Reds" && team[num] == "CIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago Cubs" && team[num] == "CHC")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Milwaukee Brewers" && team[num] == "MIL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Pittsburgh Pirates" && team[num] == "PIT")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "St. Louis Cardinals" && team[num] == "STL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Arizona Diamondbacks" && team[num] == "ARI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Colorado Rockies" && team[num] == "COL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Dodgers" && team[num] == "LAD")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Francisco Giants" && team[num] == "SFG")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Diego Padres" && team[num] == "SDP")
                                {
                                    printHitters();
                                }
                            }
                            else if (lbHitterPosition.Text == "Center Field" && position[num] == "CF")
                            {
                                if (lbMLBTeams.Text == "All Teams")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Baltimore Orioles" && team[num] == "BAL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Boston Red Sox" && team[num] == "BOS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Yankees" && team[num] == "NYY")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Tampa Bay Rays" && team[num] == "TBR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Toronto Blue Jays" && team[num] == "TOR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago White Sox" && team[num] == "CWS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cleveland Guardians" && team[num] == "CLE")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Detroit Tigers" && team[num] == "DET")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Kansas City Royals" && team[num] == "KCR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Minnesota Twins" && team[num] == "MIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Houston Astros" && team[num] == "HOU")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Angels" && team[num] == "LAA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Oakland Athletics" && team[num] == "OAK")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Seattle Mariners" && team[num] == "SEA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Texas Rangers" && team[num] == "TEX")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Atlanta Braves" && team[num] == "ATL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Miami Marlins" && team[num] == "MIA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Mets" && team[num] == "NYM")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Philidelphia Phillies" && team[num] == "PHI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Washington Nationals" && team[num] == "WSN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cincinnati Reds" && team[num] == "CIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago Cubs" && team[num] == "CHC")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Milwaukee Brewers" && team[num] == "MIL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Pittsburgh Pirates" && team[num] == "PIT")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "St. Louis Cardinals" && team[num] == "STL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Arizona Diamondbacks" && team[num] == "ARI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Colorado Rockies" && team[num] == "COL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Dodgers" && team[num] == "LAD")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Francisco Giants" && team[num] == "SFG")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Diego Padres" && team[num] == "SDP")
                                {
                                    printHitters();
                                }
                            }
                            else if (lbHitterPosition.Text == "Right Field" && position[num] == "RF")
                            {
                                if (lbMLBTeams.Text == "All Teams")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Baltimore Orioles" && team[num] == "BAL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Boston Red Sox" && team[num] == "BOS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Yankees" && team[num] == "NYY")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Tampa Bay Rays" && team[num] == "TBR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Toronto Blue Jays" && team[num] == "TOR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago White Sox" && team[num] == "CWS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cleveland Guardians" && team[num] == "CLE")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Detroit Tigers" && team[num] == "DET")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Kansas City Royals" && team[num] == "KCR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Minnesota Twins" && team[num] == "MIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Houston Astros" && team[num] == "HOU")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Angels" && team[num] == "LAA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Oakland Athletics" && team[num] == "OAK")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Seattle Mariners" && team[num] == "SEA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Texas Rangers" && team[num] == "TEX")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Atlanta Braves" && team[num] == "ATL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Miami Marlins" && team[num] == "MIA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Mets" && team[num] == "NYM")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Philidelphia Phillies" && team[num] == "PHI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Washington Nationals" && team[num] == "WSN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cincinnati Reds" && team[num] == "CIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago Cubs" && team[num] == "CHC")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Milwaukee Brewers" && team[num] == "MIL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Pittsburgh Pirates" && team[num] == "PIT")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "St. Louis Cardinals" && team[num] == "STL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Arizona Diamondbacks" && team[num] == "ARI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Colorado Rockies" && team[num] == "COL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Dodgers" && team[num] == "LAD")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Francisco Giants" && team[num] == "SFG")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Diego Padres" && team[num] == "SDP")
                                {
                                    printHitters();
                                }
                            }
                            else if (lbHitterPosition.Text == "Designated Hitter" && position[num] == "DH")
                            {
                                if (lbMLBTeams.Text == "All Teams")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Baltimore Orioles" && team[num] == "BAL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Boston Red Sox" && team[num] == "BOS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Yankees" && team[num] == "NYY")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Tampa Bay Rays" && team[num] == "TBR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Toronto Blue Jays" && team[num] == "TOR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago White Sox" && team[num] == "CWS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cleveland Guardians" && team[num] == "CLE")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Detroit Tigers" && team[num] == "DET")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Kansas City Royals" && team[num] == "KCR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Minnesota Twins" && team[num] == "MIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Houston Astros" && team[num] == "HOU")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Angels" && team[num] == "LAA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Oakland Athletics" && team[num] == "OAK")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Seattle Mariners" && team[num] == "SEA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Texas Rangers" && team[num] == "TEX")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Atlanta Braves" && team[num] == "ATL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Miami Marlins" && team[num] == "MIA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Mets" && team[num] == "NYM")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Philidelphia Phillies" && team[num] == "PHI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Washington Nationals" && team[num] == "WSN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cincinnati Reds" && team[num] == "CIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago Cubs" && team[num] == "CHC")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Milwaukee Brewers" && team[num] == "MIL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Pittsburgh Pirates" && team[num] == "PIT")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "St. Louis Cardinals" && team[num] == "STL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Arizona Diamondbacks" && team[num] == "ARI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Colorado Rockies" && team[num] == "COL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Dodgers" && team[num] == "LAD")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Francisco Giants" && team[num] == "SFG")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Diego Padres" && team[num] == "SDP")
                                {
                                    printHitters();
                                }
                            }
                            else
                            {
                                if (lbMLBTeams.Text == "All Teams")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Baltimore Orioles" && team[num] == "BAL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Boston Red Sox" && team[num] == "BOS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Yankees" && team[num] == "NYY")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Tampa Bay Rays" && team[num] == "TBR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Toronto Blue Jays" && team[num] == "TOR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago White Sox" && team[num] == "CWS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cleveland Guardians" && team[num] == "CLE")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Detroit Tigers" && team[num] == "DET")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Kansas City Royals" && team[num] == "KCR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Minnesota Twins" && team[num] == "MIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Houston Astros" && team[num] == "HOU")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Angels" && team[num] == "LAA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Oakland Athletics" && team[num] == "OAK")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Seattle Mariners" && team[num] == "SEA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Texas Rangers" && team[num] == "TEX")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Atlanta Braves" && team[num] == "ATL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Miami Marlins" && team[num] == "MIA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Mets" && team[num] == "NYM")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Philidelphia Phillies" && team[num] == "PHI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Washington Nationals" && team[num] == "WSN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cincinnati Reds" && team[num] == "CIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago Cubs" && team[num] == "CHC")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Milwaukee Brewers" && team[num] == "MIL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Pittsburgh Pirates" && team[num] == "PIT")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "St. Louis Cardinals" && team[num] == "STL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Arizona Diamondbacks" && team[num] == "ARI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Colorado Rockies" && team[num] == "COL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Dodgers" && team[num] == "LAD")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Francisco Giants" && team[num] == "SFG")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Diego Padres" && team[num] == "SDP")
                                {
                                    printHitters();
                                }
                            }
                        }
                    }
                    else if (radWest.Checked && radNL.Checked)
                    {
                        if (division[num] == "W" && league[num] == "NL")
                        {
                            if (lbHitterPosition.Text == "Catcher" && position[num] == "C")
                            {
                                if (lbMLBTeams.Text == "All Teams")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Baltimore Orioles" && team[num] == "BAL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Boston Red Sox" && team[num] == "BOS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Yankees" && team[num] == "NYY")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Tampa Bay Rays" && team[num] == "TBR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Toronto Blue Jays" && team[num] == "TOR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago White Sox" && team[num] == "CWS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cleveland Guardians" && team[num] == "CLE")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Detroit Tigers" && team[num] == "DET")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Kansas City Royals" && team[num] == "KCR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Minnesota Twins" && team[num] == "MIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Houston Astros" && team[num] == "HOU")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Angels" && team[num] == "LAA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Oakland Athletics" && team[num] == "OAK")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Seattle Mariners" && team[num] == "SEA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Texas Rangers" && team[num] == "TEX")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Atlanta Braves" && team[num] == "ATL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Miami Marlins" && team[num] == "MIA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Mets" && team[num] == "NYM")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Philidelphia Phillies" && team[num] == "PHI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Washington Nationals" && team[num] == "WSN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cincinnati Reds" && team[num] == "CIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago Cubs" && team[num] == "CHC")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Milwaukee Brewers" && team[num] == "MIL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Pittsburgh Pirates" && team[num] == "PIT")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "St. Louis Cardinals" && team[num] == "STL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Arizona Diamondbacks" && team[num] == "ARI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Colorado Rockies" && team[num] == "COL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Dodgers" && team[num] == "LAD")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Francisco Giants" && team[num] == "SFG")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Diego Padres" && team[num] == "SDP")
                                {
                                    printHitters();
                                }
                            }
                            else if (lbHitterPosition.Text == "1st Base" && position[num] == "1B")
                            {
                                if (lbMLBTeams.Text == "All Teams")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Baltimore Orioles" && team[num] == "BAL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Boston Red Sox" && team[num] == "BOS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Yankees" && team[num] == "NYY")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Tampa Bay Rays" && team[num] == "TBR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Toronto Blue Jays" && team[num] == "TOR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago White Sox" && team[num] == "CWS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cleveland Guardians" && team[num] == "CLE")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Detroit Tigers" && team[num] == "DET")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Kansas City Royals" && team[num] == "KCR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Minnesota Twins" && team[num] == "MIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Houston Astros" && team[num] == "HOU")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Angels" && team[num] == "LAA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Oakland Athletics" && team[num] == "OAK")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Seattle Mariners" && team[num] == "SEA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Texas Rangers" && team[num] == "TEX")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Atlanta Braves" && team[num] == "ATL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Miami Marlins" && team[num] == "MIA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Mets" && team[num] == "NYM")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Philidelphia Phillies" && team[num] == "PHI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Washington Nationals" && team[num] == "WSN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cincinnati Reds" && team[num] == "CIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago Cubs" && team[num] == "CHC")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Milwaukee Brewers" && team[num] == "MIL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Pittsburgh Pirates" && team[num] == "PIT")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "St. Louis Cardinals" && team[num] == "STL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Arizona Diamondbacks" && team[num] == "ARI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Colorado Rockies" && team[num] == "COL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Dodgers" && team[num] == "LAD")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Francisco Giants" && team[num] == "SFG")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Diego Padres" && team[num] == "SDP")
                                {
                                    printHitters();
                                }
                            }
                            else if (lbHitterPosition.Text == "2nd Base" && position[num] == "2B")
                            {
                                if (lbMLBTeams.Text == "All Teams")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Baltimore Orioles" && team[num] == "BAL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Boston Red Sox" && team[num] == "BOS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Yankees" && team[num] == "NYY")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Tampa Bay Rays" && team[num] == "TBR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Toronto Blue Jays" && team[num] == "TOR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago White Sox" && team[num] == "CWS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cleveland Guardians" && team[num] == "CLE")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Detroit Tigers" && team[num] == "DET")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Kansas City Royals" && team[num] == "KCR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Minnesota Twins" && team[num] == "MIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Houston Astros" && team[num] == "HOU")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Angels" && team[num] == "LAA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Oakland Athletics" && team[num] == "OAK")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Seattle Mariners" && team[num] == "SEA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Texas Rangers" && team[num] == "TEX")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Atlanta Braves" && team[num] == "ATL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Miami Marlins" && team[num] == "MIA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Mets" && team[num] == "NYM")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Philidelphia Phillies" && team[num] == "PHI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Washington Nationals" && team[num] == "WSN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cincinnati Reds" && team[num] == "CIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago Cubs" && team[num] == "CHC")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Milwaukee Brewers" && team[num] == "MIL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Pittsburgh Pirates" && team[num] == "PIT")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "St. Louis Cardinals" && team[num] == "STL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Arizona Diamondbacks" && team[num] == "ARI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Colorado Rockies" && team[num] == "COL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Dodgers" && team[num] == "LAD")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Francisco Giants" && team[num] == "SFG")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Diego Padres" && team[num] == "SDP")
                                {
                                    printHitters();
                                }
                            }
                            else if (lbHitterPosition.Text == "Short Stop" && position[num] == "SS")
                            {
                                if (lbMLBTeams.Text == "All Teams")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Baltimore Orioles" && team[num] == "BAL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Boston Red Sox" && team[num] == "BOS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Yankees" && team[num] == "NYY")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Tampa Bay Rays" && team[num] == "TBR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Toronto Blue Jays" && team[num] == "TOR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago White Sox" && team[num] == "CWS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cleveland Guardians" && team[num] == "CLE")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Detroit Tigers" && team[num] == "DET")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Kansas City Royals" && team[num] == "KCR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Minnesota Twins" && team[num] == "MIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Houston Astros" && team[num] == "HOU")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Angels" && team[num] == "LAA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Oakland Athletics" && team[num] == "OAK")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Seattle Mariners" && team[num] == "SEA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Texas Rangers" && team[num] == "TEX")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Atlanta Braves" && team[num] == "ATL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Miami Marlins" && team[num] == "MIA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Mets" && team[num] == "NYM")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Philidelphia Phillies" && team[num] == "PHI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Washington Nationals" && team[num] == "WSN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cincinnati Reds" && team[num] == "CIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago Cubs" && team[num] == "CHC")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Milwaukee Brewers" && team[num] == "MIL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Pittsburgh Pirates" && team[num] == "PIT")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "St. Louis Cardinals" && team[num] == "STL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Arizona Diamondbacks" && team[num] == "ARI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Colorado Rockies" && team[num] == "COL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Dodgers" && team[num] == "LAD")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Francisco Giants" && team[num] == "SFG")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Diego Padres" && team[num] == "SDP")
                                {
                                    printHitters();
                                }
                            }
                            else if (lbHitterPosition.Text == "3rd Base" && position[num] == "3B")
                            {
                                if (lbMLBTeams.Text == "All Teams")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Baltimore Orioles" && team[num] == "BAL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Boston Red Sox" && team[num] == "BOS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Yankees" && team[num] == "NYY")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Tampa Bay Rays" && team[num] == "TBR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Toronto Blue Jays" && team[num] == "TOR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago White Sox" && team[num] == "CWS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cleveland Guardians" && team[num] == "CLE")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Detroit Tigers" && team[num] == "DET")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Kansas City Royals" && team[num] == "KCR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Minnesota Twins" && team[num] == "MIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Houston Astros" && team[num] == "HOU")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Angels" && team[num] == "LAA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Oakland Athletics" && team[num] == "OAK")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Seattle Mariners" && team[num] == "SEA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Texas Rangers" && team[num] == "TEX")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Atlanta Braves" && team[num] == "ATL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Miami Marlins" && team[num] == "MIA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Mets" && team[num] == "NYM")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Philidelphia Phillies" && team[num] == "PHI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Washington Nationals" && team[num] == "WSN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cincinnati Reds" && team[num] == "CIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago Cubs" && team[num] == "CHC")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Milwaukee Brewers" && team[num] == "MIL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Pittsburgh Pirates" && team[num] == "PIT")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "St. Louis Cardinals" && team[num] == "STL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Arizona Diamondbacks" && team[num] == "ARI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Colorado Rockies" && team[num] == "COL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Dodgers" && team[num] == "LAD")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Francisco Giants" && team[num] == "SFG")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Diego Padres" && team[num] == "SDP")
                                {
                                    printHitters();
                                }
                            }
                            else if (lbHitterPosition.Text == "Left Field" && position[num] == "LF")
                            {
                                if (lbMLBTeams.Text == "All Teams")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Baltimore Orioles" && team[num] == "BAL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Boston Red Sox" && team[num] == "BOS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Yankees" && team[num] == "NYY")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Tampa Bay Rays" && team[num] == "TBR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Toronto Blue Jays" && team[num] == "TOR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago White Sox" && team[num] == "CWS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cleveland Guardians" && team[num] == "CLE")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Detroit Tigers" && team[num] == "DET")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Kansas City Royals" && team[num] == "KCR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Minnesota Twins" && team[num] == "MIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Houston Astros" && team[num] == "HOU")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Angels" && team[num] == "LAA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Oakland Athletics" && team[num] == "OAK")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Seattle Mariners" && team[num] == "SEA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Texas Rangers" && team[num] == "TEX")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Atlanta Braves" && team[num] == "ATL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Miami Marlins" && team[num] == "MIA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Mets" && team[num] == "NYM")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Philidelphia Phillies" && team[num] == "PHI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Washington Nationals" && team[num] == "WSN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cincinnati Reds" && team[num] == "CIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago Cubs" && team[num] == "CHC")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Milwaukee Brewers" && team[num] == "MIL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Pittsburgh Pirates" && team[num] == "PIT")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "St. Louis Cardinals" && team[num] == "STL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Arizona Diamondbacks" && team[num] == "ARI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Colorado Rockies" && team[num] == "COL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Dodgers" && team[num] == "LAD")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Francisco Giants" && team[num] == "SFG")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Diego Padres" && team[num] == "SDP")
                                {
                                    printHitters();
                                }
                            }
                            else if (lbHitterPosition.Text == "Center Field" && position[num] == "CF")
                            {
                                if (lbMLBTeams.Text == "All Teams")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Baltimore Orioles" && team[num] == "BAL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Boston Red Sox" && team[num] == "BOS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Yankees" && team[num] == "NYY")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Tampa Bay Rays" && team[num] == "TBR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Toronto Blue Jays" && team[num] == "TOR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago White Sox" && team[num] == "CWS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cleveland Guardians" && team[num] == "CLE")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Detroit Tigers" && team[num] == "DET")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Kansas City Royals" && team[num] == "KCR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Minnesota Twins" && team[num] == "MIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Houston Astros" && team[num] == "HOU")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Angels" && team[num] == "LAA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Oakland Athletics" && team[num] == "OAK")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Seattle Mariners" && team[num] == "SEA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Texas Rangers" && team[num] == "TEX")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Atlanta Braves" && team[num] == "ATL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Miami Marlins" && team[num] == "MIA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Mets" && team[num] == "NYM")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Philidelphia Phillies" && team[num] == "PHI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Washington Nationals" && team[num] == "WSN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cincinnati Reds" && team[num] == "CIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago Cubs" && team[num] == "CHC")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Milwaukee Brewers" && team[num] == "MIL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Pittsburgh Pirates" && team[num] == "PIT")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "St. Louis Cardinals" && team[num] == "STL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Arizona Diamondbacks" && team[num] == "ARI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Colorado Rockies" && team[num] == "COL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Dodgers" && team[num] == "LAD")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Francisco Giants" && team[num] == "SFG")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Diego Padres" && team[num] == "SDP")
                                {
                                    printHitters();
                                }
                            }
                            else if (lbHitterPosition.Text == "Right Field" && position[num] == "RF")
                            {
                                if (lbMLBTeams.Text == "All Teams")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Baltimore Orioles" && team[num] == "BAL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Boston Red Sox" && team[num] == "BOS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Yankees" && team[num] == "NYY")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Tampa Bay Rays" && team[num] == "TBR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Toronto Blue Jays" && team[num] == "TOR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago White Sox" && team[num] == "CWS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cleveland Guardians" && team[num] == "CLE")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Detroit Tigers" && team[num] == "DET")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Kansas City Royals" && team[num] == "KCR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Minnesota Twins" && team[num] == "MIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Houston Astros" && team[num] == "HOU")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Angels" && team[num] == "LAA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Oakland Athletics" && team[num] == "OAK")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Seattle Mariners" && team[num] == "SEA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Texas Rangers" && team[num] == "TEX")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Atlanta Braves" && team[num] == "ATL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Miami Marlins" && team[num] == "MIA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Mets" && team[num] == "NYM")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Philidelphia Phillies" && team[num] == "PHI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Washington Nationals" && team[num] == "WSN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cincinnati Reds" && team[num] == "CIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago Cubs" && team[num] == "CHC")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Milwaukee Brewers" && team[num] == "MIL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Pittsburgh Pirates" && team[num] == "PIT")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "St. Louis Cardinals" && team[num] == "STL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Arizona Diamondbacks" && team[num] == "ARI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Colorado Rockies" && team[num] == "COL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Dodgers" && team[num] == "LAD")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Francisco Giants" && team[num] == "SFG")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Diego Padres" && team[num] == "SDP")
                                {
                                    printHitters();
                                }
                            }
                            else if (lbHitterPosition.Text == "Designated Hitter" && position[num] == "DH")
                            {
                                if (lbMLBTeams.Text == "All Teams")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Baltimore Orioles" && team[num] == "BAL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Boston Red Sox" && team[num] == "BOS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Yankees" && team[num] == "NYY")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Tampa Bay Rays" && team[num] == "TBR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Toronto Blue Jays" && team[num] == "TOR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago White Sox" && team[num] == "CWS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cleveland Guardians" && team[num] == "CLE")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Detroit Tigers" && team[num] == "DET")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Kansas City Royals" && team[num] == "KCR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Minnesota Twins" && team[num] == "MIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Houston Astros" && team[num] == "HOU")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Angels" && team[num] == "LAA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Oakland Athletics" && team[num] == "OAK")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Seattle Mariners" && team[num] == "SEA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Texas Rangers" && team[num] == "TEX")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Atlanta Braves" && team[num] == "ATL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Miami Marlins" && team[num] == "MIA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Mets" && team[num] == "NYM")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Philidelphia Phillies" && team[num] == "PHI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Washington Nationals" && team[num] == "WSN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cincinnati Reds" && team[num] == "CIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago Cubs" && team[num] == "CHC")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Milwaukee Brewers" && team[num] == "MIL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Pittsburgh Pirates" && team[num] == "PIT")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "St. Louis Cardinals" && team[num] == "STL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Arizona Diamondbacks" && team[num] == "ARI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Colorado Rockies" && team[num] == "COL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Dodgers" && team[num] == "LAD")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Francisco Giants" && team[num] == "SFG")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Diego Padres" && team[num] == "SDP")
                                {
                                    printHitters();
                                }
                            }
                            else
                            {
                                if (lbMLBTeams.Text == "All Teams")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Baltimore Orioles" && team[num] == "BAL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Boston Red Sox" && team[num] == "BOS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Yankees" && team[num] == "NYY")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Tampa Bay Rays" && team[num] == "TBR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Toronto Blue Jays" && team[num] == "TOR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago White Sox" && team[num] == "CWS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cleveland Guardians" && team[num] == "CLE")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Detroit Tigers" && team[num] == "DET")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Kansas City Royals" && team[num] == "KCR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Minnesota Twins" && team[num] == "MIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Houston Astros" && team[num] == "HOU")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Angels" && team[num] == "LAA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Oakland Athletics" && team[num] == "OAK")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Seattle Mariners" && team[num] == "SEA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Texas Rangers" && team[num] == "TEX")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Atlanta Braves" && team[num] == "ATL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Miami Marlins" && team[num] == "MIA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Mets" && team[num] == "NYM")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Philidelphia Phillies" && team[num] == "PHI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Washington Nationals" && team[num] == "WSN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cincinnati Reds" && team[num] == "CIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago Cubs" && team[num] == "CHC")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Milwaukee Brewers" && team[num] == "MIL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Pittsburgh Pirates" && team[num] == "PIT")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "St. Louis Cardinals" && team[num] == "STL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Arizona Diamondbacks" && team[num] == "ARI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Colorado Rockies" && team[num] == "COL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Dodgers" && team[num] == "LAD")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Francisco Giants" && team[num] == "SFG")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Diego Padres" && team[num] == "SDP")
                                {
                                    printHitters();
                                }
                            }
                        }
                    }
                    else if (radCentral.Checked && radNL.Checked)
                    {
                        if (division[num] == "C" && league[num] == "NL")
                        {
                            if (lbHitterPosition.Text == "Catcher" && position[num] == "C")
                            {
                                if (lbMLBTeams.Text == "All Teams")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Baltimore Orioles" && team[num] == "BAL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Boston Red Sox" && team[num] == "BOS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Yankees" && team[num] == "NYY")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Tampa Bay Rays" && team[num] == "TBR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Toronto Blue Jays" && team[num] == "TOR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago White Sox" && team[num] == "CWS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cleveland Guardians" && team[num] == "CLE")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Detroit Tigers" && team[num] == "DET")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Kansas City Royals" && team[num] == "KCR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Minnesota Twins" && team[num] == "MIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Houston Astros" && team[num] == "HOU")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Angels" && team[num] == "LAA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Oakland Athletics" && team[num] == "OAK")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Seattle Mariners" && team[num] == "SEA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Texas Rangers" && team[num] == "TEX")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Atlanta Braves" && team[num] == "ATL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Miami Marlins" && team[num] == "MIA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Mets" && team[num] == "NYM")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Philidelphia Phillies" && team[num] == "PHI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Washington Nationals" && team[num] == "WSN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cincinnati Reds" && team[num] == "CIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago Cubs" && team[num] == "CHC")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Milwaukee Brewers" && team[num] == "MIL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Pittsburgh Pirates" && team[num] == "PIT")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "St. Louis Cardinals" && team[num] == "STL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Arizona Diamondbacks" && team[num] == "ARI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Colorado Rockies" && team[num] == "COL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Dodgers" && team[num] == "LAD")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Francisco Giants" && team[num] == "SFG")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Diego Padres" && team[num] == "SDP")
                                {
                                    printHitters();
                                }
                            }
                            else if (lbHitterPosition.Text == "1st Base" && position[num] == "1B")
                            {
                                if (lbMLBTeams.Text == "All Teams")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Baltimore Orioles" && team[num] == "BAL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Boston Red Sox" && team[num] == "BOS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Yankees" && team[num] == "NYY")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Tampa Bay Rays" && team[num] == "TBR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Toronto Blue Jays" && team[num] == "TOR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago White Sox" && team[num] == "CWS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cleveland Guardians" && team[num] == "CLE")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Detroit Tigers" && team[num] == "DET")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Kansas City Royals" && team[num] == "KCR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Minnesota Twins" && team[num] == "MIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Houston Astros" && team[num] == "HOU")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Angels" && team[num] == "LAA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Oakland Athletics" && team[num] == "OAK")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Seattle Mariners" && team[num] == "SEA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Texas Rangers" && team[num] == "TEX")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Atlanta Braves" && team[num] == "ATL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Miami Marlins" && team[num] == "MIA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Mets" && team[num] == "NYM")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Philidelphia Phillies" && team[num] == "PHI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Washington Nationals" && team[num] == "WSN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cincinnati Reds" && team[num] == "CIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago Cubs" && team[num] == "CHC")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Milwaukee Brewers" && team[num] == "MIL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Pittsburgh Pirates" && team[num] == "PIT")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "St. Louis Cardinals" && team[num] == "STL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Arizona Diamondbacks" && team[num] == "ARI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Colorado Rockies" && team[num] == "COL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Dodgers" && team[num] == "LAD")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Francisco Giants" && team[num] == "SFG")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Diego Padres" && team[num] == "SDP")
                                {
                                    printHitters();
                                }
                            }
                            else if (lbHitterPosition.Text == "2nd Base" && position[num] == "2B")
                            {
                                if (lbMLBTeams.Text == "All Teams")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Baltimore Orioles" && team[num] == "BAL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Boston Red Sox" && team[num] == "BOS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Yankees" && team[num] == "NYY")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Tampa Bay Rays" && team[num] == "TBR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Toronto Blue Jays" && team[num] == "TOR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago White Sox" && team[num] == "CWS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cleveland Guardians" && team[num] == "CLE")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Detroit Tigers" && team[num] == "DET")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Kansas City Royals" && team[num] == "KCR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Minnesota Twins" && team[num] == "MIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Houston Astros" && team[num] == "HOU")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Angels" && team[num] == "LAA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Oakland Athletics" && team[num] == "OAK")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Seattle Mariners" && team[num] == "SEA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Texas Rangers" && team[num] == "TEX")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Atlanta Braves" && team[num] == "ATL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Miami Marlins" && team[num] == "MIA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Mets" && team[num] == "NYM")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Philidelphia Phillies" && team[num] == "PHI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Washington Nationals" && team[num] == "WSN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cincinnati Reds" && team[num] == "CIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago Cubs" && team[num] == "CHC")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Milwaukee Brewers" && team[num] == "MIL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Pittsburgh Pirates" && team[num] == "PIT")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "St. Louis Cardinals" && team[num] == "STL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Arizona Diamondbacks" && team[num] == "ARI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Colorado Rockies" && team[num] == "COL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Dodgers" && team[num] == "LAD")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Francisco Giants" && team[num] == "SFG")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Diego Padres" && team[num] == "SDP")
                                {
                                    printHitters();
                                }
                            }
                            else if (lbHitterPosition.Text == "Short Stop" && position[num] == "SS")
                            {
                                if (lbMLBTeams.Text == "All Teams")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Baltimore Orioles" && team[num] == "BAL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Boston Red Sox" && team[num] == "BOS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Yankees" && team[num] == "NYY")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Tampa Bay Rays" && team[num] == "TBR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Toronto Blue Jays" && team[num] == "TOR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago White Sox" && team[num] == "CWS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cleveland Guardians" && team[num] == "CLE")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Detroit Tigers" && team[num] == "DET")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Kansas City Royals" && team[num] == "KCR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Minnesota Twins" && team[num] == "MIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Houston Astros" && team[num] == "HOU")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Angels" && team[num] == "LAA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Oakland Athletics" && team[num] == "OAK")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Seattle Mariners" && team[num] == "SEA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Texas Rangers" && team[num] == "TEX")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Atlanta Braves" && team[num] == "ATL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Miami Marlins" && team[num] == "MIA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Mets" && team[num] == "NYM")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Philidelphia Phillies" && team[num] == "PHI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Washington Nationals" && team[num] == "WSN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cincinnati Reds" && team[num] == "CIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago Cubs" && team[num] == "CHC")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Milwaukee Brewers" && team[num] == "MIL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Pittsburgh Pirates" && team[num] == "PIT")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "St. Louis Cardinals" && team[num] == "STL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Arizona Diamondbacks" && team[num] == "ARI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Colorado Rockies" && team[num] == "COL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Dodgers" && team[num] == "LAD")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Francisco Giants" && team[num] == "SFG")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Diego Padres" && team[num] == "SDP")
                                {
                                    printHitters();
                                }
                            }
                            else if (lbHitterPosition.Text == "3rd Base" && position[num] == "3B")
                            {
                                if (lbMLBTeams.Text == "All Teams")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Baltimore Orioles" && team[num] == "BAL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Boston Red Sox" && team[num] == "BOS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Yankees" && team[num] == "NYY")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Tampa Bay Rays" && team[num] == "TBR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Toronto Blue Jays" && team[num] == "TOR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago White Sox" && team[num] == "CWS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cleveland Guardians" && team[num] == "CLE")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Detroit Tigers" && team[num] == "DET")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Kansas City Royals" && team[num] == "KCR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Minnesota Twins" && team[num] == "MIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Houston Astros" && team[num] == "HOU")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Angels" && team[num] == "LAA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Oakland Athletics" && team[num] == "OAK")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Seattle Mariners" && team[num] == "SEA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Texas Rangers" && team[num] == "TEX")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Atlanta Braves" && team[num] == "ATL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Miami Marlins" && team[num] == "MIA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Mets" && team[num] == "NYM")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Philidelphia Phillies" && team[num] == "PHI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Washington Nationals" && team[num] == "WSN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cincinnati Reds" && team[num] == "CIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago Cubs" && team[num] == "CHC")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Milwaukee Brewers" && team[num] == "MIL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Pittsburgh Pirates" && team[num] == "PIT")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "St. Louis Cardinals" && team[num] == "STL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Arizona Diamondbacks" && team[num] == "ARI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Colorado Rockies" && team[num] == "COL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Dodgers" && team[num] == "LAD")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Francisco Giants" && team[num] == "SFG")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Diego Padres" && team[num] == "SDP")
                                {
                                    printHitters();
                                }
                            }
                            else if (lbHitterPosition.Text == "Left Field" && position[num] == "LF")
                            {
                                if (lbMLBTeams.Text == "All Teams")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Baltimore Orioles" && team[num] == "BAL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Boston Red Sox" && team[num] == "BOS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Yankees" && team[num] == "NYY")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Tampa Bay Rays" && team[num] == "TBR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Toronto Blue Jays" && team[num] == "TOR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago White Sox" && team[num] == "CWS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cleveland Guardians" && team[num] == "CLE")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Detroit Tigers" && team[num] == "DET")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Kansas City Royals" && team[num] == "KCR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Minnesota Twins" && team[num] == "MIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Houston Astros" && team[num] == "HOU")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Angels" && team[num] == "LAA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Oakland Athletics" && team[num] == "OAK")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Seattle Mariners" && team[num] == "SEA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Texas Rangers" && team[num] == "TEX")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Atlanta Braves" && team[num] == "ATL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Miami Marlins" && team[num] == "MIA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Mets" && team[num] == "NYM")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Philidelphia Phillies" && team[num] == "PHI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Washington Nationals" && team[num] == "WSN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cincinnati Reds" && team[num] == "CIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago Cubs" && team[num] == "CHC")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Milwaukee Brewers" && team[num] == "MIL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Pittsburgh Pirates" && team[num] == "PIT")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "St. Louis Cardinals" && team[num] == "STL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Arizona Diamondbacks" && team[num] == "ARI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Colorado Rockies" && team[num] == "COL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Dodgers" && team[num] == "LAD")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Francisco Giants" && team[num] == "SFG")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Diego Padres" && team[num] == "SDP")
                                {
                                    printHitters();
                                }
                            }
                            else if (lbHitterPosition.Text == "Center Field" && position[num] == "CF")
                            {
                                if (lbMLBTeams.Text == "All Teams")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Baltimore Orioles" && team[num] == "BAL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Boston Red Sox" && team[num] == "BOS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Yankees" && team[num] == "NYY")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Tampa Bay Rays" && team[num] == "TBR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Toronto Blue Jays" && team[num] == "TOR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago White Sox" && team[num] == "CWS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cleveland Guardians" && team[num] == "CLE")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Detroit Tigers" && team[num] == "DET")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Kansas City Royals" && team[num] == "KCR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Minnesota Twins" && team[num] == "MIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Houston Astros" && team[num] == "HOU")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Angels" && team[num] == "LAA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Oakland Athletics" && team[num] == "OAK")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Seattle Mariners" && team[num] == "SEA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Texas Rangers" && team[num] == "TEX")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Atlanta Braves" && team[num] == "ATL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Miami Marlins" && team[num] == "MIA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Mets" && team[num] == "NYM")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Philidelphia Phillies" && team[num] == "PHI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Washington Nationals" && team[num] == "WSN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cincinnati Reds" && team[num] == "CIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago Cubs" && team[num] == "CHC")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Milwaukee Brewers" && team[num] == "MIL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Pittsburgh Pirates" && team[num] == "PIT")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "St. Louis Cardinals" && team[num] == "STL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Arizona Diamondbacks" && team[num] == "ARI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Colorado Rockies" && team[num] == "COL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Dodgers" && team[num] == "LAD")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Francisco Giants" && team[num] == "SFG")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Diego Padres" && team[num] == "SDP")
                                {
                                    printHitters();
                                }
                            }
                            else if (lbHitterPosition.Text == "Right Field" && position[num] == "RF")
                            {
                                if (lbMLBTeams.Text == "All Teams")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Baltimore Orioles" && team[num] == "BAL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Boston Red Sox" && team[num] == "BOS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Yankees" && team[num] == "NYY")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Tampa Bay Rays" && team[num] == "TBR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Toronto Blue Jays" && team[num] == "TOR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago White Sox" && team[num] == "CWS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cleveland Guardians" && team[num] == "CLE")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Detroit Tigers" && team[num] == "DET")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Kansas City Royals" && team[num] == "KCR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Minnesota Twins" && team[num] == "MIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Houston Astros" && team[num] == "HOU")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Angels" && team[num] == "LAA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Oakland Athletics" && team[num] == "OAK")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Seattle Mariners" && team[num] == "SEA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Texas Rangers" && team[num] == "TEX")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Atlanta Braves" && team[num] == "ATL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Miami Marlins" && team[num] == "MIA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Mets" && team[num] == "NYM")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Philidelphia Phillies" && team[num] == "PHI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Washington Nationals" && team[num] == "WSN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cincinnati Reds" && team[num] == "CIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago Cubs" && team[num] == "CHC")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Milwaukee Brewers" && team[num] == "MIL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Pittsburgh Pirates" && team[num] == "PIT")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "St. Louis Cardinals" && team[num] == "STL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Arizona Diamondbacks" && team[num] == "ARI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Colorado Rockies" && team[num] == "COL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Dodgers" && team[num] == "LAD")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Francisco Giants" && team[num] == "SFG")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Diego Padres" && team[num] == "SDP")
                                {
                                    printHitters();
                                }
                            }
                            else if (lbHitterPosition.Text == "Designated Hitter" && position[num] == "DH")
                            {
                                if (lbMLBTeams.Text == "All Teams")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Baltimore Orioles" && team[num] == "BAL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Boston Red Sox" && team[num] == "BOS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Yankees" && team[num] == "NYY")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Tampa Bay Rays" && team[num] == "TBR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Toronto Blue Jays" && team[num] == "TOR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago White Sox" && team[num] == "CWS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cleveland Guardians" && team[num] == "CLE")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Detroit Tigers" && team[num] == "DET")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Kansas City Royals" && team[num] == "KCR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Minnesota Twins" && team[num] == "MIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Houston Astros" && team[num] == "HOU")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Angels" && team[num] == "LAA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Oakland Athletics" && team[num] == "OAK")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Seattle Mariners" && team[num] == "SEA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Texas Rangers" && team[num] == "TEX")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Atlanta Braves" && team[num] == "ATL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Miami Marlins" && team[num] == "MIA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Mets" && team[num] == "NYM")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Philidelphia Phillies" && team[num] == "PHI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Washington Nationals" && team[num] == "WSN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cincinnati Reds" && team[num] == "CIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago Cubs" && team[num] == "CHC")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Milwaukee Brewers" && team[num] == "MIL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Pittsburgh Pirates" && team[num] == "PIT")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "St. Louis Cardinals" && team[num] == "STL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Arizona Diamondbacks" && team[num] == "ARI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Colorado Rockies" && team[num] == "COL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Dodgers" && team[num] == "LAD")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Francisco Giants" && team[num] == "SFG")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Diego Padres" && team[num] == "SDP")
                                {
                                    printHitters();
                                }
                            }
                            else
                            {
                                if (lbMLBTeams.Text == "All Teams")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Baltimore Orioles" && team[num] == "BAL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Boston Red Sox" && team[num] == "BOS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Yankees" && team[num] == "NYY")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Tampa Bay Rays" && team[num] == "TBR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Toronto Blue Jays" && team[num] == "TOR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago White Sox" && team[num] == "CWS")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cleveland Guardians" && team[num] == "CLE")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Detroit Tigers" && team[num] == "DET")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Kansas City Royals" && team[num] == "KCR")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Minnesota Twins" && team[num] == "MIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Houston Astros" && team[num] == "HOU")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Angels" && team[num] == "LAA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Oakland Athletics" && team[num] == "OAK")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Seattle Mariners" && team[num] == "SEA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Texas Rangers" && team[num] == "TEX")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Atlanta Braves" && team[num] == "ATL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Miami Marlins" && team[num] == "MIA")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "New York Mets" && team[num] == "NYM")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Philidelphia Phillies" && team[num] == "PHI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Washington Nationals" && team[num] == "WSN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Cincinnati Reds" && team[num] == "CIN")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Chicago Cubs" && team[num] == "CHC")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Milwaukee Brewers" && team[num] == "MIL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Pittsburgh Pirates" && team[num] == "PIT")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "St. Louis Cardinals" && team[num] == "STL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Arizona Diamondbacks" && team[num] == "ARI")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Colorado Rockies" && team[num] == "COL")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "Los Angeles Dodgers" && team[num] == "LAD")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Francisco Giants" && team[num] == "SFG")
                                {
                                    printHitters();
                                }
                                if (lbMLBTeams.Text == "San Diego Padres" && team[num] == "SDP")
                                {
                                    printHitters();
                                }
                            }
                        }
                    }

                    num++;
                }
            }
        }

        private void printHitters()
        {
            rtbOut.AppendText(team[num].PadRight(5) + (firstName[num] + " " + lastName[num]).PadRight(20));

            if (cbPA.Checked)
                rtbOut.AppendText(plateAppearaces[num].ToString("n0").PadLeft(4));

            if (cbAB.Checked)
                rtbOut.AppendText(atBats[num].ToString("n0").PadLeft(4));

            if (cbR.Checked)
                rtbOut.AppendText(runs[num].ToString("n0").PadLeft(4));

            if (cbH.Checked)
                rtbOut.AppendText(hits[num].ToString("n0").PadLeft(4));

            if (cb2B.Checked)
                rtbOut.AppendText(doubles[num].ToString("n0").PadLeft(4));

            if (cb3B.Checked)
                rtbOut.AppendText(triples[num].ToString("n0").PadLeft(4));

            if (cbHR.Checked)
                rtbOut.AppendText(homeRuns[num].ToString("n0").PadLeft(4));

            if (cbRBI.Checked)
                rtbOut.AppendText(runsBattedIn[num].ToString("n0").PadLeft(4));

            if (cbSB.Checked)
                rtbOut.AppendText(steals[num].ToString("n0").PadLeft(4));

            if (cbCS.Checked)
                rtbOut.AppendText(caughtStealing[num].ToString("n0").PadLeft(4));

            if (cbBB.Checked)
                rtbOut.AppendText(walks[num].ToString("n0").PadLeft(4));

            if (cbSO.Checked)
                rtbOut.AppendText(strikeOuts[num].ToString("n0").PadLeft(4));

            if (cbAVG.Checked)
                rtbOut.AppendText(battingAverage[num].ToString("n3").PadLeft(6));

            if (cbOBP.Checked)
                rtbOut.AppendText(onBasePercentage[num].ToString("n3").PadLeft(6));

            if (cbSLG.Checked)
                rtbOut.AppendText(slugging[num].ToString("n3").PadLeft(6));

            if (cbOPS.Checked)
                rtbOut.AppendText(onBasePlusSlugging[num].ToString("n3").PadLeft(6));

            if (cbTB.Checked)
                rtbOut.AppendText(totalBases[num].ToString("n0").PadLeft(4));

            if (cbHBP.Checked)
                rtbOut.AppendText(hitByPitch[num].ToString("n0").PadLeft(4));

            if (cbSF.Checked)
                rtbOut.AppendText(sacrificeFlies[num].ToString("n0").PadLeft(4));

            if (cbIBB.Checked)
                rtbOut.AppendText(intentionalWalks[num].ToString("n0").PadLeft(4));

            if (cbBABIP.Checked)
                rtbOut.AppendText(battingAverageOnBallsInPlay[num].ToString("n3").PadLeft(6));

            if (cbISO.Checked)
                rtbOut.AppendText(isolatedPower[num].ToString("n3").PadLeft(6));

            if (cbOPSPlus.Checked)
                rtbOut.AppendText(OPSPlus[num].ToString("n0").PadLeft(5));

            if (cbPASO.Checked)
                rtbOut.AppendText(plateAppearancesPerStrikeOut[num].ToString("n3").PadLeft(6));

            if (cbRC.Checked)
                rtbOut.AppendText(runsCreated[num].ToString("n1").PadLeft(6));

            if (cbwRCPlus.Checked)
                rtbOut.AppendText(weightRunsCretedPlus[num].ToString("n0").PadLeft(6));

            if (cbwOBA.Checked)
                rtbOut.AppendText(weightedOnBaseAverage[num].ToString("n3").PadLeft(6));

            if (cbwRAA.Checked)
                rtbOut.AppendText(weightRunsAboveAverage[num].ToString("n1").PadLeft(6));

            rtbOut.AppendText("\n");
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radHitters_CheckedChanged(object sender, EventArgs e)
        {
            gbNLorAL.Visible = true;
            gbHittersBasic.Visible = true;
            gbAdvanced.Visible = true;
            lbMLBTeams.Visible = true;
            lbHitterPosition.Visible = true;
            gbDivisions.Visible = true;
        }

        private void radPitchers_CheckedChanged(object sender, EventArgs e)
        {
            gbNLorAL.Visible = true;
            lbMLBTeams.Visible = true;
        }

        private void btnDictionary_Click(object sender, EventArgs e)
        {
            if(radHitters.Checked)
            {
                rtbOut.AppendText("Hitters Stats:\n\n" +
                "PA    - Plate Appearences\n" +
                "AB    - At Bats\n" +
                "R     - Runs Scored\n" +
                "H     - Hits\n" +
                "2B    - Doubles\n" +
                "3B    - Triples\n" +
                "HR    - Home Runs\n" +
                "RBI   - Runs Batted In\n" +
                "SB    - Stolen Bases\n" +
                "CS    - Caught Stealing\n" +
                "BB    - Base on Balls\n" +
                "SO    - Strike Outs\n" +
                "AVG   - Batting Average\n" +
                "OBP   - On Base Percentage\n" +
                "SLG   - Slugging Percentage\n" +
                "OPS   - On-Base Plus Slugging Percentage\n" +
                "BABIP - Batting Average on Balls in Play\n" +
                "ISO   - Isolated Power (raw power of a hitter by taking only extra-base hits)\n" +
                "OPS+  - OPS but 100 is average (if OPS+ = 150, player is 50% better than the average hitter)\n" +
                "PA/SO - Plate Appearances Per Strike Out\n" +
                "RC    - Runs Created (estimates a player's offensive contribution in terms of total runs)\n" +
                "wRAA  - Weighted Runs Above Average (measures how many runs a hitter contributes, compared with an average player)\n" +
                "wOBA  - Weighted On Base Average (a version of on-base percentage for how a player reached base instead of whether a player reached base)\n" +
                "wRC+  - Takes the statistic Runs Created and adjusts that number to account for important external factors\n" +
                "TB    - Total Bases\n" +
                "HBP   - Hit by Pitch\n" +
                "IBB   - Intentional Base on Balls\n");
            }
            else if (radPitchers.Checked)
            {

            }
            else if (radNBA.Checked)
            {

            }
            else
            {

            }
        }
    }
}

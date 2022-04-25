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
        string[] name = new string[0];
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

        string[] pName = new string[0];
        string[] pTeam = new string[0];
        string[] pDivisions = new string[0];
        string[] pLeague = new string[0];
        string[] pStaff = new string[0];
        double[] Wins = new double[0];
        double[] Losses = new double[0];
        double[] Games = new double[0];
        double[] GamesStarted = new double[0];
        double[] Saves = new double[0];
        double[] InningsPitched = new double[0];
        double[] pHits = new double[0];
        double[] pRuns = new double[0];
        double[] EarnedRuns = new double[0];
        double[] pHomeruns = new double[0];
        double[] pWalks = new double[0];
        double[] pIntentionalWalks = new double[0];
        double[] pStrikeOuts = new double[0];
        double[] pHitbyPitches = new double[0];
        double[] battersFaced = new double[0];
        double[] ERA = new double[0];
        double[] ERAPlus = new double[0];
        double[] WinPercentage = new double[0];
        double[] WalksPlusHitsPerInningsPitched = new double[0];
        double[] HomeRunsPer9 = new double[0];
        double[] HitsPer9 = new double[0];
        double[] WalksPer9 = new double[0];
        double[] StrikeoutsPer9 = new double[0];

        int num = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
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

                labelCheck();

                while (textIn.Peek() != -1)
                {
                    Array.Resize<string>(ref team, team.Length + 1);
                    Array.Resize<string>(ref name, name.Length + 1);
                    Array.Resize<string>(ref division, division.Length + 1);
                    Array.Resize<string>(ref league, league.Length + 1);
                    Array.Resize<string>(ref position, position.Length + 1);

                    string row = textIn.ReadLine();
                    string[] record = row.Split(',');
                    team[num] = Convert.ToString(record[2]).ToUpper();
                    name[num] = Convert.ToString(record[3] + " " + record[4]).ToUpper();
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
                            if (lbMLBTeams.Text == "All Teams")
                            {
                                if (lbHitterPosition.Text == "Catcher" && position[num] == "C")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "1st Base" && position[num] == "1B")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "2nd Base" && position[num] == "2B")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Short Stop" && position[num] == "SS")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "3rd Base" && position[num] == "3B")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Left Field" && position[num] == "LF")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Center Field" && position[num] == "CF")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Right Field" && position[num] == "RF")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Designated Hitter" && position[num] == "DH")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "All Positions")
                                {
                                    printHitters();
                                }
                            }
                            if (lbMLBTeams.Text == "Baltimore Orioles" && team[num] == "BAL")
                            {
                                if (lbHitterPosition.Text == "Catcher" && position[num] == "C")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "1st Base" && position[num] == "1B")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "2nd Base" && position[num] == "2B")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Short Stop" && position[num] == "SS")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "3rd Base" && position[num] == "3B")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Left Field" && position[num] == "LF")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Center Field" && position[num] == "CF")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Right Field" && position[num] == "RF")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Designated Hitter" && position[num] == "DH")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "All Positions")
                                {
                                    printHitters();
                                }
                            }
                            if (lbMLBTeams.Text == "Boston Red Sox" && team[num] == "BOS")
                            {
                                if (lbHitterPosition.Text == "Catcher" && position[num] == "C")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "1st Base" && position[num] == "1B")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "2nd Base" && position[num] == "2B")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Short Stop" && position[num] == "SS")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "3rd Base" && position[num] == "3B")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Left Field" && position[num] == "LF")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Center Field" && position[num] == "CF")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Right Field" && position[num] == "RF")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Designated Hitter" && position[num] == "DH")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "All Positions")
                                {
                                    printHitters();
                                }
                            }
                            if (lbMLBTeams.Text == "New York Yankees" && team[num] == "NYY")
                            {
                                if (lbHitterPosition.Text == "Catcher" && position[num] == "C")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "1st Base" && position[num] == "1B")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "2nd Base" && position[num] == "2B")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Short Stop" && position[num] == "SS")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "3rd Base" && position[num] == "3B")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Left Field" && position[num] == "LF")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Center Field" && position[num] == "CF")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Right Field" && position[num] == "RF")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Designated Hitter" && position[num] == "DH")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "All Positions")
                                {
                                    printHitters();
                                }
                            }
                            if (lbMLBTeams.Text == "Tampa Bay Rays" && team[num] == "TBR")
                            {
                                if (lbHitterPosition.Text == "Catcher" && position[num] == "C")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "1st Base" && position[num] == "1B")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "2nd Base" && position[num] == "2B")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Short Stop" && position[num] == "SS")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "3rd Base" && position[num] == "3B")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Left Field" && position[num] == "LF")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Center Field" && position[num] == "CF")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Right Field" && position[num] == "RF")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Designated Hitter" && position[num] == "DH")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "All Positions")
                                {
                                    printHitters();
                                }
                            }
                            if (lbMLBTeams.Text == "Toronto Blue Jays" && team[num] == "TOR")
                            {
                                if (lbHitterPosition.Text == "Catcher" && position[num] == "C")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "1st Base" && position[num] == "1B")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "2nd Base" && position[num] == "2B")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Short Stop" && position[num] == "SS")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "3rd Base" && position[num] == "3B")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Left Field" && position[num] == "LF")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Center Field" && position[num] == "CF")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Right Field" && position[num] == "RF")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Designated Hitter" && position[num] == "DH")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "All Positions")
                                {
                                    printHitters();
                                }
                            }
                            if (lbMLBTeams.Text == "Chicago White Sox" && team[num] == "CWS")
                            {
                                if (lbHitterPosition.Text == "Catcher" && position[num] == "C")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "1st Base" && position[num] == "1B")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "2nd Base" && position[num] == "2B")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Short Stop" && position[num] == "SS")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "3rd Base" && position[num] == "3B")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Left Field" && position[num] == "LF")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Center Field" && position[num] == "CF")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Right Field" && position[num] == "RF")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Designated Hitter" && position[num] == "DH")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "All Positions")
                                {
                                    printHitters();
                                }
                            }
                            if (lbMLBTeams.Text == "Cleveland Guardians" && team[num] == "CLE")
                            {
                                if (lbHitterPosition.Text == "Catcher" && position[num] == "C")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "1st Base" && position[num] == "1B")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "2nd Base" && position[num] == "2B")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Short Stop" && position[num] == "SS")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "3rd Base" && position[num] == "3B")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Left Field" && position[num] == "LF")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Center Field" && position[num] == "CF")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Right Field" && position[num] == "RF")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Designated Hitter" && position[num] == "DH")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "All Positions")
                                {
                                    printHitters();
                                }
                            }
                            if (lbMLBTeams.Text == "Detroit Tigers" && team[num] == "DET")
                            {
                                if (lbHitterPosition.Text == "Catcher" && position[num] == "C")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "1st Base" && position[num] == "1B")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "2nd Base" && position[num] == "2B")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Short Stop" && position[num] == "SS")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "3rd Base" && position[num] == "3B")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Left Field" && position[num] == "LF")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Center Field" && position[num] == "CF")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Right Field" && position[num] == "RF")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Designated Hitter" && position[num] == "DH")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "All Positions")
                                {
                                    printHitters();
                                }
                            }
                            if (lbMLBTeams.Text == "Kansas City Royals" && team[num] == "KCR")
                            {
                                if (lbHitterPosition.Text == "Catcher" && position[num] == "C")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "1st Base" && position[num] == "1B")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "2nd Base" && position[num] == "2B")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Short Stop" && position[num] == "SS")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "3rd Base" && position[num] == "3B")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Left Field" && position[num] == "LF")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Center Field" && position[num] == "CF")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Right Field" && position[num] == "RF")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Designated Hitter" && position[num] == "DH")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "All Positions")
                                {
                                    printHitters();
                                }
                            }
                            if (lbMLBTeams.Text == "Minnesota Twins" && team[num] == "MIN")
                            {
                                if (lbHitterPosition.Text == "Catcher" && position[num] == "C")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "1st Base" && position[num] == "1B")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "2nd Base" && position[num] == "2B")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Short Stop" && position[num] == "SS")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "3rd Base" && position[num] == "3B")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Left Field" && position[num] == "LF")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Center Field" && position[num] == "CF")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Right Field" && position[num] == "RF")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Designated Hitter" && position[num] == "DH")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "All Positions")
                                {
                                    printHitters();
                                }
                            }
                            if (lbMLBTeams.Text == "Houston Astros" && team[num] == "HOU")
                            {
                                if (lbHitterPosition.Text == "Catcher" && position[num] == "C")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "1st Base" && position[num] == "1B")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "2nd Base" && position[num] == "2B")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Short Stop" && position[num] == "SS")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "3rd Base" && position[num] == "3B")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Left Field" && position[num] == "LF")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Center Field" && position[num] == "CF")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Right Field" && position[num] == "RF")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Designated Hitter" && position[num] == "DH")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "All Positions")
                                {
                                    printHitters();
                                }
                            }
                            if (lbMLBTeams.Text == "Los Angeles Angels" && team[num] == "LAA")
                            {
                                if (lbHitterPosition.Text == "Catcher" && position[num] == "C")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "1st Base" && position[num] == "1B")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "2nd Base" && position[num] == "2B")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Short Stop" && position[num] == "SS")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "3rd Base" && position[num] == "3B")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Left Field" && position[num] == "LF")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Center Field" && position[num] == "CF")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Right Field" && position[num] == "RF")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Designated Hitter" && position[num] == "DH")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "All Positions")
                                {
                                    printHitters();
                                }
                            }
                            if (lbMLBTeams.Text == "Oakland Athletics" && team[num] == "OAK")
                            {
                                if (lbHitterPosition.Text == "Catcher" && position[num] == "C")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "1st Base" && position[num] == "1B")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "2nd Base" && position[num] == "2B")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Short Stop" && position[num] == "SS")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "3rd Base" && position[num] == "3B")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Left Field" && position[num] == "LF")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Center Field" && position[num] == "CF")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Right Field" && position[num] == "RF")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Designated Hitter" && position[num] == "DH")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "All Positions")
                                {
                                    printHitters();
                                }
                            }
                            if (lbMLBTeams.Text == "Seattle Mariners" && team[num] == "SEA")
                            {
                                if (lbHitterPosition.Text == "Catcher" && position[num] == "C")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "1st Base" && position[num] == "1B")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "2nd Base" && position[num] == "2B")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Short Stop" && position[num] == "SS")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "3rd Base" && position[num] == "3B")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Left Field" && position[num] == "LF")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Center Field" && position[num] == "CF")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Right Field" && position[num] == "RF")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Designated Hitter" && position[num] == "DH")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "All Positions")
                                {
                                    printHitters();
                                }
                            }
                            if (lbMLBTeams.Text == "Texas Rangers" && team[num] == "TEX")
                            {
                                if (lbHitterPosition.Text == "Catcher" && position[num] == "C")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "1st Base" && position[num] == "1B")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "2nd Base" && position[num] == "2B")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Short Stop" && position[num] == "SS")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "3rd Base" && position[num] == "3B")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Left Field" && position[num] == "LF")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Center Field" && position[num] == "CF")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Right Field" && position[num] == "RF")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Designated Hitter" && position[num] == "DH")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "All Positions")
                                {
                                    printHitters();
                                }
                            }
                            if (lbMLBTeams.Text == "Atlanta Braves" && team[num] == "ATL")
                            {
                                if (lbHitterPosition.Text == "Catcher" && position[num] == "C")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "1st Base" && position[num] == "1B")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "2nd Base" && position[num] == "2B")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Short Stop" && position[num] == "SS")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "3rd Base" && position[num] == "3B")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Left Field" && position[num] == "LF")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Center Field" && position[num] == "CF")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Right Field" && position[num] == "RF")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Designated Hitter" && position[num] == "DH")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "All Positions")
                                {
                                    printHitters();
                                }
                            }
                            if (lbMLBTeams.Text == "Miami Marlins" && team[num] == "MIA")
                            {
                                if (lbHitterPosition.Text == "Catcher" && position[num] == "C")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "1st Base" && position[num] == "1B")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "2nd Base" && position[num] == "2B")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Short Stop" && position[num] == "SS")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "3rd Base" && position[num] == "3B")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Left Field" && position[num] == "LF")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Center Field" && position[num] == "CF")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Right Field" && position[num] == "RF")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Designated Hitter" && position[num] == "DH")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "All Positions")
                                {
                                    printHitters();
                                }
                            }
                            if (lbMLBTeams.Text == "New York Mets" && team[num] == "NYM")
                            {
                                if (lbHitterPosition.Text == "Catcher" && position[num] == "C")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "1st Base" && position[num] == "1B")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "2nd Base" && position[num] == "2B")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Short Stop" && position[num] == "SS")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "3rd Base" && position[num] == "3B")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Left Field" && position[num] == "LF")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Center Field" && position[num] == "CF")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Right Field" && position[num] == "RF")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Designated Hitter" && position[num] == "DH")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "All Positions")
                                {
                                    printHitters();
                                }
                            }
                            if (lbMLBTeams.Text == "Philadelphia Phillies" && team[num] == "PHI")
                            {
                                if (lbHitterPosition.Text == "Catcher" && position[num] == "C")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "1st Base" && position[num] == "1B")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "2nd Base" && position[num] == "2B")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Short Stop" && position[num] == "SS")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "3rd Base" && position[num] == "3B")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Left Field" && position[num] == "LF")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Center Field" && position[num] == "CF")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Right Field" && position[num] == "RF")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Designated Hitter" && position[num] == "DH")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "All Positions")
                                {
                                    printHitters();
                                }
                            }
                            if (lbMLBTeams.Text == "Washington Nationals" && team[num] == "WSN")
                            {
                                if (lbHitterPosition.Text == "Catcher" && position[num] == "C")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "1st Base" && position[num] == "1B")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "2nd Base" && position[num] == "2B")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Short Stop" && position[num] == "SS")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "3rd Base" && position[num] == "3B")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Left Field" && position[num] == "LF")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Center Field" && position[num] == "CF")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Right Field" && position[num] == "RF")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Designated Hitter" && position[num] == "DH")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "All Positions")
                                {
                                    printHitters();
                                }
                            }
                            if (lbMLBTeams.Text == "Cincinnati Reds" && team[num] == "CIN")
                            {
                                if (lbHitterPosition.Text == "Catcher" && position[num] == "C")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "1st Base" && position[num] == "1B")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "2nd Base" && position[num] == "2B")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Short Stop" && position[num] == "SS")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "3rd Base" && position[num] == "3B")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Left Field" && position[num] == "LF")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Center Field" && position[num] == "CF")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Right Field" && position[num] == "RF")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Designated Hitter" && position[num] == "DH")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "All Positions")
                                {
                                    printHitters();
                                }
                            }
                            if (lbMLBTeams.Text == "Chicago Cubs" && team[num] == "CHC")
                            {
                                if (lbHitterPosition.Text == "Catcher" && position[num] == "C")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "1st Base" && position[num] == "1B")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "2nd Base" && position[num] == "2B")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Short Stop" && position[num] == "SS")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "3rd Base" && position[num] == "3B")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Left Field" && position[num] == "LF")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Center Field" && position[num] == "CF")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Right Field" && position[num] == "RF")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Designated Hitter" && position[num] == "DH")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "All Positions")
                                {
                                    printHitters();
                                }
                            }
                            if (lbMLBTeams.Text == "Milwaukee Brewers" && team[num] == "MIL")
                            {
                                if (lbHitterPosition.Text == "Catcher" && position[num] == "C")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "1st Base" && position[num] == "1B")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "2nd Base" && position[num] == "2B")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Short Stop" && position[num] == "SS")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "3rd Base" && position[num] == "3B")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Left Field" && position[num] == "LF")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Center Field" && position[num] == "CF")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Right Field" && position[num] == "RF")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Designated Hitter" && position[num] == "DH")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "All Positions")
                                {
                                    printHitters();
                                }
                            }
                            if (lbMLBTeams.Text == "Pittsburgh Pirates" && team[num] == "PIT")
                            {
                                if (lbHitterPosition.Text == "Catcher" && position[num] == "C")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "1st Base" && position[num] == "1B")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "2nd Base" && position[num] == "2B")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Short Stop" && position[num] == "SS")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "3rd Base" && position[num] == "3B")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Left Field" && position[num] == "LF")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Center Field" && position[num] == "CF")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Right Field" && position[num] == "RF")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Designated Hitter" && position[num] == "DH")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "All Positions")
                                {
                                    printHitters();
                                }
                            }
                            if (lbMLBTeams.Text == "St. Louis Cardinals" && team[num] == "STL")
                            {
                                if (lbHitterPosition.Text == "Catcher" && position[num] == "C")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "1st Base" && position[num] == "1B")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "2nd Base" && position[num] == "2B")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Short Stop" && position[num] == "SS")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "3rd Base" && position[num] == "3B")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Left Field" && position[num] == "LF")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Center Field" && position[num] == "CF")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Right Field" && position[num] == "RF")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Designated Hitter" && position[num] == "DH")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "All Positions")
                                {
                                    printHitters();
                                }
                            }
                            if (lbMLBTeams.Text == "Arizona Diamondbacks" && team[num] == "ARI")
                            {
                                if (lbHitterPosition.Text == "Catcher" && position[num] == "C")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "1st Base" && position[num] == "1B")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "2nd Base" && position[num] == "2B")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Short Stop" && position[num] == "SS")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "3rd Base" && position[num] == "3B")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Left Field" && position[num] == "LF")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Center Field" && position[num] == "CF")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Right Field" && position[num] == "RF")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Designated Hitter" && position[num] == "DH")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "All Positions")
                                {
                                    printHitters();
                                }
                            }
                            if (lbMLBTeams.Text == "Colorado Rockies" && team[num] == "COL")
                            {
                                if (lbHitterPosition.Text == "Catcher" && position[num] == "C")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "1st Base" && position[num] == "1B")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "2nd Base" && position[num] == "2B")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Short Stop" && position[num] == "SS")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "3rd Base" && position[num] == "3B")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Left Field" && position[num] == "LF")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Center Field" && position[num] == "CF")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Right Field" && position[num] == "RF")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Designated Hitter" && position[num] == "DH")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "All Positions")
                                {
                                    printHitters();
                                }
                            }
                            if (lbMLBTeams.Text == "Los Angeles Dodgers" && team[num] == "LAD")
                            {
                                if (lbHitterPosition.Text == "Catcher" && position[num] == "C")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "1st Base" && position[num] == "1B")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "2nd Base" && position[num] == "2B")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Short Stop" && position[num] == "SS")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "3rd Base" && position[num] == "3B")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Left Field" && position[num] == "LF")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Center Field" && position[num] == "CF")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Right Field" && position[num] == "RF")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Designated Hitter" && position[num] == "DH")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "All Positions")
                                {
                                    printHitters();
                                }
                            }
                            if (lbMLBTeams.Text == "San Francisco Giants" && team[num] == "SFG")
                            {
                                if (lbHitterPosition.Text == "Catcher" && position[num] == "C")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "1st Base" && position[num] == "1B")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "2nd Base" && position[num] == "2B")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Short Stop" && position[num] == "SS")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "3rd Base" && position[num] == "3B")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Left Field" && position[num] == "LF")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Center Field" && position[num] == "CF")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Right Field" && position[num] == "RF")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Designated Hitter" && position[num] == "DH")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "All Positions")
                                {
                                    printHitters();
                                }
                            }
                            if (lbMLBTeams.Text == "San Diego Padres" && team[num] == "SDP")
                            {
                                if (lbHitterPosition.Text == "Catcher" && position[num] == "C")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "1st Base" && position[num] == "1B")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "2nd Base" && position[num] == "2B")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Short Stop" && position[num] == "SS")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "3rd Base" && position[num] == "3B")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Left Field" && position[num] == "LF")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Center Field" && position[num] == "CF")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Right Field" && position[num] == "RF")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Designated Hitter" && position[num] == "DH")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "All Positions")
                                {
                                    printHitters();
                                }
                            }
                        }
                    else if (radAllDivisions.Checked && radAL.Checked)
                        {
                            if (league[num] == "AL")
                            {
                                if (lbMLBTeams.Text == "All Teams")
                                {
                                    if (lbHitterPosition.Text == "Catcher" && position[num] == "C")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "1st Base" && position[num] == "1B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "2nd Base" && position[num] == "2B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Short Stop" && position[num] == "SS")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "3rd Base" && position[num] == "3B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Left Field" && position[num] == "LF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Center Field" && position[num] == "CF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Right Field" && position[num] == "RF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Designated Hitter" && position[num] == "DH")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "All Positions")
                                    {
                                        printHitters();
                                    }
                                }
                                if (lbMLBTeams.Text == "Baltimore Orioles" && team[num] == "BAL")
                                {
                                    if (lbHitterPosition.Text == "Catcher" && position[num] == "C")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "1st Base" && position[num] == "1B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "2nd Base" && position[num] == "2B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Short Stop" && position[num] == "SS")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "3rd Base" && position[num] == "3B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Left Field" && position[num] == "LF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Center Field" && position[num] == "CF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Right Field" && position[num] == "RF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Designated Hitter" && position[num] == "DH")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "All Positions")
                                    {
                                        printHitters();
                                    }
                                }
                                if (lbMLBTeams.Text == "Boston Red Sox" && team[num] == "BOS")
                                {
                                    if (lbHitterPosition.Text == "Catcher" && position[num] == "C")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "1st Base" && position[num] == "1B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "2nd Base" && position[num] == "2B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Short Stop" && position[num] == "SS")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "3rd Base" && position[num] == "3B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Left Field" && position[num] == "LF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Center Field" && position[num] == "CF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Right Field" && position[num] == "RF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Designated Hitter" && position[num] == "DH")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "All Positions")
                                    {
                                        printHitters();
                                    }
                                }
                                if (lbMLBTeams.Text == "New York Yankees" && team[num] == "NYY")
                                {
                                    if (lbHitterPosition.Text == "Catcher" && position[num] == "C")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "1st Base" && position[num] == "1B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "2nd Base" && position[num] == "2B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Short Stop" && position[num] == "SS")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "3rd Base" && position[num] == "3B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Left Field" && position[num] == "LF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Center Field" && position[num] == "CF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Right Field" && position[num] == "RF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Designated Hitter" && position[num] == "DH")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "All Positions")
                                    {
                                        printHitters();
                                    }
                                }
                                if (lbMLBTeams.Text == "Tampa Bay Rays" && team[num] == "TBR")
                                {
                                    if (lbHitterPosition.Text == "Catcher" && position[num] == "C")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "1st Base" && position[num] == "1B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "2nd Base" && position[num] == "2B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Short Stop" && position[num] == "SS")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "3rd Base" && position[num] == "3B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Left Field" && position[num] == "LF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Center Field" && position[num] == "CF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Right Field" && position[num] == "RF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Designated Hitter" && position[num] == "DH")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "All Positions")
                                    {
                                        printHitters();
                                    }
                                }
                                if (lbMLBTeams.Text == "Toronto Blue Jays" && team[num] == "TOR")
                                {
                                    if (lbHitterPosition.Text == "Catcher" && position[num] == "C")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "1st Base" && position[num] == "1B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "2nd Base" && position[num] == "2B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Short Stop" && position[num] == "SS")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "3rd Base" && position[num] == "3B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Left Field" && position[num] == "LF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Center Field" && position[num] == "CF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Right Field" && position[num] == "RF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Designated Hitter" && position[num] == "DH")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "All Positions")
                                    {
                                        printHitters();
                                    }
                                }
                                if (lbMLBTeams.Text == "Chicago White Sox" && team[num] == "CWS")
                                {
                                    if (lbHitterPosition.Text == "Catcher" && position[num] == "C")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "1st Base" && position[num] == "1B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "2nd Base" && position[num] == "2B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Short Stop" && position[num] == "SS")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "3rd Base" && position[num] == "3B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Left Field" && position[num] == "LF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Center Field" && position[num] == "CF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Right Field" && position[num] == "RF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Designated Hitter" && position[num] == "DH")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "All Positions")
                                    {
                                        printHitters();
                                    }
                                }
                                if (lbMLBTeams.Text == "Cleveland Guardians" && team[num] == "CLE")
                                {
                                    if (lbHitterPosition.Text == "Catcher" && position[num] == "C")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "1st Base" && position[num] == "1B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "2nd Base" && position[num] == "2B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Short Stop" && position[num] == "SS")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "3rd Base" && position[num] == "3B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Left Field" && position[num] == "LF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Center Field" && position[num] == "CF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Right Field" && position[num] == "RF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Designated Hitter" && position[num] == "DH")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "All Positions")
                                    {
                                        printHitters();
                                    }
                                }
                                if (lbMLBTeams.Text == "Detroit Tigers" && team[num] == "DET")
                                {
                                    if (lbHitterPosition.Text == "Catcher" && position[num] == "C")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "1st Base" && position[num] == "1B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "2nd Base" && position[num] == "2B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Short Stop" && position[num] == "SS")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "3rd Base" && position[num] == "3B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Left Field" && position[num] == "LF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Center Field" && position[num] == "CF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Right Field" && position[num] == "RF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Designated Hitter" && position[num] == "DH")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "All Positions")
                                    {
                                        printHitters();
                                    }
                                }
                                if (lbMLBTeams.Text == "Kansas City Royals" && team[num] == "KCR")
                                {
                                    if (lbHitterPosition.Text == "Catcher" && position[num] == "C")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "1st Base" && position[num] == "1B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "2nd Base" && position[num] == "2B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Short Stop" && position[num] == "SS")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "3rd Base" && position[num] == "3B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Left Field" && position[num] == "LF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Center Field" && position[num] == "CF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Right Field" && position[num] == "RF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Designated Hitter" && position[num] == "DH")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "All Positions")
                                    {
                                        printHitters();
                                    }
                                }
                                if (lbMLBTeams.Text == "Minnesota Twins" && team[num] == "MIN")
                                {
                                    if (lbHitterPosition.Text == "Catcher" && position[num] == "C")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "1st Base" && position[num] == "1B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "2nd Base" && position[num] == "2B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Short Stop" && position[num] == "SS")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "3rd Base" && position[num] == "3B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Left Field" && position[num] == "LF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Center Field" && position[num] == "CF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Right Field" && position[num] == "RF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Designated Hitter" && position[num] == "DH")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "All Positions")
                                    {
                                        printHitters();
                                    }
                                }
                                if (lbMLBTeams.Text == "Houston Astros" && team[num] == "HOU")
                                {
                                    if (lbHitterPosition.Text == "Catcher" && position[num] == "C")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "1st Base" && position[num] == "1B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "2nd Base" && position[num] == "2B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Short Stop" && position[num] == "SS")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "3rd Base" && position[num] == "3B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Left Field" && position[num] == "LF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Center Field" && position[num] == "CF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Right Field" && position[num] == "RF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Designated Hitter" && position[num] == "DH")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "All Positions")
                                    {
                                        printHitters();
                                    }
                                }
                                if (lbMLBTeams.Text == "Los Angeles Angels" && team[num] == "LAA")
                                {
                                    if (lbHitterPosition.Text == "Catcher" && position[num] == "C")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "1st Base" && position[num] == "1B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "2nd Base" && position[num] == "2B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Short Stop" && position[num] == "SS")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "3rd Base" && position[num] == "3B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Left Field" && position[num] == "LF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Center Field" && position[num] == "CF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Right Field" && position[num] == "RF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Designated Hitter" && position[num] == "DH")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "All Positions")
                                    {
                                        printHitters();
                                    }
                                }
                                if (lbMLBTeams.Text == "Oakland Athletics" && team[num] == "OAK")
                                {
                                    if (lbHitterPosition.Text == "Catcher" && position[num] == "C")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "1st Base" && position[num] == "1B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "2nd Base" && position[num] == "2B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Short Stop" && position[num] == "SS")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "3rd Base" && position[num] == "3B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Left Field" && position[num] == "LF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Center Field" && position[num] == "CF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Right Field" && position[num] == "RF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Designated Hitter" && position[num] == "DH")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "All Positions")
                                    {
                                        printHitters();
                                    }
                                }
                                if (lbMLBTeams.Text == "Seattle Mariners" && team[num] == "SEA")
                                {
                                    if (lbHitterPosition.Text == "Catcher" && position[num] == "C")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "1st Base" && position[num] == "1B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "2nd Base" && position[num] == "2B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Short Stop" && position[num] == "SS")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "3rd Base" && position[num] == "3B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Left Field" && position[num] == "LF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Center Field" && position[num] == "CF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Right Field" && position[num] == "RF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Designated Hitter" && position[num] == "DH")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "All Positions")
                                    {
                                        printHitters();
                                    }
                                }
                                if (lbMLBTeams.Text == "Texas Rangers" && team[num] == "TEX")
                                {
                                    if (lbHitterPosition.Text == "Catcher" && position[num] == "C")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "1st Base" && position[num] == "1B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "2nd Base" && position[num] == "2B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Short Stop" && position[num] == "SS")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "3rd Base" && position[num] == "3B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Left Field" && position[num] == "LF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Center Field" && position[num] == "CF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Right Field" && position[num] == "RF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Designated Hitter" && position[num] == "DH")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "All Positions")
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
                                if (lbMLBTeams.Text == "All Teams")
                                {
                                    if (lbHitterPosition.Text == "Catcher" && position[num] == "C")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "1st Base" && position[num] == "1B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "2nd Base" && position[num] == "2B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Short Stop" && position[num] == "SS")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "3rd Base" && position[num] == "3B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Left Field" && position[num] == "LF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Center Field" && position[num] == "CF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Right Field" && position[num] == "RF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Designated Hitter" && position[num] == "DH")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "All Positions")
                                    {
                                        printHitters();
                                    }
                                }
                                if (lbMLBTeams.Text == "Atlanta Braves" && team[num] == "ATL")
                                {
                                    if (lbHitterPosition.Text == "Catcher" && position[num] == "C")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "1st Base" && position[num] == "1B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "2nd Base" && position[num] == "2B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Short Stop" && position[num] == "SS")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "3rd Base" && position[num] == "3B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Left Field" && position[num] == "LF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Center Field" && position[num] == "CF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Right Field" && position[num] == "RF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Designated Hitter" && position[num] == "DH")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "All Positions")
                                    {
                                        printHitters();
                                    }
                                }
                                if (lbMLBTeams.Text == "Miami Marlins" && team[num] == "MIA")
                                {
                                    if (lbHitterPosition.Text == "Catcher" && position[num] == "C")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "1st Base" && position[num] == "1B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "2nd Base" && position[num] == "2B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Short Stop" && position[num] == "SS")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "3rd Base" && position[num] == "3B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Left Field" && position[num] == "LF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Center Field" && position[num] == "CF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Right Field" && position[num] == "RF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Designated Hitter" && position[num] == "DH")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "All Positions")
                                    {
                                        printHitters();
                                    }
                                }
                                if (lbMLBTeams.Text == "New York Mets" && team[num] == "NYM")
                                {
                                    if (lbHitterPosition.Text == "Catcher" && position[num] == "C")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "1st Base" && position[num] == "1B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "2nd Base" && position[num] == "2B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Short Stop" && position[num] == "SS")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "3rd Base" && position[num] == "3B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Left Field" && position[num] == "LF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Center Field" && position[num] == "CF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Right Field" && position[num] == "RF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Designated Hitter" && position[num] == "DH")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "All Positions")
                                    {
                                        printHitters();
                                    }
                                }
                                if (lbMLBTeams.Text == "Philadelphia Phillies" && team[num] == "PHI")
                                {
                                    if (lbHitterPosition.Text == "Catcher" && position[num] == "C")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "1st Base" && position[num] == "1B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "2nd Base" && position[num] == "2B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Short Stop" && position[num] == "SS")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "3rd Base" && position[num] == "3B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Left Field" && position[num] == "LF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Center Field" && position[num] == "CF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Right Field" && position[num] == "RF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Designated Hitter" && position[num] == "DH")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "All Positions")
                                    {
                                        printHitters();
                                    }
                                }
                                if (lbMLBTeams.Text == "Washington Nationals" && team[num] == "WSN")
                                {
                                    if (lbHitterPosition.Text == "Catcher" && position[num] == "C")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "1st Base" && position[num] == "1B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "2nd Base" && position[num] == "2B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Short Stop" && position[num] == "SS")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "3rd Base" && position[num] == "3B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Left Field" && position[num] == "LF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Center Field" && position[num] == "CF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Right Field" && position[num] == "RF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Designated Hitter" && position[num] == "DH")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "All Positions")
                                    {
                                        printHitters();
                                    }
                                }
                                if (lbMLBTeams.Text == "Cincinnati Reds" && team[num] == "CIN")
                                {
                                    if (lbHitterPosition.Text == "Catcher" && position[num] == "C")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "1st Base" && position[num] == "1B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "2nd Base" && position[num] == "2B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Short Stop" && position[num] == "SS")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "3rd Base" && position[num] == "3B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Left Field" && position[num] == "LF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Center Field" && position[num] == "CF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Right Field" && position[num] == "RF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Designated Hitter" && position[num] == "DH")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "All Positions")
                                    {
                                        printHitters();
                                    }
                                }
                                if (lbMLBTeams.Text == "Chicago Cubs" && team[num] == "CHC")
                                {
                                    if (lbHitterPosition.Text == "Catcher" && position[num] == "C")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "1st Base" && position[num] == "1B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "2nd Base" && position[num] == "2B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Short Stop" && position[num] == "SS")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "3rd Base" && position[num] == "3B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Left Field" && position[num] == "LF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Center Field" && position[num] == "CF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Right Field" && position[num] == "RF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Designated Hitter" && position[num] == "DH")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "All Positions")
                                    {
                                        printHitters();
                                    }
                                }
                                if (lbMLBTeams.Text == "Milwaukee Brewers" && team[num] == "MIL")
                                {
                                    if (lbHitterPosition.Text == "Catcher" && position[num] == "C")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "1st Base" && position[num] == "1B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "2nd Base" && position[num] == "2B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Short Stop" && position[num] == "SS")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "3rd Base" && position[num] == "3B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Left Field" && position[num] == "LF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Center Field" && position[num] == "CF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Right Field" && position[num] == "RF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Designated Hitter" && position[num] == "DH")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "All Positions")
                                    {
                                        printHitters();
                                    }
                                }
                                if (lbMLBTeams.Text == "Pittsburgh Pirates" && team[num] == "PIT")
                                {
                                    if (lbHitterPosition.Text == "Catcher" && position[num] == "C")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "1st Base" && position[num] == "1B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "2nd Base" && position[num] == "2B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Short Stop" && position[num] == "SS")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "3rd Base" && position[num] == "3B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Left Field" && position[num] == "LF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Center Field" && position[num] == "CF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Right Field" && position[num] == "RF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Designated Hitter" && position[num] == "DH")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "All Positions")
                                    {
                                        printHitters();
                                    }
                                }
                                if (lbMLBTeams.Text == "St. Louis" && team[num] == "STL")
                                {
                                    if (lbHitterPosition.Text == "Catcher" && position[num] == "C")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "1st Base" && position[num] == "1B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "2nd Base" && position[num] == "2B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Short Stop" && position[num] == "SS")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "3rd Base" && position[num] == "3B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Left Field" && position[num] == "LF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Center Field" && position[num] == "CF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Right Field" && position[num] == "RF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Designated Hitter" && position[num] == "DH")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "All Positions")
                                    {
                                        printHitters();
                                    }
                                }
                                if (lbMLBTeams.Text == "Arizona Diamondbacks" && team[num] == "ARI")
                                {
                                    if (lbHitterPosition.Text == "Catcher" && position[num] == "C")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "1st Base" && position[num] == "1B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "2nd Base" && position[num] == "2B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Short Stop" && position[num] == "SS")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "3rd Base" && position[num] == "3B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Left Field" && position[num] == "LF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Center Field" && position[num] == "CF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Right Field" && position[num] == "RF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Designated Hitter" && position[num] == "DH")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "All Positions")
                                    {
                                        printHitters();
                                    }
                                }
                                if (lbMLBTeams.Text == "Colorado Rockies" && team[num] == "COL")
                                {
                                    if (lbHitterPosition.Text == "Catcher" && position[num] == "C")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "1st Base" && position[num] == "1B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "2nd Base" && position[num] == "2B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Short Stop" && position[num] == "SS")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "3rd Base" && position[num] == "3B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Left Field" && position[num] == "LF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Center Field" && position[num] == "CF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Right Field" && position[num] == "RF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Designated Hitter" && position[num] == "DH")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "All Positions")
                                    {
                                        printHitters();
                                    }
                                }
                                if (lbMLBTeams.Text == "Los Angeles Dodgers" && team[num] == "LAD")
                                {
                                    if (lbHitterPosition.Text == "Catcher" && position[num] == "C")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "1st Base" && position[num] == "1B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "2nd Base" && position[num] == "2B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Short Stop" && position[num] == "SS")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "3rd Base" && position[num] == "3B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Left Field" && position[num] == "LF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Center Field" && position[num] == "CF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Right Field" && position[num] == "RF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Designated Hitter" && position[num] == "DH")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "All Positions")
                                    {
                                        printHitters();
                                    }
                                }
                                if (lbMLBTeams.Text == "San Francisco Giants" && team[num] == "SFG")
                                {
                                    if (lbHitterPosition.Text == "Catcher" && position[num] == "C")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "1st Base" && position[num] == "1B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "2nd Base" && position[num] == "2B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Short Stop" && position[num] == "SS")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "3rd Base" && position[num] == "3B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Left Field" && position[num] == "LF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Center Field" && position[num] == "CF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Right Field" && position[num] == "RF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Designated Hitter" && position[num] == "DH")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "All Positions")
                                    {
                                        printHitters();
                                    }
                                }
                                if (lbMLBTeams.Text == "San Diego Padres" && team[num] == "SDP")
                                {
                                    if (lbHitterPosition.Text == "Catcher" && position[num] == "C")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "1st Base" && position[num] == "1B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "2nd Base" && position[num] == "2B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Short Stop" && position[num] == "SS")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "3rd Base" && position[num] == "3B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Left Field" && position[num] == "LF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Center Field" && position[num] == "CF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Right Field" && position[num] == "RF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Designated Hitter" && position[num] == "DH")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "All Positions")
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
                                if (lbMLBTeams.Text == "All Teams")
                                {
                                    if (lbHitterPosition.Text == "Catcher" && position[num] == "C")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "1st Base" && position[num] == "1B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "2nd Base" && position[num] == "2B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Short Stop" && position[num] == "SS")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "3rd Base" && position[num] == "3B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Left Field" && position[num] == "LF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Center Field" && position[num] == "CF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Right Field" && position[num] == "RF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Designated Hitter" && position[num] == "DH")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "All Positions")
                                    {
                                        printHitters();
                                    }
                                }
                                if (lbMLBTeams.Text == "Baltimore Orioles" && team[num] == "BAL")
                                {
                                    if (lbHitterPosition.Text == "Catcher" && position[num] == "C")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "1st Base" && position[num] == "1B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "2nd Base" && position[num] == "2B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Short Stop" && position[num] == "SS")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "3rd Base" && position[num] == "3B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Left Field" && position[num] == "LF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Center Field" && position[num] == "CF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Right Field" && position[num] == "RF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Designated Hitter" && position[num] == "DH")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "All Positions")
                                    {
                                        printHitters();
                                    }
                                }
                                if (lbMLBTeams.Text == "Boston Red Sox" && team[num] == "BOS")
                                {
                                    if (lbHitterPosition.Text == "Catcher" && position[num] == "C")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "1st Base" && position[num] == "1B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "2nd Base" && position[num] == "2B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Short Stop" && position[num] == "SS")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "3rd Base" && position[num] == "3B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Left Field" && position[num] == "LF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Center Field" && position[num] == "CF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Right Field" && position[num] == "RF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Designated Hitter" && position[num] == "DH")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "All Positions")
                                    {
                                        printHitters();
                                    }
                                }
                                if (lbMLBTeams.Text == "New York Yankees" && team[num] == "NYY")
                                {
                                    if (lbHitterPosition.Text == "Catcher" && position[num] == "C")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "1st Base" && position[num] == "1B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "2nd Base" && position[num] == "2B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Short Stop" && position[num] == "SS")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "3rd Base" && position[num] == "3B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Left Field" && position[num] == "LF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Center Field" && position[num] == "CF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Right Field" && position[num] == "RF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Designated Hitter" && position[num] == "DH")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "All Positions")
                                    {
                                        printHitters();
                                    }
                                }
                                if (lbMLBTeams.Text == "Tampa Bay Rays" && team[num] == "TBR")
                                {
                                    if (lbHitterPosition.Text == "Catcher" && position[num] == "C")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "1st Base" && position[num] == "1B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "2nd Base" && position[num] == "2B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Short Stop" && position[num] == "SS")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "3rd Base" && position[num] == "3B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Left Field" && position[num] == "LF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Center Field" && position[num] == "CF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Right Field" && position[num] == "RF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Designated Hitter" && position[num] == "DH")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "All Positions")
                                    {
                                        printHitters();
                                    }
                                }
                                if (lbMLBTeams.Text == "Toronto Blue Jays" && team[num] == "TOR")
                                {
                                    if (lbHitterPosition.Text == "Catcher" && position[num] == "C")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "1st Base" && position[num] == "1B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "2nd Base" && position[num] == "2B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Short Stop" && position[num] == "SS")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "3rd Base" && position[num] == "3B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Left Field" && position[num] == "LF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Center Field" && position[num] == "CF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Right Field" && position[num] == "RF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Designated Hitter" && position[num] == "DH")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "All Positions")
                                    {
                                        printHitters();
                                    }
                                }
                                if (lbMLBTeams.Text == "Atlanta Braves" && team[num] == "ATL")
                                {
                                    if (lbHitterPosition.Text == "Catcher" && position[num] == "C")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "1st Base" && position[num] == "1B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "2nd Base" && position[num] == "2B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Short Stop" && position[num] == "SS")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "3rd Base" && position[num] == "3B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Left Field" && position[num] == "LF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Center Field" && position[num] == "CF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Right Field" && position[num] == "RF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Designated Hitter" && position[num] == "DH")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "All Positions")
                                    {
                                        printHitters();
                                    }
                                }
                                if (lbMLBTeams.Text == "Miami Marlins" && team[num] == "MIA")
                                {
                                    if (lbHitterPosition.Text == "Catcher" && position[num] == "C")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "1st Base" && position[num] == "1B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "2nd Base" && position[num] == "2B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Short Stop" && position[num] == "SS")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "3rd Base" && position[num] == "3B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Left Field" && position[num] == "LF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Center Field" && position[num] == "CF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Right Field" && position[num] == "RF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Designated Hitter" && position[num] == "DH")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "All Positions")
                                    {
                                        printHitters();
                                    }
                                }
                                if (lbMLBTeams.Text == "New York Mets" && team[num] == "NYM")
                                {
                                    if (lbHitterPosition.Text == "Catcher" && position[num] == "C")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "1st Base" && position[num] == "1B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "2nd Base" && position[num] == "2B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Short Stop" && position[num] == "SS")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "3rd Base" && position[num] == "3B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Left Field" && position[num] == "LF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Center Field" && position[num] == "CF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Right Field" && position[num] == "RF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Designated Hitter" && position[num] == "DH")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "All Positions")
                                    {
                                        printHitters();
                                    }
                                }
                                if (lbMLBTeams.Text == "Philadelphia Phillies" && team[num] == "PHI")
                                {
                                    if (lbHitterPosition.Text == "Catcher" && position[num] == "C")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "1st Base" && position[num] == "1B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "2nd Base" && position[num] == "2B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Short Stop" && position[num] == "SS")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "3rd Base" && position[num] == "3B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Left Field" && position[num] == "LF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Center Field" && position[num] == "CF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Right Field" && position[num] == "RF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Designated Hitter" && position[num] == "DH")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "All Positions")
                                    {
                                        printHitters();
                                    }
                                }
                                if (lbMLBTeams.Text == "Washington Nationals" && team[num] == "WSN")
                                {
                                    if (lbHitterPosition.Text == "Catcher" && position[num] == "C")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "1st Base" && position[num] == "1B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "2nd Base" && position[num] == "2B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Short Stop" && position[num] == "SS")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "3rd Base" && position[num] == "3B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Left Field" && position[num] == "LF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Center Field" && position[num] == "CF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Right Field" && position[num] == "RF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Designated Hitter" && position[num] == "DH")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "All Positions")
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
                                if (lbMLBTeams.Text == "All Teams")
                                {
                                    if (lbHitterPosition.Text == "Catcher" && position[num] == "C")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "1st Base" && position[num] == "1B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "2nd Base" && position[num] == "2B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Short Stop" && position[num] == "SS")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "3rd Base" && position[num] == "3B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Left Field" && position[num] == "LF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Center Field" && position[num] == "CF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Right Field" && position[num] == "RF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Designated Hitter" && position[num] == "DH")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "All Positions")
                                    {
                                        printHitters();
                                    }
                                }
                                if (lbMLBTeams.Text == "Chicago White Sox" && team[num] == "CWS")
                                {
                                    if (lbHitterPosition.Text == "Catcher" && position[num] == "C")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "1st Base" && position[num] == "1B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "2nd Base" && position[num] == "2B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Short Stop" && position[num] == "SS")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "3rd Base" && position[num] == "3B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Left Field" && position[num] == "LF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Center Field" && position[num] == "CF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Right Field" && position[num] == "RF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Designated Hitter" && position[num] == "DH")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "All Positions")
                                    {
                                        printHitters();
                                    }
                                }
                                if (lbMLBTeams.Text == "Cleveland Guardians" && team[num] == "CLE")
                                {
                                    if (lbHitterPosition.Text == "Catcher" && position[num] == "C")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "1st Base" && position[num] == "1B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "2nd Base" && position[num] == "2B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Short Stop" && position[num] == "SS")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "3rd Base" && position[num] == "3B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Left Field" && position[num] == "LF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Center Field" && position[num] == "CF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Right Field" && position[num] == "RF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Designated Hitter" && position[num] == "DH")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "All Positions")
                                    {
                                        printHitters();
                                    }
                                }
                                if (lbMLBTeams.Text == "Detroit Tigers" && team[num] == "DET")
                                {
                                    if (lbHitterPosition.Text == "Catcher" && position[num] == "C")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "1st Base" && position[num] == "1B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "2nd Base" && position[num] == "2B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Short Stop" && position[num] == "SS")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "3rd Base" && position[num] == "3B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Left Field" && position[num] == "LF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Center Field" && position[num] == "CF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Right Field" && position[num] == "RF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Designated Hitter" && position[num] == "DH")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "All Positions")
                                    {
                                        printHitters();
                                    }
                                }
                                if (lbMLBTeams.Text == "Kansas City Royals" && team[num] == "KCR")
                                {
                                    if (lbHitterPosition.Text == "Catcher" && position[num] == "C")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "1st Base" && position[num] == "1B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "2nd Base" && position[num] == "2B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Short Stop" && position[num] == "SS")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "3rd Base" && position[num] == "3B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Left Field" && position[num] == "LF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Center Field" && position[num] == "CF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Right Field" && position[num] == "RF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Designated Hitter" && position[num] == "DH")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "All Positions")
                                    {
                                        printHitters();
                                    }
                                }
                                if (lbMLBTeams.Text == "Minnesota Twins" && team[num] == "MIN")
                                {
                                    if (lbHitterPosition.Text == "Catcher" && position[num] == "C")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "1st Base" && position[num] == "1B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "2nd Base" && position[num] == "2B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Short Stop" && position[num] == "SS")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "3rd Base" && position[num] == "3B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Left Field" && position[num] == "LF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Center Field" && position[num] == "CF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Right Field" && position[num] == "RF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Designated Hitter" && position[num] == "DH")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "All Positions")
                                    {
                                        printHitters();
                                    }
                                }
                                if (lbMLBTeams.Text == "Cincinnati Reds" && team[num] == "CIN")
                                {
                                    if (lbHitterPosition.Text == "Catcher" && position[num] == "C")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "1st Base" && position[num] == "1B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "2nd Base" && position[num] == "2B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Short Stop" && position[num] == "SS")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "3rd Base" && position[num] == "3B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Left Field" && position[num] == "LF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Center Field" && position[num] == "CF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Right Field" && position[num] == "RF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Designated Hitter" && position[num] == "DH")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "All Positions")
                                    {
                                        printHitters();
                                    }
                                }
                                if (lbMLBTeams.Text == "Chicago Cubs" && team[num] == "CHC")
                                {
                                    if (lbHitterPosition.Text == "Catcher" && position[num] == "C")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "1st Base" && position[num] == "1B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "2nd Base" && position[num] == "2B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Short Stop" && position[num] == "SS")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "3rd Base" && position[num] == "3B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Left Field" && position[num] == "LF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Center Field" && position[num] == "CF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Right Field" && position[num] == "RF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Designated Hitter" && position[num] == "DH")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "All Positions")
                                    {
                                        printHitters();
                                    }
                                }
                                if (lbMLBTeams.Text == "Milwaukee Brewers" && team[num] == "MIL")
                                {
                                    if (lbHitterPosition.Text == "Catcher" && position[num] == "C")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "1st Base" && position[num] == "1B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "2nd Base" && position[num] == "2B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Short Stop" && position[num] == "SS")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "3rd Base" && position[num] == "3B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Left Field" && position[num] == "LF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Center Field" && position[num] == "CF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Right Field" && position[num] == "RF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Designated Hitter" && position[num] == "DH")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "All Positions")
                                    {
                                        printHitters();
                                    }
                                }
                                if (lbMLBTeams.Text == "Pittsburgh Pirates" && team[num] == "PIT")
                                {
                                    if (lbHitterPosition.Text == "Catcher" && position[num] == "C")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "1st Base" && position[num] == "1B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "2nd Base" && position[num] == "2B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Short Stop" && position[num] == "SS")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "3rd Base" && position[num] == "3B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Left Field" && position[num] == "LF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Center Field" && position[num] == "CF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Right Field" && position[num] == "RF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Designated Hitter" && position[num] == "DH")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "All Positions")
                                    {
                                        printHitters();
                                    }
                                }
                                if (lbMLBTeams.Text == "St. Louis" && team[num] == "STL")
                                {
                                    if (lbHitterPosition.Text == "Catcher" && position[num] == "C")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "1st Base" && position[num] == "1B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "2nd Base" && position[num] == "2B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Short Stop" && position[num] == "SS")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "3rd Base" && position[num] == "3B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Left Field" && position[num] == "LF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Center Field" && position[num] == "CF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Right Field" && position[num] == "RF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Designated Hitter" && position[num] == "DH")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "All Positions")
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
                                if (lbMLBTeams.Text == "All Teams")
                                {
                                    if (lbHitterPosition.Text == "Catcher" && position[num] == "C")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "1st Base" && position[num] == "1B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "2nd Base" && position[num] == "2B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Short Stop" && position[num] == "SS")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "3rd Base" && position[num] == "3B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Left Field" && position[num] == "LF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Center Field" && position[num] == "CF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Right Field" && position[num] == "RF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Designated Hitter" && position[num] == "DH")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "All Positions")
                                    {
                                        printHitters();
                                    }
                                }
                                if (lbMLBTeams.Text == "Houston Astros" && team[num] == "HOU")
                                {
                                    if (lbHitterPosition.Text == "Catcher" && position[num] == "C")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "1st Base" && position[num] == "1B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "2nd Base" && position[num] == "2B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Short Stop" && position[num] == "SS")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "3rd Base" && position[num] == "3B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Left Field" && position[num] == "LF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Center Field" && position[num] == "CF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Right Field" && position[num] == "RF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Designated Hitter" && position[num] == "DH")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "All Positions")
                                    {
                                        printHitters();
                                    }
                                }
                                if (lbMLBTeams.Text == "Los Angeles Angels" && team[num] == "LAA")
                                {
                                    if (lbHitterPosition.Text == "Catcher" && position[num] == "C")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "1st Base" && position[num] == "1B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "2nd Base" && position[num] == "2B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Short Stop" && position[num] == "SS")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "3rd Base" && position[num] == "3B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Left Field" && position[num] == "LF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Center Field" && position[num] == "CF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Right Field" && position[num] == "RF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Designated Hitter" && position[num] == "DH")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "All Positions")
                                    {
                                        printHitters();
                                    }
                                }
                                if (lbMLBTeams.Text == "Oakland Athletics" && team[num] == "OAK")
                                {
                                    if (lbHitterPosition.Text == "Catcher" && position[num] == "C")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "1st Base" && position[num] == "1B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "2nd Base" && position[num] == "2B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Short Stop" && position[num] == "SS")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "3rd Base" && position[num] == "3B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Left Field" && position[num] == "LF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Center Field" && position[num] == "CF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Right Field" && position[num] == "RF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Designated Hitter" && position[num] == "DH")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "All Positions")
                                    {
                                        printHitters();
                                    }
                                }
                                if (lbMLBTeams.Text == "Seattle Mariners" && team[num] == "SEA")
                                {
                                    if (lbHitterPosition.Text == "Catcher" && position[num] == "C")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "1st Base" && position[num] == "1B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "2nd Base" && position[num] == "2B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Short Stop" && position[num] == "SS")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "3rd Base" && position[num] == "3B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Left Field" && position[num] == "LF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Center Field" && position[num] == "CF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Right Field" && position[num] == "RF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Designated Hitter" && position[num] == "DH")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "All Positions")
                                    {
                                        printHitters();
                                    }
                                }
                                if (lbMLBTeams.Text == "Texas Rangers" && team[num] == "TEX")
                                {
                                    if (lbHitterPosition.Text == "Catcher" && position[num] == "C")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "1st Base" && position[num] == "1B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "2nd Base" && position[num] == "2B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Short Stop" && position[num] == "SS")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "3rd Base" && position[num] == "3B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Left Field" && position[num] == "LF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Center Field" && position[num] == "CF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Right Field" && position[num] == "RF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Designated Hitter" && position[num] == "DH")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "All Positions")
                                    {
                                        printHitters();
                                    }
                                }
                                if (lbMLBTeams.Text == "Arizona Diamondbacks" && team[num] == "ARI")
                                {
                                    if (lbHitterPosition.Text == "Catcher" && position[num] == "C")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "1st Base" && position[num] == "1B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "2nd Base" && position[num] == "2B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Short Stop" && position[num] == "SS")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "3rd Base" && position[num] == "3B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Left Field" && position[num] == "LF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Center Field" && position[num] == "CF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Right Field" && position[num] == "RF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Designated Hitter" && position[num] == "DH")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "All Positions")
                                    {
                                        printHitters();
                                    }
                                }
                                if (lbMLBTeams.Text == "Colorado Rockies" && team[num] == "COL")
                                {
                                    if (lbHitterPosition.Text == "Catcher" && position[num] == "C")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "1st Base" && position[num] == "1B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "2nd Base" && position[num] == "2B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Short Stop" && position[num] == "SS")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "3rd Base" && position[num] == "3B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Left Field" && position[num] == "LF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Center Field" && position[num] == "CF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Right Field" && position[num] == "RF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Designated Hitter" && position[num] == "DH")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "All Positions")
                                    {
                                        printHitters();
                                    }
                                }
                                if (lbMLBTeams.Text == "Los Angeles Dodgers" && team[num] == "LAD")
                                {
                                    if (lbHitterPosition.Text == "Catcher" && position[num] == "C")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "1st Base" && position[num] == "1B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "2nd Base" && position[num] == "2B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Short Stop" && position[num] == "SS")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "3rd Base" && position[num] == "3B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Left Field" && position[num] == "LF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Center Field" && position[num] == "CF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Right Field" && position[num] == "RF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Designated Hitter" && position[num] == "DH")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "All Positions")
                                    {
                                        printHitters();
                                    }
                                }
                                if (lbMLBTeams.Text == "San Francisco Giants" && team[num] == "SFG")
                                {
                                    if (lbHitterPosition.Text == "Catcher" && position[num] == "C")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "1st Base" && position[num] == "1B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "2nd Base" && position[num] == "2B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Short Stop" && position[num] == "SS")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "3rd Base" && position[num] == "3B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Left Field" && position[num] == "LF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Center Field" && position[num] == "CF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Right Field" && position[num] == "RF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Designated Hitter" && position[num] == "DH")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "All Positions")
                                    {
                                        printHitters();
                                    }
                                }
                                if (lbMLBTeams.Text == "San Diego Padres" && team[num] == "SDP")
                                {
                                    if (lbHitterPosition.Text == "Catcher" && position[num] == "C")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "1st Base" && position[num] == "1B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "2nd Base" && position[num] == "2B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Short Stop" && position[num] == "SS")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "3rd Base" && position[num] == "3B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Left Field" && position[num] == "LF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Center Field" && position[num] == "CF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Right Field" && position[num] == "RF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Designated Hitter" && position[num] == "DH")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "All Positions")
                                    {
                                        printHitters();
                                    }
                                }
                            }
                        }
                    else if (radEast.Checked && radAL.Checked)
                        {
                            if (league[num] == "AL" && division[num] == "E")
                            {
                                if (lbMLBTeams.Text == "All Teams")
                                {
                                    if (lbHitterPosition.Text == "Catcher" && position[num] == "C")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "1st Base" && position[num] == "1B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "2nd Base" && position[num] == "2B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Short Stop" && position[num] == "SS")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "3rd Base" && position[num] == "3B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Left Field" && position[num] == "LF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Center Field" && position[num] == "CF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Right Field" && position[num] == "RF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Designated Hitter" && position[num] == "DH")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "All Positions")
                                    {
                                        printHitters();
                                    }
                                }
                                if (lbMLBTeams.Text == "Baltimore Orioles" && team[num] == "BAL")
                                {
                                    if (lbHitterPosition.Text == "Catcher" && position[num] == "C")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "1st Base" && position[num] == "1B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "2nd Base" && position[num] == "2B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Short Stop" && position[num] == "SS")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "3rd Base" && position[num] == "3B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Left Field" && position[num] == "LF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Center Field" && position[num] == "CF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Right Field" && position[num] == "RF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Designated Hitter" && position[num] == "DH")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "All Positions")
                                    {
                                        printHitters();
                                    }
                                }
                                if (lbMLBTeams.Text == "Boston Red Sox" && team[num] == "BOS")
                                {
                                    if (lbHitterPosition.Text == "Catcher" && position[num] == "C")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "1st Base" && position[num] == "1B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "2nd Base" && position[num] == "2B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Short Stop" && position[num] == "SS")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "3rd Base" && position[num] == "3B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Left Field" && position[num] == "LF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Center Field" && position[num] == "CF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Right Field" && position[num] == "RF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Designated Hitter" && position[num] == "DH")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "All Positions")
                                    {
                                        printHitters();
                                    }
                                }
                                if (lbMLBTeams.Text == "New York Yankees" && team[num] == "NYY")
                                {
                                    if (lbHitterPosition.Text == "Catcher" && position[num] == "C")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "1st Base" && position[num] == "1B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "2nd Base" && position[num] == "2B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Short Stop" && position[num] == "SS")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "3rd Base" && position[num] == "3B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Left Field" && position[num] == "LF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Center Field" && position[num] == "CF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Right Field" && position[num] == "RF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Designated Hitter" && position[num] == "DH")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "All Positions")
                                    {
                                        printHitters();
                                    }
                                }
                                if (lbMLBTeams.Text == "Tampa Bay Rays" && team[num] == "TBR")
                                {
                                    if (lbHitterPosition.Text == "Catcher" && position[num] == "C")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "1st Base" && position[num] == "1B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "2nd Base" && position[num] == "2B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Short Stop" && position[num] == "SS")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "3rd Base" && position[num] == "3B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Left Field" && position[num] == "LF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Center Field" && position[num] == "CF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Right Field" && position[num] == "RF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Designated Hitter" && position[num] == "DH")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "All Positions")
                                    {
                                        printHitters();
                                    }
                                }
                                if (lbMLBTeams.Text == "Toronto Blue Jays" && team[num] == "TOR")
                                {
                                    if (lbHitterPosition.Text == "Catcher" && position[num] == "C")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "1st Base" && position[num] == "1B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "2nd Base" && position[num] == "2B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Short Stop" && position[num] == "SS")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "3rd Base" && position[num] == "3B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Left Field" && position[num] == "LF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Center Field" && position[num] == "CF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Right Field" && position[num] == "RF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Designated Hitter" && position[num] == "DH")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "All Positions")
                                    {
                                        printHitters();
                                    }
                                }
                            }
                        }
                    else if (radCentral.Checked && radAL.Checked)
                        {
                            if (league[num] == "AL" && division[num] == "C")
                            {
                                if (lbMLBTeams.Text == "Chicago White Sox" && team[num] == "CWS")
                                {
                                    if (lbHitterPosition.Text == "Catcher" && position[num] == "C")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "1st Base" && position[num] == "1B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "2nd Base" && position[num] == "2B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Short Stop" && position[num] == "SS")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "3rd Base" && position[num] == "3B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Left Field" && position[num] == "LF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Center Field" && position[num] == "CF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Right Field" && position[num] == "RF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Designated Hitter" && position[num] == "DH")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "All Positions")
                                    {
                                        printHitters();
                                    }
                                }
                                if (lbMLBTeams.Text == "Cleveland Guardians" && team[num] == "CLE")
                                {
                                    if (lbHitterPosition.Text == "Catcher" && position[num] == "C")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "1st Base" && position[num] == "1B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "2nd Base" && position[num] == "2B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Short Stop" && position[num] == "SS")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "3rd Base" && position[num] == "3B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Left Field" && position[num] == "LF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Center Field" && position[num] == "CF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Right Field" && position[num] == "RF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Designated Hitter" && position[num] == "DH")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "All Positions")
                                    {
                                        printHitters();
                                    }
                                }
                                if (lbMLBTeams.Text == "Detroit Tigers" && team[num] == "DET")
                                {
                                    if (lbHitterPosition.Text == "Catcher" && position[num] == "C")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "1st Base" && position[num] == "1B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "2nd Base" && position[num] == "2B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Short Stop" && position[num] == "SS")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "3rd Base" && position[num] == "3B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Left Field" && position[num] == "LF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Center Field" && position[num] == "CF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Right Field" && position[num] == "RF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Designated Hitter" && position[num] == "DH")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "All Positions")
                                    {
                                        printHitters();
                                    }
                                }
                                if (lbMLBTeams.Text == "Kansas City Royals" && team[num] == "KCR")
                                {
                                    if (lbHitterPosition.Text == "Catcher" && position[num] == "C")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "1st Base" && position[num] == "1B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "2nd Base" && position[num] == "2B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Short Stop" && position[num] == "SS")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "3rd Base" && position[num] == "3B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Left Field" && position[num] == "LF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Center Field" && position[num] == "CF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Right Field" && position[num] == "RF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Designated Hitter" && position[num] == "DH")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "All Positions")
                                    {
                                        printHitters();
                                    }
                                }
                                if (lbMLBTeams.Text == "Minnesota Twins" && team[num] == "MIN")
                                {
                                    if (lbHitterPosition.Text == "Catcher" && position[num] == "C")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "1st Base" && position[num] == "1B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "2nd Base" && position[num] == "2B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Short Stop" && position[num] == "SS")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "3rd Base" && position[num] == "3B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Left Field" && position[num] == "LF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Center Field" && position[num] == "CF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Right Field" && position[num] == "RF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Designated Hitter" && position[num] == "DH")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "All Positions")
                                    {
                                        printHitters();
                                    }
                                }
                                if (lbMLBTeams.Text == "All Teams")
                                {
                                    if (lbHitterPosition.Text == "Catcher" && position[num] == "C")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "1st Base" && position[num] == "1B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "2nd Base" && position[num] == "2B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Short Stop" && position[num] == "SS")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "3rd Base" && position[num] == "3B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Left Field" && position[num] == "LF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Center Field" && position[num] == "CF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Right Field" && position[num] == "RF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Designated Hitter" && position[num] == "DH")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "All Positions")
                                    {
                                        printHitters();
                                    }
                                }
                            }
                        }
                    else if (radWest.Checked && radAL.Checked)
                        {
                            if (league[num] == "AL" && division[num] == "W")
                            {
                                if (lbMLBTeams.Text == "Houston Astros" && team[num] == "HOU")
                                {
                                    if (lbHitterPosition.Text == "Catcher" && position[num] == "C")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "1st Base" && position[num] == "1B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "2nd Base" && position[num] == "2B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Short Stop" && position[num] == "SS")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "3rd Base" && position[num] == "3B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Left Field" && position[num] == "LF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Center Field" && position[num] == "CF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Right Field" && position[num] == "RF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Designated Hitter" && position[num] == "DH")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "All Positions")
                                    {
                                        printHitters();
                                    }
                                }
                                if (lbMLBTeams.Text == "Los Angeles Angels" && team[num] == "LAA")
                                {
                                    if (lbHitterPosition.Text == "Catcher" && position[num] == "C")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "1st Base" && position[num] == "1B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "2nd Base" && position[num] == "2B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Short Stop" && position[num] == "SS")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "3rd Base" && position[num] == "3B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Left Field" && position[num] == "LF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Center Field" && position[num] == "CF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Right Field" && position[num] == "RF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Designated Hitter" && position[num] == "DH")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "All Positions")
                                    {
                                        printHitters();
                                    }
                                }
                                if (lbMLBTeams.Text == "Oakland Athletics" && team[num] == "OAK")
                                {
                                    if (lbHitterPosition.Text == "Catcher" && position[num] == "C")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "1st Base" && position[num] == "1B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "2nd Base" && position[num] == "2B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Short Stop" && position[num] == "SS")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "3rd Base" && position[num] == "3B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Left Field" && position[num] == "LF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Center Field" && position[num] == "CF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Right Field" && position[num] == "RF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Designated Hitter" && position[num] == "DH")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "All Positions")
                                    {
                                        printHitters();
                                    }
                                }
                                if (lbMLBTeams.Text == "Seattle Mariners" && team[num] == "SEA")
                                {
                                    if (lbHitterPosition.Text == "Catcher" && position[num] == "C")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "1st Base" && position[num] == "1B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "2nd Base" && position[num] == "2B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Short Stop" && position[num] == "SS")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "3rd Base" && position[num] == "3B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Left Field" && position[num] == "LF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Center Field" && position[num] == "CF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Right Field" && position[num] == "RF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Designated Hitter" && position[num] == "DH")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "All Positions")
                                    {
                                        printHitters();
                                    }
                                }
                                if (lbMLBTeams.Text == "Texas Rangers" && team[num] == "TEX")
                                {
                                    if (lbHitterPosition.Text == "Catcher" && position[num] == "C")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "1st Base" && position[num] == "1B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "2nd Base" && position[num] == "2B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Short Stop" && position[num] == "SS")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "3rd Base" && position[num] == "3B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Left Field" && position[num] == "LF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Center Field" && position[num] == "CF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Right Field" && position[num] == "RF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Designated Hitter" && position[num] == "DH")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "All Positions")
                                    {
                                        printHitters();
                                    }
                                }
                                if (lbMLBTeams.Text == "All Teams")
                                {
                                    if (lbHitterPosition.Text == "Catcher" && position[num] == "C")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "1st Base" && position[num] == "1B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "2nd Base" && position[num] == "2B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Short Stop" && position[num] == "SS")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "3rd Base" && position[num] == "3B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Left Field" && position[num] == "LF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Center Field" && position[num] == "CF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Right Field" && position[num] == "RF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Designated Hitter" && position[num] == "DH")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "All Positions")
                                    {
                                        printHitters();
                                    }
                                }
                            }
                        }
                    else if (radEast.Checked && radNL.Checked)
                        {
                            if (league[num] == "NL" && division[num] == "E")
                            {
                                if (lbMLBTeams.Text == "All Teams")
                                {
                                    if (lbHitterPosition.Text == "Catcher" && position[num] == "C")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "1st Base" && position[num] == "1B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "2nd Base" && position[num] == "2B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Short Stop" && position[num] == "SS")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "3rd Base" && position[num] == "3B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Left Field" && position[num] == "LF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Center Field" && position[num] == "CF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Right Field" && position[num] == "RF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Designated Hitter" && position[num] == "DH")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "All Positions")
                                    {
                                        printHitters();
                                    }
                                }
                                if (lbMLBTeams.Text == "Atlanta Braves" && team[num] == "ATL")
                                {
                                    if (lbHitterPosition.Text == "Catcher" && position[num] == "C")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "1st Base" && position[num] == "1B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "2nd Base" && position[num] == "2B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Short Stop" && position[num] == "SS")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "3rd Base" && position[num] == "3B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Left Field" && position[num] == "LF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Center Field" && position[num] == "CF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Right Field" && position[num] == "RF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Designated Hitter" && position[num] == "DH")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "All Positions")
                                    {
                                        printHitters();
                                    }
                                }
                                if (lbMLBTeams.Text == "Miami Marlins" && team[num] == "MIA")
                                {
                                    if (lbHitterPosition.Text == "Catcher" && position[num] == "C")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "1st Base" && position[num] == "1B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "2nd Base" && position[num] == "2B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Short Stop" && position[num] == "SS")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "3rd Base" && position[num] == "3B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Left Field" && position[num] == "LF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Center Field" && position[num] == "CF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Right Field" && position[num] == "RF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Designated Hitter" && position[num] == "DH")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "All Positions")
                                    {
                                        printHitters();
                                    }
                                }
                                if (lbMLBTeams.Text == "New York Mets" && team[num] == "NYM")
                                {
                                    if (lbHitterPosition.Text == "Catcher" && position[num] == "C")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "1st Base" && position[num] == "1B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "2nd Base" && position[num] == "2B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Short Stop" && position[num] == "SS")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "3rd Base" && position[num] == "3B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Left Field" && position[num] == "LF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Center Field" && position[num] == "CF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Right Field" && position[num] == "RF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Designated Hitter" && position[num] == "DH")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "All Positions")
                                    {
                                        printHitters();
                                    }
                                }
                                if (lbMLBTeams.Text == "Philadelphia Phillies" && team[num] == "PHI")
                                {
                                    if (lbHitterPosition.Text == "Catcher" && position[num] == "C")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "1st Base" && position[num] == "1B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "2nd Base" && position[num] == "2B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Short Stop" && position[num] == "SS")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "3rd Base" && position[num] == "3B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Left Field" && position[num] == "LF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Center Field" && position[num] == "CF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Right Field" && position[num] == "RF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Designated Hitter" && position[num] == "DH")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "All Positions")
                                    {
                                        printHitters();
                                    }
                                }
                                if (lbMLBTeams.Text == "Washington Nationals" && team[num] == "WSN")
                                {
                                    if (lbHitterPosition.Text == "Catcher" && position[num] == "C")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "1st Base" && position[num] == "1B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "2nd Base" && position[num] == "2B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Short Stop" && position[num] == "SS")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "3rd Base" && position[num] == "3B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Left Field" && position[num] == "LF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Center Field" && position[num] == "CF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Right Field" && position[num] == "RF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Designated Hitter" && position[num] == "DH")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "All Positions")
                                    {
                                        printHitters();
                                    }
                                }
                            }
                        }
                    else if (radWest.Checked && radNL.Checked)
                        {
                            if (league[num] == "NL" && division[num] == "W")
                            {
                                if (lbMLBTeams.Text == "All Teams")
                                {
                                    if (lbHitterPosition.Text == "Catcher" && position[num] == "C")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "1st Base" && position[num] == "1B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "2nd Base" && position[num] == "2B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Short Stop" && position[num] == "SS")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "3rd Base" && position[num] == "3B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Left Field" && position[num] == "LF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Center Field" && position[num] == "CF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Right Field" && position[num] == "RF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Designated Hitter" && position[num] == "DH")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "All Positions")
                                    {
                                        printHitters();
                                    }
                                }
                                if (lbMLBTeams.Text == "Arizona Diamondbacks" && team[num] == "ARI")
                                {
                                    if (lbHitterPosition.Text == "Catcher" && position[num] == "C")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "1st Base" && position[num] == "1B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "2nd Base" && position[num] == "2B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Short Stop" && position[num] == "SS")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "3rd Base" && position[num] == "3B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Left Field" && position[num] == "LF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Center Field" && position[num] == "CF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Right Field" && position[num] == "RF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Designated Hitter" && position[num] == "DH")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "All Positions")
                                    {
                                        printHitters();
                                    }
                                }
                                if (lbMLBTeams.Text == "Colorado Rockies" && team[num] == "COL")
                                {
                                    if (lbHitterPosition.Text == "Catcher" && position[num] == "C")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "1st Base" && position[num] == "1B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "2nd Base" && position[num] == "2B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Short Stop" && position[num] == "SS")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "3rd Base" && position[num] == "3B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Left Field" && position[num] == "LF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Center Field" && position[num] == "CF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Right Field" && position[num] == "RF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Designated Hitter" && position[num] == "DH")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "All Positions")
                                    {
                                        printHitters();
                                    }
                                }
                                if (lbMLBTeams.Text == "Los Angeles Dodgers" && team[num] == "LAD")
                                {
                                    if (lbHitterPosition.Text == "Catcher" && position[num] == "C")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "1st Base" && position[num] == "1B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "2nd Base" && position[num] == "2B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Short Stop" && position[num] == "SS")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "3rd Base" && position[num] == "3B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Left Field" && position[num] == "LF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Center Field" && position[num] == "CF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Right Field" && position[num] == "RF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Designated Hitter" && position[num] == "DH")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "All Positions")
                                    {
                                        printHitters();
                                    }
                                }
                                if (lbMLBTeams.Text == "San Francisco Giants" && team[num] == "SFG")
                                {
                                    if (lbHitterPosition.Text == "Catcher" && position[num] == "C")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "1st Base" && position[num] == "1B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "2nd Base" && position[num] == "2B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Short Stop" && position[num] == "SS")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "3rd Base" && position[num] == "3B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Left Field" && position[num] == "LF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Center Field" && position[num] == "CF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Right Field" && position[num] == "RF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Designated Hitter" && position[num] == "DH")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "All Positions")
                                    {
                                        printHitters();
                                    }
                                }
                                if (lbMLBTeams.Text == "San Diego Padres" && team[num] == "SDP")
                                {
                                    if (lbHitterPosition.Text == "Catcher" && position[num] == "C")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "1st Base" && position[num] == "1B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "2nd Base" && position[num] == "2B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Short Stop" && position[num] == "SS")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "3rd Base" && position[num] == "3B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Left Field" && position[num] == "LF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Center Field" && position[num] == "CF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Right Field" && position[num] == "RF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Designated Hitter" && position[num] == "DH")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "All Positions")
                                    {
                                        printHitters();
                                    }
                                }
                            }
                        }
                    else if (radCentral.Checked && radNL.Checked)
                        {
                            if (league[num] == "NL" && division[num] == "C")
                            {
                                if (lbMLBTeams.Text == "All Teams")
                                {
                                    if (lbHitterPosition.Text == "Catcher" && position[num] == "C")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "1st Base" && position[num] == "1B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "2nd Base" && position[num] == "2B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Short Stop" && position[num] == "SS")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "3rd Base" && position[num] == "3B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Left Field" && position[num] == "LF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Center Field" && position[num] == "CF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Right Field" && position[num] == "RF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Designated Hitter" && position[num] == "DH")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "All Positions")
                                    {
                                        printHitters();
                                    }
                                }
                                if (lbMLBTeams.Text == "Cincinnati Reds" && team[num] == "CIN")
                                {
                                    if (lbHitterPosition.Text == "Catcher" && position[num] == "C")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "1st Base" && position[num] == "1B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "2nd Base" && position[num] == "2B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Short Stop" && position[num] == "SS")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "3rd Base" && position[num] == "3B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Left Field" && position[num] == "LF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Center Field" && position[num] == "CF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Right Field" && position[num] == "RF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Designated Hitter" && position[num] == "DH")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "All Positions")
                                    {
                                        printHitters();
                                    }
                                }
                                if (lbMLBTeams.Text == "Chicago Cubs" && team[num] == "CHC")
                                {
                                    if (lbHitterPosition.Text == "Catcher" && position[num] == "C")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "1st Base" && position[num] == "1B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "2nd Base" && position[num] == "2B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Short Stop" && position[num] == "SS")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "3rd Base" && position[num] == "3B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Left Field" && position[num] == "LF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Center Field" && position[num] == "CF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Right Field" && position[num] == "RF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Designated Hitter" && position[num] == "DH")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "All Positions")
                                    {
                                        printHitters();
                                    }
                                }
                                if (lbMLBTeams.Text == "Milwaukee Brewers" && team[num] == "MIL")
                                {
                                    if (lbHitterPosition.Text == "Catcher" && position[num] == "C")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "1st Base" && position[num] == "1B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "2nd Base" && position[num] == "2B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Short Stop" && position[num] == "SS")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "3rd Base" && position[num] == "3B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Left Field" && position[num] == "LF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Center Field" && position[num] == "CF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Right Field" && position[num] == "RF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Designated Hitter" && position[num] == "DH")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "All Positions")
                                    {
                                        printHitters();
                                    }
                                }
                                if (lbMLBTeams.Text == "Pittsburgh Pirates" && team[num] == "PIT")
                                {
                                    if (lbHitterPosition.Text == "Catcher" && position[num] == "C")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "1st Base" && position[num] == "1B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "2nd Base" && position[num] == "2B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Short Stop" && position[num] == "SS")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "3rd Base" && position[num] == "3B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Left Field" && position[num] == "LF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Center Field" && position[num] == "CF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Right Field" && position[num] == "RF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Designated Hitter" && position[num] == "DH")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "All Positions")
                                    {
                                        printHitters();
                                    }
                                }
                                if (lbMLBTeams.Text == "St. Louis" && team[num] == "STL")
                                {
                                    if (lbHitterPosition.Text == "Catcher" && position[num] == "C")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "1st Base" && position[num] == "1B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "2nd Base" && position[num] == "2B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Short Stop" && position[num] == "SS")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "3rd Base" && position[num] == "3B")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Left Field" && position[num] == "LF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Center Field" && position[num] == "CF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Right Field" && position[num] == "RF")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "Designated Hitter" && position[num] == "DH")
                                    {
                                        printHitters();
                                    }
                                    else if (lbHitterPosition.Text == "All Positions")
                                    {
                                        printHitters();
                                    }
                                }
                            }
                        }                   
                }
                num++;
            }
            else if (radPitchers.Checked)
            {
                rtbLabels.AppendText("Team Player              ");

                double er = 0;
                double ip = 0;
                double earnedRunAverage = 0;
                double w = 0;
                double l = 0;
                double bb = 0;
                double ph = 0;
                double homeruns;
                double k = 0;

                string path = @"Pitchers.csv";
                StreamReader textIn = new StreamReader(
                new FileStream(path, FileMode.Open, FileAccess.Read));

                labelCheck();

                while (textIn.Peek() != -1)
                {
                    Array.Resize<string>(ref pTeam, pTeam.Length + 1);
                    Array.Resize<string>(ref pName, pName.Length + 1);
                    Array.Resize<string>(ref pDivisions, pDivisions.Length + 1);
                    Array.Resize<string>(ref pLeague, pLeague.Length + 1);
                    Array.Resize<string>(ref pStaff, pStaff.Length + 1);

                    string row = textIn.ReadLine();
                    string[] record = row.Split(',');
                    pTeam[num] = Convert.ToString(record[2]).ToUpper();
                    pName[num] = Convert.ToString(record[3]).ToUpper();
                    pDivisions[num] = Convert.ToString(record[1]).ToUpper();
                    pLeague[num] = Convert.ToString(record[0]).ToUpper();
                    pStaff[num] = Convert.ToString(record[4]).ToUpper();

                    Array.Resize<double>(ref Wins, Wins.Length + 1);
                    Wins[num] = Convert.ToDouble(record[5]);
                    w = Convert.ToDouble(record[5]);

                    Array.Resize<double>(ref Losses, Losses.Length + 1);
                    Losses[num] = Convert.ToDouble(record[6]); 
                    l = Convert.ToDouble(record[6]);

                    Array.Resize<double>(ref Games, Games.Length + 1);
                    Games[num] = Convert.ToDouble(record[7]);

                    Array.Resize<double>(ref GamesStarted, GamesStarted.Length + 1);
                    GamesStarted[num] = Convert.ToDouble(record[8]);

                    Array.Resize<double>(ref Saves, Saves.Length + 1);
                    Saves[num] = Convert.ToDouble(record[9]);

                    Array.Resize<double>(ref InningsPitched, InningsPitched.Length + 1);
                    InningsPitched[num] = Convert.ToDouble(record[10]);
                    ip = Convert.ToDouble(record[10]);

                    Array.Resize<double>(ref pHits, pHits.Length + 1);
                    pHits[num] = Convert.ToDouble(record[11]);
                    ph = Convert.ToDouble(record[11]);

                    Array.Resize<double>(ref pRuns, pRuns.Length + 1);
                    pRuns[num] = Convert.ToDouble(record[12]);

                    Array.Resize<double>(ref EarnedRuns, EarnedRuns.Length + 1);
                    EarnedRuns[num] = Convert.ToDouble(record[13]);
                    er = Convert.ToDouble(record[13]);

                    Array.Resize<double>(ref pHomeruns, pHomeruns.Length + 1);
                    pHomeruns[num] = Convert.ToDouble(record[14]);
                    homeruns = Convert.ToDouble(record[14]);

                    Array.Resize<double>(ref pWalks, pWalks.Length + 1);
                    pWalks[num] = Convert.ToDouble(record[15]);
                    bb = Convert.ToDouble(record[15]);

                    Array.Resize<double>(ref pIntentionalWalks, pIntentionalWalks.Length + 1);
                    pIntentionalWalks[num] = Convert.ToDouble(record[16]);

                    Array.Resize<double>(ref pStrikeOuts, pStrikeOuts.Length + 1);
                    pStrikeOuts[num] = Convert.ToDouble(record[17]);
                    k = Convert.ToDouble(record[17]);

                    Array.Resize<double>(ref pHitbyPitches, pHitbyPitches.Length + 1);
                    pHitbyPitches[num] = Convert.ToDouble(record[18]);

                    Array.Resize<double>(ref battersFaced, battersFaced.Length + 1);
                    battersFaced[num] = Convert.ToDouble(record[19]);

                    Array.Resize<double>(ref ERA, ERA.Length + 1);
                    var era = new Pitchers(er, ip);
                    ERA[num] = era.CalculateERA();
                    earnedRunAverage = ERA[num];

                    Array.Resize<double>(ref ERAPlus, ERAPlus.Length + 1);
                    var erap = new Pitchers(earnedRunAverage);
                    ERAPlus[num] = erap.CalculateERAPlus();

                    Array.Resize<double>(ref WinPercentage, WinPercentage.Length + 1);
                    var WPCT = new Pitchers(w, l, 0);
                    WinPercentage[num] = WPCT.CalculateWPCT();

                    Array.Resize<double>(ref WalksPlusHitsPerInningsPitched, WalksPlusHitsPerInningsPitched.Length + 1);
                    var WHIP = new Pitchers(ph, bb, ip, 0);
                    WalksPlusHitsPerInningsPitched[num] = WHIP.CalculateWHIP();

                    Array.Resize<double>(ref HomeRunsPer9, HomeRunsPer9.Length + 1);
                    var hrper9 = new Pitchers(homeruns, ph, 0, 0, 0);
                    HomeRunsPer9[num] = hrper9.CalculateHRper9();

                    Array.Resize<double>(ref HitsPer9, HitsPer9.Length + 1);
                    var hper9 = new Pitchers(ph, ip, 0, 0, 0, 0);
                    HitsPer9[num] = hper9.CalculateHper9();

                    Array.Resize<double>(ref WalksPer9, WalksPer9.Length + 1);
                    var bbper9 = new Pitchers(bb, ip, 0, 0, 0, 0, 0);
                    WalksPer9[num] = bbper9.CalculateBBper9();

                    Array.Resize<double>(ref StrikeoutsPer9, StrikeoutsPer9.Length + 1);
                    var kper9 = new Pitchers(k, ip, 0, 0, 0, 0, 0, 0);
                    StrikeoutsPer9[num] = kper9.CalculateKper9();

                    if (radAllDivisions.Checked && radMLB.Checked)
                    {
                        if (lbMLBTeams.Text == "All Teams")
                        {
                            if (lbStaff.Text == "Starter" && pStaff[num] == "S")
                            {
                                printPitchers();
                            }
                            else if (lbStaff.Text == "Reliever" && pStaff[num] == "R")
                            {
                                printPitchers();
                            }
                            else if (lbStaff.Text == "Closer" && pStaff[num] == "C")
                            {
                                printPitchers();
                            }
                            if (lbStaff.Text == "All Positions")
                            {
                                printPitchers();
                            }
                        }
                        if (lbMLBTeams.Text == "Baltimore Orioles" && team[num] == "BAL")
                        {
                            if (lbStaff.Text == "Starter" && pStaff[num] == "S")
                            {
                                printPitchers();
                            }
                            else if (lbStaff.Text == "Reliever" && pStaff[num] == "R")
                            {
                                printPitchers();
                            }
                            else if (lbStaff.Text == "Closer" && pStaff[num] == "C")
                            {
                                printPitchers();
                            }
                            if (lbStaff.Text == "All Positions")
                            {
                                printPitchers();
                            }
                        }
                        if (lbMLBTeams.Text == "Boston Red Sox" && team[num] == "BOS")
                        {
                            if (lbStaff.Text == "Starter" && pStaff[num] == "S")
                            {
                                printPitchers();
                            }
                            else if (lbStaff.Text == "Reliever" && pStaff[num] == "R")
                            {
                                printPitchers();
                            }
                            else if (lbStaff.Text == "Closer" && pStaff[num] == "C")
                            {
                                printPitchers();
                            }
                            if (lbStaff.Text == "All Positions")
                            {
                                printPitchers();
                            }
                        }
                        if (lbMLBTeams.Text == "New York Yankees" && team[num] == "NYY")
                        {
                            if (lbStaff.Text == "Starter" && pStaff[num] == "S")
                            {
                                printPitchers();
                            }
                            else if (lbStaff.Text == "Reliever" && pStaff[num] == "R")
                            {
                                printPitchers();
                            }
                            else if (lbStaff.Text == "Closer" && pStaff[num] == "C")
                            {
                                printPitchers();
                            }
                            if (lbStaff.Text == "All Positions")
                            {
                                printPitchers();
                            }
                        }
                        if (lbMLBTeams.Text == "Tampa Bay Rays" && team[num] == "TBR")
                        {
                            if (lbStaff.Text == "Starter" && pStaff[num] == "S")
                            {
                                printPitchers();
                            }
                            else if (lbStaff.Text == "Reliever" && pStaff[num] == "R")
                            {
                                printPitchers();
                            }
                            else if (lbStaff.Text == "Closer" && pStaff[num] == "C")
                            {
                                printPitchers();
                            }
                            if (lbStaff.Text == "All Positions")
                            {
                                printPitchers();
                            }
                        }
                        if (lbMLBTeams.Text == "Toronto Blue Jays" && team[num] == "TOR")
                        {
                            if (lbStaff.Text == "Starter" && pStaff[num] == "S")
                            {
                                printPitchers();
                            }
                            else if (lbStaff.Text == "Reliever" && pStaff[num] == "R")
                            {
                                printPitchers();
                            }
                            else if (lbStaff.Text == "Closer" && pStaff[num] == "C")
                            {
                                printPitchers();
                            }
                            if (lbStaff.Text == "All Positions")
                            {
                                printPitchers();
                            }
                        }
                        if (lbMLBTeams.Text == "Chicago White Sox" && team[num] == "CWS")
                        {
                            if (lbStaff.Text == "Starter" && pStaff[num] == "S")
                            {
                                printPitchers();
                            }
                            else if (lbStaff.Text == "Reliever" && pStaff[num] == "R")
                            {
                                printPitchers();
                            }
                            else if (lbStaff.Text == "Closer" && pStaff[num] == "C")
                            {
                                printPitchers();
                            }
                            if (lbStaff.Text == "All Positions")
                            {
                                printPitchers();
                            }
                        }
                        if (lbMLBTeams.Text == "Cleveland Guardians" && team[num] == "CLE")
                        {
                            if (lbStaff.Text == "Starter" && pStaff[num] == "S")
                            {
                                printPitchers();
                            }
                            else if (lbStaff.Text == "Reliever" && pStaff[num] == "R")
                            {
                                printPitchers();
                            }
                            else if (lbStaff.Text == "Closer" && pStaff[num] == "C")
                            {
                                printPitchers();
                            }
                            if (lbStaff.Text == "All Positions")
                            {
                                printPitchers();
                            }
                        }
                        if (lbMLBTeams.Text == "Detroit Tigers" && team[num] == "DET")
                        {
                            if (lbStaff.Text == "Starter" && pStaff[num] == "S")
                            {
                                printPitchers();
                            }
                            else if (lbStaff.Text == "Reliever" && pStaff[num] == "R")
                            {
                                printPitchers();
                            }
                            else if (lbStaff.Text == "Closer" && pStaff[num] == "C")
                            {
                                printPitchers();
                            }
                            if (lbStaff.Text == "All Positions")
                            {
                                printPitchers();
                            }
                        }
                        if (lbMLBTeams.Text == "Kansas City Royals" && team[num] == "KCR")
                        {
                            if (lbStaff.Text == "Starter" && pStaff[num] == "S")
                            {
                                printPitchers();
                            }
                            else if (lbStaff.Text == "Reliever" && pStaff[num] == "R")
                            {
                                printPitchers();
                            }
                            else if (lbStaff.Text == "Closer" && pStaff[num] == "C")
                            {
                                printPitchers();
                            }
                            if (lbStaff.Text == "All Positions")
                            {
                                printPitchers();
                            }
                        }
                        if (lbMLBTeams.Text == "Minnesota Twins" && team[num] == "MIN")
                        {
                            if (lbStaff.Text == "Starter" && pStaff[num] == "S")
                            {
                                printPitchers();
                            }
                            else if (lbStaff.Text == "Reliever" && pStaff[num] == "R")
                            {
                                printPitchers();
                            }
                            else if (lbStaff.Text == "Closer" && pStaff[num] == "C")
                            {
                                printPitchers();
                            }
                            if (lbStaff.Text == "All Positions")
                            {
                                printPitchers();
                            }
                        }
                        if (lbMLBTeams.Text == "Houston Astros" && team[num] == "HOU")
                        {
                            if (lbStaff.Text == "Starter" && pStaff[num] == "S")
                            {
                                printPitchers();
                            }
                            else if (lbStaff.Text == "Reliever" && pStaff[num] == "R")
                            {
                                printPitchers();
                            }
                            else if (lbStaff.Text == "Closer" && pStaff[num] == "C")
                            {
                                printPitchers();
                            }
                            if (lbStaff.Text == "All Positions")
                            {
                                printPitchers();
                            }
                        }
                        if (lbMLBTeams.Text == "Los Angeles Angels" && team[num] == "LAA")
                        {
                            if (lbStaff.Text == "Starter" && pStaff[num] == "S")
                            {
                                printPitchers();
                            }
                            else if (lbStaff.Text == "Reliever" && pStaff[num] == "R")
                            {
                                printPitchers();
                            }
                            else if (lbStaff.Text == "Closer" && pStaff[num] == "C")
                            {
                                printPitchers();
                            }
                            if (lbStaff.Text == "All Positions")
                            {
                                printPitchers();
                            }
                        }
                        if (lbMLBTeams.Text == "Oakland Athletics" && team[num] == "OAK")
                        {
                            if (lbStaff.Text == "Starter" && pStaff[num] == "S")
                            {
                                printPitchers();
                            }
                            else if (lbStaff.Text == "Reliever" && pStaff[num] == "R")
                            {
                                printPitchers();
                            }
                            else if (lbStaff.Text == "Closer" && pStaff[num] == "C")
                            {
                                printPitchers();
                            }
                            if (lbStaff.Text == "All Positions")
                            {
                                printPitchers();
                            }
                        }
                        if (lbMLBTeams.Text == "Seattle Mariners" && team[num] == "SEA")
                        {
                            if (lbStaff.Text == "Starter" && pStaff[num] == "S")
                            {
                                printPitchers();
                            }
                            else if (lbStaff.Text == "Reliever" && pStaff[num] == "R")
                            {
                                printPitchers();
                            }
                            else if (lbStaff.Text == "Closer" && pStaff[num] == "C")
                            {
                                printPitchers();
                            }
                            if (lbStaff.Text == "All Positions")
                            {
                                printPitchers();
                            }
                        }
                        if (lbMLBTeams.Text == "Texas Rangers" && team[num] == "TEX")
                        {
                            if (lbStaff.Text == "Starter" && pStaff[num] == "S")
                            {
                                printPitchers();
                            }
                            else if (lbStaff.Text == "Reliever" && pStaff[num] == "R")
                            {
                                printPitchers();
                            }
                            else if (lbStaff.Text == "Closer" && pStaff[num] == "C")
                            {
                                printPitchers();
                            }
                            if (lbStaff.Text == "All Positions")
                            {
                                printPitchers();
                            }
                        }
                        if (lbMLBTeams.Text == "Atlanta Braves" && team[num] == "ATL")
                        {
                            if (lbStaff.Text == "Starter" && pStaff[num] == "S")
                            {
                                printPitchers();
                            }
                            else if (lbStaff.Text == "Reliever" && pStaff[num] == "R")
                            {
                                printPitchers();
                            }
                            else if (lbStaff.Text == "Closer" && pStaff[num] == "C")
                            {
                                printPitchers();
                            }
                            if (lbStaff.Text == "All Positions")
                            {
                                printPitchers();
                            }
                        }
                        if (lbMLBTeams.Text == "Miami Marlins" && team[num] == "MIA")
                        {
                            if (lbStaff.Text == "Starter" && pStaff[num] == "S")
                            {
                                printPitchers();
                            }
                            else if (lbStaff.Text == "Reliever" && pStaff[num] == "R")
                            {
                                printPitchers();
                            }
                            else if (lbStaff.Text == "Closer" && pStaff[num] == "C")
                            {
                                printPitchers();
                            }
                            if (lbStaff.Text == "All Positions")
                            {
                                printPitchers();
                            }
                        }
                        if (lbMLBTeams.Text == "New York Mets" && team[num] == "NYM")
                        {
                            if (lbStaff.Text == "Starter" && pStaff[num] == "S")
                            {
                                printPitchers();
                            }
                            else if (lbStaff.Text == "Reliever" && pStaff[num] == "R")
                            {
                                printPitchers();
                            }
                            else if (lbStaff.Text == "Closer" && pStaff[num] == "C")
                            {
                                printPitchers();
                            }
                            if (lbStaff.Text == "All Positions")
                            {
                                printPitchers();
                            }
                        }
                        if (lbMLBTeams.Text == "Philadelphia Phillies" && team[num] == "PHI")
                        {
                            if (lbStaff.Text == "Starter" && pStaff[num] == "S")
                            {
                                printPitchers();
                            }
                            else if (lbStaff.Text == "Reliever" && pStaff[num] == "R")
                            {
                                printPitchers();
                            }
                            else if (lbStaff.Text == "Closer" && pStaff[num] == "C")
                            {
                                printPitchers();
                            }
                            if (lbStaff.Text == "All Positions")
                            {
                                printPitchers();
                            }
                        }
                        if (lbMLBTeams.Text == "Washington Nationals" && team[num] == "WSN")
                        {
                            if (lbStaff.Text == "Starter" && pStaff[num] == "S")
                            {
                                printPitchers();
                            }
                            else if (lbStaff.Text == "Reliever" && pStaff[num] == "R")
                            {
                                printPitchers();
                            }
                            else if (lbStaff.Text == "Closer" && pStaff[num] == "C")
                            {
                                printPitchers();
                            }
                            if (lbStaff.Text == "All Positions")
                            {
                                printPitchers();
                            }
                        }
                        if (lbMLBTeams.Text == "Cincinnati Reds" && team[num] == "CIN")
                        {
                            if (lbStaff.Text == "Starter" && pStaff[num] == "S")
                            {
                                printPitchers();
                            }
                            else if (lbStaff.Text == "Reliever" && pStaff[num] == "R")
                            {
                                printPitchers();
                            }
                            else if (lbStaff.Text == "Closer" && pStaff[num] == "C")
                            {
                                printPitchers();
                            }
                            if (lbStaff.Text == "All Positions")
                            {
                                printPitchers();
                            }
                        }
                        if (lbMLBTeams.Text == "Chicago Cubs" && team[num] == "CHC")
                        {
                            if (lbStaff.Text == "Starter" && pStaff[num] == "S")
                            {
                                printPitchers();
                            }
                            else if (lbStaff.Text == "Reliever" && pStaff[num] == "R")
                            {
                                printPitchers();
                            }
                            else if (lbStaff.Text == "Closer" && pStaff[num] == "C")
                            {
                                printPitchers();
                            }
                            if (lbStaff.Text == "All Positions")
                            {
                                printPitchers();
                            }
                        }
                        if (lbMLBTeams.Text == "Milwaukee Brewers" && team[num] == "MIL")
                        {
                            if (lbStaff.Text == "Starter" && pStaff[num] == "S")
                            {
                                printPitchers();
                            }
                            else if (lbStaff.Text == "Reliever" && pStaff[num] == "R")
                            {
                                printPitchers();
                            }
                            else if (lbStaff.Text == "Closer" && pStaff[num] == "C")
                            {
                                printPitchers();
                            }
                            if (lbStaff.Text == "All Positions")
                            {
                                printPitchers();
                            }
                        }
                        if (lbMLBTeams.Text == "Pittsburgh Pirates" && team[num] == "PIT")
                        {
                            if (lbStaff.Text == "Starter" && pStaff[num] == "S")
                            {
                                printPitchers();
                            }
                            else if (lbStaff.Text == "Reliever" && pStaff[num] == "R")
                            {
                                printPitchers();
                            }
                            else if (lbStaff.Text == "Closer" && pStaff[num] == "C")
                            {
                                printPitchers();
                            }
                            if (lbStaff.Text == "All Positions")
                            {
                                printPitchers();
                            }
                        }
                        if (lbMLBTeams.Text == "St. Louis Cardinals" && team[num] == "STL")
                        {
                            if (lbStaff.Text == "Starter" && pStaff[num] == "S")
                            {
                                printPitchers();
                            }
                            else if (lbStaff.Text == "Reliever" && pStaff[num] == "R")
                            {
                                printPitchers();
                            }
                            else if (lbStaff.Text == "Closer" && pStaff[num] == "C")
                            {
                                printPitchers();
                            }
                            if (lbStaff.Text == "All Positions")
                            {
                                printPitchers();
                            }
                        }
                        if (lbMLBTeams.Text == "Arizona Diamondbacks" && team[num] == "ARI")
                        {
                            if (lbStaff.Text == "Starter" && pStaff[num] == "S")
                            {
                                printPitchers();
                            }
                            else if (lbStaff.Text == "Reliever" && pStaff[num] == "R")
                            {
                                printPitchers();
                            }
                            else if (lbStaff.Text == "Closer" && pStaff[num] == "C")
                            {
                                printPitchers();
                            }
                            if (lbStaff.Text == "All Positions")
                            {
                                printPitchers();
                            }
                        }
                        if (lbMLBTeams.Text == "Colorado Rockies" && team[num] == "COL")
                        {
                            if (lbStaff.Text == "Starter" && pStaff[num] == "S")
                            {
                                printPitchers();
                            }
                            else if (lbStaff.Text == "Reliever" && pStaff[num] == "R")
                            {
                                printPitchers();
                            }
                            else if (lbStaff.Text == "Closer" && pStaff[num] == "C")
                            {
                                printPitchers();
                            }
                            if (lbStaff.Text == "All Positions")
                            {
                                printPitchers();
                            }
                        }
                        if (lbMLBTeams.Text == "Los Angeles Dodgers" && team[num] == "LAD")
                        {
                            if (lbStaff.Text == "Starter" && pStaff[num] == "S")
                            {
                                printPitchers();
                            }
                            else if (lbStaff.Text == "Reliever" && pStaff[num] == "R")
                            {
                                printPitchers();
                            }
                            else if (lbStaff.Text == "Closer" && pStaff[num] == "C")
                            {
                                printPitchers();
                            }
                            if (lbStaff.Text == "All Positions")
                            {
                                printPitchers();
                            }
                        }
                        if (lbMLBTeams.Text == "San Francisco Giants" && team[num] == "SFG")
                        {
                            if (lbStaff.Text == "Starter" && pStaff[num] == "S")
                            {
                                printPitchers();
                            }
                            else if (lbStaff.Text == "Reliever" && pStaff[num] == "R")
                            {
                                printPitchers();
                            }
                            else if (lbStaff.Text == "Closer" && pStaff[num] == "C")
                            {
                                printPitchers();
                            }
                            if (lbStaff.Text == "All Positions")
                            {
                                printPitchers();
                            }
                        }
                        if (lbMLBTeams.Text == "San Diego Padres" && team[num] == "SDP")
                        {
                            if (lbStaff.Text == "Starter" && pStaff[num] == "S")
                            {
                                printPitchers();
                            }
                            else if (lbStaff.Text == "Reliever" && pStaff[num] == "R")
                            {
                                printPitchers();
                            }
                            else if (lbStaff.Text == "Closer" && pStaff[num] == "C")
                            {
                                printPitchers();
                            }
                            if (lbStaff.Text == "All Positions")
                            {
                                printPitchers();
                            }
                        }
                    }
                    else if (radAllDivisions.Checked && radAL.Checked)
                    {
                        if (league[num] == "AL")
                        {
                            if (lbMLBTeams.Text == "All Teams")
                            {
                                if (lbHitterPosition.Text == "Catcher" && position[num] == "C")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "1st Base" && position[num] == "1B")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "2nd Base" && position[num] == "2B")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Short Stop" && position[num] == "SS")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "3rd Base" && position[num] == "3B")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Left Field" && position[num] == "LF")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Center Field" && position[num] == "CF")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Right Field" && position[num] == "RF")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "Designated Hitter" && position[num] == "DH")
                                {
                                    printHitters();
                                }
                                else if (lbHitterPosition.Text == "All Positions")
                                {
                                    printHitters();
                                }
                            }
                            if (lbMLBTeams.Text == "Baltimore Orioles" && team[num] == "BAL")
                            {
                                if (lbStaff.Text == "Starter" && pStaff[num] == "S")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Reliever" && pStaff[num] == "R")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Closer" && pStaff[num] == "C")
                                {
                                    printPitchers();
                                }
                                if (lbStaff.Text == "All Positions")
                                {
                                    printPitchers();
                                }
                            }
                            if (lbMLBTeams.Text == "Boston Red Sox" && team[num] == "BOS")
                            {
                                if (lbStaff.Text == "Starter" && pStaff[num] == "S")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Reliever" && pStaff[num] == "R")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Closer" && pStaff[num] == "C")
                                {
                                    printPitchers();
                                }
                                if (lbStaff.Text == "All Positions")
                                {
                                    printPitchers();
                                }
                            }
                            if (lbMLBTeams.Text == "New York Yankees" && team[num] == "NYY")
                            {
                                if (lbStaff.Text == "Starter" && pStaff[num] == "S")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Reliever" && pStaff[num] == "R")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Closer" && pStaff[num] == "C")
                                {
                                    printPitchers();
                                }
                                if (lbStaff.Text == "All Positions")
                                {
                                    printPitchers();
                                }
                            }
                            if (lbMLBTeams.Text == "Tampa Bay Rays" && team[num] == "TBR")
                            {
                                if (lbStaff.Text == "Starter" && pStaff[num] == "S")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Reliever" && pStaff[num] == "R")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Closer" && pStaff[num] == "C")
                                {
                                    printPitchers();
                                }
                                if (lbStaff.Text == "All Positions")
                                {
                                    printPitchers();
                                }
                            }
                            if (lbMLBTeams.Text == "Toronto Blue Jays" && team[num] == "TOR")
                            {
                                if (lbStaff.Text == "Starter" && pStaff[num] == "S")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Reliever" && pStaff[num] == "R")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Closer" && pStaff[num] == "C")
                                {
                                    printPitchers();
                                }
                                if (lbStaff.Text == "All Positions")
                                {
                                    printPitchers();
                                }
                            }
                            if (lbMLBTeams.Text == "Chicago White Sox" && team[num] == "CWS")
                            {
                                if (lbStaff.Text == "Starter" && pStaff[num] == "S")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Reliever" && pStaff[num] == "R")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Closer" && pStaff[num] == "C")
                                {
                                    printPitchers();
                                }
                                if (lbStaff.Text == "All Positions")
                                {
                                    printPitchers();
                                }
                            }
                            if (lbMLBTeams.Text == "Cleveland Guardians" && team[num] == "CLE")
                            {
                                if (lbStaff.Text == "Starter" && pStaff[num] == "S")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Reliever" && pStaff[num] == "R")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Closer" && pStaff[num] == "C")
                                {
                                    printPitchers();
                                }
                                if (lbStaff.Text == "All Positions")
                                {
                                    printPitchers();
                                }
                            }
                            if (lbMLBTeams.Text == "Detroit Tigers" && team[num] == "DET")
                            {
                                if (lbStaff.Text == "Starter" && pStaff[num] == "S")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Reliever" && pStaff[num] == "R")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Closer" && pStaff[num] == "C")
                                {
                                    printPitchers();
                                }
                                if (lbStaff.Text == "All Positions")
                                {
                                    printPitchers();
                                }
                            }
                            if (lbMLBTeams.Text == "Kansas City Royals" && team[num] == "KCR")
                            {
                                if (lbStaff.Text == "Starter" && pStaff[num] == "S")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Reliever" && pStaff[num] == "R")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Closer" && pStaff[num] == "C")
                                {
                                    printPitchers();
                                }
                                if (lbStaff.Text == "All Positions")
                                {
                                    printPitchers();
                                }
                            }
                            if (lbMLBTeams.Text == "Minnesota Twins" && team[num] == "MIN")
                            {
                                if (lbStaff.Text == "Starter" && pStaff[num] == "S")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Reliever" && pStaff[num] == "R")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Closer" && pStaff[num] == "C")
                                {
                                    printPitchers();
                                }
                                if (lbStaff.Text == "All Positions")
                                {
                                    printPitchers();
                                }
                            }
                            if (lbMLBTeams.Text == "Houston Astros" && team[num] == "HOU")
                            {
                                if (lbStaff.Text == "Starter" && pStaff[num] == "S")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Reliever" && pStaff[num] == "R")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Closer" && pStaff[num] == "C")
                                {
                                    printPitchers();
                                }
                                if (lbStaff.Text == "All Positions")
                                {
                                    printPitchers();
                                }
                            }
                            if (lbMLBTeams.Text == "Los Angeles Angels" && team[num] == "LAA")
                            {
                                if (lbStaff.Text == "Starter" && pStaff[num] == "S")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Reliever" && pStaff[num] == "R")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Closer" && pStaff[num] == "C")
                                {
                                    printPitchers();
                                }
                                if (lbStaff.Text == "All Positions")
                                {
                                    printPitchers();
                                }
                            }
                            if (lbMLBTeams.Text == "Oakland Athletics" && team[num] == "OAK")
                            {
                                if (lbStaff.Text == "Starter" && pStaff[num] == "S")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Reliever" && pStaff[num] == "R")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Closer" && pStaff[num] == "C")
                                {
                                    printPitchers();
                                }
                                if (lbStaff.Text == "All Positions")
                                {
                                    printPitchers();
                                }
                            }
                            if (lbMLBTeams.Text == "Seattle Mariners" && team[num] == "SEA")
                            {
                                if (lbStaff.Text == "Starter" && pStaff[num] == "S")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Reliever" && pStaff[num] == "R")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Closer" && pStaff[num] == "C")
                                {
                                    printPitchers();
                                }
                                if (lbStaff.Text == "All Positions")
                                {
                                    printPitchers();
                                }
                            }
                            if (lbMLBTeams.Text == "Texas Rangers" && team[num] == "TEX")
                            {
                                if (lbStaff.Text == "Starter" && pStaff[num] == "S")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Reliever" && pStaff[num] == "R")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Closer" && pStaff[num] == "C")
                                {
                                    printPitchers();
                                }
                                if (lbStaff.Text == "All Positions")
                                {
                                    printPitchers();
                                }
                            }
                        }
                    }
                    else if (radAllDivisions.Checked && radNL.Checked)
                    {
                        if (league[num] == "NL")
                        {
                            if (lbMLBTeams.Text == "All Teams")
                            {
                                if (lbStaff.Text == "Starter" && pStaff[num] == "S")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Reliever" && pStaff[num] == "R")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Closer" && pStaff[num] == "C")
                                {
                                    printPitchers();
                                }
                                if (lbStaff.Text == "All Positions")
                                {
                                    printPitchers();
                                }
                            }

                            if (lbMLBTeams.Text == "Atlanta Braves" && team[num] == "ATL")
                            {
                                if (lbStaff.Text == "Starter" && pStaff[num] == "S")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Reliever" && pStaff[num] == "R")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Closer" && pStaff[num] == "C")
                                {
                                    printPitchers();
                                }
                                if (lbStaff.Text == "All Positions")
                                {
                                    printPitchers();
                                }
                            }
                            if (lbMLBTeams.Text == "Miami Marlins" && team[num] == "MIA")
                            {
                                if (lbStaff.Text == "Starter" && pStaff[num] == "S")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Reliever" && pStaff[num] == "R")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Closer" && pStaff[num] == "C")
                                {
                                    printPitchers();
                                }
                                if (lbStaff.Text == "All Positions")
                                {
                                    printPitchers();
                                }
                            }
                            if (lbMLBTeams.Text == "New York Mets" && team[num] == "NYM")
                            {
                                if (lbStaff.Text == "Starter" && pStaff[num] == "S")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Reliever" && pStaff[num] == "R")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Closer" && pStaff[num] == "C")
                                {
                                    printPitchers();
                                }
                                if (lbStaff.Text == "All Positions")
                                {
                                    printPitchers();
                                }
                            }
                            if (lbMLBTeams.Text == "Philadelphia Phillies" && team[num] == "PHI")
                            {
                                if (lbStaff.Text == "Starter" && pStaff[num] == "S")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Reliever" && pStaff[num] == "R")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Closer" && pStaff[num] == "C")
                                {
                                    printPitchers();
                                }
                                if (lbStaff.Text == "All Positions")
                                {
                                    printPitchers();
                                }
                            }
                            if (lbMLBTeams.Text == "Washington Nationals" && team[num] == "WSN")
                            {
                                if (lbStaff.Text == "Starter" && pStaff[num] == "S")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Reliever" && pStaff[num] == "R")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Closer" && pStaff[num] == "C")
                                {
                                    printPitchers();
                                }
                                if (lbStaff.Text == "All Positions")
                                {
                                    printPitchers();
                                }
                            }
                            if (lbMLBTeams.Text == "Cincinnati Reds" && team[num] == "CIN")
                            {
                                if (lbStaff.Text == "Starter" && pStaff[num] == "S")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Reliever" && pStaff[num] == "R")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Closer" && pStaff[num] == "C")
                                {
                                    printPitchers();
                                }
                                if (lbStaff.Text == "All Positions")
                                {
                                    printPitchers();
                                }
                            }
                            if (lbMLBTeams.Text == "Chicago Cubs" && team[num] == "CHC")
                            {
                                if (lbStaff.Text == "Starter" && pStaff[num] == "S")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Reliever" && pStaff[num] == "R")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Closer" && pStaff[num] == "C")
                                {
                                    printPitchers();
                                }
                                if (lbStaff.Text == "All Positions")
                                {
                                    printPitchers();
                                }
                            }
                            if (lbMLBTeams.Text == "Milwaukee Brewers" && team[num] == "MIL")
                            {
                                if (lbStaff.Text == "Starter" && pStaff[num] == "S")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Reliever" && pStaff[num] == "R")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Closer" && pStaff[num] == "C")
                                {
                                    printPitchers();
                                }
                                if (lbStaff.Text == "All Positions")
                                {
                                    printPitchers();
                                }
                            }
                            if (lbMLBTeams.Text == "Pittsburgh Pirates" && team[num] == "PIT")
                            {
                                if (lbStaff.Text == "Starter" && pStaff[num] == "S")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Reliever" && pStaff[num] == "R")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Closer" && pStaff[num] == "C")
                                {
                                    printPitchers();
                                }
                                if (lbStaff.Text == "All Positions")
                                {
                                    printPitchers();
                                }
                            }
                            if (lbMLBTeams.Text == "St. Louis Cardinals" && team[num] == "STL")
                            {
                                if (lbStaff.Text == "Starter" && pStaff[num] == "S")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Reliever" && pStaff[num] == "R")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Closer" && pStaff[num] == "C")
                                {
                                    printPitchers();
                                }
                                if (lbStaff.Text == "All Positions")
                                {
                                    printPitchers();
                                }
                            }
                            if (lbMLBTeams.Text == "Arizona Diamondbacks" && team[num] == "ARI")
                            {
                                if (lbStaff.Text == "Starter" && pStaff[num] == "S")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Reliever" && pStaff[num] == "R")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Closer" && pStaff[num] == "C")
                                {
                                    printPitchers();
                                }
                                if (lbStaff.Text == "All Positions")
                                {
                                    printPitchers();
                                }
                            }
                            if (lbMLBTeams.Text == "Colorado Rockies" && team[num] == "COL")
                            {
                                if (lbStaff.Text == "Starter" && pStaff[num] == "S")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Reliever" && pStaff[num] == "R")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Closer" && pStaff[num] == "C")
                                {
                                    printPitchers();
                                }
                                if (lbStaff.Text == "All Positions")
                                {
                                    printPitchers();
                                }
                            }
                            if (lbMLBTeams.Text == "Los Angeles Dodgers" && team[num] == "LAD")
                            {
                                if (lbStaff.Text == "Starter" && pStaff[num] == "S")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Reliever" && pStaff[num] == "R")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Closer" && pStaff[num] == "C")
                                {
                                    printPitchers();
                                }
                                if (lbStaff.Text == "All Positions")
                                {
                                    printPitchers();
                                }
                            }
                            if (lbMLBTeams.Text == "San Francisco Giants" && team[num] == "SFG")
                            {
                                if (lbStaff.Text == "Starter" && pStaff[num] == "S")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Reliever" && pStaff[num] == "R")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Closer" && pStaff[num] == "C")
                                {
                                    printPitchers();
                                }
                                if (lbStaff.Text == "All Positions")
                                {
                                    printPitchers();
                                }
                            }
                            if (lbMLBTeams.Text == "San Diego Padres" && team[num] == "SDP")
                            {
                                if (lbStaff.Text == "Starter" && pStaff[num] == "S")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Reliever" && pStaff[num] == "R")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Closer" && pStaff[num] == "C")
                                {
                                    printPitchers();
                                }
                                if (lbStaff.Text == "All Positions")
                                {
                                    printPitchers();
                                }
                            }
                        }
                    }
                    else if (radEast.Checked && radMLB.Checked)
                    {
                        if (division[num] == "E")
                        {
                            if (lbMLBTeams.Text == "All Teams")
                            {
                                if (lbStaff.Text == "Starter" && pStaff[num] == "S")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Reliever" && pStaff[num] == "R")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Closer" && pStaff[num] == "C")
                                {
                                    printPitchers();
                                }
                                if (lbStaff.Text == "All Positions")
                                {
                                    printPitchers();
                                }
                            }
                            if (lbMLBTeams.Text == "Baltimore Orioles" && team[num] == "BAL")
                            {
                                if (lbStaff.Text == "Starter" && pStaff[num] == "S")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Reliever" && pStaff[num] == "R")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Closer" && pStaff[num] == "C")
                                {
                                    printPitchers();
                                }
                                if (lbStaff.Text == "All Positions")
                                {
                                    printPitchers();
                                }
                            }
                            if (lbMLBTeams.Text == "Boston Red Sox" && team[num] == "BOS")
                            {
                                if (lbStaff.Text == "Starter" && pStaff[num] == "S")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Reliever" && pStaff[num] == "R")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Closer" && pStaff[num] == "C")
                                {
                                    printPitchers();
                                }
                                if (lbStaff.Text == "All Positions")
                                {
                                    printPitchers();
                                }
                            }
                            if (lbMLBTeams.Text == "New York Yankees" && team[num] == "NYY")
                            {
                                if (lbStaff.Text == "Starter" && pStaff[num] == "S")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Reliever" && pStaff[num] == "R")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Closer" && pStaff[num] == "C")
                                {
                                    printPitchers();
                                }
                                if (lbStaff.Text == "All Positions")
                                {
                                    printPitchers();
                                }
                            }
                            if (lbMLBTeams.Text == "Tampa Bay Rays" && team[num] == "TBR")
                            {
                                if (lbStaff.Text == "Starter" && pStaff[num] == "S")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Reliever" && pStaff[num] == "R")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Closer" && pStaff[num] == "C")
                                {
                                    printPitchers();
                                }
                                if (lbStaff.Text == "All Positions")
                                {
                                    printPitchers();
                                }
                            }
                            if (lbMLBTeams.Text == "Toronto Blue Jays" && team[num] == "TOR")
                            {
                                if (lbStaff.Text == "Starter" && pStaff[num] == "S")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Reliever" && pStaff[num] == "R")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Closer" && pStaff[num] == "C")
                                {
                                    printPitchers();
                                }
                                if (lbStaff.Text == "All Positions")
                                {
                                    printPitchers();
                                }
                            }
                            if (lbMLBTeams.Text == "Atlanta Braves" && team[num] == "ATL")
                            {
                                if (lbStaff.Text == "Starter" && pStaff[num] == "S")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Reliever" && pStaff[num] == "R")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Closer" && pStaff[num] == "C")
                                {
                                    printPitchers();
                                }
                                if (lbStaff.Text == "All Positions")
                                {
                                    printPitchers();
                                }
                            }
                            if (lbMLBTeams.Text == "Miami Marlins" && team[num] == "MIA")
                            {
                                if (lbStaff.Text == "Starter" && pStaff[num] == "S")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Reliever" && pStaff[num] == "R")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Closer" && pStaff[num] == "C")
                                {
                                    printPitchers();
                                }
                                if (lbStaff.Text == "All Positions")
                                {
                                    printPitchers();
                                }
                            }
                            if (lbMLBTeams.Text == "New York Mets" && team[num] == "NYM")
                            {
                                if (lbStaff.Text == "Starter" && pStaff[num] == "S")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Reliever" && pStaff[num] == "R")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Closer" && pStaff[num] == "C")
                                {
                                    printPitchers();
                                }
                                if (lbStaff.Text == "All Positions")
                                {
                                    printPitchers();
                                }
                            }
                            if (lbMLBTeams.Text == "Philadelphia Phillies" && team[num] == "PHI")
                            {
                                if (lbStaff.Text == "Starter" && pStaff[num] == "S")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Reliever" && pStaff[num] == "R")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Closer" && pStaff[num] == "C")
                                {
                                    printPitchers();
                                }
                                if (lbStaff.Text == "All Positions")
                                {
                                    printPitchers();
                                }
                            }
                            if (lbMLBTeams.Text == "Washington Nationals" && team[num] == "WSN")
                            {
                                if (lbStaff.Text == "Starter" && pStaff[num] == "S")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Reliever" && pStaff[num] == "R")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Closer" && pStaff[num] == "C")
                                {
                                    printPitchers();
                                }
                                if (lbStaff.Text == "All Positions")
                                {
                                    printPitchers();
                                }
                            }
                        }
                    }
                    else if (radCentral.Checked && radMLB.Checked)
                    {
                        if (division[num] == "C")
                        {
                            if (lbMLBTeams.Text == "All Teams")
                            {
                                if (lbStaff.Text == "Starter" && pStaff[num] == "S")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Reliever" && pStaff[num] == "R")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Closer" && pStaff[num] == "C")
                                {
                                    printPitchers();
                                }
                                if (lbStaff.Text == "All Positions")
                                {
                                    printPitchers();
                                }
                            }
                            if (lbMLBTeams.Text == "Chicago White Sox" && team[num] == "CWS")
                            {
                                if (lbStaff.Text == "Starter" && pStaff[num] == "S")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Reliever" && pStaff[num] == "R")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Closer" && pStaff[num] == "C")
                                {
                                    printPitchers();
                                }
                                if (lbStaff.Text == "All Positions")
                                {
                                    printPitchers();
                                }
                            }
                            if (lbMLBTeams.Text == "Cleveland Guardians" && team[num] == "CLE")
                            {
                                if (lbStaff.Text == "Starter" && pStaff[num] == "S")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Reliever" && pStaff[num] == "R")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Closer" && pStaff[num] == "C")
                                {
                                    printPitchers();
                                }
                                if (lbStaff.Text == "All Positions")
                                {
                                    printPitchers();
                                }
                            }
                            if (lbMLBTeams.Text == "Detroit Tigers" && team[num] == "DET")
                            {
                                if (lbStaff.Text == "Starter" && pStaff[num] == "S")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Reliever" && pStaff[num] == "R")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Closer" && pStaff[num] == "C")
                                {
                                    printPitchers();
                                }
                                if (lbStaff.Text == "All Positions")
                                {
                                    printPitchers();
                                }
                            }
                            if (lbMLBTeams.Text == "Kansas City Royals" && team[num] == "KCR")
                            {
                                if (lbStaff.Text == "Starter" && pStaff[num] == "S")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Reliever" && pStaff[num] == "R")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Closer" && pStaff[num] == "C")
                                {
                                    printPitchers();
                                }
                                if (lbStaff.Text == "All Positions")
                                {
                                    printPitchers();
                                }
                            }
                            if (lbMLBTeams.Text == "Minnesota Twins" && team[num] == "MIN")
                            {
                                if (lbStaff.Text == "Starter" && pStaff[num] == "S")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Reliever" && pStaff[num] == "R")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Closer" && pStaff[num] == "C")
                                {
                                    printPitchers();
                                }
                                if (lbStaff.Text == "All Positions")
                                {
                                    printPitchers();
                                }
                            }
                            if (lbMLBTeams.Text == "Cincinnati Reds" && team[num] == "CIN")
                            {
                                if (lbStaff.Text == "Starter" && pStaff[num] == "S")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Reliever" && pStaff[num] == "R")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Closer" && pStaff[num] == "C")
                                {
                                    printPitchers();
                                }
                                if (lbStaff.Text == "All Positions")
                                {
                                    printPitchers();
                                }
                            }
                            if (lbMLBTeams.Text == "Chicago Cubs" && team[num] == "CHC")
                            {
                                if (lbStaff.Text == "Starter" && pStaff[num] == "S")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Reliever" && pStaff[num] == "R")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Closer" && pStaff[num] == "C")
                                {
                                    printPitchers();
                                }
                                if (lbStaff.Text == "All Positions")
                                {
                                    printPitchers();
                                }
                            }
                            if (lbMLBTeams.Text == "Milwaukee Brewers" && team[num] == "MIL")
                            {
                                if (lbStaff.Text == "Starter" && pStaff[num] == "S")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Reliever" && pStaff[num] == "R")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Closer" && pStaff[num] == "C")
                                {
                                    printPitchers();
                                }
                                if (lbStaff.Text == "All Positions")
                                {
                                    printPitchers();
                                }
                            }
                            if (lbMLBTeams.Text == "Pittsburgh Pirates" && team[num] == "PIT")
                            {
                                if (lbStaff.Text == "Starter" && pStaff[num] == "S")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Reliever" && pStaff[num] == "R")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Closer" && pStaff[num] == "C")
                                {
                                    printPitchers();
                                }
                                if (lbStaff.Text == "All Positions")
                                {
                                    printPitchers();
                                }
                            }
                            if (lbMLBTeams.Text == "St. Louis Cardinals" && team[num] == "STL")
                            {
                                if (lbStaff.Text == "Starter" && pStaff[num] == "S")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Reliever" && pStaff[num] == "R")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Closer" && pStaff[num] == "C")
                                {
                                    printPitchers();
                                }
                                if (lbStaff.Text == "All Positions")
                                {
                                    printPitchers();
                                }
                            }
                        }
                    }
                    else if (radWest.Checked && radMLB.Checked)
                    {
                        if (division[num] == "W")
                        {
                            if (lbMLBTeams.Text == "All Teams")
                            {
                                if (lbStaff.Text == "Starter" && pStaff[num] == "S")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Reliever" && pStaff[num] == "R")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Closer" && pStaff[num] == "C")
                                {
                                    printPitchers();
                                }
                                if (lbStaff.Text == "All Positions")
                                {
                                    printPitchers();
                                }
                            }
                            if (lbMLBTeams.Text == "Houston Astros" && team[num] == "HOU")
                            {
                                if (lbStaff.Text == "Starter" && pStaff[num] == "S")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Reliever" && pStaff[num] == "R")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Closer" && pStaff[num] == "C")
                                {
                                    printPitchers();
                                }
                                if (lbStaff.Text == "All Positions")
                                {
                                    printPitchers();
                                }
                            }
                            if (lbMLBTeams.Text == "Los Angeles Angels" && team[num] == "LAA")
                            {
                                if (lbStaff.Text == "Starter" && pStaff[num] == "S")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Reliever" && pStaff[num] == "R")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Closer" && pStaff[num] == "C")
                                {
                                    printPitchers();
                                }
                                if (lbStaff.Text == "All Positions")
                                {
                                    printPitchers();
                                }
                            }
                            if (lbMLBTeams.Text == "Oakland Athletics" && team[num] == "OAK")
                            {
                                if (lbStaff.Text == "Starter" && pStaff[num] == "S")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Reliever" && pStaff[num] == "R")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Closer" && pStaff[num] == "C")
                                {
                                    printPitchers();
                                }
                                if (lbStaff.Text == "All Positions")
                                {
                                    printPitchers();
                                }
                            }
                            if (lbMLBTeams.Text == "Seattle Mariners" && team[num] == "SEA")
                            {
                                if (lbStaff.Text == "Starter" && pStaff[num] == "S")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Reliever" && pStaff[num] == "R")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Closer" && pStaff[num] == "C")
                                {
                                    printPitchers();
                                }
                                if (lbStaff.Text == "All Positions")
                                {
                                    printPitchers();
                                }
                            }
                            if (lbMLBTeams.Text == "Texas Rangers" && team[num] == "TEX")
                            {
                                if (lbStaff.Text == "Starter" && pStaff[num] == "S")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Reliever" && pStaff[num] == "R")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Closer" && pStaff[num] == "C")
                                {
                                    printPitchers();
                                }
                                if (lbStaff.Text == "All Positions")
                                {
                                    printPitchers();
                                }
                            }
                            if (lbMLBTeams.Text == "Arizona Diamondbacks" && team[num] == "ARI")
                            {
                                if (lbStaff.Text == "Starter" && pStaff[num] == "S")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Reliever" && pStaff[num] == "R")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Closer" && pStaff[num] == "C")
                                {
                                    printPitchers();
                                }
                                if (lbStaff.Text == "All Positions")
                                {
                                    printPitchers();
                                }
                            }
                            if (lbMLBTeams.Text == "Colorado Rockies" && team[num] == "COL")
                            {
                                if (lbStaff.Text == "Starter" && pStaff[num] == "S")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Reliever" && pStaff[num] == "R")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Closer" && pStaff[num] == "C")
                                {
                                    printPitchers();
                                }
                                if (lbStaff.Text == "All Positions")
                                {
                                    printPitchers();
                                }
                            }
                            if (lbMLBTeams.Text == "Los Angeles Dodgers" && team[num] == "LAD")
                            {
                                if (lbStaff.Text == "Starter" && pStaff[num] == "S")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Reliever" && pStaff[num] == "R")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Closer" && pStaff[num] == "C")
                                {
                                    printPitchers();
                                }
                                if (lbStaff.Text == "All Positions")
                                {
                                    printPitchers();
                                }
                            }
                            if (lbMLBTeams.Text == "San Francisco Giants" && team[num] == "SFG")
                            {
                                if (lbStaff.Text == "Starter" && pStaff[num] == "S")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Reliever" && pStaff[num] == "R")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Closer" && pStaff[num] == "C")
                                {
                                    printPitchers();
                                }
                                if (lbStaff.Text == "All Positions")
                                {
                                    printPitchers();
                                }
                            }
                            if (lbMLBTeams.Text == "San Diego Padres" && team[num] == "SDP")
                            {
                                if (lbStaff.Text == "Starter" && pStaff[num] == "S")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Reliever" && pStaff[num] == "R")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Closer" && pStaff[num] == "C")
                                {
                                    printPitchers();
                                }
                                if (lbStaff.Text == "All Positions")
                                {
                                    printPitchers();
                                }
                            }
                        }
                    }
                    else if (radEast.Checked && radAL.Checked)
                    {
                        if (league[num] == "AL" && division[num] == "E")
                        {
                            if (lbMLBTeams.Text == "All Teams")
                            {
                                if (lbStaff.Text == "Starter" && pStaff[num] == "S")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Reliever" && pStaff[num] == "R")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Closer" && pStaff[num] == "C")
                                {
                                    printPitchers();
                                }
                                if (lbStaff.Text == "All Positions")
                                {
                                    printPitchers();
                                }
                            }
                            if (lbMLBTeams.Text == "Baltimore Orioles" && team[num] == "BAL")
                            {
                                if (lbStaff.Text == "Starter" && pStaff[num] == "S")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Reliever" && pStaff[num] == "R")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Closer" && pStaff[num] == "C")
                                {
                                    printPitchers();
                                }
                                if (lbStaff.Text == "All Positions")
                                {
                                    printPitchers();
                                }
                            }
                            if (lbMLBTeams.Text == "Boston Red Sox" && team[num] == "BOS")
                            {
                                if (lbStaff.Text == "Starter" && pStaff[num] == "S")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Reliever" && pStaff[num] == "R")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Closer" && pStaff[num] == "C")
                                {
                                    printPitchers();
                                }
                                if (lbStaff.Text == "All Positions")
                                {
                                    printPitchers();
                                }
                            }
                            if (lbMLBTeams.Text == "New York Yankees" && team[num] == "NYY")
                            {
                                if (lbStaff.Text == "Starter" && pStaff[num] == "S")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Reliever" && pStaff[num] == "R")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Closer" && pStaff[num] == "C")
                                {
                                    printPitchers();
                                }
                                if (lbStaff.Text == "All Positions")
                                {
                                    printPitchers();
                                }
                            }
                            if (lbMLBTeams.Text == "Tampa Bay Rays" && team[num] == "TBR")
                            {
                                if (lbStaff.Text == "Starter" && pStaff[num] == "S")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Reliever" && pStaff[num] == "R")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Closer" && pStaff[num] == "C")
                                {
                                    printPitchers();
                                }
                                if (lbStaff.Text == "All Positions")
                                {
                                    printPitchers();
                                }
                            }
                            if (lbMLBTeams.Text == "Toronto Blue Jays" && team[num] == "TOR")
                            {
                                if (lbStaff.Text == "Starter" && pStaff[num] == "S")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Reliever" && pStaff[num] == "R")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Closer" && pStaff[num] == "C")
                                {
                                    printPitchers();
                                }
                                if (lbStaff.Text == "All Positions")
                                {
                                    printPitchers();
                                }
                            }
                        }
                    }
                    else if (radCentral.Checked && radAL.Checked)
                    {
                        if (league[num] == "AL" && division[num] == "C")
                        {
                            if (lbMLBTeams.Text == "All Teams")
                            {
                                if (lbStaff.Text == "Starter" && pStaff[num] == "S")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Reliever" && pStaff[num] == "R")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Closer" && pStaff[num] == "C")
                                {
                                    printPitchers();
                                }
                                if (lbStaff.Text == "All Positions")
                                {
                                    printPitchers();
                                }
                            }
                            if (lbMLBTeams.Text == "Chicago White Sox" && team[num] == "CWS")
                            {
                                if (lbStaff.Text == "Starter" && pStaff[num] == "S")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Reliever" && pStaff[num] == "R")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Closer" && pStaff[num] == "C")
                                {
                                    printPitchers();
                                }
                                if (lbStaff.Text == "All Positions")
                                {
                                    printPitchers();
                                }
                            }
                            if (lbMLBTeams.Text == "Cleveland Guardians" && team[num] == "CLE")
                            {
                                if (lbStaff.Text == "Starter" && pStaff[num] == "S")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Reliever" && pStaff[num] == "R")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Closer" && pStaff[num] == "C")
                                {
                                    printPitchers();
                                }
                                if (lbStaff.Text == "All Positions")
                                {
                                    printPitchers();
                                }
                            }
                            if (lbMLBTeams.Text == "Detroit Tigers" && team[num] == "DET")
                            {
                                if (lbStaff.Text == "Starter" && pStaff[num] == "S")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Reliever" && pStaff[num] == "R")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Closer" && pStaff[num] == "C")
                                {
                                    printPitchers();
                                }
                                if (lbStaff.Text == "All Positions")
                                {
                                    printPitchers();
                                }
                            }
                            if (lbMLBTeams.Text == "Kansas City Royals" && team[num] == "KCR")
                            {
                                if (lbStaff.Text == "Starter" && pStaff[num] == "S")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Reliever" && pStaff[num] == "R")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Closer" && pStaff[num] == "C")
                                {
                                    printPitchers();
                                }
                                if (lbStaff.Text == "All Positions")
                                {
                                    printPitchers();
                                }
                            }
                            if (lbMLBTeams.Text == "Minnesota Twins" && team[num] == "MIN")
                            {
                                if (lbStaff.Text == "Starter" && pStaff[num] == "S")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Reliever" && pStaff[num] == "R")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Closer" && pStaff[num] == "C")
                                {
                                    printPitchers();
                                }
                                if (lbStaff.Text == "All Positions")
                                {
                                    printPitchers();
                                }
                            }
                        }
                    }
                    else if (radWest.Checked && radAL.Checked)
                    {
                        if (league[num] == "AL" && division[num] == "W")
                        {
                            if (lbMLBTeams.Text == "All Teams")
                            {
                                if (lbStaff.Text == "Starter" && pStaff[num] == "S")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Reliever" && pStaff[num] == "R")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Closer" && pStaff[num] == "C")
                                {
                                    printPitchers();
                                }
                                if (lbStaff.Text == "All Positions")
                                {
                                    printPitchers();
                                }
                            }
                            if (lbMLBTeams.Text == "Houston Astros" && team[num] == "HOU")
                            {
                                if (lbStaff.Text == "Starter" && pStaff[num] == "S")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Reliever" && pStaff[num] == "R")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Closer" && pStaff[num] == "C")
                                {
                                    printPitchers();
                                }
                                if (lbStaff.Text == "All Positions")
                                {
                                    printPitchers();
                                }
                            }
                            if (lbMLBTeams.Text == "Los Angeles Angels" && team[num] == "LAA")
                            {
                                if (lbStaff.Text == "Starter" && pStaff[num] == "S")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Reliever" && pStaff[num] == "R")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Closer" && pStaff[num] == "C")
                                {
                                    printPitchers();
                                }
                                if (lbStaff.Text == "All Positions")
                                {
                                    printPitchers();
                                }
                            }
                            if (lbMLBTeams.Text == "Oakland Athletics" && team[num] == "OAK")
                            {
                                if (lbStaff.Text == "Starter" && pStaff[num] == "S")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Reliever" && pStaff[num] == "R")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Closer" && pStaff[num] == "C")
                                {
                                    printPitchers();
                                }
                                if (lbStaff.Text == "All Positions")
                                {
                                    printPitchers();
                                }
                            }
                            if (lbMLBTeams.Text == "Seattle Mariners" && team[num] == "SEA")
                            {
                                if (lbStaff.Text == "Starter" && pStaff[num] == "S")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Reliever" && pStaff[num] == "R")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Closer" && pStaff[num] == "C")
                                {
                                    printPitchers();
                                }
                                if (lbStaff.Text == "All Positions")
                                {
                                    printPitchers();
                                }
                            }
                            if (lbMLBTeams.Text == "Texas Rangers" && team[num] == "TEX")
                            {
                                if (lbStaff.Text == "Starter" && pStaff[num] == "S")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Reliever" && pStaff[num] == "R")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Closer" && pStaff[num] == "C")
                                {
                                    printPitchers();
                                }
                                if (lbStaff.Text == "All Positions")
                                {
                                    printPitchers();
                                }
                            }
                        }
                    }
                    else if (radEast.Checked && radNL.Checked)
                    {
                        if (league[num] == "NL" && division[num] == "E")
                        {
                            if (lbMLBTeams.Text == "All Teams")
                            {
                                if (lbStaff.Text == "Starter" && pStaff[num] == "S")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Reliever" && pStaff[num] == "R")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Closer" && pStaff[num] == "C")
                                {
                                    printPitchers();
                                }
                                if (lbStaff.Text == "All Positions")
                                {
                                    printPitchers();
                                }
                            }
                            if (lbMLBTeams.Text == "Atlanta Braves" && team[num] == "ATL")
                            {
                                if (lbStaff.Text == "Starter" && pStaff[num] == "S")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Reliever" && pStaff[num] == "R")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Closer" && pStaff[num] == "C")
                                {
                                    printPitchers();
                                }
                                if (lbStaff.Text == "All Positions")
                                {
                                    printPitchers();
                                }
                            }
                            if (lbMLBTeams.Text == "Miami Marlins" && team[num] == "MIA")
                            {
                                if (lbStaff.Text == "Starter" && pStaff[num] == "S")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Reliever" && pStaff[num] == "R")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Closer" && pStaff[num] == "C")
                                {
                                    printPitchers();
                                }
                                if (lbStaff.Text == "All Positions")
                                {
                                    printPitchers();
                                }
                            }
                            if (lbMLBTeams.Text == "New York Mets" && team[num] == "NYM")
                            {
                                if (lbStaff.Text == "Starter" && pStaff[num] == "S")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Reliever" && pStaff[num] == "R")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Closer" && pStaff[num] == "C")
                                {
                                    printPitchers();
                                }
                                if (lbStaff.Text == "All Positions")
                                {
                                    printPitchers();
                                }
                            }
                            if (lbMLBTeams.Text == "Philadelphia Phillies" && team[num] == "PHI")
                            {
                                if (lbStaff.Text == "Starter" && pStaff[num] == "S")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Reliever" && pStaff[num] == "R")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Closer" && pStaff[num] == "C")
                                {
                                    printPitchers();
                                }
                                if (lbStaff.Text == "All Positions")
                                {
                                    printPitchers();
                                }
                            }
                            if (lbMLBTeams.Text == "Washington Nationals" && team[num] == "WSN")
                            {
                                if (lbStaff.Text == "Starter" && pStaff[num] == "S")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Reliever" && pStaff[num] == "R")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Closer" && pStaff[num] == "C")
                                {
                                    printPitchers();
                                }
                                if (lbStaff.Text == "All Positions")
                                {
                                    printPitchers();
                                }
                            }
                        }
                    }
                    else if (radWest.Checked && radNL.Checked)
                    {
                        if (league[num] == "NL" && division[num] == "W")
                        {
                            if (lbMLBTeams.Text == "All Teams")
                            {
                                if (lbStaff.Text == "Starter" && pStaff[num] == "S")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Reliever" && pStaff[num] == "R")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Closer" && pStaff[num] == "C")
                                {
                                    printPitchers();
                                }
                                if (lbStaff.Text == "All Positions")
                                {
                                    printPitchers();
                                }
                            }
                            if (lbMLBTeams.Text == "Arizona Diamondbacks" && team[num] == "ARI")
                            {
                                if (lbStaff.Text == "Starter" && pStaff[num] == "S")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Reliever" && pStaff[num] == "R")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Closer" && pStaff[num] == "C")
                                {
                                    printPitchers();
                                }
                                if (lbStaff.Text == "All Positions")
                                {
                                    printPitchers();
                                }
                            }
                            if (lbMLBTeams.Text == "Colorado Rockies" && team[num] == "COL")
                            {
                                if (lbStaff.Text == "Starter" && pStaff[num] == "S")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Reliever" && pStaff[num] == "R")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Closer" && pStaff[num] == "C")
                                {
                                    printPitchers();
                                }
                                if (lbStaff.Text == "All Positions")
                                {
                                    printPitchers();
                                }
                            }
                            if (lbMLBTeams.Text == "Los Angeles Dodgers" && team[num] == "LAD")
                            {
                                if (lbStaff.Text == "Starter" && pStaff[num] == "S")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Reliever" && pStaff[num] == "R")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Closer" && pStaff[num] == "C")
                                {
                                    printPitchers();
                                }
                                if (lbStaff.Text == "All Positions")
                                {
                                    printPitchers();
                                }
                            }
                            if (lbMLBTeams.Text == "San Francisco Giants" && team[num] == "SFG")
                            {
                                if (lbStaff.Text == "Starter" && pStaff[num] == "S")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Reliever" && pStaff[num] == "R")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Closer" && pStaff[num] == "C")
                                {
                                    printPitchers();
                                }
                                if (lbStaff.Text == "All Positions")
                                {
                                    printPitchers();
                                }
                            }
                            if (lbMLBTeams.Text == "San Diego Padres" && team[num] == "SDP")
                            {
                                if (lbStaff.Text == "Starter" && pStaff[num] == "S")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Reliever" && pStaff[num] == "R")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Closer" && pStaff[num] == "C")
                                {
                                    printPitchers();
                                }
                                if (lbStaff.Text == "All Positions")
                                {
                                    printPitchers();
                                }
                            }
                        }
                    }
                    else if (radCentral.Checked && radNL.Checked)
                    {
                        if (league[num] == "NL" && division[num] == "C")
                        {
                            if (lbMLBTeams.Text == "All Teams")
                            {
                                if (lbStaff.Text == "Starter" && pStaff[num] == "S")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Reliever" && pStaff[num] == "R")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Closer" && pStaff[num] == "C")
                                {
                                    printPitchers();
                                }
                                if (lbStaff.Text == "All Positions")
                                {
                                    printPitchers();
                                }
                            }
                            if (lbMLBTeams.Text == "Cincinnati Reds" && team[num] == "CIN")
                            {
                                if (lbStaff.Text == "Starter" && pStaff[num] == "S")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Reliever" && pStaff[num] == "R")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Closer" && pStaff[num] == "C")
                                {
                                    printPitchers();
                                }
                                if (lbStaff.Text == "All Positions")
                                {
                                    printPitchers();
                                }
                            }
                            if (lbMLBTeams.Text == "Chicago Cubs" && team[num] == "CHC")
                            {
                                if (lbStaff.Text == "Starter" && pStaff[num] == "S")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Reliever" && pStaff[num] == "R")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Closer" && pStaff[num] == "C")
                                {
                                    printPitchers();
                                }
                                if (lbStaff.Text == "All Positions")
                                {
                                    printPitchers();
                                }
                            }
                            if (lbMLBTeams.Text == "Milwaukee Brewers" && team[num] == "MIL")
                            {
                                if (lbStaff.Text == "Starter" && pStaff[num] == "S")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Reliever" && pStaff[num] == "R")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Closer" && pStaff[num] == "C")
                                {
                                    printPitchers();
                                }
                                if (lbStaff.Text == "All Positions")
                                {
                                    printPitchers();
                                }
                            }
                            if (lbMLBTeams.Text == "Pittsburgh Pirates" && team[num] == "PIT")
                            {
                                if (lbStaff.Text == "Starter" && pStaff[num] == "S")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Reliever" && pStaff[num] == "R")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Closer" && pStaff[num] == "C")
                                {
                                    printPitchers();
                                }
                                if (lbStaff.Text == "All Positions")
                                {
                                    printPitchers();
                                }
                            }
                            if (lbMLBTeams.Text == "St. Louis Cardinals" && team[num] == "STL")
                            {
                                if (lbStaff.Text == "Starter" && pStaff[num] == "S")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Reliever" && pStaff[num] == "R")
                                {
                                    printPitchers();
                                }
                                else if (lbStaff.Text == "Closer" && pStaff[num] == "C")
                                {
                                    printPitchers();
                                }
                                if (lbStaff.Text == "All Positions")
                                {
                                    printPitchers();
                                }
                            }
                        }
                    }
                }
            }
        }

        private void printHitters()
        {
            rtbOut.AppendText(team[num].PadRight(5) + (name[num]).PadRight(20));

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

        private void printPitchers()
        {
            rtbOut.AppendText(pTeam[num].PadRight(5) + (pName[num]).PadRight(20));

            if (cbWins.Checked)
                rtbOut.AppendText(Wins[num].ToString("n0").PadLeft(4));

            if (cbLosses.Checked)
                rtbOut.AppendText(Losses[num].ToString("n0").PadLeft(4));

            if (cbGames.Checked)
                rtbOut.AppendText(Games[num].ToString("n0").PadLeft(4));

            if (cbGS.Checked)
                rtbOut.AppendText(GamesStarted[num].ToString("n0").PadLeft(4));

            if (cbSV.Checked)
                rtbOut.AppendText(Saves[num].ToString("n0").PadLeft(4));

            if (cbIP.Checked)
                rtbOut.AppendText(InningsPitched[num].ToString("n1").PadLeft(6));

            if (cbPitcherH.Checked)
                rtbOut.AppendText(pHits[num].ToString("n0").PadLeft(4));

            if (cbTotalRuns.Checked)
                rtbOut.AppendText(pRuns[num].ToString("n0").PadLeft(4));

            if (cbER.Checked)
                rtbOut.AppendText(EarnedRuns[num].ToString("n0").PadLeft(4));

            if (cbHRGivenUp.Checked)
                rtbOut.AppendText(pHomeruns[num].ToString("n0").PadLeft(4));

            if (cbPBB.Checked)
                rtbOut.AppendText(pWalks[num].ToString("n0").PadLeft(4));

            if (cbPIBB.Checked)
                rtbOut.AppendText(pIntentionalWalks[num].ToString("n0").PadLeft(4));

            if (cbPSO.Checked)
                rtbOut.AppendText(pStrikeOuts[num].ToString("n0").PadLeft(4));

            if (cbPHBP.Checked)
                rtbOut.AppendText(pHitbyPitches[num].ToString("n0").PadLeft(4));

            if (cbBF.Checked)
                rtbOut.AppendText(battersFaced[num].ToString("n0").PadLeft(4));

            if (cbERA.Checked)
                rtbOut.AppendText(ERA[num].ToString("n2").PadLeft(6));

            if (cbERAPlus.Checked)
                rtbOut.AppendText(ERAPlus[num].ToString("n0").PadLeft(5));

            if (cbWPCT.Checked)
                rtbOut.AppendText(WinPercentage[num].ToString("n3").PadLeft(6));

            if (cbWHIP.Checked)
                rtbOut.AppendText(WalksPlusHitsPerInningsPitched[num].ToString("n3").PadLeft(6));

            if (cbHRper9.Checked)
                rtbOut.AppendText(HomeRunsPer9[num].ToString("n1").PadLeft(5));

            if (cbHitsPer9.Checked)
                rtbOut.AppendText(HitsPer9[num].ToString("n1").PadLeft(5));

            if (cbBBper9.Checked)
                rtbOut.AppendText(WalksPer9[num].ToString("n1").PadLeft(5));

            if (cbSOper9.Checked)
                rtbOut.AppendText(StrikeoutsPer9[num].ToString("n1").PadLeft(5));

            rtbOut.AppendText("\n");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radHitters_CheckedChanged(object sender, EventArgs e)
        {
            gbNLorAL.Visible = true;
            gbBasicStats.Visible = true;
            cbPA.Visible = true;
            cbAB.Visible = true;
            cbR.Visible = true;
            cbH.Visible = true;
            cb2B.Visible = true;
            cb3B.Visible = true;
            cbHR.Visible = true;
            cbRBI.Visible = true;
            cbSB.Visible = true;
            cbCS.Visible = true;
            cbBB.Visible = true;
            cbSO.Visible = true;
            cbAVG.Visible = true;
            cbOBP.Visible = true;
            cbSLG.Visible = true;
            cbOPS.Visible = true;
            gbAdvanced.Visible = true;
            lbMLBTeams.Visible = true;
            lbHitterPosition.Visible = true;
            gbDivisions.Visible = true;
            cbBABIP.Visible = true;
            cbISO.Visible = true;
            cbOPSPlus.Visible = true;
            cbPASO.Visible = true;
            cbRC.Visible = true;
            cbwRCPlus.Visible = true;
            cbwOBA.Visible = true;
            cbwRAA.Visible = true;
            cbTB.Visible = true;
            cbHBP.Visible   = true;
            cbIBB.Visible = true;
            cbSF.Visible = true;
        }

        private void radPitchers_CheckedChanged(object sender, EventArgs e)
        {
            gbNLorAL.Visible = true;
            lbMLBTeams.Visible = true;
            gbBasicStats.Visible = true;
            cbWins.Visible = true;
            cbLosses.Visible = true;
            cbGames.Visible = true;
            cbGS.Visible = true;
            cbSV.Visible = true;
            cbIP.Visible = true;
            cbPitcherH.Visible = true;
            cbTotalRuns.Visible = true;
            cbER.Visible = true;
            cbHRGivenUp.Visible = true;
            cbPBB.Visible = true;
            cbPIBB.Visible  = true;
            cbPSO.Visible = true;
            cbPHBP.Visible = true;
            cbBF.Visible = true;
            lbStaff.Visible = true;
            gbDivisions.Visible = true;
            gbAdvanced.Visible = true;
            cbERA.Visible = true;
            cbERAPlus.Visible = true;
            cbWPCT.Visible = true;
            cbWHIP.Visible = true;
            cbHRper9.Visible = true;
            cbHitsPer9.Visible = true;
            cbBBper9.Visible = true;
            cbSOper9.Visible = true;
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
                rtbOut.AppendText("Pitchers Stats:\n\n" +
                "W     - Wins\n" +
                "L     - Losses\n" +
                "G     - Games\n" +
                "GS    - Games Started\n" +
                "SV    - Saves\n" +
                "IP    - Innings Pitched\n" +
                "H     - Hits\n" +
                "R     - Runs\n" +
                "ER    - Earned Runs\n" +
                "HR    - Home Runs\n" +
                "BB    - Walks\n" +
                "IBB   - Intentional Walks\n" +
                "SO    - Strikeouts\n" +
                "HBP   - Hit by Pitches\n" +
                "BF    - Batters Faces\n");
            }
            else if (radNBA.Checked)
            {

            }
            else if (radWNBA.Checked)
            {

            }
        }

        private void labelCheck()
        {
            if(radHitters.Checked)
            {
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
            }
            else if (radPitchers.Checked)
            {
                if (cbWins.Checked)
                    rtbLabels.AppendText("   W");
                if (cbLosses.Checked)
                    rtbLabels.AppendText("   L");
                if (cbGames.Checked)
                    rtbLabels.AppendText("   G");
                if (cbGS.Checked)
                    rtbLabels.AppendText("  GS");
                if (cbSV.Checked)
                    rtbLabels.AppendText("  SV");
                if (cbIP.Checked)
                    rtbLabels.AppendText("    IP");
                if (cbPitcherH.Checked)
                    rtbLabels.AppendText("   H");
                if (cbTotalRuns.Checked)
                    rtbLabels.AppendText("   R");
                if (cbER.Checked)
                    rtbLabels.AppendText("  ER");
                if (cbHRGivenUp.Checked)
                    rtbLabels.AppendText("  HR");
                if (cbPBB.Checked)
                    rtbLabels.AppendText("  BB");
                if (cbPIBB.Checked)
                    rtbLabels.AppendText(" IBB");
                if (cbPSO.Checked)
                    rtbLabels.AppendText("  SO");
                if (cbPHBP.Checked)
                    rtbLabels.AppendText(" HBP");
                if (cbBF.Checked)
                    rtbLabels.AppendText("  BF");
                if (cbERA.Checked)
                    rtbLabels.AppendText("   ERA");
                if (cbERAPlus.Checked)
                    rtbLabels.AppendText(" ERA+");
                if (cbWPCT.Checked)
                    rtbLabels.AppendText("  WPCT");
                if (cbWHIP.Checked)
                    rtbLabels.AppendText("  WHIP");
                if (cbHRper9.Checked)
                    rtbLabels.AppendText(" HR/9");
                if (cbHitsPer9.Checked)
                    rtbLabels.AppendText("  H/9");
                if (cbBBper9.Checked)
                    rtbLabels.AppendText(" BB/9");
                if (cbSOper9.Checked)
                    rtbLabels.AppendText(" SO/9");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string t = txtSearch.Text.ToUpper();

            for (int i = 0; i <= t.Length-1; i++)
            {
                if(t == name[i])
                {
                    rtbOut.Clear();
                    rtbLabels.Clear();
                    rtbLabels.AppendText("Team Player              ");
                    labelCheck();
                    printHitters();
                }
            }
        }
    }
}

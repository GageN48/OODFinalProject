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
    public partial class LeagueForm : Form
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
        double[] StrikeOutToWalk = new double[0];
        double[] WalkRate = new double[0];
        double[] StrikeOutRate = new double[0];
        double[] FieldingIndependentPitching = new double[0];

        int num = 0;
        string[] NBAname = new string[0];
        string[] NBAteam = new string[0];
        double[] NBAgamesplayed = new double[0];
        double[] NBAmintotal = new double[0];
        double[] NBAfgmakes = new double[0];
        double[] NBAfgattempts = new double[0];
        double[] NBAtpmakes = new double[0];
        double[] NBAtpattempts = new double[0];
        double[] NBAftmakes = new double[0];
        double[] NBAftattempts = new double[0];
        double[] NBAob = new double[0];
        double[] NBAdb = new double[0];
        double[] NBAassists = new double[0];
        double[] NBAblocks = new double[0];
        double[] NBAsteals = new double[0];
        double[] NBAto = new double[0];
        double[] NBAtotalpoints = new double[0];
        double[] NBAminutespergame = new double[0];
        double[] NBAfieldgoalpercentage = new double[0];
        double[] NBAthreepointpercentage = new double[0];
        double[] NBAfreethrowpercentage = new double[0];
        double[] NBAtrueshootingpercentage = new double[0];
        double[] NBAscoringefficiency = new double[0];
        double[] NBAshootingefficiency = new double[0];
        double[] NBAtrueshootingattempt = new double[0];
        double[] NBAstealspergame = new double[0];
        double[] NBAturnoverspergame = new double[0];
        double[] NBAassistspergame = new double[0];
        double[] NBAblockspergame = new double[0];
        double[] NBAassitstoturnovers = new double[0];
        double[] NBAreboundspergame = new double[0];
        string[] NBAPosition = new string[0];
        string[] NBAConference = new string[0];
        string[] NBADivision = new string[0];

        string[] WNBAname = new string[0];
        string[] WNBAteam = new string[0];
        double[] WNBAgamesplayed = new double[0];
        double[] WNBAfgmakes = new double[0];
        double[] WNBAfgattempts = new double[0];
        double[] WNBAtpmakes = new double[0];
        double[] WNBAtpattempts = new double[0];
        double[] WNBAftmakes = new double[0];
        double[] WNBAftattempts = new double[0];
        double[] WNBAob = new double[0];
        double[] WNBAdb = new double[0];
        double[] WNBAassists = new double[0];
        double[] WNBAblocks = new double[0];
        double[] WNBAsteals = new double[0];
        double[] WNBAto = new double[0];
        double[] WNBAtotalpoints = new double[0];
        double[] WNBAfieldgoalpercentage = new double[0];
        double[] WNBAthreepointpercentage = new double[0];
        double[] WNBAfreethrowpercentage = new double[0];
        double[] WNBAtrueshootingpercentage = new double[0];
        double[] WNBAscoringefficiency = new double[0];
        double[] WNBAshootingefficiency = new double[0];
        double[] WNBAtrueshootingattempt = new double[0];
        double[] WNBAstealspergame = new double[0];
        double[] WNBAturnoverspergame = new double[0];
        double[] WNBAassistspergame = new double[0];
        double[] WNBAblockspergame = new double[0];
        double[] WNBAassitstoturnovers = new double[0];
        double[] WNBAreboundspergame = new double[0];
        string[] WNBAPosition = new string[0];
        string[] WNBAConference = new string[0];

        string[] HNameS = new string[0];

        public LeagueForm()
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

                num = 0;

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
                double bf = 0;
                double phbp = 0;

                string path = @"Pitchers.csv";
                StreamReader textIn = new StreamReader(
                new FileStream(path, FileMode.Open, FileAccess.Read));

                labelCheck();

                num = 0;

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
                    phbp = Convert.ToDouble(record[18]);

                    Array.Resize<double>(ref battersFaced, battersFaced.Length + 1);
                    battersFaced[num] = Convert.ToDouble(record[19]);
                    bf = Convert.ToDouble(record[19]);

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

                    Array.Resize<double>(ref StrikeOutToWalk, StrikeOutToWalk.Length + 1);
                    var sobb = new Pitchers(k, bb, 0, 0, 0, 0, 0, 0, 0);
                    StrikeOutToWalk[num] = sobb.CalculateSOBB();

                    Array.Resize<double>(ref WalkRate, WalkRate.Length + 1);
                    var wr = new Pitchers(bf, bb, 0, 0, 0, 0, 0, 0, 0, 0);
                    WalkRate[num] = wr.CalculateWR();

                    Array.Resize<double>(ref StrikeOutRate, StrikeOutRate.Length + 1);
                    var sr = new Pitchers(bf, k, 0, 0, 0, 0, 0, 0, 0, 0, 0);
                    StrikeOutRate[num] = sr.CalculateSR();

                    Array.Resize<double>(ref FieldingIndependentPitching, FieldingIndependentPitching.Length + 1);
                    var fip = new Pitchers(ip, k, homeruns, bb, phbp, 0, 0, 0, 0, 0, 0, 0);
                    FieldingIndependentPitching[num] = fip.CalculateFIP();

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
                        if (lbMLBTeams.Text == "Baltimore Orioles" && pTeam[num] == "BAL")
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
                        if (lbMLBTeams.Text == "Boston Red Sox" && pTeam[num] == "BOS")
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
                        if (lbMLBTeams.Text == "New York Yankees" && pTeam[num] == "NYY")
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
                        if (lbMLBTeams.Text == "Tampa Bay Rays" && pTeam[num] == "TBR")
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
                        if (lbMLBTeams.Text == "Toronto Blue Jays" && pTeam[num] == "TOR")
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
                        if (lbMLBTeams.Text == "Chicago White Sox" && pTeam[num] == "CWS")
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
                        if (lbMLBTeams.Text == "Cleveland Guardians" && pTeam[num] == "CLE")
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
                        if (lbMLBTeams.Text == "Detroit Tigers" && pTeam[num] == "DET")
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
                        if (lbMLBTeams.Text == "Kansas City Royals" && pTeam[num] == "KCR")
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
                        if (lbMLBTeams.Text == "Minnesota Twins" && pTeam[num] == "MIN")
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
                        if (lbMLBTeams.Text == "Houston Astros" && pTeam[num] == "HOU")
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
                        if (lbMLBTeams.Text == "Los Angeles Angels" && pTeam[num] == "LAA")
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
                        if (lbMLBTeams.Text == "Oakland Athletics" && pTeam[num] == "OAK")
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
                        if (lbMLBTeams.Text == "Seattle Mariners" && pTeam[num] == "SEA")
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
                        if (lbMLBTeams.Text == "Texas Rangers" && pTeam[num] == "TEX")
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
                        if (lbMLBTeams.Text == "Atlanta Braves" && pTeam[num] == "ATL")
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
                        if (lbMLBTeams.Text == "Miami Marlins" && pTeam[num] == "MIA")
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
                        if (lbMLBTeams.Text == "New York Mets" && pTeam[num] == "NYM")
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
                        if (lbMLBTeams.Text == "Philadelphia Phillies" && pTeam[num] == "PHI")
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
                        if (lbMLBTeams.Text == "Washington Nationals" && pTeam[num] == "WSN")
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
                        if (lbMLBTeams.Text == "Cincinnati Reds" && pTeam[num] == "CIN")
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
                        if (lbMLBTeams.Text == "Chicago Cubs" && pTeam[num] == "CHC")
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
                        if (lbMLBTeams.Text == "Milwaukee Brewers" && pTeam[num] == "MIL")
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
                        if (lbMLBTeams.Text == "Pittsburgh Pirates" && pTeam[num] == "PIT")
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
                        if (lbMLBTeams.Text == "St. Louis Cardinals" && pTeam[num] == "STL")
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
                        if (lbMLBTeams.Text == "Arizona Diamondbacks" && pTeam[num] == "ARI")
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
                        if (lbMLBTeams.Text == "Colorado Rockies" && pTeam[num] == "COL")
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
                        if (lbMLBTeams.Text == "Los Angeles Dodgers" && pTeam[num] == "LAD")
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
                        if (lbMLBTeams.Text == "San Francisco Giants" && pTeam[num] == "SFG")
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
                        if (lbMLBTeams.Text == "San Diego Padres" && pTeam[num] == "SDP")
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
                        if (pLeague[num] == "AL")
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
                            if (lbMLBTeams.Text == "Baltimore Orioles" && pTeam[num] == "BAL")
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
                            if (lbMLBTeams.Text == "Boston Red Sox" && pTeam[num] == "BOS")
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
                            if (lbMLBTeams.Text == "New York Yankees" && pTeam[num] == "NYY")
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
                            if (lbMLBTeams.Text == "Tampa Bay Rays" && pTeam[num] == "TBR")
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
                            if (lbMLBTeams.Text == "Toronto Blue Jays" && pTeam[num] == "TOR")
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
                            if (lbMLBTeams.Text == "Chicago White Sox" && pTeam[num] == "CWS")
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
                            if (lbMLBTeams.Text == "Cleveland Guardians" && pTeam[num] == "CLE")
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
                            if (lbMLBTeams.Text == "Detroit Tigers" && pTeam[num] == "DET")
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
                            if (lbMLBTeams.Text == "Kansas City Royals" && pTeam[num] == "KCR")
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
                            if (lbMLBTeams.Text == "Minnesota Twins" && pTeam[num] == "MIN")
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
                            if (lbMLBTeams.Text == "Houston Astros" && pTeam[num] == "HOU")
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
                            if (lbMLBTeams.Text == "Los Angeles Angels" && pTeam[num] == "LAA")
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
                            if (lbMLBTeams.Text == "Oakland Athletics" && pTeam[num] == "OAK")
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
                            if (lbMLBTeams.Text == "Seattle Mariners" && pTeam[num] == "SEA")
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
                            if (lbMLBTeams.Text == "Texas Rangers" && pTeam[num] == "TEX")
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
                        if (pLeague[num] == "NL")
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
                            if (lbMLBTeams.Text == "Atlanta Braves" && pTeam[num] == "ATL")
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
                            if (lbMLBTeams.Text == "Miami Marlins" && pTeam[num] == "MIA")
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
                            if (lbMLBTeams.Text == "New York Mets" && pTeam[num] == "NYM")
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
                            if (lbMLBTeams.Text == "Philadelphia Phillies" && pTeam[num] == "PHI")
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
                            if (lbMLBTeams.Text == "Washington Nationals" && pTeam[num] == "WSN")
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
                            if (lbMLBTeams.Text == "Cincinnati Reds" && pTeam[num] == "CIN")
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
                            if (lbMLBTeams.Text == "Chicago Cubs" && pTeam[num] == "CHC")
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
                            if (lbMLBTeams.Text == "Milwaukee Brewers" && pTeam[num] == "MIL")
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
                            if (lbMLBTeams.Text == "Pittsburgh Pirates" && pTeam[num] == "PIT")
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
                            if (lbMLBTeams.Text == "St. Louis Cardinals" && pTeam[num] == "STL")
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
                            if (lbMLBTeams.Text == "Arizona Diamondbacks" && pTeam[num] == "ARI")
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
                            if (lbMLBTeams.Text == "Colorado Rockies" && pTeam[num] == "COL")
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
                            if (lbMLBTeams.Text == "Los Angeles Dodgers" && pTeam[num] == "LAD")
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
                            if (lbMLBTeams.Text == "San Francisco Giants" && pTeam[num] == "SFG")
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
                            if (lbMLBTeams.Text == "San Diego Padres" && pTeam[num] == "SDP")
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
                        if (pDivisions[num] == "E")
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
                            if (lbMLBTeams.Text == "Baltimore Orioles" && pTeam[num] == "BAL")
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
                            if (lbMLBTeams.Text == "Boston Red Sox" && pTeam[num] == "BOS")
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
                            if (lbMLBTeams.Text == "New York Yankees" && pTeam[num] == "NYY")
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
                            if (lbMLBTeams.Text == "Tampa Bay Rays" && pTeam[num] == "TBR")
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
                            if (lbMLBTeams.Text == "Toronto Blue Jays" && pTeam[num] == "TOR")
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
                            if (lbMLBTeams.Text == "Atlanta Braves" && pTeam[num] == "ATL")
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
                            if (lbMLBTeams.Text == "Miami Marlins" && pTeam[num] == "MIA")
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
                            if (lbMLBTeams.Text == "New York Mets" && pTeam[num] == "NYM")
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
                            if (lbMLBTeams.Text == "Philadelphia Phillies" && pTeam[num] == "PHI")
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
                            if (lbMLBTeams.Text == "Washington Nationals" && pTeam[num] == "WSN")
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
                        if (pDivisions[num] == "C")
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
                            if (lbMLBTeams.Text == "Chicago White Sox" && pTeam[num] == "CWS")
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
                            if (lbMLBTeams.Text == "Cleveland Guardians" && pTeam[num] == "CLE")
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
                            if (lbMLBTeams.Text == "Detroit Tigers" && pTeam[num] == "DET")
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
                            if (lbMLBTeams.Text == "Kansas City Royals" && pTeam[num] == "KCR")
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
                            if (lbMLBTeams.Text == "Minnesota Twins" && pTeam[num] == "MIN")
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
                            if (lbMLBTeams.Text == "Cincinnati Reds" && pTeam[num] == "CIN")
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
                            if (lbMLBTeams.Text == "Chicago Cubs" && pTeam[num] == "CHC")
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
                            if (lbMLBTeams.Text == "Milwaukee Brewers" && pTeam[num] == "MIL")
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
                            if (lbMLBTeams.Text == "Pittsburgh Pirates" && pTeam[num] == "PIT")
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
                            if (lbMLBTeams.Text == "St. Louis Cardinals" && pTeam[num] == "STL")
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
                        if (pDivisions[num] == "W")
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
                            if (lbMLBTeams.Text == "Houston Astros" && pTeam[num] == "HOU")
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
                            if (lbMLBTeams.Text == "Los Angeles Angels" && pTeam[num] == "LAA")
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
                            if (lbMLBTeams.Text == "Oakland Athletics" && pTeam[num] == "OAK")
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
                            if (lbMLBTeams.Text == "Seattle Mariners" && pTeam[num] == "SEA")
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
                            if (lbMLBTeams.Text == "Texas Rangers" && pTeam[num] == "TEX")
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
                            if (lbMLBTeams.Text == "Arizona Diamondbacks" && pTeam[num] == "ARI")
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
                            if (lbMLBTeams.Text == "Colorado Rockies" && pTeam[num] == "COL")
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
                            if (lbMLBTeams.Text == "Los Angeles Dodgers" && pTeam[num] == "LAD")
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
                            if (lbMLBTeams.Text == "San Francisco Giants" && pTeam[num] == "SFG")
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
                            if (lbMLBTeams.Text == "San Diego Padres" && pTeam[num] == "SDP")
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
                        if (pLeague[num] == "AL" && pDivisions[num] == "E")
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
                            if (lbMLBTeams.Text == "Baltimore Orioles" && pTeam[num] == "BAL")
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
                            if (lbMLBTeams.Text == "Boston Red Sox" && pTeam[num] == "BOS")
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
                            if (lbMLBTeams.Text == "New York Yankees" && pTeam[num] == "NYY")
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
                            if (lbMLBTeams.Text == "Tampa Bay Rays" && pTeam[num] == "TBR")
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
                            if (lbMLBTeams.Text == "Toronto Blue Jays" && pTeam[num] == "TOR")
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
                        if (pLeague[num] == "AL" && pDivisions[num] == "C")
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
                            if (lbMLBTeams.Text == "Chicago White Sox" && pTeam[num] == "CWS")
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
                            if (lbMLBTeams.Text == "Cleveland Guardians" && pTeam[num] == "CLE")
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
                            if (lbMLBTeams.Text == "Detroit Tigers" && pTeam[num] == "DET")
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
                            if (lbMLBTeams.Text == "Kansas City Royals" && pTeam[num] == "KCR")
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
                            if (lbMLBTeams.Text == "Minnesota Twins" && pTeam[num] == "MIN")
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
                        if (pLeague[num] == "AL" && pDivisions[num] == "W")
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
                            if (lbMLBTeams.Text == "Houston Astros" && pTeam[num] == "HOU")
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
                            if (lbMLBTeams.Text == "Los Angeles Angels" && pTeam[num] == "LAA")
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
                            if (lbMLBTeams.Text == "Oakland Athletics" && pTeam[num] == "OAK")
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
                            if (lbMLBTeams.Text == "Seattle Mariners" && pTeam[num] == "SEA")
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
                            if (lbMLBTeams.Text == "Texas Rangers" && pTeam[num] == "TEX")
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
                        if (pLeague[num] == "NL" && pDivisions[num] == "E")
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
                            if (lbMLBTeams.Text == "Atlanta Braves" && pTeam[num] == "ATL")
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
                            if (lbMLBTeams.Text == "Miami Marlins" && pTeam[num] == "MIA")
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
                            if (lbMLBTeams.Text == "New York Mets" && pTeam[num] == "NYM")
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
                            if (lbMLBTeams.Text == "Philadelphia Phillies" && pTeam[num] == "PHI")
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
                            if (lbMLBTeams.Text == "Washington Nationals" && pTeam[num] == "WSN")
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
                        if (pLeague[num] == "NL" && pDivisions[num] == "W")
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
                            if (lbMLBTeams.Text == "Arizona Diamondbacks" && pTeam[num] == "ARI")
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
                            if (lbMLBTeams.Text == "Colorado Rockies" && pTeam[num] == "COL")
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
                            if (lbMLBTeams.Text == "Los Angeles Dodgers" && pTeam[num] == "LAD")
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
                            if (lbMLBTeams.Text == "San Francisco Giants" && pTeam[num] == "SFG")
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
                            if (lbMLBTeams.Text == "San Diego Padres" && pTeam[num] == "SDP")
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
                        if (pLeague[num] == "NL" && pDivisions[num] == "C")
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
                            if (lbMLBTeams.Text == "Cincinnati Reds" && pTeam[num] == "CIN")
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
                            if (lbMLBTeams.Text == "Chicago Cubs" && pTeam[num] == "CHC")
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
                            if (lbMLBTeams.Text == "Milwaukee Brewers" && pTeam[num] == "MIL")
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
                            if (lbMLBTeams.Text == "Pittsburgh Pirates" && pTeam[num] == "PIT")
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
                            if (lbMLBTeams.Text == "St. Louis Cardinals" && pTeam[num] == "STL")
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
            else if (radNBA.Checked)
            {
                rtbLabels.AppendText("Team          Player                  ");

                double m = 0;
                double g = 0;
                double fgm = 0;
                double fga = 0;
                double tpm = 0;
                double tpa = 0;
                double ftm = 0;
                double fta = 0;
                double pt = 0;
                double tsa = 0;
                double or = 0;
                double dr = 0;
                double a = 0;
                double s = 0;
                double b = 0;
                double t = 0;


                string path = @"NBATeamsStats.csv";
                StreamReader textIn = new StreamReader(
                new FileStream(path, FileMode.Open, FileAccess.Read));

                labelCheck();

                num = 0;

                while (textIn.Peek() != -1)
                {
                    Array.Resize<string>(ref NBAteam, NBAteam.Length + 1);
                    Array.Resize<string>(ref NBAname, NBAname.Length + 1);
                    Array.Resize<string>(ref NBAPosition, NBAPosition.Length + 1);
                    Array.Resize<string>(ref NBAConference, NBAConference.Length + 1);
                    Array.Resize<string>(ref NBADivision, NBADivision.Length + 1);

                    string row = textIn.ReadLine();
                    string[] record = row.Split(',');
                    NBAteam[num] = Convert.ToString(record[2]).ToUpper();
                    NBAname[num] = Convert.ToString(record[3] + " " + record[4]).ToUpper();
                    NBAPosition[num] = Convert.ToString(record[5]).ToUpper();
                    NBAConference[num] = Convert.ToString(record[0]).ToUpper();
                    NBADivision[num] = Convert.ToString(record[1]).ToUpper();

                    Array.Resize<double>(ref NBAgamesplayed, NBAgamesplayed.Length + 1);
                    NBAgamesplayed[num] = Convert.ToDouble(record[6]);
                    g = Convert.ToDouble(record[6]);

                    Array.Resize<double>(ref NBAmintotal, NBAmintotal.Length + 1);
                    NBAmintotal[num] = Convert.ToDouble(record[7]);
                    m = Convert.ToDouble(record[7]);

                    Array.Resize<double>(ref NBAfgmakes, NBAfgmakes.Length + 1);
                    NBAfgmakes[num] = Convert.ToDouble(record[8]);
                    fgm = Convert.ToDouble(record[8]);

                    Array.Resize<double>(ref NBAfgattempts, NBAfgattempts.Length + 1);
                    NBAfgattempts[num] = Convert.ToDouble(record[9]);
                    fga = Convert.ToDouble(record[9]);

                    Array.Resize<double>(ref NBAtpmakes, NBAtpmakes.Length + 1);
                    NBAtpmakes[num] = Convert.ToDouble(record[10]);
                    tpm = Convert.ToDouble(record[10]);

                    Array.Resize<double>(ref NBAtpattempts, NBAtpattempts.Length + 1);
                    NBAtpattempts[num] = Convert.ToDouble(record[11]);
                    tpa = Convert.ToDouble(record[11]);

                    Array.Resize<double>(ref NBAftmakes, NBAftmakes.Length + 1);
                    NBAftmakes[num] = Convert.ToDouble(record[12]);
                    ftm = Convert.ToDouble(record[12]);

                    Array.Resize<double>(ref NBAftattempts, NBAftattempts.Length + 1);
                    NBAftattempts[num] = Convert.ToDouble(record[13]);
                    fta = Convert.ToDouble(record[13]);

                    Array.Resize<double>(ref NBAob, NBAob.Length + 1);
                    NBAob[num] = Convert.ToDouble(record[14]);
                    or = Convert.ToDouble(record[14]);

                    Array.Resize<double>(ref NBAdb, NBAdb.Length + 1);
                    NBAdb[num] = Convert.ToDouble(record[15]);
                    dr = Convert.ToDouble(record[15]);

                    Array.Resize<double>(ref NBAassists, NBAassists.Length + 1);
                    NBAassists[num] = Convert.ToDouble(record[16]);
                    a = Convert.ToDouble(record[16]);

                    Array.Resize<double>(ref NBAblocks, NBAblocks.Length + 1);
                    NBAblocks[num] = Convert.ToDouble(record[17]);
                    b = Convert.ToDouble(record[17]);

                    Array.Resize<double>(ref NBAsteals, NBAsteals.Length + 1);
                    NBAsteals[num] = Convert.ToDouble(record[18]);
                    s = Convert.ToDouble(record[18]);

                    Array.Resize<double>(ref NBAto, NBAto.Length + 1);
                    NBAto[num] = Convert.ToDouble(record[19]);
                    t = Convert.ToDouble(record[19]);

                    Array.Resize<double>(ref NBAtotalpoints, NBAtotalpoints.Length + 1);
                    NBAtotalpoints[num] = Convert.ToDouble(record[20]);
                    pt = Convert.ToDouble(record[20]);

                    Array.Resize<double>(ref NBAminutespergame, NBAminutespergame.Length + 1);
                    var MPG = new NBA(g, m);
                    NBAminutespergame[num] = MPG.CalculateMPG();

                    Array.Resize<double>(ref NBAfieldgoalpercentage, NBAfieldgoalpercentage.Length + 1);
                    var FGP = new NBA(fgm, fga, 0);
                    NBAfieldgoalpercentage[num] = FGP.CalculateFGP();

                    Array.Resize<double>(ref NBAthreepointpercentage, NBAthreepointpercentage.Length + 1);
                    var TPP = new NBA(tpm, tpa, 0, 0);
                    NBAthreepointpercentage[num] = TPP.CalculateTPP();

                    Array.Resize<double>(ref NBAfreethrowpercentage, NBAfreethrowpercentage.Length + 1);
                    var FTP = new NBA(ftm, fta, 0, 0, 0);
                    NBAfreethrowpercentage[num] = FTP.CalculateFTP();

                    Array.Resize<double>(ref NBAtrueshootingattempt, NBAtrueshootingattempt.Length + 1);
                    var TSA = new NBA(fga, fta, 0, 0, 0, 0);
                    NBAtrueshootingattempt[num] = TSA.CalculateTSA();
                    tsa = NBAtrueshootingattempt[num];

                    Array.Resize<double>(ref NBAtrueshootingpercentage, NBAtrueshootingpercentage.Length + 1);
                    var TS = new NBA(pt, tsa, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
                    NBAtrueshootingpercentage[num] = TS.CalculateTS();

                    Array.Resize<double>(ref NBAscoringefficiency, NBAscoringefficiency.Length + 1);
                    var SCEFF = new NBA(pt, or, dr, a, s, b, t, g);
                    NBAscoringefficiency[num] = SCEFF.CalculateSCEFF();

                    Array.Resize<double>(ref NBAshootingefficiency, NBAshootingefficiency.Length + 1);
                    var SHEFF = new NBA(fgm, tpm, fga, 0, 0, 0, 0);
                    NBAshootingefficiency[num] = SHEFF.CalculateSHEFF();


                    Array.Resize<double>(ref NBAstealspergame, NBAstealspergame.Length + 1);
                    var STLPG = new NBA(s, g, 0, 0, 0, 0, 0, 0, 0);
                    NBAstealspergame[num] = STLPG.CalculateSTLPG();

                    Array.Resize<double>(ref NBAturnoverspergame, NBAturnoverspergame.Length + 1);
                    var TOPG = new NBA(t, g, 0, 0, 0, 0, 0, 0, 0, 0);
                    NBAturnoverspergame[num] = TOPG.CalculateTOPG();

                    Array.Resize<double>(ref NBAassistspergame, NBAassistspergame.Length + 1);
                    var ASTSPG = new NBA(a, g, 0, 0, 0, 0, 0, 0, 0, 0, 0);
                    NBAassistspergame[num] = ASTSPG.CalculateASTSPG();

                    Array.Resize<double>(ref NBAblockspergame, NBAblockspergame.Length + 1);
                    var BLKPG = new NBA(b, g, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
                    NBAblockspergame[num] = BLKPG.CalculateBLKPG();

                    Array.Resize<double>(ref NBAassitstoturnovers, NBAassitstoturnovers.Length + 1);
                    var ASTTO = new NBA(a, t, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
                    NBAassitstoturnovers[num] = ASTTO.CalculateASTTO();

                    Array.Resize<double>(ref NBAreboundspergame, NBAreboundspergame.Length + 1);
                    var REBPG = new NBA(or, dr, g, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
                    NBAreboundspergame[num] = REBPG.CalculateREBPG();

                    if (radMLB.Checked && radAllDivisions.Checked)
                    {
                        if (lbNBATeams.Text == "All Teams")
                        {
                            if (lbNBApositions.Text == "All Positions")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Point Guard" && NBAPosition[num] == "PG")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Shooting Guard" && NBAPosition[num] == "SG")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Small Forward" && NBAPosition[num] == "SF")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Power Forward" && NBAPosition[num] == "PF")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Center" && NBAPosition[num] == "C")
                            {
                                printNBA();
                            }
                        }
                        if (lbNBATeams.Text == "Atlanta Hawks" && NBAteam[num] == "HAWKS")
                        {
                            if (lbNBApositions.Text == "All Positions")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Point Guard" && NBAPosition[num] == "PG")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Shooting Guard" && NBAPosition[num] == "SG")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Small Forward" && NBAPosition[num] == "SF")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Power Forward" && NBAPosition[num] == "PF")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Center" && NBAPosition[num] == "C")
                            {
                                printNBA();
                            }
                        }
                        if (lbNBATeams.Text == "Boston Celtics" && NBAteam[num] == "CELTICS")
                        {
                            if (lbNBApositions.Text == "All Positions")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Point Guard" && NBAPosition[num] == "PG")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Shooting Guard" && NBAPosition[num] == "SG")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Small Forward" && NBAPosition[num] == "SF")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Power Forward" && NBAPosition[num] == "PF")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Center" && NBAPosition[num] == "C")
                            {
                                printNBA();
                            }
                        }
                        if (lbNBATeams.Text == "Brooklyn Nets" && NBAteam[num] == "NETS")
                        {
                            if (lbNBApositions.Text == "All Positions")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Point Guard" && NBAPosition[num] == "PG")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Shooting Guard" && NBAPosition[num] == "SG")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Small Forward" && NBAPosition[num] == "SF")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Power Forward" && NBAPosition[num] == "PF")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Center" && NBAPosition[num] == "C")
                            {
                                printNBA();
                            }
                        }
                        if (lbNBATeams.Text == "Charlotte Hornets" && NBAteam[num] == "HORNETS")
                        {
                            if (lbNBApositions.Text == "All Positions")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Point Guard" && NBAPosition[num] == "PG")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Shooting Guard" && NBAPosition[num] == "SG")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Small Forward" && NBAPosition[num] == "SF")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Power Forward" && NBAPosition[num] == "PF")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Center" && NBAPosition[num] == "C")
                            {
                                printNBA();
                            }
                        }
                        if (lbNBATeams.Text == "Chicago Bulls" && NBAteam[num] == "BULLS")
                        {
                            if (lbNBApositions.Text == "All Positions")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Point Guard" && NBAPosition[num] == "PG")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Shooting Guard" && NBAPosition[num] == "SG")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Small Forward" && NBAPosition[num] == "SF")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Power Forward" && NBAPosition[num] == "PF")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Center" && NBAPosition[num] == "C")
                            {
                                printNBA();
                            }
                        }
                        if (lbNBATeams.Text == "Cleveland Cavaliers" && NBAteam[num] == "CAVALIERS")
                        {
                            if (lbNBApositions.Text == "All Positions")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Point Guard" && NBAPosition[num] == "PG")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Shooting Guard" && NBAPosition[num] == "SG")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Small Forward" && NBAPosition[num] == "SF")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Power Forward" && NBAPosition[num] == "PF")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Center" && NBAPosition[num] == "C")
                            {
                                printNBA();
                            }
                        }
                        if (lbNBATeams.Text == "Dallas Mavericks" && NBAteam[num] == "MAVERICKS")
                        {
                            if (lbNBApositions.Text == "All Positions")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Point Guard" && NBAPosition[num] == "PG")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Shooting Guard" && NBAPosition[num] == "SG")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Small Forward" && NBAPosition[num] == "SF")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Power Forward" && NBAPosition[num] == "PF")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Center" && NBAPosition[num] == "C")
                            {
                                printNBA();
                            }
                        }
                        if (lbNBATeams.Text == "Denver Nuggets" && NBAteam[num] == "NUGGETS")
                        {
                            if (lbNBApositions.Text == "All Positions")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Point Guard" && NBAPosition[num] == "PG")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Shooting Guard" && NBAPosition[num] == "SG")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Small Forward" && NBAPosition[num] == "SF")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Power Forward" && NBAPosition[num] == "PF")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Center" && NBAPosition[num] == "C")
                            {
                                printNBA();
                            }
                        }
                        if (lbNBATeams.Text == "Detroit Pistons" && NBAteam[num] == "PISTONS")
                        {
                            if (lbNBApositions.Text == "All Positions")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Point Guard" && NBAPosition[num] == "PG")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Shooting Guard" && NBAPosition[num] == "SG")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Small Forward" && NBAPosition[num] == "SF")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Power Forward" && NBAPosition[num] == "PF")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Center" && NBAPosition[num] == "C")
                            {
                                printNBA();
                            }
                        }
                        if (lbNBATeams.Text == "Golden State Warriors" && NBAteam[num] == "WARRIORS")
                        {
                            if (lbNBApositions.Text == "All Positions")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Point Guard" && NBAPosition[num] == "PG")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Shooting Guard" && NBAPosition[num] == "SG")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Small Forward" && NBAPosition[num] == "SF")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Power Forward" && NBAPosition[num] == "PF")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Center" && NBAPosition[num] == "C")
                            {
                                printNBA();
                            }
                        }
                        if (lbNBATeams.Text == "Houston Rockets" && NBAteam[num] == "ROCKETS")
                        {
                            if (lbNBApositions.Text == "All Positions")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Point Guard" && NBAPosition[num] == "PG")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Shooting Guard" && NBAPosition[num] == "SG")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Small Forward" && NBAPosition[num] == "SF")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Power Forward" && NBAPosition[num] == "PF")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Center" && NBAPosition[num] == "C")
                            {
                                printNBA();
                            }
                        }
                        if (lbNBATeams.Text == "Indiana Pacers" && NBAteam[num] == "PACERS")
                        {
                            if (lbNBApositions.Text == "All Positions")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Point Guard" && NBAPosition[num] == "PG")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Shooting Guard" && NBAPosition[num] == "SG")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Small Forward" && NBAPosition[num] == "SF")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Power Forward" && NBAPosition[num] == "PF")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Center" && NBAPosition[num] == "C")
                            {
                                printNBA();
                            }
                        }
                        if (lbNBATeams.Text == "Los Angeles Clippers" && NBAteam[num] == "CLIPPERS")
                        {
                            if (lbNBApositions.Text == "All Positions")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Point Guard" && NBAPosition[num] == "PG")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Shooting Guard" && NBAPosition[num] == "SG")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Small Forward" && NBAPosition[num] == "SF")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Power Forward" && NBAPosition[num] == "PF")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Center" && NBAPosition[num] == "C")
                            {
                                printNBA();
                            }
                        }
                        if (lbNBATeams.Text == "Los Angeles Lakers" && NBAteam[num] == "LAKERS")
                        {
                            if (lbNBApositions.Text == "All Positions")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Point Guard" && NBAPosition[num] == "PG")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Shooting Guard" && NBAPosition[num] == "SG")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Small Forward" && NBAPosition[num] == "SF")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Power Forward" && NBAPosition[num] == "PF")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Center" && NBAPosition[num] == "C")
                            {
                                printNBA();
                            }
                        }
                        if (lbNBATeams.Text == "Memphis Grizzlies" && NBAteam[num] == "GRIZZIES")
                        {
                            if (lbNBApositions.Text == "All Positions")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Point Guard" && NBAPosition[num] == "PG")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Shooting Guard" && NBAPosition[num] == "SG")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Small Forward" && NBAPosition[num] == "SF")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Power Forward" && NBAPosition[num] == "PF")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Center" && NBAPosition[num] == "C")
                            {
                                printNBA();
                            }
                        }
                        if (lbNBATeams.Text == "Miami Heat" && NBAteam[num] == "HEAT")
                        {
                            if (lbNBApositions.Text == "All Positions")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Point Guard" && NBAPosition[num] == "PG")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Shooting Guard" && NBAPosition[num] == "SG")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Small Forward" && NBAPosition[num] == "SF")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Power Forward" && NBAPosition[num] == "PF")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Center" && NBAPosition[num] == "C")
                            {
                                printNBA();
                            }
                        }
                        if (lbNBATeams.Text == "Milwaukee Bucks" && NBAteam[num] == "BUCKS")
                        {
                            if (lbNBApositions.Text == "All Positions")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Point Guard" && NBAPosition[num] == "PG")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Shooting Guard" && NBAPosition[num] == "SG")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Small Forward" && NBAPosition[num] == "SF")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Power Forward" && NBAPosition[num] == "PF")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Center" && NBAPosition[num] == "C")
                            {
                                printNBA();
                            }
                        }
                        if (lbNBATeams.Text == "Minnesota Timberwolves" && NBAteam[num] == "TIMBERWOLVES")
                        {
                            if (lbNBApositions.Text == "All Positions")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Point Guard" && NBAPosition[num] == "PG")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Shooting Guard" && NBAPosition[num] == "SG")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Small Forward" && NBAPosition[num] == "SF")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Power Forward" && NBAPosition[num] == "PF")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Center" && NBAPosition[num] == "C")
                            {
                                printNBA();
                            }
                        }
                        if (lbNBATeams.Text == "New Orleans Pelicans" && NBAteam[num] == "PELICANS")
                        {
                            if (lbNBApositions.Text == "All Positions")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Point Guard" && NBAPosition[num] == "PG")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Shooting Guard" && NBAPosition[num] == "SG")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Small Forward" && NBAPosition[num] == "SF")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Power Forward" && NBAPosition[num] == "PF")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Center" && NBAPosition[num] == "C")
                            {
                                printNBA();
                            }
                        }
                        if (lbNBATeams.Text == "New York Knicks" && NBAteam[num] == "KNICKS")
                        {
                            if (lbNBApositions.Text == "All Positions")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Point Guard" && NBAPosition[num] == "PG")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Shooting Guard" && NBAPosition[num] == "SG")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Small Forward" && NBAPosition[num] == "SF")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Power Forward" && NBAPosition[num] == "PF")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Center" && NBAPosition[num] == "C")
                            {
                                printNBA();
                            }
                        }
                        if (lbNBATeams.Text == "Oklahoma City Thunder" && NBAteam[num] == "THUNDER")
                        {
                            if (lbNBApositions.Text == "All Positions")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Point Guard" && NBAPosition[num] == "PG")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Shooting Guard" && NBAPosition[num] == "SG")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Small Forward" && NBAPosition[num] == "SF")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Power Forward" && NBAPosition[num] == "PF")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Center" && NBAPosition[num] == "C")
                            {
                                printNBA();
                            }
                        }
                        if (lbNBATeams.Text == "Orlando Magic" && NBAteam[num] == "MAGIC")
                        {
                            if (lbNBApositions.Text == "All Positions")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Point Guard" && NBAPosition[num] == "PG")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Shooting Guard" && NBAPosition[num] == "SG")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Small Forward" && NBAPosition[num] == "SF")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Power Forward" && NBAPosition[num] == "PF")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Center" && NBAPosition[num] == "C")
                            {
                                printNBA();
                            }
                        }
                        if (lbNBATeams.Text == "Philadelphia 76ers" && NBAteam[num] == "76ERS")
                        {
                            if (lbNBApositions.Text == "All Positions")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Point Guard" && NBAPosition[num] == "PG")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Shooting Guard" && NBAPosition[num] == "SG")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Small Forward" && NBAPosition[num] == "SF")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Power Forward" && NBAPosition[num] == "PF")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Center" && NBAPosition[num] == "C")
                            {
                                printNBA();
                            }
                        }
                        if (lbNBATeams.Text == "Phoenix Suns" && NBAteam[num] == "SUNS")
                        {
                            if (lbNBApositions.Text == "All Positions")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Point Guard" && NBAPosition[num] == "PG")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Shooting Guard" && NBAPosition[num] == "SG")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Small Forward" && NBAPosition[num] == "SF")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Power Forward" && NBAPosition[num] == "PF")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Center" && NBAPosition[num] == "C")
                            {
                                printNBA();
                            }
                        }
                        if (lbNBATeams.Text == "Portland Trail Blazers" && NBAteam[num] == "BLAZERS")
                        {
                            if (lbNBApositions.Text == "All Positions")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Point Guard" && NBAPosition[num] == "PG")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Shooting Guard" && NBAPosition[num] == "SG")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Small Forward" && NBAPosition[num] == "SF")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Power Forward" && NBAPosition[num] == "PF")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Center" && NBAPosition[num] == "C")
                            {
                                printNBA();
                            }
                        }
                        if (lbNBATeams.Text == "Sacramento Kings" && NBAteam[num] == "KINGS")
                        {
                            if (lbNBApositions.Text == "All Positions")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Point Guard" && NBAPosition[num] == "PG")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Shooting Guard" && NBAPosition[num] == "SG")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Small Forward" && NBAPosition[num] == "SF")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Power Forward" && NBAPosition[num] == "PF")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Center" && NBAPosition[num] == "C")
                            {
                                printNBA();
                            }
                        }
                        if (lbNBATeams.Text == "San Antonio Spurs" && NBAteam[num] == "SPURS")
                        {
                            if (lbNBApositions.Text == "All Positions")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Point Guard" && NBAPosition[num] == "PG")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Shooting Guard" && NBAPosition[num] == "SG")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Small Forward" && NBAPosition[num] == "SF")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Power Forward" && NBAPosition[num] == "PF")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Center" && NBAPosition[num] == "C")
                            {
                                printNBA();
                            }
                        }
                        if (lbNBATeams.Text == "Toronto Raptors" && NBAteam[num] == "RAPTORS")
                        {
                            if (lbNBApositions.Text == "All Positions")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Point Guard" && NBAPosition[num] == "PG")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Shooting Guard" && NBAPosition[num] == "SG")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Small Forward" && NBAPosition[num] == "SF")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Power Forward" && NBAPosition[num] == "PF")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Center" && NBAPosition[num] == "C")
                            {
                                printNBA();
                            }
                        }
                        if (lbNBATeams.Text == "Utah Jazz" && NBAteam[num] == "JAZZ")
                        {
                            if (lbNBApositions.Text == "All Positions")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Point Guard" && NBAPosition[num] == "PG")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Shooting Guard" && NBAPosition[num] == "SG")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Small Forward" && NBAPosition[num] == "SF")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Power Forward" && NBAPosition[num] == "PF")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Center" && NBAPosition[num] == "C")
                            {
                                printNBA();
                            }
                        }
                        if (lbNBATeams.Text == "Washington Wizards" && NBAteam[num] == "WIZARDS")
                        {
                            if (lbNBApositions.Text == "All Positions")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Point Guard" && NBAPosition[num] == "PG")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Shooting Guard" && NBAPosition[num] == "SG")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Small Forward" && NBAPosition[num] == "SF")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Power Forward" && NBAPosition[num] == "PF")
                            {
                                printNBA();
                            }
                            else if (lbNBApositions.Text == "Center" && NBAPosition[num] == "C")
                            {
                                printNBA();
                            }
                        }
                    }
                    else if (radEastNBA.Checked && radAllDivisions.Checked)
                    {
                        if (NBAConference[num] == "EASTERN")
                        {
                            if (lbNBATeams.Text == "All Teams")
                            {
                                if (lbNBApositions.Text == "All Positions")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Point Guard" && NBAPosition[num] == "PG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Shooting Guard" && NBAPosition[num] == "SG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Small Forward" && NBAPosition[num] == "SF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Power Forward" && NBAPosition[num] == "PF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Center" && NBAPosition[num] == "C")
                                {
                                    printNBA();
                                }
                            }
                            if (lbNBATeams.Text == "Miami Heat" && NBAteam[num] == "HEAT")
                            {
                                if (lbNBApositions.Text == "All Positions")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Point Guard" && NBAPosition[num] == "PG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Shooting Guard" && NBAPosition[num] == "SG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Small Forward" && NBAPosition[num] == "SF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Power Forward" && NBAPosition[num] == "PF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Center" && NBAPosition[num] == "C")
                                {
                                    printNBA();
                                }
                            }
                            if (lbNBATeams.Text == "Boston Celtics" && NBAteam[num] == "CELTICS")
                            {
                                if (lbNBApositions.Text == "All Positions")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Point Guard" && NBAPosition[num] == "PG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Shooting Guard" && NBAPosition[num] == "SG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Small Forward" && NBAPosition[num] == "SF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Power Forward" && NBAPosition[num] == "PF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Center" && NBAPosition[num] == "C")
                                {
                                    printNBA();
                                }
                            }
                            if (lbNBATeams.Text == "Milwaukee Bucks" && NBAteam[num] == "BUCKS")
                            {
                                if (lbNBApositions.Text == "All Positions")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Point Guard" && NBAPosition[num] == "PG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Shooting Guard" && NBAPosition[num] == "SG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Small Forward" && NBAPosition[num] == "SF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Power Forward" && NBAPosition[num] == "PF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Center" && NBAPosition[num] == "C")
                                {
                                    printNBA();
                                }
                            }
                            if (lbNBATeams.Text == "Philadelphia 76ers" && NBAteam[num] == "76ERS")
                            {
                                if (lbNBApositions.Text == "All Positions")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Point Guard" && NBAPosition[num] == "PG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Shooting Guard" && NBAPosition[num] == "SG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Small Forward" && NBAPosition[num] == "SF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Power Forward" && NBAPosition[num] == "PF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Center" && NBAPosition[num] == "C")
                                {
                                    printNBA();
                                }
                            }
                            if (lbNBATeams.Text == "Toronto Raptors" && NBAteam[num] == "RAPTORS")
                            {
                                if (lbNBApositions.Text == "All Positions")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Point Guard" && NBAPosition[num] == "PG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Shooting Guard" && NBAPosition[num] == "SG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Small Forward" && NBAPosition[num] == "SF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Power Forward" && NBAPosition[num] == "PF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Center" && NBAPosition[num] == "C")
                                {
                                    printNBA();
                                }
                            }
                            if (lbNBATeams.Text == "Chicago Bulls" && NBAteam[num] == "BULLS")
                            {
                                if (lbNBApositions.Text == "All Positions")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Point Guard" && NBAPosition[num] == "PG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Shooting Guard" && NBAPosition[num] == "SG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Small Forward" && NBAPosition[num] == "SF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Power Forward" && NBAPosition[num] == "PF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Center" && NBAPosition[num] == "C")
                                {
                                    printNBA();
                                }
                            }
                            if (lbNBATeams.Text == "Brooklyn Nets" && NBAteam[num] == "NETS")
                            {
                                if (lbNBApositions.Text == "All Positions")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Point Guard" && NBAPosition[num] == "PG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Shooting Guard" && NBAPosition[num] == "SG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Small Forward" && NBAPosition[num] == "SF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Power Forward" && NBAPosition[num] == "PF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Center" && NBAPosition[num] == "C")
                                {
                                    printNBA();
                                }
                            }
                            if (lbNBATeams.Text == "Brooklyn Nets" && NBAteam[num] == "NETS")
                            {
                                if (lbNBApositions.Text == "All Positions")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Point Guard" && NBAPosition[num] == "PG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Shooting Guard" && NBAPosition[num] == "SG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Small Forward" && NBAPosition[num] == "SF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Power Forward" && NBAPosition[num] == "PF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Center" && NBAPosition[num] == "C")
                                {
                                    printNBA();
                                }
                            }
                            if (lbNBATeams.Text == "Atlanta Hawks" && NBAteam[num] == "HAWKS")
                            {
                                if (lbNBApositions.Text == "All Positions")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Point Guard" && NBAPosition[num] == "PG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Shooting Guard" && NBAPosition[num] == "SG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Small Forward" && NBAPosition[num] == "SF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Power Forward" && NBAPosition[num] == "PF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Center" && NBAPosition[num] == "C")
                                {
                                    printNBA();
                                }
                            }
                            if (lbNBATeams.Text == "Cleveland Cavaliers" && NBAteam[num] == "CAVALIERS")
                            {
                                if (lbNBApositions.Text == "All Positions")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Point Guard" && NBAPosition[num] == "PG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Shooting Guard" && NBAPosition[num] == "SG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Small Forward" && NBAPosition[num] == "SF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Power Forward" && NBAPosition[num] == "PF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Center" && NBAPosition[num] == "C")
                                {
                                    printNBA();
                                }
                            }
                            if (lbNBATeams.Text == "Charlotte Hornets" && NBAteam[num] == "HORNETS")
                            {
                                if (lbNBApositions.Text == "All Positions")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Point Guard" && NBAPosition[num] == "PG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Shooting Guard" && NBAPosition[num] == "SG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Small Forward" && NBAPosition[num] == "SF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Power Forward" && NBAPosition[num] == "PF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Center" && NBAPosition[num] == "C")
                                {
                                    printNBA();
                                }
                            }
                            if (lbNBATeams.Text == "New York Knicks" && NBAteam[num] == "KNICKS")
                            {
                                if (lbNBApositions.Text == "All Positions")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Point Guard" && NBAPosition[num] == "PG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Shooting Guard" && NBAPosition[num] == "SG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Small Forward" && NBAPosition[num] == "SF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Power Forward" && NBAPosition[num] == "PF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Center" && NBAPosition[num] == "C")
                                {
                                    printNBA();
                                }
                            }
                            if (lbNBATeams.Text == "Washington Wizards" && NBAteam[num] == "WIZARDS")
                            {
                                if (lbNBApositions.Text == "All Positions")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Point Guard" && NBAPosition[num] == "PG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Shooting Guard" && NBAPosition[num] == "SG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Small Forward" && NBAPosition[num] == "SF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Power Forward" && NBAPosition[num] == "PF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Center" && NBAPosition[num] == "C")
                                {
                                    printNBA();
                                }
                            }
                            if (lbNBATeams.Text == "Indiana Pacers" && NBAteam[num] == "PACERS")
                            {
                                if (lbNBApositions.Text == "All Positions")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Point Guard" && NBAPosition[num] == "PG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Shooting Guard" && NBAPosition[num] == "SG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Small Forward" && NBAPosition[num] == "SF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Power Forward" && NBAPosition[num] == "PF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Center" && NBAPosition[num] == "C")
                                {
                                    printNBA();
                                }
                            }
                            if (lbNBATeams.Text == "Detroit Pistons" && NBAteam[num] == "PISTONS")
                            {
                                if (lbNBApositions.Text == "All Positions")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Point Guard" && NBAPosition[num] == "PG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Shooting Guard" && NBAPosition[num] == "SG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Small Forward" && NBAPosition[num] == "SF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Power Forward" && NBAPosition[num] == "PF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Center" && NBAPosition[num] == "C")
                                {
                                    printNBA();
                                }
                            }
                            if (lbNBATeams.Text == "Orlando Magic" && NBAteam[num] == "MAGIC")
                            {
                                if (lbNBApositions.Text == "All Positions")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Point Guard" && NBAPosition[num] == "PG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Shooting Guard" && NBAPosition[num] == "SG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Small Forward" && NBAPosition[num] == "SF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Power Forward" && NBAPosition[num] == "PF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Center" && NBAPosition[num] == "C")
                                {
                                    printNBA();
                                }
                            }
                        }
                    }
                    else if (radWestNBA.Checked && radAllDivisions.Checked)
                    {
                        if (NBAConference[num] == "WESTERN")
                        {

                        }
                        {
                            if (lbNBATeams.Text == "All Teams")
                            {
                                if (lbNBApositions.Text == "All Positions")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Point Guard" && NBAPosition[num] == "PG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Shooting Guard" && NBAPosition[num] == "SG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Small Forward" && NBAPosition[num] == "SF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Power Forward" && NBAPosition[num] == "PF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Center" && NBAPosition[num] == "C")
                                {
                                    printNBA();
                                }
                            }
                            if (lbNBATeams.Text == "Phoenix Suns" && NBAteam[num] == "SUNS")
                            {
                                if (lbNBApositions.Text == "All Positions")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Point Guard" && NBAPosition[num] == "PG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Shooting Guard" && NBAPosition[num] == "SG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Small Forward" && NBAPosition[num] == "SF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Power Forward" && NBAPosition[num] == "PF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Center" && NBAPosition[num] == "C")
                                {
                                    printNBA();
                                }
                            }
                            if (lbNBATeams.Text == "Memphis Grizzlies" && NBAteam[num] == "GRIZZIES")
                            {
                                if (lbNBApositions.Text == "All Positions")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Point Guard" && NBAPosition[num] == "PG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Shooting Guard" && NBAPosition[num] == "SG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Small Forward" && NBAPosition[num] == "SF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Power Forward" && NBAPosition[num] == "PF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Center" && NBAPosition[num] == "C")
                                {
                                    printNBA();
                                }
                            }
                            if (lbNBATeams.Text == "Golden State Warriors" && NBAteam[num] == "WARRIORS")
                            {
                                if (lbNBApositions.Text == "All Positions")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Point Guard" && NBAPosition[num] == "PG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Shooting Guard" && NBAPosition[num] == "SG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Small Forward" && NBAPosition[num] == "SF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Power Forward" && NBAPosition[num] == "PF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Center" && NBAPosition[num] == "C")
                                {
                                    printNBA();
                                }
                            }
                            if (lbNBATeams.Text == "Dallas Mavericks" && NBAteam[num] == "MAVERICKS")
                            {
                                if (lbNBApositions.Text == "All Positions")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Point Guard" && NBAPosition[num] == "PG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Shooting Guard" && NBAPosition[num] == "SG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Small Forward" && NBAPosition[num] == "SF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Power Forward" && NBAPosition[num] == "PF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Center" && NBAPosition[num] == "C")
                                {
                                    printNBA();
                                }
                            }
                            if (lbNBATeams.Text == "Utah Jazz" && NBAteam[num] == "JAZZ")
                            {
                                if (lbNBApositions.Text == "All Positions")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Point Guard" && NBAPosition[num] == "PG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Shooting Guard" && NBAPosition[num] == "SG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Small Forward" && NBAPosition[num] == "SF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Power Forward" && NBAPosition[num] == "PF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Center" && NBAPosition[num] == "C")
                                {
                                    printNBA();
                                }
                            }
                            if (lbNBATeams.Text == "Denver Nuggets" && NBAteam[num] == "NUGGETS")
                            {
                                if (lbNBApositions.Text == "All Positions")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Point Guard" && NBAPosition[num] == "PG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Shooting Guard" && NBAPosition[num] == "SG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Small Forward" && NBAPosition[num] == "SF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Power Forward" && NBAPosition[num] == "PF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Center" && NBAPosition[num] == "C")
                                {
                                    printNBA();
                                }
                            }
                            if (lbNBATeams.Text == "Minnesota Timberwolves" && NBAteam[num] == "TIMBERWOLVES")
                            {
                                if (lbNBApositions.Text == "All Positions")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Point Guard" && NBAPosition[num] == "PG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Shooting Guard" && NBAPosition[num] == "SG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Small Forward" && NBAPosition[num] == "SF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Power Forward" && NBAPosition[num] == "PF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Center" && NBAPosition[num] == "C")
                                {
                                    printNBA();
                                }
                            }
                            if (lbNBATeams.Text == "New Orleans Pelicans" && NBAteam[num] == "PELICANS")
                            {
                                if (lbNBApositions.Text == "All Positions")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Point Guard" && NBAPosition[num] == "PG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Shooting Guard" && NBAPosition[num] == "SG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Small Forward" && NBAPosition[num] == "SF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Power Forward" && NBAPosition[num] == "PF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Center" && NBAPosition[num] == "C")
                                {
                                    printNBA();
                                }
                            }
                            if (lbNBATeams.Text == "Los Angeles Clippers" && NBAteam[num] == "CLIPPERS")
                            {
                                if (lbNBApositions.Text == "All Positions")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Point Guard" && NBAPosition[num] == "PG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Shooting Guard" && NBAPosition[num] == "SG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Small Forward" && NBAPosition[num] == "SF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Power Forward" && NBAPosition[num] == "PF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Center" && NBAPosition[num] == "C")
                                {
                                    printNBA();
                                }
                            }
                            if (lbNBATeams.Text == "San Antonio Spurs" && NBAteam[num] == "SPURS")
                            {
                                if (lbNBApositions.Text == "All Positions")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Point Guard" && NBAPosition[num] == "PG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Shooting Guard" && NBAPosition[num] == "SG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Small Forward" && NBAPosition[num] == "SF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Power Forward" && NBAPosition[num] == "PF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Center" && NBAPosition[num] == "C")
                                {
                                    printNBA();
                                }
                            }
                            if (lbNBATeams.Text == "Los Angeles Lakers" && NBAteam[num] == "LAKERS")
                            {
                                if (lbNBApositions.Text == "All Positions")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Point Guard" && NBAPosition[num] == "PG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Shooting Guard" && NBAPosition[num] == "SG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Small Forward" && NBAPosition[num] == "SF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Power Forward" && NBAPosition[num] == "PF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Center" && NBAPosition[num] == "C")
                                {
                                    printNBA();
                                }
                            }
                            if (lbNBATeams.Text == "Sacramento Kings" && NBAteam[num] == "KINGS")
                            {
                                if (lbNBApositions.Text == "All Positions")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Point Guard" && NBAPosition[num] == "PG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Shooting Guard" && NBAPosition[num] == "SG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Small Forward" && NBAPosition[num] == "SF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Power Forward" && NBAPosition[num] == "PF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Center" && NBAPosition[num] == "C")
                                {
                                    printNBA();
                                }
                            }
                            if (lbNBATeams.Text == "Portland Trail Blazers" && NBAteam[num] == "BLAZERS")
                            {
                                if (lbNBApositions.Text == "All Positions")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Point Guard" && NBAPosition[num] == "PG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Shooting Guard" && NBAPosition[num] == "SG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Small Forward" && NBAPosition[num] == "SF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Power Forward" && NBAPosition[num] == "PF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Center" && NBAPosition[num] == "C")
                                {
                                    printNBA();
                                }
                            }
                            if (lbNBATeams.Text == "Oklahoma City Thunder" && NBAteam[num] == "THUNDER")
                            {
                                if (lbNBApositions.Text == "All Positions")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Point Guard" && NBAPosition[num] == "PG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Shooting Guard" && NBAPosition[num] == "SG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Small Forward" && NBAPosition[num] == "SF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Power Forward" && NBAPosition[num] == "PF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Center" && NBAPosition[num] == "C")
                                {
                                    printNBA();
                                }
                            }
                            if (lbNBATeams.Text == "Houston Rockets" && NBAteam[num] == "ROCKETS")
                            {
                                if (lbNBApositions.Text == "All Positions")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Point Guard" && NBAPosition[num] == "PG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Shooting Guard" && NBAPosition[num] == "SG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Small Forward" && NBAPosition[num] == "SF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Power Forward" && NBAPosition[num] == "PF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Center" && NBAPosition[num] == "C")
                                {
                                    printNBA();
                                }
                            }
                        }
                    }
                    else if (radMLB.Checked && radAtlantic.Checked)
                    {
                        if (NBADivision[num] == "ATLANTIC")
                        {
                            if (lbNBATeams.Text == "All Teams")
                            {
                                if (lbNBApositions.Text == "All Positions")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Point Guard" && NBAPosition[num] == "PG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Shooting Guard" && NBAPosition[num] == "SG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Small Forward" && NBAPosition[num] == "SF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Power Forward" && NBAPosition[num] == "PF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Center" && NBAPosition[num] == "C")
                                {
                                    printNBA();
                                }
                            }
                            if (lbNBATeams.Text == "Philadelphia 76ers" && NBAteam[num] == "76ERS")
                            {
                                if (lbNBApositions.Text == "All Positions")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Point Guard" && NBAPosition[num] == "PG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Shooting Guard" && NBAPosition[num] == "SG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Small Forward" && NBAPosition[num] == "SF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Power Forward" && NBAPosition[num] == "PF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Center" && NBAPosition[num] == "C")
                                {
                                    printNBA();
                                }
                            }
                            if (lbNBATeams.Text == "Boston Celtics" && NBAteam[num] == "CELTICS")
                            {
                                if (lbNBApositions.Text == "All Positions")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Point Guard" && NBAPosition[num] == "PG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Shooting Guard" && NBAPosition[num] == "SG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Small Forward" && NBAPosition[num] == "SF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Power Forward" && NBAPosition[num] == "PF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Center" && NBAPosition[num] == "C")
                                {
                                    printNBA();
                                }
                            }
                            if (lbNBATeams.Text == "Brooklyn Nets" && NBAteam[num] == "NETS")
                            {
                                if (lbNBApositions.Text == "All Positions")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Point Guard" && NBAPosition[num] == "PG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Shooting Guard" && NBAPosition[num] == "SG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Small Forward" && NBAPosition[num] == "SF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Power Forward" && NBAPosition[num] == "PF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Center" && NBAPosition[num] == "C")
                                {
                                    printNBA();
                                }
                            }
                            if (lbNBATeams.Text == "New York Knicks" && NBAteam[num] == "KNICKS")
                            {
                                if (lbNBApositions.Text == "All Positions")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Point Guard" && NBAPosition[num] == "PG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Shooting Guard" && NBAPosition[num] == "SG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Small Forward" && NBAPosition[num] == "SF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Power Forward" && NBAPosition[num] == "PF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Center" && NBAPosition[num] == "C")
                                {
                                    printNBA();
                                }
                            }
                            if (lbNBATeams.Text == "Toronto Raptors" && NBAteam[num] == "RAPTORS")
                            {
                                if (lbNBApositions.Text == "All Positions")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Point Guard" && NBAPosition[num] == "PG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Shooting Guard" && NBAPosition[num] == "SG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Small Forward" && NBAPosition[num] == "SF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Power Forward" && NBAPosition[num] == "PF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Center" && NBAPosition[num] == "C")
                                {
                                    printNBA();
                                }
                            }
                        }
                    }
                    else if (radMLB.Checked && radEast.Checked)
                    {
                        if (NBADivision[num] == "CENTRAL")
                        {
                            if (lbNBATeams.Text == "All Teams")
                            {
                                if (lbNBApositions.Text == "All Positions")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Point Guard" && NBAPosition[num] == "PG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Shooting Guard" && NBAPosition[num] == "SG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Small Forward" && NBAPosition[num] == "SF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Power Forward" && NBAPosition[num] == "PF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Center" && NBAPosition[num] == "C")
                                {
                                    printNBA();
                                }
                            }
                            if (lbNBATeams.Text == "Chicago Bulls" && NBAteam[num] == "BULLS")
                            {
                                if (lbNBApositions.Text == "All Positions")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Point Guard" && NBAPosition[num] == "PG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Shooting Guard" && NBAPosition[num] == "SG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Small Forward" && NBAPosition[num] == "SF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Power Forward" && NBAPosition[num] == "PF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Center" && NBAPosition[num] == "C")
                                {
                                    printNBA();
                                }
                            }
                            if (lbNBATeams.Text == "Detroit Pistons" && NBAteam[num] == "PISTONS")
                            {
                                if (lbNBApositions.Text == "All Positions")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Point Guard" && NBAPosition[num] == "PG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Shooting Guard" && NBAPosition[num] == "SG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Small Forward" && NBAPosition[num] == "SF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Power Forward" && NBAPosition[num] == "PF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Center" && NBAPosition[num] == "C")
                                {
                                    printNBA();
                                }
                            }
                            if (lbNBATeams.Text == "Milwaukee Bucks" && NBAteam[num] == "BUCKS")
                            {
                                if (lbNBApositions.Text == "All Positions")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Point Guard" && NBAPosition[num] == "PG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Shooting Guard" && NBAPosition[num] == "SG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Small Forward" && NBAPosition[num] == "SF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Power Forward" && NBAPosition[num] == "PF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Center" && NBAPosition[num] == "C")
                                {
                                    printNBA();
                                }
                            }
                            if (lbNBATeams.Text == "Cleveland Cavaliers" && NBAteam[num] == "CAVALIERS")
                            {
                                if (lbNBApositions.Text == "All Positions")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Point Guard" && NBAPosition[num] == "PG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Shooting Guard" && NBAPosition[num] == "SG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Small Forward" && NBAPosition[num] == "SF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Power Forward" && NBAPosition[num] == "PF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Center" && NBAPosition[num] == "C")
                                {
                                    printNBA();
                                }
                            }
                            if (lbNBATeams.Text == "Indiana Pacers" && NBAteam[num] == "PACERS")
                            {
                                if (lbNBApositions.Text == "All Positions")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Point Guard" && NBAPosition[num] == "PG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Shooting Guard" && NBAPosition[num] == "SG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Small Forward" && NBAPosition[num] == "SF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Power Forward" && NBAPosition[num] == "PF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Center" && NBAPosition[num] == "C")
                                {
                                    printNBA();
                                }
                            }
                        }
                    }
                    else if (radMLB.Checked && radSoutheast.Checked)
                    {
                        if (NBADivision[num] == "SOUTHEAST")
                        {
                            if (lbNBATeams.Text == "All Teams")
                            {
                                if (lbNBApositions.Text == "All Positions")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Point Guard" && NBAPosition[num] == "PG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Shooting Guard" && NBAPosition[num] == "SG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Small Forward" && NBAPosition[num] == "SF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Power Forward" && NBAPosition[num] == "PF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Center" && NBAPosition[num] == "C")
                                {
                                    printNBA();
                                }
                            }
                            if (lbNBATeams.Text == "Miami Heat" && NBAteam[num] == "HEAT")
                            {
                                if (lbNBApositions.Text == "All Positions")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Point Guard" && NBAPosition[num] == "PG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Shooting Guard" && NBAPosition[num] == "SG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Small Forward" && NBAPosition[num] == "SF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Power Forward" && NBAPosition[num] == "PF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Center" && NBAPosition[num] == "C")
                                {
                                    printNBA();
                                }
                            }
                            if (lbNBATeams.Text == "Charlotte Hornets" && NBAteam[num] == "HORNETS")
                            {
                                if (lbNBApositions.Text == "All Positions")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Point Guard" && NBAPosition[num] == "PG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Shooting Guard" && NBAPosition[num] == "SG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Small Forward" && NBAPosition[num] == "SF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Power Forward" && NBAPosition[num] == "PF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Center" && NBAPosition[num] == "C")
                                {
                                    printNBA();
                                }
                            }
                            if (lbNBATeams.Text == "Atlanta Hawks" && NBAteam[num] == "HAWKS")
                            {
                                if (lbNBApositions.Text == "All Positions")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Point Guard" && NBAPosition[num] == "PG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Shooting Guard" && NBAPosition[num] == "SG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Small Forward" && NBAPosition[num] == "SF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Power Forward" && NBAPosition[num] == "PF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Center" && NBAPosition[num] == "C")
                                {
                                    printNBA();
                                }
                            }
                            if (lbNBATeams.Text == "Washington Wizards" && NBAteam[num] == "WIZARDS")
                            {
                                if (lbNBApositions.Text == "All Positions")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Point Guard" && NBAPosition[num] == "PG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Shooting Guard" && NBAPosition[num] == "SG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Small Forward" && NBAPosition[num] == "SF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Power Forward" && NBAPosition[num] == "PF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Center" && NBAPosition[num] == "C")
                                {
                                    printNBA();
                                }
                            }
                            if (lbNBATeams.Text == "Orlando Magic" && NBAteam[num] == "MAGIC")
                            {
                                if (lbNBApositions.Text == "All Positions")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Point Guard" && NBAPosition[num] == "PG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Shooting Guard" && NBAPosition[num] == "SG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Small Forward" && NBAPosition[num] == "SF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Power Forward" && NBAPosition[num] == "PF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Center" && NBAPosition[num] == "C")
                                {
                                    printNBA();
                                }
                            }
                        }
                    }
                    else if (radMLB.Checked && radSouthwest.Checked)
                    {
                        if (NBADivision[num] == "SOUTHWEST")
                        {
                            if (lbNBATeams.Text == "All Teams")
                            {
                                if (lbNBApositions.Text == "All Positions")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Point Guard" && NBAPosition[num] == "PG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Shooting Guard" && NBAPosition[num] == "SG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Small Forward" && NBAPosition[num] == "SF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Power Forward" && NBAPosition[num] == "PF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Center" && NBAPosition[num] == "C")
                                {
                                    printNBA();
                                }
                            }
                            if (lbNBATeams.Text == "San Antonio Spurs" && NBAteam[num] == "SPURS")
                            {
                                if (lbNBApositions.Text == "All Positions")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Point Guard" && NBAPosition[num] == "PG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Shooting Guard" && NBAPosition[num] == "SG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Small Forward" && NBAPosition[num] == "SF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Power Forward" && NBAPosition[num] == "PF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Center" && NBAPosition[num] == "C")
                                {
                                    printNBA();
                                }
                            }
                            if (lbNBATeams.Text == "Memphis Grizzlies" && NBAteam[num] == "GRIZZIES")
                            {
                                if (lbNBApositions.Text == "All Positions")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Point Guard" && NBAPosition[num] == "PG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Shooting Guard" && NBAPosition[num] == "SG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Small Forward" && NBAPosition[num] == "SF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Power Forward" && NBAPosition[num] == "PF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Center" && NBAPosition[num] == "C")
                                {
                                    printNBA();
                                }
                            }
                            if (lbNBATeams.Text == "Dallas Mavericks" && NBAteam[num] == "MAVERICKS")
                            {
                                if (lbNBApositions.Text == "All Positions")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Point Guard" && NBAPosition[num] == "PG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Shooting Guard" && NBAPosition[num] == "SG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Small Forward" && NBAPosition[num] == "SF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Power Forward" && NBAPosition[num] == "PF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Center" && NBAPosition[num] == "C")
                                {
                                    printNBA();
                                }
                            }
                            if (lbNBATeams.Text == "Houston Rockets" && NBAteam[num] == "ROCKETS")
                            {
                                if (lbNBApositions.Text == "All Positions")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Point Guard" && NBAPosition[num] == "PG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Shooting Guard" && NBAPosition[num] == "SG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Small Forward" && NBAPosition[num] == "SF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Power Forward" && NBAPosition[num] == "PF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Center" && NBAPosition[num] == "C")
                                {
                                    printNBA();
                                }
                            }
                            if (lbNBATeams.Text == "New Orleans Pelicans" && NBAteam[num] == "PELICANS")
                            {
                                if (lbNBApositions.Text == "All Positions")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Point Guard" && NBAPosition[num] == "PG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Shooting Guard" && NBAPosition[num] == "SG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Small Forward" && NBAPosition[num] == "SF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Power Forward" && NBAPosition[num] == "PF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Center" && NBAPosition[num] == "C")
                                {
                                    printNBA();
                                }
                            }
                        }
                    }
                    else if (radMLB.Checked && radPacific.Checked)
                    {
                        if (NBADivision[num] == "PACIFIC")
                        {
                            if (lbNBATeams.Text == "All Teams")
                            {
                                if (lbNBApositions.Text == "All Positions")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Point Guard" && NBAPosition[num] == "PG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Shooting Guard" && NBAPosition[num] == "SG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Small Forward" && NBAPosition[num] == "SF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Power Forward" && NBAPosition[num] == "PF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Center" && NBAPosition[num] == "C")
                                {
                                    printNBA();
                                }
                            }
                            if (lbNBATeams.Text == "Phoenix Suns" && NBAteam[num] == "SUNS")
                            {
                                if (lbNBApositions.Text == "All Positions")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Point Guard" && NBAPosition[num] == "PG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Shooting Guard" && NBAPosition[num] == "SG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Small Forward" && NBAPosition[num] == "SF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Power Forward" && NBAPosition[num] == "PF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Center" && NBAPosition[num] == "C")
                                {
                                    printNBA();
                                }
                            }
                            if (lbNBATeams.Text == "Los Angeles Clippers" && NBAteam[num] == "CLIPPERS")
                            {
                                if (lbNBApositions.Text == "All Positions")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Point Guard" && NBAPosition[num] == "PG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Shooting Guard" && NBAPosition[num] == "SG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Small Forward" && NBAPosition[num] == "SF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Power Forward" && NBAPosition[num] == "PF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Center" && NBAPosition[num] == "C")
                                {
                                    printNBA();
                                }
                            }
                            if (lbNBATeams.Text == "Los Angeles Lakers" && NBAteam[num] == "LAKERS")
                            {
                                if (lbNBApositions.Text == "All Positions")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Point Guard" && NBAPosition[num] == "PG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Shooting Guard" && NBAPosition[num] == "SG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Small Forward" && NBAPosition[num] == "SF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Power Forward" && NBAPosition[num] == "PF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Center" && NBAPosition[num] == "C")
                                {
                                    printNBA();
                                }
                            }
                            if (lbNBATeams.Text == "Sacramento Kings" && NBAteam[num] == "KINGS")
                            {
                                if (lbNBApositions.Text == "All Positions")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Point Guard" && NBAPosition[num] == "PG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Shooting Guard" && NBAPosition[num] == "SG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Small Forward" && NBAPosition[num] == "SF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Power Forward" && NBAPosition[num] == "PF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Center" && NBAPosition[num] == "C")
                                {
                                    printNBA();
                                }
                            }
                            if (lbNBATeams.Text == "Golden State Warriors" && NBAteam[num] == "WARRIORS")
                            {
                                if (lbNBApositions.Text == "All Positions")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Point Guard" && NBAPosition[num] == "PG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Shooting Guard" && NBAPosition[num] == "SG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Small Forward" && NBAPosition[num] == "SF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Power Forward" && NBAPosition[num] == "PF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Center" && NBAPosition[num] == "C")
                                {
                                    printNBA();
                                }
                            }
                        }
                    }
                    else if (radMLB.Checked && radNorthwest.Checked)
                    {
                        if (NBADivision[num] == "NORTHWEST")
                        {
                            if (lbNBATeams.Text == "All Teams")
                            {
                                if (lbNBApositions.Text == "All Positions")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Point Guard" && NBAPosition[num] == "PG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Shooting Guard" && NBAPosition[num] == "SG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Small Forward" && NBAPosition[num] == "SF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Power Forward" && NBAPosition[num] == "PF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Center" && NBAPosition[num] == "C")
                                {
                                    printNBA();
                                }
                            }
                            if (lbNBATeams.Text == "Minnesota Timberwolves" && NBAteam[num] == "TIMBERWOLVES")
                            {
                                if (lbNBApositions.Text == "All Positions")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Point Guard" && NBAPosition[num] == "PG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Shooting Guard" && NBAPosition[num] == "SG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Small Forward" && NBAPosition[num] == "SF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Power Forward" && NBAPosition[num] == "PF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Center" && NBAPosition[num] == "C")
                                {
                                    printNBA();
                                }
                            }
                            if (lbNBATeams.Text == "Oklahoma City Thunder" && NBAteam[num] == "THUNDER")
                            {
                                if (lbNBApositions.Text == "All Positions")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Point Guard" && NBAPosition[num] == "PG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Shooting Guard" && NBAPosition[num] == "SG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Small Forward" && NBAPosition[num] == "SF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Power Forward" && NBAPosition[num] == "PF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Center" && NBAPosition[num] == "C")
                                {
                                    printNBA();
                                }
                            }
                            if (lbNBATeams.Text == "Utah Jazz" && NBAteam[num] == "JAZZ")
                            {
                                if (lbNBApositions.Text == "All Positions")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Point Guard" && NBAPosition[num] == "PG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Shooting Guard" && NBAPosition[num] == "SG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Small Forward" && NBAPosition[num] == "SF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Power Forward" && NBAPosition[num] == "PF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Center" && NBAPosition[num] == "C")
                                {
                                    printNBA();
                                }
                            }
                            if (lbNBATeams.Text == "Portland Trail Blazers" && NBAteam[num] == "BLAZERS")
                            {
                                if (lbNBApositions.Text == "All Positions")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Point Guard" && NBAPosition[num] == "PG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Shooting Guard" && NBAPosition[num] == "SG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Small Forward" && NBAPosition[num] == "SF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Power Forward" && NBAPosition[num] == "PF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Center" && NBAPosition[num] == "C")
                                {
                                    printNBA();
                                }
                            }
                            if (lbNBATeams.Text == "Denver Nuggets" && NBAteam[num] == "NUGGETS")
                            {
                                if (lbNBApositions.Text == "All Positions")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Point Guard" && NBAPosition[num] == "PG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Shooting Guard" && NBAPosition[num] == "SG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Small Forward" && NBAPosition[num] == "SF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Power Forward" && NBAPosition[num] == "PF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Center" && NBAPosition[num] == "C")
                                {
                                    printNBA();
                                }
                            }
                        }
                    }
                    else if (radEastNBA.Checked && radAtlantic.Checked)
                    {
                        if (NBAConference[num] == "EASTERN" && NBADivision[num] == "ATLANTIC")
                        {
                            if (lbNBATeams.Text == "All Teams")
                            {
                                if (lbNBApositions.Text == "All Positions")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Point Guard" && NBAPosition[num] == "PG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Shooting Guard" && NBAPosition[num] == "SG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Small Forward" && NBAPosition[num] == "SF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Power Forward" && NBAPosition[num] == "PF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Center" && NBAPosition[num] == "C")
                                {
                                    printNBA();
                                }
                            }
                            if (lbNBATeams.Text == "Philadelphia 76ers" && NBAteam[num] == "76ERS")
                            {
                                if (lbNBApositions.Text == "All Positions")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Point Guard" && NBAPosition[num] == "PG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Shooting Guard" && NBAPosition[num] == "SG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Small Forward" && NBAPosition[num] == "SF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Power Forward" && NBAPosition[num] == "PF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Center" && NBAPosition[num] == "C")
                                {
                                    printNBA();
                                }
                            }
                            if (lbNBATeams.Text == "Boston Celtics" && NBAteam[num] == "CELTICS")
                            {
                                if (lbNBApositions.Text == "All Positions")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Point Guard" && NBAPosition[num] == "PG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Shooting Guard" && NBAPosition[num] == "SG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Small Forward" && NBAPosition[num] == "SF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Power Forward" && NBAPosition[num] == "PF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Center" && NBAPosition[num] == "C")
                                {
                                    printNBA();
                                }
                            }
                            if (lbNBATeams.Text == "Brooklyn Nets" && NBAteam[num] == "NETS")
                            {
                                if (lbNBApositions.Text == "All Positions")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Point Guard" && NBAPosition[num] == "PG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Shooting Guard" && NBAPosition[num] == "SG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Small Forward" && NBAPosition[num] == "SF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Power Forward" && NBAPosition[num] == "PF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Center" && NBAPosition[num] == "C")
                                {
                                    printNBA();
                                }
                            }
                            if (lbNBATeams.Text == "New York Knicks" && NBAteam[num] == "KNICKS")
                            {
                                if (lbNBApositions.Text == "All Positions")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Point Guard" && NBAPosition[num] == "PG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Shooting Guard" && NBAPosition[num] == "SG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Small Forward" && NBAPosition[num] == "SF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Power Forward" && NBAPosition[num] == "PF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Center" && NBAPosition[num] == "C")
                                {
                                    printNBA();
                                }
                            }
                            if (lbNBATeams.Text == "Toronto Raptors" && NBAteam[num] == "RAPTORS")
                            {
                                if (lbNBApositions.Text == "All Positions")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Point Guard" && NBAPosition[num] == "PG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Shooting Guard" && NBAPosition[num] == "SG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Small Forward" && NBAPosition[num] == "SF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Power Forward" && NBAPosition[num] == "PF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Center" && NBAPosition[num] == "C")
                                {
                                    printNBA();
                                }
                            }
                        }
                    }
                    else if (radEastNBA.Checked && radEast.Checked)
                    {
                        if (NBAConference[num] == "EASTERN" && NBADivision[num] == "CENTRAL")
                        {
                            if (lbNBATeams.Text == "All Teams")
                            {
                                if (lbNBApositions.Text == "All Positions")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Point Guard" && NBAPosition[num] == "PG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Shooting Guard" && NBAPosition[num] == "SG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Small Forward" && NBAPosition[num] == "SF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Power Forward" && NBAPosition[num] == "PF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Center" && NBAPosition[num] == "C")
                                {
                                    printNBA();
                                }
                            }
                            if (lbNBATeams.Text == "Chicago Bulls" && NBAteam[num] == "BULLS")
                            {
                                if (lbNBApositions.Text == "All Positions")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Point Guard" && NBAPosition[num] == "PG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Shooting Guard" && NBAPosition[num] == "SG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Small Forward" && NBAPosition[num] == "SF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Power Forward" && NBAPosition[num] == "PF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Center" && NBAPosition[num] == "C")
                                {
                                    printNBA();
                                }
                            }
                            if (lbNBATeams.Text == "Detroit Pistons" && NBAteam[num] == "PISTONS")
                            {
                                if (lbNBApositions.Text == "All Positions")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Point Guard" && NBAPosition[num] == "PG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Shooting Guard" && NBAPosition[num] == "SG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Small Forward" && NBAPosition[num] == "SF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Power Forward" && NBAPosition[num] == "PF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Center" && NBAPosition[num] == "C")
                                {
                                    printNBA();
                                }
                            }
                            if (lbNBATeams.Text == "Milwaukee Bucks" && NBAteam[num] == "BUCKS")
                            {
                                if (lbNBApositions.Text == "All Positions")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Point Guard" && NBAPosition[num] == "PG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Shooting Guard" && NBAPosition[num] == "SG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Small Forward" && NBAPosition[num] == "SF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Power Forward" && NBAPosition[num] == "PF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Center" && NBAPosition[num] == "C")
                                {
                                    printNBA();
                                }
                            }
                            if (lbNBATeams.Text == "Cleveland Cavaliers" && NBAteam[num] == "CAVALIERS")
                            {
                                if (lbNBApositions.Text == "All Positions")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Point Guard" && NBAPosition[num] == "PG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Shooting Guard" && NBAPosition[num] == "SG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Small Forward" && NBAPosition[num] == "SF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Power Forward" && NBAPosition[num] == "PF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Center" && NBAPosition[num] == "C")
                                {
                                    printNBA();
                                }
                            }
                            if (lbNBATeams.Text == "Indiana Pacers" && NBAteam[num] == "PACERS")
                            {
                                if (lbNBApositions.Text == "All Positions")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Point Guard" && NBAPosition[num] == "PG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Shooting Guard" && NBAPosition[num] == "SG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Small Forward" && NBAPosition[num] == "SF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Power Forward" && NBAPosition[num] == "PF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Center" && NBAPosition[num] == "C")
                                {
                                    printNBA();
                                }
                            }
                        }

                    }
                    else if (radEastNBA.Checked && radSoutheast.Checked)
                    {
                        if (NBAConference[num] == "EASTERN" && NBADivision[num] == "SOUTHEAST")
                        {
                            if (lbNBATeams.Text == "All Teams")
                            {
                                if (lbNBApositions.Text == "All Positions")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Point Guard" && NBAPosition[num] == "PG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Shooting Guard" && NBAPosition[num] == "SG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Small Forward" && NBAPosition[num] == "SF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Power Forward" && NBAPosition[num] == "PF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Center" && NBAPosition[num] == "C")
                                {
                                    printNBA();
                                }
                            }
                            if (lbNBATeams.Text == "Miami Heat" && NBAteam[num] == "HEAT")
                            {
                                if (lbNBApositions.Text == "All Positions")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Point Guard" && NBAPosition[num] == "PG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Shooting Guard" && NBAPosition[num] == "SG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Small Forward" && NBAPosition[num] == "SF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Power Forward" && NBAPosition[num] == "PF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Center" && NBAPosition[num] == "C")
                                {
                                    printNBA();
                                }
                            }
                            if (lbNBATeams.Text == "Charlotte Hornets" && NBAteam[num] == "HORNETS")
                            {
                                if (lbNBApositions.Text == "All Positions")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Point Guard" && NBAPosition[num] == "PG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Shooting Guard" && NBAPosition[num] == "SG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Small Forward" && NBAPosition[num] == "SF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Power Forward" && NBAPosition[num] == "PF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Center" && NBAPosition[num] == "C")
                                {
                                    printNBA();
                                }
                            }
                            if (lbNBATeams.Text == "Atlanta Hawks" && NBAteam[num] == "HAWKS")
                            {
                                if (lbNBApositions.Text == "All Positions")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Point Guard" && NBAPosition[num] == "PG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Shooting Guard" && NBAPosition[num] == "SG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Small Forward" && NBAPosition[num] == "SF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Power Forward" && NBAPosition[num] == "PF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Center" && NBAPosition[num] == "C")
                                {
                                    printNBA();
                                }
                            }
                            if (lbNBATeams.Text == "Washington Wizards" && NBAteam[num] == "WIZARDS")
                            {
                                if (lbNBApositions.Text == "All Positions")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Point Guard" && NBAPosition[num] == "PG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Shooting Guard" && NBAPosition[num] == "SG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Small Forward" && NBAPosition[num] == "SF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Power Forward" && NBAPosition[num] == "PF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Center" && NBAPosition[num] == "C")
                                {
                                    printNBA();
                                }
                            }
                            if (lbNBATeams.Text == "Orlando Magic" && NBAteam[num] == "MAGIC")
                            {
                                if (lbNBApositions.Text == "All Positions")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Point Guard" && NBAPosition[num] == "PG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Shooting Guard" && NBAPosition[num] == "SG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Small Forward" && NBAPosition[num] == "SF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Power Forward" && NBAPosition[num] == "PF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Center" && NBAPosition[num] == "C")
                                {
                                    printNBA();
                                }
                            }
                        }
                    }
                    else if (radWestNBA.Checked && radNorthwest.Checked)
                    {
                        if (NBAConference[num] == "WESTERN" && NBADivision[num] == "NORTHWEST")
                        {
                            if (lbNBATeams.Text == "All Teams")
                            {
                                if (lbNBApositions.Text == "All Positions")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Point Guard" && NBAPosition[num] == "PG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Shooting Guard" && NBAPosition[num] == "SG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Small Forward" && NBAPosition[num] == "SF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Power Forward" && NBAPosition[num] == "PF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Center" && NBAPosition[num] == "C")
                                {
                                    printNBA();
                                }
                            }
                            if (lbNBATeams.Text == "Minnesota Timberwolves" && NBAteam[num] == "TIMBERWOLVES")
                            {
                                if (lbNBApositions.Text == "All Positions")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Point Guard" && NBAPosition[num] == "PG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Shooting Guard" && NBAPosition[num] == "SG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Small Forward" && NBAPosition[num] == "SF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Power Forward" && NBAPosition[num] == "PF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Center" && NBAPosition[num] == "C")
                                {
                                    printNBA();
                                }
                            }
                            if (lbNBATeams.Text == "Oklahoma City Thunder" && NBAteam[num] == "THUNDER")
                            {
                                if (lbNBApositions.Text == "All Positions")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Point Guard" && NBAPosition[num] == "PG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Shooting Guard" && NBAPosition[num] == "SG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Small Forward" && NBAPosition[num] == "SF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Power Forward" && NBAPosition[num] == "PF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Center" && NBAPosition[num] == "C")
                                {
                                    printNBA();
                                }
                            }
                            if (lbNBATeams.Text == "Utah Jazz" && NBAteam[num] == "JAZZ")
                            {
                                if (lbNBApositions.Text == "All Positions")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Point Guard" && NBAPosition[num] == "PG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Shooting Guard" && NBAPosition[num] == "SG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Small Forward" && NBAPosition[num] == "SF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Power Forward" && NBAPosition[num] == "PF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Center" && NBAPosition[num] == "C")
                                {
                                    printNBA();
                                }
                            }
                            if (lbNBATeams.Text == "Portland Trail Blazers" && NBAteam[num] == "BLAZERS")
                            {
                                if (lbNBApositions.Text == "All Positions")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Point Guard" && NBAPosition[num] == "PG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Shooting Guard" && NBAPosition[num] == "SG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Small Forward" && NBAPosition[num] == "SF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Power Forward" && NBAPosition[num] == "PF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Center" && NBAPosition[num] == "C")
                                {
                                    printNBA();
                                }
                            }
                            if (lbNBATeams.Text == "Denver Nuggets" && NBAteam[num] == "NUGGETS")
                            {
                                if (lbNBApositions.Text == "All Positions")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Point Guard" && NBAPosition[num] == "PG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Shooting Guard" && NBAPosition[num] == "SG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Small Forward" && NBAPosition[num] == "SF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Power Forward" && NBAPosition[num] == "PF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Center" && NBAPosition[num] == "C")
                                {
                                    printNBA();
                                }
                            }

                        }
                    }
                    else if (radWestNBA.Checked && radPacific.Checked)
                    {
                        if (NBAConference[num] == "WESTERN" && NBADivision[num] == "PACIFIC")
                        {
                            if (lbNBATeams.Text == "All Teams")
                            {
                                if (lbNBApositions.Text == "All Positions")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Point Guard" && NBAPosition[num] == "PG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Shooting Guard" && NBAPosition[num] == "SG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Small Forward" && NBAPosition[num] == "SF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Power Forward" && NBAPosition[num] == "PF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Center" && NBAPosition[num] == "C")
                                {
                                    printNBA();
                                }
                            }
                            if (lbNBATeams.Text == "Phoenix Suns" && NBAteam[num] == "SUNS")
                            {
                                if (lbNBApositions.Text == "All Positions")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Point Guard" && NBAPosition[num] == "PG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Shooting Guard" && NBAPosition[num] == "SG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Small Forward" && NBAPosition[num] == "SF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Power Forward" && NBAPosition[num] == "PF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Center" && NBAPosition[num] == "C")
                                {
                                    printNBA();
                                }
                            }
                            if (lbNBATeams.Text == "Los Angeles Clippers" && NBAteam[num] == "CLIPPERS")
                            {
                                if (lbNBApositions.Text == "All Positions")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Point Guard" && NBAPosition[num] == "PG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Shooting Guard" && NBAPosition[num] == "SG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Small Forward" && NBAPosition[num] == "SF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Power Forward" && NBAPosition[num] == "PF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Center" && NBAPosition[num] == "C")
                                {
                                    printNBA();
                                }
                            }
                            if (lbNBATeams.Text == "Los Angeles Lakers" && NBAteam[num] == "LAKERS")
                            {
                                if (lbNBApositions.Text == "All Positions")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Point Guard" && NBAPosition[num] == "PG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Shooting Guard" && NBAPosition[num] == "SG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Small Forward" && NBAPosition[num] == "SF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Power Forward" && NBAPosition[num] == "PF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Center" && NBAPosition[num] == "C")
                                {
                                    printNBA();
                                }
                            }
                            if (lbNBATeams.Text == "Sacramento Kings" && NBAteam[num] == "KINGS")
                            {
                                if (lbNBApositions.Text == "All Positions")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Point Guard" && NBAPosition[num] == "PG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Shooting Guard" && NBAPosition[num] == "SG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Small Forward" && NBAPosition[num] == "SF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Power Forward" && NBAPosition[num] == "PF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Center" && NBAPosition[num] == "C")
                                {
                                    printNBA();
                                }
                            }
                            if (lbNBATeams.Text == "Golden State Warriors" && NBAteam[num] == "WARRIORS")
                            {
                                if (lbNBApositions.Text == "All Positions")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Point Guard" && NBAPosition[num] == "PG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Shooting Guard" && NBAPosition[num] == "SG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Small Forward" && NBAPosition[num] == "SF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Power Forward" && NBAPosition[num] == "PF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Center" && NBAPosition[num] == "C")
                                {
                                    printNBA();
                                }
                            }
                        }
                    }
                    else if (radWestNBA.Checked && radSouthwest.Checked)
                    {
                        if (NBAConference[num] == "WESTERN" && NBADivision[num] == "SOUTHWEST")
                        {
                            if (lbNBATeams.Text == "All Teams")
                            {
                                if (lbNBApositions.Text == "All Positions")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Point Guard" && NBAPosition[num] == "PG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Shooting Guard" && NBAPosition[num] == "SG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Small Forward" && NBAPosition[num] == "SF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Power Forward" && NBAPosition[num] == "PF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Center" && NBAPosition[num] == "C")
                                {
                                    printNBA();
                                }
                            }
                            if (lbNBATeams.Text == "Minnesota Timberwolves" && NBAteam[num] == "TIMBERWOLVES")
                            {
                                if (lbNBApositions.Text == "All Positions")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Point Guard" && NBAPosition[num] == "PG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Shooting Guard" && NBAPosition[num] == "SG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Small Forward" && NBAPosition[num] == "SF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Power Forward" && NBAPosition[num] == "PF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Center" && NBAPosition[num] == "C")
                                {
                                    printNBA();
                                }
                            }
                            if (lbNBATeams.Text == "Oklahoma City Thunder" && NBAteam[num] == "THUNDER")
                            {
                                if (lbNBApositions.Text == "All Positions")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Point Guard" && NBAPosition[num] == "PG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Shooting Guard" && NBAPosition[num] == "SG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Small Forward" && NBAPosition[num] == "SF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Power Forward" && NBAPosition[num] == "PF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Center" && NBAPosition[num] == "C")
                                {
                                    printNBA();
                                }
                            }
                            if (lbNBATeams.Text == "Utah Jazz" && NBAteam[num] == "JAZZ")
                            {
                                if (lbNBApositions.Text == "All Positions")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Point Guard" && NBAPosition[num] == "PG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Shooting Guard" && NBAPosition[num] == "SG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Small Forward" && NBAPosition[num] == "SF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Power Forward" && NBAPosition[num] == "PF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Center" && NBAPosition[num] == "C")
                                {
                                    printNBA();
                                }
                            }
                            if (lbNBATeams.Text == "Portland Trail Blazers" && NBAteam[num] == "BLAZERS")
                            {
                                if (lbNBApositions.Text == "All Positions")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Point Guard" && NBAPosition[num] == "PG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Shooting Guard" && NBAPosition[num] == "SG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Small Forward" && NBAPosition[num] == "SF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Power Forward" && NBAPosition[num] == "PF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Center" && NBAPosition[num] == "C")
                                {
                                    printNBA();
                                }
                            }
                            if (lbNBATeams.Text == "Denver Nuggets" && NBAteam[num] == "NUGGETS")
                            {
                                if (lbNBApositions.Text == "All Positions")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Point Guard" && NBAPosition[num] == "PG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Shooting Guard" && NBAPosition[num] == "SG")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Small Forward" && NBAPosition[num] == "SF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Power Forward" && NBAPosition[num] == "PF")
                                {
                                    printNBA();
                                }
                                else if (lbNBApositions.Text == "Center" && NBAPosition[num] == "C")
                                {
                                    printNBA();
                                }
                            }

                        }
                    }

                    num++;
                }

            }
            else if (radWNBA.Checked)
            {
                rtbLabels.AppendText("Team    Player                  ");

                double Wg = 0;
                double Wfgm = 0;
                double Wfga = 0;
                double Wtpm = 0;
                double Wtpa = 0;
                double Wftm = 0;
                double Wfta = 0;
                double Wpt = 0;
                double Wtsa = 0;
                double Wor = 0;
                double Wdr = 0;
                double Wa = 0;
                double Ws = 0;
                double Wb = 0;
                double Wt = 0;

                string path = @"WNBAStats.csv";
                StreamReader textIn = new StreamReader(
                new FileStream(path, FileMode.Open, FileAccess.Read));

                labelCheck();

                num = 0;

                while (textIn.Peek() != -1)
                {
                    Array.Resize<string>(ref WNBAteam, WNBAteam.Length + 1);
                    Array.Resize<string>(ref WNBAname, WNBAname.Length + 1);
                    Array.Resize<string>(ref WNBAPosition, WNBAPosition.Length + 1);
                    Array.Resize<string>(ref WNBAConference, WNBAConference.Length + 1);


                    string row = textIn.ReadLine();
                    string[] record = row.Split(',');
                    WNBAteam[num] = Convert.ToString(record[1]).ToUpper();
                    WNBAname[num] = Convert.ToString(record[2] + " " + record[3]).ToUpper();
                    WNBAPosition[num] = Convert.ToString(record[4]).ToUpper();
                    WNBAConference[num] = Convert.ToString(record[0]).ToUpper();


                    Array.Resize<double>(ref WNBAgamesplayed, WNBAgamesplayed.Length + 1);
                    WNBAgamesplayed[num] = Convert.ToDouble(record[5]);
                    Wg = Convert.ToDouble(record[5]);

                    Array.Resize<double>(ref WNBAfgmakes, WNBAfgmakes.Length + 1);
                    WNBAfgmakes[num] = Convert.ToDouble(record[6]);
                    Wfgm = Convert.ToDouble(record[6]);

                    Array.Resize<double>(ref WNBAfgattempts, WNBAfgattempts.Length + 1);
                    WNBAfgattempts[num] = Convert.ToDouble(record[7]);
                    Wfga = Convert.ToDouble(record[7]);

                    Array.Resize<double>(ref WNBAtpmakes, WNBAtpmakes.Length + 1);
                    WNBAtpmakes[num] = Convert.ToDouble(record[8]);
                    Wtpm = Convert.ToDouble(record[8]);

                    Array.Resize<double>(ref WNBAtpattempts, WNBAtpattempts.Length + 1);
                    WNBAtpattempts[num] = Convert.ToDouble(record[9]);
                    Wtpa = Convert.ToDouble(record[9]);

                    Array.Resize<double>(ref WNBAftmakes, WNBAftmakes.Length + 1);
                    WNBAftmakes[num] = Convert.ToDouble(record[10]);
                    Wftm = Convert.ToDouble(record[10]);

                    Array.Resize<double>(ref WNBAftattempts, WNBAftattempts.Length + 1);
                    WNBAftattempts[num] = Convert.ToDouble(record[11]);
                    Wfta = Convert.ToDouble(record[11]);

                    Array.Resize<double>(ref WNBAob, WNBAob.Length + 1);
                    WNBAob[num] = Convert.ToDouble(record[12]);
                    Wor = Convert.ToDouble(record[12]);

                    Array.Resize<double>(ref WNBAdb, WNBAdb.Length + 1);
                    WNBAdb[num] = Convert.ToDouble(record[13]);
                    Wdr = Convert.ToDouble(record[13]);

                    Array.Resize<double>(ref WNBAassists, WNBAassists.Length + 1);
                    WNBAassists[num] = Convert.ToDouble(record[14]);
                    Wa = Convert.ToDouble(record[14]);

                    Array.Resize<double>(ref WNBAblocks, WNBAblocks.Length + 1);
                    WNBAblocks[num] = Convert.ToDouble(record[15]);
                    Wb = Convert.ToDouble(record[15]);

                    Array.Resize<double>(ref WNBAsteals, WNBAsteals.Length + 1);
                    WNBAsteals[num] = Convert.ToDouble(record[16]);
                    Ws = Convert.ToDouble(record[16]);

                    Array.Resize<double>(ref WNBAto, WNBAto.Length + 1);
                    WNBAto[num] = Convert.ToDouble(record[17]);
                    Wt = Convert.ToDouble(record[17]);

                    Array.Resize<double>(ref WNBAtotalpoints, WNBAtotalpoints.Length + 1);
                    WNBAtotalpoints[num] = Convert.ToDouble(record[18]);
                    Wpt = Convert.ToDouble(record[18]);

                    Array.Resize<double>(ref WNBAfieldgoalpercentage, WNBAfieldgoalpercentage.Length + 1);
                    var FGP = new WNBA(Wfgm, Wfga, 0);
                    WNBAfieldgoalpercentage[num] = FGP.CalculateFGP();

                    Array.Resize<double>(ref WNBAthreepointpercentage, WNBAthreepointpercentage.Length + 1);
                    var TPP = new WNBA(Wtpm, Wtpa, 0, 0);
                    WNBAthreepointpercentage[num] = TPP.CalculateTPP();

                    Array.Resize<double>(ref WNBAfreethrowpercentage, WNBAfreethrowpercentage.Length + 1);
                    var FTP = new WNBA(Wftm, Wfta, 0, 0, 0);
                    WNBAfreethrowpercentage[num] = FTP.CalculateFTP();

                    Array.Resize<double>(ref WNBAtrueshootingattempt, WNBAtrueshootingattempt.Length + 1);
                    var TSA = new WNBA(Wfga, Wfta, 0, 0, 0, 0);
                    WNBAtrueshootingattempt[num] = TSA.CalculateTSA();
                    Wtsa = WNBAtrueshootingattempt[num];

                    Array.Resize<double>(ref WNBAtrueshootingpercentage, WNBAtrueshootingpercentage.Length + 1);
                    var TS = new WNBA(Wpt, Wtsa, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
                    WNBAtrueshootingpercentage[num] = TS.CalculateTS();

                    Array.Resize<double>(ref WNBAscoringefficiency, WNBAscoringefficiency.Length + 1);
                    var SCEFF = new WNBA(Wpt, Wor, Wdr, Wa, Ws, Wb, Wt, Wg);
                    WNBAscoringefficiency[num] = SCEFF.CalculateSCEFF();

                    Array.Resize<double>(ref WNBAshootingefficiency, WNBAshootingefficiency.Length + 1);
                    var SHEFF = new WNBA(Wfgm, Wtpm, Wfga, 0, 0, 0, 0);
                    WNBAshootingefficiency[num] = SHEFF.CalculateSHEFF();

                    Array.Resize<double>(ref WNBAstealspergame, WNBAstealspergame.Length + 1);
                    var STLPG = new WNBA(Ws, Wg, 0, 0, 0, 0, 0, 0, 0);
                    WNBAstealspergame[num] = STLPG.CalculateSTLPG();

                    Array.Resize<double>(ref WNBAturnoverspergame, WNBAturnoverspergame.Length + 1);
                    var TOPG = new WNBA(Wt, Wg, 0, 0, 0, 0, 0, 0, 0, 0);
                    WNBAturnoverspergame[num] = TOPG.CalculateTOPG();

                    Array.Resize<double>(ref WNBAassistspergame, WNBAassistspergame.Length + 1);
                    var ASTSPG = new WNBA(Wa, Wg, 0, 0, 0, 0, 0, 0, 0, 0, 0);
                    WNBAassistspergame[num] = ASTSPG.CalculateASTSPG();

                    Array.Resize<double>(ref WNBAblockspergame, WNBAblockspergame.Length + 1);
                    var BLKPG = new WNBA(Wb, Wg, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
                    WNBAblockspergame[num] = BLKPG.CalculateBLKPG();

                    Array.Resize<double>(ref WNBAassitstoturnovers, WNBAassitstoturnovers.Length + 1);
                    var ASTTO = new WNBA(Wa, Wt, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
                    WNBAassitstoturnovers[num] = ASTTO.CalculateASTTO();

                    Array.Resize<double>(ref WNBAreboundspergame, WNBAreboundspergame.Length + 1);
                    var REBPG = new WNBA(Wor, Wdr, Wg, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
                    WNBAreboundspergame[num] = REBPG.CalculateREBPG();

                    if (radMLB.Checked)
                    {
                        if (lbWNBATeams.Text == "All Teams")
                        {


                            if (lbWNBApositions.Text == "All Positions")
                            {
                                printWNBA();
                            }
                            else if (lbWNBApositions.Text == "Guard" && WNBAPosition[num] == "G")
                            {
                                printWNBA();
                            }
                            else if (lbWNBApositions.Text == "Forward" && WNBAPosition[num] == "F")
                            {
                                printWNBA();
                            }
                            else if (lbWNBApositions.Text == "Center" && WNBAPosition[num] == "C")
                            {
                                printWNBA();
                            }

                        }
                        if (lbWNBATeams.Text == "Atlanta Dream" && WNBAteam[num] == "DREAM")
                        {
                            if (lbWNBApositions.Text == "All Positions")
                            {
                                printWNBA();
                            }
                            else if (lbWNBApositions.Text == "Guard" && WNBAPosition[num] == "G")
                            {
                                printWNBA();
                            }
                            else if (lbWNBApositions.Text == "Forward" && WNBAPosition[num] == "F")
                            {
                                printWNBA();
                            }
                            else if (lbWNBApositions.Text == "Center" && WNBAPosition[num] == "C")
                            {
                                printWNBA();
                            }
                        }
                        if (lbWNBATeams.Text == "Chicago Sky" && WNBAteam[num] == "SKY")
                        {

                            {
                                if (lbWNBApositions.Text == "All Positions")
                                {
                                    printWNBA();
                                }
                                else if (lbWNBApositions.Text == "Guard" && WNBAPosition[num] == "G")
                                {
                                    printWNBA();
                                }
                                else if (lbWNBApositions.Text == "Forward" && WNBAPosition[num] == "F")
                                {
                                    printWNBA();
                                }
                                else if (lbWNBApositions.Text == "Center" && WNBAPosition[num] == "C")
                                {
                                    printWNBA();
                                }
                            }
                        }
                        if (lbWNBATeams.Text == "Conneticut Sun" && WNBAteam[num] == "SUNS")
                        {

                            {
                                if (lbWNBApositions.Text == "All Positions")
                                {
                                    printWNBA();
                                }
                                else if (lbWNBApositions.Text == "Guard" && WNBAPosition[num] == "G")
                                {
                                    printWNBA();
                                }
                                else if (lbWNBApositions.Text == "Forward" && WNBAPosition[num] == "F")
                                {
                                    printWNBA();
                                }
                                else if (lbWNBApositions.Text == "Center" && WNBAPosition[num] == "C")
                                {
                                    printWNBA();
                                }
                            }
                        }
                        if (lbWNBATeams.Text == "Dallas Wings" && WNBAteam[num] == "WINGS")
                        {

                            {
                                if (lbWNBApositions.Text == "All Positions")
                                {
                                    printWNBA();
                                }
                                else if (lbWNBApositions.Text == "Guard" && WNBAPosition[num] == "G")
                                {
                                    printWNBA();
                                }
                                else if (lbWNBApositions.Text == "Forward" && WNBAPosition[num] == "F")
                                {
                                    printWNBA();
                                }
                                else if (lbWNBApositions.Text == "Center" && WNBAPosition[num] == "C")
                                {
                                    printWNBA();
                                }
                            }
                        }
                        if (lbWNBATeams.Text == "Indiana Fever" && WNBAteam[num] == "FEVER")
                        {

                            {
                                if (lbWNBApositions.Text == "All Positions")
                                {
                                    printWNBA();
                                }
                                else if (lbWNBApositions.Text == "Guard" && WNBAPosition[num] == "G")
                                {
                                    printWNBA();
                                }
                                else if (lbWNBApositions.Text == "Forward" && WNBAPosition[num] == "F")
                                {
                                    printWNBA();
                                }
                                else if (lbWNBApositions.Text == "Center" && WNBAPosition[num] == "C")
                                {
                                    printWNBA();
                                }
                            }
                        }
                        if (lbWNBATeams.Text == "Las Vegas Aces" && WNBAteam[num] == "ACES")
                        {

                            {
                                if (lbWNBApositions.Text == "All Positions")
                                {
                                    printWNBA();
                                }
                                else if (lbWNBApositions.Text == "Guard" && WNBAPosition[num] == "G")
                                {
                                    printWNBA();
                                }
                                else if (lbWNBApositions.Text == "Forward" && WNBAPosition[num] == "F")
                                {
                                    printWNBA();
                                }
                                else if (lbWNBApositions.Text == "Center" && WNBAPosition[num] == "C")
                                {
                                    printWNBA();
                                }
                            }
                        }
                        if (lbWNBATeams.Text == "Los Angeles Sparks" && WNBAteam[num] == "SPARKS")
                        {

                            {
                                if (lbWNBApositions.Text == "All Positions")
                                {
                                    printWNBA();
                                }
                                else if (lbWNBApositions.Text == "Guard" && WNBAPosition[num] == "G")
                                {
                                    printWNBA();
                                }
                                else if (lbWNBApositions.Text == "Forward" && WNBAPosition[num] == "F")
                                {
                                    printWNBA();
                                }
                                else if (lbWNBApositions.Text == "Center" && WNBAPosition[num] == "C")
                                {
                                    printWNBA();
                                }
                            }
                        }
                        if (lbWNBATeams.Text == "Minnesota Lynx" && WNBAteam[num] == "LYNX")
                        {

                            {
                                if (lbWNBApositions.Text == "All Positions")
                                {
                                    printWNBA();
                                }
                                else if (lbWNBApositions.Text == "Guard" && WNBAPosition[num] == "G")
                                {
                                    printWNBA();
                                }
                                else if (lbWNBApositions.Text == "Forward" && WNBAPosition[num] == "F")
                                {
                                    printWNBA();
                                }
                                else if (lbWNBApositions.Text == "Center" && WNBAPosition[num] == "C")
                                {
                                    printWNBA();
                                }
                            }
                        }
                        if (lbWNBATeams.Text == "Phoenix Mercury" && WNBAteam[num] == "MERCURY")
                        {

                            {
                                if (lbWNBApositions.Text == "All Positions")
                                {
                                    printWNBA();
                                }
                                else if (lbWNBApositions.Text == "Guard" && WNBAPosition[num] == "G")
                                {
                                    printWNBA();
                                }
                                else if (lbWNBApositions.Text == "Forward" && WNBAPosition[num] == "F")
                                {
                                    printWNBA();
                                }
                                else if (lbWNBApositions.Text == "Center" && WNBAPosition[num] == "C")
                                {
                                    printWNBA();
                                }
                            }
                        }
                        if (lbWNBATeams.Text == "Seattle Storm" && WNBAteam[num] == "STORM")
                        {

                            {
                                if (lbWNBApositions.Text == "All Positions")
                                {
                                    printWNBA();
                                }
                                else if (lbWNBApositions.Text == "Guard" && WNBAPosition[num] == "G")
                                {
                                    printWNBA();
                                }
                                else if (lbWNBApositions.Text == "Forward" && WNBAPosition[num] == "F")
                                {
                                    printWNBA();
                                }
                                else if (lbWNBApositions.Text == "Center" && WNBAPosition[num] == "C")
                                {
                                    printWNBA();
                                }
                            }
                        }
                        if (lbWNBATeams.Text == "Washington Mystics" && WNBAteam[num] == "MYSTICS")
                        {

                            {
                                if (lbWNBApositions.Text == "All Positions")
                                {
                                    printWNBA();
                                }
                                else if (lbWNBApositions.Text == "Guard" && WNBAPosition[num] == "G")
                                {
                                    printWNBA();
                                }
                                else if (lbWNBApositions.Text == "Forward" && WNBAPosition[num] == "F")
                                {
                                    printWNBA();
                                }
                                else if (lbWNBApositions.Text == "Center" && WNBAPosition[num] == "C")
                                {
                                    printWNBA();
                                }
                            }
                        }
                        if (lbWNBATeams.Text == "New York Liberty" && WNBAteam[num] == "LIBERTY")
                        {

                            {
                                if (lbWNBApositions.Text == "All Positions")
                                {
                                    printWNBA();
                                }
                                else if (lbWNBApositions.Text == "Guard" && WNBAPosition[num] == "G")
                                {
                                    printWNBA();
                                }
                                else if (lbWNBApositions.Text == "Forward" && WNBAPosition[num] == "F")
                                {
                                    printWNBA();
                                }
                                else if (lbWNBApositions.Text == "Center" && WNBAPosition[num] == "C")
                                {
                                    printWNBA();
                                }
                            }
                        }
                    }
                    else if (radEastNBA.Checked)
                    {
                        if (WNBAConference[num] == "EASTERN")
                        {
                            if (lbWNBATeams.Text == "All Teams")
                            {

                                {


                                    if (lbWNBApositions.Text == "All Positions")
                                    {
                                        printWNBA();
                                    }
                                    else if (lbWNBApositions.Text == "Guard" && WNBAPosition[num] == "G")
                                    {
                                        printWNBA();
                                    }
                                    else if (lbWNBApositions.Text == "Forward" && WNBAPosition[num] == "F")
                                    {
                                        printWNBA();
                                    }
                                    else if (lbWNBApositions.Text == "Center" && WNBAPosition[num] == "C")
                                    {
                                        printWNBA();
                                    }

                                }
                            }
                            if (lbWNBATeams.Text == "Atlanta Dream" && WNBAteam[num] == "DREAM")
                            {

                                {
                                    if (lbWNBApositions.Text == "All Positions")
                                    {
                                        printWNBA();
                                    }
                                    else if (lbWNBApositions.Text == "Guard" && WNBAPosition[num] == "G")
                                    {
                                        printWNBA();
                                    }
                                    else if (lbWNBApositions.Text == "Forward" && WNBAPosition[num] == "F")
                                    {
                                        printWNBA();
                                    }
                                    else if (lbWNBApositions.Text == "Center" && WNBAPosition[num] == "C")
                                    {
                                        printWNBA();
                                    }
                                }
                            }
                            if (lbWNBATeams.Text == "Chicago Sky" && WNBAteam[num] == "SKY")
                            {

                                {
                                    if (lbWNBApositions.Text == "All Positions")
                                    {
                                        printWNBA();
                                    }
                                    else if (lbWNBApositions.Text == "Guard" && WNBAPosition[num] == "G")
                                    {
                                        printWNBA();
                                    }
                                    else if (lbWNBApositions.Text == "Forward" && WNBAPosition[num] == "F")
                                    {
                                        printWNBA();
                                    }
                                    else if (lbWNBApositions.Text == "Center" && WNBAPosition[num] == "C")
                                    {
                                        printWNBA();
                                    }
                                }
                            }
                            if (lbWNBATeams.Text == "Conneticut Sun" && WNBAteam[num] == "SUNS")
                            {

                                {
                                    if (lbWNBApositions.Text == "All Positions")
                                    {
                                        printWNBA();
                                    }
                                    else if (lbWNBApositions.Text == "Guard" && WNBAPosition[num] == "G")
                                    {
                                        printWNBA();
                                    }
                                    else if (lbWNBApositions.Text == "Forward" && WNBAPosition[num] == "F")
                                    {
                                        printWNBA();
                                    }
                                    else if (lbWNBApositions.Text == "Center" && WNBAPosition[num] == "C")
                                    {
                                        printWNBA();
                                    }
                                }
                            }
                            if (lbWNBATeams.Text == "Indiana Fever" && WNBAteam[num] == "FEVER")
                            {

                                {
                                    if (lbWNBApositions.Text == "All Positions")
                                    {
                                        printWNBA();
                                    }
                                    else if (lbWNBApositions.Text == "Guard" && WNBAPosition[num] == "G")
                                    {
                                        printWNBA();
                                    }
                                    else if (lbWNBApositions.Text == "Forward" && WNBAPosition[num] == "F")
                                    {
                                        printWNBA();
                                    }
                                    else if (lbWNBApositions.Text == "Center" && WNBAPosition[num] == "C")
                                    {
                                        printWNBA();
                                    }
                                }
                            }
                            if (lbWNBATeams.Text == "New York Liberty" && WNBAteam[num] == "LIBERTY")
                            {

                                {
                                    if (lbWNBApositions.Text == "All Positions")
                                    {
                                        printWNBA();
                                    }
                                    else if (lbWNBApositions.Text == "Guard" && WNBAPosition[num] == "G")
                                    {
                                        printWNBA();
                                    }
                                    else if (lbWNBApositions.Text == "Forward" && WNBAPosition[num] == "F")
                                    {
                                        printWNBA();
                                    }
                                    else if (lbWNBApositions.Text == "Center" && WNBAPosition[num] == "C")
                                    {
                                        printWNBA();
                                    }
                                }
                            }
                            if (lbWNBATeams.Text == "Washington Mystics" && WNBAteam[num] == "MYSTICS")
                            {

                                {
                                    if (lbWNBApositions.Text == "All Positions")
                                    {
                                        printWNBA();
                                    }
                                    else if (lbWNBApositions.Text == "Guard" && WNBAPosition[num] == "G")
                                    {
                                        printWNBA();
                                    }
                                    else if (lbWNBApositions.Text == "Forward" && WNBAPosition[num] == "F")
                                    {
                                        printWNBA();
                                    }
                                    else if (lbWNBApositions.Text == "Center" && WNBAPosition[num] == "C")
                                    {
                                        printWNBA();
                                    }
                                }
                            }
                        }
                    }
                    else if (radWestNBA.Checked)
                    {
                        if (WNBAConference[num] == "WESTERN")
                        {
                            if (lbWNBATeams.Text == "All Teams")
                            {

                                {


                                    if (lbWNBApositions.Text == "All Positions")
                                    {
                                        printWNBA();
                                    }
                                    else if (lbWNBApositions.Text == "Guard" && WNBAPosition[num] == "G")
                                    {
                                        printWNBA();
                                    }
                                    else if (lbWNBApositions.Text == "Forward" && WNBAPosition[num] == "F")
                                    {
                                        printWNBA();
                                    }
                                    else if (lbWNBApositions.Text == "Center" && NBAPosition[num] == "C")
                                    {
                                        printWNBA();
                                    }

                                }
                            }
                            if (lbWNBATeams.Text == "Dallas Wings" && WNBAteam[num] == "WINGS")
                            {

                                {
                                    if (lbWNBApositions.Text == "All Positions")
                                    {
                                        printWNBA();
                                    }
                                    else if (lbWNBApositions.Text == "Guard" && WNBAPosition[num] == "G")
                                    {
                                        printWNBA();
                                    }
                                    else if (lbWNBApositions.Text == "Forward" && WNBAPosition[num] == "F")
                                    {
                                        printWNBA();
                                    }
                                    else if (lbWNBApositions.Text == "Center" && WNBAPosition[num] == "C")
                                    {
                                        printWNBA();
                                    }
                                }
                            }
                            if (lbWNBATeams.Text == "Las Vegas Aces" && WNBAteam[num] == "ACES")
                            {

                                {
                                    if (lbWNBApositions.Text == "All Positions")
                                    {
                                        printWNBA();
                                    }
                                    else if (lbWNBApositions.Text == "Guard" && WNBAPosition[num] == "G")
                                    {
                                        printWNBA();
                                    }
                                    else if (lbWNBApositions.Text == "Forward" && WNBAPosition[num] == "F")
                                    {
                                        printWNBA();
                                    }
                                    else if (lbWNBApositions.Text == "Center" && WNBAPosition[num] == "C")
                                    {
                                        printWNBA();
                                    }
                                }
                            }
                            if (lbWNBATeams.Text == "Los Angeles Sparks" && WNBAteam[num] == "SPARKS")
                            {

                                {
                                    if (lbWNBApositions.Text == "All Positions")
                                    {
                                        printWNBA();
                                    }
                                    else if (lbWNBApositions.Text == "Guard" && WNBAPosition[num] == "G")
                                    {
                                        printWNBA();
                                    }
                                    else if (lbWNBApositions.Text == "Forward" && WNBAPosition[num] == "F")
                                    {
                                        printWNBA();
                                    }
                                    else if (lbWNBApositions.Text == "Center" && WNBAPosition[num] == "C")
                                    {
                                        printWNBA();
                                    }
                                }
                            }
                            if (lbWNBATeams.Text == "Minnesota Lynx" && WNBAteam[num] == "LYNX")
                            {

                                {
                                    if (lbWNBApositions.Text == "All Positions")
                                    {
                                        printWNBA();
                                    }
                                    else if (lbWNBApositions.Text == "Guard" && WNBAPosition[num] == "G")
                                    {
                                        printWNBA();
                                    }
                                    else if (lbWNBApositions.Text == "Forward" && WNBAPosition[num] == "F")
                                    {
                                        printWNBA();
                                    }
                                    else if (lbWNBApositions.Text == "Center" && WNBAPosition[num] == "C")
                                    {
                                        printWNBA();
                                    }
                                }
                            }
                            if (lbWNBATeams.Text == "Phoenix Mercury" && WNBAteam[num] == "MERCURY")
                            {

                                {
                                    if (lbWNBApositions.Text == "All Positions")
                                    {
                                        printWNBA();
                                    }
                                    else if (lbWNBApositions.Text == "Guard" && WNBAPosition[num] == "G")
                                    {
                                        printWNBA();
                                    }
                                    else if (lbWNBApositions.Text == "Forward" && WNBAPosition[num] == "F")
                                    {
                                        printWNBA();
                                    }
                                    else if (lbWNBApositions.Text == "Center" && WNBAPosition[num] == "C")
                                    {
                                        printWNBA();
                                    }
                                }
                            }
                            if (lbWNBATeams.Text == "Seattle Storm" && WNBAteam[num] == "STORM")
                            {

                                {
                                    if (lbWNBApositions.Text == "All Positions")
                                    {
                                        printWNBA();
                                    }
                                    else if (lbWNBApositions.Text == "Guard" && WNBAPosition[num] == "G")
                                    {
                                        printWNBA();
                                    }
                                    else if (lbWNBApositions.Text == "Forward" && WNBAPosition[num] == "F")
                                    {
                                        printWNBA();
                                    }
                                    else if (lbWNBApositions.Text == "Center" && WNBAPosition[num] == "C")
                                    {
                                        printWNBA();
                                    }
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

            if (cbSOBB.Checked)
                rtbOut.AppendText(StrikeOutToWalk[num].ToString("n1").PadLeft(6));

            if (cbBBRate.Checked)
                rtbOut.AppendText(WalkRate[num].ToString("p1").PadLeft(6));

            if (cbSORate.Checked)
                rtbOut.AppendText(StrikeOutRate[num].ToString("p1").PadLeft(6));

            if (cbFIP.Checked)
                rtbOut.AppendText(FieldingIndependentPitching[num].ToString("n2").PadLeft(5));

            rtbOut.AppendText("\n");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radHitters_CheckedChanged(object sender, EventArgs e)
        {
            if (radHitters.Checked)
            {
                gbNLorAL.Visible = true;
                gbBasicStats.Visible = true;
                radAL.Visible = true;
                radNL.Visible = true;
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
                cbHBP.Visible = true;
                cbIBB.Visible = true;
                cbSF.Visible = true;
            }
            else
            {
                gbNLorAL.Visible = false;
                gbBasicStats.Visible = false;
                radAL.Visible = false;
                radNL.Visible = false;
                cbPA.Visible = false;
                cbAB.Visible = false;
                cbR.Visible = false;
                cbH.Visible = false;
                cb2B.Visible = false;
                cb3B.Visible = false;
                cbHR.Visible = false;
                cbRBI.Visible = false;
                cbSB.Visible = false;
                cbCS.Visible = false;
                cbBB.Visible = false;
                cbSO.Visible = false;
                cbAVG.Visible = false;
                cbOBP.Visible = false;
                cbSLG.Visible = false;
                cbOPS.Visible = false;
                gbAdvanced.Visible = false;
                lbMLBTeams.Visible = false;
                lbHitterPosition.Visible = false;
                gbDivisions.Visible = false;
                cbBABIP.Visible = false;
                cbISO.Visible = false;
                cbOPSPlus.Visible = false;
                cbPASO.Visible = false;
                cbRC.Visible = false;
                cbwRCPlus.Visible = false;
                cbwOBA.Visible = false;
                cbwRAA.Visible = false;
                cbTB.Visible = false;
                cbHBP.Visible = false;
                cbIBB.Visible = false;
                cbSF.Visible = false;
            }
        }

        private void radPitchers_CheckedChanged(object sender, EventArgs e)
        {
            if (radPitchers.Checked)
            {
                gbNLorAL.Visible = true;
                lbMLBTeams.Visible = true;
                gbBasicStats.Visible = true;
                radAL.Visible = true;
                radNL.Visible = true;
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
                cbPIBB.Visible = true;
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
                cbSOBB.Visible = true;
                cbBBRate.Visible = true;
                cbSORate.Visible = true;
                cbFIP.Visible = true;
            }
            else
            {
                gbNLorAL.Visible = false;
                lbMLBTeams.Visible = false;
                gbBasicStats.Visible = false;
                radAL.Visible = false;
                radNL.Visible = false;
                cbWins.Visible = false;
                cbLosses.Visible = false;
                cbGames.Visible = false;
                cbGS.Visible = false;
                cbSV.Visible = false;
                cbIP.Visible = false;
                cbPitcherH.Visible = false;
                cbTotalRuns.Visible = false;
                cbER.Visible = false;
                cbHRGivenUp.Visible = false;
                cbPBB.Visible = false;
                cbPIBB.Visible = false;
                cbPSO.Visible = false;
                cbPHBP.Visible = false;
                cbBF.Visible = false;
                lbStaff.Visible = false;
                gbDivisions.Visible = false;
                gbAdvanced.Visible = false;
                cbERA.Visible = false;
                cbERAPlus.Visible = false;
                cbWPCT.Visible = false;
                cbWHIP.Visible = false;
                cbHRper9.Visible = false;
                cbHitsPer9.Visible = false;
                cbBBper9.Visible = false;
                cbSOper9.Visible = false;
                cbSOBB.Visible = false;
                cbBBRate.Visible = false;
                cbSORate.Visible = false;
                cbFIP.Visible = false;
            }
        }

        private void btnDictionary_Click(object sender, EventArgs e)
        {
            if (radHitters.Checked)
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
                "BF    - Batters Faces\n" +
                "ERA   - Earned Run Average\n" +
                "ERA+  - ERA compared to other pitchers where 100 is average\n" +
                "WPCT  - Win percentage\n" +
                "WHIP   - Walks Plus Hits per Innings" +
                "HR/9   - Home Runs per 9 Innings" +
                "H/9    - Hits per 9 Innings" +
                "BB/9   - Walks per 9 Innings" +
                "SO/9   - Strikeouts per 9 Innings" +
                "SO/BB  - Strikeout to walk percentage" +
                "BB%    - Walk percentage" +
                "SO%    - Strikeout percentage" +
                "FIP    - Fielding Independent Pitching");
            }
            else if (radNBA.Checked || radWNBA.Checked)
            {
                rtbOut.AppendText("NBA Stats:\n\n" +
             "GP     - Games Played\n" +
             "MIN    - Total minutes in games\n" +
             "FGM    - Field Goal Makes\n" +
             "FGA    - Field Goal Attempts\n" +
             "3PM    - 3 Point Makes\n" +
             "3PA    - 3 Point Attempts\n" +
             "FTM    - Free Throw Misses\n" +
             "FTA    - Free Throw Attempts\n" +
             "OR     - Offensive Rebounds\n" +
             "DR     - Defensive Rebounds\n" +
             "AST    - Total Assists\n" +
             "BLK    - Total Blocks\n" +
             "STL    - Total Steals\n" +
             "TO     - Total Turnovers\n" +
             "PTS    - Total Points\n" +
             "MPG    - Minutes per game\n" +
             "FG%    - Field Goal Percentage\n" +
             "3P%    - 3 Point Percentage\n" +
             "FT%    - Free Throw Percentage\n" +
             "TSA    - True Shooting Average\n" +
             "TS%    - True Shooting Percentage\n" +
             "SC-EFF - Scoring Efficiency\n" +
             "SH-EFF - Shooting Efficiency\n" +
             "STL/PG - Steals Per Game\n" +
             "TO/PG  - Turnovers Per Game\n" +
             "AST/PG - Assists Per Game\n" +
             "BLK/PG - Blocks Per Game\n" +
             "STL/PG - Steals Per Game\n" +
             "AST/TO - Assists To Turnover Ratio\n" +
             "REB/PG - Rebounds Per Game\n");
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
                if (cbSOBB.Checked)
                    rtbLabels.AppendText(" SO/BB");
                if (cbBBRate.Checked)
                    rtbLabels.AppendText("   BB%");
                if (cbSORate.Checked)
                    rtbLabels.AppendText("    K%");
                if (cbFIP.Checked)
                    rtbLabels.AppendText("  FIP");
            }
            if (radNBA.Checked || radWNBA.Checked)
            {
                if (cbGamesPlayed.Checked)
                    rtbLabels.AppendText("  GP");

                if (cbMinutes.Checked)
                    rtbLabels.AppendText("    TM");

                if (cbFGmakes.Checked)
                    rtbLabels.AppendText(" FGM");

                if (cbFGattempts.Checked)
                    rtbLabels.AppendText(" FGA");

                if (cb3PM.Checked)
                    rtbLabels.AppendText(" 3PM");

                if (cb3PA.Checked)
                    rtbLabels.AppendText(" 3PA");

                if (cbFTM.Checked)
                    rtbLabels.AppendText(" FTM");

                if (cbFTA.Checked)
                    rtbLabels.AppendText(" FTA");

                if (cbOB.Checked)
                    rtbLabels.AppendText("  OR");

                if (cbDB.Checked)
                    rtbLabels.AppendText("  DR");

                if (cbAssists.Checked)
                    rtbLabels.AppendText(" AST");

                if (cbBlocks.Checked)
                    rtbLabels.AppendText(" BLK");

                if (cbSteals.Checked)
                    rtbLabels.AppendText(" STL");

                if (cbTO.Checked)
                    rtbLabels.AppendText("  TO");

                if (cbPoints.Checked)
                    rtbLabels.AppendText("   PTS");

                if (cbMPG.Checked)
                    rtbLabels.AppendText("   MPG");

                if (cbFGP.Checked)
                    rtbLabels.AppendText("   FG%");

                if (cbTPP.Checked)
                    rtbLabels.AppendText("   3P%");

                if (cbFTP.Checked)
                    rtbLabels.AppendText("   FT%");

                if (cbTSA.Checked)
                    rtbLabels.AppendText("     TSA");

                if (cbTS.Checked)
                    rtbLabels.AppendText("  TS%");

                if (cbSCEFF.Checked)
                    rtbLabels.AppendText(" SC-EFF");

                if (cbSHEFF.Checked)
                    rtbLabels.AppendText(" SH-EFF");

                if (cbSTLPG.Checked)
                    rtbLabels.AppendText(" STL/PG");

                if (cbTOPG.Checked)
                    rtbLabels.AppendText(" TO/PG");

                if (cbASTSPG.Checked)
                    rtbLabels.AppendText(" AST/PG");

                if (cbBLKPG.Checked)
                    rtbLabels.AppendText(" BLK/PG");

                if (cbASTTO.Checked)
                    rtbLabels.AppendText(" AST/TO");

                if (cbREBPG.Checked)
                    rtbLabels.AppendText(" REB/PG");
            }
        }

        private void radNBA_CheckedChanged(object sender, EventArgs e)
        {
            if (radNBA.Checked)
            {
                lbNBATeams.Visible = true;
                lbNBApositions.Visible = true;
                gbDivisions.Visible = true;
                gbBasicStats.Visible = true;
                gbAdvanced.Visible = true;
                gbNLorAL.Visible = true;
                radMLB.Visible = true;
                radEastNBA.Visible = true;
                radWestNBA.Visible = true;
                radAllDivisions.Visible = true;
                radCentralNBA.Visible = true;
                radAtlantic.Visible = true;
                radNorthwest.Visible = true;
                radPacific.Visible = true;
                radSoutheast.Visible = true;
                radSouthwest.Visible = true;
                cbTSA.Visible = true;
                cbTS.Visible = true;
                cbTPP.Visible = true;
                cbTOPG.Visible = true;
                cbTO.Visible = true;
                cbSTLPG.Visible = true;
                cbSteals.Visible = true;
                cbSHEFF.Visible = true;
                cbSCEFF.Visible = true;
                cbREBPG.Visible = true;
                cbPoints.Visible = true;
                cbOB.Visible = true;
                cbMinutes.Visible = true;
                cbGamesPlayed.Visible = true;
                cbFTP.Visible = true;
                cbFTM.Visible = true;
                cbFTA.Visible = true;
                cbFGP.Visible = true;
                cbFGmakes.Visible = true;
                cbFGattempts.Visible = true;
                cbDB.Visible = true;
                cbBlocks.Visible = true;
                cbBLKPG.Visible = true;
                cbASTTO.Visible = true;
                cbASTSPG.Visible = true;
                cbAssists.Visible = true;
                cb3PM.Visible = true;
                cb3PA.Visible = true;
            }
            else
            {
                lbNBATeams.Visible = false;
                lbNBApositions.Visible = false;
                gbDivisions.Visible = false;
                gbBasicStats.Visible = false;
                gbAdvanced.Visible = false;
                gbNLorAL.Visible = false;
                radEastNBA.Visible = false;
                radWestNBA.Visible = false;
                radCentralNBA.Visible = false;
                radAtlantic.Visible = false;
                radNorthwest.Visible = false;
                radPacific.Visible = false;
                radSoutheast.Visible = false;
                radSouthwest.Visible = false;
                cbTSA.Visible = false;
                cbTS.Visible = false;
                cbTPP.Visible = false;
                cbTOPG.Visible = false;
                cbTO.Visible = false;
                cbSTLPG.Visible = false;
                cbSteals.Visible = false;
                cbSHEFF.Visible = false;
                cbSCEFF.Visible = false;
                cbREBPG.Visible = false;
                cbPoints.Visible = false;
                cbOB.Visible = false;
                cbMinutes.Visible = false;
                cbGamesPlayed.Visible = false;
                cbFTP.Visible = false;
                cbFTM.Visible = false;
                cbFTA.Visible = false;
                cbFGP.Visible = false;
                cbFGmakes.Visible = false;
                cbFGattempts.Visible = false;
                cbDB.Visible = false;
                cbBlocks.Visible = false;
                cbBLKPG.Visible = false;
                cbASTTO.Visible = false;
                cbASTSPG.Visible = false;
                cbAssists.Visible = false;
                cb3PM.Visible = false;
                cb3PA.Visible = false;
            }
        }

        private void printNBA()
        {
            rtbOut.AppendText((NBAteam[num]).PadRight(14));
            rtbOut.AppendText((NBAname[num]).PadRight(24));

            if (cbGamesPlayed.Checked)
            {
                rtbOut.AppendText(NBAgamesplayed[num].ToString("n0").PadLeft(4));
            }

            if (cbMinutes.Checked)
            {
                rtbOut.AppendText(NBAmintotal[num].ToString("n0").PadLeft(6));
            }

            if (cbFGmakes.Checked)
            {
                rtbOut.AppendText(NBAfgmakes[num].ToString("n0").PadLeft(4));
            }

            if (cbFGattempts.Checked)
            {
                rtbOut.AppendText(NBAfgattempts[num].ToString("n0").PadLeft(4));
            }

            if (cb3PM.Checked)
            {
                rtbOut.AppendText(NBAtpmakes[num].ToString("n0").PadLeft(4));
            }

            if (cb3PA.Checked)
            {
                rtbOut.AppendText(NBAtpattempts[num].ToString("n0").PadLeft(4));
            }

            if (cbFTM.Checked)
            {
                rtbOut.AppendText(NBAftmakes[num].ToString("n0").PadLeft(4));
            }

            if (cbFTA.Checked)
            {
                rtbOut.AppendText(NBAftattempts[num].ToString("n0").PadLeft(4));
            }

            if (cbOB.Checked)
            {
                rtbOut.AppendText(NBAob[num].ToString("n0").PadLeft(4));
            }

            if (cbDB.Checked)
            {
                rtbOut.AppendText(NBAdb[num].ToString("n0").PadLeft(4));
            }

            if (cbAssists.Checked)
            {
                rtbOut.AppendText(NBAassists[num].ToString("n0").PadLeft(4));
            }

            if (cbBlocks.Checked)
            {
                rtbOut.AppendText(NBAblocks[num].ToString("n0").PadLeft(4));
            }

            if (cbSteals.Checked)
            {
                rtbOut.AppendText(NBAsteals[num].ToString("n0").PadLeft(4));
            }

            if (cbTO.Checked)
            {
                rtbOut.AppendText(NBAto[num].ToString("n0").PadLeft(4));
            }

            if (cbPoints.Checked)
            {
                rtbOut.AppendText(NBAtotalpoints[num].ToString("n0").PadLeft(6));
            }

            if (cbMPG.Checked)
            {
                rtbOut.AppendText(NBAminutespergame[num].ToString("n1").PadLeft(6));
            }

            if (cbFGP.Checked)
            {
                rtbOut.AppendText(NBAfieldgoalpercentage[num].ToString("n2").PadLeft(6));
            }


            if (cbTPP.Checked)
            {
                rtbOut.AppendText(NBAthreepointpercentage[num].ToString("n2").PadLeft(6));
            }


            if (cbFTP.Checked)
            {
                rtbOut.AppendText(NBAfreethrowpercentage[num].ToString("n2").PadLeft(6));
            }


            if (cbTSA.Checked)
            {
                rtbOut.AppendText(NBAtrueshootingattempt[num].ToString("n1").PadLeft(8));
            }

            if (cbTS.Checked)
            {
                rtbOut.AppendText(NBAtrueshootingpercentage[num].ToString("n2").PadLeft(5));
            }


            if (cbSCEFF.Checked)
            {
                rtbOut.AppendText(NBAscoringefficiency[num].ToString("n2").PadLeft(7));
            }

            if (cbSHEFF.Checked)
            {
                rtbOut.AppendText(NBAshootingefficiency[num].ToString("n2").PadLeft(7));
            }

            if (cbSTLPG.Checked)
            {
                rtbOut.AppendText(NBAstealspergame[num].ToString("n1").PadLeft(6));
            }

            if (cbTOPG.Checked)
            {
                rtbOut.AppendText(NBAturnoverspergame[num].ToString("n1").PadLeft(6));
            }

            if (cbASTSPG.Checked)
            {
                rtbOut.AppendText(NBAassistspergame[num].ToString("n1").PadLeft(7));
            }

            if (cbBLKPG.Checked)
            {
                rtbOut.AppendText(NBAblockspergame[num].ToString("n1").PadLeft(7));
            }

            if (cbASTTO.Checked)
            {
                rtbOut.AppendText(NBAassitstoturnovers[num].ToString("n1").PadLeft(7));
            }

            if (cbREBPG.Checked)
            {
                rtbOut.AppendText(NBAreboundspergame[num].ToString("n1").PadLeft(7));
            }

            rtbOut.AppendText("\n");
        }

        private void printWNBA()
        {
            rtbOut.AppendText((WNBAteam[num]).PadRight(8));
            rtbOut.AppendText((WNBAname[num]).PadRight(24));

            if (cbGamesPlayed.Checked)
            {
                rtbOut.AppendText(WNBAgamesplayed[num].ToString("n0").PadLeft(4));
            }

            if (cbFGmakes.Checked)
            {
                rtbOut.AppendText(WNBAfgmakes[num].ToString("n0").PadLeft(4));
            }

            if (cbFGattempts.Checked)
            {
                rtbOut.AppendText(WNBAfgattempts[num].ToString("n0").PadLeft(4));
            }

            if (cb3PM.Checked)
            {
                rtbOut.AppendText(WNBAtpmakes[num].ToString("n0").PadLeft(4));
            }

            if (cb3PA.Checked)
            {
                rtbOut.AppendText(WNBAtpattempts[num].ToString("n0").PadLeft(4));
            }

            if (cbFTM.Checked)
            {
                rtbOut.AppendText(WNBAftmakes[num].ToString("n0").PadLeft(4));
            }

            if (cbFTA.Checked)
            {
                rtbOut.AppendText(WNBAftattempts[num].ToString("n0").PadLeft(4));
            }

            if (cbOB.Checked)
            {
                rtbOut.AppendText(WNBAob[num].ToString("n0").PadLeft(4));
            }

            if (cbDB.Checked)
            {
                rtbOut.AppendText(WNBAdb[num].ToString("n0").PadLeft(4));
            }

            if (cbAssists.Checked)
            {
                rtbOut.AppendText(WNBAassists[num].ToString("n0").PadLeft(4));
            }

            if (cbBlocks.Checked)
            {
                rtbOut.AppendText(WNBAblocks[num].ToString("n0").PadLeft(4));
            }

            if (cbSteals.Checked)
            {
                rtbOut.AppendText(WNBAsteals[num].ToString("n0").PadLeft(4));
            }

            if (cbTO.Checked)
            {
                rtbOut.AppendText(WNBAto[num].ToString("n0").PadLeft(4));
            }

            if (cbPoints.Checked)
            {
                rtbOut.AppendText(WNBAtotalpoints[num].ToString("n0").PadLeft(6));
            }

            if (cbFGP.Checked)
            {
                rtbOut.AppendText(WNBAfieldgoalpercentage[num].ToString("n2").PadLeft(6));
            }


            if (cbTPP.Checked)
            {
                rtbOut.AppendText(WNBAthreepointpercentage[num].ToString("n2").PadLeft(6));
            }


            if (cbFTP.Checked)
            {
                rtbOut.AppendText(WNBAfreethrowpercentage[num].ToString("n2").PadLeft(6));
            }


            if (cbTSA.Checked)
            {
                rtbOut.AppendText(WNBAtrueshootingattempt[num].ToString("n2").PadLeft(7));
            }

            if (cbTS.Checked)
            {
                rtbOut.AppendText(WNBAtrueshootingpercentage[num].ToString("n2").PadLeft(5));
            }


            if (cbSCEFF.Checked)
            {
                rtbOut.AppendText(WNBAscoringefficiency[num].ToString("n2").PadLeft(7));
            }

            if (cbSHEFF.Checked)
            {
                rtbOut.AppendText(WNBAshootingefficiency[num].ToString("n2").PadLeft(7));
            }

            if (cbSTLPG.Checked)
            {
                rtbOut.AppendText(WNBAstealspergame[num].ToString("n1").PadLeft(7));
            }

            if (cbTOPG.Checked)
            {
                rtbOut.AppendText(WNBAturnoverspergame[num].ToString("n1").PadLeft(6));
            }

            if (cbASTSPG.Checked)
            {
                rtbOut.AppendText(WNBAassistspergame[num].ToString("n1").PadLeft(7));
            }

            if (cbBLKPG.Checked)
            {
                rtbOut.AppendText(WNBAblockspergame[num].ToString("n1").PadLeft(7));
            }

            if (cbASTTO.Checked)
            {
                rtbOut.AppendText(WNBAassitstoturnovers[num].ToString("n1").PadLeft(7));
            }

            if (cbREBPG.Checked)
            {
                rtbOut.AppendText(WNBAreboundspergame[num].ToString("n1").PadLeft(7));
            }

            rtbOut.AppendText("\n");
        }

        private void radWNBA_CheckedChanged(object sender, EventArgs e)
        {
            if (radWNBA.Checked)
            {
                lbWNBATeams.Visible = true;
                lbWNBApositions.Visible = true;
                gbBasicStats.Visible = true;
                gbAdvanced.Visible = true;
                gbNLorAL.Visible = true;
                radMLB.Visible = true;
                radEastNBA.Visible = true;
                radWestNBA.Visible = true;
                cbTSA.Visible = true;
                cbTS.Visible = true;
                cbTPP.Visible = true;
                cbTOPG.Visible = true;
                cbTO.Visible = true;
                cbSTLPG.Visible = true;
                cbSteals.Visible = true;
                cbSHEFF.Visible = true;
                cbSCEFF.Visible = true;
                cbREBPG.Visible = true;
                cbPoints.Visible = true;
                cbOB.Visible = true;
                cbGamesPlayed.Visible = true;
                cbFTP.Visible = true;
                cbFTM.Visible = true;
                cbFTA.Visible = true;
                cbFGP.Visible = true;
                cbFGmakes.Visible = true;
                cbFGattempts.Visible = true;
                cbDB.Visible = true;
                cbBlocks.Visible = true;
                cbBLKPG.Visible = true;
                cbASTTO.Visible = true;
                cbASTSPG.Visible = true;
                cbAssists.Visible = true;
                cb3PM.Visible = true;
                cb3PA.Visible = true;
            }
            else
            {
                lbWNBATeams.Visible = false;
                lbWNBApositions.Visible = false;
                gbBasicStats.Visible = false;
                gbAdvanced.Visible = false;
                gbNLorAL.Visible = false;
                radEastNBA.Visible = false;
                radWestNBA.Visible = false;
                cbTSA.Visible = false;
                cbTS.Visible = false;
                cbTPP.Visible = false;
                cbTOPG.Visible = false;
                cbTO.Visible = false;
                cbSTLPG.Visible = false;
                cbSteals.Visible = false;
                cbSHEFF.Visible = false;
                cbSCEFF.Visible = false;
                cbREBPG.Visible = false;
                cbPoints.Visible = false;
                cbOB.Visible = false;
                cbGamesPlayed.Visible = false;
                cbFTP.Visible = false;
                cbFTM.Visible = false;
                cbFTA.Visible = false;
                cbFGP.Visible = false;
                cbFGmakes.Visible = false;
                cbFGattempts.Visible = false;
                cbDB.Visible = false;
                cbBlocks.Visible = false;
                cbBLKPG.Visible = false;
                cbASTTO.Visible = false;
                cbASTSPG.Visible = false;
                cbAssists.Visible = false;
                cb3PM.Visible = false;
                cb3PA.Visible = false;
            }
        }
    }
}

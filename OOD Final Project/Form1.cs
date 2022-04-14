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

                int num = 0;
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


                while (textIn.Peek() != -1)
                {
                    Array.Resize<string>(ref team, team.Length + 1);
                    Array.Resize<string>(ref firstName, firstName.Length + 1);
                    Array.Resize<string>(ref lastName, lastName.Length + 1);

                    string row = textIn.ReadLine();
                    string[] record = row.Split(',');
                    team[num] = Convert.ToString(record[2]).ToUpper();
                    firstName[num] = Convert.ToString(record[3]);
                    lastName[num] = Convert.ToString(record[4]);

                    Array.Resize<double>(ref plateAppearaces, plateAppearaces.Length + 1);
                    plateAppearaces[num] = Convert.ToDouble(record[18]);

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

                    Array.Resize<double>(ref totalBases, totalBases.Length + 1);
                    var TB = new Hitters(h, d, t, hr);
                    totalBases[num] = TB.CalculateTB();

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

                    if (radMLB.Checked)
                    {
                        if (radAllDivisions.Checked && radMLB.Checked)
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

                            rtbOut.AppendText("\n");
                            num++;
                        }
                    }
                }
            }
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

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
            if (radHitters.Checked)
            {
                string path = @"Hitters.csv";
                StreamReader textIn = new StreamReader(
                new FileStream(path, FileMode.Open, FileAccess.Read));
                if (radMLB.Checked)
                {
                    if(radAllDivisions.Checked && radMLB.Checked)
                    {
                        int num = 0;
                        string[] firstName = new string[0];
                        string[] lastName = new string [0];
                        string[] team = new string[0]; 
                        double[] plateAppearaces = new double[0];
                        double[] atBats = new double[0];
                        double[] runs = new double[0];
                        double[] hits = new double[0];
                        double[] doubles = new double[0];
                        double[] triples = new double[0];
                        double[] homeRuns = new double[0];


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

                            rtbOut.AppendText(team[num].PadRight(4) + firstName[num].PadRight(12) + lastName[num].PadRight(12));
                            
                            if (cbPA.Checked)
                            {
                                Array.Resize<double>(ref plateAppearaces, plateAppearaces.Length + 1);

                                plateAppearaces[num] = Convert.ToDouble(record[18]);

                                rtbOut.AppendText(plateAppearaces[num].ToString("n0").PadLeft(4));
                            }

                            if(cbAB.Checked)
                            {
                                Array.Resize<double>(ref atBats, atBats.Length + 1);

                                atBats[num] = Convert.ToDouble(record[6]);

                                rtbOut.AppendText(atBats[num].ToString("n0").PadLeft(4));
                            }

                            if (cbR.Checked)
                            {
                                Array.Resize<double>(ref runs, runs.Length + 1);

                                runs[num] = Convert.ToDouble(record[7]);

                                rtbOut.AppendText(runs[num].ToString("n0").PadLeft(4));
                            }

                            if (cbH.Checked)
                            {
                                Array.Resize<double>(ref hits, hits.Length + 1);

                                hits[num] = Convert.ToDouble(record[8]);

                                rtbOut.AppendText(hits[num].ToString("n0").PadLeft(4));
                            }

                            if (cb2B.Checked)
                            {
                                Array.Resize<double>(ref doubles, doubles.Length + 1);

                                doubles[num] = Convert.ToDouble(record[9]);

                                rtbOut.AppendText(doubles[num].ToString("n0").PadLeft(4));
                            }

                            if (cb3B.Checked)
                            {
                                Array.Resize<double>(ref triples, triples.Length + 1);

                                triples[num] = Convert.ToDouble(record[10]);

                                rtbOut.AppendText(triples[num].ToString("n0").PadLeft(4));
                            }

                            if (cbHR.Checked)
                            {
                                Array.Resize<double>(ref homeRuns, homeRuns.Length + 1);

                                homeRuns[num] = Convert.ToDouble(record[11]);

                                rtbOut.AppendText(homeRuns[num].ToString("n0").PadLeft(4));
                            }



                            rtbOut.AppendText("\n");
                            num++;
                        }
                    }
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            rtbOut.Clear();
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

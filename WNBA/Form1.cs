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

namespace ProjectV2
{
    public partial class Form1 : Form
    {

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
        public Form1()
        {
            InitializeComponent();
        }

        private void radNBA_CheckedChanged(object sender, EventArgs e)
        {
            lbNBATeams.Visible = true;
            lbNBApositions.Visible = true;
            gbDivisionsNBA.Visible = true;
            gbLeague.Visible = true;
            gbNBAbasic.Visible = true;
            gbNBAadvanced.Visible = true;
            gbConferences.Visible = true;
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            rtbOut.Clear();
            rtbLabels.Clear();

            if (radNBA.Checked)
            {
                rtbLabels.AppendText("Team Player              ");


                string path = @"NBATeamsStats.csv";
                StreamReader textIn = new StreamReader(
                new FileStream(path, FileMode.Open, FileAccess.Read));

                labelCheck();

                while (textIn.Peek() != -1)
                {
                    Array.Resize<string>(ref NBAteam, NBAteam.Length + 1);
                    Array.Resize<string>(ref NBAname, NBAname.Length + 1);

                    string row = textIn.ReadLine();
                    string[] record = row.Split(',');
                    NBAteam[num] = Convert.ToString(record[2]).ToUpper();
                    NBAname[num] = Convert.ToString(record[3] + " " + record[4]).ToUpper();

                    Array.Resize<double>(ref NBAgamesplayed, NBAgamesplayed.Length + 1);
                    NBAgamesplayed[num] = Convert.ToDouble(record[6]);

                    Array.Resize<double>(ref NBAmintotal, NBAmintotal.Length + 1);
                    NBAmintotal[num] = Convert.ToDouble(record[7]);

                    Array.Resize<double>(ref NBAfgmakes, NBAfgmakes.Length + 1);
                    NBAfgmakes[num] = Convert.ToDouble(record[8]);

                    Array.Resize<double>(ref NBAfgattempts, NBAfgattempts.Length + 1);
                    NBAfgattempts[num] = Convert.ToDouble(record[9]);

                    Array.Resize<double>(ref NBAtpmakes, NBAtpmakes.Length + 1);
                    NBAtpmakes[num] = Convert.ToDouble(record[10]);

                    Array.Resize<double>(ref NBAtpattempts, NBAtpattempts.Length + 1);
                    NBAtpattempts[num] = Convert.ToDouble(record[11]);

                    Array.Resize<double>(ref NBAftmakes, NBAftmakes.Length + 1);
                    NBAftmakes[num] = Convert.ToDouble(record[12]);

                    Array.Resize<double>(ref NBAftattempts, NBAftattempts.Length + 1);
                    NBAftattempts[num] = Convert.ToDouble(record[13]);

                    Array.Resize<double>(ref NBAob, NBAob.Length + 1);
                    NBAob[num] = Convert.ToDouble(record[14]);

                    Array.Resize<double>(ref NBAdb, NBAdb.Length + 1);
                    NBAdb[num] = Convert.ToDouble(record[15]);

                    Array.Resize<double>(ref NBAassists, NBAassists.Length + 1);
                    NBAassists[num] = Convert.ToDouble(record[16]);

                    Array.Resize<double>(ref NBAblocks, NBAblocks.Length + 1);
                    NBAblocks[num] = Convert.ToDouble(record[17]);

                    Array.Resize<double>(ref NBAsteals, NBAsteals.Length + 1);
                    NBAsteals[num] = Convert.ToDouble(record[18]);

                    Array.Resize<double>(ref NBAto, NBAto.Length + 1);
                    NBAto[num] = Convert.ToDouble(record[19]);

                    Array.Resize<double>(ref NBAtotalpoints, NBAtotalpoints.Length + 1);
                    NBAtotalpoints[num] = Convert.ToDouble(record[20]);

                    printNBA();

                    

                    num++;
                }
            }
        }
        private void printNBA()
        {
            rtbOut.AppendText(NBAteam[num].PadRight(5) + (NBAname[num]).PadRight(20));

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


            rtbOut.AppendText("\n");
        }

        private void labelCheck()
        {
            if (radNBA.Checked)
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

                else if (radWNBA.Checked)
                { 
                
                };
            };
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDictionary_Click_1(object sender, EventArgs e)
        {
            if (radNBA.Checked)
            {
                rtbOut.AppendText("NBA Stats:\n\n" +
             "GP    - Games Played\n" +
             "MIN   - Total minutes in games\n" +
             "FGM   - Field Goal Makes\n" +
             "FGA   - Field Goal Attempts\n" +
             "3PM   - 3 Point Makes\n" +
             "3PA   - 3 Point Attempts\n" +
             "FTM   - Free Throw Misses\n" +
             "FTA   - Free Throw Attempts\n" +
             "OR    - Offensive Rebounds\n" +
             "DR    - Defensive Rebounds\n" +
             "AST   - Total Assists\n" +
             "BLK   - Total Blocks\n" +
             "STL   - Total Steals\n" +
             "TO    - Total Turnovers\n" +
             "PTS   - Total Points\n");
            }
        }
    }
}

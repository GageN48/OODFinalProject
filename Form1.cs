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
        double[] WNBAmintotal = new double[0];
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

        public Form1()
        {
            InitializeComponent();
        }

        private void radNBA_CheckedChanged(object sender, EventArgs e)
        {
            if (radNBA.Checked)
            {
                lbNBATeams.Visible = true;
                lbNBApositions.Visible = true;
                gbDivisionsNBA.Visible = true;
                gbNBAbasic.Visible = true;
                gbNBAadvanced.Visible = true;
                gbConferences.Visible = true;
                radConferences.Visible = true;
                radEastNBA.Visible = true;
                radWestNBA.Visible = true;
                radAllDivisionsNBA.Visible = true;
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
                cbMPG.Visible = true;
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
                gbDivisionsNBA.Visible = false;
                gbNBAbasic.Visible = false;
                gbNBAadvanced.Visible = false;
                gbConferences.Visible = false;
                radConferences.Visible = false;
                radEastNBA.Visible = false;
                radWestNBA.Visible = false;
                radAllDivisionsNBA.Visible = false;
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
                cbMPG.Visible = false;
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

        private void btnGo_Click(object sender, EventArgs e)
        {
            rtbOut.Clear();
            rtbLabels.Clear();

            if (radNBA.Checked)
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

                    if (radConferences.Checked && radAllDivisionsNBA.Checked)
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
                    else if (radEastNBA.Checked && radAllDivisionsNBA.Checked)
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
                    else if (radWestNBA.Checked && radAllDivisionsNBA.Checked)
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
                    else if (radConferences.Checked && radAtlantic.Checked)
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
                    else if (radConferences.Checked && radCentralNBA.Checked)
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
                    else if (radConferences.Checked && radSoutheast.Checked)
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
                    else if (radConferences.Checked && radSouthwest.Checked)
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
                    else if (radConferences.Checked && radPacific.Checked)
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
                    else if (radConferences.Checked && radNorthwest.Checked)
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
                    else if (radEastNBA.Checked && radCentralNBA.Checked)
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
                    WNBAPosition[num] = Convert.ToString(record[5]).ToUpper();
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

                    if (radConferences.Checked)
                    {
                        if (lbWNBATeams.Text == "All Teams")
                        {


                            if (lbWNBApositions.Text == "All Positions")
                            {
                                printWNBA();
                            }
                            else if (lbWNBApositions.Text == "Point Guard" && WNBAPosition[num] == "PG")
                            {
                                printWNBA();
                            }
                            else if (lbWNBApositions.Text == "Shooting Guard" && WNBAPosition[num] == "SG")
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
                            else if (lbWNBApositions.Text == "Point Guard" && WNBAPosition[num] == "PG")
                            {
                                printWNBA();
                            }
                            else if (lbWNBApositions.Text == "Shooting Guard" && WNBAPosition[num] == "SG")
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
                                else if (lbWNBApositions.Text == "Point Guard" && WNBAPosition[num] == "PG")
                                {
                                    printWNBA();
                                }
                                else if (lbWNBApositions.Text == "Shooting Guard" && WNBAPosition[num] == "SG")
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
                                else if (lbWNBApositions.Text == "Point Guard" && WNBAPosition[num] == "PG")
                                {
                                    printWNBA();
                                }
                                else if (lbWNBApositions.Text == "Shooting Guard" && WNBAPosition[num] == "SG")
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
                                else if (lbWNBApositions.Text == "Point Guard" && WNBAPosition[num] == "PG")
                                {
                                    printWNBA();
                                }
                                else if (lbWNBApositions.Text == "Shooting Guard" && WNBAPosition[num] == "SG")
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
                                else if (lbWNBApositions.Text == "Point Guard" && WNBAPosition[num] == "PG")
                                {
                                    printWNBA();
                                }
                                else if (lbWNBApositions.Text == "Shooting Guard" && WNBAPosition[num] == "SG")
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
                        if (lbWNBATeams.Text == "LasVegas Aces" && WNBAteam[num] == "ACES")
                        {

                            {
                                if (lbWNBApositions.Text == "All Positions")
                                {
                                    printWNBA();
                                }
                                else if (lbWNBApositions.Text == "Point Guard" && WNBAPosition[num] == "PG")
                                {
                                    printWNBA();
                                }
                                else if (lbWNBApositions.Text == "Shooting Guard" && WNBAPosition[num] == "SG")
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
                        if (lbWNBATeams.Text == "LosAngeles Sparks" && WNBAteam[num] == "SPARKS")
                        {

                            {
                                if (lbWNBApositions.Text == "All Positions")
                                {
                                    printWNBA();
                                }
                                else if (lbWNBApositions.Text == "Point Guard" && WNBAPosition[num] == "PG")
                                {
                                    printWNBA();
                                }
                                else if (lbWNBApositions.Text == "Shooting Guard" && WNBAPosition[num] == "SG")
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
                                else if (lbWNBApositions.Text == "Point Guard" && WNBAPosition[num] == "PG")
                                {
                                    printWNBA();
                                }
                                else if (lbWNBApositions.Text == "Shooting Guard" && WNBAPosition[num] == "SG")
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
                                else if (lbWNBApositions.Text == "Point Guard" && WNBAPosition[num] == "PG")
                                {
                                    printWNBA();
                                }
                                else if (lbWNBApositions.Text == "Shooting Guard" && WNBAPosition[num] == "SG")
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
                                else if (lbWNBApositions.Text == "Point Guard" && WNBAPosition[num] == "PG")
                                {
                                    printWNBA();
                                }
                                else if (lbWNBApositions.Text == "Shooting Guard" && WNBAPosition[num] == "SG")
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
                                else if (lbWNBApositions.Text == "Point Guard" && WNBAPosition[num] == "PG")
                                {
                                    printWNBA();
                                }
                                else if (lbWNBApositions.Text == "Shooting Guard" && WNBAPosition[num] == "SG")
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
                        if (lbWNBATeams.Text == "NewYork Liberty" && WNBAteam[num] == "LIBERTY")
                        {

                            {
                                if (lbWNBApositions.Text == "All Positions")
                                {
                                    printWNBA();
                                }
                                else if (lbWNBApositions.Text == "Point Guard" && WNBAPosition[num] == "PG")
                                {
                                    printWNBA();
                                }
                                else if (lbWNBApositions.Text == "Shooting Guard" && WNBAPosition[num] == "SG")
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
                    else if (radEastNBA.Checked )
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
                                    else if (lbWNBApositions.Text == "Point Guard" && WNBAPosition[num] == "PG")
                                    {
                                        printWNBA();
                                    }
                                    else if (lbWNBApositions.Text == "Shooting Guard" && WNBAPosition[num] == "SG")
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
                                    else if (lbWNBApositions.Text == "Point Guard" && WNBAPosition[num] == "PG")
                                    {
                                        printWNBA();
                                    }
                                    else if (lbWNBApositions.Text == "Shooting Guard" && WNBAPosition[num] == "SG")
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
                                    else if (lbWNBApositions.Text == "Point Guard" && WNBAPosition[num] == "PG")
                                    {
                                        printWNBA();
                                    }
                                    else if (lbWNBApositions.Text == "Shooting Guard" && WNBAPosition[num] == "SG")
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
                                    else if (lbWNBApositions.Text == "Point Guard" && WNBAPosition[num] == "PG")
                                    {
                                        printWNBA();
                                    }
                                    else if (lbWNBApositions.Text == "Shooting Guard" && WNBAPosition[num] == "SG")
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
                                    else if (lbWNBApositions.Text == "Point Guard" && WNBAPosition[num] == "PG")
                                    {
                                        printWNBA();
                                    }
                                    else if (lbWNBApositions.Text == "Shooting Guard" && WNBAPosition[num] == "SG")
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
                            if (lbWNBATeams.Text == "NewYork Liberty" && WNBAteam[num] == "LIBERTY")
                            {

                                {
                                    if (lbWNBApositions.Text == "All Positions")
                                    {
                                        printWNBA();
                                    }
                                    else if (lbWNBApositions.Text == "Point Guard" && WNBAPosition[num] == "PG")
                                    {
                                        printWNBA();
                                    }
                                    else if (lbWNBApositions.Text == "Shooting Guard" && WNBAPosition[num] == "SG")
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
                                    else if (lbWNBApositions.Text == "Point Guard" && WNBAPosition[num] == "PG")
                                    {
                                        printWNBA();
                                    }
                                    else if (lbWNBApositions.Text == "Shooting Guard" && WNBAPosition[num] == "SG")
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
                                    else if (lbWNBApositions.Text == "Point Guard" && WNBAPosition[num] == "PG")
                                    {
                                        printWNBA();
                                    }
                                    else if (lbWNBApositions.Text == "Shooting Guard" && WNBAPosition[num] == "SG")
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
                                    else if (lbWNBApositions.Text == "Point Guard" && WNBAPosition[num] == "PG")
                                    {
                                        printWNBA();
                                    }
                                    else if (lbWNBApositions.Text == "Shooting Guard" && WNBAPosition[num] == "SG")
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
                            if (lbWNBATeams.Text == "LasVegas Aces" && WNBAteam[num] == "ACES")
                            {

                                {
                                    if (lbWNBApositions.Text == "All Positions")
                                    {
                                        printWNBA();
                                    }
                                    else if (lbWNBApositions.Text == "Point Guard" && WNBAPosition[num] == "PG")
                                    {
                                        printWNBA();
                                    }
                                    else if (lbWNBApositions.Text == "Shooting Guard" && WNBAPosition[num] == "SG")
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
                            if (lbWNBATeams.Text == "LosAngeles Sparks" && WNBAteam[num] == "SPARKS")
                            {

                                {
                                    if (lbWNBApositions.Text == "All Positions")
                                    {
                                        printWNBA();
                                    }
                                    else if (lbWNBApositions.Text == "Point Guard" && WNBAPosition[num] == "PG")
                                    {
                                        printWNBA();
                                    }
                                    else if (lbWNBApositions.Text == "Shooting Guard" && WNBAPosition[num] == "SG")
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
                                    else if (lbWNBApositions.Text == "Point Guard" && WNBAPosition[num] == "PG")
                                    {
                                        printWNBA();
                                    }
                                    else if (lbWNBApositions.Text == "Shooting Guard" && WNBAPosition[num] == "SG")
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
                                    else if (lbWNBApositions.Text == "Point Guard" && WNBAPosition[num] == "PG")
                                    {
                                        printWNBA();
                                    }
                                    else if (lbWNBApositions.Text == "Shooting Guard" && WNBAPosition[num] == "SG")
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
                                    else if (lbWNBApositions.Text == "Point Guard" && WNBAPosition[num] == "PG")
                                    {
                                        printWNBA();
                                    }
                                    else if (lbWNBApositions.Text == "Shooting Guard" && WNBAPosition[num] == "SG")
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

            if(cbSHEFF.Checked)
            {
                rtbOut.AppendText(NBAshootingefficiency[num].ToString("n2").PadLeft(7));
            }

            if (cbSTLPG.Checked)
            {
                rtbOut.AppendText(NBAstealspergame[num].ToString("n1").PadLeft(6));
            }

            if (cbTOPG.Checked)
            {
                rtbOut.AppendText(NBAturnoverspergame[num].ToString("n1").PadLeft(7));
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

        private void labelCheck()
        {
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDictionary_Click_1(object sender, EventArgs e)
        {
            if (radNBA.Checked || radWNBA.Checked)
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
             "REB/PG - Rebounds Per Game\n"
             );
            }
        }

        private void radWNBA_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radWNBA.Checked)
            {
                lbWNBATeams.Visible = true;
                lbWNBApositions.Visible = true;
                gbLeague.Visible = true;
                gbNBAbasic.Visible = true;
                gbNBAadvanced.Visible = true;
                gbConferences.Visible = true;
                radConferences.Visible = true;
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
                gbDivisionsNBA.Visible = false;
                gbNBAbasic.Visible = false;
                gbNBAadvanced.Visible = false;
                gbConferences.Visible = false;
                radConferences.Visible = false;
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
                cbMPG.Visible = false;
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
    }
}

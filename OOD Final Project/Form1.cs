using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            if(radHitters.Checked)
            {

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
            gbLeagueDivisions.Visible = true;
            gbHittersBasic.Visible = true;
            gbAdvanced.Visible = true;
            lbMLBTeams.Visible = true;
            lbHitterPosition.Visible = true;
        }

        private void radPitchers_CheckedChanged(object sender, EventArgs e)
        {
            gbLeagueDivisions.Visible = true;
            lbMLBTeams.Visible = true;
        }

        private void btnDictionary_Click(object sender, EventArgs e)
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
                "WAR   - Measures a player's value in all facets of the game\n" +
                "TB    - Total Bases\n" +
                "HBP   - Hit by Pitch\n" +
                "IBB   - Intentional Base on Balls\n");
        }
    }
}

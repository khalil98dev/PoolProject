using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoolProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ctrlPoolTable1_OnTimerStop(object sender, ctrlPoolTable.TimerArgs e)
        {
            MessageBox.Show(string.Concat($"Player: {e.PlayerName} Timer Done.\nDetails:",
                                         "\n------------------------------------\n",
                                          $"\nFees per hour: {e.FeesPerHour} ",
                                          $"\nTotal hours: {e.Hours}",
                                          $"\nTotal Minutes: {e.Minutes}",
                                          $"\nTotal Seconds: {e.Seconds}",
                                          "\n------------------------------------\n",
                                          $"Total fees: {e.TotalFees} DZ",
                                          "\n------------------------------------\n",
                                          $"\nWelcome Back agin MR.{e.PlayerName}"




                                    ), "Timer Done", MessageBoxButtons.OK, MessageBoxIcon.Information) ;
        }

        private void ctrlPoolTable1_Load(object sender, EventArgs e)
        {
          
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ctrlPoolTable1_OnTimerStop_1(object sender, ctrlPoolTable.TimerArgs e)
        {
            MessageBox.Show(string.Concat($"Player: {e.PlayerName} Timer Done.\nDetails:",
                                         "\n------------------------------------\n",
                                          $"\nFees per hour: {e.FeesPerHour} ",
                                          $"\nTotal hours: {e.Hours}",
                                          $"\nTotal Minutes: {e.Minutes}",
                                          $"\nTotal Seconds: {e.Seconds}",
                                          "\n------------------------------------\n",
                                          $"Total fees: {e.TotalFees} DZ",
                                          "\n------------------------------------\n",
                                          $"\nWelcome Back agin MR.{e.PlayerName}"




                                    ), "Timer Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

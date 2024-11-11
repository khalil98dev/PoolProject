namespace PoolProject
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ctrlPoolTable1 = new PoolProject.ctrlPoolTable();
            this.ctrlPoolTable2 = new PoolProject.ctrlPoolTable();
            this.ctrlPoolTable3 = new PoolProject.ctrlPoolTable();
            this.ctrlPoolTable4 = new PoolProject.ctrlPoolTable();
            this.ctrlPoolTable5 = new PoolProject.ctrlPoolTable();
            this.ctrlPoolTable6 = new PoolProject.ctrlPoolTable();
            this.ctrlPoolTable7 = new PoolProject.ctrlPoolTable();
            this.ctrlPoolTable8 = new PoolProject.ctrlPoolTable();
            this.ctrlPoolTable9 = new PoolProject.ctrlPoolTable();
            this.ctrlPoolTable10 = new PoolProject.ctrlPoolTable();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.ctrlPoolTable1);
            this.flowLayoutPanel1.Controls.Add(this.ctrlPoolTable2);
            this.flowLayoutPanel1.Controls.Add(this.ctrlPoolTable3);
            this.flowLayoutPanel1.Controls.Add(this.ctrlPoolTable4);
            this.flowLayoutPanel1.Controls.Add(this.ctrlPoolTable5);
            this.flowLayoutPanel1.Controls.Add(this.ctrlPoolTable6);
            this.flowLayoutPanel1.Controls.Add(this.ctrlPoolTable7);
            this.flowLayoutPanel1.Controls.Add(this.ctrlPoolTable8);
            this.flowLayoutPanel1.Controls.Add(this.ctrlPoolTable9);
            this.flowLayoutPanel1.Controls.Add(this.ctrlPoolTable10);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(986, 908);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // ctrlPoolTable1
            // 
            this.ctrlPoolTable1.BackColor = System.Drawing.Color.Black;
            this.ctrlPoolTable1.FeesPerHour = 10F;
            this.ctrlPoolTable1.Location = new System.Drawing.Point(3, 3);
            this.ctrlPoolTable1.Name = "ctrlPoolTable1";
            this.ctrlPoolTable1.PlayerName = "Player";
            this.ctrlPoolTable1.Size = new System.Drawing.Size(317, 274);
            this.ctrlPoolTable1.TabIndex = 0;
            this.ctrlPoolTable1.TableNumber = "01";
            this.ctrlPoolTable1.OnTimerStop += new System.EventHandler<PoolProject.ctrlPoolTable.TimerArgs>(this.ctrlPoolTable1_OnTimerStop_1);
            // 
            // ctrlPoolTable2
            // 
            this.ctrlPoolTable2.BackColor = System.Drawing.Color.Black;
            this.ctrlPoolTable2.FeesPerHour = 10F;
            this.ctrlPoolTable2.Location = new System.Drawing.Point(326, 3);
            this.ctrlPoolTable2.Name = "ctrlPoolTable2";
            this.ctrlPoolTable2.PlayerName = "Player";
            this.ctrlPoolTable2.Size = new System.Drawing.Size(317, 274);
            this.ctrlPoolTable2.TabIndex = 1;
            this.ctrlPoolTable2.TableNumber = "02";
            this.ctrlPoolTable2.OnTimerStop += new System.EventHandler<PoolProject.ctrlPoolTable.TimerArgs>(this.ctrlPoolTable1_OnTimerStop_1);
            // 
            // ctrlPoolTable3
            // 
            this.ctrlPoolTable3.BackColor = System.Drawing.Color.Black;
            this.ctrlPoolTable3.FeesPerHour = 10F;
            this.ctrlPoolTable3.Location = new System.Drawing.Point(649, 3);
            this.ctrlPoolTable3.Name = "ctrlPoolTable3";
            this.ctrlPoolTable3.PlayerName = "Player";
            this.ctrlPoolTable3.Size = new System.Drawing.Size(317, 274);
            this.ctrlPoolTable3.TabIndex = 2;
            this.ctrlPoolTable3.TableNumber = "03";
            this.ctrlPoolTable3.OnTimerStop += new System.EventHandler<PoolProject.ctrlPoolTable.TimerArgs>(this.ctrlPoolTable1_OnTimerStop_1);
            // 
            // ctrlPoolTable4
            // 
            this.ctrlPoolTable4.BackColor = System.Drawing.Color.Black;
            this.ctrlPoolTable4.FeesPerHour = 10F;
            this.ctrlPoolTable4.Location = new System.Drawing.Point(3, 283);
            this.ctrlPoolTable4.Name = "ctrlPoolTable4";
            this.ctrlPoolTable4.PlayerName = "Player";
            this.ctrlPoolTable4.Size = new System.Drawing.Size(317, 272);
            this.ctrlPoolTable4.TabIndex = 3;
            this.ctrlPoolTable4.TableNumber = "04";
            this.ctrlPoolTable4.OnTimerStop += new System.EventHandler<PoolProject.ctrlPoolTable.TimerArgs>(this.ctrlPoolTable1_OnTimerStop_1);
            // 
            // ctrlPoolTable5
            // 
            this.ctrlPoolTable5.BackColor = System.Drawing.Color.Black;
            this.ctrlPoolTable5.FeesPerHour = 10F;
            this.ctrlPoolTable5.Location = new System.Drawing.Point(326, 283);
            this.ctrlPoolTable5.Name = "ctrlPoolTable5";
            this.ctrlPoolTable5.PlayerName = "Player";
            this.ctrlPoolTable5.Size = new System.Drawing.Size(317, 272);
            this.ctrlPoolTable5.TabIndex = 4;
            this.ctrlPoolTable5.TableNumber = "05";
            this.ctrlPoolTable5.OnTimerStop += new System.EventHandler<PoolProject.ctrlPoolTable.TimerArgs>(this.ctrlPoolTable1_OnTimerStop_1);
            // 
            // ctrlPoolTable6
            // 
            this.ctrlPoolTable6.BackColor = System.Drawing.Color.Black;
            this.ctrlPoolTable6.FeesPerHour = 10F;
            this.ctrlPoolTable6.Location = new System.Drawing.Point(649, 283);
            this.ctrlPoolTable6.Name = "ctrlPoolTable6";
            this.ctrlPoolTable6.PlayerName = "Player";
            this.ctrlPoolTable6.Size = new System.Drawing.Size(317, 272);
            this.ctrlPoolTable6.TabIndex = 5;
            this.ctrlPoolTable6.TableNumber = "06";
            this.ctrlPoolTable6.OnTimerStop += new System.EventHandler<PoolProject.ctrlPoolTable.TimerArgs>(this.ctrlPoolTable1_OnTimerStop_1);
            // 
            // ctrlPoolTable7
            // 
            this.ctrlPoolTable7.BackColor = System.Drawing.Color.Black;
            this.ctrlPoolTable7.FeesPerHour = 10F;
            this.ctrlPoolTable7.Location = new System.Drawing.Point(3, 561);
            this.ctrlPoolTable7.Name = "ctrlPoolTable7";
            this.ctrlPoolTable7.PlayerName = "Player";
            this.ctrlPoolTable7.Size = new System.Drawing.Size(317, 274);
            this.ctrlPoolTable7.TabIndex = 6;
            this.ctrlPoolTable7.TableNumber = "07";
            // 
            // ctrlPoolTable8
            // 
            this.ctrlPoolTable8.BackColor = System.Drawing.Color.Black;
            this.ctrlPoolTable8.FeesPerHour = 10F;
            this.ctrlPoolTable8.Location = new System.Drawing.Point(326, 561);
            this.ctrlPoolTable8.Name = "ctrlPoolTable8";
            this.ctrlPoolTable8.PlayerName = "Player";
            this.ctrlPoolTable8.Size = new System.Drawing.Size(317, 274);
            this.ctrlPoolTable8.TabIndex = 7;
            this.ctrlPoolTable8.TableNumber = "08";
            // 
            // ctrlPoolTable9
            // 
            this.ctrlPoolTable9.BackColor = System.Drawing.Color.Black;
            this.ctrlPoolTable9.FeesPerHour = 10F;
            this.ctrlPoolTable9.Location = new System.Drawing.Point(649, 561);
            this.ctrlPoolTable9.Name = "ctrlPoolTable9";
            this.ctrlPoolTable9.PlayerName = "Player";
            this.ctrlPoolTable9.Size = new System.Drawing.Size(317, 274);
            this.ctrlPoolTable9.TabIndex = 8;
            this.ctrlPoolTable9.TableNumber = "09";
            // 
            // ctrlPoolTable10
            // 
            this.ctrlPoolTable10.BackColor = System.Drawing.Color.Black;
            this.ctrlPoolTable10.FeesPerHour = 10F;
            this.ctrlPoolTable10.Location = new System.Drawing.Point(3, 841);
            this.ctrlPoolTable10.Name = "ctrlPoolTable10";
            this.ctrlPoolTable10.PlayerName = "Player";
            this.ctrlPoolTable10.Size = new System.Drawing.Size(317, 274);
            this.ctrlPoolTable10.TabIndex = 9;
            this.ctrlPoolTable10.TableNumber = "10";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(986, 908);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private ctrlPoolTable ctrlPoolTable1;
        private ctrlPoolTable ctrlPoolTable2;
        private ctrlPoolTable ctrlPoolTable3;
        private ctrlPoolTable ctrlPoolTable4;
        private ctrlPoolTable ctrlPoolTable5;
        private ctrlPoolTable ctrlPoolTable6;
        private ctrlPoolTable ctrlPoolTable7;
        private ctrlPoolTable ctrlPoolTable8;
        private ctrlPoolTable ctrlPoolTable9;
        private ctrlPoolTable ctrlPoolTable10;
    }
}


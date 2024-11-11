using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoolProject
{
    public partial class ctrlPoolTable : UserControl
    {
        public class TimerArgs : EventArgs
        { 
            public float FeesPerHour { get; set; }

            public int Hours {  get; set; }
            public int Seconds { get; set; }
            public int Minutes { get; set; }

            private float _TotlaFees { get;

                set;


            }


            public float TotalFees { get { return _TotlaFees; } 
                private set { _TotlaFees = value; } }
            public string PlayerName { get; set; }  


            private int _ElipsedTime
            {
                get; set;
            }

            
            private float _GetTotalFees()
            {
                //Get the price for 1 ms; 
                float MsPrice = FeesPerHour / (3600 * 1000); 

                return Convert.ToSingle( MsPrice * ElipsedTieme());
            }
            /// <summary>
            /// Return the value of the occured time on Milliseconds
            /// </summary>
           


            public TimerArgs(float feesPerHour, int hours, int seconds, int minutes,string PlayerName)
            {
                FeesPerHour = feesPerHour;
                Hours = hours;
                Seconds = seconds;
                Minutes = minutes;
                TotalFees = _GetTotalFees();
                this.PlayerName = PlayerName;
            }

            private int ElipsedTieme()
            {
                return ((Hours) * 3600 + Minutes * 60 + Seconds) * 1000;  
            }
        
        }
       
        public event EventHandler<TimerArgs> OnTimerStop;
       
        void RaiseOnTimerStopEvent()
        {
            if(OnTimerStop != null)
            {
                EventHandler<TimerArgs> handler = OnTimerStop;
                if(handler != null)
                {
                    handler(this,new TimerArgs(this.FeesPerHour,this._Hour,
                                                this._Second,this._Minute,PlayerName)); 
                }
            }
        }
        public ctrlPoolTable()
        {
            InitializeComponent();
        }


        private string _PlayerName = "Player 01"; 
        
       

        [Category("Pool Config"),Description("Paler Name")]
        public string PlayerName { get
            {
                return _PlayerName;
            }
            set { _PlayerName = value;
                lblPlayerName.Text = value;
                 }
                  
           }

        private string _TableNumber = "01";

        [Category("Pool Config"), Description("Table Number")]
        public string TableNumber { get { return _TableNumber; }
            set { 
                    _TableNumber = value;   
                    lblTableNum.Text = value;
                    grpTable.Text = "Table " + value;
                    
            } }

        private float _FeesPerHour = 100;
        
        [Category("Pool Config"), Description("Fees Per Hour")]
        public float FeesPerHour { get {  return _FeesPerHour; }
            set {  _FeesPerHour = value;} }



        //Set Player Name and Fees Pers Hour

        private void _SetConfig(object sender,frmConfig.ConfigArgs e)
        {
            this.PlayerName =  e.PlayerName;
            this.FeesPerHour= e.FeesPerHour;

            MessageBox.Show($"Settings Updates to {_TableNumber} Table, \nEnjoy^^"); 

        }

        //Paramaters 
        private int _Second =0;
        private int _Minute = 0;
        private int _Hour =0;



        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void ctrlPoolTable_Load(object sender, EventArgs e)
        {
            FeesPerHour = 10;
            PlayerName = "Player"; 
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
                    }


        void ResetTimer()
        {
            _Second = 0;
            _Minute = 0;
            _Hour = 0;
            lblTime.Text = TimerFormate(0,0,0);
            TableTimer.Stop();
            Pasue = false;
            btnStart.Text = "Start";
        }
        private void btbTable_Enter(object sender, EventArgs e)
        {

        }
        private frmConfig _Config = new frmConfig();
        void SubscribeToOnChangeEvent()
        {
            _Config.OnConfigChanged += _SetConfig; 
        }

        void UnSubscribeToOnChangeEvent()
        {
            _Config.OnConfigChanged -= _SetConfig;
        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            SubscribeToOnChangeEvent();
            _Config.ShowDialog();
            _Config.DoDragDrop(this, DragDropEffects.Copy);
        }
        void _Start()
        {
            TableTimer.Start();
        }

        void _Stop()
        {
            TableTimer.Stop();
            RaiseOnTimerStopEvent();
        }

        bool Pasue = false; 
        private void button1_Click_1(object sender, EventArgs e)
        {
            if(!Pasue)
            {
                btnStart.Text = "Pause";
                Pasue = true;
                TableTimer.Start();
            }
            else
            {
                btnStart.Text = "Start";
                Pasue = false;
                TableTimer.Stop();
            }
            

        }

        string TimerFormate(int Seconds,int Minutes,int Hours)
        {
            string Second = ""; 
            string Minute = ""; 
            string Hour = ""; 
          if(Seconds < 10) 
            {
                Second = "0" + Seconds.ToString(); 
            }else 
                Second = Seconds.ToString();

          if(Minutes < 10)
            {
                if(Minutes==0)
                {
                    Minute = "00";
                }else
                    Minute = "0"+Minutes.ToString();
            }

          if(Hours < 10)
            {
                if (Hours != 0)
                {
                    Hour = "0" + Hours.ToString();
                }
                else
                    Hour = "00";
            }

            return string.Concat(Hour, ":", Minute,":", Second) ;
        }
        private void TableTimer_Tick(object sender, EventArgs e)
        {
            if (_Second == 60)
            {
                _Second = 0;
                if (_Minute == 60)
                {
                    _Minute = 0;
                    _Hour++;
                }
                else
                    _Minute++;

           }
            else
                _Second++;

            lblTime.Text =  TimerFormate(_Second,_Minute,_Hour);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            _Stop();
            ResetTimer();
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ResetTimer();
            _Stop();
        }

        private void btnResetTimer_Click(object sender, EventArgs e)
        {
            ResetTimer();
        }
    }
}

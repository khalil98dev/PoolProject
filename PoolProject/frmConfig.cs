using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PoolProject
{
    public partial class frmConfig : Form
    {
        public class ConfigArgs : EventArgs
        {
            public string PlayerName { get; set; }
            public float FeesPerHour { get; set; }

            public ConfigArgs(string PlayerName, float FeesPerHour)
            {
                this.PlayerName = PlayerName;
                this.FeesPerHour = FeesPerHour;
            }
        }
        public frmConfig()
        {
            InitializeComponent();
        }
       

        private bool _IsValidPrice(string Price)
        {
            var Patter = @"\b\d+\b";
            var regex = new Regex(Patter);

            return regex.IsMatch(Price); 
        }

        public event EventHandler<ConfigArgs> OnConfigChanged;

        private string _PlayerName {  get; set; }
        private float _FeesPerHour { get; set; }    
        public void RaiseOnConfigChanged()
        {
            if(OnConfigChanged != null)
            {
                EventHandler<ConfigArgs> Handler = OnConfigChanged; 
                if(Handler != null)
                {
                    OnConfigChanged?.Invoke(this, new ConfigArgs(_PlayerName, _FeesPerHour));
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmConfig_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                lblError.Visible = true;
                return;
            }

            try
            {
                this._FeesPerHour = Convert.ToSingle(txbFeesPerHour.Text);
            }catch(Exception ex)
            {
                MessageBox.Show($"Error When Tring to convert FeesPersHour To Floot{ex.Message}","Error",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                return;
            }
            
            this._PlayerName = txbPlayerName.Text;
            RaiseOnConfigChanged();
        }

        private void frmConfig_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            
        }

        private void txbFeesPerHour_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
          
            if (((TextBox)sender).Text== string.Empty)
            {

                errPr.SetError(((TextBox)sender), "This Field is requaried.");
                e.Cancel = true;
            }
            else
            {
                errPr.SetError(((TextBox)sender), null);
            }

            if(((TextBox)sender) == txbFeesPerHour)
            {
                if(!_IsValidPrice(txbFeesPerHour.Text))
                {
                    errPr.SetError(((TextBox)sender),"Please re-Write the correct price format");
                    e.Cancel = true;
                }else
                { errPr.SetError(((TextBox)sender),null); }
            }


        }
    }
}

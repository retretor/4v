using System;
using System.ComponentModel;
using System.Timers;
using System.Windows.Forms;

namespace OST_Labs
{
    public partial class Form1 : Form
    {
        private readonly ViewDetailed _viewDetailed;
        private bool _isCanWork;

        
        public Form1()
        {
            InitializeComponent();
            var model = new Model();
            _isCanWork = false;
            _viewDetailed = new ViewDetailed(model, new Controller(), this);
            _viewDetailed.DataBind();
            Prepare();
        }
        private void Prepare()
        {
            UpdateSettings();
            SaveSettingsButton.Enabled = true;
            EndSeanseButton.Enabled = false;
            WorkCycleButton.Enabled = false;
            SettingsPanel.Enabled = true;
        }

        private void SaveSettingsButton_Click(object sender, EventArgs e)
        {
            SessionPreparation();
            _viewDetailed.ReactToUserActions(ModelOperations.SaveSettings);
        }
        private void WorkCycleButton_Click(object sender, EventArgs e)
        {
            _viewDetailed.ReactToUserActions(ModelOperations.WorkingCycle);
        }

        private void EndSeanseButton_Click(object sender, EventArgs e)
        {
            _viewDetailed.ReactToUserActions(ModelOperations.EndOfSession);
            EndOfSession();
            UpdateSettings();
        }
        private void SessionPreparation()
        {
            SaveSettingsButton.Enabled = false;
            EndSeanseButton.Enabled = true;
            WorkCycleButton.Enabled = radioButton1.Checked;
            SettingsPanel.Enabled = false;
            
            _isCanWork = true;
        }

        private void EndOfSession()
        {
            EndSeanseButton.Enabled = false;
            SaveSettingsButton.Enabled = true;
            WorkCycleButton.Enabled = false;
            SettingsPanel.Enabled = true;
            
            _isCanWork = false;
        }

        private void UpdateSettings()
        {
            ProcessIntensivityNumeric.Value = 0.5m;
            MinWorkTimeNumeric.Value = MinWorkTimeNumeric.Minimum;
            MaxWorkTimeNumeric.Value = MaxWorkTimeNumeric.Minimum;
            MinAddrSpaceNumeric.Value = MinAddrSpaceNumeric.Minimum;
            MaxAddrSpaceNumeric.Value = MaxAddrSpaceNumeric.Minimum;
            RamSize.SelectedItem = RamSize.Items[0];
        }

        private void timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            if(radioButton2.Checked && _isCanWork)
                _viewDetailed.ReactToUserActions(ModelOperations.WorkingCycle);
        }
        
    }
}

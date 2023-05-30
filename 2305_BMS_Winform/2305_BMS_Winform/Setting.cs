using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace _2305_BMS_Winform
{
    
    public partial class Setting : Form
    {
        private SettingValues settingValues;
        public class SettingValues
        {
            public double OverVoltageDef { get; set; }
            public double UnderVoltageDef { get; set; }
            public double ChargeParam { get; set; }
            public double DischargeParam { get; set; }
            public int ChargeDelay { get; set; }
            public int DischargeDelay { get; set; }
            public int CellBalanceExcution { get; set; }
            public int CellBalanceDelay { get; set; }
            public int RefreshDelay { get; set; }
            public double VoltagePreset { get; set; }
        }
        public Setting(SettingValues settingValues)
        {
            InitializeComponent();

            this.settingValues = settingValues;

            overVoltageDefTextBox.Text = settingValues.OverVoltageDef.ToString();
            underVoltageDefTextBox.Text = settingValues.UnderVoltageDef.ToString();
            chargeParamTextBox.Text = settingValues.ChargeParam.ToString();
            dischargeParamTextBox.Text = settingValues.DischargeParam.ToString();
            chargeDelayTextBox.Text = settingValues.ChargeDelay.ToString();
            dischargeDelayTextBox.Text = settingValues.DischargeDelay.ToString();
            cellBalanceExcutionTextBox.Text = settingValues.CellBalanceExcution.ToString();
            cellBalanceDelayTextBox.Text = settingValues.CellBalanceDelay.ToString();
            refreshDelayTextBox.Text = settingValues.RefreshDelay.ToString();
            voltagePresetTextBox.Text = settingValues.VoltagePreset.ToString();

        }

        private void button_SettingApply_Click(object sender, EventArgs e)
        {
            settingValues.OverVoltageDef = double.Parse(overVoltageDefTextBox.Text);
            settingValues.UnderVoltageDef = double.Parse(underVoltageDefTextBox.Text);
            settingValues.ChargeParam = double.Parse(chargeParamTextBox.Text);
            settingValues.DischargeParam = double.Parse(dischargeParamTextBox.Text);
            settingValues.ChargeDelay = int.Parse(chargeDelayTextBox.Text);
            settingValues.DischargeDelay = int.Parse(dischargeDelayTextBox.Text);
            settingValues.CellBalanceExcution = int.Parse(cellBalanceExcutionTextBox.Text);
            settingValues.CellBalanceDelay = int.Parse(cellBalanceDelayTextBox.Text);
            settingValues.RefreshDelay = int.Parse(refreshDelayTextBox.Text);
            settingValues.VoltagePreset = double.Parse(voltagePresetTextBox.Text);

            DialogResult = DialogResult.OK;
            
        }

        private void button_SettingCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        public SettingValues GetSettingValues()
        {
            return settingValues;
        }
    }
}

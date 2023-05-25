using System;
using System.IO;
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
    public class settingParam
    {
        double OverVoltageDef = 0.0;
        double UnderVoltageDef = 0.0;

        double ChargeParam = 0.0;
        double DischargeParam = 0.0;

        int ChargeDelay = 0;
        int DischargeDelay = 0;

        int CellBalanceExcution = 0;
        int CellBalanceDelay = 0;

        int RefreshDelay = 0;
        double VoltagePreset = 0;


    };

    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            this.textBox_Status.Text = "STOP";
            string filePath = "Setting.config";

            if (File.Exists(filePath))
            {
                UpdateFileData(filePath);
            }
            else
            {
                CreateNewFile(filePath);
            }
        }

        static void UpdateFileData(string filePath)
        {

        }

        static void CreateNewFile(string filePath)
        {

        }

        private void buttonCharge_Click(object sender, EventArgs e)
        {
            this.textBox_Status.Text = "CHARGE";
        }

        private void button_discharge_Click(object sender, EventArgs e)
        {
            this.textBox_Status.Text = "DISCHARGE";
        }

        private void button_stop_Click(object sender, EventArgs e)
        {
            this.textBox_Status.Text = "STOP";
        }

        private void button_setting_Click(object sender, EventArgs e)
        {
            Setting DiagSetting = new Setting();
            DiagSetting.Show();
        }

        private void button_up_cellV1_Click(object sender, EventArgs e)
        {

        }

        private void button_up_cellV2_Click(object sender, EventArgs e)
        {

        }

        private void button_up_cellV3_Click(object sender, EventArgs e)
        {

        }

        private void button_up_cellV4_Click(object sender, EventArgs e)
        {

        }

        private void button_up_cellV5_Click(object sender, EventArgs e)
        {

        }

        private void button_up_cellV6_Click(object sender, EventArgs e)
        {

        }

        private void button_up_cellV7_Click(object sender, EventArgs e)
        {

        }

        private void button_up_cellV8_Click(object sender, EventArgs e)
        {

        }

        private void button_down_cellV1_Click(object sender, EventArgs e)
        {

        }

        private void button_down_cellV2_Click(object sender, EventArgs e)
        {

        }

        private void button_down_cellV3_Click(object sender, EventArgs e)
        {

        }

        private void button_down_cellV4_Click(object sender, EventArgs e)
        {

        }

        private void button_down_cellV5_Click(object sender, EventArgs e)
        {

        }

        private void button_down_cellV6_Click(object sender, EventArgs e)
        {

        }

        private void button_down_cellV7_Click(object sender, EventArgs e)
        {

        }

        private void button_down_cellV8_Click(object sender, EventArgs e)
        {

        }
    }
}

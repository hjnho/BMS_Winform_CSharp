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
    public partial class Main : Form
    {
        private Timer timer;
        private int timerCount = 0;
        
        public Main()
        {
            InitializeComponent();

            timer = new Timer();
            timer.Interval = Constants.TIMER_INTERVAL_CELL_VOLTAGE;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();

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

        void timer_Tick(object sender, EventArgs e)
        {
            textBox_CellV1.Text = "3.7";
            textBox_CellV2.Text = "3.7";
            textBox_CellV3.Text = "3.7";
            textBox_CellV4.Text = "3.7";
            textBox_CellV5.Text = "3.7";
            textBox_CellV6.Text = "3.7";
            textBox_CellV7.Text = "3.7";
            textBox_CellV8.Text = "3.7";
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
        static class Constants
    {
        public const int TIMER_INTERVAL_CELL_VOLTAGE = 1000; // 1Sec
    }
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
}



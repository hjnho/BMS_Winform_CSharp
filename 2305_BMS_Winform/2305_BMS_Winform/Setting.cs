﻿using System;
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
        public Setting()
        {
            InitializeComponent();
        }

        private void button_SettingApply_Click(object sender, EventArgs e)
        {
            
        }

        private void button_SettingCancel_Click(object sender, EventArgs e)
        {

        }

        public delegate void DataPassEventHandler_INT(int data[5]);

        public event DataPassEventHandler_INT DataPassEventInt;

        public delegate void DataPassEventHandler_DOUBLE(double data[5]);

        public event DataPassEventHandler_DOUBLE DataPassEventDouble;
    }
}

﻿using System;
using System.Windows.Forms;

namespace BreastCancerDetection
{
    public partial class Information: Form
    {
        public Information()
        {
            InitializeComponent();
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

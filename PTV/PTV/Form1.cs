﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Next5Form next5form = new Next5Form();
            next5form.TopLevel = false;
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(next5form);
            next5form.Show();
        }
    }
}

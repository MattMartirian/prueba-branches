﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            MessageBox.Show("pito");
            MessageBox.Show(":v");
            MessageBox.Show("AGUANTE EL BARCELONA LA CONCHA GORDA DE TU MADRE");
        }
    }
}

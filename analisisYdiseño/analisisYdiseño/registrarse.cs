﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace analisisYdiseño
{
    public partial class registrarse : Form
    {
        public registrarse()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 dato = new Form1();
            dato.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decano dato = new decano();
            dato.ShowDialog();
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forms_bán_cá
{
    public partial class kienthucnuoica : Form
    {
        public kienthucnuoica()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            trangchu phuckien = new trangchu();
            phuckien.Show();
            this.Hide();

        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banking.View
{
    public partial class Login : UserControl
    {
        public Login()
        {
            InitializeComponent();
            this.Resize += (s, e) =>
            {
                // Căn giữa Panel trong Form
                panel1.Location = new Point((this.ClientSize.Width - panel1.Width) / 2,
                                                (this.ClientSize.Height - panel1.Height) / 2);
            };
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}

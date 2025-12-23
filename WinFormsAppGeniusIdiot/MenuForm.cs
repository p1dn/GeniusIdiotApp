using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsAppGeniusIdiot
{
    public partial class MenuForm : Form
    {
        private readonly string userName;

        public MenuForm()
        {
            InitializeComponent();
        }

        public MenuForm(string userName) : this()
        {
            this.userName = userName;
        }
    }
}

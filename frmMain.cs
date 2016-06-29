using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace FileListExists
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void cmdRun_Click(object sender, EventArgs e)
        {
            string[] files = txtSource.Lines;
            TextBox t;
            int run = 0;

            txtExists.Text = "";
            txtDoesntExist.Text = "";

            foreach (string f in files)
            {
                if (File.Exists(Path.GetFullPath(f)))
                    t = txtExists;
                else
                    t = txtDoesntExist;

                t.Text += f + "\r\n";
                run++;
            }
        }
    }
}

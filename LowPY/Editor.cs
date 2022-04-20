using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using DevLeader.IronPython.WinForms;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using FastColoredTextBoxNS;

namespace LowPY
{

    public partial class Editor : Form
    {
        public static string writepath = Menu.filePath;
        private static Process InterProc;

        float timesclicked = 0;


        public Editor()
        {
            InitializeComponent();

            System.Diagnostics.Process InterProc = new System.Diagnostics.Process();
        }

        private void Editor_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            pathText.Text = Menu.filePath;

            string readfile = File.ReadAllText(Menu.filePath);

            editorTextbox.Text = readfile;
        }

        protected override void WndProc(ref Message m) // this motherfucker makes shit dragable
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }

            base.WndProc(ref m);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            save();
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            var menu = new Menu();

            menu.Show();
        }

        public void runButton_Click(object sender, EventArgs e)
        {

            if (File.Exists(writepath))
            {
                status.Text = writepath + " is valid ..";

                var shell = new MainForm();

                shell.Show();

                status.Text = "Launched Script Runner successfully ..";

            }


            else
            {

                status.Text = writepath + " does not exist";

            }

        }

        //  Stream outputStream


        void save()
        {

            File.WriteAllText(Menu.filePath, editorTextbox.Text);

            status.Text = "Saved to; " + Menu.filePath;

        }

        private void localpyinstall_Click(object sender, EventArgs e)
        {
            string localappdata = Environment.GetEnvironmentVariable("LocalAppData");

            string pythonpath = localappdata + @"\Programs\Python\Python310\python.exe";

            if (File.Exists(pythonpath))
            {

                status.Text = pythonpath + " is valid ..";

                if (File.Exists(writepath))
                {
                    status.Text = writepath + " is valid ..";

                    Process.Start(pythonpath, writepath);

                    status.Text = "Started Python.exe with " + writepath + " ..";

                }

            }

            else
            {

                status.Text = "Could not validate a python install, install python 3.10 from https://www.python.org/";

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            timesclicked += 1;

            if (timesclicked == 5)
            {

                var about = new About();

                about.Show();

            }


        }

        private void editorTextbox_TextChanged(object sender, EventArgs e)
        {
            Style GreenStyle = new TextStyle(Brushes.Green, null, FontStyle.Italic);

            
        }

    }
}
 
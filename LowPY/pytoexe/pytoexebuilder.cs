using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LowPY
{
    public partial class pytoexebuilder : Form
    {
        public pytoexebuilder()
        {
            InitializeComponent();
        }

        private void pytoexebuilder_Load(object sender, EventArgs e)
        {
            this.TopMost = true;

            pathtext.Text = Editor.writepath;

            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void buildButton_Click_1(object sender, EventArgs e)
        {
            output.Text += "Starting the build process..\n";
            output.Text += "\r\nPath : " + Editor.writepath;


            try
            {

                string path = Editor.writepath;
                string buildpath = System.IO.Directory.GetParent(path).FullName;

                output.Text += "\r\nBuilding to : " + buildpath;

                var p = new System.Diagnostics.Process();
                p.StartInfo.FileName = "cmd.exe";
                p.StartInfo.Arguments = "/c pyinstaller --onefile " + path + " --distpath " + buildpath;
                //p.StartInfo.RedirectStandardOutput = true;
                p.StartInfo.UseShellExecute = true;
                p.StartInfo.CreateNoWindow = false;
                p.Start();

                output.Text += "\r\nBuild process started..";

                p.WaitForExit();

                output.Text += "\r\nBuild process finished..";

            }
            catch (Exception ex)
            {
                output.Text += "\r\nBUILD CRASHED : " + ex;

            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var setup = new pytoexesetup();

            this.Hide();
            setup.Show();
        }
    }
}

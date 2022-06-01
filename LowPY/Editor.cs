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
using System.Text.RegularExpressions;
using FastColoredTextBoxNS;
using DiscordRPC;

namespace LowPY
{

    public partial class Editor : Form
    {
        public static string writepath = Menu.filePath;
        private static Process InterProc;

        float timesclicked = 0;
        private DiscordRpcClient client;

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

            string filename = Path.GetFileName(writepath);

            client = new DiscordRpcClient("981283103093964830");
            client.Initialize();

            client.SetPresence(new RichPresence()
            {
                Details = "Doing Python stuff..",
                State = "Editing file : " + filename,
                
                Assets = new Assets()
                {
                    LargeImageKey = "lpy_logo",
                    LargeImageText = "https://github.com/zeropixx/LowPY",
                    //SmallImageKey = "lpy_logo"
                }
            });

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
            Menu.filePath = null;
            Editor.writepath = null;

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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            timesclicked += 1;

            if (timesclicked == 5)
            {

                var about = new About();

                about.Show();

            }


        }

        private void tkinterbutton_Click(object sender, EventArgs e)
        {
            string localappdata = Environment.GetEnvironmentVariable("LocalAppData");

            string pythonpath = localappdata + @"\Programs\Python\Python310\python.exe";

            string writepath = Editor.writepath;

            status.Text = "Running Py.exe with " + writepath + " ..";


            if (File.Exists(pythonpath))
            {

                if (File.Exists(writepath))
                {
                    string filename = Path.GetFileName(writepath);

                    if (filename.Contains(" "))
                    {
                        MessageBox.Show("Cannot read filename\nLowPY cant read filenames with spaces in TKinter mode\nrename your file to not contain spaces to use TKinter mode");
                    }
                    else
                    {
                        spacecheckpassed();

                        void spacecheckpassed()
                        {

                            var timedout = 0;

                            Process.Start(pythonpath, writepath);

                            status.Text += "\nStarted Python.exe with " + writepath + " ..\n";

                            status.Text = "Waiting 1 seconds for TKinter build..";

                            Pywait();

                            void Pywait()
                            {

                                var t = Task.Delay(1000); //1 second/1000 ms
                                t.Wait();

                                timedout += 1;

                            }

                            FileInfo fileInfo = new FileInfo(writepath);
                            string buildpath = fileInfo.DirectoryName;

                            buildpath += @"\__pycache__";

                            if (Directory.Exists(buildpath))
                            {
                                status.Text = "TKinter wait finished..";

                                status.Text = "PyCache is ; " + buildpath + " ..";

                                buildpath += @"\tkinter.cpython-310.pyc";

                                Process.Start(pythonpath, buildpath);

                                status.Text = "Started compiled TKinter build ; " + buildpath + " ..";

                            }
                            else
                            {
                                status.Text = "TKinter has not finished building.. starting wait";

                                Pywait();
                            }

                        }

                    }

                }

            }

            else
            {

                status.Text += "\nCould not validate a python install, install python 3.10 from https://www.python.org/ \n";

            }
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pytoexeButton_Click(object sender, EventArgs e)
        {
            var builder = new pytoexebuilder();         

            if (File.Exists(@"ref/pybuildersetupdone"))
            {
                builder.Show();

            }

            else
            {

                var pyinstallsetup = new pytoexesetup();

                pyinstallsetup.Show();

            }

        }

        private void pythonconsoleButton_Click_1(object sender, EventArgs e)
        {
            string localappdata = Environment.GetEnvironmentVariable("LocalAppData");
            string pythonpath = localappdata + @"\Programs\Python\Python310\python.exe";

            if (File.Exists(pythonpath))
            {

                Process.Start(pythonpath);

                status.Text = "Started the Python console (python.exe) ..";

            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var about = new helpforms.help();

            about.Show();


        }

        private void editorTextbox_Load(object sender, EventArgs e)
        {

        }
    }
}
 
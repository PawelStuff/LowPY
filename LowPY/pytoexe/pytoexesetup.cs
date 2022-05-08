using DevLeader.IronPython.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LowPY
{
    public partial class pytoexesetup : Form
    {
        public pytoexesetup()
        {
            InitializeComponent();
        }

        private void pytoexesetup_Load(object sender, EventArgs e)
        {
            this.TopMost = true;

            var editor = new Editor();
            editor.MinimizeBox = true;
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            File.Create(@"ref/pybuildersetupdone");

            var pybuildthing = new pytoexebuilder();
            pybuildthing.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("the installation process will now start\nafter it finishes you will be sent to the builder\nif you cannot build after this setup finishes redo this setup from the link within the builder");

            try
            {
                installpyinstaller();

                void installpyinstaller()
                {

                    var p = new System.Diagnostics.Process();
                    p.StartInfo.FileName = "cmd.exe";
                    p.StartInfo.Arguments = "/c pip install PyInstaller";
                    //p.StartInfo.RedirectStandardOutput = true;
                    p.StartInfo.UseShellExecute = true;
                    p.StartInfo.CreateNoWindow = false;
                    p.Start();

                    p.WaitForExit();

                    Repeatinstallask();

                }

                void Repeatinstallask()
                {
                    var builder = new pytoexebuilder();

                    builder.Show();
                    this.Hide();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception catched (something went wrong) : " + ex);

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

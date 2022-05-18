using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LowPY.helpforms
{
    public partial class help : Form
    {
        public help()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var editorhelp = new helpforms.editorhelp();

            editorhelp.Show();

            this.Hide();
        }

        private void help_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var srhelp = new helpforms.scriptrunnerhelp();

            srhelp.Show();

            this.Hide();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var tkhelp = new helpforms.tkinterhelp();

            tkhelp.Show();

            this.Hide();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var pytoexehelp = new helpforms.pytoexehelp();

            pytoexehelp.Show();

            this.Hide();
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var fctb = new helpforms.fctbhelp();

            fctb.Show();

            this.Hide();
        }
    }
}

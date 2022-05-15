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
    public partial class scriptrunnerhelp : Form
    {
        public scriptrunnerhelp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var index = new helpforms.help();

            index.Show();
            this.Hide();
        }

        private void scriptrunnerhelp_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
        }
    }
}

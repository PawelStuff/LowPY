using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

using IronPython.Hosting;
using LowPY;
using System.Diagnostics;

namespace DevLeader.IronPython.WinForms
{
    // just to be clear afterwards, ive had too many failed tries writing my own python thing so i take this one from :
    // https://www.codeproject.com/articles/755977/ironpython-a-quick-winforms-introduction
    // and ive modified it to my needs


    /// <summary>
    /// A form that allows users to execute Python scripts from a file or from 
    /// entering them manually on the form.
    /// </summary>
    public partial class MainForm : Form
    {
        #region Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="MainForm"/> class.
        /// </summary>
        ///    

        public MainForm()
        {
            InitializeComponent();
        }
        #endregion

        #region Internal Members
        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Form.Load" /> event.
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
        protected override void OnLoad(EventArgs e)
        {
            Editor editor = new Editor();

            pathtext.Text = Editor.writepath;

            base.OnLoad(e);
        }

        private void ExecuteScript(string scriptBody, Stream outputStream)
        {
            var py = Python.CreateEngine();
            py.Runtime.IO.SetOutput(outputStream, Encoding.ASCII);

            try
            {
                py.Execute(scriptBody);                
            }
            catch (Exception ex)
            {
                using (var writer = new StreamWriter(outputStream))
                {
                    writer.WriteLine(
                        "Exception Catched! (Something went wrong):\r\n" +
                        ex.Message + "\r\n\r\n" + ex.StackTrace);
                }
            }
        }
        #endregion

        #region Event Handlers
        private void RadInputFromFile_CheckedChanged(object sender, EventArgs e)
        {
            bool optionEnabled = ((RadioButton)sender).Checked;
        }

        private void RadInputFromForm_CheckedChanged(object sender, EventArgs e)
        {
            bool optionEnabled = ((RadioButton)sender).Checked;
        }

        private void CmdRunScript_Click(object sender, EventArgs e)
        {
            pathtext.Text = Editor.writepath;

            string scriptBody;

            scriptBody = Editor.writepath;

            var inputFilePath = Editor.writepath;
            if (!File.Exists(inputFilePath))
            {
                MessageBox.Show(
                    "The file '" + inputFilePath + "' does not exist.",
                    Application.ProductName);
                return;
            }

            try
            {
                using (var reader = new StreamReader(inputFilePath))
                {
                    scriptBody = reader.ReadToEnd();
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show(
                    "An exception was caught while opening '" + inputFilePath + "':\r\n\r\n" +
                    ex.Message + "\r\n\r\n" + ex.StackTrace,
                    Application.ProductName);
                return;
            }

            // run our script and print the output
            txtOutput.Text += DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + ":\r\n";
            using (var outStream = new ScriptOutputStream(txtOutput))
            {
                ExecuteScript(scriptBody, outStream);
            }

            txtOutput.Text += "\r\n";

            // scroll to the end of the output
            txtOutput.SelectionLength = 0;
            txtOutput.SelectionStart = txtOutput.Text.Length - 1;
            txtOutput.ScrollToCaret();
            
        }

        private void CmdClearOutput_Click(object sender, EventArgs e)
        {
            txtOutput.Clear();
        }

        #endregion

        #region Classes
        private class ScriptOutputStream : Stream
        {
            #region Fields
            private readonly TextBox _control;
            #endregion

            #region Constructors
            public ScriptOutputStream(TextBox control)
            {
                _control = control;
            }
            #endregion

            #region Properties
            public override bool CanRead
            {
                get { return false; }
            }

            public override bool CanSeek
            {
                get { return false; }
            }

            public override bool CanWrite
            {
                get { return true; }
            }

            public override long Length
            {
                get { throw new NotImplementedException(); }
            }

            public override long Position
            {
                get { throw new NotImplementedException(); }
                set { throw new NotImplementedException(); }
            }
            #endregion

            #region Exposed Members
            public override void Flush()
            {
            }

            public override int Read(byte[] buffer, int offset, int count)
            {
                throw new NotImplementedException();
            }

            public override long Seek(long offset, SeekOrigin origin)
            {
                throw new NotImplementedException();
            }

            public override void SetLength(long value)
            {
                throw new NotImplementedException();
            }

            public override void Write(byte[] buffer, int offset, int count)
            {
                _control.Text += Encoding.ASCII.GetString(buffer, offset, count);
            }
            #endregion
        }
        #endregion

        private void txtOutput_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtOutput_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
        }

        private void localpyinstall_Click(object sender, EventArgs e)
        {
            string localappdata = Environment.GetEnvironmentVariable("LocalAppData");

            string pythonpath = localappdata + @"\Programs\Python\Python310\python.exe";

            string writepath = Editor.writepath;

            if (File.Exists(pythonpath))
            {

                if (File.Exists(writepath))
                {

                    Process.Start(pythonpath, writepath);

                    txtOutput.Text += "\nStarted Python.exe with " + writepath + " ..\n";

                }

            }

            else
            {

                txtOutput.Text += "\nCould not validate a python install, install python 3.10 from https://www.python.org/ \n";

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

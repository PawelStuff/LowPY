namespace DevLeader.IronPython.WinForms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.cmdRunScript = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pathtext = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.localpyinstall = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtOutput
            // 
            this.txtOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtOutput.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtOutput.ForeColor = System.Drawing.Color.White;
            this.txtOutput.Location = new System.Drawing.Point(13, 171);
            this.txtOutput.Margin = new System.Windows.Forms.Padding(0);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtOutput.Size = new System.Drawing.Size(317, 177);
            this.txtOutput.TabIndex = 3;
            this.txtOutput.Text = "   LowPY v1.0\r\n  Script Runner\r\n\r\n    \"Strawberry\"\r\n============\r\n";
            this.txtOutput.TextChanged += new System.EventHandler(this.txtOutput_TextChanged_1);
            // 
            // cmdRunScript
            // 
            this.cmdRunScript.Location = new System.Drawing.Point(13, 95);
            this.cmdRunScript.Name = "cmdRunScript";
            this.cmdRunScript.Size = new System.Drawing.Size(164, 54);
            this.cmdRunScript.TabIndex = 2;
            this.cmdRunScript.Text = "Run Open Script\r\n(embeded engine)";
            this.cmdRunScript.UseVisualStyleBackColor = true;
            this.cmdRunScript.Click += new System.EventHandler(this.CmdRunScript_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LowPY.Properties.Resources.lpy_logo_2_35;
            this.pictureBox1.Location = new System.Drawing.Point(17, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.pathtext);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-6, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(354, 77);
            this.panel1.TabIndex = 5;
            // 
            // pathtext
            // 
            this.pathtext.AutoSize = true;
            this.pathtext.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pathtext.Location = new System.Drawing.Point(90, 31);
            this.pathtext.Name = "pathtext";
            this.pathtext.Size = new System.Drawing.Size(68, 19);
            this.pathtext.TabIndex = 6;
            this.pathtext.Text = "path here";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(90, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 27);
            this.label1.TabIndex = 5;
            this.label1.Text = "LowPY Script Runner";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkGray;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(13, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Output Console";
            // 
            // localpyinstall
            // 
            this.localpyinstall.BackColor = System.Drawing.Color.Silver;
            this.localpyinstall.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.localpyinstall.Location = new System.Drawing.Point(184, 96);
            this.localpyinstall.Margin = new System.Windows.Forms.Padding(4);
            this.localpyinstall.Name = "localpyinstall";
            this.localpyinstall.Size = new System.Drawing.Size(146, 53);
            this.localpyinstall.TabIndex = 10;
            this.localpyinstall.Text = "Run with local Python 3.10 install";
            this.localpyinstall.UseVisualStyleBackColor = false;
            this.localpyinstall.Click += new System.EventHandler(this.localpyinstall_Click);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(348, 360);
            this.Controls.Add(this.localpyinstall);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmdRunScript);
            this.Controls.Add(this.txtOutput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MdiChildrenMinimizedAnchorBottom = false;
            this.Name = "MainForm";
            this.Text = "LowPY - Script Runner";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtOutput;
        private Button cmdRunScript;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label pathtext;
        private Button localpyinstall;
    }
}


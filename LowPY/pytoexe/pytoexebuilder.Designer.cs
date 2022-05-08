namespace LowPY
{
    partial class pytoexebuilder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pytoexebuilder));
            this.output = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pathtext = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buildButton = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // output
            // 
            this.output.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.output.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.output.ForeColor = System.Drawing.SystemColors.Menu;
            this.output.Location = new System.Drawing.Point(11, 187);
            this.output.Multiline = true;
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(272, 148);
            this.output.TabIndex = 1;
            this.output.Text = "   LowPY v1.0\r\n  PyInstaller Builder\r\n\r\n    \"Strawberry\"\r\n============\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkGray;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Output Console";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.pathtext);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-51, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(354, 81);
            this.panel1.TabIndex = 8;
            // 
            // pathtext
            // 
            this.pathtext.AutoSize = true;
            this.pathtext.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pathtext.Location = new System.Drawing.Point(135, 34);
            this.pathtext.Name = "pathtext";
            this.pathtext.Size = new System.Drawing.Size(55, 15);
            this.pathtext.TabIndex = 6;
            this.pathtext.Text = "path here";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(135, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "LowPY PyInstaller Builder";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LowPY.Properties.Resources.lpy_logo_2_35;
            this.pictureBox1.Location = new System.Drawing.Point(64, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // buildButton
            // 
            this.buildButton.Location = new System.Drawing.Point(13, 99);
            this.buildButton.Name = "buildButton";
            this.buildButton.Size = new System.Drawing.Size(272, 67);
            this.buildButton.TabIndex = 9;
            this.buildButton.Text = "Build";
            this.buildButton.UseVisualStyleBackColor = true;
            this.buildButton.Click += new System.EventHandler(this.buildButton_Click_1);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(194, 169);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(89, 15);
            this.linkLabel1.TabIndex = 10;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "run setup again";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // pytoexebuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(296, 347);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.buildButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.output);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "pytoexebuilder";
            this.Text = "LowPY PyInstaller Builder";
            this.Load += new System.EventHandler(this.pytoexebuilder_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox output;
        private Label label2;
        private Panel panel1;
        private Label pathtext;
        private Label label1;
        private PictureBox pictureBox1;
        private Button buildButton;
        private LinkLabel linkLabel1;
    }
}
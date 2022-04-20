namespace LowPY
{
    partial class Editor
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editor));
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.pathText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.runButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.localpyinstall = new System.Windows.Forms.Button();
            this.editorTextbox = new FastColoredTextBoxNS.FastColoredTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editorTextbox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.menuButton);
            this.panel1.Controls.Add(this.exitButton);
            this.panel1.Controls.Add(this.pathText);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 14);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1160, 72);
            this.panel1.TabIndex = 0;
            // 
            // menuButton
            // 
            this.menuButton.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuButton.Location = new System.Drawing.Point(1094, 4);
            this.menuButton.Margin = new System.Windows.Forms.Padding(4);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(22, 23);
            this.menuButton.TabIndex = 3;
            this.menuButton.Text = "M";
            this.menuButton.UseVisualStyleBackColor = true;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exitButton.Location = new System.Drawing.Point(1124, 4);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(22, 23);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "X";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // pathText
            // 
            this.pathText.Font = new System.Drawing.Font("Segoe UI Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pathText.Location = new System.Drawing.Point(85, 37);
            this.pathText.Name = "pathText";
            this.pathText.Size = new System.Drawing.Size(1061, 33);
            this.pathText.TabIndex = 4;
            this.pathText.Text = "path here";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "LowPY";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LowPY.Properties.Resources.lpy_logo_2_35;
            this.pictureBox1.Location = new System.Drawing.Point(12, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.Font = new System.Drawing.Font("Segoe UI Light", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(1053, 125);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 72);
            this.button1.TabIndex = 3;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // runButton
            // 
            this.runButton.BackColor = System.Drawing.Color.Gray;
            this.runButton.Font = new System.Drawing.Font("Segoe UI Light", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.runButton.Location = new System.Drawing.Point(1052, 498);
            this.runButton.Margin = new System.Windows.Forms.Padding(4);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(72, 72);
            this.runButton.TabIndex = 4;
            this.runButton.Text = "Script Runner";
            this.runButton.UseVisualStyleBackColor = false;
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gray;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(0, 654);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Status :";
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.BackColor = System.Drawing.Color.Gray;
            this.status.Font = new System.Drawing.Font("Segoe UI Light", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.status.ForeColor = System.Drawing.Color.Lime;
            this.status.Location = new System.Drawing.Point(56, 654);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(30, 19);
            this.status.TabIndex = 6;
            this.status.Text = "idle";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Gray;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(1053, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "File Saving";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Gray;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(1053, 475);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Executing";
            // 
            // localpyinstall
            // 
            this.localpyinstall.BackColor = System.Drawing.Color.Gray;
            this.localpyinstall.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.localpyinstall.Location = new System.Drawing.Point(1052, 578);
            this.localpyinstall.Margin = new System.Windows.Forms.Padding(4);
            this.localpyinstall.Name = "localpyinstall";
            this.localpyinstall.Size = new System.Drawing.Size(72, 72);
            this.localpyinstall.TabIndex = 9;
            this.localpyinstall.Text = "Run with local Python 3.10 install";
            this.localpyinstall.UseVisualStyleBackColor = false;
            this.localpyinstall.Click += new System.EventHandler(this.localpyinstall_Click);
            // 
            // editorTextbox
            // 
            this.editorTextbox.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.editorTextbox.AutoScrollMinSize = new System.Drawing.Size(241, 18);
            this.editorTextbox.BackBrush = null;
            this.editorTextbox.BackColor = System.Drawing.Color.DimGray;
            this.editorTextbox.CharHeight = 18;
            this.editorTextbox.CharWidth = 10;
            this.editorTextbox.CommentPrefix = "#";
            this.editorTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.editorTextbox.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.editorTextbox.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.editorTextbox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.editorTextbox.IndentBackColor = System.Drawing.Color.Gray;
            this.editorTextbox.IsReplaceMode = false;
            this.editorTextbox.LineNumberColor = System.Drawing.Color.Aquamarine;
            this.editorTextbox.Location = new System.Drawing.Point(12, 101);
            this.editorTextbox.Name = "editorTextbox";
            this.editorTextbox.Paddings = new System.Windows.Forms.Padding(0);
            this.editorTextbox.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.editorTextbox.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("editorTextbox.ServiceColors")));
            this.editorTextbox.ServiceLinesColor = System.Drawing.Color.DarkGray;
            this.editorTextbox.Size = new System.Drawing.Size(1033, 550);
            this.editorTextbox.TabIndex = 10;
            this.editorTextbox.Text = "print(\"hello lowpy!\")";
            this.editorTextbox.Zoom = 100;
            // 
            // Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1156, 682);
            this.Controls.Add(this.editorTextbox);
            this.Controls.Add(this.localpyinstall);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.status);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.runButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "Editor";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LowPY - Editor";
            this.Load += new System.EventHandler(this.Editor_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editorTextbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label pathText;
        private Label label1;
        private Button exitButton;
        private Button button1;
        private Button menuButton;
        private Button runButton;
        private Label label2;
        private Label status;
        private Label label3;
        private Label label4;
        private Button localpyinstall;
        private FastColoredTextBoxNS.FastColoredTextBox editorTextbox;
    }
}
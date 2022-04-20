namespace LowPY
{
    partial class Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.openButton = new System.Windows.Forms.Button();
            this.welcomeText = new System.Windows.Forms.Label();
            this.lpyLogo = new System.Windows.Forms.PictureBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.pathButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lpyLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.openButton);
            this.panel1.Controls.Add(this.welcomeText);
            this.panel1.Location = new System.Drawing.Point(12, 168);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(325, 270);
            this.panel1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(178, 142);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 88);
            this.button2.TabIndex = 2;
            this.button2.Text = "Create New";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // openButton
            // 
            this.openButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.openButton.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.openButton.Location = new System.Drawing.Point(35, 142);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(109, 88);
            this.openButton.TabIndex = 1;
            this.openButton.Text = "Open";
            this.openButton.UseVisualStyleBackColor = false;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // welcomeText
            // 
            this.welcomeText.AutoSize = true;
            this.welcomeText.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.welcomeText.Location = new System.Drawing.Point(35, 50);
            this.welcomeText.Name = "welcomeText";
            this.welcomeText.Size = new System.Drawing.Size(252, 35);
            this.welcomeText.TabIndex = 0;
            this.welcomeText.Text = "Welcome to LowPY";
            // 
            // lpyLogo
            // 
            this.lpyLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lpyLogo.Image = global::LowPY.Properties.Resources.lpy_logo_2_35;
            this.lpyLogo.Location = new System.Drawing.Point(73, 12);
            this.lpyLogo.Name = "lpyLogo";
            this.lpyLogo.Size = new System.Drawing.Size(200, 200);
            this.lpyLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lpyLogo.TabIndex = 1;
            this.lpyLogo.TabStop = false;
            this.lpyLogo.Click += new System.EventHandler(this.lpyLogo_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(317, 12);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(20, 23);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "X";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // pathButton
            // 
            this.pathButton.Location = new System.Drawing.Point(12, 12);
            this.pathButton.Name = "pathButton";
            this.pathButton.Size = new System.Drawing.Size(21, 23);
            this.pathButton.TabIndex = 3;
            this.pathButton.Text = "P";
            this.pathButton.UseVisualStyleBackColor = true;
            this.pathButton.Click += new System.EventHandler(this.pathButton_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(349, 450);
            this.Controls.Add(this.lpyLogo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pathButton);
            this.Controls.Add(this.exitButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lpyLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private PictureBox lpyLogo;
        private Button exitButton;
        private Button pathButton;
        private Button button2;
        private Button openButton;
        private Label welcomeText;
    }
}
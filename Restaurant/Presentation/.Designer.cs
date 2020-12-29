namespace Restaurant
{
    partial class Admin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.AdminTopPanel = new System.Windows.Forms.Panel();
            this.AdminLeftPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btnAdminSettings = new System.Windows.Forms.Button();
            this.btnAdminLogout = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.AdminLeftPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.AdminLeftPanel);
            this.panel1.Controls.Add(this.AdminTopPanel);
            this.panel1.Location = new System.Drawing.Point(-1, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1351, 731);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // AdminTopPanel
            // 
            this.AdminTopPanel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.AdminTopPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.AdminTopPanel.Location = new System.Drawing.Point(3, 3);
            this.AdminTopPanel.Name = "AdminTopPanel";
            this.AdminTopPanel.Size = new System.Drawing.Size(1345, 61);
            this.AdminTopPanel.TabIndex = 0;
            // 
            // AdminLeftPanel
            // 
            this.AdminLeftPanel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.AdminLeftPanel.Controls.Add(this.btnAdminLogout);
            this.AdminLeftPanel.Controls.Add(this.btnAdminSettings);
            this.AdminLeftPanel.Controls.Add(this.button6);
            this.AdminLeftPanel.Controls.Add(this.button5);
            this.AdminLeftPanel.Location = new System.Drawing.Point(3, 63);
            this.AdminLeftPanel.Name = "AdminLeftPanel";
            this.AdminLeftPanel.Size = new System.Drawing.Size(238, 665);
            this.AdminLeftPanel.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(491, 277);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(613, 375);
            this.panel2.TabIndex = 2;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(207, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(198, 182);
            this.button4.TabIndex = 3;
            this.button4.Text = "Employees";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(3, 21);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(232, 36);
            this.button5.TabIndex = 0;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(3, 63);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(232, 36);
            this.button6.TabIndex = 1;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // btnAdminSettings
            // 
            this.btnAdminSettings.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminSettings.Location = new System.Drawing.Point(3, 105);
            this.btnAdminSettings.Name = "btnAdminSettings";
            this.btnAdminSettings.Size = new System.Drawing.Size(232, 36);
            this.btnAdminSettings.TabIndex = 2;
            this.btnAdminSettings.Text = "Settings";
            this.btnAdminSettings.UseVisualStyleBackColor = true;
            // 
            // btnAdminLogout
            // 
            this.btnAdminLogout.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnAdminLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdminLogout.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminLogout.Location = new System.Drawing.Point(3, 147);
            this.btnAdminLogout.Name = "btnAdminLogout";
            this.btnAdminLogout.Size = new System.Drawing.Size(232, 36);
            this.btnAdminLogout.TabIndex = 3;
            this.btnAdminLogout.Text = "Log Out";
            this.btnAdminLogout.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(411, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(198, 182);
            this.button3.TabIndex = 2;
            this.button3.Text = "Manage Food ";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(313, 190);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(198, 182);
            this.button2.TabIndex = 1;
            this.button2.Text = "Restaurant Information";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(198, 182);
            this.button1.TabIndex = 0;
            this.button1.Text = "Manage Users";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button7.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(109, 190);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(198, 182);
            this.button7.TabIndex = 5;
            this.button7.Text = "Purchases ";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(473, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(604, 75);
            this.label1.TabIndex = 3;
            this.label1.Text = "Welcome to Cuisine";
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Admin";
            this.Text = "Admin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.AdminLeftPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel AdminTopPanel;
        private System.Windows.Forms.Panel AdminLeftPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAdminLogout;
        private System.Windows.Forms.Button btnAdminSettings;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label1;
    }
}
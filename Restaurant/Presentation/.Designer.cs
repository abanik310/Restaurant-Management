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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.AdminLeftPanel = new System.Windows.Forms.Panel();
            this.btnAdminDashBoard = new System.Windows.Forms.Button();
            this.btnAdminSetting = new System.Windows.Forms.Button();
            this.btnAdminEmployees = new System.Windows.Forms.Button();
            this.btnAdminUsers = new System.Windows.Forms.Button();
            this.btnAdminPurchases = new System.Windows.Forms.Button();
            this.btnAdminFood = new System.Windows.Forms.Button();
            this.btnAdminLogout = new System.Windows.Forms.Button();
            this.btnAdminProfile = new System.Windows.Forms.Button();
            this.pnlAdminUI = new System.Windows.Forms.Panel();
            this.pnlAdminMain = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAdminName = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.AdminLeftPanel.SuspendLayout();
            this.pnlAdminUI.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 132F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.AdminLeftPanel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnlAdminUI, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1350, 729);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // AdminLeftPanel
            // 
            this.AdminLeftPanel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.AdminLeftPanel.Controls.Add(this.btnAdminDashBoard);
            this.AdminLeftPanel.Controls.Add(this.btnAdminSetting);
            this.AdminLeftPanel.Controls.Add(this.btnAdminEmployees);
            this.AdminLeftPanel.Controls.Add(this.btnAdminUsers);
            this.AdminLeftPanel.Controls.Add(this.btnAdminPurchases);
            this.AdminLeftPanel.Controls.Add(this.btnAdminFood);
            this.AdminLeftPanel.Controls.Add(this.btnAdminLogout);
            this.AdminLeftPanel.Controls.Add(this.btnAdminProfile);
            this.AdminLeftPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AdminLeftPanel.Location = new System.Drawing.Point(3, 3);
            this.AdminLeftPanel.Name = "AdminLeftPanel";
            this.AdminLeftPanel.Size = new System.Drawing.Size(126, 723);
            this.AdminLeftPanel.TabIndex = 2;
            this.AdminLeftPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.AdminLeftPanel_Paint);
            // 
            // btnAdminDashBoard
            // 
            this.btnAdminDashBoard.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminDashBoard.Location = new System.Drawing.Point(3, 92);
            this.btnAdminDashBoard.Name = "btnAdminDashBoard";
            this.btnAdminDashBoard.Size = new System.Drawing.Size(120, 36);
            this.btnAdminDashBoard.TabIndex = 11;
            this.btnAdminDashBoard.Text = "Dash Board";
            this.btnAdminDashBoard.UseVisualStyleBackColor = true;
            // 
            // btnAdminSetting
            // 
            this.btnAdminSetting.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminSetting.Location = new System.Drawing.Point(4, 343);
            this.btnAdminSetting.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdminSetting.Name = "btnAdminSetting";
            this.btnAdminSetting.Size = new System.Drawing.Size(119, 29);
            this.btnAdminSetting.TabIndex = 10;
            this.btnAdminSetting.Text = "Settings";
            this.btnAdminSetting.UseVisualStyleBackColor = true;
            this.btnAdminSetting.Click += new System.EventHandler(this.btnAdminSetting_Click);
            // 
            // btnAdminEmployees
            // 
            this.btnAdminEmployees.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminEmployees.Location = new System.Drawing.Point(4, 176);
            this.btnAdminEmployees.Name = "btnAdminEmployees";
            this.btnAdminEmployees.Size = new System.Drawing.Size(120, 36);
            this.btnAdminEmployees.TabIndex = 9;
            this.btnAdminEmployees.Text = "Employees";
            this.btnAdminEmployees.UseVisualStyleBackColor = true;
            this.btnAdminEmployees.Click += new System.EventHandler(this.btnEmployees_Click);
            // 
            // btnAdminUsers
            // 
            this.btnAdminUsers.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminUsers.Location = new System.Drawing.Point(4, 134);
            this.btnAdminUsers.Name = "btnAdminUsers";
            this.btnAdminUsers.Size = new System.Drawing.Size(120, 36);
            this.btnAdminUsers.TabIndex = 8;
            this.btnAdminUsers.Text = "Users";
            this.btnAdminUsers.UseVisualStyleBackColor = true;
            this.btnAdminUsers.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnAdminPurchases
            // 
            this.btnAdminPurchases.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminPurchases.Location = new System.Drawing.Point(4, 260);
            this.btnAdminPurchases.Name = "btnAdminPurchases";
            this.btnAdminPurchases.Size = new System.Drawing.Size(120, 36);
            this.btnAdminPurchases.TabIndex = 7;
            this.btnAdminPurchases.Text = "Purchases";
            this.btnAdminPurchases.UseVisualStyleBackColor = true;
            this.btnAdminPurchases.Click += new System.EventHandler(this.btnPurchases_Click);
            // 
            // btnAdminFood
            // 
            this.btnAdminFood.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminFood.Location = new System.Drawing.Point(4, 218);
            this.btnAdminFood.Name = "btnAdminFood";
            this.btnAdminFood.Size = new System.Drawing.Size(120, 36);
            this.btnAdminFood.TabIndex = 6;
            this.btnAdminFood.Text = "Food Stock";
            this.btnAdminFood.UseVisualStyleBackColor = true;
            this.btnAdminFood.Click += new System.EventHandler(this.btnFood_Click);
            // 
            // btnAdminLogout
            // 
            this.btnAdminLogout.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnAdminLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdminLogout.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminLogout.Location = new System.Drawing.Point(3, 376);
            this.btnAdminLogout.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdminLogout.Name = "btnAdminLogout";
            this.btnAdminLogout.Size = new System.Drawing.Size(120, 36);
            this.btnAdminLogout.TabIndex = 3;
            this.btnAdminLogout.Text = "Log Out";
            this.btnAdminLogout.UseVisualStyleBackColor = false;
            this.btnAdminLogout.Click += new System.EventHandler(this.btnAdminLogout_Click);
            // 
            // btnAdminProfile
            // 
            this.btnAdminProfile.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminProfile.Location = new System.Drawing.Point(4, 302);
            this.btnAdminProfile.Name = "btnAdminProfile";
            this.btnAdminProfile.Size = new System.Drawing.Size(120, 36);
            this.btnAdminProfile.TabIndex = 2;
            this.btnAdminProfile.Text = "Profile";
            this.btnAdminProfile.UseVisualStyleBackColor = true;
            this.btnAdminProfile.Click += new System.EventHandler(this.btnAdminSettings_Click);
            // 
            // pnlAdminUI
            // 
            this.pnlAdminUI.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlAdminUI.Controls.Add(this.pnlAdminMain);
            this.pnlAdminUI.Controls.Add(this.panel1);
            this.pnlAdminUI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAdminUI.Location = new System.Drawing.Point(135, 3);
            this.pnlAdminUI.Name = "pnlAdminUI";
            this.pnlAdminUI.Size = new System.Drawing.Size(1212, 723);
            this.pnlAdminUI.TabIndex = 3;
            // 
            // pnlAdminMain
            // 
            this.pnlAdminMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAdminMain.Location = new System.Drawing.Point(0, 58);
            this.pnlAdminMain.Name = "pnlAdminMain";
            this.pnlAdminMain.Size = new System.Drawing.Size(1212, 665);
            this.pnlAdminMain.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblAdminName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1212, 58);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(861, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "Welcome";
            // 
            // lblAdminName
            // 
            this.lblAdminName.AutoSize = true;
            this.lblAdminName.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAdminName.Location = new System.Drawing.Point(979, 16);
            this.lblAdminName.Name = "lblAdminName";
            this.lblAdminName.Size = new System.Drawing.Size(75, 28);
            this.lblAdminName.TabIndex = 5;
            this.lblAdminName.Text = "Name";
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Admin";
            this.Text = "Admin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.AdminLeftPanel.ResumeLayout(false);
            this.pnlAdminUI.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel AdminLeftPanel;
        private System.Windows.Forms.Label lblAdminName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdminLogout;
        private System.Windows.Forms.Button btnAdminProfile;
        private System.Windows.Forms.Panel pnlAdminUI;
        private System.Windows.Forms.Button btnAdminEmployees;
        private System.Windows.Forms.Button btnAdminUsers;
        private System.Windows.Forms.Button btnAdminPurchases;
        private System.Windows.Forms.Button btnAdminFood;
        private System.Windows.Forms.Panel pnlAdminMain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAdminSetting;
        private System.Windows.Forms.Button btnAdminDashBoard;
    }
}
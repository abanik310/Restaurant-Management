namespace Restaurant
{
    partial class Manager
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
            this.btnCashierProfile = new System.Windows.Forms.Button();
            this.btnManagerPurchases = new System.Windows.Forms.Button();
            this.btnManFood = new System.Windows.Forms.Button();
            this.btnManagerLogout = new System.Windows.Forms.Button();
            this.btnManagerSettings = new System.Windows.Forms.Button();
            this.btnManagerDashBoard = new System.Windows.Forms.Button();
            this.pnlAdminUI = new System.Windows.Forms.Panel();
            this.pnlManagerMain = new System.Windows.Forms.Panel();
            this.pnlCashierMain = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAdminName = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.AdminLeftPanel.SuspendLayout();
            this.pnlAdminUI.SuspendLayout();
            this.pnlManagerMain.SuspendLayout();
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
            this.AdminLeftPanel.Controls.Add(this.btnCashierProfile);
            this.AdminLeftPanel.Controls.Add(this.btnManagerPurchases);
            this.AdminLeftPanel.Controls.Add(this.btnManFood);
            this.AdminLeftPanel.Controls.Add(this.btnManagerLogout);
            this.AdminLeftPanel.Controls.Add(this.btnManagerSettings);
            this.AdminLeftPanel.Controls.Add(this.btnManagerDashBoard);
            this.AdminLeftPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AdminLeftPanel.Location = new System.Drawing.Point(3, 3);
            this.AdminLeftPanel.Name = "AdminLeftPanel";
            this.AdminLeftPanel.Size = new System.Drawing.Size(126, 723);
            this.AdminLeftPanel.TabIndex = 2;
            this.AdminLeftPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.AdminLeftPanel_Paint);
            // 
            // btnCashierProfile
            // 
            this.btnCashierProfile.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCashierProfile.Location = new System.Drawing.Point(3, 186);
            this.btnCashierProfile.Name = "btnCashierProfile";
            this.btnCashierProfile.Size = new System.Drawing.Size(120, 36);
            this.btnCashierProfile.TabIndex = 8;
            this.btnCashierProfile.Text = "Profile";
            this.btnCashierProfile.UseVisualStyleBackColor = true;
            // 
            // btnManagerPurchases
            // 
            this.btnManagerPurchases.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManagerPurchases.Location = new System.Drawing.Point(3, 144);
            this.btnManagerPurchases.Name = "btnManagerPurchases";
            this.btnManagerPurchases.Size = new System.Drawing.Size(120, 36);
            this.btnManagerPurchases.TabIndex = 7;
            this.btnManagerPurchases.Text = "Purchases";
            this.btnManagerPurchases.UseVisualStyleBackColor = true;
            this.btnManagerPurchases.Click += new System.EventHandler(this.btnPurchases_Click);
            // 
            // btnManFood
            // 
            this.btnManFood.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManFood.Location = new System.Drawing.Point(3, 102);
            this.btnManFood.Name = "btnManFood";
            this.btnManFood.Size = new System.Drawing.Size(120, 36);
            this.btnManFood.TabIndex = 6;
            this.btnManFood.Text = "Food Stock";
            this.btnManFood.UseVisualStyleBackColor = true;
            this.btnManFood.Click += new System.EventHandler(this.btnFood_Click);
            // 
            // btnManagerLogout
            // 
            this.btnManagerLogout.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnManagerLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnManagerLogout.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManagerLogout.Location = new System.Drawing.Point(3, 270);
            this.btnManagerLogout.Name = "btnManagerLogout";
            this.btnManagerLogout.Size = new System.Drawing.Size(120, 36);
            this.btnManagerLogout.TabIndex = 3;
            this.btnManagerLogout.Text = "Log Out";
            this.btnManagerLogout.UseVisualStyleBackColor = false;
            this.btnManagerLogout.Click += new System.EventHandler(this.btnAdminLogout_Click);
            // 
            // btnManagerSettings
            // 
            this.btnManagerSettings.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManagerSettings.Location = new System.Drawing.Point(3, 228);
            this.btnManagerSettings.Name = "btnManagerSettings";
            this.btnManagerSettings.Size = new System.Drawing.Size(120, 36);
            this.btnManagerSettings.TabIndex = 2;
            this.btnManagerSettings.Text = "Settings";
            this.btnManagerSettings.UseVisualStyleBackColor = true;
            this.btnManagerSettings.Click += new System.EventHandler(this.btnAdminSettings_Click);
            // 
            // btnManagerDashBoard
            // 
            this.btnManagerDashBoard.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManagerDashBoard.Location = new System.Drawing.Point(3, 60);
            this.btnManagerDashBoard.Name = "btnManagerDashBoard";
            this.btnManagerDashBoard.Size = new System.Drawing.Size(120, 36);
            this.btnManagerDashBoard.TabIndex = 0;
            this.btnManagerDashBoard.Text = "Dash Board";
            this.btnManagerDashBoard.UseVisualStyleBackColor = true;
            this.btnManagerDashBoard.Click += new System.EventHandler(this.btnManagerDashBoard_Click);
            // 
            // pnlAdminUI
            // 
            this.pnlAdminUI.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlAdminUI.Controls.Add(this.pnlManagerMain);
            this.pnlAdminUI.Controls.Add(this.panel1);
            this.pnlAdminUI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAdminUI.Location = new System.Drawing.Point(135, 3);
            this.pnlAdminUI.Name = "pnlAdminUI";
            this.pnlAdminUI.Size = new System.Drawing.Size(1212, 723);
            this.pnlAdminUI.TabIndex = 3;
            // 
            // pnlManagerMain
            // 
            this.pnlManagerMain.Controls.Add(this.pnlCashierMain);
            this.pnlManagerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlManagerMain.Location = new System.Drawing.Point(0, 58);
            this.pnlManagerMain.Name = "pnlManagerMain";
            this.pnlManagerMain.Size = new System.Drawing.Size(1212, 665);
            this.pnlManagerMain.TabIndex = 1;
            // 
            // pnlCashierMain
            // 
            this.pnlCashierMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCashierMain.Location = new System.Drawing.Point(0, 0);
            this.pnlCashierMain.Name = "pnlCashierMain";
            this.pnlCashierMain.Size = new System.Drawing.Size(1212, 665);
            this.pnlCashierMain.TabIndex = 2;
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
            this.label1.Location = new System.Drawing.Point(870, 16);
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
            this.lblAdminName.Location = new System.Drawing.Point(988, 16);
            this.lblAdminName.Name = "lblAdminName";
            this.lblAdminName.Size = new System.Drawing.Size(75, 28);
            this.lblAdminName.TabIndex = 5;
            this.lblAdminName.Text = "Name";
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Manager";
            this.Text = "Cashier";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.AdminLeftPanel.ResumeLayout(false);
            this.pnlAdminUI.ResumeLayout(false);
            this.pnlManagerMain.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel AdminLeftPanel;
        private System.Windows.Forms.Label lblAdminName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnManagerLogout;
        private System.Windows.Forms.Button btnManagerSettings;
        private System.Windows.Forms.Button btnManagerDashBoard;
        private System.Windows.Forms.Panel pnlAdminUI;
        private System.Windows.Forms.Button btnManagerPurchases;
        private System.Windows.Forms.Button btnManFood;
        private System.Windows.Forms.Panel pnlManagerMain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlCashierMain;
        private System.Windows.Forms.Button btnCashierProfile;
    }
}
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
            this.btnAdminLogout = new System.Windows.Forms.Button();
            this.btnAdminSettings = new System.Windows.Forms.Button();
            this.btnDashBoard = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAdminName = new System.Windows.Forms.Label();
            this.pnlAdminUI = new System.Windows.Forms.Panel();
            this.btnPurchases = new System.Windows.Forms.Button();
            this.btnFood = new System.Windows.Forms.Button();
            this.btnEmployees = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlAdminMain = new System.Windows.Forms.Panel();
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
            this.AdminLeftPanel.Controls.Add(this.btnEmployees);
            this.AdminLeftPanel.Controls.Add(this.btnUsers);
            this.AdminLeftPanel.Controls.Add(this.btnPurchases);
            this.AdminLeftPanel.Controls.Add(this.btnFood);
            this.AdminLeftPanel.Controls.Add(this.btnAdminLogout);
            this.AdminLeftPanel.Controls.Add(this.btnAdminSettings);
            this.AdminLeftPanel.Controls.Add(this.btnDashBoard);
            this.AdminLeftPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AdminLeftPanel.Location = new System.Drawing.Point(3, 3);
            this.AdminLeftPanel.Name = "AdminLeftPanel";
            this.AdminLeftPanel.Size = new System.Drawing.Size(126, 723);
            this.AdminLeftPanel.TabIndex = 2;
            this.AdminLeftPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.AdminLeftPanel_Paint);
            // 
            // btnAdminLogout
            // 
            this.btnAdminLogout.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnAdminLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdminLogout.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminLogout.Location = new System.Drawing.Point(3, 312);
            this.btnAdminLogout.Name = "btnAdminLogout";
            this.btnAdminLogout.Size = new System.Drawing.Size(120, 36);
            this.btnAdminLogout.TabIndex = 3;
            this.btnAdminLogout.Text = "Log Out";
            this.btnAdminLogout.UseVisualStyleBackColor = false;
            this.btnAdminLogout.Click += new System.EventHandler(this.btnAdminLogout_Click);
            // 
            // btnAdminSettings
            // 
            this.btnAdminSettings.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminSettings.Location = new System.Drawing.Point(3, 270);
            this.btnAdminSettings.Name = "btnAdminSettings";
            this.btnAdminSettings.Size = new System.Drawing.Size(120, 36);
            this.btnAdminSettings.TabIndex = 2;
            this.btnAdminSettings.Text = "Settings";
            this.btnAdminSettings.UseVisualStyleBackColor = true;
            this.btnAdminSettings.Click += new System.EventHandler(this.btnAdminSettings_Click);
            // 
            // btnDashBoard
            // 
            this.btnDashBoard.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashBoard.Location = new System.Drawing.Point(3, 60);
            this.btnDashBoard.Name = "btnDashBoard";
            this.btnDashBoard.Size = new System.Drawing.Size(120, 36);
            this.btnDashBoard.TabIndex = 0;
            this.btnDashBoard.Text = "Dash Board";
            this.btnDashBoard.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(964, 17);
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
            this.lblAdminName.Location = new System.Drawing.Point(1082, 17);
            this.lblAdminName.Name = "lblAdminName";
            this.lblAdminName.Size = new System.Drawing.Size(75, 28);
            this.lblAdminName.TabIndex = 5;
            this.lblAdminName.Text = "Name";
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
            // btnPurchases
            // 
            this.btnPurchases.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPurchases.Location = new System.Drawing.Point(3, 228);
            this.btnPurchases.Name = "btnPurchases";
            this.btnPurchases.Size = new System.Drawing.Size(120, 36);
            this.btnPurchases.TabIndex = 7;
            this.btnPurchases.Text = "Purchases";
            this.btnPurchases.UseVisualStyleBackColor = true;
            this.btnPurchases.Click += new System.EventHandler(this.btnPurchases_Click);
            // 
            // btnFood
            // 
            this.btnFood.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFood.Location = new System.Drawing.Point(3, 186);
            this.btnFood.Name = "btnFood";
            this.btnFood.Size = new System.Drawing.Size(120, 36);
            this.btnFood.TabIndex = 6;
            this.btnFood.Text = "Food";
            this.btnFood.UseVisualStyleBackColor = true;
            this.btnFood.Click += new System.EventHandler(this.btnFood_Click);
            // 
            // btnEmployees
            // 
            this.btnEmployees.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployees.Location = new System.Drawing.Point(3, 144);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Size = new System.Drawing.Size(120, 36);
            this.btnEmployees.TabIndex = 9;
            this.btnEmployees.Text = "Employees";
            this.btnEmployees.UseVisualStyleBackColor = true;
            this.btnEmployees.Click += new System.EventHandler(this.btnEmployees_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsers.Location = new System.Drawing.Point(3, 102);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(120, 36);
            this.btnUsers.TabIndex = 8;
            this.btnUsers.Text = "Users";
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.Click += new System.EventHandler(this.button4_Click);
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
            // pnlAdminMain
            // 
            this.pnlAdminMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAdminMain.Location = new System.Drawing.Point(0, 58);
            this.pnlAdminMain.Name = "pnlAdminMain";
            this.pnlAdminMain.Size = new System.Drawing.Size(1212, 665);
            this.pnlAdminMain.TabIndex = 1;
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
        private System.Windows.Forms.Button btnAdminSettings;
        private System.Windows.Forms.Button btnDashBoard;
        private System.Windows.Forms.Panel pnlAdminUI;
        private System.Windows.Forms.Button btnEmployees;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnPurchases;
        private System.Windows.Forms.Button btnFood;
        private System.Windows.Forms.Panel pnlAdminMain;
        private System.Windows.Forms.Panel panel1;
    }
}
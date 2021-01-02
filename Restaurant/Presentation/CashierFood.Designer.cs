namespace Restaurant.Presentation
{
    partial class CashierFood
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbxCFoodSearch = new System.Windows.Forms.TextBox();
            this.btnCFoodStockSearch = new System.Windows.Forms.Button();
            this.btnCFoodFrsh = new System.Windows.Forms.Button();
            this.dGVCashierFoodStock = new System.Windows.Forms.DataGridView();
            this.FoodStock = new System.Windows.Forms.Label();
            this.FoodItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVCashierFoodStock)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.59649F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.40351F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1212, 723);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.FoodStock);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(279, 717);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.dGVCashierFoodStock, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(288, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.344491F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.65551F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(921, 717);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Controls.Add(this.tbxCFoodSearch);
            this.panel2.Controls.Add(this.btnCFoodStockSearch);
            this.panel2.Controls.Add(this.btnCFoodFrsh);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(915, 61);
            this.panel2.TabIndex = 0;
            // 
            // tbxCFoodSearch
            // 
            this.tbxCFoodSearch.Location = new System.Drawing.Point(15, 12);
            this.tbxCFoodSearch.Multiline = true;
            this.tbxCFoodSearch.Name = "tbxCFoodSearch";
            this.tbxCFoodSearch.Size = new System.Drawing.Size(222, 37);
            this.tbxCFoodSearch.TabIndex = 46;
            // 
            // btnCFoodStockSearch
            // 
            this.btnCFoodStockSearch.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnCFoodStockSearch.Location = new System.Drawing.Point(253, 12);
            this.btnCFoodStockSearch.Name = "btnCFoodStockSearch";
            this.btnCFoodStockSearch.Size = new System.Drawing.Size(98, 37);
            this.btnCFoodStockSearch.TabIndex = 45;
            this.btnCFoodStockSearch.Text = "Search";
            this.btnCFoodStockSearch.UseVisualStyleBackColor = false;
            // 
            // btnCFoodFrsh
            // 
            this.btnCFoodFrsh.BackColor = System.Drawing.Color.LimeGreen;
            this.btnCFoodFrsh.Location = new System.Drawing.Point(813, 12);
            this.btnCFoodFrsh.Name = "btnCFoodFrsh";
            this.btnCFoodFrsh.Size = new System.Drawing.Size(98, 37);
            this.btnCFoodFrsh.TabIndex = 43;
            this.btnCFoodFrsh.Text = "Refresh";
            this.btnCFoodFrsh.UseVisualStyleBackColor = false;
            // 
            // dGVCashierFoodStock
            // 
            this.dGVCashierFoodStock.AllowUserToAddRows = false;
            this.dGVCashierFoodStock.AllowUserToDeleteRows = false;
            this.dGVCashierFoodStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVCashierFoodStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FoodItem,
            this.Price,
            this.Qty});
            this.dGVCashierFoodStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGVCashierFoodStock.Location = new System.Drawing.Point(3, 70);
            this.dGVCashierFoodStock.Name = "dGVCashierFoodStock";
            this.dGVCashierFoodStock.ReadOnly = true;
            this.dGVCashierFoodStock.Size = new System.Drawing.Size(915, 644);
            this.dGVCashierFoodStock.TabIndex = 1;
            // 
            // FoodStock
            // 
            this.FoodStock.AutoSize = true;
            this.FoodStock.Font = new System.Drawing.Font("Cambria", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FoodStock.Location = new System.Drawing.Point(47, 23);
            this.FoodStock.Name = "FoodStock";
            this.FoodStock.Size = new System.Drawing.Size(192, 41);
            this.FoodStock.TabIndex = 0;
            this.FoodStock.Text = "Food Stock";
            // 
            // FoodItem
            // 
            this.FoodItem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FoodItem.HeaderText = "FoodItem";
            this.FoodItem.Name = "FoodItem";
            this.FoodItem.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Qty
            // 
            this.Qty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Qty.HeaderText = "Qty";
            this.Qty.Name = "Qty";
            this.Qty.ReadOnly = true;
            // 
            // CashierFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "CashierFood";
            this.Size = new System.Drawing.Size(1212, 723);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVCashierFoodStock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCFoodStockSearch;
        private System.Windows.Forms.Button btnCFoodFrsh;
        private System.Windows.Forms.TextBox tbxCFoodSearch;
        private System.Windows.Forms.DataGridView dGVCashierFoodStock;
        private System.Windows.Forms.Label FoodStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoodItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
    }
}

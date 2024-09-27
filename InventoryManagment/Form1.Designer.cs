namespace InventoryManagment
{
    partial class Form1
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
            groupBox1 = new GroupBox();
            cmbxInventory = new ComboBox();
            txtDescription = new TextBox();
            txtWeight = new TextBox();
            txtPrice = new TextBox();
            txtStkQnty = new TextBox();
            txtBrand = new TextBox();
            txtProductName = new TextBox();
            btnClear = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnSave = new Button();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            lblShowCode = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            label10 = new Label();
            btnSearch = new Button();
            txtSearch = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmbxInventory);
            groupBox1.Controls.Add(txtDescription);
            groupBox1.Controls.Add(txtWeight);
            groupBox1.Controls.Add(txtPrice);
            groupBox1.Controls.Add(txtStkQnty);
            groupBox1.Controls.Add(txtBrand);
            groupBox1.Controls.Add(txtProductName);
            groupBox1.Controls.Add(btnClear);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(btnUpdate);
            groupBox1.Controls.Add(btnSave);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(lblShowCode);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 138);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(540, 572);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Inventory";
            // 
            // cmbxInventory
            // 
            cmbxInventory.FormattingEnabled = true;
            cmbxInventory.Items.AddRange(new object[] { "In Stock ", "Out Of Stock" });
            cmbxInventory.Location = new Point(25, 289);
            cmbxInventory.Name = "cmbxInventory";
            cmbxInventory.Size = new Size(189, 27);
            cmbxInventory.TabIndex = 3;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(23, 367);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(488, 96);
            txtDescription.TabIndex = 2;
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(277, 289);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(191, 27);
            txtWeight.TabIndex = 2;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(277, 218);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(191, 27);
            txtPrice.TabIndex = 2;
            // 
            // txtStkQnty
            // 
            txtStkQnty.Location = new Point(23, 218);
            txtStkQnty.Name = "txtStkQnty";
            txtStkQnty.Size = new Size(191, 27);
            txtStkQnty.TabIndex = 2;
            // 
            // txtBrand
            // 
            txtBrand.Location = new Point(277, 149);
            txtBrand.Name = "txtBrand";
            txtBrand.Size = new Size(191, 27);
            txtBrand.TabIndex = 2;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(19, 149);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(191, 27);
            txtProductName.TabIndex = 2;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(420, 490);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(91, 44);
            btnClear.TabIndex = 1;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(294, 490);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(91, 44);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(154, 490);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(91, 44);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(23, 490);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(91, 44);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(19, 333);
            label9.Name = "label9";
            label9.Size = new Size(99, 19);
            label9.TabIndex = 0;
            label9.Text = "Description :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(277, 266);
            label8.Name = "label8";
            label8.Size = new Size(58, 19);
            label8.TabIndex = 0;
            label8.Text = "Weight";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(19, 266);
            label7.Name = "label7";
            label7.Size = new Size(73, 19);
            label7.TabIndex = 0;
            label7.Text = "Inventory";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(277, 195);
            label6.Name = "label6";
            label6.Size = new Size(46, 19);
            label6.TabIndex = 0;
            label6.Text = "Price";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 195);
            label5.Name = "label5";
            label5.Size = new Size(119, 19);
            label5.TabIndex = 0;
            label5.Text = "Stock Quantity :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(277, 126);
            label4.Name = "label4";
            label4.Size = new Size(49, 19);
            label4.TabIndex = 0;
            label4.Text = "Brand";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 126);
            label3.Name = "label3";
            label3.Size = new Size(116, 19);
            label3.TabIndex = 0;
            label3.Text = "Product Name :";
            // 
            // lblShowCode
            // 
            lblShowCode.AutoSize = true;
            lblShowCode.Location = new Point(132, 50);
            lblShowCode.Name = "lblShowCode";
            lblShowCode.Size = new Size(45, 19);
            lblShowCode.TabIndex = 0;
            lblShowCode.Text = "Code";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 50);
            label1.Name = "label1";
            label1.Size = new Size(112, 19);
            label1.TabIndex = 0;
            label1.Text = "Product Code :";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(596, 140);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(922, 572);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellClick;
            // 
            // label10
            // 
            label10.BackColor = SystemColors.ActiveCaption;
            label10.Dock = DockStyle.Top;
            label10.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(0, 0);
            label10.Name = "label10";
            label10.Size = new Size(1553, 53);
            label10.TabIndex = 2;
            label10.Text = "Inventory Managment ";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(596, 105);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(696, 105);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(220, 27);
            txtSearch.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1553, 722);
            Controls.Add(btnSearch);
            Controls.Add(label10);
            Controls.Add(txtSearch);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtDescription;
        private TextBox txtWeight;
        private TextBox txtPrice;
        private TextBox txtStkQnty;
        private TextBox txtBrand;
        private TextBox txtProductName;
        private Button btnClear;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnSave;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label lblShowCode;
        private Label label1;
        private DataGridView dataGridView1;
        private Label label10;
        private ComboBox cmbxInventory;
        private Button btnSearch;
        private TextBox txtSearch;
    }
}

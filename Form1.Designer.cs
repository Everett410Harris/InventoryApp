namespace AppInventory
{
    partial class InventoryManagement
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
            this.mainLbl = new System.Windows.Forms.Label();
            this.inventoryDGV = new System.Windows.Forms.DataGridView();
            this.newBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.skuLbl = new System.Windows.Forms.Label();
            this.priceTb = new System.Windows.Forms.TextBox();
            this.descriptionTb = new System.Windows.Forms.TextBox();
            this.quantityTb = new System.Windows.Forms.TextBox();
            this.skuTb = new System.Windows.Forms.TextBox();
            this.nameTb = new System.Windows.Forms.TextBox();
            this.categoryCB = new System.Windows.Forms.ComboBox();
            this.priceLbl = new System.Windows.Forms.Label();
            this.nameLbl = new System.Windows.Forms.Label();
            this.descriptionLbl = new System.Windows.Forms.Label();
            this.categoryLbl = new System.Windows.Forms.Label();
            this.quantityLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // mainLbl
            // 
            this.mainLbl.Font = new System.Drawing.Font("Georgia", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mainLbl.Location = new System.Drawing.Point(12, 9);
            this.mainLbl.Name = "mainLbl";
            this.mainLbl.Size = new System.Drawing.Size(1310, 78);
            this.mainLbl.TabIndex = 0;
            this.mainLbl.Text = "Inventory Management System";
            this.mainLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // inventoryDGV
            // 
            this.inventoryDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.inventoryDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inventoryDGV.Location = new System.Drawing.Point(12, 350);
            this.inventoryDGV.Name = "inventoryDGV";
            this.inventoryDGV.RowTemplate.Height = 25;
            this.inventoryDGV.Size = new System.Drawing.Size(1290, 434);
            this.inventoryDGV.TabIndex = 1;
            this.inventoryDGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.inventoryDGV_CellDoubleClick);
            // 
            // newBtn
            // 
            this.newBtn.BackColor = System.Drawing.Color.White;
            this.newBtn.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.newBtn.Location = new System.Drawing.Point(12, 299);
            this.newBtn.Name = "newBtn";
            this.newBtn.Size = new System.Drawing.Size(426, 45);
            this.newBtn.TabIndex = 2;
            this.newBtn.Text = "New";
            this.newBtn.UseVisualStyleBackColor = false;
            this.newBtn.Click += new System.EventHandler(this.newBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.White;
            this.saveBtn.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.saveBtn.Location = new System.Drawing.Point(444, 299);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(426, 45);
            this.saveBtn.TabIndex = 3;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.White;
            this.deleteBtn.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deleteBtn.Location = new System.Drawing.Point(876, 299);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(426, 45);
            this.deleteBtn.TabIndex = 4;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // skuLbl
            // 
            this.skuLbl.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.skuLbl.Location = new System.Drawing.Point(12, 186);
            this.skuLbl.Name = "skuLbl";
            this.skuLbl.Size = new System.Drawing.Size(100, 23);
            this.skuLbl.TabIndex = 5;
            this.skuLbl.Text = "SKU:";
            // 
            // priceTb
            // 
            this.priceTb.Location = new System.Drawing.Point(12, 270);
            this.priceTb.Name = "priceTb";
            this.priceTb.Size = new System.Drawing.Size(426, 23);
            this.priceTb.TabIndex = 6;
            // 
            // descriptionTb
            // 
            this.descriptionTb.Location = new System.Drawing.Point(444, 270);
            this.descriptionTb.Name = "descriptionTb";
            this.descriptionTb.Size = new System.Drawing.Size(426, 23);
            this.descriptionTb.TabIndex = 7;
            // 
            // quantityTb
            // 
            this.quantityTb.Location = new System.Drawing.Point(876, 270);
            this.quantityTb.Name = "quantityTb";
            this.quantityTb.Size = new System.Drawing.Size(426, 23);
            this.quantityTb.TabIndex = 8;
            // 
            // skuTb
            // 
            this.skuTb.Location = new System.Drawing.Point(12, 212);
            this.skuTb.Name = "skuTb";
            this.skuTb.Size = new System.Drawing.Size(426, 23);
            this.skuTb.TabIndex = 9;
            // 
            // nameTb
            // 
            this.nameTb.Location = new System.Drawing.Point(444, 212);
            this.nameTb.Name = "nameTb";
            this.nameTb.Size = new System.Drawing.Size(426, 23);
            this.nameTb.TabIndex = 10;
            // 
            // categoryCB
            // 
            this.categoryCB.FormattingEnabled = true;
            this.categoryCB.Items.AddRange(new object[] {
            "Furniture",
            "Lamps",
            "Kitchenware",
            "Tables",
            "Bathroom Decor"});
            this.categoryCB.Location = new System.Drawing.Point(876, 212);
            this.categoryCB.Name = "categoryCB";
            this.categoryCB.Size = new System.Drawing.Size(426, 23);
            this.categoryCB.TabIndex = 11;
            // 
            // priceLbl
            // 
            this.priceLbl.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.priceLbl.Location = new System.Drawing.Point(12, 244);
            this.priceLbl.Name = "priceLbl";
            this.priceLbl.Size = new System.Drawing.Size(100, 23);
            this.priceLbl.TabIndex = 12;
            this.priceLbl.Text = "Price:";
            // 
            // nameLbl
            // 
            this.nameLbl.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nameLbl.Location = new System.Drawing.Point(444, 186);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(100, 23);
            this.nameLbl.TabIndex = 13;
            this.nameLbl.Text = "Name:";
            // 
            // descriptionLbl
            // 
            this.descriptionLbl.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.descriptionLbl.Location = new System.Drawing.Point(444, 244);
            this.descriptionLbl.Name = "descriptionLbl";
            this.descriptionLbl.Size = new System.Drawing.Size(115, 23);
            this.descriptionLbl.TabIndex = 14;
            this.descriptionLbl.Text = "Description:";
            // 
            // categoryLbl
            // 
            this.categoryLbl.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.categoryLbl.Location = new System.Drawing.Point(876, 186);
            this.categoryLbl.Name = "categoryLbl";
            this.categoryLbl.Size = new System.Drawing.Size(100, 23);
            this.categoryLbl.TabIndex = 15;
            this.categoryLbl.Text = "Category:";
            // 
            // quantityLbl
            // 
            this.quantityLbl.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.quantityLbl.Location = new System.Drawing.Point(876, 244);
            this.quantityLbl.Name = "quantityLbl";
            this.quantityLbl.Size = new System.Drawing.Size(100, 23);
            this.quantityLbl.TabIndex = 16;
            this.quantityLbl.Text = "Quantity:";
            // 
            // InventoryManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(1314, 796);
            this.Controls.Add(this.quantityLbl);
            this.Controls.Add(this.categoryLbl);
            this.Controls.Add(this.descriptionLbl);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.priceLbl);
            this.Controls.Add(this.categoryCB);
            this.Controls.Add(this.nameTb);
            this.Controls.Add(this.skuTb);
            this.Controls.Add(this.quantityTb);
            this.Controls.Add(this.descriptionTb);
            this.Controls.Add(this.priceTb);
            this.Controls.Add(this.skuLbl);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.newBtn);
            this.Controls.Add(this.inventoryDGV);
            this.Controls.Add(this.mainLbl);
            this.Name = "InventoryManagement";
            this.Text = "Inventory Management";
            this.Load += new System.EventHandler(this.InventoryManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label mainLbl;
        private DataGridView inventoryDGV;
        private Button newBtn;
        private Button saveBtn;
        private Button deleteBtn;
        private Label skuLbl;
        private TextBox priceTb;
        private TextBox descriptionTb;
        private TextBox quantityTb;
        private TextBox skuTb;
        private TextBox nameTb;
        private ComboBox categoryCB;
        private Label priceLbl;
        private Label nameLbl;
        private Label descriptionLbl;
        private Label categoryLbl;
        private Label quantityLbl;
    }
}
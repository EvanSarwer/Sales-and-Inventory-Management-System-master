﻿namespace Sales_and_Inventory_Management_System.Presentation_Layer
{
    partial class ProductManagement
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DeleteProductButton = new System.Windows.Forms.Button();
            this.UpdateProductButton = new System.Windows.Forms.Button();
            this.productCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.productQuantityTextBox = new System.Windows.Forms.TextBox();
            this.productPriceTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addProductButton = new System.Windows.Forms.Button();
            this.productNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.loadProductListGridView = new System.Windows.Forms.DataGridView();
            this.backToHomeButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.searchProductNameTextBox = new System.Windows.Forms.TextBox();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.addProductQuantityTextBox = new System.Windows.Forms.TextBox();
            this.addProductQuantityButton = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.loadInsufficientQuantityProductsListGridView = new System.Windows.Forms.DataGridView();
            this.searchByQuantityNumberTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.addQuantityProductNameTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loadProductListGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loadInsufficientQuantityProductsListGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DeleteProductButton);
            this.groupBox1.Controls.Add(this.UpdateProductButton);
            this.groupBox1.Controls.Add(this.productCategoryComboBox);
            this.groupBox1.Controls.Add(this.productQuantityTextBox);
            this.groupBox1.Controls.Add(this.productPriceTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.addProductButton);
            this.groupBox1.Controls.Add(this.productNameTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(91, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(448, 327);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product Add/Update/Delete";
            // 
            // DeleteProductButton
            // 
            this.DeleteProductButton.Location = new System.Drawing.Point(307, 265);
            this.DeleteProductButton.Name = "DeleteProductButton";
            this.DeleteProductButton.Size = new System.Drawing.Size(95, 30);
            this.DeleteProductButton.TabIndex = 10;
            this.DeleteProductButton.Text = "Delete";
            this.DeleteProductButton.UseVisualStyleBackColor = true;
            this.DeleteProductButton.Click += new System.EventHandler(this.DeleteProductButton_Click);
            // 
            // UpdateProductButton
            // 
            this.UpdateProductButton.Location = new System.Drawing.Point(190, 265);
            this.UpdateProductButton.Name = "UpdateProductButton";
            this.UpdateProductButton.Size = new System.Drawing.Size(95, 30);
            this.UpdateProductButton.TabIndex = 9;
            this.UpdateProductButton.Text = "Update";
            this.UpdateProductButton.UseVisualStyleBackColor = true;
            this.UpdateProductButton.Click += new System.EventHandler(this.UpdateProductButton_Click);
            // 
            // productCategoryComboBox
            // 
            this.productCategoryComboBox.FormattingEnabled = true;
            this.productCategoryComboBox.Location = new System.Drawing.Point(167, 181);
            this.productCategoryComboBox.Name = "productCategoryComboBox";
            this.productCategoryComboBox.Size = new System.Drawing.Size(154, 27);
            this.productCategoryComboBox.TabIndex = 8;
            // 
            // productQuantityTextBox
            // 
            this.productQuantityTextBox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productQuantityTextBox.Location = new System.Drawing.Point(167, 135);
            this.productQuantityTextBox.Name = "productQuantityTextBox";
            this.productQuantityTextBox.Size = new System.Drawing.Size(154, 26);
            this.productQuantityTextBox.TabIndex = 7;
            // 
            // productPriceTextBox
            // 
            this.productPriceTextBox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productPriceTextBox.Location = new System.Drawing.Point(167, 94);
            this.productPriceTextBox.Name = "productPriceTextBox";
            this.productPriceTextBox.Size = new System.Drawing.Size(154, 26);
            this.productPriceTextBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Category";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Quantity";
            // 
            // addProductButton
            // 
            this.addProductButton.Location = new System.Drawing.Point(50, 265);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(117, 30);
            this.addProductButton.TabIndex = 2;
            this.addProductButton.Text = "Add Product";
            this.addProductButton.UseVisualStyleBackColor = true;
            this.addProductButton.Click += new System.EventHandler(this.addProductButton_Click);
            // 
            // productNameTextBox
            // 
            this.productNameTextBox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productNameTextBox.Location = new System.Drawing.Point(167, 53);
            this.productNameTextBox.Name = "productNameTextBox";
            this.productNameTextBox.Size = new System.Drawing.Size(154, 26);
            this.productNameTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Name";
            // 
            // loadProductListGridView
            // 
            this.loadProductListGridView.AllowUserToAddRows = false;
            this.loadProductListGridView.AllowUserToDeleteRows = false;
            this.loadProductListGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.loadProductListGridView.Location = new System.Drawing.Point(31, 89);
            this.loadProductListGridView.Name = "loadProductListGridView";
            this.loadProductListGridView.ReadOnly = true;
            this.loadProductListGridView.Size = new System.Drawing.Size(453, 232);
            this.loadProductListGridView.TabIndex = 1;
            this.loadProductListGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.loadProductListGridView_CellClick);
            // 
            // backToHomeButton
            // 
            this.backToHomeButton.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backToHomeButton.Location = new System.Drawing.Point(91, 22);
            this.backToHomeButton.Name = "backToHomeButton";
            this.backToHomeButton.Size = new System.Drawing.Size(97, 31);
            this.backToHomeButton.TabIndex = 2;
            this.backToHomeButton.Text = "Home";
            this.backToHomeButton.UseVisualStyleBackColor = true;
            this.backToHomeButton.Click += new System.EventHandler(this.backToHomeButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(61, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 19);
            this.label6.TabIndex = 9;
            this.label6.Text = "Search by Product Name";
            // 
            // searchProductNameTextBox
            // 
            this.searchProductNameTextBox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchProductNameTextBox.Location = new System.Drawing.Point(266, 45);
            this.searchProductNameTextBox.Name = "searchProductNameTextBox";
            this.searchProductNameTextBox.Size = new System.Drawing.Size(172, 26);
            this.searchProductNameTextBox.TabIndex = 10;
            this.searchProductNameTextBox.TextChanged += new System.EventHandler(this.searchProductNameTextBox_TextChanged);
            // 
            // RefreshButton
            // 
            this.RefreshButton.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefreshButton.Location = new System.Drawing.Point(959, 34);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(76, 31);
            this.RefreshButton.TabIndex = 11;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.loadProductListGridView);
            this.groupBox2.Controls.Add(this.searchProductNameTextBox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(568, 82);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(512, 327);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "List of Products";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.addQuantityProductNameTextBox);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.addProductQuantityButton);
            this.groupBox3.Controls.Add(this.addProductQuantityTextBox);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(91, 443);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(448, 269);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Add Quantity of Products";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(71, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Quantity";
            // 
            // addProductQuantityTextBox
            // 
            this.addProductQuantityTextBox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductQuantityTextBox.Location = new System.Drawing.Point(209, 112);
            this.addProductQuantityTextBox.Name = "addProductQuantityTextBox";
            this.addProductQuantityTextBox.Size = new System.Drawing.Size(154, 26);
            this.addProductQuantityTextBox.TabIndex = 11;
            // 
            // addProductQuantityButton
            // 
            this.addProductQuantityButton.Location = new System.Drawing.Point(209, 159);
            this.addProductQuantityButton.Name = "addProductQuantityButton";
            this.addProductQuantityButton.Size = new System.Drawing.Size(153, 30);
            this.addProductQuantityButton.TabIndex = 11;
            this.addProductQuantityButton.Text = "Add Quantity";
            this.addProductQuantityButton.UseVisualStyleBackColor = true;
            this.addProductQuantityButton.Click += new System.EventHandler(this.addProductQuantityButton_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.searchByQuantityNumberTextBox);
            this.groupBox4.Controls.Add(this.loadInsufficientQuantityProductsListGridView);
            this.groupBox4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(568, 415);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(568, 322);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Insufficient Quantity of Products";
            // 
            // loadInsufficientQuantityProductsListGridView
            // 
            this.loadInsufficientQuantityProductsListGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.loadInsufficientQuantityProductsListGridView.Location = new System.Drawing.Point(21, 89);
            this.loadInsufficientQuantityProductsListGridView.Name = "loadInsufficientQuantityProductsListGridView";
            this.loadInsufficientQuantityProductsListGridView.Size = new System.Drawing.Size(532, 227);
            this.loadInsufficientQuantityProductsListGridView.TabIndex = 0;
            this.loadInsufficientQuantityProductsListGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.loadInsufficientQuantityProductsListGridView_CellClick);
            // 
            // searchByQuantityNumberTextBox
            // 
            this.searchByQuantityNumberTextBox.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchByQuantityNumberTextBox.Location = new System.Drawing.Point(340, 42);
            this.searchByQuantityNumberTextBox.Name = "searchByQuantityNumberTextBox";
            this.searchByQuantityNumberTextBox.Size = new System.Drawing.Size(98, 25);
            this.searchByQuantityNumberTextBox.TabIndex = 12;
            this.searchByQuantityNumberTextBox.Text = "10";
            this.searchByQuantityNumberTextBox.TextChanged += new System.EventHandler(this.searchByQuantityNumberTextBox_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(62, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(255, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Products which have Quantity less than";
            // 
            // addQuantityProductNameTextBox
            // 
            this.addQuantityProductNameTextBox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addQuantityProductNameTextBox.Location = new System.Drawing.Point(209, 61);
            this.addQuantityProductNameTextBox.Name = "addQuantityProductNameTextBox";
            this.addQuantityProductNameTextBox.Size = new System.Drawing.Size(154, 26);
            this.addQuantityProductNameTextBox.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(71, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 19);
            this.label8.TabIndex = 11;
            this.label8.Text = "Product Name";
            // 
            // ProductManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1159, 749);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.backToHomeButton);
            this.Controls.Add(this.groupBox1);
            this.Name = "ProductManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Management";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProductManagement_FormClosing);
            this.Load += new System.EventHandler(this.ProductManagement_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loadProductListGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loadInsufficientQuantityProductsListGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox productCategoryComboBox;
        private System.Windows.Forms.TextBox productQuantityTextBox;
        private System.Windows.Forms.TextBox productPriceTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addProductButton;
        private System.Windows.Forms.TextBox productNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView loadProductListGridView;
        private System.Windows.Forms.Button backToHomeButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox searchProductNameTextBox;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.Button DeleteProductButton;
        private System.Windows.Forms.Button UpdateProductButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button addProductQuantityButton;
        private System.Windows.Forms.TextBox addProductQuantityTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView loadInsufficientQuantityProductsListGridView;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox searchByQuantityNumberTextBox;
        private System.Windows.Forms.TextBox addQuantityProductNameTextBox;
        private System.Windows.Forms.Label label8;
    }
}
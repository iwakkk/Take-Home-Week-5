namespace Take_Home_Week_5
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_namabaru = new System.Windows.Forms.TextBox();
            this.combo_category = new System.Windows.Forms.ComboBox();
            this.txt_hargabaru = new System.Windows.Forms.TextBox();
            this.txt_stockbaru = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dgv_category = new System.Windows.Forms.DataGridView();
            this.dgv_product = new System.Windows.Forms.DataGridView();
            this.txt_namacategory = new System.Windows.Forms.TextBox();
            this.combo_filter = new System.Windows.Forms.ComboBox();
            this.btn_addcategory = new System.Windows.Forms.Button();
            this.btn_removecategory = new System.Windows.Forms.Button();
            this.btn_addproduct = new System.Windows.Forms.Button();
            this.btn_editproduct = new System.Windows.Forms.Button();
            this.btn_removeproduct = new System.Windows.Forms.Button();
            this.btn_showall = new System.Windows.Forms.Button();
            this.btn_showfilter = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_category)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(524, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Category";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Details";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label4.Location = new System.Drawing.Point(26, 313);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nama :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 341);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Categroy :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 369);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Harga :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 401);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Stock :";
            // 
            // txt_namabaru
            // 
            this.txt_namabaru.Location = new System.Drawing.Point(82, 313);
            this.txt_namabaru.Name = "txt_namabaru";
            this.txt_namabaru.Size = new System.Drawing.Size(264, 22);
            this.txt_namabaru.TabIndex = 7;
            // 
            // combo_category
            // 
            this.combo_category.FormattingEnabled = true;
            this.combo_category.Location = new System.Drawing.Point(82, 341);
            this.combo_category.Name = "combo_category";
            this.combo_category.Size = new System.Drawing.Size(121, 24);
            this.combo_category.TabIndex = 8;
            // 
            // txt_hargabaru
            // 
            this.txt_hargabaru.Location = new System.Drawing.Point(82, 371);
            this.txt_hargabaru.Name = "txt_hargabaru";
            this.txt_hargabaru.Size = new System.Drawing.Size(121, 22);
            this.txt_hargabaru.TabIndex = 9;
            this.txt_hargabaru.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_hargabaru_KeyPress);
            // 
            // txt_stockbaru
            // 
            this.txt_stockbaru.Location = new System.Drawing.Point(82, 401);
            this.txt_stockbaru.Name = "txt_stockbaru";
            this.txt_stockbaru.Size = new System.Drawing.Size(121, 22);
            this.txt_stockbaru.TabIndex = 10;
            this.txt_stockbaru.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_stockbaru_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label8.Location = new System.Drawing.Point(526, 283);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 16);
            this.label8.TabIndex = 11;
            this.label8.Text = "Nama :";
            // 
            // dgv_category
            // 
            this.dgv_category.AllowUserToAddRows = false;
            this.dgv_category.AllowUserToDeleteRows = false;
            this.dgv_category.AllowUserToResizeColumns = false;
            this.dgv_category.AllowUserToResizeRows = false;
            this.dgv_category.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_category.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_category.Location = new System.Drawing.Point(529, 58);
            this.dgv_category.Name = "dgv_category";
            this.dgv_category.RowHeadersVisible = false;
            this.dgv_category.RowHeadersWidth = 51;
            this.dgv_category.RowTemplate.Height = 24;
            this.dgv_category.Size = new System.Drawing.Size(242, 199);
            this.dgv_category.TabIndex = 12;
            // 
            // dgv_product
            // 
            this.dgv_product.AllowDrop = true;
            this.dgv_product.AllowUserToAddRows = false;
            this.dgv_product.AllowUserToDeleteRows = false;
            this.dgv_product.AllowUserToOrderColumns = true;
            this.dgv_product.AllowUserToResizeColumns = false;
            this.dgv_product.AllowUserToResizeRows = false;
            this.dgv_product.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_product.Location = new System.Drawing.Point(22, 58);
            this.dgv_product.Name = "dgv_product";
            this.dgv_product.RowHeadersVisible = false;
            this.dgv_product.RowHeadersWidth = 51;
            this.dgv_product.RowTemplate.Height = 24;
            this.dgv_product.Size = new System.Drawing.Size(433, 199);
            this.dgv_product.TabIndex = 13;
            this.dgv_product.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_product_CellMouseClick);
            // 
            // txt_namacategory
            // 
            this.txt_namacategory.Location = new System.Drawing.Point(582, 283);
            this.txt_namacategory.Name = "txt_namacategory";
            this.txt_namacategory.Size = new System.Drawing.Size(189, 22);
            this.txt_namacategory.TabIndex = 14;
            // 
            // combo_filter
            // 
            this.combo_filter.Enabled = false;
            this.combo_filter.FormattingEnabled = true;
            this.combo_filter.Location = new System.Drawing.Point(247, 19);
            this.combo_filter.Name = "combo_filter";
            this.combo_filter.Size = new System.Drawing.Size(100, 24);
            this.combo_filter.TabIndex = 15;
            this.combo_filter.SelectedIndexChanged += new System.EventHandler(this.combo_filter_SelectedIndexChanged);
            this.combo_filter.SelectionChangeCommitted += new System.EventHandler(this.combo_filter_SelectionChangeCommitted);
            // 
            // btn_addcategory
            // 
            this.btn_addcategory.Location = new System.Drawing.Point(607, 313);
            this.btn_addcategory.Name = "btn_addcategory";
            this.btn_addcategory.Size = new System.Drawing.Size(79, 46);
            this.btn_addcategory.TabIndex = 16;
            this.btn_addcategory.Text = "Add Category";
            this.btn_addcategory.UseVisualStyleBackColor = true;
            this.btn_addcategory.Click += new System.EventHandler(this.btn_addcategory_Click);
            // 
            // btn_removecategory
            // 
            this.btn_removecategory.Location = new System.Drawing.Point(692, 313);
            this.btn_removecategory.Name = "btn_removecategory";
            this.btn_removecategory.Size = new System.Drawing.Size(79, 46);
            this.btn_removecategory.TabIndex = 17;
            this.btn_removecategory.Text = "Remove Category";
            this.btn_removecategory.UseVisualStyleBackColor = true;
            this.btn_removecategory.Click += new System.EventHandler(this.btn_removecategory_Click);
            // 
            // btn_addproduct
            // 
            this.btn_addproduct.Location = new System.Drawing.Point(227, 377);
            this.btn_addproduct.Name = "btn_addproduct";
            this.btn_addproduct.Size = new System.Drawing.Size(79, 46);
            this.btn_addproduct.TabIndex = 18;
            this.btn_addproduct.Text = "Add Product";
            this.btn_addproduct.UseVisualStyleBackColor = true;
            this.btn_addproduct.Click += new System.EventHandler(this.btn_addproduct_Click);
            // 
            // btn_editproduct
            // 
            this.btn_editproduct.Location = new System.Drawing.Point(312, 377);
            this.btn_editproduct.Name = "btn_editproduct";
            this.btn_editproduct.Size = new System.Drawing.Size(79, 46);
            this.btn_editproduct.TabIndex = 19;
            this.btn_editproduct.Text = "Edit Product";
            this.btn_editproduct.UseVisualStyleBackColor = true;
            this.btn_editproduct.Click += new System.EventHandler(this.btn_editproduct_Click);
            // 
            // btn_removeproduct
            // 
            this.btn_removeproduct.Location = new System.Drawing.Point(397, 377);
            this.btn_removeproduct.Name = "btn_removeproduct";
            this.btn_removeproduct.Size = new System.Drawing.Size(79, 46);
            this.btn_removeproduct.TabIndex = 20;
            this.btn_removeproduct.Text = "Remove Product";
            this.btn_removeproduct.UseVisualStyleBackColor = true;
            this.btn_removeproduct.Click += new System.EventHandler(this.btn_removeproduct_Click);
            // 
            // btn_showall
            // 
            this.btn_showall.Location = new System.Drawing.Point(131, 19);
            this.btn_showall.Name = "btn_showall";
            this.btn_showall.Size = new System.Drawing.Size(52, 25);
            this.btn_showall.TabIndex = 21;
            this.btn_showall.Text = "All";
            this.btn_showall.UseVisualStyleBackColor = true;
            this.btn_showall.Click += new System.EventHandler(this.btn_showall_Click);
            // 
            // btn_showfilter
            // 
            this.btn_showfilter.Location = new System.Drawing.Point(189, 19);
            this.btn_showfilter.Name = "btn_showfilter";
            this.btn_showfilter.Size = new System.Drawing.Size(52, 25);
            this.btn_showfilter.TabIndex = 22;
            this.btn_showfilter.Text = "Filter";
            this.btn_showfilter.UseVisualStyleBackColor = true;
            this.btn_showfilter.Click += new System.EventHandler(this.btn_showfilter_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Take_Home_Week_5.Properties.Resources.pngegg;
            this.pictureBox1.Location = new System.Drawing.Point(500, 361);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(299, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_showfilter);
            this.Controls.Add(this.btn_showall);
            this.Controls.Add(this.btn_removeproduct);
            this.Controls.Add(this.btn_editproduct);
            this.Controls.Add(this.btn_addproduct);
            this.Controls.Add(this.btn_removecategory);
            this.Controls.Add(this.btn_addcategory);
            this.Controls.Add(this.combo_filter);
            this.Controls.Add(this.txt_namacategory);
            this.Controls.Add(this.dgv_product);
            this.Controls.Add(this.dgv_category);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_stockbaru);
            this.Controls.Add(this.txt_hargabaru);
            this.Controls.Add(this.combo_category);
            this.Controls.Add(this.txt_namabaru);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_category)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_namabaru;
        private System.Windows.Forms.ComboBox combo_category;
        private System.Windows.Forms.TextBox txt_hargabaru;
        private System.Windows.Forms.TextBox txt_stockbaru;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgv_category;
        private System.Windows.Forms.DataGridView dgv_product;
        private System.Windows.Forms.TextBox txt_namacategory;
        private System.Windows.Forms.ComboBox combo_filter;
        private System.Windows.Forms.Button btn_addcategory;
        private System.Windows.Forms.Button btn_removecategory;
        private System.Windows.Forms.Button btn_addproduct;
        private System.Windows.Forms.Button btn_editproduct;
        private System.Windows.Forms.Button btn_removeproduct;
        private System.Windows.Forms.Button btn_showall;
        private System.Windows.Forms.Button btn_showfilter;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


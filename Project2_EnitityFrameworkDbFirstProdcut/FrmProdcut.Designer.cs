namespace Project2_EnitityFrameworkDbFirstProdcut
{
    partial class FrmProdcut
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
            this.btnList = new System.Windows.Forms.Button();
            this.bntSearch = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProducId = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtProdcutStock = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProductPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbProductCategory = new System.Windows.Forms.ComboBox();
            this.btnProdcutListWhitCategory = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(120, 218);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(81, 32);
            this.btnList.TabIndex = 19;
            this.btnList.Text = "Listele";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // bntSearch
            // 
            this.bntSearch.Location = new System.Drawing.Point(120, 313);
            this.bntSearch.Name = "bntSearch";
            this.bntSearch.Size = new System.Drawing.Size(153, 32);
            this.bntSearch.TabIndex = 18;
            this.bntSearch.Text = "Ara";
            this.bntSearch.UseVisualStyleBackColor = true;
            this.bntSearch.Click += new System.EventHandler(this.bntSearch_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(120, 360);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(153, 32);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(120, 410);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(153, 32);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(120, 64);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(153, 22);
            this.txtProductName.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Ürün İsmi:";
            // 
            // txtProducId
            // 
            this.txtProducId.Location = new System.Drawing.Point(120, 36);
            this.txtProducId.Name = "txtProducId";
            this.txtProducId.Size = new System.Drawing.Size(153, 22);
            this.txtProducId.TabIndex = 13;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(339, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(626, 333);
            this.dataGridView1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ürün ID:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(120, 265);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(153, 32);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtProdcutStock
            // 
            this.txtProdcutStock.Location = new System.Drawing.Point(120, 120);
            this.txtProdcutStock.Name = "txtProdcutStock";
            this.txtProdcutStock.Size = new System.Drawing.Size(153, 22);
            this.txtProdcutStock.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "Ürün Fiyatı:";
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.Location = new System.Drawing.Point(120, 92);
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.Size = new System.Drawing.Size(153, 22);
            this.txtProductPrice.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "Ürün Stok:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 16);
            this.label5.TabIndex = 24;
            this.label5.Text = "Ürün Kategori:";
            // 
            // cmbProductCategory
            // 
            this.cmbProductCategory.FormattingEnabled = true;
            this.cmbProductCategory.Location = new System.Drawing.Point(122, 148);
            this.cmbProductCategory.Name = "cmbProductCategory";
            this.cmbProductCategory.Size = new System.Drawing.Size(151, 24);
            this.cmbProductCategory.TabIndex = 25;
            // 
            // btnProdcutListWhitCategory
            // 
            this.btnProdcutListWhitCategory.Location = new System.Drawing.Point(216, 218);
            this.btnProdcutListWhitCategory.Name = "btnProdcutListWhitCategory";
            this.btnProdcutListWhitCategory.Size = new System.Drawing.Size(81, 32);
            this.btnProdcutListWhitCategory.TabIndex = 26;
            this.btnProdcutListWhitCategory.Text = "Listele";
            this.btnProdcutListWhitCategory.UseVisualStyleBackColor = true;
            this.btnProdcutListWhitCategory.Click += new System.EventHandler(this.btnProdcutListWhitCategory_Click);
            // 
            // FrmProdcut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 450);
            this.Controls.Add(this.btnProdcutListWhitCategory);
            this.Controls.Add(this.cmbProductCategory);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtProdcutStock);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtProductPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.bntSearch);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtProducId);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdd);
            this.Name = "FrmProdcut";
            this.Text = "FrmProdcut";
            this.Load += new System.EventHandler(this.FrmProdcut_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button bntSearch;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProducId;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtProdcutStock;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProductPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbProductCategory;
        private System.Windows.Forms.Button btnProdcutListWhitCategory;
    }
}
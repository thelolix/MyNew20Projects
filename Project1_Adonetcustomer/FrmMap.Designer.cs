namespace Project1_Adonetcustomer
{
    partial class FrmMap
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
            this.btnOpenCityForm = new System.Windows.Forms.Button();
            this.btnCustomerFrom = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpenCityForm
            // 
            this.btnOpenCityForm.Location = new System.Drawing.Point(46, 45);
            this.btnOpenCityForm.Name = "btnOpenCityForm";
            this.btnOpenCityForm.Size = new System.Drawing.Size(170, 41);
            this.btnOpenCityForm.TabIndex = 0;
            this.btnOpenCityForm.Text = "Şehir İşlemleri";
            this.btnOpenCityForm.UseVisualStyleBackColor = true;
            this.btnOpenCityForm.Click += new System.EventHandler(this.btnOpenCityForm_Click);
            // 
            // btnCustomerFrom
            // 
            this.btnCustomerFrom.Location = new System.Drawing.Point(46, 112);
            this.btnCustomerFrom.Name = "btnCustomerFrom";
            this.btnCustomerFrom.Size = new System.Drawing.Size(170, 42);
            this.btnCustomerFrom.TabIndex = 1;
            this.btnCustomerFrom.Text = "Müşteri İşlemleri";
            this.btnCustomerFrom.UseVisualStyleBackColor = true;
            this.btnCustomerFrom.Click += new System.EventHandler(this.btnCustomerFrom_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(46, 182);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(170, 43);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Çıkış Yap";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // FrmMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 333);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCustomerFrom);
            this.Controls.Add(this.btnOpenCityForm);
            this.Name = "FrmMap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formlar";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpenCityForm;
        private System.Windows.Forms.Button btnCustomerFrom;
        private System.Windows.Forms.Button btnExit;
    }
}
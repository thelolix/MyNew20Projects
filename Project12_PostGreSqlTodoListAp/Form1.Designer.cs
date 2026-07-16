namespace Project12_PostGreSqlTodoListAp
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
            this.btnList = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPriority = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rdbTrue = new System.Windows.Forms.RadioButton();
            this.rdbFoulse = new System.Windows.Forms.RadioButton();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAllList = new System.Windows.Forms.Button();
            this.btnCheckedList = new System.Windows.Forms.Button();
            this.btnCountineLsit = new System.Windows.Forms.Button();
            this.cbmCategory = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(31, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "İşlem Id:";
            // 
            // btnList
            // 
            this.btnList.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnList.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnList.Location = new System.Drawing.Point(342, 36);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(144, 35);
            this.btnList.TabIndex = 1;
            this.btnList.Text = "Listele";
            this.btnList.UseVisualStyleBackColor = true;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(106, 37);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(209, 27);
            this.txtId.TabIndex = 2;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(106, 70);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(209, 27);
            this.txtTitle.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(43, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Başlık:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(26, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Kategori:";
            // 
            // txtPriority
            // 
            this.txtPriority.Location = new System.Drawing.Point(106, 136);
            this.txtPriority.Name = "txtPriority";
            this.txtPriority.Size = new System.Drawing.Size(209, 27);
            this.txtPriority.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(32, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Öncelik:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(106, 170);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(209, 164);
            this.txtDescription.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(21, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Açıklama:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(27, 391);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = "Durum:";
            // 
            // rdbTrue
            // 
            this.rdbTrue.AutoSize = true;
            this.rdbTrue.Location = new System.Drawing.Point(87, 391);
            this.rdbTrue.Name = "rdbTrue";
            this.rdbTrue.Size = new System.Drawing.Size(65, 23);
            this.rdbTrue.TabIndex = 13;
            this.rdbTrue.TabStop = true;
            this.rdbTrue.Text = "Yapıldı ";
            this.rdbTrue.UseVisualStyleBackColor = true;
            // 
            // rdbFoulse
            // 
            this.rdbFoulse.AutoSize = true;
            this.rdbFoulse.Location = new System.Drawing.Point(153, 393);
            this.rdbFoulse.Name = "rdbFoulse";
            this.rdbFoulse.Size = new System.Drawing.Size(76, 23);
            this.rdbFoulse.TabIndex = 14;
            this.rdbFoulse.TabStop = true;
            this.rdbFoulse.Text = "Yapılmadı";
            this.rdbFoulse.UseVisualStyleBackColor = true;
            this.rdbFoulse.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCreate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCreate.Location = new System.Drawing.Point(342, 74);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(144, 35);
            this.btnCreate.TabIndex = 15;
            this.btnCreate.Text = "Oluştur";
            this.btnCreate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDelete.Location = new System.Drawing.Point(342, 116);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(144, 35);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnUpdate.Location = new System.Drawing.Point(342, 159);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(144, 35);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnAllList
            // 
            this.btnAllList.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAllList.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAllList.Location = new System.Drawing.Point(342, 202);
            this.btnAllList.Name = "btnAllList";
            this.btnAllList.Size = new System.Drawing.Size(144, 35);
            this.btnAllList.TabIndex = 18;
            this.btnAllList.Text = "Tüm Liste";
            this.btnAllList.UseVisualStyleBackColor = true;
            // 
            // btnCheckedList
            // 
            this.btnCheckedList.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCheckedList.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCheckedList.Location = new System.Drawing.Point(342, 243);
            this.btnCheckedList.Name = "btnCheckedList";
            this.btnCheckedList.Size = new System.Drawing.Size(144, 35);
            this.btnCheckedList.TabIndex = 19;
            this.btnCheckedList.Text = "Tamamlananlar";
            this.btnCheckedList.UseVisualStyleBackColor = true;
            // 
            // btnCountineLsit
            // 
            this.btnCountineLsit.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCountineLsit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCountineLsit.Location = new System.Drawing.Point(342, 285);
            this.btnCountineLsit.Name = "btnCountineLsit";
            this.btnCountineLsit.Size = new System.Drawing.Size(144, 35);
            this.btnCountineLsit.TabIndex = 20;
            this.btnCountineLsit.Text = "Devam Edenler";
            this.btnCountineLsit.UseVisualStyleBackColor = true;
            // 
            // cbmCategory
            // 
            this.cbmCategory.FormattingEnabled = true;
            this.cbmCategory.Location = new System.Drawing.Point(108, 101);
            this.cbmCategory.Name = "cbmCategory";
            this.cbmCategory.Size = new System.Drawing.Size(208, 27);
            this.cbmCategory.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LawnGreen;
            this.ClientSize = new System.Drawing.Size(600, 535);
            this.Controls.Add(this.cbmCategory);
            this.Controls.Add(this.btnCountineLsit);
            this.Controls.Add(this.btnCheckedList);
            this.Controls.Add(this.btnAllList);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.rdbFoulse);
            this.Controls.Add(this.rdbTrue);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPriority);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Rockwell Nova Cond", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Yapılacak Listesi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPriority;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rdbTrue;
        private System.Windows.Forms.RadioButton rdbFoulse;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAllList;
        private System.Windows.Forms.Button btnCheckedList;
        private System.Windows.Forms.Button btnCountineLsit;
        private System.Windows.Forms.ComboBox cbmCategory;
    }
}


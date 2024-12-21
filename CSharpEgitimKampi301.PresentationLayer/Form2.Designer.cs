namespace CSharpEgitimKampi301.PresentationLayer
{
	partial class Form2
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
			this.btnGetById = new System.Windows.Forms.Button();
			this.BtnUpdate = new System.Windows.Forms.Button();
			this.BtnDelete = new System.Windows.Forms.Button();
			this.BtnAdd = new System.Windows.Forms.Button();
			this.txtProductName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.datagridview1 = new System.Windows.Forms.DataGridView();
			this.btnList = new System.Windows.Forms.Button();
			this.txtProductID = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtProductStock = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtProductPrice = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtProductDescription = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.cbxProductCategory = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.datagridview1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnGetById
			// 
			this.btnGetById.Location = new System.Drawing.Point(114, 727);
			this.btnGetById.Name = "btnGetById";
			this.btnGetById.Size = new System.Drawing.Size(198, 54);
			this.btnGetById.TabIndex = 25;
			this.btnGetById.Text = "Id\'ye Göre Getir";
			this.btnGetById.UseVisualStyleBackColor = true;
			// 
			// BtnUpdate
			// 
			this.BtnUpdate.Location = new System.Drawing.Point(114, 667);
			this.BtnUpdate.Name = "BtnUpdate";
			this.BtnUpdate.Size = new System.Drawing.Size(198, 54);
			this.BtnUpdate.TabIndex = 24;
			this.BtnUpdate.Text = "Güncelle";
			this.BtnUpdate.UseVisualStyleBackColor = true;
			this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
			// 
			// BtnDelete
			// 
			this.BtnDelete.Location = new System.Drawing.Point(115, 607);
			this.BtnDelete.Name = "BtnDelete";
			this.BtnDelete.Size = new System.Drawing.Size(198, 54);
			this.BtnDelete.TabIndex = 23;
			this.BtnDelete.Text = "Sil";
			this.BtnDelete.UseVisualStyleBackColor = true;
			this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
			// 
			// BtnAdd
			// 
			this.BtnAdd.Location = new System.Drawing.Point(115, 547);
			this.BtnAdd.Name = "BtnAdd";
			this.BtnAdd.Size = new System.Drawing.Size(198, 54);
			this.BtnAdd.TabIndex = 22;
			this.BtnAdd.Text = "Ekle";
			this.BtnAdd.UseVisualStyleBackColor = true;
			this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
			// 
			// txtProductName
			// 
			this.txtProductName.Location = new System.Drawing.Point(114, 61);
			this.txtProductName.Name = "txtProductName";
			this.txtProductName.Size = new System.Drawing.Size(198, 26);
			this.txtProductName.TabIndex = 18;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(22, 67);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(75, 20);
			this.label2.TabIndex = 17;
			this.label2.Text = "Ürün Adı:";
			// 
			// datagridview1
			// 
			this.datagridview1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
			this.datagridview1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.datagridview1.Location = new System.Drawing.Point(334, 14);
			this.datagridview1.Name = "datagridview1";
			this.datagridview1.RowHeadersWidth = 62;
			this.datagridview1.RowTemplate.Height = 28;
			this.datagridview1.Size = new System.Drawing.Size(995, 761);
			this.datagridview1.TabIndex = 16;
			// 
			// btnList
			// 
			this.btnList.Location = new System.Drawing.Point(114, 487);
			this.btnList.Name = "btnList";
			this.btnList.Size = new System.Drawing.Size(199, 54);
			this.btnList.TabIndex = 15;
			this.btnList.Text = "Listele";
			this.btnList.UseVisualStyleBackColor = true;
			this.btnList.Click += new System.EventHandler(this.btnList_Click);
			// 
			// txtProductID
			// 
			this.txtProductID.Location = new System.Drawing.Point(114, 17);
			this.txtProductID.Name = "txtProductID";
			this.txtProductID.Size = new System.Drawing.Size(198, 26);
			this.txtProductID.TabIndex = 14;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(28, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(69, 20);
			this.label1.TabIndex = 13;
			this.label1.Text = "Ürün ID:";
			// 
			// txtProductStock
			// 
			this.txtProductStock.Location = new System.Drawing.Point(114, 105);
			this.txtProductStock.Name = "txtProductStock";
			this.txtProductStock.Size = new System.Drawing.Size(198, 26);
			this.txtProductStock.TabIndex = 27;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 111);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(85, 20);
			this.label4.TabIndex = 26;
			this.label4.Text = "Ürün Stok:";
			// 
			// txtProductPrice
			// 
			this.txtProductPrice.Location = new System.Drawing.Point(114, 149);
			this.txtProductPrice.Name = "txtProductPrice";
			this.txtProductPrice.Size = new System.Drawing.Size(198, 26);
			this.txtProductPrice.TabIndex = 29;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(9, 155);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(88, 20);
			this.label5.TabIndex = 28;
			this.label5.Text = "Ürün Fİyat:";
			// 
			// txtProductDescription
			// 
			this.txtProductDescription.Location = new System.Drawing.Point(114, 239);
			this.txtProductDescription.Multiline = true;
			this.txtProductDescription.Name = "txtProductDescription";
			this.txtProductDescription.Size = new System.Drawing.Size(198, 62);
			this.txtProductDescription.TabIndex = 31;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(25, 199);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(72, 20);
			this.label6.TabIndex = 30;
			this.label6.Text = "Kategori:";
			// 
			// cbxProductCategory
			// 
			this.cbxProductCategory.FormattingEnabled = true;
			this.cbxProductCategory.Location = new System.Drawing.Point(114, 193);
			this.cbxProductCategory.Name = "cbxProductCategory";
			this.cbxProductCategory.Size = new System.Drawing.Size(198, 28);
			this.cbxProductCategory.TabIndex = 32;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(20, 243);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(77, 20);
			this.label7.TabIndex = 33;
			this.label7.Text = "Açıklama:";
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(1349, 792);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.cbxProductCategory);
			this.Controls.Add(this.txtProductDescription);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtProductPrice);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtProductStock);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.btnGetById);
			this.Controls.Add(this.BtnUpdate);
			this.Controls.Add(this.BtnDelete);
			this.Controls.Add(this.BtnAdd);
			this.Controls.Add(this.txtProductName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.datagridview1);
			this.Controls.Add(this.btnList);
			this.Controls.Add(this.txtProductID);
			this.Controls.Add(this.label1);
			this.Name = "Form2";
			this.Text = "FrmProduct";
			this.Load += new System.EventHandler(this.Form2_Load);
			((System.ComponentModel.ISupportInitialize)(this.datagridview1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnGetById;
		private System.Windows.Forms.Button BtnUpdate;
		private System.Windows.Forms.Button BtnDelete;
		private System.Windows.Forms.Button BtnAdd;
		private System.Windows.Forms.TextBox txtProductName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridView datagridview1;
		private System.Windows.Forms.Button btnList;
		private System.Windows.Forms.TextBox txtProductID;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtProductStock;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtProductPrice;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtProductDescription;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox cbxProductCategory;
		private System.Windows.Forms.Label label7;
	}
}
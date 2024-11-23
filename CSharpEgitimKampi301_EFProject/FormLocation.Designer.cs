namespace CSharpEgitimKampi301_EFProject
{
	partial class FormLocation
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
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.txtCountry = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtCity = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.dgvLocation = new System.Windows.Forms.DataGridView();
			this.btnList = new System.Windows.Forms.Button();
			this.txtId = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtDayNight = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtPrice = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.cbxGuide = new System.Windows.Forms.ComboBox();
			this.nudCapacity = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.dgvLocation)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudCapacity)).BeginInit();
			this.SuspendLayout();
			// 
			// btnGetById
			// 
			this.btnGetById.BackColor = System.Drawing.Color.Brown;
			this.btnGetById.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnGetById.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnGetById.Location = new System.Drawing.Point(144, 544);
			this.btnGetById.Name = "btnGetById";
			this.btnGetById.Size = new System.Drawing.Size(225, 57);
			this.btnGetById.TabIndex = 23;
			this.btnGetById.Text = "Id\'ye Göre Getir";
			this.btnGetById.UseVisualStyleBackColor = false;
			// 
			// btnUpdate
			// 
			this.btnUpdate.BackColor = System.Drawing.Color.Brown;
			this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnUpdate.Location = new System.Drawing.Point(144, 497);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(225, 57);
			this.btnUpdate.TabIndex = 22;
			this.btnUpdate.Text = "Güncelle";
			this.btnUpdate.UseVisualStyleBackColor = false;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.BackColor = System.Drawing.Color.Brown;
			this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnAdd.Location = new System.Drawing.Point(144, 403);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(225, 57);
			this.btnAdd.TabIndex = 21;
			this.btnAdd.Text = "Ekle";
			this.btnAdd.UseVisualStyleBackColor = false;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.BackColor = System.Drawing.Color.Brown;
			this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnDelete.Location = new System.Drawing.Point(144, 450);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(225, 57);
			this.btnDelete.TabIndex = 20;
			this.btnDelete.Text = "Sil";
			this.btnDelete.UseVisualStyleBackColor = false;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// txtCountry
			// 
			this.txtCountry.Location = new System.Drawing.Point(144, 128);
			this.txtCountry.Name = "txtCountry";
			this.txtCountry.Size = new System.Drawing.Size(213, 26);
			this.txtCountry.TabIndex = 19;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(75, 131);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(45, 20);
			this.label3.TabIndex = 18;
			this.label3.Text = "Ülke:";
			// 
			// txtCity
			// 
			this.txtCity.Location = new System.Drawing.Point(144, 80);
			this.txtCity.Name = "txtCity";
			this.txtCity.Size = new System.Drawing.Size(213, 26);
			this.txtCity.TabIndex = 17;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(70, 83);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(50, 20);
			this.label2.TabIndex = 16;
			this.label2.Text = "Şehir:";
			// 
			// dgvLocation
			// 
			this.dgvLocation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvLocation.Location = new System.Drawing.Point(382, 37);
			this.dgvLocation.Name = "dgvLocation";
			this.dgvLocation.RowHeadersWidth = 62;
			this.dgvLocation.RowTemplate.Height = 28;
			this.dgvLocation.Size = new System.Drawing.Size(1173, 561);
			this.dgvLocation.TabIndex = 15;
			// 
			// btnList
			// 
			this.btnList.BackColor = System.Drawing.Color.Brown;
			this.btnList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnList.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnList.Location = new System.Drawing.Point(144, 356);
			this.btnList.Name = "btnList";
			this.btnList.Size = new System.Drawing.Size(225, 57);
			this.btnList.TabIndex = 14;
			this.btnList.Text = "Listele";
			this.btnList.UseVisualStyleBackColor = false;
			this.btnList.Click += new System.EventHandler(this.btnList_Click);
			// 
			// txtId
			// 
			this.txtId.Location = new System.Drawing.Point(144, 34);
			this.txtId.Name = "txtId";
			this.txtId.Size = new System.Drawing.Size(213, 26);
			this.txtId.TabIndex = 13;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(23, 37);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(97, 20);
			this.label1.TabIndex = 12;
			this.label1.Text = "Lokasyon id:";
			// 
			// txtDayNight
			// 
			this.txtDayNight.Location = new System.Drawing.Point(144, 267);
			this.txtDayNight.Name = "txtDayNight";
			this.txtDayNight.Size = new System.Drawing.Size(213, 26);
			this.txtDayNight.TabIndex = 29;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(33, 270);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(87, 20);
			this.label4.TabIndex = 28;
			this.label4.Text = "Gün Gece:";
			// 
			// txtPrice
			// 
			this.txtPrice.Location = new System.Drawing.Point(144, 219);
			this.txtPrice.Name = "txtPrice";
			this.txtPrice.Size = new System.Drawing.Size(213, 26);
			this.txtPrice.TabIndex = 27;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(73, 222);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(47, 20);
			this.label5.TabIndex = 26;
			this.label5.Text = "Fiyat:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(45, 176);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(71, 20);
			this.label6.TabIndex = 24;
			this.label6.Text = "Kapasite";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(54, 314);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(66, 20);
			this.label7.TabIndex = 30;
			this.label7.Text = "Rehber:";
			// 
			// cbxGuide
			// 
			this.cbxGuide.FormattingEnabled = true;
			this.cbxGuide.Location = new System.Drawing.Point(144, 314);
			this.cbxGuide.Name = "cbxGuide";
			this.cbxGuide.Size = new System.Drawing.Size(213, 28);
			this.cbxGuide.TabIndex = 31;
			// 
			// nudCapacity
			// 
			this.nudCapacity.Location = new System.Drawing.Point(144, 174);
			this.nudCapacity.Name = "nudCapacity";
			this.nudCapacity.Size = new System.Drawing.Size(213, 26);
			this.nudCapacity.TabIndex = 32;
			// 
			// FormLocation
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1578, 626);
			this.Controls.Add(this.nudCapacity);
			this.Controls.Add(this.cbxGuide);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.txtDayNight);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtPrice);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.btnGetById);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.txtCountry);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtCity);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.dgvLocation);
			this.Controls.Add(this.btnList);
			this.Controls.Add(this.txtId);
			this.Controls.Add(this.label1);
			this.Name = "FormLocation";
			this.Text = "FormLocation";
			this.Load += new System.EventHandler(this.FormLocation_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvLocation)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudCapacity)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnGetById;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.TextBox txtCountry;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtCity;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridView dgvLocation;
		private System.Windows.Forms.Button btnList;
		private System.Windows.Forms.TextBox txtId;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtDayNight;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtPrice;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ComboBox cbxGuide;
		private System.Windows.Forms.NumericUpDown nudCapacity;
	}
}
using CSharpEgitimKampi301_EFProject.NewFolder1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi301_EFProject
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		EgitimKampiEFTravelDbEntities db = new EgitimKampiEFTravelDbEntities();

		private void btnList_Click(object sender, EventArgs e)
		{
			

			var values = db.Guide.ToList();

			dgv1.DataSource = values;


		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			Guide guide = new Guide();

			guide.GuideName = txtName.Text;

			guide.GuideSurname = txtSurname.Text;

			db.Guide.Add(guide);

			db.SaveChanges();

			MessageBox.Show("Rehber Başarı ile eklendi!");
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			int id = int.Parse(txtId.Text);

			var toBeDeletedValue = db.Guide.Find(id);

			db.Guide.Remove(toBeDeletedValue);
			db.SaveChanges();
			MessageBox.Show("Rehber Başarı ile Silindi!");

		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			int id = int.Parse(txtId.Text);

			var updatedValue = db.Guide.Find(id);

			updatedValue.GuideName = txtName.Text.Trim();
			updatedValue.GuideSurname = txtSurname.Text.Trim();

			MessageBox.Show("Rehber başarı ile güncellendi!","Uyarı",MessageBoxButtons.OK, MessageBoxIcon.Warning);

		}

		private void btnGetById_Click(object sender, EventArgs e)
		{
			int id = int.Parse(txtId.Text);

			var values = db.Guide.Where(x=>x.GuideId == id).ToList();

			dgv1.DataSource = values;
		}
	}
}

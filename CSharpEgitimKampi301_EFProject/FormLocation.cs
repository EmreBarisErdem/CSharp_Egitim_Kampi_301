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
	public partial class FormLocation : Form
	{
		public FormLocation()
		{
			InitializeComponent();
		}

		EgitimKampiEFTravelDbEntities db = new EgitimKampiEFTravelDbEntities();

		private void btnList_Click(object sender, EventArgs e)
		{
			var values = db.Location.ToList();
			dgvLocation.DataSource = values;

		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			Location location = new Location();

			location.Capacity = byte.Parse(nudCapacity.Value.ToString());

			location.City = txtCity.Text;

			location.Country = txtCountry.Text;

			location.Price = decimal.Parse(txtPrice.Text);

			location.GuideId = int.Parse(cbxGuide.SelectedValue.ToString());

			db.Location.Add(location);

			db.SaveChanges();

			MessageBox.Show("Ekleme işlemi Başarılı!");

		}

		private void FormLocation_Load(object sender, EventArgs e)
		{
			var values = db.Guide.Select(x => new
			{
				FullName = x.GuideName + " " + x.GuideSurname,
				x.GuideId
			}).ToList();


			cbxGuide.DisplayMember = "FullName";
			cbxGuide.ValueMember = "GuideId";
			cbxGuide.DataSource = values;
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			int id = int.Parse(txtId.Text);

			var toBeDeletedValue = db.Location.Find(id);

			db.Location.Remove(toBeDeletedValue);

			db.SaveChanges();

			MessageBox.Show("Silme İşlemi Başarılı!");
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			int id = int.Parse(txtId.Text);

			var toBeUpdatedValue = db.Location.Find(id);

			toBeUpdatedValue.DayNight = txtDayNight.Text;
			toBeUpdatedValue.Price = decimal.Parse(txtPrice.Text);
			toBeUpdatedValue.Capacity = byte.Parse(nudCapacity.Value.ToString());
			toBeUpdatedValue.City = txtCity.Text;
			toBeUpdatedValue.Country = txtCountry.Text;
			toBeUpdatedValue.GuideId = int.Parse(cbxGuide.SelectedValue.ToString());

		}
	}
}

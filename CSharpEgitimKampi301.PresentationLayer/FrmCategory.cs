using CSharpEgitimKampi301.BusinessLayer.Abstract;
using CSharpEgitimKampi301.BusinessLayer.Concrete;
using CSharpEgitimKampi301.DataAccessLayer.EntityFramework;
using CSharpEgitimKampi301.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi301.PresentationLayer
{
	public partial class Form1 : Form
	{

		private readonly ICategoryService _categoryService;

		public Form1()
		{
			_categoryService = new CategoryManager(new EfCategoryDal());
			InitializeComponent();
		}

		private void btnList_Click(object sender, EventArgs e)
		{
			var categoryValues = _categoryService.TGetAll();
			datagridview1.DataSource = categoryValues;
		}

		private void BtnAdd_Click(object sender, EventArgs e)
		{
			Category category = new Category();
			category.CategoryName = txtCategoryName.Text;
			category.CategoryStatus = true;
			_categoryService.TInsert(category);
			MessageBox.Show("Ekleme Başarılı!");
		}

		private void BtnDelete_Click(object sender, EventArgs e)
		{
			int id = int.Parse(txtCategoryID.Text);

			var deletedValues = _categoryService.TGetById(id);

			_categoryService.TDelete(deletedValues);

			MessageBox.Show("Silme Başarılı");
		}

		private void btnGetById_Click(object sender, EventArgs e)
		{
			int id = int.Parse(txtCategoryID.Text);

			var values = _categoryService.TGetById(id);

			datagridview1.DataSource = values;
		}

		private void BtnUpdate_Click(object sender, EventArgs e)
		{
			
			int updatedCatId = int.Parse(txtCategoryID.Text);

			var updatedValue = _categoryService.TGetById(updatedCatId);

			updatedValue.CategoryName = txtCategoryName.Text;
			updatedValue.CategoryStatus = true;

			_categoryService.TUpdate(updatedValue);
		}
	}
}

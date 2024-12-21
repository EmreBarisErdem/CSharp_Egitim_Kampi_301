using CSharpEgitimKampi301.BusinessLayer.Abstract;
using CSharpEgitimKampi301.BusinessLayer.Concrete;
using CSharpEgitimKampi301.DataAccessLayer.EntityFramework;
using CSharpEgitimKampi301.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi301.PresentationLayer
{
	public partial class Form2 : Form
	{
		private readonly IProductService _productService;
		private readonly ICategoryService _categoryService;

		public Form2()
		{
			InitializeComponent();
			_productService = new ProductManager(new EfProductDal());
			_categoryService = new CategoryManager(new EfCategoryDal());
		}

		

		private void btnList_Click(object sender, EventArgs e)
		{
			var values = _productService.TGetAll();
			datagridview1.DataSource = values;
		}

		private void BtnDelete_Click(object sender, EventArgs e)
		{
			int id = int.Parse(txtProductID.Text);
			_productService.TDelete(_productService.TGetById(id));
			MessageBox.Show("Silme Başarılı");
		}

		private void BtnAdd_Click(object sender, EventArgs e)
		{
			if (cbxProductCategory.SelectedValue != null)
			{
				Product product = new Product();

				product.CategoryId = int.Parse(cbxProductCategory.SelectedValue.ToString());
				product.ProductName = txtProductName.Text;
				product.ProductPrice = decimal.Parse(txtProductPrice.Text);
				product.ProductDescription = txtProductDescription.Text;
				product.ProductStock = int.Parse(txtProductStock.Text);
				_productService.TInsert(product);

				MessageBox.Show("Ürün Eklendi");
			}
			else
			{
				MessageBox.Show("Lütfen bir kategori seçin.");
			}
		}

		private void BtnUpdate_Click(object sender, EventArgs e)
		{
			int id = int.Parse(txtProductID.Text);
			var product = _productService.TGetById(id);
			product.ProductDescription= txtProductDescription.Text;
			product.ProductPrice = decimal.Parse(txtProductPrice.Text);
			product.ProductName = txtProductName.Text;
			product.ProductStock = int.Parse(txtProductStock.Text);
			product.CategoryId = int.Parse(cbxProductCategory.SelectedValue.ToString());

			_productService.TUpdate(product);
			MessageBox.Show("Güncelleme Başarılı");
		}

		private void Form2_Load(object sender, EventArgs e)
		{
			var values = _categoryService.TGetAll();

			cbxProductCategory.DataSource = values;

			cbxProductCategory.DisplayMember = "CategoryName";

			cbxProductCategory.ValueMember = "CategoryId";
		}
	}
}

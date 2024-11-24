using CSharpEgitimKampi301_EFProject.NewFolder1;
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

namespace CSharpEgitimKampi301_EFProject
{
	public partial class FrmStatistics : Form
	{
		public FrmStatistics()
		{
			InitializeComponent();
		}

		EgitimKampiEFTravelDbEntities db = new EgitimKampiEFTravelDbEntities();

		private void FrmStatistics_Load(object sender, EventArgs e)
		{
			//Toplam Lokasyon Sayısı
			lblLokasyon.Text = db.Location.Count().ToString();

			//Toplam Kapasite Sayısı
			lblKapasite.Text = db.Location.Sum(x=>x.Capacity).ToString();

			//Rehber Sayısı
			lblGuideCount.Text = db.Guide.Count().ToString();

			//Ortalama Kapasite
			lblAvgCapacity.Text = db.Location.Average(x=>x.Capacity).ToString();


			//Ortalama Tur Fiyatı
			lblAvgLocationPrice.Text = db.Location.Average(x => x.Price).ToString() + "TL";


			//Eklenen Son Ülke
			int lastCountryId = db.Location.Max(x => x.LocationId);

			lblLastCountry.Text = db.Location.Where(x => x.LocationId == lastCountryId).Select(y => y.Country).FirstOrDefault();


			//kapadokya şehrinin kapasitesi
			lblCappadociaCapacity.Text = db.Location.Where(x=>x.City=="Kapadokya").Select(y => y.Capacity).FirstOrDefault().ToString();


			//Türkiye Tur Kapasite Oranı
			lblTrCapacityAvg.Text = db.Location.Where(x=>x.Country=="Türkiye").Average(x=>x.Capacity).ToString();


			//Roma Gezisinin Rehber İsmi
			var romeGuideId = db.Location.Where(x=>x.City=="Roma").Select(y=>y.GuideId).FirstOrDefault();

			lblRomeGuideName.Text = db.Guide.Where(x => x.GuideId == romeGuideId).Select(y => y.GuideName + " " + y.GuideSurname).FirstOrDefault().ToString();


			//max kapasiteli tur
			var maxCapacity = db.Location.Max(x => x.Capacity);

			lblMaxCapacityLocation.Text = db.Location.Where(x => x.Capacity == maxCapacity).Select(y => y.City).FirstOrDefault().ToString();

			//En pahalı tur

			var maxPrice = db.Location.Max(x=>x.Price);
			lblMaxExpsLocation.Text = db.Location.Where(x=>x.Price == maxPrice).Select(y=>y.City).FirstOrDefault().ToString();



			//'Ayşegül Çınar' isimli Rehberin Tur sayısı
			var guideIdOfAysegulCınar = db.Guide.Where(x=>x.GuideName=="Ayşegül" && x.GuideSurname=="Çınar").Select(y=>y.GuideId).FirstOrDefault();

			lblAysegulCınarLocation.Text = db.Location.Where(x=>x.GuideId==guideIdOfAysegulCınar).Count().ToString();	

		}


	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.EntityLayer.Concrete
{
	public class Category
	{
        //internal ==> access modifier => Bulunduğu katmandan erişim sağlanır.

        // Public , Private , Internal , Protected

        //Field - Variable - Property

        //int x; // field

        //void metod()
        //{
        //    int y; // Variable
        //}

        public int CategoryId { get; set; } // Property

        public string CategoryName { get; set; }

        public bool CategoryStatus { get; set; }

        //Navigation Properties
        public virtual List<Product> Products { get; set; }

    }
}

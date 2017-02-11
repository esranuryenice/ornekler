using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTakibiForms.DAL.Model
{
  public  class Sale
    {
        public int ID { get; set; }
        public DateTime SatisTarihi { get; set; }
        public int SatisMiktari { get; set; }
        public int MusteriID { get; set; }
        public int UrunID { get; set; }
        public string SatisFaturaNo { get; set; }

        //ilişki yapmak için property
        public Current Musteri { get; set; }//bağlamak için kullanılır...
        public Product Urun { get; set; }
    }
}

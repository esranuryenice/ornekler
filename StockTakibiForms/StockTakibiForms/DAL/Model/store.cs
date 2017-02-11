using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTakibiForms.DAL.Model
{
   public class Store
    {
        public int ID { get; set; }
        public int UrunID { get; set; }
        public int AlisMiktari { get; set; }
        public DateTime SonKullanmaTarihi { get; set; }
        public DateTime AlisTarihi { get; set; }
        public double AlisFiyati { get; set; }
        public int TedarikciID { get; set; }
        public string AlisFaturaNo { get; set; }

        //ilişki yapmak için property
        public Product Urun { get; set; }
        public Current Tedarikci { get; set; }


    }
 
}

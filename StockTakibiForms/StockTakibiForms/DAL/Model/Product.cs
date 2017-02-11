using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTakibiForms.DAL.Model
{
    public class Product
    {
        public int ID { get; set; }
        public string UrunBarkod { get; set; }
        public string UrunAdi { get; set; }
        public int KategoriID { get; set; }//Category Class
        public double UrunMiktar { get; set; }
        public int UrunMiktarTuruID { get; set; }// Miktar Turu
        public double SatisFiyat { get; set; }
        public int KDVOran { get; set; }
        public int StockAdeti { get; set; }

        //ilişki yapmak için property
        public Category Kategori { get; set; }
        public ProductAmountType UrunMiktariTuru { get; set; }



    }
}

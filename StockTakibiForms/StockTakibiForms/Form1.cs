using StockTakibiForms.DAL.DBContext;
using StockTakibiForms.DAL.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockTakibiForms
{
    public partial class Form1 : Form
    {
       

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
            
        {
            //using (StokTakibiDBContext context = new StokTakibiDBContext())

            //{
            //    context.Category.Add(new Category { Ad = "Kahve" });

            //    context.Category.Add(new Category { Ad = "Çay" });

            //    Category c = new Category();
            //    c.Ad = "Soğuk İçecek";
            //    context.Category.Add(c);


            //    context.SaveChanges();
            //}
        }
    }
}

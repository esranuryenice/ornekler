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
            using (StokTakibiDBContext context = new StokTakibiDBContext())
            {
                var resultCategory = context.Category.ToList();
                foreach (var item in resultCategory)
                {
                    comboBoxurun_kategori.Items.Add(item);
                }

                // comboBoxurun_kategori.DataSource = context.Category.ToList();

               var  resultPAT = context.ProductAmountType.ToList();
                comboBoxurun_miktar_türü.DataSource = resultPAT;
            }

            tabControlmenu.Visible = false;
            pictureBox2.Visible = false;

        }

        private async void pictureBox1_Click(object sender, EventArgs e)
        {

           
            pictureBox1.Visible = false;
            label1.Visible = false;

            pictureBox2.Visible = true;
            await Task.Delay(2500);

            pictureBox2.Visible = false;
            tabControlmenu.Visible = true;
        }

        private void buttonekle_Click(object sender, EventArgs e)
        {
            Product p = new Product();
            p.UrunBarkod = textBoxbarkod.Text;
            p.UrunAdi = textBoxurun_adi.Text;
            p.UrunMiktar = Convert.ToDouble(numericUpDownurun_miktar.Value);
            p.KDVOran = int.Parse(comboBoxKDV.SelectedItem.ToString());
            p.StockAdeti = Convert.ToInt32(numericUpDowstok_adeti.Value);

            Category c =(Category) comboBoxurun_kategori.SelectedItem;
            p.KategoriID = c.ID;

           
            ProductAmountType pat = (ProductAmountType)comboBoxurun_miktar_türü.SelectedItem;
            p.UrunMiktarTuruID = pat.ID;
            using (StokTakibiDBContext context = new StokTakibiDBContext())
            {
                context.Product.Add(p);
                context.SaveChanges();
            }



        }
    }
}

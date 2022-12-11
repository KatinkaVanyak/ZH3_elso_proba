using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZH3_elso_proba
{
    public partial class Adatbazis_Control1 : UserControl
    {
        Models.SeBikestoreContext context = new Models.SeBikestoreContext();
        public Adatbazis_Control1()
        {
            InitializeComponent();

            Üzlet_Szűrés_listbox1re();
            Produkt_szűrés_listbox2re();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // új üzlet hozzáadása gomb

            Rekord_felvetel_Form2 newüzlet = new Rekord_felvetel_Form2();
            if (newüzlet.ShowDialog() == DialogResult.OK)
            {

                Models.Store üzlet = new Models.Store();
                üzlet.StoreName = newüzlet.textBox1_üzlet.Text;

                context.Stores.Add(üzlet);
                context.SaveChanges();


                Üzlet_Szűrés_listbox1re();

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // üzlet szűrése és megjelenítése

            Üzlet_Szűrés_listbox1re();
        }

        private void Üzlet_Szűrés_listbox1re()
        {
            var üzlet_választott = from x in context.Stores
                                   where x.StoreName.Contains(textBox1.Text)
                                   select x;

            listBox1.DataSource = üzlet_választott.ToList();
            listBox1.DisplayMember = "StoreName";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Rácsos();
        }

        private void Rácsos()
        {
            var selectedStore = (Models.Store)listBox1.SelectedItem;
            var készlet = from x in context.Stocks
                          where x.StoreSk == selectedStore.StoreSk && x.ProductFk == x.ProductFkNavigation.ProductSk
                          select new DetailedItem
                          {
                              StoreId = selectedStore.StoreSk,
                              ProductId = x.ProductFk,
                              ProductName = x.ProductFkNavigation.ProductName,
                              Quantity = x.Quantity
                          };

            detailedItemBindingSource.DataSource = készlet.ToList();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Produkt_szűrés_listbox2re();
        }

        private void Produkt_szűrés_listbox2re()
        {
            var produkt_választott = from x in context.Products
                                     where x.ProductName.Contains(textBox2.Text)
                                     select x;

            listBox2.DataSource = produkt_választott.ToList();
            listBox2.DisplayMember = "ProductName";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var selectedStore = (Models.Store)listBox1.SelectedItem;
            var selectedProduct = (Models.Product)listBox2.SelectedItem;



            Models.Stock újstocksor = new Models.Stock()
            {
                StoreSk = selectedStore.StoreSk,
                ProductFk = selectedProduct.ProductSk,
                Quantity = int.Parse(textBox3.Text)
            };

            context.Stocks.Add(újstocksor);
            context.SaveChanges();
            Rácsos();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            /*
             if (MessageBox.Show("Biztos be akarja zárni?","Bezárja az ablakot?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;

            }
             */

            if (MessageBox.Show("Biztos ki akarja törölni?", "Kitörli?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var selectedStock = (DetailedItem)detailedItemBindingSource.Current;
                var delete = (from x in context.Stocks
                              where x.StoreSk == selectedStock.StoreId
                              select x).FirstOrDefault();

                context.Stocks.Remove(delete);
                context.SaveChanges();
                Rácsos();
            }
            
            
        }

        private void Adatbazis_Control1_Load(object sender, EventArgs e)
        {

        }
    }
}

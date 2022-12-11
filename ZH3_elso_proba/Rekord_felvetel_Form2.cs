using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZH3_elso_proba
{
    public partial class Rekord_felvetel_Form2 : Form
    {
        public Rekord_felvetel_Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //hozzáadás button OK button

            if (this.ValidateChildren() == true)
            {
                this.DialogResult = DialogResult.OK;
            }
        }


        private bool CheckNemÜres(string név)
        {
            return !string.IsNullOrEmpty(név);
        }

        private bool CheckNincsSzám(string beüzlet)
        {
            Regex r = new Regex("^[^0-9]");
            return r.IsMatch(beüzlet);
        }


        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1_üzlet.Text) || !CheckNincsSzám(textBox1_üzlet.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox1_üzlet, "Az üzlet nem lehet üres és nem kezdődhet számmal");
            }
        }

        private void textBox1_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBox1_üzlet,"");
        }

        private void button2_Click(object sender, EventArgs e)
        {

            //cancel button
            this.DialogResult = DialogResult.Cancel;
            
        }

        private void Rekord_felvetel_Form2_Load(object sender, EventArgs e)
        {

        }
    }
}

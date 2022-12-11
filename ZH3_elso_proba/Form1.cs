using System.Windows.Forms;

namespace ZH3_elso_proba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void button_Adatbazishoz_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Adatbazis_Control1 uc1 = new();
            panel1.Controls.Add(uc1);
            uc1.Dock = DockStyle.Fill;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Biztos be akarja zárni?","Bezárja az ablakot?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;

            }
        }

        private void button_Excelhez_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Excel_Control2 uc2 = new();
            panel1.Controls.Add(uc2);
            uc2.Dock = DockStyle.Fill;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
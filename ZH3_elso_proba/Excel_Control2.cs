using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;

namespace ZH3_elso_proba
{
    public partial class Excel_Control2 : UserControl
    {

        Excel.Application xlApp; // A Microsoft Excel alkalmazás
        Excel.Workbook xlWB;     // A létrehozott munkafüzet
        Excel.Worksheet xlSheet; // Munkalap a munkafüzeten belül

        public Excel_Control2()
        {
            InitializeComponent();
        }

        private void Import_button_Click(object sender, EventArgs e)
        {


            try
            {
                // Excel elindítása és az applikáció objektum betöltése
                xlApp = new Excel.Application();

                // Új munkafüzet
                xlWB = xlApp.Workbooks.Add(Missing.Value);

                // Új munkalap
                xlSheet = xlWB.ActiveSheet;

                // Tábla létrehozása
                CreateTable(); // Ennek megírása a következő feladatrészben következik

                // Control átadása a felhasználónak
                xlApp.Visible = true;
                xlApp.UserControl = true;
            }
            catch (Exception ex) // Hibakezelés a beépített hibaüzenettel
            {
                string errMsg = string.Format("Error: {0}\nLine: {1}", ex.Message, ex.Source);
                MessageBox.Show(errMsg, "Error");

                // Hiba esetén az Excel applikáció bezárása automatikusan
                xlWB.Close(false, Type.Missing, Type.Missing);
                xlApp.Quit();
                xlWB = null;
                xlApp = null;
            }

            void CreateTable()
            {
                string[] fejlécek = new string[] 
                {
                "First name",
                "Second name",
                "Phone",
                "EMail",
                "zip-code",
                };

                for (int i = 0; i < fejlécek.Length; i++)
                {
                    xlSheet.Cells[1, 1] = fejlécek[0];
                    xlSheet.Cells[1, 2] = fejlécek[1];
                    xlSheet.Cells[1, 3] = fejlécek[2];
                    xlSheet.Cells[1, 4] = fejlécek[3];
                    xlSheet.Cells[1, 5] = fejlécek[4];
               
                }

                Models.SeBikestoreContext context = new Models.SeBikestoreContext();
                var kérd_össz = context.Customers.ToList();

                object[,] adatok = new object[kérd_össz.Count(), fejlécek.Count()];

                for (int i = 0; i < kérd_össz.Count; i++)
                {
                    adatok[i, 0] = kérd_össz[i].FirstName;
                    adatok[i, 1] = kérd_össz[i].LastName;
                    adatok[i, 2] = kérd_össz[i].Phone;
                    adatok[i, 3] = kérd_össz[i].Email;
                    adatok[i, 4] = kérd_össz[i].ZipCode;
                }


                int sorokSzáma = adatok.GetLength(0);   // az object adatok 2 dimenziós. az 1. dimenzió a sorok, a 2. az oszlopok?
                int oszlopokSzáma = adatok.GetLength(1);

                Excel.Range adatRange = xlSheet.get_Range("A2", Type.Missing).get_Resize(sorokSzáma, oszlopokSzáma);
                adatRange.Value2 = adatok;

                adatRange.Font.Italic = true;

            }

        }

        private void Excel_Control2_Load(object sender, EventArgs e)
        {

        }
    }
}

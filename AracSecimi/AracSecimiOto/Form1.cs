using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AracSecimiOto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            FillKasaTipi();
            FillYakitTipi();
            FillMarka();
            FillDataGridView();
        }

        private void FillDataGridView()
        {
            dataGridView1.ColumnCount = 7;
            dataGridView1.Columns[0].Name = "Ruhsat No";
            dataGridView1.Columns[1].Name = "Marka";
            dataGridView1.Columns[2].Name = "Model";
            dataGridView1.Columns[3].Name = "Yakıt Tipi";
            dataGridView1.Columns[4].Name = "Kasa Tipi";
            dataGridView1.Columns[5].Name = "Kilometresi";
            dataGridView1.Columns[6].Name = "Fiyatı";
        }

        private void FillMarka()
        {
            cmbMarka.Items.Clear();

            cmbMarka.Items.Add("KIA");
            cmbMarka.Items.Add("Toyota");
            cmbMarka.Items.Add("Peugeot");
            cmbMarka.Items.Add("Honda");
            cmbMarka.Items.Add("Opel");
            cmbMarka.Items.Add("Seat");
            cmbMarka.Items.Add("BMW");
            cmbMarka.Items.Add("Mercedes");
            cmbMarka.Items.Add("Volkswagen");
            cmbMarka.Items.Add("Volvo");
        }

        private void FillYakitTipi()
        {
            cmbYakitTipi.Items.Clear();

            cmbYakitTipi.Items.Add("Benzinli");
            cmbYakitTipi.Items.Add("Dizel");
            cmbYakitTipi.Items.Add("Benzin + LPG");
            cmbYakitTipi.Items.Add("Elektrikli");
            cmbYakitTipi.Items.Add("Hibrit");
        }

        private void FillKasaTipi()
        {
            cmbKasaTipi.Items.Clear();

            cmbKasaTipi.Items.Add("Sedan");
            cmbKasaTipi.Items.Add("Hatcback");
            cmbKasaTipi.Items.Add("Arazi-SUV");
            cmbKasaTipi.Items.Add("Coupe");
            cmbKasaTipi.Items.Add("Cabrio");
        }

        private void cmbMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbModel.Items.Clear();

            string marka = cmbMarka.SelectedItem.ToString();

            if (marka == "KIA")
            {
                string[] model = { "Sportage", "Ceed", "Sorento" };
                cmbModel.Items.AddRange(model);
            }

            if (marka == "Toyota")
            {
                string[] model = { "Auris", "Corolla" };
                cmbModel.Items.AddRange(model);
            }

            if (marka == "Peugeot")
            {
                string[] model = { "301", "206", "207", "407", "508" };
                cmbModel.Items.AddRange(model);
            }

            if (marka == "Honda")
            {
                string[] model = { "Civic", "Accord" };
                cmbModel.Items.AddRange(model);
            }

            if (marka == "Opel")
            {
                string[] model = { "Corsa", "Astra", "Meriva", "Vectra" };
                cmbModel.Items.AddRange(model);
            }

            if (marka == "Seat")
            {
                string[] model = { "Leon", "Ibıza" };
                cmbModel.Items.AddRange(model);
            }

            if (marka == "BMW")
            {
                string[] model = { "5.20", "3.20", "3.16", "4.20", "X5", "X6" };
                cmbModel.Items.AddRange(model);
            }

            if (marka == "Mercedes")
            {
                string[] model = { "E200", "C200", "CLK200", "S500" };
                cmbModel.Items.AddRange(model);
            }

            if (marka == "Volkswagen")
            {
                string[] model = { "Polo", "Golf", "Passat", "Jetta" };
                cmbModel.Items.AddRange(model);
            }

            if (marka == "Volvo")
            {
                string[] model = { "V40", "S60", "XC90" };
                cmbModel.Items.AddRange(model);
            }


        }


        private void btnKaydet_Click(object sender, EventArgs e)
        {

            string[] aracBilgileri = new string[]
            {
                txtRuhsatNo.Text,
                cmbMarka.Text, cmbModel.Text,
                cmbYakitTipi.Text,
                cmbKasaTipi.Text,
                txtKilometresi.Text,
                txtFiyati.Text
            };

            dataGridView1.Rows.Add(aracBilgileri);

            FormClear();

        }

        private void FormClear()
        {
            txtRuhsatNo.Clear();
            cmbMarka.Items.Clear();
            cmbModel.Items.Clear();
            cmbYakitTipi.Items.Clear();
            cmbKasaTipi.Items.Clear();
            txtKilometresi.Text = "";
            txtFiyati.Clear();

            FillKasaTipi();
            FillYakitTipi();
            FillMarka();

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            {
                if (dataGridView1.CurrentRow.Cells[0].Value != null)
                    dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                else MessageBox.Show("Silmek için önce bir kayıt seçiniz");

            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Tugas_PBO_Winform
{
    public partial class DetailTransaksi : Form
    {
        public DetailTransaksi()
        {
            InitializeComponent();
        }

        private void DetailTransaksi_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            string sql = $"INSERT INTO detail_transaksi(id_transaksi, id_laptop, jumlah) VALUES ({textBox1.Text},{textBox11.Text},{textBox10.Text})";
            new DBHelpers().Execute(sql);
            new DBHelpers().Execute($"UPDATE laptop SET stok = stok - ({textBox10.Text}) WHERE id_laptop = {textBox11.Text}");
            InputBarang form = new InputBarang();
            form.ShowDialog();
            this.Close();
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

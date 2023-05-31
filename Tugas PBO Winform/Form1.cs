using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net;
using Npgsql;

namespace Tugas_PBO_Winform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }


        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new DBHelpers().Execute($"INSERT INTO laptop(id_laptop, nama_laptop, harga_laptop, stok_laptop) VALUES ({textBox1.Text},'{textBox2.Text}',{textBox3.Text}, {textBox4.Text})");
            showdataLaptop();

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void showdataDetailTransaksi()
        {
            var reader3 = new DBHelpers().Select("SELECT * from detail_transaksi order by id_detail_transaksi ASC");
            dataGridView3.Rows.Clear();
            while (reader3.Read())
            {
                dataGridView3.Rows.Add(reader3["id_detail_transaksi"], reader3["id_transaksi"], reader3["id_laptop"], reader3["jumlah"]);
            }
        }

        private void showdataTransaksi()
        {
            var reader2 = new DBHelpers().Select("SELECT * from transaksi order by id_transaksi ASC");
            dataGridView2.Rows.Clear();
            while (reader2.Read())
            {
                dataGridView2.Rows.Add(reader2["id_transaksi"], reader2["nama_pembeli"], reader2["tanggal_transaksi"]);
            }
        }

        private void showdataLaptop()
        {
            var reader = new DBHelpers().Select("SELECT * from laptop order by id_laptop ASC");
            dataGridView1.Rows.Clear();
            while (reader.Read())
            {
                dataGridView1.Rows.Add(reader["id_laptop"], reader["nama_laptop"], reader["harga_laptop"], reader["stok_laptop"]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new DBHelpers().Execute($"Delete from laptop where id_laptop = '{textBox1.Text}'");
            showdataLaptop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new DBHelpers().Execute($"Update laptop SET nama_laptop = '{textBox2.Text}', harga_laptop = {textBox3.Text}, stok_laptop = {textBox4.Text} where id_laptop = {textBox1.Text}");
            showdataLaptop();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            var Reader = new DBHelpers().Select($"select * from laptop where nama_laptop ilike '%{textBox5.Text}%'");

            dataGridView1.Rows.Clear();
            while (Reader.Read())
            {
                dataGridView1.Rows.Add((int)Reader["id_laptop"], (string)Reader["nama_laptop"], (int)Reader["harga_laptop"], (int)Reader["stok_laptop"]);
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        string APIKey = "1135fcebbe186c58315556215b0af835";
        private void Weather_Click(object sender, EventArgs e)
        {
            getWeather();
        }

        private void getWeather()
        {
            using (WebClient web = new WebClient())
            {
                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}", TbCity.Text, APIKey);
                var json = web.DownloadString(url);
                WeatherInfo.root Info = JsonConvert.DeserializeObject<WeatherInfo.root>(json);
                pic_Icon.ImageLocation = "https://openweathermap.org/img/w/" + Info.weather[0].icon + ".png";
                lab_Condition.Text = Info.weather[0].main;
                lab_Detail.Text = Info.weather[0].description;
                lab_Sunset.Text = convertDateTime(Info.sys.sunset).ToString();
                lab_Sunrise.Text = convertDateTime(Info.sys.sunrise).ToString();
                lab_Windspeed.Text = Info.wind.speed.ToString();
                lab_Pressure.Text = Info.main.pressure.ToString();
            }
        }
        DateTime convertDateTime(long millisec)

        {
            DateTime day = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            day = day.AddSeconds(millisec).ToLocalTime();
            return day;
        }

        private void pic_Icon_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            string sql = $"INSERT INTO transaksi(id_transaksi, nama_pembeli) VALUES ({textBox6.Text}, '{textBox12.Text}')";
            new DBHelpers().Execute(sql);
            DetailTransaksi form = new DetailTransaksi();
            form.ShowDialog();
            showdataTransaksi();
            showdataDetailTransaksi();
            showdataLaptop();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            showdataLaptop();
            showdataTransaksi();
            showdataDetailTransaksi();
        }
    }
}
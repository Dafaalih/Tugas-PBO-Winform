namespace Tugas_PBO_Winform
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            label5 = new Label();
            textBox5 = new TextBox();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            tabPage2 = new TabPage();
            pictureBox2 = new PictureBox();
            label14 = new Label();
            textBox12 = new TextBox();
            label9 = new Label();
            button8 = new Button();
            label7 = new Label();
            textBox6 = new TextBox();
            dataGridView2 = new DataGridView();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            tabPage3 = new TabPage();
            dataGridView3 = new DataGridView();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            Column11 = new DataGridViewTextBoxColumn();
            Weather = new TabPage();
            pic_Icon = new PictureBox();
            lab_Pressure = new Label();
            lab_Windspeed = new Label();
            lab_Sunset = new Label();
            label22 = new Label();
            label23 = new Label();
            lab_Sunrise = new Label();
            label17 = new Label();
            lab_ = new Label();
            lab_Detail = new Label();
            lab_Condition = new Label();
            TbCity = new Label();
            textBox8 = new TextBox();
            button4 = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            Weather.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_Icon).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(Weather);
            tabControl1.Font = new Font("Poppins", 8F, FontStyle.Bold, GraphicsUnit.Point);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1302, 757);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.DarkSlateGray;
            tabPage1.Controls.Add(pictureBox1);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(textBox5);
            tabPage1.Controls.Add(button3);
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(textBox4);
            tabPage1.Controls.Add(textBox3);
            tabPage1.Controls.Add(textBox2);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Location = new Point(4, 37);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1294, 716);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Laptop";
            tabPage1.Click += tabPage1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(28, 19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(88, 82);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Poppins", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ButtonFace;
            label6.Location = new Point(122, 35);
            label6.Name = "label6";
            label6.Size = new Size(234, 56);
            label6.TabIndex = 17;
            label6.Text = "ITech Laptop";
            label6.Click += label6_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dataGridView1.Location = new Point(583, 100);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(651, 478);
            dataGridView1.TabIndex = 15;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "IdLaptop";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Nama Laptop";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Harga Laptop";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "Stok Laptop";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(583, 50);
            label5.Name = "label5";
            label5.Size = new Size(79, 32);
            label5.TabIndex = 13;
            label5.Text = "Search";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(668, 48);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(566, 31);
            textBox5.TabIndex = 12;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // button3
            // 
            button3.Font = new Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.DarkSlateGray;
            button3.Location = new Point(321, 371);
            button3.Name = "button3";
            button3.Size = new Size(95, 34);
            button3.TabIndex = 10;
            button3.Text = "Update";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.DarkSlateGray;
            button2.Location = new Point(445, 371);
            button2.Name = "button2";
            button2.Size = new Size(95, 34);
            button2.TabIndex = 9;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.DarkSlateGray;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(200, 371);
            button1.Name = "button1";
            button1.Size = new Size(95, 34);
            button1.TabIndex = 8;
            button1.Text = "Insert";
            button1.TextAlign = ContentAlignment.TopCenter;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(62, 300);
            label4.Name = "label4";
            label4.Size = new Size(54, 32);
            label4.TabIndex = 7;
            label4.Text = "Stok";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(62, 235);
            label3.Name = "label3";
            label3.Size = new Size(71, 32);
            label3.TabIndex = 6;
            label3.Text = "Harga";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(62, 167);
            label2.Name = "label2";
            label2.Size = new Size(71, 32);
            label2.TabIndex = 5;
            label2.Text = "Nama";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(62, 104);
            label1.Name = "label1";
            label1.Size = new Size(95, 32);
            label1.TabIndex = 4;
            label1.Text = "IDLaptop";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(222, 301);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(294, 31);
            textBox4.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(222, 236);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(294, 31);
            textBox3.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(222, 168);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(294, 31);
            textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(222, 102);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(294, 31);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.DarkSlateGray;
            tabPage2.Controls.Add(pictureBox2);
            tabPage2.Controls.Add(label14);
            tabPage2.Controls.Add(textBox12);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(button8);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(textBox6);
            tabPage2.Controls.Add(dataGridView2);
            tabPage2.Location = new Point(4, 37);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1294, 716);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Transaksi";
            tabPage2.Click += tabPage2_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImageLayout = ImageLayout.None;
            pictureBox2.ErrorImage = null;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.InitialImage = null;
            pictureBox2.Location = new Point(31, 26);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(88, 82);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 20;
            pictureBox2.TabStop = false;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.ForeColor = SystemColors.ButtonHighlight;
            label14.Location = new Point(61, 167);
            label14.Name = "label14";
            label14.Size = new Size(80, 28);
            label14.TabIndex = 10;
            label14.Text = "Pembeli";
            label14.Click += label14_Click;
            // 
            // textBox12
            // 
            textBox12.Location = new Point(178, 167);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(318, 31);
            textBox12.TabIndex = 9;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Poppins", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(125, 42);
            label9.Name = "label9";
            label9.Size = new Size(188, 56);
            label9.TabIndex = 7;
            label9.Text = "Transaksi";
            label9.Click += label9_Click;
            // 
            // button8
            // 
            button8.ForeColor = Color.DarkSlateGray;
            button8.Location = new Point(178, 238);
            button8.Name = "button8";
            button8.Size = new Size(112, 34);
            button8.TabIndex = 6;
            button8.Text = "Upload";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(61, 113);
            label7.Name = "label7";
            label7.Size = new Size(111, 28);
            label7.TabIndex = 3;
            label7.Text = "IDTransaksi";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(178, 113);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(318, 31);
            textBox6.TabIndex = 1;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.BackgroundColor = SystemColors.ButtonFace;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Column5, Column6, Column7 });
            dataGridView2.Location = new Point(558, 52);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.RowTemplate.Height = 33;
            dataGridView2.Size = new Size(685, 566);
            dataGridView2.TabIndex = 0;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // Column5
            // 
            Column5.HeaderText = "ID Transaksi";
            Column5.MinimumWidth = 8;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.HeaderText = "Pembeli";
            Column6.MinimumWidth = 8;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // Column7
            // 
            Column7.HeaderText = "Tanggal Transaksi";
            Column7.MinimumWidth = 8;
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.DarkSlateGray;
            tabPage3.Controls.Add(dataGridView3);
            tabPage3.Location = new Point(4, 37);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1294, 716);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Detail Transakasi";
            // 
            // dataGridView3
            // 
            dataGridView3.AllowUserToAddRows = false;
            dataGridView3.AllowUserToDeleteRows = false;
            dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView3.BackgroundColor = SystemColors.ButtonFace;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Columns.AddRange(new DataGridViewColumn[] { Column8, Column9, Column10, Column11 });
            dataGridView3.Dock = DockStyle.Fill;
            dataGridView3.Location = new Point(3, 3);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.ReadOnly = true;
            dataGridView3.RowHeadersVisible = false;
            dataGridView3.RowHeadersWidth = 62;
            dataGridView3.RowTemplate.Height = 33;
            dataGridView3.Size = new Size(1288, 710);
            dataGridView3.TabIndex = 1;
            // 
            // Column8
            // 
            Column8.FillWeight = 93.45795F;
            Column8.HeaderText = "ID Detail Transaksi";
            Column8.MinimumWidth = 8;
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            // 
            // Column9
            // 
            Column9.FillWeight = 98.56892F;
            Column9.HeaderText = "ID Transaksi";
            Column9.MinimumWidth = 8;
            Column9.Name = "Column9";
            Column9.ReadOnly = true;
            // 
            // Column10
            // 
            Column10.FillWeight = 102.485733F;
            Column10.HeaderText = "ID Laptop";
            Column10.MinimumWidth = 8;
            Column10.Name = "Column10";
            Column10.ReadOnly = true;
            // 
            // Column11
            // 
            Column11.FillWeight = 105.487411F;
            Column11.HeaderText = "Jumlah";
            Column11.MinimumWidth = 8;
            Column11.Name = "Column11";
            Column11.ReadOnly = true;
            // 
            // Weather
            // 
            Weather.BackColor = Color.DarkSlateGray;
            Weather.Controls.Add(pic_Icon);
            Weather.Controls.Add(lab_Pressure);
            Weather.Controls.Add(lab_Windspeed);
            Weather.Controls.Add(lab_Sunset);
            Weather.Controls.Add(label22);
            Weather.Controls.Add(label23);
            Weather.Controls.Add(lab_Sunrise);
            Weather.Controls.Add(label17);
            Weather.Controls.Add(lab_);
            Weather.Controls.Add(lab_Detail);
            Weather.Controls.Add(lab_Condition);
            Weather.Controls.Add(TbCity);
            Weather.Controls.Add(textBox8);
            Weather.Controls.Add(button4);
            Weather.Location = new Point(4, 37);
            Weather.Name = "Weather";
            Weather.Padding = new Padding(3);
            Weather.Size = new Size(1294, 716);
            Weather.TabIndex = 3;
            Weather.Text = "Weather";
            Weather.Click += Weather_Click;
            // 
            // pic_Icon
            // 
            pic_Icon.Location = new Point(726, 157);
            pic_Icon.Name = "pic_Icon";
            pic_Icon.Size = new Size(491, 452);
            pic_Icon.SizeMode = PictureBoxSizeMode.Zoom;
            pic_Icon.TabIndex = 19;
            pic_Icon.TabStop = false;
            pic_Icon.Click += pic_Icon_Click;
            // 
            // lab_Pressure
            // 
            lab_Pressure.AutoSize = true;
            lab_Pressure.BackColor = Color.Transparent;
            lab_Pressure.Font = new Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lab_Pressure.ForeColor = SystemColors.ButtonFace;
            lab_Pressure.Location = new Point(487, 224);
            lab_Pressure.Name = "lab_Pressure";
            lab_Pressure.Size = new Size(57, 32);
            lab_Pressure.TabIndex = 18;
            lab_Pressure.Text = "N / A";
            // 
            // lab_Windspeed
            // 
            lab_Windspeed.AutoSize = true;
            lab_Windspeed.BackColor = Color.Transparent;
            lab_Windspeed.Font = new Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lab_Windspeed.ForeColor = SystemColors.ButtonFace;
            lab_Windspeed.Location = new Point(487, 170);
            lab_Windspeed.Name = "lab_Windspeed";
            lab_Windspeed.Size = new Size(57, 32);
            lab_Windspeed.TabIndex = 17;
            lab_Windspeed.Text = "N / A";
            // 
            // lab_Sunset
            // 
            lab_Sunset.AutoSize = true;
            lab_Sunset.BackColor = Color.Transparent;
            lab_Sunset.Font = new Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lab_Sunset.ForeColor = SystemColors.ButtonFace;
            lab_Sunset.Location = new Point(169, 338);
            lab_Sunset.Name = "lab_Sunset";
            lab_Sunset.Size = new Size(57, 32);
            lab_Sunset.TabIndex = 16;
            lab_Sunset.Text = "N / A";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.BackColor = Color.Transparent;
            label22.Font = new Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label22.ForeColor = SystemColors.ButtonFace;
            label22.Location = new Point(349, 224);
            label22.Name = "label22";
            label22.Size = new Size(104, 32);
            label22.TabIndex = 13;
            label22.Text = "Pressure :";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.BackColor = Color.Transparent;
            label23.Font = new Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label23.ForeColor = SystemColors.ButtonFace;
            label23.Location = new Point(349, 170);
            label23.Name = "label23";
            label23.Size = new Size(132, 32);
            label23.TabIndex = 12;
            label23.Text = "Wind Speed :";
            // 
            // lab_Sunrise
            // 
            lab_Sunrise.AutoSize = true;
            lab_Sunrise.BackColor = Color.Transparent;
            lab_Sunrise.Font = new Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lab_Sunrise.ForeColor = SystemColors.ButtonFace;
            lab_Sunrise.Location = new Point(169, 284);
            lab_Sunrise.Name = "lab_Sunrise";
            lab_Sunrise.Size = new Size(57, 32);
            lab_Sunrise.TabIndex = 10;
            lab_Sunrise.Text = "N / A";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = Color.Transparent;
            label17.Font = new Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label17.ForeColor = SystemColors.ButtonFace;
            label17.Location = new Point(78, 338);
            label17.Name = "label17";
            label17.Size = new Size(86, 32);
            label17.TabIndex = 9;
            label17.Text = "Sunset :";
            // 
            // lab_
            // 
            lab_.AutoSize = true;
            lab_.BackColor = Color.Transparent;
            lab_.Font = new Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lab_.ForeColor = SystemColors.ButtonFace;
            lab_.Location = new Point(78, 284);
            lab_.Name = "lab_";
            lab_.Size = new Size(92, 32);
            lab_.TabIndex = 8;
            lab_.Text = "Sunrise :";
            // 
            // lab_Detail
            // 
            lab_Detail.AutoSize = true;
            lab_Detail.BackColor = Color.Transparent;
            lab_Detail.Font = new Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lab_Detail.ForeColor = SystemColors.ButtonFace;
            lab_Detail.Location = new Point(78, 229);
            lab_Detail.Name = "lab_Detail";
            lab_Detail.Size = new Size(86, 32);
            lab_Detail.TabIndex = 7;
            lab_Detail.Text = "Details :";
            // 
            // lab_Condition
            // 
            lab_Condition.AutoSize = true;
            lab_Condition.BackColor = Color.Transparent;
            lab_Condition.Font = new Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lab_Condition.ForeColor = SystemColors.ButtonFace;
            lab_Condition.Location = new Point(78, 170);
            lab_Condition.Name = "lab_Condition";
            lab_Condition.Size = new Size(122, 32);
            lab_Condition.TabIndex = 6;
            lab_Condition.Text = "Conditions :";
            // 
            // TbCity
            // 
            TbCity.AutoSize = true;
            TbCity.BackColor = Color.Transparent;
            TbCity.Font = new Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point);
            TbCity.ForeColor = SystemColors.ButtonFace;
            TbCity.Location = new Point(74, 105);
            TbCity.Name = "TbCity";
            TbCity.Size = new Size(51, 32);
            TbCity.TabIndex = 5;
            TbCity.Text = "City";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(139, 106);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(386, 31);
            textBox8.TabIndex = 1;
            // 
            // button4
            // 
            button4.Location = new Point(545, 103);
            button4.Name = "button4";
            button4.Size = new Size(112, 34);
            button4.TabIndex = 0;
            button4.Text = "Search";
            button4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1301, 757);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "ITech";
            Load += Form1_Load_1;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            Weather.ResumeLayout(false);
            Weather.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic_Icon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button3;
        private Button button2;
        private Button button1;
        private DataGridView dataGridView1;
        private Label label5;
        private TextBox textBox5;
        private Label label6;
        private TabPage tabPage3;
        private DataGridView dataGridView3;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column11;
        private PictureBox pictureBox1;
        private TabPage Weather;
        private Button button4;
        private Label label18;
        private Label lab_Sunrise;
        private Label label17;
        private Label lab_;
        private Label lab_Detail;
        private Label lab_Condition;
        private Label TbCity;
        private TextBox textBox8;
        private Label lab_Pressure;
        private Label lab_Windspeed;
        private Label lab_Sunset;
        private Label label22;
        private Label label23;
        private PictureBox pic_Icon;
        private TabPage tabPage2;
        private PictureBox pictureBox2;
        private Label label9;
        private Button button8;
        private Label label7;
        private TextBox textBox6;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private Label label14;
        private TextBox textBox12;
    }
}
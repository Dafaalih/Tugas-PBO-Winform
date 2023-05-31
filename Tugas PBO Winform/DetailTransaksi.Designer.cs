namespace Tugas_PBO_Winform
{
    partial class DetailTransaksi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label12 = new Label();
            label13 = new Label();
            textBox10 = new TextBox();
            textBox11 = new TextBox();
            button8 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = SystemColors.ButtonFace;
            label12.Location = new Point(58, 176);
            label12.Name = "label12";
            label12.Size = new Size(84, 32);
            label12.TabIndex = 31;
            label12.Text = "Jumlah";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = SystemColors.ButtonFace;
            label13.Location = new Point(58, 120);
            label13.Name = "label13";
            label13.Size = new Size(99, 32);
            label13.TabIndex = 30;
            label13.Text = "ID Laptop";
            // 
            // textBox10
            // 
            textBox10.Location = new Point(191, 177);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(318, 31);
            textBox10.TabIndex = 3;
            textBox10.TextChanged += textBox10_TextChanged;
            // 
            // textBox11
            // 
            textBox11.Location = new Point(191, 121);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(318, 31);
            textBox11.TabIndex = 2;
            // 
            // button8
            // 
            button8.Font = new Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button8.ForeColor = Color.DarkSlateGray;
            button8.Location = new Point(191, 239);
            button8.Name = "button8";
            button8.Size = new Size(112, 34);
            button8.TabIndex = 25;
            button8.Text = "Upload";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(58, 63);
            label1.Name = "label1";
            label1.Size = new Size(127, 32);
            label1.TabIndex = 33;
            label1.Text = "ID Transaksi";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(191, 64);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(318, 31);
            textBox1.TabIndex = 1;
            // 
            // DetailTransaksi
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(611, 397);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(label12);
            Controls.Add(label13);
            Controls.Add(textBox10);
            Controls.Add(textBox11);
            Controls.Add(button8);
            Name = "DetailTransaksi";
            StartPosition = FormStartPosition.CenterParent;
            Text = "DetailTransaksi";
            Load += DetailTransaksi_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label12;
        private Label label13;
        private TextBox textBox10;
        private TextBox textBox11;
        private Button button8;
        private Label label1;
        private TextBox textBox1;
    }
}
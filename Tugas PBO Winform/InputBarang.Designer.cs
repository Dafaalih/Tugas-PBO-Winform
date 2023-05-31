namespace Tugas_PBO_Winform
{
    partial class InputBarang
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
            button8 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = SystemColors.ButtonFace;
            label12.Location = new Point(37, 80);
            label12.Name = "label12";
            label12.Size = new Size(456, 32);
            label12.TabIndex = 32;
            label12.Text = "Apakah anda ingin mengimputkan barang lagi?\r\n";
            label12.Click += label12_Click;
            // 
            // button8
            // 
            button8.Font = new Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button8.ForeColor = Color.DarkSlateGray;
            button8.Location = new Point(116, 141);
            button8.Name = "button8";
            button8.Size = new Size(112, 34);
            button8.TabIndex = 33;
            button8.Text = "Iya";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.DarkSlateGray;
            button1.Location = new Point(298, 141);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 34;
            button1.Text = "Tidak";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // InputBarang
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(538, 283);
            Controls.Add(button1);
            Controls.Add(button8);
            Controls.Add(label12);
            Name = "InputBarang";
            StartPosition = FormStartPosition.CenterParent;
            Text = "InputBarang";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label12;
        private Button button8;
        private Button button1;
    }
}
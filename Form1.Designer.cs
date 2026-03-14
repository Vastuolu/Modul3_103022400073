namespace Modul3_103022400073
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
            satuanAwal = new ComboBox();
            satuanAkhir = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            nilaiAwal = new TextBox();
            nilaiAkhir = new TextBox();
            label3 = new Label();
            label4 = new Label();
            convertBtn = new Button();
            SuspendLayout();
            // 
            // satuanAwal
            // 
            satuanAwal.FormattingEnabled = true;
            satuanAwal.Items.AddRange(new object[] { "Celcius", "Fahrenheit", "Kelvin", "Reamur" });
            satuanAwal.Location = new Point(101, 139);
            satuanAwal.Name = "satuanAwal";
            satuanAwal.Size = new Size(125, 28);
            satuanAwal.TabIndex = 0;
            satuanAwal.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // satuanAkhir
            // 
            satuanAkhir.FormattingEnabled = true;
            satuanAkhir.Items.AddRange(new object[] { "Celcius", "Fahrenheit", "Kelvin", "Reamur" });
            satuanAkhir.Location = new Point(101, 214);
            satuanAkhir.Name = "satuanAkhir";
            satuanAkhir.Size = new Size(125, 28);
            satuanAkhir.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(120, 116);
            label1.Name = "label1";
            label1.Size = new Size(91, 20);
            label1.TabIndex = 2;
            label1.Text = "Satuan Awal";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(120, 191);
            label2.Name = "label2";
            label2.Size = new Size(92, 20);
            label2.TabIndex = 3;
            label2.Text = "Satuan Akhir";
            label2.Click += label2_Click;
            // 
            // nilaiAwal
            // 
            nilaiAwal.Location = new Point(275, 139);
            nilaiAwal.Name = "nilaiAwal";
            nilaiAwal.Size = new Size(235, 27);
            nilaiAwal.TabIndex = 4;
            // 
            // nilaiAkhir
            // 
            nilaiAkhir.Location = new Point(275, 214);
            nilaiAkhir.Name = "nilaiAkhir";
            nilaiAkhir.ReadOnly = true;
            nilaiAkhir.Size = new Size(235, 27);
            nilaiAkhir.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(275, 116);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 6;
            label3.Text = "Nilai Awal";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(275, 191);
            label4.Name = "label4";
            label4.Size = new Size(78, 20);
            label4.TabIndex = 7;
            label4.Text = "Nilai Akhir";
            label4.Click += label4_Click;
            // 
            // convertBtn
            // 
            convertBtn.Location = new Point(556, 139);
            convertBtn.Name = "convertBtn";
            convertBtn.Size = new Size(94, 29);
            convertBtn.TabIndex = 8;
            convertBtn.Text = "Convert";
            convertBtn.UseVisualStyleBackColor = true;
            convertBtn.Click += convertBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(convertBtn);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(nilaiAkhir);
            Controls.Add(nilaiAwal);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(satuanAkhir);
            Controls.Add(satuanAwal);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox satuanAwal;
        private ComboBox satuanAkhir;
        private Label label1;
        private Label label2;
        private TextBox nilaiAwal;
        private TextBox nilaiAkhir;
        private Label label3;
        private Label label4;
        private Button convertBtn;
    }
}

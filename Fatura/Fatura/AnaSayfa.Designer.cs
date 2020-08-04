namespace Fatura
{
    partial class AnaSayfa
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaSayfa));
            this.buttonPrint = new System.Windows.Forms.Button();
            this.buttonPrintPre = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSok = new System.Windows.Forms.TextBox();
            this.textBoxMah = new System.Windows.Forms.TextBox();
            this.textBoxTc = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxİlçe = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxSözlemeNo = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxİmei = new System.Windows.Forms.TextBox();
            this.textBoxMarka = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.textBoxKDV = new System.Windows.Forms.TextBox();
            this.textBoxKdvHaric = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.textBoxToplam = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBoxTrk = new System.Windows.Forms.CheckBox();
            this.checkBoxPage2 = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.checkBoxPage1 = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.checkBoxPage3 = new System.Windows.Forms.CheckBox();
            this.checkBoxkdvharic = new System.Windows.Forms.CheckBox();
            this.checkBoxkdvtoplam = new System.Windows.Forms.CheckBox();
            this.textBoxTuturText = new System.Windows.Forms.TextBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonPrint
            // 
            this.buttonPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buttonPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrint.Font = new System.Drawing.Font("Turkcell Satura", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonPrint.ForeColor = System.Drawing.Color.White;
            this.buttonPrint.Location = new System.Drawing.Point(542, 404);
            this.buttonPrint.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(152, 43);
            this.buttonPrint.TabIndex = 0;
            this.buttonPrint.Text = "Yazdır";
            this.buttonPrint.UseVisualStyleBackColor = false;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // buttonPrintPre
            // 
            this.buttonPrintPre.BackColor = System.Drawing.Color.Transparent;
            this.buttonPrintPre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrintPre.Font = new System.Drawing.Font("Turkcell Satura", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonPrintPre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buttonPrintPre.Location = new System.Drawing.Point(414, 404);
            this.buttonPrintPre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonPrintPre.Name = "buttonPrintPre";
            this.buttonPrintPre.Size = new System.Drawing.Size(124, 43);
            this.buttonPrintPre.TabIndex = 1;
            this.buttonPrintPre.Text = "Önizleme";
            this.buttonPrintPre.UseVisualStyleBackColor = false;
            this.buttonPrintPre.Click += new System.EventHandler(this.buttonPrintPre_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.AllowCurrentPage = true;
            this.printDialog1.AllowSelection = true;
            this.printDialog1.AllowSomePages = true;
            this.printDialog1.Document = this.printDocument1;
            this.printDialog1.PrintToFile = true;
            this.printDialog1.ShowHelp = true;
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Text = "Baskı önizleme";
            this.printPreviewDialog1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Turkcell Satura", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(38, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Adı Soyadı:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Turkcell Satura", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(56, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mahalle:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Turkcell Satura", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(21, 67);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sokak/Cadde:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Turkcell Satura", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(74, 98);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "İlçe/İl:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Turkcell Satura", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(4, 63);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "TC/VD-Vergi No:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Enabled = false;
            this.label8.Font = new System.Drawing.Font("Turkcell Satura", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(21, 69);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 18);
            this.label8.TabIndex = 9;
            this.label8.Text = "Sözleşme No:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Enabled = false;
            this.label9.Font = new System.Drawing.Font("Turkcell Satura", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(56, 35);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(201, 18);
            this.label9.TabIndex = 10;
            this.label9.Text = "TURKCELL TEMLİK EDİLMİŞTİR";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd.MM.yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Turkcell Satura", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(575, 58);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(119, 25);
            this.dateTimePicker1.TabIndex = 14;
            this.dateTimePicker1.Value = new System.DateTime(2020, 8, 4, 0, 0, 0, 0);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(121, 29);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(190, 25);
            this.textBoxName.TabIndex = 15;
            // 
            // textBoxSok
            // 
            this.textBoxSok.Location = new System.Drawing.Point(121, 64);
            this.textBoxSok.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxSok.Name = "textBoxSok";
            this.textBoxSok.Size = new System.Drawing.Size(190, 25);
            this.textBoxSok.TabIndex = 16;
            // 
            // textBoxMah
            // 
            this.textBoxMah.Location = new System.Drawing.Point(121, 33);
            this.textBoxMah.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxMah.Name = "textBoxMah";
            this.textBoxMah.Size = new System.Drawing.Size(190, 25);
            this.textBoxMah.TabIndex = 17;
            // 
            // textBoxTc
            // 
            this.textBoxTc.Location = new System.Drawing.Point(121, 59);
            this.textBoxTc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxTc.Name = "textBoxTc";
            this.textBoxTc.Size = new System.Drawing.Size(190, 25);
            this.textBoxTc.TabIndex = 18;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBoxName);
            this.groupBox1.Controls.Add(this.textBoxTc);
            this.groupBox1.Font = new System.Drawing.Font("Turkcell Satura", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(12, 87);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(315, 105);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri ";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxİlçe);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBoxSok);
            this.groupBox2.Controls.Add(this.textBoxMah);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Turkcell Satura", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(12, 196);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(315, 143);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Adres";
            // 
            // textBoxİlçe
            // 
            this.textBoxİlçe.Location = new System.Drawing.Point(121, 95);
            this.textBoxİlçe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxİlçe.Name = "textBoxİlçe";
            this.textBoxİlçe.Size = new System.Drawing.Size(190, 25);
            this.textBoxİlçe.TabIndex = 18;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBoxTrk);
            this.groupBox3.Controls.Add(this.textBoxSözlemeNo);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Font = new System.Drawing.Font("Turkcell Satura", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(12, 343);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(315, 118);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Turkcell";
            // 
            // textBoxSözlemeNo
            // 
            this.textBoxSözlemeNo.Enabled = false;
            this.textBoxSözlemeNo.Location = new System.Drawing.Point(120, 65);
            this.textBoxSözlemeNo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxSözlemeNo.Name = "textBoxSözlemeNo";
            this.textBoxSözlemeNo.Size = new System.Drawing.Size(190, 25);
            this.textBoxSözlemeNo.TabIndex = 19;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.textBoxİmei);
            this.groupBox4.Controls.Add(this.textBoxMarka);
            this.groupBox4.Font = new System.Drawing.Font("Turkcell Satura", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox4.ForeColor = System.Drawing.Color.Black;
            this.groupBox4.Location = new System.Drawing.Point(342, 87);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Size = new System.Drawing.Size(353, 105);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ürün";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Turkcell Satura", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(4, 36);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 18);
            this.label12.TabIndex = 3;
            this.label12.Text = "Marka-Model";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Turkcell Satura", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(4, 67);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 18);
            this.label13.TabIndex = 4;
            this.label13.Text = "İmei:";
            // 
            // textBoxİmei
            // 
            this.textBoxİmei.Location = new System.Drawing.Point(121, 64);
            this.textBoxİmei.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxİmei.MaxLength = 16;
            this.textBoxİmei.Name = "textBoxİmei";
            this.textBoxİmei.Size = new System.Drawing.Size(190, 25);
            this.textBoxİmei.TabIndex = 16;
            // 
            // textBoxMarka
            // 
            this.textBoxMarka.Location = new System.Drawing.Point(121, 33);
            this.textBoxMarka.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxMarka.Name = "textBoxMarka";
            this.textBoxMarka.Size = new System.Drawing.Size(190, 25);
            this.textBoxMarka.TabIndex = 17;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBoxTuturText);
            this.groupBox5.Controls.Add(this.checkBoxkdvtoplam);
            this.groupBox5.Controls.Add(this.checkBoxkdvharic);
            this.groupBox5.Controls.Add(this.textBoxToplam);
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.textBoxKDV);
            this.groupBox5.Controls.Add(this.textBoxKdvHaric);
            this.groupBox5.Font = new System.Drawing.Font("Turkcell Satura", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox5.ForeColor = System.Drawing.Color.Black;
            this.groupBox5.Location = new System.Drawing.Point(342, 196);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox5.Size = new System.Drawing.Size(353, 143);
            this.groupBox5.TabIndex = 22;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Tutar";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Turkcell Satura", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(6, 25);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(114, 18);
            this.label15.TabIndex = 3;
            this.label15.Text = "Kdv Hariç Tutar:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Turkcell Satura", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.Location = new System.Drawing.Point(41, 56);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(76, 18);
            this.label16.TabIndex = 4;
            this.label16.Text = "KDV %18 :";
            // 
            // textBoxKDV
            // 
            this.textBoxKDV.Enabled = false;
            this.textBoxKDV.Location = new System.Drawing.Point(121, 53);
            this.textBoxKDV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxKDV.Name = "textBoxKDV";
            this.textBoxKDV.Size = new System.Drawing.Size(190, 25);
            this.textBoxKDV.TabIndex = 16;
            this.textBoxKDV.TextChanged += new System.EventHandler(this.textBoxKDV_TextChanged);
            // 
            // textBoxKdvHaric
            // 
            this.textBoxKdvHaric.Location = new System.Drawing.Point(121, 22);
            this.textBoxKdvHaric.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxKdvHaric.Name = "textBoxKdvHaric";
            this.textBoxKdvHaric.Size = new System.Drawing.Size(190, 25);
            this.textBoxKdvHaric.TabIndex = 17;
            this.textBoxKdvHaric.TextChanged += new System.EventHandler(this.textBoxKdvHaric_TextChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Turkcell Satura", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.Location = new System.Drawing.Point(19, 83);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(98, 18);
            this.label17.TabIndex = 18;
            this.label17.Text = "Toplam Tutar:";
            // 
            // textBoxToplam
            // 
            this.textBoxToplam.Location = new System.Drawing.Point(121, 80);
            this.textBoxToplam.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxToplam.Name = "textBoxToplam";
            this.textBoxToplam.Size = new System.Drawing.Size(190, 25);
            this.textBoxToplam.TabIndex = 19;
            this.textBoxToplam.TextChanged += new System.EventHandler(this.textBoxToplam_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Turkcell Satura", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(523, 63);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 18);
            this.label6.TabIndex = 18;
            this.label6.Text = "Tarih:";
            // 
            // checkBoxTrk
            // 
            this.checkBoxTrk.AutoSize = true;
            this.checkBoxTrk.Location = new System.Drawing.Point(262, 37);
            this.checkBoxTrk.Name = "checkBoxTrk";
            this.checkBoxTrk.Size = new System.Drawing.Size(15, 14);
            this.checkBoxTrk.TabIndex = 20;
            this.checkBoxTrk.UseVisualStyleBackColor = true;
            this.checkBoxTrk.CheckedChanged += new System.EventHandler(this.checkBoxTrk_CheckedChanged);
            // 
            // checkBoxPage2
            // 
            this.checkBoxPage2.AutoSize = true;
            this.checkBoxPage2.Checked = true;
            this.checkBoxPage2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxPage2.Location = new System.Drawing.Point(184, 24);
            this.checkBoxPage2.Name = "checkBoxPage2";
            this.checkBoxPage2.Size = new System.Drawing.Size(15, 14);
            this.checkBoxPage2.TabIndex = 21;
            this.checkBoxPage2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(118, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 18);
            this.label7.TabIndex = 23;
            this.label7.Text = "2.Nüsha";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label11);
            this.groupBox6.Controls.Add(this.checkBoxPage3);
            this.groupBox6.Controls.Add(this.label10);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Controls.Add(this.checkBoxPage2);
            this.groupBox6.Controls.Add(this.checkBoxPage1);
            this.groupBox6.Location = new System.Drawing.Point(342, 344);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(352, 52);
            this.groupBox6.TabIndex = 24;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Fatura Ayarı";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(6, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 18);
            this.label10.TabIndex = 26;
            this.label10.Text = "1.Nüsha";
            // 
            // checkBoxPage1
            // 
            this.checkBoxPage1.AutoSize = true;
            this.checkBoxPage1.Checked = true;
            this.checkBoxPage1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxPage1.Location = new System.Drawing.Point(72, 24);
            this.checkBoxPage1.Name = "checkBoxPage1";
            this.checkBoxPage1.Size = new System.Drawing.Size(15, 14);
            this.checkBoxPage1.TabIndex = 25;
            this.checkBoxPage1.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(230, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 18);
            this.label11.TabIndex = 28;
            this.label11.Text = "3.Nüsha";
            // 
            // checkBoxPage3
            // 
            this.checkBoxPage3.AutoSize = true;
            this.checkBoxPage3.Checked = true;
            this.checkBoxPage3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxPage3.Location = new System.Drawing.Point(296, 24);
            this.checkBoxPage3.Name = "checkBoxPage3";
            this.checkBoxPage3.Size = new System.Drawing.Size(15, 14);
            this.checkBoxPage3.TabIndex = 27;
            this.checkBoxPage3.UseVisualStyleBackColor = true;
            // 
            // checkBoxkdvharic
            // 
            this.checkBoxkdvharic.AutoSize = true;
            this.checkBoxkdvharic.Location = new System.Drawing.Point(317, 28);
            this.checkBoxkdvharic.Name = "checkBoxkdvharic";
            this.checkBoxkdvharic.Size = new System.Drawing.Size(15, 14);
            this.checkBoxkdvharic.TabIndex = 20;
            this.checkBoxkdvharic.UseVisualStyleBackColor = true;
            this.checkBoxkdvharic.CheckedChanged += new System.EventHandler(this.checkBoxkdvharic_CheckedChanged);
            // 
            // checkBoxkdvtoplam
            // 
            this.checkBoxkdvtoplam.AutoSize = true;
            this.checkBoxkdvtoplam.Checked = true;
            this.checkBoxkdvtoplam.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxkdvtoplam.Location = new System.Drawing.Point(317, 86);
            this.checkBoxkdvtoplam.Name = "checkBoxkdvtoplam";
            this.checkBoxkdvtoplam.Size = new System.Drawing.Size(15, 14);
            this.checkBoxkdvtoplam.TabIndex = 21;
            this.checkBoxkdvtoplam.UseVisualStyleBackColor = true;
            this.checkBoxkdvtoplam.CheckedChanged += new System.EventHandler(this.checkBoxkdvtoplam_CheckedChanged);
            // 
            // textBoxTuturText
            // 
            this.textBoxTuturText.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBoxTuturText.Location = new System.Drawing.Point(9, 110);
            this.textBoxTuturText.Name = "textBoxTuturText";
            this.textBoxTuturText.Size = new System.Drawing.Size(339, 25);
            this.textBoxTuturText.TabIndex = 22;
            this.textBoxTuturText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.Transparent;
            this.buttonClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonClose.BackgroundImage")));
            this.buttonClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonClose.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.ForeColor = System.Drawing.Color.Black;
            this.buttonClose.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonClose.Location = new System.Drawing.Point(674, 3);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(30, 30);
            this.buttonClose.TabIndex = 25;
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(709, 475);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.buttonPrintPre);
            this.Controls.Add(this.buttonPrint);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Font = new System.Drawing.Font("Turkcell Satura", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(12, 90, 12, 12);
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RightToLeftLayout = true;
            this.ShowTitle = false;
            this.SmallLineColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.SmallLineColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Genç Teknoloji Fatura İrsaliye";
            this.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.Button buttonPrintPre;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxSok;
        private System.Windows.Forms.TextBox textBoxMah;
        private System.Windows.Forms.TextBox textBoxTc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxİlçe;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkBoxTrk;
        private System.Windows.Forms.TextBox textBoxSözlemeNo;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxİmei;
        private System.Windows.Forms.TextBox textBoxMarka;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox textBoxToplam;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBoxKDV;
        private System.Windows.Forms.TextBox textBoxKdvHaric;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBoxPage2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox checkBoxPage3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox checkBoxPage1;
        private System.Windows.Forms.CheckBox checkBoxkdvtoplam;
        private System.Windows.Forms.CheckBox checkBoxkdvharic;
        private System.Windows.Forms.TextBox textBoxTuturText;
        private System.Windows.Forms.Button buttonClose;
    }
}


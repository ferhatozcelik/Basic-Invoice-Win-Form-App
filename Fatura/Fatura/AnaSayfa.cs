using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fatura
{
    public partial class AnaSayfa : MetroSet_UI.Forms.MetroSetForm
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            DialogResult yazdirmaIslemi;
            yazdirmaIslemi = printDialog1.ShowDialog();
            if (yazdirmaIslemi == DialogResult.OK)
            {
                printDialog1.ShowDialog();
            }
        }

        private void buttonPrintPre_Click(object sender, EventArgs e)
        {
            DialogResult yazdirmaIslemi;
            yazdirmaIslemi = printPreviewDialog1.ShowDialog();
            if (yazdirmaIslemi == DialogResult.OK)
            {
                printPreviewDialog1.ShowDialog();
            }
        }
        private void DrawRotatedTextAt(Graphics gr, float angle,
            string txt, int x, int y, Font the_font, Brush the_brush)
        {
            // Save the graphics state.
            GraphicsState state = gr.Save();
            gr.ResetTransform();

            // Rotate.
            gr.RotateTransform(angle);

            // Translate to desired position. Be sure to append
            // the rotation so it occurs after the rotation.
            gr.TranslateTransform(x, y, MatrixOrder.Append);

            // Draw the text at the origin.
            gr.DrawString(txt, the_font, the_brush, 0, 0);

            // Restore the graphics state.
            gr.Restore(state);
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
           
           using (Font the_font = new Font("Calibri", 12, FontStyle.Bold))
            {    //boy - en
                //Deneme Metni 
                DrawRotatedTextAt(e.Graphics, 90, "Deneme Metni", 100, 100, the_font, Brushes.Black);

                //Tarih
                DrawRotatedTextAt(e.Graphics, 90, dateTimePicker1.Value.Date.ToString("dd/MM/yyyy"), 500,100, the_font, Brushes.Black);
                DrawRotatedTextAt(e.Graphics, 90, dateTimePicker1.Value.Date.ToString("dd/MM/yyyy"), 520,100, the_font, Brushes.Black);
                DrawRotatedTextAt(e.Graphics, 90, dateTimePicker1.Value.Date.ToString("dd/MM/yyyy"), 540,100, the_font, Brushes.Black);
               //Ad
                DrawRotatedTextAt(e.Graphics, 90, textBoxName.Text, 700, 300, the_font, Brushes.Black);
                DrawRotatedTextAt(e.Graphics, 90, textBoxTc.Text, 650, 300, the_font, Brushes.Black);

                DrawRotatedTextAt(e.Graphics, 90, textBoxMah.Text, 500, 300, the_font, Brushes.Black);
                DrawRotatedTextAt(e.Graphics, 90, textBoxSok.Text, 550, 300, the_font, Brushes.Black);
                DrawRotatedTextAt(e.Graphics, 90, textBoxİlçe.Text, 450, 300, the_font, Brushes.Black);
                DrawRotatedTextAt(e.Graphics, 90, textBoxMarka.Text, 400, 300, the_font, Brushes.Black);
                DrawRotatedTextAt(e.Graphics, 90, textBoxİmei.Text, 380, 300, the_font, Brushes.Black);
                DrawRotatedTextAt(e.Graphics, 90, textBoxKdvHaric.Text, 350, 300, the_font, Brushes.Black);
                DrawRotatedTextAt(e.Graphics, 90, textBoxKDV.Text, 300, 300, the_font, Brushes.Black);
                DrawRotatedTextAt(e.Graphics, 90, textBoxToplam.Text, 200, 300, the_font, Brushes.Black);

                if (checkBoxTrk.Checked)
                {
                    if(textBoxSözlemeNo.Text != "")
                    {
                        DrawRotatedTextAt(e.Graphics, 90, textBoxSözlemeNo.Text, 900, 300, the_font, Brushes.Black);
                        DrawRotatedTextAt(e.Graphics, 90, "TURKCELL TEMLİK EDİLMİŞTİR", 950, 300, the_font, Brushes.Black);

                    }
                    else
                    {
                        Alert("Sözleşme No Yazınız!");
                    }
                }












            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.dateTimePicker1.Value = DateTime.Now;
            if (checkBoxkdvtoplam.Checked)
            {
                textBoxToplam.Enabled = true;
                textBoxKdvHaric.Enabled = false;
                checkBoxkdvharic.Enabled = true;
                checkBoxkdvtoplam.Enabled = false;
                checkBoxkdvharic.Checked = false;
                textBoxToplam.Text = "";
                textBoxKdvHaric.Text = "";
            }



        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        float kdvliFiyat, fiyat , hesaplanankdv;
        float kdv = 18;
        //Tutar
        private void textBoxToplam_TextChanged(object sender, EventArgs e)
        {
            if (checkBoxkdvtoplam.Checked)
            {
                try
                {

                    fiyat = 0;
                    kdvliFiyat = 0;
                    hesaplanankdv = 0;
                    kdvliFiyat = float.Parse(textBoxToplam.Text);
                    hesaplanankdv = (1 + (kdv / 100));
                    fiyat = kdvliFiyat / hesaplanankdv;
                    textBoxKdvHaric.Text = Convert.ToString(fiyat);
                    textBoxKDV.Text = Convert.ToString(kdvliFiyat- fiyat);

                    MetineCevir(textBoxToplam.Text);
                }
                catch (Exception)
                {

                }
            }

        }
        
        string onbinler, binler, yuzler, onlar, birler;
        int sayı, basamak4, basamak3, basamak2, basamak1, basamak5;

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBoxTrk_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTrk.Checked)
            {
                textBoxSözlemeNo.Enabled = true;
                label8.Enabled = true;
                label9.Enabled = true;
            }
            else
            {

                textBoxSözlemeNo.Enabled = false;
                label8.Enabled = false;
                label9.Enabled = false;
            }
        }

        private void MetineCevir(string text)
        {
            sayı = int.Parse(text);
            basamak5 = sayı / 10000;
            sayı = sayı % 10000;
            switch (basamak5)
            {
                case 1: onbinler = "on"; break;
                case 2: onbinler = "yirmi"; break;
                case 3: onbinler = "otuz"; break;
                case 4: onbinler = "kırk"; break;
                case 5: onbinler = "elli"; break;
                case 6: onbinler = "atmış"; break;
                case 7: onbinler = "yetmiş"; break;
                case 8: onbinler = "seksen"; break;
                case 9: onbinler = "doksan"; break;
            }

            basamak4 = sayı / 1000;
            sayı = sayı % 1000;
            switch (basamak4)
            {
                case 1: binler = "bin"; break;
                case 2: binler = "ikibin"; break;
                case 3: binler = "üçbin"; break;
                case 4: binler = "dörtbin"; break;
                case 5: binler = "beşbin"; break;
                case 6: binler = "altıbin"; break;
                case 7: binler = "yedibin"; break;
                case 8: binler = "sekizbin"; break;
                case 9: binler = "dokuzbin"; break;

                default:
                    binler = "";
                    break;
            }
            basamak3 = sayı / 100;
            sayı = sayı % 100;
            switch (basamak3)
            {
                case 1: yuzler = "yüz"; break;
                case 2: yuzler = "ikiyüz"; break;
                case 3: yuzler = "üçyüz"; break;
                case 4: yuzler = "dörtyüz"; break;
                case 5: yuzler = "beşyüz"; break;
                case 6: yuzler = "altıyüz"; break;
                case 7: yuzler = "yediyüz"; break;
                case 8: yuzler = "sekizyüz"; break;
                case 9: yuzler = "dokuzyüz"; break;
                default:
                    yuzler = "";
                    break;
            }
            basamak2 = sayı / 10;
            sayı = sayı % 10;
            switch (basamak2)
            {
                case 1: onlar = "on"; break;
                case 2: onlar = "yirmi"; break;
                case 3: onlar = "otuz"; break;
                case 4: onlar = "kırk"; break;
                case 5: onlar = "elli"; break;
                case 6: onlar = "atmış"; break;
                case 7: onlar = "yetmiş"; break;
                case 8: onlar = "seksen"; break;
                case 9: onlar = "doksan"; break;
                default:
                    onlar = "";
                    break;
            }
            basamak1 = sayı / 1;
            sayı = sayı % 1;
            switch (basamak1)
            {
                case 1: birler = "bir"; break;
                case 2: birler = "iki"; break;
                case 3: birler = "üç"; break;
                case 4: birler = "dört"; break;
                case 5: birler = "beş"; break;
                case 6: birler = "altı"; break;
                case 7: birler = "yedi"; break;
                case 8: birler = "sekiz"; break;
                case 9: birler = "dokuz"; break;
                default:
                    birler = "";
                    break;
            }

            string tutaryazi = onbinler + " " + binler + " " + yuzler + " " + onlar + " " + birler;
            textBoxTuturText.Text = tutaryazi.ToUpper();



    }

        private void textBoxKDV_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxkdvharic_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBoxkdvharic.Checked)
            {
                textBoxToplam.Enabled = false;
                textBoxKdvHaric.Enabled = true;
                checkBoxkdvharic.Enabled = false;
                checkBoxkdvtoplam.Enabled = true;
                checkBoxkdvtoplam.Checked = false;
                textBoxToplam.Text = "";
                textBoxKdvHaric.Text = "";

            }
            
        }

        private void checkBoxkdvtoplam_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxkdvtoplam.Checked)
            {
                textBoxToplam.Enabled = true;
                textBoxKdvHaric.Enabled = false;

                checkBoxkdvharic.Enabled = true;
                checkBoxkdvtoplam.Enabled = false;

                checkBoxkdvharic.Checked = false; 
                textBoxToplam.Text = "";
                textBoxKdvHaric.Text = "";
            }
        }

        private void textBoxKdvHaric_TextChanged(object sender, EventArgs e)
        {
            if (checkBoxkdvharic.Checked)
            {
                try
                {

                    fiyat = 0;
                    kdvliFiyat = 0;
                    hesaplanankdv = 0;
                    fiyat = float.Parse(textBoxKdvHaric.Text);
                    hesaplanankdv = fiyat * (kdv / 100);
                    kdvliFiyat = fiyat + hesaplanankdv;
                    textBoxToplam.Text = Convert.ToString(kdvliFiyat);
                    textBoxKDV.Text = Convert.ToString(hesaplanankdv);
                }
                catch (Exception)
                {
                }

            }
        }

        private void Alert(string v)
        {
            MessageBox.Show(v);
        }
    }
}

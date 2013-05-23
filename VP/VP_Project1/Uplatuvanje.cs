using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VP_Project1
{
    public partial class Uplatuvanje : Form
    {
        public decimal vkupno { get; set; }
        public Uplata up { get; set; }
        public Uplatuvanje()
        {
            vkupno = 1;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tb_ime.Text == "") { 
                MessageBox.Show("Името не смее да е празно!");
            }
            else if (comboKonj.SelectedIndex < 0) {
                MessageBox.Show("Одбери Коњ!");
            }
            else if (tb_uplata.Text == "")
            {
                MessageBox.Show("Внеси колку пари уплаќаш!");
            }
            else {
                up = new Uplata(tb_ime.Text, comboKonj.SelectedIndex, Convert.ToDecimal(tb_koeficient.Text), Convert.ToInt32(tb_uplata.Text));
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                Close();

            }

        }

        private void comboKonj_TextChanged(object sender, EventArgs e)
        {
            switch (comboKonj.SelectedIndex)
            {
                case 0:
                    vkupno = (decimal)2.25;
                    tb_koeficient.Text = "2.25";

                    break;
                case 1:
                    vkupno = (decimal)2.25;
                    tb_koeficient.Text = "1.25";
                    break;
                case 2:
                    vkupno = (decimal)2.25;
                    tb_koeficient.Text = "4.25";
                    break;
                case 3:
                    vkupno = (decimal)2.25;
                    tb_koeficient.Text = "5.25";
                    break;
                default:
                    break;
            }
        }

        private void tb_uplata_TextChanged(object sender, EventArgs e)
        {
            
               if (char.IsDigit(this.tb_uplata.Text.Last())==false){
                   MessageBox.Show("Уплатата мора да е број!");
               }
               

        }

        //private void tb_uplata_TextChanged(object sender, EventArgs e)
        //{
        //    //TODO : neso so konvertiranje od sting vo int

        //    //Konvertirawe od string vo int za da se mnozat posle
        //    //tb_vkupno.Text = string.Format(Convert.ToInt32(tb_uplata.Text) * Convert.ToDecimal(tb_koeficient.Text));
        //}

    }
}

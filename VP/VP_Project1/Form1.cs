using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VP_Project1.Properties;

namespace VP_Project1
{
    public partial class form1 : Form
    {
        private int k0_x, k1_x, k2_x, k3_x, k0_y, k1_y, k2_y, k3_y, sis;
        public SoundPlayer sound, gun;
        public form1()
        {
            InitializeComponent();
            vratiNazad();
            sound = new SoundPlayer(Resources.gallop);
            gun = new SoundPlayer(Resources.gun);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            crtaj(g);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var rand = new Random();
            var s = rand.Next(1, 100);
            label1.Text = s.ToString();
            label2.Text = (s % 4).ToString();
            if (s % 4 == 0)
            {
                k0_x += 12;
                End(k0_x, 0);
            }
            else if (s % 4 == 1)
            {
                k1_x += 12;
                End(k1_x, 1);
            }
            else if (s % 4 == 2)
            {
                k2_x += 12;
                End(k2_x, 2);
            }
            else if (s % 4 == 3)
            {
                k3_x += 12;
                End(k3_x, 3);
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void crtaj(Graphics g)
        {
            if (sis == 0)
            {
                g.DrawImageUnscaled(Resources.k0_3, k0_x, k0_y);
                g.DrawImageUnscaled(Resources.k1_0, k1_x, k1_y);
                g.DrawImageUnscaled(Resources.k2_0, k2_x, k2_y);
                g.DrawImageUnscaled(Resources.k3_0, k3_x, k3_y);
                sis = 1;
            }
            else if (sis == 1)
            {
                g.DrawImageUnscaled(Resources.k0_1, k0_x, k0_y);
                g.DrawImageUnscaled(Resources.k1_1, k1_x, k1_y);
                g.DrawImageUnscaled(Resources.k2_1, k2_x, k2_y);
                g.DrawImageUnscaled(Resources.k3_1, k3_x, k3_y);
                sis = 2;
            }
            else if (sis == 2)
            {
                g.DrawImageUnscaled(Resources.k0_2, k0_x, k0_y);
                g.DrawImageUnscaled(Resources.k1_2, k1_x, k1_y);
                g.DrawImageUnscaled(Resources.k2_2, k2_x, k2_y);
                g.DrawImageUnscaled(Resources.k3_2, k3_x, k3_y);
                sis = 3;
            }

            else if (sis == 3)
            {
                g.DrawImageUnscaled(Resources.k0_0, k0_x, k0_y);
                g.DrawImageUnscaled(Resources.k1_3, k1_x, k1_y);
                g.DrawImageUnscaled(Resources.k2_3, k2_x, k2_y);
                g.DrawImageUnscaled(Resources.k3_0, k3_x, k3_y);
                sis = 0;
            }
        }
        public void vratiNazad()
        {
            button1.Enabled = true;
            button2.Enabled = true;
            lbUplata.Items.Clear();
            k0_x = 0;
            k1_x = 0;
            k2_x = 0;
            k3_x = 0;
            k0_y = -15;
            k1_y = 70;
            k2_y = 155;
            k3_y = 240;
            sis = 0;
            Invalidate();
        }
        public void End(int x, int konj)
        {
            Invalidate();
            label2.Text = x.ToString();
            if (x > 385)
            {
                timer1.Stop();
                timer2.Stop();
                sound.Stop();
                switch (konj)
                {
                    case 0:
                        MessageBox.Show("Pobedi prviot");
                        vratiNazad();
                        break;
                    case 1:
                        MessageBox.Show("Pobedi 2");
                        vratiNazad();
                        break;
                    case 2:
                        MessageBox.Show("Pobedi 3");
                        vratiNazad();
                        break;
                    case 3:
                        MessageBox.Show("Pobedi 4");
                        vratiNazad();
                        break;
                    default:
                        break;
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Uplatuvanje upl = new Uplatuvanje();
            if (upl.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                lbUplata.Items.Add(upl.up);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            gun.PlaySync();
            sound.PlayLooping();

            button1.Enabled = false;
            timer1.Start();
            timer2.Start();
        }
    }

}

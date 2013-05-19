using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VP_Project1.Properties;

namespace VP_Project1
{
    public partial class Form1 : Form
    {
        private Image k0,k1,k2,k3;
        private int k0_x, k1_x, k2_x, k3_x, k0_y, k1_y, k2_y, k3_y,sis;
        public Form1()
        {
            InitializeComponent();
            k0 = Resources.k0;
            k1 = Resources.k1;
            k2 = Resources.k2;
            k3 = Resources.k3;           
            k0_x = 0;
            k1_x = 0;
            k2_x = 0;
            k3_x = 0;
            k0_y = 20;
            k1_y = 70;
            k2_y = 130;
            k3_y = 180;
            sis = 0;
            timer1.Start();
            timer2.Start();
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
            label1.Text = s.ToString() ;
            label2.Text = (s % 4).ToString();
            if (s % 4 == 0) {
                k0_x += 10;
                Invalidate();
            }
            else if (s % 4 == 1) {
                k1_x += 10;
                Invalidate();
            }
            else if (s % 4 == 2) {
                k2_x += 10;
                Invalidate();
            }
            else if (s % 4 == 3) {
                k3_x += 10;
                Invalidate();
            }
            
            

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Invalidate();
        }
        /*
        private void Form1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyValue.ToString())
            {
                case "39" :
                    label1.Text = "39";
                label1.Left += 5;
                    break;
                case "40":
                    label1.Text = "40";
                    label1.Top += 5;
                    break;
                case "37":
                    label1.Text = "37";
                    label1.Left -= 5;
                    break;
                case "38":
                    label1.Text = "39";
                    label1.Top -= 5;
                    break;
                case "13":
                    MessageBox.Show("Fire Missle");
                    break;
                default:
                    break;
            }
            
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Pen a = new Pen(Color.Red,4);
            Graphics g = this.CreateGraphics();
            g.DrawEllipse(a, e.X-60, e.Y-60, 120, 120);
            
        }
    */
        private void crtaj(Graphics g) {
            if(sis==0){
            g.DrawImageUnscaled(k0, k0_x, k0_y);
            g.DrawImageUnscaled(k1, k1_x, k1_y);
            g.DrawImageUnscaled(k2, k2_x, k2_y);
            g.DrawImageUnscaled(k3, k3_x, k3_y);
            sis = 1;
            }
            else{
                sis=0;
                 g.DrawImageUnscaled(k3, k0_x, k0_y);
                 g.DrawImageUnscaled(k2, k1_x, k1_y);
                 g.DrawImageUnscaled(k1, k2_x, k2_y);
                 g.DrawImageUnscaled(k0, k3_x, k3_y);
            }
        }
         }
    
}

﻿using System;
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
        private Image slika,k0,k1,k2,k3;
        private int a, b, k0_x, k1_x, k2_x, k3_x, k0_y, k1_y, k2_y, k3_y;
        public Form1()
        {
            InitializeComponent();
            slika = Resources.food;
            k0 = Resources.k0;
            k1 = Resources.k1;
            k2 = Resources.k2;
            k3 = Resources.k3;
            a = 50;
            b = 15;
            k0_x = 20;
            k1_x = 70;
            k2_x = 130;
            k3_x = 180;



            timer1.Start();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;

            g.DrawImageUnscaled(slika, a, b);
            g.DrawImageUnscaled(k0, b,k0_x);
            g.DrawImageUnscaled(k1, b,k1_x);
            g.DrawImageUnscaled(k2,b, k2_x);
            g.DrawImageUnscaled(k3,b, k3_x);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            a += 10;
            var rand = new Random();
            var s = rand.Next(0, 100);
            label1.Text = s.ToString() ;
            if (s % 4 == 0) { 
                
            }
            
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
         }
}

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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
        }
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
    }
}

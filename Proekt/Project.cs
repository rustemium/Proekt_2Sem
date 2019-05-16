using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Proekt
{
    public partial class Project : Form
    {
        private int i1 = 80;
        private int i2 = 80;
        public Project()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Label lbl = new Label();
            lbl.Location = new Point(52, i1); //расположение
            lbl.Size = new Size(250, 30); // размер
            lbl.Text = textBox1.Text; //текст
            lbl.Font = new System.Drawing.Font("MV Boli", 13F);
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            lbl.BackColor = Color.Transparent;
            this.Controls.Add(lbl);
            i1 += 30;
            lbl.MouseDown += new MouseEventHandler(Lbl_MouseDown);
        }

        private void Lbl_MouseDown(object sender, MouseEventArgs e)
        {
            Label clickedlabel = sender as Label;
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                int x = clickedlabel.Location.X;
                if (x == 52)
                {
                    clickedlabel.Location = new Point(320, i2);
                    i1 -= 30;
                    i2 += 30;
                }
                else
                {
                    clickedlabel.Location = new Point(52, i1);
                    i1 += 30;
                    i2 -= 30;
                }

            }

            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                int x = clickedlabel.Location.X;
                if (x == 52)
                {
                    this.Controls.Remove(clickedlabel);
                    i1 -= 30;
                }
                else
                {
                    this.Controls.Remove(clickedlabel);
                    i2 -= 30;
                }
            }
        }

        private void Lbl_Click(object sender, MouseEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
        
        }

        private void Project_Load(object sender, EventArgs e)
        {
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
        }

    }
}

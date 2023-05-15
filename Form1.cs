using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SanPlast.Model;

namespace SanPlast
{
    public partial class Form1 : Form
    {
        Cabin C;

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            C = new Cabin();
            CBStrona.SelectedIndex = 0;
            CBColor.SelectedIndex = 0;
        }

        private void CBColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            C.Color = CBColor.SelectedItem.ToString();
            ReturnPicture();
        }

        private void CBStrona_SelectedIndexChanged(object sender, EventArgs e)
        {
            C.Strona = CBStrona.SelectedIndex == 0 ? true : false;
            ReturnPicture();
        }

        private void NUDWys_ValueChanged(object sender, EventArgs e)
        {
            C.Wys = Convert.ToInt32(NUDWys.Value);
            C.SzB = Convert.ToInt32(NUDSzB.Value);
            C.SzC = Convert.ToInt32(NUDSzC.Value);
            C.ObchB = Convert.ToInt32(NUDOdchB.Value);
            C.OdchC = Convert.ToInt32(NUDOdchC.Value);
            ReturnPicture();
        }

        private void ReturnPicture()
        {
            pictureBox1.Image = C.Img();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
                C.Policz();
            else
                MessageBox.Show("Wprowadź numer zamówienia");
        }
    }
}

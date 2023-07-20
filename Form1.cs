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
using SanPlast.Dane;

namespace SanPlast
{
    public partial class Form1 : Form
    {
        Cabin C;
        bool InFocus = false;
        //Dane.Dane D = new Dane.Dane();

        public Form1()
        {
            InitializeComponent();

            //Dane.Dane.SaveDS();
            Dane.Dane.ReadDS();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            C = new Cabin
            {
                LS = new List<Szyba>() { new Szyba(), new Szyba() },
                Szer = new int[2]
            };
            CBStrona.SelectedIndex = 0;
            CBColor.SelectedIndex = 0;
            NUDWys_ValueChanged(this, null);
            CheckBox1_CheckedChanged(this, null);
        }

        private void CBColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            C.Kolor = CBColor.SelectedItem.ToString();
            ReturnPicture();
        }

        private void CBStrona_SelectedIndexChanged(object sender, EventArgs e)
        {
            C.Strona = CBStrona.SelectedIndex == 0;
            ReturnPicture();
        }

        private void NUDWys_ValueChanged(object sender, EventArgs e)
        {
            C.Wys = Convert.ToInt32(NUDWys.Value);
            C.Szer = new int[] { Convert.ToInt32(NUDSzB.Value), Convert.ToInt32(NUDSzC.Value) };
            C.LS[0].OdSz = Convert.ToInt32(NUDOdchB.Value);
            C.LS[1].OdSz = Convert.ToInt32(NUDOdchC.Value);
            C.SlantDim = new int[] { Convert.ToInt32(NudSlantHeight.Value), Convert.ToInt32(NudSlantAngle.Value) };
            C.CutoutDim = new int[] { Convert.ToInt32(NudCutHeight.Value), Convert.ToInt32(NudCutHeightOdch.Value), Convert.ToInt32(NudCutWidth.Value), Convert.ToInt32(NudCutWidthOdch.Value) };
            NudSlantHeight.Maximum = NUDWys.Value;
            NudCutHeight.Maximum = NUDWys.Value;
            NudCutWidth.Maximum = NUDSzC.Value;
            ReturnPicture();
        }

        private void ReturnPicture() => pictureBox1.Image = C.Img();

        private void Button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(textBox1.Text))
                C.Policz();
            else
                MessageBox.Show("Wprowadź numer zamówienia");
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            C.Folder = textBox1.Text;
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            C.LS[0].OdSzB = true;
            C.LS[1].OdSzB = checkBox1.Checked;
        }

        private void pictureBox1_MouseWheel(object sender, MouseEventArgs e)
        {
            //you can do anything here
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void CbSlant_CheckedChanged(object sender, EventArgs e)
        {
            if (CbSlant.Checked)
            {
                PSlant.Height = PSlant.MaximumSize.Height;
                C.Slant = true;
            }
            else
            {
                PSlant.Height = PSlant.MinimumSize.Height;
                C.Slant = false;
            }
            ReturnPicture();
        }

        private void CbCutout_CheckedChanged(object sender, EventArgs e)
        {
            if (CbCutout.Checked)
            {
                PCutout.Size = PCutout.MaximumSize;
                C.Cutout = true;
            }
            else
            {
                PCutout.Size = PCutout.MinimumSize;
                C.Cutout = false;
            }
            ReturnPicture();
        }
    }
}

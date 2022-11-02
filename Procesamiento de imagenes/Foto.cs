using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Procesamiento_de_imagenes
{
    public partial class Foto : Form
    {


        private Bitmap original;
        private Bitmap resultante;
        private int[] histograma = new int[256];
        private int[,] conv3x3 = new int[3, 3];
        private int factor;
        private int offset;




        private int anchoVentana, altoVentana;

        public Foto()
        {
            InitializeComponent();


            System.Object[] ItemObject = new System.Object[8];

            ItemObject[0] = "NEGATIVO";
            ItemObject[1] = "ROJO";
            ItemObject[2] = "VERDE";
            ItemObject[3] = "AZUL";
            ItemObject[4] = "SEPIA";
            ItemObject[5] = "3D";
            ItemObject[6] = "PIXEL";
            ItemObject[7] = "BLANCO/NEGRO";






            FiltroImg.Items.AddRange(ItemObject);



            resultante = new Bitmap(800, 600);
            anchoVentana = 800;
            altoVentana = 600;

        }

        private void Foto_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 frm = new Form1();
            frm.Show();
        }

        private void SideBarContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ActivarFoto_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                original = (Bitmap)(Bitmap.FromFile(openFileDialog1.FileName));
                anchoVentana = original.Width;
                altoVentana = original.Height;

                resultante = original;

                this.Invalidate();

            }
        }

        private void FiltroImg_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AceptarFoto_Click(object sender, EventArgs e)
        {

            int x = 0;
            int y = 0;
            int a = 100;

            int r = 0;
            int g = 0;
            int b = 0;


            resultante = new Bitmap(original.Width, original.Height);

            Color rColor = new Color();
            Color oColor = new Color();

            switch (FiltroImg.Text)
            {

                case "NEGATIVO":
                    {

                        FiltroColor("NEGATIVO", x, y, oColor, rColor);
                        break;
                    }


                case "ROJO":
                    {
                        FiltroColor("ROJO", x, y, oColor, rColor);
                        break;
                    }
                case "VERDE":
                    {
                        FiltroColor("VERDE", x, y, oColor, rColor);
                        break;
                    }
                case "AZUL":
                    {
                        FiltroColor("AZUL", x, y, oColor, rColor);
                        break;
                    }
                case "SEPIA":
                    {
                        for (x = 0; x < original.Width; x++)
                        {
                            for (y = 0; y < original.Height; y++)
                            {

                                oColor = original.GetPixel(x, y);
                                a = oColor.A;
                                r = oColor.R;
                                g = oColor.G;
                                b = oColor.B;
                                int tr = (int)(0.393 * r + 0.769 * g + 0.189 * b);
                                int tg = (int)(0.349 * r + 0.686 * g + 0.168 * b);
                                int tb = (int)(0.272 * r + 0.534 * g + 0.131 * b);
                                if (tr > 255)
                                {
                                    r = 255;
                                }
                                else
                                    r = tr;
                                if (tg > 255)
                                {
                                    g = 255;
                                }
                                else
                                    g = tg;
                                if (tb > 255)
                                {
                                    b = 255;
                                }
                                else
                                    b = tb;
                                rColor = Color.FromArgb(a, r, g, b);
                                // Colocamos el color en resultante
                                resultante.SetPixel(x, y, rColor);
                            }
                        }
                        break;
                    }
                case "3D":
                    {
                        for (x = 0; x < original.Width; x++)
                            for (y = 0; y < original.Height; y++)
                            {
                                g = original.GetPixel(x, y).G;

                                if (x + a < original.Width)
                                    r = original.GetPixel(x + a, y).R;
                                else
                                    r = 0;

                                if (x - a >= 0)
                                    b = original.GetPixel(x - a, y).B;

                                else
                                    b = 0;

                                resultante.SetPixel(x, y, Color.FromArgb(r, g, b));

                            }
                        this.Invalidate();



                        break;
                    }
                case "PIXEL":
                    {

                        int mosaico = 30;
                        int xm = 0;
                        int ym = 0;
                        int rs = 0;
                        int gs = 0;
                        int bs = 0;


                        for (x = 0; x < original.Width - mosaico; x += mosaico)
                        {
                            for (y = 0; y < original.Height - mosaico; y += mosaico)
                            {
                                rs = 0;
                                gs = 0;
                                bs = 0;
                                for (xm = x; xm < (x + mosaico); xm++)
                                {
                                    for (ym = y; ym < (y + mosaico); ym++)
                                    {
                                        oColor = original.GetPixel(xm, ym);
                                        rs += oColor.R;
                                        gs += oColor.G;
                                        bs += oColor.B;
                                    }
                                }
                                r = rs / (mosaico * mosaico);
                                g = gs / (mosaico * mosaico);
                                b = bs / (mosaico * mosaico);
                                rColor = Color.FromArgb(r, g, b);
                                // Colocamos el color en resultante
                                for (xm = x; xm < (x + mosaico); xm++)
                                {
                                    for (ym = y; ym < (y + mosaico); ym++)
                                    {
                                        resultante.SetPixel(xm, ym, rColor);
                                    }

                                }
                            }
                        }

                        break;
                    }
                case "BLANCO/NEGRO":
                    {
                 
                        float g1=0;

                        for (x = 0; x < original.Width; x++)
                        {
                            for (y = 0; y < original.Height; y++)
                            {
                                oColor = original.GetPixel(x, y);
                                g1 = oColor.R * 0.299f + oColor.G * 0.587f + oColor.B * 0.114f;
                                rColor = Color.FromArgb((int)g1, (int)g1, (int)g1);
                                resultante.SetPixel(x, y, rColor);
                            }
                        }
                        break;
                    }
                    //COLOR


            }
        }
        ////////////////VARIABLE
        private void FiltroColor(string Col, int x, int y, Color oColor, Color rColor)
        {

            for (x = 0; x < original.Width; x++)
            {
                for (y = 0; y < original.Height; y++)
                {
                    oColor = original.GetPixel(x, y);
                    switch (Col)
                    {

                        case "NEGATIVO":
                            {
                                rColor = Color.FromArgb(255 - oColor.R,
                                                        255 - oColor.G,
                                                        255 - oColor.B);
                                resultante.SetPixel(x, y, rColor);

                                break;
                            }
                        case "ROJO":
                            {
                                rColor = Color.FromArgb(oColor.R,
                                                        0,
                                                        0);

                                resultante.SetPixel(x, y, rColor);
                                break;
                            }
                        case "VERDE":
                            {
                                rColor = Color.FromArgb(0,
                                                        oColor.G,
                                                        0);

                                resultante.SetPixel(x, y, rColor);
                                break;
                            }
                        case "AZUL":
                            {
                                rColor = Color.FromArgb(0,
                                                       0,
                                                        oColor.B);
                                resultante.SetPixel(x, y, rColor);
                                break;
                            }
                    }
                }
            }
            this.Invalidate();
        }

        private void Foto_Paint(object sender, PaintEventArgs e)
        {
            if (resultante != null)
            {
                Pic_Img.Image = resultante;


            }
        }
    }
}

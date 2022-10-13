using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Procesamiento_de_imagenes
{
    public partial class Form1 : Form
    {


        bool sideBarExpand;
        bool ImagenCollapse;
    
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void COMENZAR_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Btn_Fotos_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Fotos_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
      

        }

        private void SideBarTime_Tick(object sender, EventArgs e)
        {
            // /// 48, 561
            if (sideBarExpand)
            {
                SideBarContainer.Width -= 10;
                if (SideBarContainer.Width == SideBarContainer.MinimumSize.Width)
                {
                    sideBarExpand = false;
                    SideBarTime.Stop();
                }
            }
            else
            {
                SideBarContainer.Width += 10;
                if (SideBarContainer.Width == SideBarContainer.MaximumSize.Width)
                {
                    sideBarExpand = true;
                    SideBarTime.Stop();
                }
            }
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            SideBarTime.Start();
         

        }

        private void ImagenTimer_Tick(object sender, EventArgs e)
        {
            if (ImagenCollapse)
            {
                ImageContent.Height -= 10;
                if (ImageContent.Height == ImageContent.MinimumSize.Height)
                {
                    ImagenCollapse = false;
                    ImagenTimer.Stop();
                }
            }
            else
            { 
                ImageContent.Height += 10;
                if (ImageContent.Height == ImageContent.MaximumSize.Height)
                {
                    ImagenCollapse = true;
                    ImagenTimer.Stop();
                }
            }
        }

        private void btn_Deteccion_Click(object sender, EventArgs e)
        {
  
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Video frm = new Video();
            frm.Show();
            this.Hide();

        }

        private void ImageContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Deteccion_Click_1(object sender, EventArgs e)
        {
            Detección frm = new Detección();
            frm.Show();
            this.Hide();




        }

        private void LabelCamara_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Foto frm = new Foto();
            frm.Show();
            this.Hide();
  


        }

        private void CamaraActiva_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ActivarVideo_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Imagen_PaddingChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {


            Logo.Show();


        }

        private void Btn_Imagen_Click(object sender, EventArgs e)
        {
            ImagenTimer.Start();

        }

        private void ActivarFoto_Click(object sender, EventArgs e)
        {

        }

        private void Pic_Img_Click(object sender, EventArgs e)
        {

        }

        private void FiltroImg_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LabelImg_Click(object sender, EventArgs e)
        {

        }

        private void AceptarFoto_Click(object sender, EventArgs e)
        {

        }

        private void AceptarCamara_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BTM_Manual_Click(object sender, EventArgs e)
        {
            Manual frm = new Manual();
            frm.Show();
            this.Hide();

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

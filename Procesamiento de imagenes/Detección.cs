using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using Emgu.CV;
using Emgu.CV.Structure;

namespace Procesamiento_de_imagenes
{
    public partial class Detección : Form
    {
        private bool HayDispositivos;
        private FilterInfoCollection MyDispositivos;
        private VideoCaptureDevice MiWebCam = null;

        static readonly CascadeClassifier cascadeClassifier = new CascadeClassifier("haarcascade_frontalface_alt_tree.xml"); // Para reconocer el rostro

        public Detección()
        {
            InitializeComponent();
            cargarDispositivos();
        }


        private void Detección_Load(object sender, EventArgs e)
        {

        }

        private void Pic_Camara_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 frm = new Form1();
            frm.Show();

        }


        private void ActivarCam_Click(object sender, EventArgs e)
        {

            CerrarWebCam();

            int i = FiltroCamara.SelectedIndex;
            string nombreVide = MyDispositivos[i].MonikerString;
            MiWebCam = new VideoCaptureDevice(nombreVide);
            MiWebCam.NewFrame+= new NewFrameEventHandler(Capturado);
            MiWebCam.Start();


        }

         private void Capturado(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap Imagen = (Bitmap)eventArgs.Frame.Clone();
            Pic_Camara.Image=Imagen;
        }
        public void cargarDispositivos()
        {
            MyDispositivos = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (MyDispositivos.Count > 0)
            {
                HayDispositivos = true;
                for (int i = 0; i < MyDispositivos.Count; i++)
                {
                    FiltroCamara.Items.Add(MyDispositivos[i].Name.ToString());
                }
            }
            else
            {
                HayDispositivos = false;

            }
        }
        public void CerrarWebCam()
        {
            if (MiWebCam != null && MiWebCam.IsRunning)
            {
                MiWebCam.SignalToStop();
                MiWebCam = null;


            }
        }
       
    }
}

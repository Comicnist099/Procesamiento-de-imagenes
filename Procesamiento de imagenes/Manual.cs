using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Procesamiento_de_imagenes
{
    public partial class Manual : Form
    {
        public Manual()
        {
            InitializeComponent();
        }

        private void Manual_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 frm = new Form1();
            frm.Show();
        }
    }
}

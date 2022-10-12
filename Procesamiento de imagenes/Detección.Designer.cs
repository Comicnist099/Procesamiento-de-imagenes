
namespace Procesamiento_de_imagenes
{
    partial class Detección
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Detección));
            this.panel9 = new System.Windows.Forms.Panel();
            this.ActivarCam = new System.Windows.Forms.Button();
            this.Pic_Camara = new System.Windows.Forms.PictureBox();
            this.SideBarContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_menu = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.FiltroCamara = new System.Windows.Forms.ComboBox();
            this.LabelCamara = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.AceptarCamara = new System.Windows.Forms.Button();
            this.NumPersonas = new System.Windows.Forms.Label();
            this.LabelPersonas = new System.Windows.Forms.Label();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Camara)).BeginInit();
            this.SideBarContainer.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_menu)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel12.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.ActivarCam);
            this.panel9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel9.Location = new System.Drawing.Point(231, 223);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(211, 49);
            this.panel9.TabIndex = 7;
            // 
            // ActivarCam
            // 
            this.ActivarCam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.ActivarCam.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ActivarCam.ForeColor = System.Drawing.SystemColors.Control;
            this.ActivarCam.Image = ((System.Drawing.Image)(resources.GetObject("ActivarCam.Image")));
            this.ActivarCam.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ActivarCam.Location = new System.Drawing.Point(-1, -9);
            this.ActivarCam.Name = "ActivarCam";
            this.ActivarCam.Size = new System.Drawing.Size(212, 67);
            this.ActivarCam.TabIndex = 2;
            this.ActivarCam.Text = "ActivarCamara";
            this.ActivarCam.UseVisualStyleBackColor = false;
            this.ActivarCam.Click += new System.EventHandler(this.ActivarCam_Click);
            // 
            // Pic_Camara
            // 
            this.Pic_Camara.Image = ((System.Drawing.Image)(resources.GetObject("Pic_Camara.Image")));
            this.Pic_Camara.Location = new System.Drawing.Point(478, 34);
            this.Pic_Camara.Name = "Pic_Camara";
            this.Pic_Camara.Size = new System.Drawing.Size(445, 427);
            this.Pic_Camara.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic_Camara.TabIndex = 14;
            this.Pic_Camara.TabStop = false;
            this.Pic_Camara.Click += new System.EventHandler(this.Pic_Camara_Click);
            // 
            // SideBarContainer
            // 
            this.SideBarContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.SideBarContainer.Controls.Add(this.panel1);
            this.SideBarContainer.Controls.Add(this.panel2);
            this.SideBarContainer.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideBarContainer.Location = new System.Drawing.Point(0, 0);
            this.SideBarContainer.MaximumSize = new System.Drawing.Size(199, 561);
            this.SideBarContainer.MinimumSize = new System.Drawing.Size(48, 561);
            this.SideBarContainer.Name = "SideBarContainer";
            this.SideBarContainer.Size = new System.Drawing.Size(199, 561);
            this.SideBarContainer.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btn_menu);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(196, 100);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(47, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Menu";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(69, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btn_menu
            // 
            this.btn_menu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_menu.Image = ((System.Drawing.Image)(resources.GetObject("btn_menu.Image")));
            this.btn_menu.InitialImage = ((System.Drawing.Image)(resources.GetObject("btn_menu.InitialImage")));
            this.btn_menu.Location = new System.Drawing.Point(4, 31);
            this.btn_menu.Name = "btn_menu";
            this.btn_menu.Size = new System.Drawing.Size(30, 29);
            this.btn_menu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_menu.TabIndex = 4;
            this.btn_menu.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel2.Location = new System.Drawing.Point(3, 109);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(234, 49);
            this.panel2.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(-2, -9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 67);
            this.button1.TabIndex = 2;
            this.button1.Text = "Atras";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FiltroCamara
            // 
            this.FiltroCamara.FormattingEnabled = true;
            this.FiltroCamara.Location = new System.Drawing.Point(205, 124);
            this.FiltroCamara.Name = "FiltroCamara";
            this.FiltroCamara.Size = new System.Drawing.Size(267, 23);
            this.FiltroCamara.TabIndex = 16;
            // 
            // LabelCamara
            // 
            this.LabelCamara.AutoSize = true;
            this.LabelCamara.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelCamara.Location = new System.Drawing.Point(252, 75);
            this.LabelCamara.Name = "LabelCamara";
            this.LabelCamara.Size = new System.Drawing.Size(171, 25);
            this.LabelCamara.TabIndex = 17;
            this.LabelCamara.Text = "FILTROS CAMARA";
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.AceptarCamara);
            this.panel12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel12.Location = new System.Drawing.Point(231, 287);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(211, 49);
            this.panel12.TabIndex = 18;
            // 
            // AceptarCamara
            // 
            this.AceptarCamara.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.AceptarCamara.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AceptarCamara.ForeColor = System.Drawing.SystemColors.Control;
            this.AceptarCamara.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AceptarCamara.Location = new System.Drawing.Point(-1, -9);
            this.AceptarCamara.Name = "AceptarCamara";
            this.AceptarCamara.Size = new System.Drawing.Size(212, 67);
            this.AceptarCamara.TabIndex = 2;
            this.AceptarCamara.Text = "Aceptar Efecto Camara";
            this.AceptarCamara.UseVisualStyleBackColor = false;
            // 
            // NumPersonas
            // 
            this.NumPersonas.AutoSize = true;
            this.NumPersonas.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.NumPersonas.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NumPersonas.ForeColor = System.Drawing.SystemColors.Control;
            this.NumPersonas.Location = new System.Drawing.Point(239, 384);
            this.NumPersonas.Name = "NumPersonas";
            this.NumPersonas.Size = new System.Drawing.Size(23, 25);
            this.NumPersonas.TabIndex = 10;
            this.NumPersonas.Text = "0";
            // 
            // LabelPersonas
            // 
            this.LabelPersonas.AutoSize = true;
            this.LabelPersonas.BackColor = System.Drawing.SystemColors.ControlText;
            this.LabelPersonas.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelPersonas.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.LabelPersonas.Location = new System.Drawing.Point(230, 348);
            this.LabelPersonas.Name = "LabelPersonas";
            this.LabelPersonas.Size = new System.Drawing.Size(207, 25);
            this.LabelPersonas.TabIndex = 9;
            this.LabelPersonas.Text = "Personas en la camara";
            // 
            // Detección
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 522);
            this.Controls.Add(this.NumPersonas);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.LabelPersonas);
            this.Controls.Add(this.LabelCamara);
            this.Controls.Add(this.FiltroCamara);
            this.Controls.Add(this.SideBarContainer);
            this.Controls.Add(this.Pic_Camara);
            this.Controls.Add(this.panel9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Detección";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.Detección_Load);
            this.panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Camara)).EndInit();
            this.SideBarContainer.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_menu)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button ActivarCam;
        private System.Windows.Forms.PictureBox Pic_Camara;
        private System.Windows.Forms.FlowLayoutPanel SideBarContainer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox btn_menu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox FiltroCamara;
        private System.Windows.Forms.Label LabelCamara;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Button AceptarCamara;
        private System.Windows.Forms.Label NumPersonas;
        private System.Windows.Forms.Label LabelPersonas;




    }
}
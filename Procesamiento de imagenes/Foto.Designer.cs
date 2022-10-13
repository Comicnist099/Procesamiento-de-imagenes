
namespace Procesamiento_de_imagenes
{
    partial class Foto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Foto));
            this.SideBarContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_menu = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.ActivarFoto = new System.Windows.Forms.Button();
            this.LabelImg = new System.Windows.Forms.Label();
            this.FiltroImg = new System.Windows.Forms.ComboBox();
            this.Pic_Img = new System.Windows.Forms.PictureBox();
            this.panel13 = new System.Windows.Forms.Panel();
            this.AceptarFoto = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.SideBarContainer.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_menu)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Img)).BeginInit();
            this.panel13.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
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
            this.SideBarContainer.TabIndex = 17;
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
            // panel6
            // 
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel6.Location = new System.Drawing.Point(230, 154);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(211, 59);
            this.panel6.TabIndex = 18;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.ActivarFoto);
            this.panel7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel7.Location = new System.Drawing.Point(0, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(211, 49);
            this.panel7.TabIndex = 5;
            // 
            // ActivarFoto
            // 
            this.ActivarFoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.ActivarFoto.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ActivarFoto.ForeColor = System.Drawing.SystemColors.Control;
            this.ActivarFoto.Image = ((System.Drawing.Image)(resources.GetObject("ActivarFoto.Image")));
            this.ActivarFoto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ActivarFoto.Location = new System.Drawing.Point(0, -6);
            this.ActivarFoto.Name = "ActivarFoto";
            this.ActivarFoto.Size = new System.Drawing.Size(212, 67);
            this.ActivarFoto.TabIndex = 2;
            this.ActivarFoto.Text = "Subir Foto";
            this.ActivarFoto.UseVisualStyleBackColor = false;
            // 
            // LabelImg
            // 
            this.LabelImg.AutoSize = true;
            this.LabelImg.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelImg.Location = new System.Drawing.Point(264, 63);
            this.LabelImg.Name = "LabelImg";
            this.LabelImg.Size = new System.Drawing.Size(166, 25);
            this.LabelImg.TabIndex = 21;
            this.LabelImg.Text = "FILTROS IMAGEN";
            // 
            // FiltroImg
            // 
            this.FiltroImg.FormattingEnabled = true;
            this.FiltroImg.Location = new System.Drawing.Point(215, 116);
            this.FiltroImg.Name = "FiltroImg";
            this.FiltroImg.Size = new System.Drawing.Size(267, 23);
            this.FiltroImg.TabIndex = 20;
            // 
            // Pic_Img
            // 
            this.Pic_Img.Image = ((System.Drawing.Image)(resources.GetObject("Pic_Img.Image")));
            this.Pic_Img.Location = new System.Drawing.Point(488, 34);
            this.Pic_Img.Name = "Pic_Img";
            this.Pic_Img.Size = new System.Drawing.Size(447, 427);
            this.Pic_Img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic_Img.TabIndex = 19;
            this.Pic_Img.TabStop = false;
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.AceptarFoto);
            this.panel13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel13.Location = new System.Drawing.Point(230, 253);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(211, 49);
            this.panel13.TabIndex = 22;
            // 
            // AceptarFoto
            // 
            this.AceptarFoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.AceptarFoto.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AceptarFoto.ForeColor = System.Drawing.SystemColors.Control;
            this.AceptarFoto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AceptarFoto.Location = new System.Drawing.Point(-1, -9);
            this.AceptarFoto.Name = "AceptarFoto";
            this.AceptarFoto.Size = new System.Drawing.Size(212, 67);
            this.AceptarFoto.TabIndex = 2;
            this.AceptarFoto.Text = "Aceptar Efecto Foto";
            this.AceptarFoto.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button2);
            this.panel3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel3.Location = new System.Drawing.Point(229, 328);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(211, 49);
            this.panel3.TabIndex = 23;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.button2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(-1, -9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(212, 67);
            this.button2.TabIndex = 2;
            this.button2.Text = "Histograma";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // Foto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 483);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel13);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.LabelImg);
            this.Controls.Add(this.FiltroImg);
            this.Controls.Add(this.Pic_Img);
            this.Controls.Add(this.SideBarContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Foto";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Foto";
            this.Load += new System.EventHandler(this.Foto_Load);
            this.SideBarContainer.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_menu)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Img)).EndInit();
            this.panel13.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel SideBarContainer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox btn_menu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button ActivarFoto;
        private System.Windows.Forms.Label LabelImg;
        private System.Windows.Forms.ComboBox FiltroImg;
        private System.Windows.Forms.PictureBox Pic_Img;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Button AceptarFoto;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button2;
    }
}
namespace Procesamiento_de_imagenes
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.SideBarTime = new System.Windows.Forms.Timer(this.components);
            this.ImagenTimer = new System.Windows.Forms.Timer(this.components);
            this.Logo = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.Video = new System.Windows.Forms.Button();
            this.ImageContent = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_Deteccion = new System.Windows.Forms.Button();
            this.Pan_Fotos = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.Btn_Imagen = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_menu = new System.Windows.Forms.PictureBox();
            this.SideBarContainer = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.ImageContent.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.Pan_Fotos.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_menu)).BeginInit();
            this.SideBarContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // SideBarTime
            // 
            this.SideBarTime.Interval = 10;
            this.SideBarTime.Tick += new System.EventHandler(this.SideBarTime_Tick);
            // 
            // ImagenTimer
            // 
            this.ImagenTimer.Interval = 8;
            this.ImagenTimer.Tick += new System.EventHandler(this.ImagenTimer_Tick);
            // 
            // Logo
            // 
            this.Logo.ErrorImage = ((System.Drawing.Image)(resources.GetObject("Logo.ErrorImage")));
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(262, 55);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(640, 452);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 7;
            this.Logo.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.ImageContent);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel2.Location = new System.Drawing.Point(3, 109);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(196, 276);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.Video);
            this.panel7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel7.Location = new System.Drawing.Point(2, 133);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(211, 47);
            this.panel7.TabIndex = 6;
            // 
            // Video
            // 
            this.Video.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.Video.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Video.ForeColor = System.Drawing.SystemColors.Control;
            this.Video.Image = ((System.Drawing.Image)(resources.GetObject("Video.Image")));
            this.Video.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Video.Location = new System.Drawing.Point(-8, -5);
            this.Video.Name = "Video";
            this.Video.Size = new System.Drawing.Size(212, 56);
            this.Video.TabIndex = 2;
            this.Video.Text = "Video";
            this.Video.UseVisualStyleBackColor = false;
            this.Video.Click += new System.EventHandler(this.button2_Click);
            // 
            // ImageContent
            // 
            this.ImageContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.ImageContent.Controls.Add(this.panel5);
            this.ImageContent.Controls.Add(this.panel3);
            this.ImageContent.Controls.Add(this.Pan_Fotos);
            this.ImageContent.Location = new System.Drawing.Point(-1, -1);
            this.ImageContent.MaximumSize = new System.Drawing.Size(217, 118);
            this.ImageContent.MinimumSize = new System.Drawing.Size(217, 45);
            this.ImageContent.Name = "ImageContent";
            this.ImageContent.Size = new System.Drawing.Size(217, 45);
            this.ImageContent.TabIndex = 1;
            this.ImageContent.Paint += new System.Windows.Forms.PaintEventHandler(this.ImageContent_Paint);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.button2);
            this.panel5.Location = new System.Drawing.Point(1, 82);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(234, 36);
            this.panel5.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(-4, -7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(212, 67);
            this.button2.TabIndex = 2;
            this.button2.Text = "Fotos";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_Deteccion);
            this.panel3.Location = new System.Drawing.Point(1, 45);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(234, 36);
            this.panel3.TabIndex = 3;
            // 
            // btn_Deteccion
            // 
            this.btn_Deteccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.btn_Deteccion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Deteccion.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Deteccion.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Deteccion.Image = ((System.Drawing.Image)(resources.GetObject("btn_Deteccion.Image")));
            this.btn_Deteccion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Deteccion.Location = new System.Drawing.Point(-4, -14);
            this.btn_Deteccion.Name = "btn_Deteccion";
            this.btn_Deteccion.Size = new System.Drawing.Size(212, 67);
            this.btn_Deteccion.TabIndex = 2;
            this.btn_Deteccion.Text = "Deteccion";
            this.btn_Deteccion.UseVisualStyleBackColor = false;
            this.btn_Deteccion.Click += new System.EventHandler(this.btn_Deteccion_Click_1);
            // 
            // Pan_Fotos
            // 
            this.Pan_Fotos.Controls.Add(this.panel8);
            this.Pan_Fotos.Controls.Add(this.Btn_Imagen);
            this.Pan_Fotos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Pan_Fotos.Location = new System.Drawing.Point(1, -5);
            this.Pan_Fotos.Name = "Pan_Fotos";
            this.Pan_Fotos.Size = new System.Drawing.Size(195, 49);
            this.Pan_Fotos.TabIndex = 1;
            // 
            // panel8
            // 
            this.panel8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel8.Location = new System.Drawing.Point(213, 10);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(211, 49);
            this.panel8.TabIndex = 6;
            // 
            // Btn_Imagen
            // 
            this.Btn_Imagen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.Btn_Imagen.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_Imagen.ForeColor = System.Drawing.SystemColors.Control;
            this.Btn_Imagen.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Imagen.Image")));
            this.Btn_Imagen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Imagen.Location = new System.Drawing.Point(-4, -11);
            this.Btn_Imagen.Name = "Btn_Imagen";
            this.Btn_Imagen.Size = new System.Drawing.Size(212, 67);
            this.Btn_Imagen.TabIndex = 2;
            this.Btn_Imagen.Text = "Imagen";
            this.Btn_Imagen.UseVisualStyleBackColor = false;
            this.Btn_Imagen.Click += new System.EventHandler(this.Btn_Imagen_Click);
            this.Btn_Imagen.PaddingChanged += new System.EventHandler(this.Btn_Imagen_PaddingChanged);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button1);
            this.panel4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel4.Location = new System.Drawing.Point(-4, 182);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(211, 49);
            this.panel4.TabIndex = 3;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(-1, -8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 67);
            this.button1.TabIndex = 2;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
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
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
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
            this.btn_menu.Click += new System.EventHandler(this.btn_menu_Click);
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
            this.SideBarContainer.TabIndex = 0;
            this.SideBarContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 545);
            this.ControlBox = false;
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.SideBarContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Procesamiento de imagenes";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.ImageContent.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.Pan_Fotos.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_menu)).EndInit();
            this.SideBarContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Timer SideBarTime;
        private System.Windows.Forms.Timer ImagenTimer;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button Video;
        private System.Windows.Forms.Panel ImageContent;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_Deteccion;
        private System.Windows.Forms.Panel Pan_Fotos;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button Btn_Imagen;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox btn_menu;
        private System.Windows.Forms.FlowLayoutPanel SideBarContainer;
        private System.Windows.Forms.Panel panel7;
    }
}


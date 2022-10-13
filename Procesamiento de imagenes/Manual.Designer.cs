
namespace Procesamiento_de_imagenes
{
    partial class Manual
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manual));
            this.SideBarContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_menu = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.IntruccionesVideo = new System.Windows.Forms.Label();
            this.Pic_Camara = new System.Windows.Forms.PictureBox();
            this.SideBarContainer.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_menu)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Camara)).BeginInit();
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
            this.SideBarContainer.TabIndex = 16;
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
            // IntruccionesVideo
            // 
            this.IntruccionesVideo.AutoSize = true;
            this.IntruccionesVideo.Font = new System.Drawing.Font("Segoe UI Mono", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.IntruccionesVideo.Location = new System.Drawing.Point(504, 27);
            this.IntruccionesVideo.Name = "IntruccionesVideo";
            this.IntruccionesVideo.Size = new System.Drawing.Size(372, 36);
            this.IntruccionesVideo.TabIndex = 17;
            this.IntruccionesVideo.Text = "MANUAL DE USUARIO";
            // 
            // Pic_Camara
            // 
            this.Pic_Camara.Image = global::Procesamiento_de_imagenes.Properties.Resources.manual;
            this.Pic_Camara.Location = new System.Drawing.Point(293, 100);
            this.Pic_Camara.Name = "Pic_Camara";
            this.Pic_Camara.Size = new System.Drawing.Size(750, 448);
            this.Pic_Camara.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic_Camara.TabIndex = 18;
            this.Pic_Camara.TabStop = false;
            // 
            // Manual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(1184, 545);
            this.ControlBox = false;
            this.Controls.Add(this.Pic_Camara);
            this.Controls.Add(this.IntruccionesVideo);
            this.Controls.Add(this.SideBarContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Manual";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manual";
            this.Load += new System.EventHandler(this.Manual_Load);
            this.SideBarContainer.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_menu)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Camara)).EndInit();
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
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label IntruccionesVideo;
        private System.Windows.Forms.PictureBox Pic_Camara;
    }
}
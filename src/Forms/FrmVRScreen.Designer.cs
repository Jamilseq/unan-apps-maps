namespace src
{
    partial class FrmVRScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVRScreen));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNameDestination = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxMiniMap = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonCloseRouteVR = new System.Windows.Forms.Button();
            this.paneBgRouteVR = new System.Windows.Forms.Panel();
            this.imageListRoutesVR = new System.Windows.Forms.ImageList(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMiniMap)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtNameDestination);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBoxMiniMap);
            this.panel1.Location = new System.Drawing.Point(35, 603);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(305, 127);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(182, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "10 Mtr";
            // 
            // txtNameDestination
            // 
            this.txtNameDestination.AutoSize = true;
            this.txtNameDestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameDestination.Location = new System.Drawing.Point(137, 37);
            this.txtNameDestination.Name = "txtNameDestination";
            this.txtNameDestination.Size = new System.Drawing.Size(142, 62);
            this.txtNameDestination.TabIndex = 3;
            this.txtNameDestination.Text = "Biblioteca\r\nCentral";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Location = new System.Drawing.Point(259, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 22);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(183)))), ((int)(((byte)(5)))));
            this.label1.Location = new System.Drawing.Point(137, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gire ala izquierda";
            // 
            // pictureBoxMiniMap
            // 
            this.pictureBoxMiniMap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBoxMiniMap.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxMiniMap.Name = "pictureBoxMiniMap";
            this.pictureBoxMiniMap.Size = new System.Drawing.Size(119, 101);
            this.pictureBoxMiniMap.TabIndex = 0;
            this.pictureBoxMiniMap.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Location = new System.Drawing.Point(23, 749);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 41);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // buttonCloseRouteVR
            // 
            this.buttonCloseRouteVR.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonCloseRouteVR.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonCloseRouteVR.BackgroundImage")));
            this.buttonCloseRouteVR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonCloseRouteVR.Location = new System.Drawing.Point(228, 749);
            this.buttonCloseRouteVR.Name = "buttonCloseRouteVR";
            this.buttonCloseRouteVR.Size = new System.Drawing.Size(112, 41);
            this.buttonCloseRouteVR.TabIndex = 2;
            this.buttonCloseRouteVR.UseVisualStyleBackColor = false;
            this.buttonCloseRouteVR.Click += new System.EventHandler(this.buttonCloseRouteVR_Click);
            // 
            // paneBgRouteVR
            // 
            this.paneBgRouteVR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.paneBgRouteVR.Location = new System.Drawing.Point(0, 3);
            this.paneBgRouteVR.Name = "paneBgRouteVR";
            this.paneBgRouteVR.Size = new System.Drawing.Size(380, 594);
            this.paneBgRouteVR.TabIndex = 3;
            // 
            // imageListRoutesVR
            // 
            this.imageListRoutesVR.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListRoutesVR.ImageStream")));
            this.imageListRoutesVR.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListRoutesVR.Images.SetKeyName(0, "pasillo-biblioteca.png");
            this.imageListRoutesVR.Images.SetKeyName(1, "pasillo-pabellon-22.png");
            this.imageListRoutesVR.Images.SetKeyName(2, "parqueo.png");
            this.imageListRoutesVR.Images.SetKeyName(3, "pasillo-random.png");
            this.imageListRoutesVR.Images.SetKeyName(4, "pasillo-fernando-gordillo.png");
            this.imageListRoutesVR.Images.SetKeyName(5, "pasillo-pabellon-10.png");
            this.imageListRoutesVR.Images.SetKeyName(6, "pasillo-pabellon-56.png");
            this.imageListRoutesVR.Images.SetKeyName(7, "pasillo-pabellon-36.png");
            // 
            // FrmVRScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 840);
            this.ControlBox = false;
            this.Controls.Add(this.paneBgRouteVR);
            this.Controls.Add(this.buttonCloseRouteVR);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Name = "FrmVRScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmVRScreen_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMiniMap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxMiniMap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtNameDestination;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonCloseRouteVR;
        private System.Windows.Forms.Panel paneBgRouteVR;
        private System.Windows.Forms.ImageList imageListRoutesVR;
    }
}
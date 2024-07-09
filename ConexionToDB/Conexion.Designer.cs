namespace ConexionToDB
{
    partial class Conexion
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Conexion));
            this.conectar = new System.Windows.Forms.Button();
            this.desconectar = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.pictureBoxGreen = new System.Windows.Forms.PictureBox();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.pictureBoxRed = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRed)).BeginInit();
            this.SuspendLayout();
            // 
            // conectar
            // 
            this.conectar.Location = new System.Drawing.Point(32, 207);
            this.conectar.Name = "conectar";
            this.conectar.Size = new System.Drawing.Size(88, 23);
            this.conectar.TabIndex = 0;
            this.conectar.Text = "Conectar";
            this.conectar.UseVisualStyleBackColor = true;
            this.conectar.Click += new System.EventHandler(this.buttonConectar_Click);
            // 
            // desconectar
            // 
            this.desconectar.Location = new System.Drawing.Point(126, 207);
            this.desconectar.Name = "desconectar";
            this.desconectar.Size = new System.Drawing.Size(88, 23);
            this.desconectar.TabIndex = 1;
            this.desconectar.Text = "Desconectar";
            this.desconectar.UseVisualStyleBackColor = true;
            this.desconectar.Click += new System.EventHandler(this.buttonDesconectar_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(32, 184);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(182, 10);
            this.progressBar.TabIndex = 2;
            // 
            // pictureBoxGreen
            // 
            this.pictureBoxGreen.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBoxGreen.ErrorImage = null;
            this.pictureBoxGreen.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxGreen.Image")));
            this.pictureBoxGreen.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxGreen.InitialImage")));
            this.pictureBoxGreen.Location = new System.Drawing.Point(44, 12);
            this.pictureBoxGreen.Name = "pictureBoxGreen";
            this.pictureBoxGreen.Size = new System.Drawing.Size(155, 154);
            this.pictureBoxGreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxGreen.TabIndex = 3;
            this.pictureBoxGreen.TabStop = false;
            this.pictureBoxGreen.Visible = false;
            // 
            // buttonInsert
            // 
            this.buttonInsert.Location = new System.Drawing.Point(32, 242);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(182, 23);
            this.buttonInsert.TabIndex = 5;
            this.buttonInsert.Text = "Insertar Datos";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // pictureBoxRed
            // 
            this.pictureBoxRed.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxRed.Image")));
            this.pictureBoxRed.Location = new System.Drawing.Point(44, 12);
            this.pictureBoxRed.Name = "pictureBoxRed";
            this.pictureBoxRed.Size = new System.Drawing.Size(155, 154);
            this.pictureBoxRed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxRed.TabIndex = 4;
            this.pictureBoxRed.TabStop = false;
            // 
            // Conexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 286);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.pictureBoxRed);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.desconectar);
            this.Controls.Add(this.conectar);
            this.Controls.Add(this.pictureBoxGreen);
            this.Name = "Conexion";
            this.Text = "Employee Database";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRed)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button conectar;
        private System.Windows.Forms.Button desconectar;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.PictureBox pictureBoxGreen;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.PictureBox pictureBoxRed;
    }
}


namespace PresentacionGui
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.PnlSuperior = new System.Windows.Forms.Panel();
            this.PnlContenedor = new System.Windows.Forms.Panel();
            this.PnlPrincipal = new System.Windows.Forms.Panel();
            this.PnlLogo = new System.Windows.Forms.Panel();
            this.BtnCotizacion = new System.Windows.Forms.Button();
            this.PnlBtnGestionarCotizacion = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.BtnGestionServicio = new System.Windows.Forms.Button();
            this.PnlBtnGestionServicio = new System.Windows.Forms.Panel();
            this.BtnConsultar = new System.Windows.Forms.Button();
            this.PnlMenu = new System.Windows.Forms.Panel();
            this.BtnPbxCerrar = new System.Windows.Forms.PictureBox();
            this.BtnPbxMaximizar = new System.Windows.Forms.PictureBox();
            this.BtnPbxRestaurar = new System.Windows.Forms.PictureBox();
            this.BtnPbxMinimizar = new System.Windows.Forms.PictureBox();
            this.PnlSuperior.SuspendLayout();
            this.PnlContenedor.SuspendLayout();
            this.PnlBtnGestionarCotizacion.SuspendLayout();
            this.PnlBtnGestionServicio.SuspendLayout();
            this.PnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnPbxCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnPbxMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnPbxRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnPbxMinimizar)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlSuperior
            // 
            this.PnlSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PnlSuperior.Controls.Add(this.BtnPbxMinimizar);
            this.PnlSuperior.Controls.Add(this.BtnPbxRestaurar);
            this.PnlSuperior.Controls.Add(this.BtnPbxMaximizar);
            this.PnlSuperior.Controls.Add(this.BtnPbxCerrar);
            this.PnlSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlSuperior.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PnlSuperior.Location = new System.Drawing.Point(0, 0);
            this.PnlSuperior.Name = "PnlSuperior";
            this.PnlSuperior.Size = new System.Drawing.Size(934, 40);
            this.PnlSuperior.TabIndex = 1;
            // 
            // PnlContenedor
            // 
            this.PnlContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.PnlContenedor.Controls.Add(this.PnlPrincipal);
            this.PnlContenedor.Controls.Add(this.PnlMenu);
            this.PnlContenedor.Controls.Add(this.PnlSuperior);
            this.PnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlContenedor.Location = new System.Drawing.Point(0, 0);
            this.PnlContenedor.Name = "PnlContenedor";
            this.PnlContenedor.Size = new System.Drawing.Size(934, 561);
            this.PnlContenedor.TabIndex = 2;
            this.PnlContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlContenedor_Paint);
            // 
            // PnlPrincipal
            // 
            this.PnlPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.PnlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlPrincipal.Location = new System.Drawing.Point(189, 40);
            this.PnlPrincipal.Name = "PnlPrincipal";
            this.PnlPrincipal.Size = new System.Drawing.Size(745, 521);
            this.PnlPrincipal.TabIndex = 0;
            // 
            // PnlLogo
            // 
            this.PnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlLogo.Location = new System.Drawing.Point(0, 0);
            this.PnlLogo.Name = "PnlLogo";
            this.PnlLogo.Size = new System.Drawing.Size(189, 153);
            this.PnlLogo.TabIndex = 1;
            // 
            // BtnCotizacion
            // 
            this.BtnCotizacion.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnCotizacion.FlatAppearance.BorderSize = 0;
            this.BtnCotizacion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.BtnCotizacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SpringGreen;
            this.BtnCotizacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCotizacion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCotizacion.ForeColor = System.Drawing.Color.DimGray;
            this.BtnCotizacion.Location = new System.Drawing.Point(0, 153);
            this.BtnCotizacion.Name = "BtnCotizacion";
            this.BtnCotizacion.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnCotizacion.Size = new System.Drawing.Size(189, 45);
            this.BtnCotizacion.TabIndex = 0;
            this.BtnCotizacion.Text = "Gestion Cotizacion";
            this.BtnCotizacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCotizacion.UseVisualStyleBackColor = true;
            this.BtnCotizacion.Click += new System.EventHandler(this.BtnCotizacion_Click);
            // 
            // PnlBtnGestionarCotizacion
            // 
            this.PnlBtnGestionarCotizacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.PnlBtnGestionarCotizacion.Controls.Add(this.button2);
            this.PnlBtnGestionarCotizacion.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlBtnGestionarCotizacion.Location = new System.Drawing.Point(0, 198);
            this.PnlBtnGestionarCotizacion.Name = "PnlBtnGestionarCotizacion";
            this.PnlBtnGestionarCotizacion.Size = new System.Drawing.Size(189, 51);
            this.PnlBtnGestionarCotizacion.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.DimGray;
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(189, 38);
            this.button2.TabIndex = 0;
            this.button2.Text = "Cotizar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtnGestionServicio
            // 
            this.BtnGestionServicio.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnGestionServicio.FlatAppearance.BorderSize = 0;
            this.BtnGestionServicio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.BtnGestionServicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SpringGreen;
            this.BtnGestionServicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGestionServicio.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGestionServicio.ForeColor = System.Drawing.Color.DimGray;
            this.BtnGestionServicio.Location = new System.Drawing.Point(0, 249);
            this.BtnGestionServicio.Name = "BtnGestionServicio";
            this.BtnGestionServicio.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnGestionServicio.Size = new System.Drawing.Size(189, 45);
            this.BtnGestionServicio.TabIndex = 3;
            this.BtnGestionServicio.Text = "Gestion Servicio";
            this.BtnGestionServicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGestionServicio.UseVisualStyleBackColor = true;
            this.BtnGestionServicio.Click += new System.EventHandler(this.button1_Click);
            // 
            // PnlBtnGestionServicio
            // 
            this.PnlBtnGestionServicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.PnlBtnGestionServicio.Controls.Add(this.BtnConsultar);
            this.PnlBtnGestionServicio.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlBtnGestionServicio.Location = new System.Drawing.Point(0, 294);
            this.PnlBtnGestionServicio.Name = "PnlBtnGestionServicio";
            this.PnlBtnGestionServicio.Size = new System.Drawing.Size(189, 50);
            this.PnlBtnGestionServicio.TabIndex = 3;
            // 
            // BtnConsultar
            // 
            this.BtnConsultar.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnConsultar.FlatAppearance.BorderSize = 0;
            this.BtnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConsultar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConsultar.ForeColor = System.Drawing.Color.DimGray;
            this.BtnConsultar.Location = new System.Drawing.Point(0, 0);
            this.BtnConsultar.Name = "BtnConsultar";
            this.BtnConsultar.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.BtnConsultar.Size = new System.Drawing.Size(189, 38);
            this.BtnConsultar.TabIndex = 0;
            this.BtnConsultar.Text = "Consultar";
            this.BtnConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConsultar.UseVisualStyleBackColor = true;
            this.BtnConsultar.Click += new System.EventHandler(this.BtnConsultar_Click);
            // 
            // PnlMenu
            // 
            this.PnlMenu.AutoScroll = true;
            this.PnlMenu.BackColor = System.Drawing.Color.Indigo;
            this.PnlMenu.Controls.Add(this.PnlBtnGestionServicio);
            this.PnlMenu.Controls.Add(this.BtnGestionServicio);
            this.PnlMenu.Controls.Add(this.PnlBtnGestionarCotizacion);
            this.PnlMenu.Controls.Add(this.BtnCotizacion);
            this.PnlMenu.Controls.Add(this.PnlLogo);
            this.PnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlMenu.Location = new System.Drawing.Point(0, 40);
            this.PnlMenu.Name = "PnlMenu";
            this.PnlMenu.Size = new System.Drawing.Size(189, 521);
            this.PnlMenu.TabIndex = 0;
            // 
            // BtnPbxCerrar
            // 
            this.BtnPbxCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnPbxCerrar.Image = ((System.Drawing.Image)(resources.GetObject("BtnPbxCerrar.Image")));
            this.BtnPbxCerrar.Location = new System.Drawing.Point(897, 6);
            this.BtnPbxCerrar.Margin = new System.Windows.Forms.Padding(0);
            this.BtnPbxCerrar.Name = "BtnPbxCerrar";
            this.BtnPbxCerrar.Size = new System.Drawing.Size(28, 28);
            this.BtnPbxCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnPbxCerrar.TabIndex = 0;
            this.BtnPbxCerrar.TabStop = false;
            this.BtnPbxCerrar.Click += new System.EventHandler(this.BtnPbxCerrar_Click);
            // 
            // BtnPbxMaximizar
            // 
            this.BtnPbxMaximizar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BtnPbxMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("BtnPbxMaximizar.Image")));
            this.BtnPbxMaximizar.Location = new System.Drawing.Point(857, 6);
            this.BtnPbxMaximizar.Margin = new System.Windows.Forms.Padding(0);
            this.BtnPbxMaximizar.Name = "BtnPbxMaximizar";
            this.BtnPbxMaximizar.Size = new System.Drawing.Size(28, 28);
            this.BtnPbxMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnPbxMaximizar.TabIndex = 1;
            this.BtnPbxMaximizar.TabStop = false;
            this.BtnPbxMaximizar.Click += new System.EventHandler(this.BtnPbxMaximizar_Click);
            // 
            // BtnPbxRestaurar
            // 
            this.BtnPbxRestaurar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BtnPbxRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("BtnPbxRestaurar.Image")));
            this.BtnPbxRestaurar.Location = new System.Drawing.Point(857, 6);
            this.BtnPbxRestaurar.Margin = new System.Windows.Forms.Padding(0);
            this.BtnPbxRestaurar.Name = "BtnPbxRestaurar";
            this.BtnPbxRestaurar.Size = new System.Drawing.Size(28, 28);
            this.BtnPbxRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnPbxRestaurar.TabIndex = 2;
            this.BtnPbxRestaurar.TabStop = false;
            this.BtnPbxRestaurar.Visible = false;
            this.BtnPbxRestaurar.Click += new System.EventHandler(this.BtnPbxRestaurar_Click);
            // 
            // BtnPbxMinimizar
            // 
            this.BtnPbxMinimizar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BtnPbxMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("BtnPbxMinimizar.Image")));
            this.BtnPbxMinimizar.Location = new System.Drawing.Point(819, 6);
            this.BtnPbxMinimizar.Margin = new System.Windows.Forms.Padding(0);
            this.BtnPbxMinimizar.Name = "BtnPbxMinimizar";
            this.BtnPbxMinimizar.Size = new System.Drawing.Size(28, 28);
            this.BtnPbxMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnPbxMinimizar.TabIndex = 3;
            this.BtnPbxMinimizar.TabStop = false;
            this.BtnPbxMinimizar.Click += new System.EventHandler(this.BtnPbxMinimizar_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 561);
            this.Controls.Add(this.PnlContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(700, 350);
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPrincipal";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.PnlSuperior.ResumeLayout(false);
            this.PnlContenedor.ResumeLayout(false);
            this.PnlBtnGestionarCotizacion.ResumeLayout(false);
            this.PnlBtnGestionServicio.ResumeLayout(false);
            this.PnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BtnPbxCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnPbxMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnPbxRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnPbxMinimizar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PnlSuperior;
        private System.Windows.Forms.Panel PnlContenedor;
        private System.Windows.Forms.Panel PnlPrincipal;
        private System.Windows.Forms.Panel PnlMenu;
        private System.Windows.Forms.Panel PnlBtnGestionServicio;
        private System.Windows.Forms.Button BtnConsultar;
        private System.Windows.Forms.Button BtnGestionServicio;
        private System.Windows.Forms.Panel PnlBtnGestionarCotizacion;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BtnCotizacion;
        private System.Windows.Forms.Panel PnlLogo;
        private System.Windows.Forms.PictureBox BtnPbxMinimizar;
        private System.Windows.Forms.PictureBox BtnPbxRestaurar;
        private System.Windows.Forms.PictureBox BtnPbxMaximizar;
        private System.Windows.Forms.PictureBox BtnPbxCerrar;
    }
}


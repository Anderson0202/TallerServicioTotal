
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
            this.PnlMenu = new System.Windows.Forms.Panel();
            this.PnlBtnGestionServicio = new System.Windows.Forms.Panel();
            this.BtnConsultar = new System.Windows.Forms.Button();
            this.BtnGestionServicio = new System.Windows.Forms.Button();
            this.PnlBtnGestionarCotizacion = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.BtnCotizacion = new System.Windows.Forms.Button();
            this.PnlLogo = new System.Windows.Forms.Panel();
            this.PnlSuperior = new System.Windows.Forms.Panel();
            this.PnlContenedor = new System.Windows.Forms.Panel();
            this.PnlPrincipal = new System.Windows.Forms.Panel();
            this.PnlMenu.SuspendLayout();
            this.PnlBtnGestionServicio.SuspendLayout();
            this.PnlBtnGestionarCotizacion.SuspendLayout();
            this.PnlContenedor.SuspendLayout();
            this.SuspendLayout();
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
            this.PnlMenu.Location = new System.Drawing.Point(0, 42);
            this.PnlMenu.Name = "PnlMenu";
            this.PnlMenu.Size = new System.Drawing.Size(189, 519);
            this.PnlMenu.TabIndex = 0;
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
            // PnlLogo
            // 
            this.PnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlLogo.Location = new System.Drawing.Point(0, 0);
            this.PnlLogo.Name = "PnlLogo";
            this.PnlLogo.Size = new System.Drawing.Size(189, 153);
            this.PnlLogo.TabIndex = 1;
            // 
            // PnlSuperior
            // 
            this.PnlSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PnlSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlSuperior.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PnlSuperior.Location = new System.Drawing.Point(0, 0);
            this.PnlSuperior.Name = "PnlSuperior";
            this.PnlSuperior.Size = new System.Drawing.Size(934, 42);
            this.PnlSuperior.TabIndex = 1;
            // 
            // PnlContenedor
            // 
            this.PnlContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.PnlContenedor.Controls.Add(this.PnlPrincipal);
            this.PnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlContenedor.Location = new System.Drawing.Point(0, 0);
            this.PnlContenedor.Name = "PnlContenedor";
            this.PnlContenedor.Size = new System.Drawing.Size(934, 561);
            this.PnlContenedor.TabIndex = 2;
            // 
            // PnlPrincipal
            // 
            this.PnlPrincipal.Location = new System.Drawing.Point(350, 178);
            this.PnlPrincipal.Name = "PnlPrincipal";
            this.PnlPrincipal.Size = new System.Drawing.Size(200, 100);
            this.PnlPrincipal.TabIndex = 0;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 561);
            this.Controls.Add(this.PnlMenu);
            this.Controls.Add(this.PnlSuperior);
            this.Controls.Add(this.PnlContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(700, 350);
            this.Name = "Principal";
            this.Text = "FrmPrincipal";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.PnlMenu.ResumeLayout(false);
            this.PnlBtnGestionServicio.ResumeLayout(false);
            this.PnlBtnGestionarCotizacion.ResumeLayout(false);
            this.PnlContenedor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlMenu;
        private System.Windows.Forms.Panel PnlBtnGestionarCotizacion;
        private System.Windows.Forms.Button BtnCotizacion;
        private System.Windows.Forms.Panel PnlLogo;
        private System.Windows.Forms.Panel PnlSuperior;
        private System.Windows.Forms.Panel PnlContenedor;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel PnlBtnGestionServicio;
        private System.Windows.Forms.Button BtnConsultar;
        private System.Windows.Forms.Button BtnGestionServicio;
        private System.Windows.Forms.Panel PnlPrincipal;
    }
}


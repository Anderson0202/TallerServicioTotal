
namespace PresentacionGui
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.PnlSuperior = new System.Windows.Forms.Panel();
            this.BtnPbxMinimizar = new System.Windows.Forms.PictureBox();
            this.BtnPbxRestaurar = new System.Windows.Forms.PictureBox();
            this.BtnPbxMaximizar = new System.Windows.Forms.PictureBox();
            this.BtnPbxCerrar = new System.Windows.Forms.PictureBox();
            this.PnlContenedor = new System.Windows.Forms.Panel();
            this.PnlPrincipal = new System.Windows.Forms.Panel();
            this.PnlMenu = new System.Windows.Forms.Panel();
            this.PnlBtnGestionServicio = new System.Windows.Forms.Panel();
            this.BtnConsultar = new System.Windows.Forms.Button();
            this.BtnGestionServicio = new System.Windows.Forms.Button();
            this.PnlBtnGestionarCotizacion = new System.Windows.Forms.Panel();
            this.BtnCotizar = new System.Windows.Forms.Button();
            this.BtnCotizacion = new System.Windows.Forms.Button();
            this.PnlLogo = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.PnlSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnPbxMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnPbxRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnPbxMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnPbxCerrar)).BeginInit();
            this.PnlContenedor.SuspendLayout();
            this.PnlMenu.SuspendLayout();
            this.PnlBtnGestionServicio.SuspendLayout();
            this.PnlBtnGestionarCotizacion.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.PnlSuperior.Size = new System.Drawing.Size(1039, 40);
            this.PnlSuperior.TabIndex = 1;
            this.PnlSuperior.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlSuperior_Paint);
            this.PnlSuperior.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PnlSuperior_MouseMove);
            // 
            // BtnPbxMinimizar
            // 
            this.BtnPbxMinimizar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BtnPbxMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("BtnPbxMinimizar.Image")));
            this.BtnPbxMinimizar.Location = new System.Drawing.Point(924, 6);
            this.BtnPbxMinimizar.Margin = new System.Windows.Forms.Padding(0);
            this.BtnPbxMinimizar.Name = "BtnPbxMinimizar";
            this.BtnPbxMinimizar.Size = new System.Drawing.Size(28, 28);
            this.BtnPbxMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnPbxMinimizar.TabIndex = 3;
            this.BtnPbxMinimizar.TabStop = false;
            this.BtnPbxMinimizar.Click += new System.EventHandler(this.BtnPbxMinimizar_Click);
            this.BtnPbxMinimizar.MouseHover += new System.EventHandler(this.BtnPbxMinimizar_MouseHover);
            this.BtnPbxMinimizar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BtnPbxMinimizar_MouseMove);
            // 
            // BtnPbxRestaurar
            // 
            this.BtnPbxRestaurar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BtnPbxRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("BtnPbxRestaurar.Image")));
            this.BtnPbxRestaurar.Location = new System.Drawing.Point(962, 6);
            this.BtnPbxRestaurar.Margin = new System.Windows.Forms.Padding(0);
            this.BtnPbxRestaurar.Name = "BtnPbxRestaurar";
            this.BtnPbxRestaurar.Size = new System.Drawing.Size(28, 28);
            this.BtnPbxRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnPbxRestaurar.TabIndex = 2;
            this.BtnPbxRestaurar.TabStop = false;
            this.BtnPbxRestaurar.Visible = false;
            this.BtnPbxRestaurar.Click += new System.EventHandler(this.BtnPbxRestaurar_Click);
            // 
            // BtnPbxMaximizar
            // 
            this.BtnPbxMaximizar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BtnPbxMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("BtnPbxMaximizar.Image")));
            this.BtnPbxMaximizar.Location = new System.Drawing.Point(962, 6);
            this.BtnPbxMaximizar.Margin = new System.Windows.Forms.Padding(0);
            this.BtnPbxMaximizar.Name = "BtnPbxMaximizar";
            this.BtnPbxMaximizar.Size = new System.Drawing.Size(28, 28);
            this.BtnPbxMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnPbxMaximizar.TabIndex = 1;
            this.BtnPbxMaximizar.TabStop = false;
            this.BtnPbxMaximizar.Click += new System.EventHandler(this.BtnPbxMaximizar_Click);
            // 
            // BtnPbxCerrar
            // 
            this.BtnPbxCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnPbxCerrar.Image = ((System.Drawing.Image)(resources.GetObject("BtnPbxCerrar.Image")));
            this.BtnPbxCerrar.Location = new System.Drawing.Point(1002, 6);
            this.BtnPbxCerrar.Margin = new System.Windows.Forms.Padding(0);
            this.BtnPbxCerrar.Name = "BtnPbxCerrar";
            this.BtnPbxCerrar.Size = new System.Drawing.Size(28, 28);
            this.BtnPbxCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnPbxCerrar.TabIndex = 0;
            this.BtnPbxCerrar.TabStop = false;
            this.BtnPbxCerrar.Click += new System.EventHandler(this.BtnPbxCerrar_Click);
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
            this.PnlContenedor.Size = new System.Drawing.Size(1039, 757);
            this.PnlContenedor.TabIndex = 2;
            this.PnlContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlContenedor_Paint);
            // 
            // PnlPrincipal
            // 
            this.PnlPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.PnlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlPrincipal.Location = new System.Drawing.Point(189, 40);
            this.PnlPrincipal.Name = "PnlPrincipal";
            this.PnlPrincipal.Size = new System.Drawing.Size(850, 717);
            this.PnlPrincipal.TabIndex = 0;
            // 
            // PnlMenu
            // 
            this.PnlMenu.AutoScroll = true;
            this.PnlMenu.BackColor = System.Drawing.Color.Indigo;
            this.PnlMenu.Controls.Add(this.panel2);
            this.PnlMenu.Controls.Add(this.button4);
            this.PnlMenu.Controls.Add(this.panel1);
            this.PnlMenu.Controls.Add(this.button1);
            this.PnlMenu.Controls.Add(this.PnlBtnGestionServicio);
            this.PnlMenu.Controls.Add(this.BtnGestionServicio);
            this.PnlMenu.Controls.Add(this.PnlBtnGestionarCotizacion);
            this.PnlMenu.Controls.Add(this.BtnCotizacion);
            this.PnlMenu.Controls.Add(this.PnlLogo);
            this.PnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlMenu.Location = new System.Drawing.Point(0, 40);
            this.PnlMenu.Name = "PnlMenu";
            this.PnlMenu.Size = new System.Drawing.Size(189, 717);
            this.PnlMenu.TabIndex = 0;
            // 
            // PnlBtnGestionServicio
            // 
            this.PnlBtnGestionServicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.PnlBtnGestionServicio.Controls.Add(this.button3);
            this.PnlBtnGestionServicio.Controls.Add(this.BtnConsultar);
            this.PnlBtnGestionServicio.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlBtnGestionServicio.Location = new System.Drawing.Point(0, 294);
            this.PnlBtnGestionServicio.Name = "PnlBtnGestionServicio";
            this.PnlBtnGestionServicio.Size = new System.Drawing.Size(189, 125);
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
            this.PnlBtnGestionarCotizacion.Controls.Add(this.BtnCotizar);
            this.PnlBtnGestionarCotizacion.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlBtnGestionarCotizacion.Location = new System.Drawing.Point(0, 198);
            this.PnlBtnGestionarCotizacion.Name = "PnlBtnGestionarCotizacion";
            this.PnlBtnGestionarCotizacion.Size = new System.Drawing.Size(189, 51);
            this.PnlBtnGestionarCotizacion.TabIndex = 2;
            // 
            // BtnCotizar
            // 
            this.BtnCotizar.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnCotizar.FlatAppearance.BorderSize = 0;
            this.BtnCotizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCotizar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCotizar.ForeColor = System.Drawing.Color.DimGray;
            this.BtnCotizar.Image = ((System.Drawing.Image)(resources.GetObject("BtnCotizar.Image")));
            this.BtnCotizar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCotizar.Location = new System.Drawing.Point(0, 0);
            this.BtnCotizar.Name = "BtnCotizar";
            this.BtnCotizar.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.BtnCotizar.Size = new System.Drawing.Size(189, 38);
            this.BtnCotizar.TabIndex = 0;
            this.BtnCotizar.Text = "Agregar Cotizacion";
            this.BtnCotizar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCotizar.UseVisualStyleBackColor = true;
            this.BtnCotizar.Click += new System.EventHandler(this.button2_Click);
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
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SpringGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DimGray;
            this.button1.Location = new System.Drawing.Point(0, 419);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(189, 45);
            this.button1.TabIndex = 4;
            this.button1.Text = "Gestion Piesas";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.panel1.Controls.Add(this.button2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 464);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(189, 50);
            this.panel1.TabIndex = 5;
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
            this.button2.Text = "Consultar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.DimGray;
            this.button3.Location = new System.Drawing.Point(0, 38);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(189, 38);
            this.button3.TabIndex = 1;
            this.button3.Text = "Facturar";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SpringGreen;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.DimGray;
            this.button4.Location = new System.Drawing.Point(0, 514);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button4.Size = new System.Drawing.Size(189, 45);
            this.button4.TabIndex = 6;
            this.button4.Text = "Gestion Agenda";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.panel2.Controls.Add(this.button5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 559);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(189, 50);
            this.panel2.TabIndex = 7;
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Top;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.DimGray;
            this.button5.Location = new System.Drawing.Point(0, 0);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button5.Size = new System.Drawing.Size(189, 38);
            this.button5.TabIndex = 0;
            this.button5.Text = "Consultar";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 757);
            this.Controls.Add(this.PnlContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(700, 350);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPrincipal";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.PnlSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BtnPbxMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnPbxRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnPbxMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnPbxCerrar)).EndInit();
            this.PnlContenedor.ResumeLayout(false);
            this.PnlMenu.ResumeLayout(false);
            this.PnlBtnGestionServicio.ResumeLayout(false);
            this.PnlBtnGestionarCotizacion.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
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
        private System.Windows.Forms.Button BtnCotizar;
        private System.Windows.Forms.Button BtnCotizacion;
        private System.Windows.Forms.Panel PnlLogo;
        private System.Windows.Forms.PictureBox BtnPbxMinimizar;
        private System.Windows.Forms.PictureBox BtnPbxRestaurar;
        private System.Windows.Forms.PictureBox BtnPbxMaximizar;
        private System.Windows.Forms.PictureBox BtnPbxCerrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
    }
}


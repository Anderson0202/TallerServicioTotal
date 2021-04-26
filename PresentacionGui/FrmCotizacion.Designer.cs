
namespace PresentacionGui
{
    partial class FrmCotizacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCotizacion));
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TCDatosCotizacion = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.CmbMarca = new System.Windows.Forms.ComboBox();
            this.CmbModelo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CmbYear = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CmbCilindraje = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.BtnCambioDeAceite = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.TCDatosCotizacion.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.AllowDrop = true;
            this.BtnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.BtnCancelar.FlatAppearance.BorderSize = 0;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.ForeColor = System.Drawing.Color.DimGray;
            this.BtnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("BtnCancelar.Image")));
            this.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCancelar.Location = new System.Drawing.Point(12, 745);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(104, 31);
            this.BtnCancelar.TabIndex = 0;
            this.BtnCancelar.Text = "CANCELAR";
            this.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "COTIZACION";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(319, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "DATOS DEL VEHICULO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(70, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Marca";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(286, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "ELIGA EL SERVICIO DESEADO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(150, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "AGENDA";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(123, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "DATOS DEL CONTACTO";
            // 
            // TCDatosCotizacion
            // 
            this.TCDatosCotizacion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TCDatosCotizacion.Controls.Add(this.tabPage1);
            this.TCDatosCotizacion.Controls.Add(this.tabPage2);
            this.TCDatosCotizacion.Controls.Add(this.tabPage3);
            this.TCDatosCotizacion.Controls.Add(this.tabPage4);
            this.TCDatosCotizacion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TCDatosCotizacion.Location = new System.Drawing.Point(39, 33);
            this.TCDatosCotizacion.Name = "TCDatosCotizacion";
            this.TCDatosCotizacion.SelectedIndex = 0;
            this.TCDatosCotizacion.Size = new System.Drawing.Size(779, 696);
            this.TCDatosCotizacion.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Indigo;
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.CmbCilindraje);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.CmbYear);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.CmbModelo);
            this.tabPage1.Controls.Add(this.CmbMarca);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.ForeColor = System.Drawing.Color.Indigo;
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(704, 318);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "VEHICULO";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.BtnCambioDeAceite);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(771, 666);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "SERVICIO";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Indigo;
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Location = new System.Drawing.Point(4, 26);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(461, 182);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "AGENDA";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.Indigo;
            this.tabPage4.Controls.Add(this.label6);
            this.tabPage4.Location = new System.Drawing.Point(4, 26);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(704, 318);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "CONTACTO";
            // 
            // CmbMarca
            // 
            this.CmbMarca.BackColor = System.Drawing.Color.Indigo;
            this.CmbMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmbMarca.ForeColor = System.Drawing.Color.DimGray;
            this.CmbMarca.FormattingEnabled = true;
            this.CmbMarca.Items.AddRange(new object[] {
            "SELECCIONE",
            "TOYOTA",
            "NISSAN",
            "MAZDA",
            "MITSUBISHI",
            "HONDA",
            "SUZUKI",
            "HYUNDAI",
            "BMW",
            "VOLKSWAGEN",
            "CHEVROLET",
            "DODGE",
            "FORD",
            "RENAULT",
            "JEEP",
            "KIA",
            "PEUGEOT",
            "SKODA",
            "SSANGYONG",
            "",
            "",
            ""});
            this.CmbMarca.Location = new System.Drawing.Point(147, 59);
            this.CmbMarca.Name = "CmbMarca";
            this.CmbMarca.Size = new System.Drawing.Size(185, 25);
            this.CmbMarca.TabIndex = 4;
            // 
            // CmbModelo
            // 
            this.CmbModelo.BackColor = System.Drawing.Color.Indigo;
            this.CmbModelo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmbModelo.ForeColor = System.Drawing.Color.DimGray;
            this.CmbModelo.FormattingEnabled = true;
            this.CmbModelo.Items.AddRange(new object[] {
            "SELECCIONE",
            "TOYOTA",
            "NISSAN",
            "MAZDA",
            "MITSUBISHI",
            "HONDA",
            "SUZUKI",
            "HYUNDAI",
            "BMW",
            "VOLKSWAGEN",
            "CHEVROLET",
            "DODGE",
            "FORD",
            "RENAULT",
            "JEEP",
            "KIA",
            "PEUGEOT",
            "SKODA",
            "SSANGYONG",
            "",
            "",
            ""});
            this.CmbModelo.Location = new System.Drawing.Point(147, 111);
            this.CmbModelo.Name = "CmbModelo";
            this.CmbModelo.Size = new System.Drawing.Size(185, 25);
            this.CmbModelo.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(64, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Modelo";
            // 
            // CmbYear
            // 
            this.CmbYear.BackColor = System.Drawing.Color.Indigo;
            this.CmbYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmbYear.ForeColor = System.Drawing.Color.DimGray;
            this.CmbYear.FormattingEnabled = true;
            this.CmbYear.Items.AddRange(new object[] {
            "SELECCIONE",
            "TOYOTA",
            "NISSAN",
            "MAZDA",
            "MITSUBISHI",
            "HONDA",
            "SUZUKI",
            "HYUNDAI",
            "BMW",
            "VOLKSWAGEN",
            "CHEVROLET",
            "DODGE",
            "FORD",
            "RENAULT",
            "JEEP",
            "KIA",
            "PEUGEOT",
            "SKODA",
            "SSANGYONG",
            "",
            "",
            ""});
            this.CmbYear.Location = new System.Drawing.Point(147, 167);
            this.CmbYear.Name = "CmbYear";
            this.CmbYear.Size = new System.Drawing.Size(185, 25);
            this.CmbYear.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(87, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 16);
            this.label8.TabIndex = 8;
            this.label8.Text = "Año";
            // 
            // CmbCilindraje
            // 
            this.CmbCilindraje.BackColor = System.Drawing.Color.Indigo;
            this.CmbCilindraje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmbCilindraje.ForeColor = System.Drawing.Color.DimGray;
            this.CmbCilindraje.FormattingEnabled = true;
            this.CmbCilindraje.Items.AddRange(new object[] {
            "SELECCIONE",
            "TOYOTA",
            "NISSAN",
            "MAZDA",
            "MITSUBISHI",
            "HONDA",
            "SUZUKI",
            "HYUNDAI",
            "BMW",
            "VOLKSWAGEN",
            "CHEVROLET",
            "DODGE",
            "FORD",
            "RENAULT",
            "JEEP",
            "KIA",
            "PEUGEOT",
            "SKODA",
            "SSANGYONG",
            "",
            "",
            ""});
            this.CmbCilindraje.Location = new System.Drawing.Point(147, 227);
            this.CmbCilindraje.Name = "CmbCilindraje";
            this.CmbCilindraje.Size = new System.Drawing.Size(185, 25);
            this.CmbCilindraje.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(48, 230);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 16);
            this.label9.TabIndex = 10;
            this.label9.Text = "Cilindraje";
            // 
            // BtnCambioDeAceite
            // 
            this.BtnCambioDeAceite.AllowDrop = true;
            this.BtnCambioDeAceite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnCambioDeAceite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.BtnCambioDeAceite.FlatAppearance.BorderSize = 0;
            this.BtnCambioDeAceite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCambioDeAceite.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCambioDeAceite.ForeColor = System.Drawing.Color.DimGray;
            this.BtnCambioDeAceite.Image = ((System.Drawing.Image)(resources.GetObject("BtnCambioDeAceite.Image")));
            this.BtnCambioDeAceite.Location = new System.Drawing.Point(46, 293);
            this.BtnCambioDeAceite.Name = "BtnCambioDeAceite";
            this.BtnCambioDeAceite.Size = new System.Drawing.Size(148, 72);
            this.BtnCambioDeAceite.TabIndex = 5;
            this.BtnCambioDeAceite.Text = "Cambio de Aceite";
            this.BtnCambioDeAceite.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnCambioDeAceite.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnCambioDeAceite.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.DimGray;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(243, 293);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 72);
            this.button2.TabIndex = 6;
            this.button2.Text = "Latoneria y Pintura";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DimGray;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(424, 293);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 72);
            this.button1.TabIndex = 7;
            this.button1.Text = "Revision por Kilometraje";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.DimGray;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(593, 293);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(148, 72);
            this.button3.TabIndex = 8;
            this.button3.Text = "Servicio de Escaner";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // FrmCotizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(867, 798);
            this.Controls.Add(this.TCDatosCotizacion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnCancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCotizacion";
            this.Text = "FrmCotizacion";
            this.TCDatosCotizacion.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabControl TCDatosCotizacion;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox CmbCilindraje;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox CmbYear;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CmbModelo;
        private System.Windows.Forms.ComboBox CmbMarca;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BtnCambioDeAceite;
    }
}

namespace PresentacionGui
{
    partial class FrmRegistrarDiagnostico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistrarDiagnostico));
            this.label10 = new System.Windows.Forms.Label();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnCambioAceite = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ComboHora = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DimGray;
            this.label10.Location = new System.Drawing.Point(283, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(167, 16);
            this.label10.TabIndex = 48;
            this.label10.Text = "REGISTRO DIAGNOSTICO";
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
            this.BtnCancelar.Location = new System.Drawing.Point(12, 398);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(104, 31);
            this.BtnCancelar.TabIndex = 61;
            this.BtnCancelar.Text = "CANCELAR";
            this.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCancelar.UseVisualStyleBackColor = false;
            // 
            // BtnCambioAceite
            // 
            this.BtnCambioAceite.AllowDrop = true;
            this.BtnCambioAceite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnCambioAceite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.BtnCambioAceite.FlatAppearance.BorderSize = 0;
            this.BtnCambioAceite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCambioAceite.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCambioAceite.ForeColor = System.Drawing.Color.DimGray;
            this.BtnCambioAceite.Image = ((System.Drawing.Image)(resources.GetObject("BtnCambioAceite.Image")));
            this.BtnCambioAceite.Location = new System.Drawing.Point(640, 366);
            this.BtnCambioAceite.Name = "BtnCambioAceite";
            this.BtnCambioAceite.Size = new System.Drawing.Size(148, 72);
            this.BtnCambioAceite.TabIndex = 60;
            this.BtnCambioAceite.Text = "GUARDAR";
            this.BtnCambioAceite.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnCambioAceite.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnCambioAceite.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(51, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 16);
            this.label1.TabIndex = 62;
            this.label1.Text = "¿Donde presenta la falla?";
            // 
            // ComboHora
            // 
            this.ComboHora.BackColor = System.Drawing.Color.Indigo;
            this.ComboHora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboHora.ForeColor = System.Drawing.Color.DimGray;
            this.ComboHora.FormattingEnabled = true;
            this.ComboHora.Items.AddRange(new object[] {
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
            this.ComboHora.Location = new System.Drawing.Point(233, 106);
            this.ComboHora.Name = "ComboHora";
            this.ComboHora.Size = new System.Drawing.Size(246, 21);
            this.ComboHora.TabIndex = 63;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(104, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 16);
            this.label2.TabIndex = 64;
            this.label2.Text = "Incluye escaner";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(233, 164);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(29, 20);
            this.textBox6.TabIndex = 65;
            // 
            // FrmRegistrarDiagnostico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ComboHora);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnCambioAceite);
            this.Controls.Add(this.label10);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRegistrarDiagnostico";
            this.Text = "FrmRegistrarDiagnostico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnCambioAceite;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ComboHora;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox6;
    }
}
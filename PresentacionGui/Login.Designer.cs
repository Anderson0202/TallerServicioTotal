
namespace PresentacionGui
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.TxUsuario = new System.Windows.Forms.TextBox();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.TxClave = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BntAcceder = new System.Windows.Forms.Button();
            this.LinkClave = new System.Windows.Forms.LinkLabel();
            this.BtnPbCerrar = new System.Windows.Forms.PictureBox();
            this.BtnPbMinimizar = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnPbCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnPbMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Indigo;
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 291);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(764, 291);
            this.shapeContainer1.TabIndex = 1;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape1.Enabled = false;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 329;
            this.lineShape1.X2 = 651;
            this.lineShape1.Y1 = 91;
            this.lineShape1.Y2 = 91;
            this.lineShape1.Click += new System.EventHandler(this.lineShape1_Click);
            // 
            // TxUsuario
            // 
            this.TxUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.TxUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxUsuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxUsuario.ForeColor = System.Drawing.Color.DimGray;
            this.TxUsuario.Location = new System.Drawing.Point(329, 65);
            this.TxUsuario.Name = "TxUsuario";
            this.TxUsuario.Size = new System.Drawing.Size(343, 20);
            this.TxUsuario.TabIndex = 1;
            this.TxUsuario.Text = "USUARIO";
            this.TxUsuario.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.TxUsuario.Enter += new System.EventHandler(this.TxUsuario_Enter);
            this.TxUsuario.Leave += new System.EventHandler(this.TxUsuario_Leave);
            // 
            // lineShape2
            // 
            this.lineShape2.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape2.Enabled = false;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 330;
            this.lineShape2.X2 = 652;
            this.lineShape2.Y1 = 154;
            this.lineShape2.Y2 = 154;
            this.lineShape2.Click += new System.EventHandler(this.lineShape1_Click);
            // 
            // TxClave
            // 
            this.TxClave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.TxClave.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxClave.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxClave.ForeColor = System.Drawing.Color.DimGray;
            this.TxClave.Location = new System.Drawing.Point(329, 129);
            this.TxClave.Name = "TxClave";
            this.TxClave.Size = new System.Drawing.Size(325, 20);
            this.TxClave.TabIndex = 2;
            this.TxClave.Text = "CLAVE";
            this.TxClave.Enter += new System.EventHandler(this.TxClave_Enter);
            this.TxClave.Leave += new System.EventHandler(this.TxClave_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(454, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "LOGIN";
            // 
            // BntAcceder
            // 
            this.BntAcceder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BntAcceder.FlatAppearance.BorderSize = 0;
            this.BntAcceder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.BntAcceder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BntAcceder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BntAcceder.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BntAcceder.ForeColor = System.Drawing.Color.LightGray;
            this.BntAcceder.Location = new System.Drawing.Point(331, 199);
            this.BntAcceder.Name = "BntAcceder";
            this.BntAcceder.Size = new System.Drawing.Size(323, 40);
            this.BntAcceder.TabIndex = 3;
            this.BntAcceder.Text = "ACCEDER";
            this.BntAcceder.UseVisualStyleBackColor = false;
            this.BntAcceder.Click += new System.EventHandler(this.BntAcceder_Click);
            // 
            // LinkClave
            // 
            this.LinkClave.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.LinkClave.AutoSize = true;
            this.LinkClave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.LinkClave.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkClave.LinkColor = System.Drawing.Color.DimGray;
            this.LinkClave.Location = new System.Drawing.Point(411, 267);
            this.LinkClave.Name = "LinkClave";
            this.LinkClave.Size = new System.Drawing.Size(161, 17);
            this.LinkClave.TabIndex = 0;
            this.LinkClave.TabStop = true;
            this.LinkClave.Text = "¿Ha olvidado la clave?";
            // 
            // BtnPbCerrar
            // 
            this.BtnPbCerrar.Image = ((System.Drawing.Image)(resources.GetObject("BtnPbCerrar.Image")));
            this.BtnPbCerrar.Location = new System.Drawing.Point(737, 12);
            this.BtnPbCerrar.Name = "BtnPbCerrar";
            this.BtnPbCerrar.Size = new System.Drawing.Size(15, 15);
            this.BtnPbCerrar.TabIndex = 7;
            this.BtnPbCerrar.TabStop = false;
            this.BtnPbCerrar.Click += new System.EventHandler(this.BtnPbCerrar_Click);
            // 
            // BtnPbMinimizar
            // 
            this.BtnPbMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("BtnPbMinimizar.Image")));
            this.BtnPbMinimizar.Location = new System.Drawing.Point(716, 12);
            this.BtnPbMinimizar.Name = "BtnPbMinimizar";
            this.BtnPbMinimizar.Size = new System.Drawing.Size(15, 15);
            this.BtnPbMinimizar.TabIndex = 8;
            this.BtnPbMinimizar.TabStop = false;
            this.BtnPbMinimizar.Click += new System.EventHandler(this.BtnPbMinimizar_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(60, 91);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(130, 121);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(764, 291);
            this.Controls.Add(this.BtnPbMinimizar);
            this.Controls.Add(this.BtnPbCerrar);
            this.Controls.Add(this.LinkClave);
            this.Controls.Add(this.BntAcceder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxClave);
            this.Controls.Add(this.TxUsuario);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Login_MouseDown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BtnPbCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnPbMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.TextBox TxUsuario;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private System.Windows.Forms.TextBox TxClave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BntAcceder;
        private System.Windows.Forms.LinkLabel LinkClave;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox BtnPbCerrar;
        private System.Windows.Forms.PictureBox BtnPbMinimizar;
    }
}
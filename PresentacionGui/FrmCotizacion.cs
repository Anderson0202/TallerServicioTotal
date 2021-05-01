using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentacionGui
{
    public partial class FrmCotizacion : Form
    {
        public FrmCotizacion()
        {
            InitializeComponent();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lineShape1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void BtnCambioDeAceite_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void BtnCambioBateria_Click(object sender, EventArgs e)
        {

        }

        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = Controls.OfType<MiForm>().FirstOrDefault();//Busca en la colecion el formulario                                                                     //si el formulario/instancia no existe
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                
                formulario.Show();
                formulario.BringToFront();
                formulario.FormClosed += new FormClosedEventHandler(CerrarFormularios);
            }
            //si el formulario/instancia existe
            else
            {
                formulario.BringToFront();
            }
        }

        private void CerrarFormularios(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms["FrmCotizacion"] == null)
            {
                BtnDiagnosticarFalla.BackColor = Color.FromArgb(15, 15, 15);
                
            }
        }
        private void BtnDiagnosticarFalla_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmDiagnostico>();
            BtnDiagnosticarFalla.BackColor = Color.FromArgb(32, 178, 170);
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}

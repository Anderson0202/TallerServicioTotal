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
            formulario = PnlDiagnosticar.Controls.OfType<MiForm>().FirstOrDefault();//Busca en la colecion el formulario                                                                     //si el formulario/instancia no existe
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                PnlDiagnosticar.Controls.Add(formulario);
                PnlDiagnosticar.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
                PnlDiagnosticar.BringToFront();
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
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void BtnDiagnosticarFalla_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario<FrmRegistrarDiagnostico>();
            BtnDiagnosticarFalla.BackColor = Color.FromArgb(32, 178, 170);
            BtnVolver.Visible = true;
            PnlDiagnosticar.Visible = true;
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            PnlDiagnosticar.Visible = false;
            BtnDiagnosticarFalla.BackColor = Color.FromArgb(15, 15, 15);
        }

        private void BtnSiguiente_Click(object sender, EventArgs e)
        {

            if (TpVehiculo.ContainsFocus)
            {
                TpServicio.Focus();
            }
            else if (TpServicio.Focused)
            {
                TpAgenda.Focus();
            }
            else if (TpAgenda.Focused)
            {
                TpContacto.Focus();
            }
            else if (TpContacto.Focused)
            {
                TpVehiculo.Focus();
            }
            

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace PresentacionGui
{
    public partial class FrmLogin : Form
    {
        FrmPrincipal Principal;
        public FrmLogin()
        {
            InitializeComponent();
            Principal = new FrmPrincipal();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void lineShape1_Click(object sender, EventArgs e)
        {

        }

        private void TxUsuario_Enter(object sender, EventArgs e)
        {
            if (TxUsuario.Text == "USUARIO")
            {
                TxUsuario.Text = "";
                TxUsuario.ForeColor = Color.LightGray;
            }
        }

        private void TxUsuario_Leave(object sender, EventArgs e)
        {
            if (TxUsuario.Text == "")
            {
                TxUsuario.Text = "USUARIO";
                TxUsuario.ForeColor = Color.DimGray;
            }
        }

        private void TxClave_Leave(object sender, EventArgs e)
        {
            if (TxClave.Text == "")
            {
                TxClave.Text = "CLAVE";
                TxClave.ForeColor = Color.DimGray;
                TxClave.UseSystemPasswordChar = false;
            }
        }

        private void TxClave_Enter(object sender, EventArgs e)
        {
            if (TxClave.Text == "CLAVE")
            {
                TxClave.Text = "";
                TxClave.ForeColor = Color.LightGray;
                TxClave.UseSystemPasswordChar = true;
            }
        }

        private void BtnPbCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnPbMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BntAcceder_Click(object sender, EventArgs e)
        {
            if (Vacio())
            {
                if (TxUsuario.Text.Equals("A"))
                {
                    if (TxClave.Text.Equals("C"))
                    {
                        Principal.Visible = true;
                        this.Visible = false;
                    }
                    else
                    {
                        Mensaje("Clave Incorrecta - Intente nuevamente -");
                    }
                }
                else
                {
                    Mensaje("Usuario Incorrecto  - Intente nuevamente -");
                }
            }

        }

        private bool Vacio()
        {
            try
            {
                if (TxUsuario.Text.Equals("USUARIO"))
                {
                    Mensaje("Ingrese el Usuario");
                    return false;
                }
                else if (TxClave.Text.Equals("CLAVE"))
                {
                    Mensaje("Ingrese la Clave");
                    return false;
                }
                return true;

            }
            catch (Exception e)
            {

                Mensaje("Ingrese usuario o clave" + e.Message);
                return false;
            }
        }

        public void Mensaje(string txt)
        {
            MessageBox.Show(txt, "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

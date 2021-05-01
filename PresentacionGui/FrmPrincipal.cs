using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentacionGui
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            EsconderSubMenus();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true;
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            //no tocar
        }

        #region Funcionalidades de form
        private void EsconderSubMenus()
        {
            PnlBtnGestionarCotizacion.Visible = false;
            PnlBtnGestionServicio.Visible = false;
            PnlPiesas.Visible = false;
            PnlDiagnostico.Visible = false;
            PnlMecanico.Visible = false;
            PnlAgenda.Visible = false;
        }

        private void MostrarSubMenus(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                EsconderSubMenus();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        #region Botones_Principales_Menu
        private void BtnCotizacion_Click(object sender, EventArgs e)
        {
            MostrarSubMenus(PnlBtnGestionarCotizacion);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MostrarSubMenus(PnlBtnGestionServicio);
        }
        #endregion
        #region Botones_Secundarios_SubMenu
        private void button2_Click(object sender, EventArgs e)
        {
            //escribi sobre este metodo
            AbrirFormulario<FrmCotizacion>();
            BtnCotizar.BackColor = Color.FromArgb(32, 178, 170);
            EsconderSubMenus();
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            //escribi sobre este metodo
            EsconderSubMenus();
        }


        #endregion
        #region Botones_BarraSuperior_y_Redimencion
        private void PnlContenedor_Paint(object sender, PaintEventArgs e)
        {

        }
        //RESIZE METODO PARA REDIMENCIONAR/CAMBIAR TAMAÑO A FORMULARIO EN TIEMPO DE EJECUCION 
        //----------------------------------------------------------
        private int tolerance = 12;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        //DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));
            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);
            region.Exclude(sizeGripRectangle);
            this.PnlContenedor.Region = region;
            this.Invalidate();
        }
        //COLOR Y GRIP DE RECTANGULO INFERIOR
        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(15, 15, 15));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);
            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Indigo, sizeGripRectangle);
        }

        private void BtnPbxCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        int lx, ly;
        int sw, sh;

        private void BtnPbxMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnPbxMaximizar_Click(object sender, EventArgs e)
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;
            BtnPbxMaximizar.Visible = false;
            BtnPbxRestaurar.Visible = true;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }

        private void BtnPbxRestaurar_Click(object sender, EventArgs e)
        {
            BtnPbxMaximizar.Visible = true;
            BtnPbxRestaurar.Visible = false;
            this.Size = new Size(sw, sh);
            this.Location = new Point(lx, ly);
        }
        #endregion

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void PnlSuperior_Paint(object sender, PaintEventArgs e)
        {
            //no tocar
        }
        private void PnlSuperior_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        private void BtnPbxMinimizar_MouseHover(object sender, EventArgs e){/*no tocar*/}
        private void BtnPbxMinimizar_MouseMove(object sender, MouseEventArgs e){/*no tocar*/}

        private void button7_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmDiagnostico>();
            BtnConsultarDiagnostico.BackColor = Color.FromArgb(32, 178, 170);
            EsconderSubMenus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmFacturar>();
            button3.BackColor = Color.FromArgb(32, 178, 170);
            EsconderSubMenus();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmRegistrarDiagnostico>();
            BtnConsultarAgenda.BackColor = Color.FromArgb(32, 178, 170);
            EsconderSubMenus();
        }

        private void PnlBtnGestionServicio_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnPiesas_Click(object sender, EventArgs e)
        {
            MostrarSubMenus(PnlPiesas);
        }

        private void BtnAgenda_Click(object sender, EventArgs e)
        {
            MostrarSubMenus(PnlAgenda);
        }

        private void BtnDiagnostico_Click(object sender, EventArgs e)
        {
            MostrarSubMenus(PnlDiagnostico);
        }

        private void BtnMecanico_Click(object sender, EventArgs e)
        {
            MostrarSubMenus(PnlMecanico);
        }

        private void BtnConsultarAgenda_Click(object sender, EventArgs e)
        {

            AbrirFormulario<FrmConsultarAgenda>();
            BtnConsultarAgenda.BackColor = Color.FromArgb(32, 178, 170);
            EsconderSubMenus();
        }

        private void BtnConsultarMecanico_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmConsultarMecanico>();
            BtnConsultarAgenda.BackColor = Color.FromArgb(32, 178, 170);
            EsconderSubMenus();
        }

        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = PnlPrincipal.Controls.OfType<MiForm>().FirstOrDefault();//Busca en la colecion el formulario                                                                     //si el formulario/instancia no existe
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                PnlPrincipal.Controls.Add(formulario);
                PnlPrincipal.Tag = formulario;
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
                BtnCotizar.BackColor = Color.FromArgb(15, 15, 15);
                button3.BackColor = Color.FromArgb(15, 15, 15);
                BtnConsultarDiagnostico.BackColor = Color.FromArgb(15, 15, 15);
                BtnConsultarAgenda.BackColor = Color.FromArgb(15, 15, 15);
                BtnConsultarMecanico.BackColor = Color.FromArgb(15, 15, 15);
                BtnConsultar.BackColor = Color.FromArgb(15, 15, 15);
                BtnConsultarPiesa.BackColor = Color.FromArgb(15, 15, 15);
                
            }
        }


    }
}

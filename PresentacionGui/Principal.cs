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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
            EsconderSubMenus();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            //no tocar
        }

        private void EsconderSubMenus()
        {
            PnlBtnGestionarCotizacion.Visible = false;
            PnlBtnGestionServicio.Visible = false;
            
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
        #region Botones_Secundarios_Menu
        private void button2_Click(object sender, EventArgs e)
        {
            //escribi sobre este metodo
            EsconderSubMenus();
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            //escribi sobre este metodo
            EsconderSubMenus();
        }
        #endregion

        

    }
}

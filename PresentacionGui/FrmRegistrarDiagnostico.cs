﻿using System;
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
    public partial class FrmRegistrarDiagnostico : Form
    {
        public FrmRegistrarDiagnostico()
        {
            InitializeComponent();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
